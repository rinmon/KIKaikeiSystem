using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.query
{
    class KamokuKubunSummary
    {
        // 年度ごとの金額
        public class SummaryRow
        {
            public int KamokuKubunId;
            public long KarikataAmount; //借方金額
            public long KashikataAmount; // 貸方金額


            public SummaryRow(int id_, long karikatAmoujnt, long kashikataAmount) {
                KamokuKubunId = id_;
                AddAmount(karikatAmoujnt, kashikataAmount);
            }

            public void AddAmount(long karikataAmount, long kashikataAmount){
                this.KarikataAmount += karikataAmount;
                this.KashikataAmount += kashikataAmount;
            }

            public void AddAmount(SummaryRow row) {
                this.KarikataAmount += row.KarikataAmount;
                this.KashikataAmount += row.KashikataAmount;
            }

            public long GetTaisyaku(models.db.KaikeiDatabase db) {
                models.db.Row kamokuKubunRow = db.MTKamokuKubun.GetFirstRow("where id=" + KamokuKubunId);
                if (kamokuKubunRow == null) {
                    return 0;
                }
                int kanjouKamokuId = (int)kamokuKubunRow.GetLong("kanjou_kamoku_id", -1);
                models.db.Row kanjouKamokuRow = db.MTKanjouKamoku.GetFirstRow("where id=" + kanjouKamokuId);
                if (kanjouKamokuRow == null) {
                    return 0;
                }
                int taisyakuKubunId = (int)kanjouKamokuRow.GetLong("taisyaku_kubun_id", -1);

                if (taisyakuKubunId == (int)models.constants.MTTaisyakuKubun.KariPlus || taisyakuKubunId == (int)models.constants.MTTaisyakuKubun.KariMinus) {
                    return KarikataAmount - KashikataAmount;
                }
                else {
                    return KashikataAmount - KarikataAmount;
                }
            }
        };

        
        private db.KaikeiDatabase db;
        private Dictionary<int, SummaryRow> kamokuKubunSummaryTable;
        private SummaryRow dummyRow;

        public delegate void OnAddDenpyouDelegate(int kamokuKubunId, long karikataKingaku, long kashikataKingaku, models.db.Row denpyouRow);
        public event OnAddDenpyouDelegate OnAddDenpyou;
        public Dictionary<int, bool> ObserveKamokuKubunList{get;private set;}


        public KamokuKubunSummary(db.KaikeiDatabase aDB) {
            db = aDB;

            kamokuKubunSummaryTable = new Dictionary<int, SummaryRow>();
            dummyRow = new SummaryRow(-1, 0, 0);
            ObserveKamokuKubunList = new Dictionary<int, bool>();
            OnAddDenpyou = null;
        }


        public DateTime StartDate {
            get;
            private set;
        }

        public DateTime EndDate {
            get;
            private set;
        }

        public int KaikeiKubun{
            get;
            private set;
        }

        public bool AddZenkiKurikoshi {
            get;
            private set;
        }

        public bool AddPairedShikinDenpyou {
            get;
            private set;
        }

        public SummaryRow SummaryItem(int kamokuKubunId) {
            if (kamokuKubunSummaryTable.ContainsKey(kamokuKubunId)) {
                return kamokuKubunSummaryTable[kamokuKubunId];
            }
            else {
                return dummyRow;
            }
        }

        private void AddKanjouKamokuAmountToSummaryItem(int kanjouKamokuId, int torihikiKubunId, long karikataAmount, long kashikataAmount, models.db.Row denpyouRow) {
            if (kanjouKamokuId == -1 || kanjouKamokuId == 0) {
                return;
            }

            models.db.Row kanjouKamokuRow = db.MTKanjouKamoku.GetFirstRow("where id = " + kanjouKamokuId);

            int jigyouKamokuKubunId = (int)kanjouKamokuRow.GetLong("jigyou_kamoku_kubun_id", -1);
            int shikinKamokuKubunId = (int)kanjouKamokuRow.GetLong("shikin_kamoku_kubun_id", -1);
            int taisyakuKamokuKubunId = (int)kanjouKamokuRow.GetLong("taisyaku_kamoku_kubun_id", -1);
            if (torihikiKubunId == (int)models.constants.MTTorihikiKubun.Jigyou) {
                AddKamokuKubunAmountToSummaryItem(jigyouKamokuKubunId, karikataAmount, kashikataAmount, denpyouRow);
            }
            else if (torihikiKubunId == (int)models.constants.MTTorihikiKubun.Shikin) {
                AddKamokuKubunAmountToSummaryItem(shikinKamokuKubunId, karikataAmount, kashikataAmount, denpyouRow);
            }
            AddKamokuKubunAmountToSummaryItem(taisyakuKamokuKubunId, karikataAmount, kashikataAmount, denpyouRow);

            // 補助科目の場合は、小区分についても合計する    
            if ((int)kanjouKamokuRow.GetLong("hierarchy", -1) == (int)models.constants.MTKanjouKamokuHierarchy.HojoKamoku) {
                AddKanjouKamokuAmountToSummaryItem((int)kanjouKamokuRow.GetLong("parent_id", -1), torihikiKubunId, karikataAmount, kashikataAmount, denpyouRow);
            }
        }

        private void AddKamokuKubunAmountToSummaryItem(int kamokuKubunId, long karikataAmount, long kashikataAmount, models.db.Row denpyouRow) {
            if (kamokuKubunId == -1) {
                return;
            }

            if (!kamokuKubunSummaryTable.ContainsKey(kamokuKubunId)) {
                kamokuKubunSummaryTable[kamokuKubunId] = new SummaryRow(kamokuKubunId, karikataAmount, kashikataAmount);
            }
            else {
                kamokuKubunSummaryTable[kamokuKubunId].AddAmount(karikataAmount, kashikataAmount);
            }

            if (OnAddDenpyou != null && ObserveKamokuKubunList.ContainsKey(kamokuKubunId)) {
                OnAddDenpyou(kamokuKubunId, karikataAmount, kashikataAmount, denpyouRow);
            }
        }

        public void Calc(DateTime startDate, DateTime endDate, int kaikeiKubun, bool addKurikoshi, bool addPairedShikinDenpyou){
            StartDate = startDate;
            EndDate = endDate;
            KaikeiKubun = kaikeiKubun;
            AddZenkiKurikoshi = addKurikoshi;
            AddPairedShikinDenpyou = addPairedShikinDenpyou;

            kamokuKubunSummaryTable.Clear();

            SummarizeMeisaiTable();
            if (AddZenkiKurikoshi) {
                AddKurikoshi();
            }
        }

        public void CalcKurikoshi(int year, int kaikeiKubun) {
            StartDate = helper.Helper.GetNenndoKisanbi(year);
            EndDate = helper.Helper.GetNenndoKimatsubi(year);
            KaikeiKubun = kaikeiKubun;
            AddZenkiKurikoshi = true;
            AddPairedShikinDenpyou = false;

            AddKurikoshi();
        }


        private void SummarizeMeisaiTable() {
            string sql = string.Format("where {0} <= kihyoubi and kihyoubi <= {1} ",
                            helper.Converter.DateTimeToInt(StartDate),
                            helper.Converter.DateTimeToInt(EndDate));

            foreach (var row in db.KaikeiDenpyouMeisai.Select(sql)) {
                if(!db.MTKaikeiKubun.IsChildOf((int)row.GetLong("kaikei_kubun", -1), KaikeiKubun)){
                    continue;
                }
                if (AddPairedShikinDenpyou == false) {
                    if (db.KaikeiDenpyouMeisai.IsPairedShikinRow(row)) {
                        continue;
                    }
                }
                long amount = row.GetLong("karikata_kingaku", 0);
                int torihikiKubunId = (int)row.GetLong("torihiki_kubun", -1);

                AddKanjouKamokuAmountToSummaryItem((int)row.GetLong("karikata_kamoku_id", -1), torihikiKubunId, amount, 0, row);
                AddKanjouKamokuAmountToSummaryItem((int)row.GetLong("kashikata_kamoku_id", -1), torihikiKubunId, 0, amount, row);
                AddKanjouKamokuAmountToSummaryItem((int)row.GetLong("karikata_hojo_id", -1), torihikiKubunId, amount, 0, row);
                AddKanjouKamokuAmountToSummaryItem((int)row.GetLong("kashikata_hojo_id", -1), torihikiKubunId, 0, amount, row);
            }
        }

        private void AddKurikoshi() {
            string sql = "where nenndo=" + StartDate.Year;

            foreach (var row in db.ZenkiKurikoshiKamokuKubun.Select(sql)){
                if(!db.MTKaikeiKubun.IsChildOf((int)row.GetLong("kaikei_kubun_id", -1), KaikeiKubun)){
                    continue;
                }
                int kamokuKubunId = (int)row.GetLong("kamoku_kubun_id", 0);
                models.db.Row kamokuKubunRow = db.MTKamokuKubun.GetFirstRow("where id=" + kamokuKubunId);
                if(kamokuKubunRow == null){
                    continue;
                }
                int kanjouKamokuId = (int)kamokuKubunRow.GetLong("kanjou_kamoku_id", -1);
                models.db.Row kanjouKamokuRow = db.MTKanjouKamoku.GetFirstRow("where id=" + kanjouKamokuId);
                if(kanjouKamokuRow == null){
                    continue;
                }
                int taisyakuKubunId = (int)kanjouKamokuRow.GetLong("taisyaku_kubun_id", -1);

                long amount = row.GetLong("zenki_kurikoshi_gaku", 0);
                long karikataAmount = 0;
                long kashikataAmount = 0;
                if (taisyakuKubunId == (int)models.constants.MTTaisyakuKubun.KariPlus || taisyakuKubunId == (int)models.constants.MTTaisyakuKubun.KariMinus) {
                    karikataAmount = amount;
                }
                else{
                    kashikataAmount = amount;
                }

                AddKamokuKubunAmountToSummaryItem(kamokuKubunId, karikataAmount, kashikataAmount, row);
            }
        }

    }
}
