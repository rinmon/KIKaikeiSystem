using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.query
{
    class BalanceSheet
    {
        public enum SummaryItem {
            ShisanSummary = 0,
            HusaiPlusJunshisanSummary = 1,
            HusaiSummary = 2,
            JunshisanSummary = 3,
            JikiKurikoshiSagaku = 4,
            ToukiSagaku = 5,
        };

        public class BalanceSheetRow
        {
            public int Id{get;set;}         // 科目区分ID
            public int DaikubunId { get; set; }
            public int TaisyakuKamokuKubunId;
            public long CurrentSumAmount{get;set;}
            public long LastSumAmount{get;set;}
            public long Sai { get { return CurrentSumAmount - LastSumAmount; } }
            public long GetTaisyaku() {
                return CurrentSumAmount + LastSumAmount;
            }

            public BalanceSheetRow(int id_, int daikubunId, int taisyakuKamokuKubunId) {
                Id = id_;
                DaikubunId = daikubunId;
                TaisyakuKamokuKubunId = taisyakuKamokuKubunId;
                CurrentSumAmount = 0;
                LastSumAmount = 0;
            }

            public void Add(BalanceSheetRow row){
                CurrentSumAmount += row.CurrentSumAmount;
                LastSumAmount += row.LastSumAmount;
            }

            public void Substract(BalanceSheetRow row) {
                CurrentSumAmount -= row.CurrentSumAmount;
                LastSumAmount -= row.LastSumAmount;
            }

            public void DainyuuAMinusB(BalanceSheetRow a, BalanceSheetRow b) {
                this.Add(a);
                this.Substract(b);
            }
        };

        
        private db.KaikeiDatabase db;
        private query.KamokuKubunSummary kamokuKubunSummary;
        private Dictionary<int, BalanceSheetRow> kamokuKubunId2BalanceSheetRow;
        private Dictionary<int, BalanceSheetRow> kamokuKubunId2BalanceSheetRowWithoutKurikoshi;
        private Dictionary<SummaryItem, BalanceSheetRow> summaryItems;


        public BalanceSheet(db.KaikeiDatabase aDB) {
            db = aDB;

            kamokuKubunId2BalanceSheetRow = new Dictionary<int, BalanceSheetRow>();
            kamokuKubunId2BalanceSheetRowWithoutKurikoshi = new Dictionary<int, BalanceSheetRow>();
            summaryItems = new Dictionary<SummaryItem, BalanceSheetRow>();
        }

        public int StartNenndo {
            get;
            private set;
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

        public int KaikeiKubunHierarchy {
            get;
            private set;
        }

        public bool HideInnerKaikeiKubunKamoku {
            get;
            private set;
        }

        public BalanceSheetRow GetSummaryItem(SummaryItem item) {
            return summaryItems[item];
        }

        public BalanceSheetRow GetBalanceSheetRow(int kamokuKubunId) {
            if (kamokuKubunId2BalanceSheetRow.ContainsKey(kamokuKubunId)) {
                return kamokuKubunId2BalanceSheetRow[kamokuKubunId];
            }
            return null;
        }

        public IEnumerable<BalanceSheetRow> AllKamokuSummary() {
            foreach (var row in db.MTKamokuKubun.Select("order by display_order")) {
                int id = (int)row.GetLong("id", 0);
                if (!kamokuKubunId2BalanceSheetRow.ContainsKey(id)) {
                    continue;
                }
                yield return kamokuKubunId2BalanceSheetRow[id];
            }
        }


        public List<BalanceSheetRow> GetChildrenList(int parentId){
            var result = new List<BalanceSheetRow>();

            foreach(var row in AllKamokuSummary()){
                if(row.TaisyakuKamokuKubunId == parentId){
                    result.Add(row);
                }
            }

            return result;
        }


        public void Calc(DateTime startDate, DateTime endDate, int kaikeiKubun, bool hideInnerKaikeiKubunKamoku){
            StartDate = helper.Converter.DateTimeToNenndoKisannbi(startDate);
            StartNenndo = startDate.Year;
            EndDate = endDate;
            KaikeiKubun = kaikeiKubun == -1 ? db.MTKaikeiKubun.RootNodeId : kaikeiKubun;
            KaikeiKubunHierarchy = (int)db.MTKaikeiKubun.GetHierarchyOf(kaikeiKubun);
            HideInnerKaikeiKubunKamoku = hideInnerKaikeiKubunKamoku;

            // init summary items
            summaryItems.Clear();
            foreach (SummaryItem item in Enum.GetValues(typeof(SummaryItem))) {
                summaryItems[item] = new BalanceSheetRow(0, 0, 0);
            }

            kamokuKubunId2BalanceSheetRow.Clear();
            
            kamokuKubunSummary = new KamokuKubunSummary(db);
            kamokuKubunSummary.Calc(startDate, endDate, kaikeiKubun, addKurikoshi:false, addPairedShikinDenpyou:true);

            SummarizeMeisaiTable();
            SummarizeKurikoshi();

            CalcSummary();
        }


        private void SummarizeMeisaiTable() {
            string orderStr = "order by display_order";

            foreach (models.db.Row kubunRow in db.MTKamokuKubun.SelectChildren((int)models.constants.MTKamokuKubun.TaisyakuRoot, order: orderStr)) {
                foreach (models.db.Row daikubunRow in db.MTKamokuKubun.SelectChildren(kubunRow.GetId(), order: orderStr)) {
                    if (daikubunRow.GetId() == (int)models.constants.MTKamokuKubun.JikiKurikoshikatsudouZougenSagakuDaikubun) {
                        continue;
                    }

                    foreach (models.db.Row kamokuRow in db.MTKamokuKubun.SelectChildren(daikubunRow.GetId(), order: orderStr)) {
                        if (HideInnerKaikeiKubunKamoku && db.MTKamokuKubun.IsInnerKaikeiKubunKamoku(KaikeiKubunHierarchy, kamokuRow)) {
                            continue;
                        }

                        BalanceSheetRow balanceSheetRow = new BalanceSheetRow(kamokuRow.GetId(), daikubunRow.GetId(), kubunRow.GetId());
                        balanceSheetRow.CurrentSumAmount = kamokuKubunSummary.SummaryItem(kamokuRow.GetId()).GetTaisyaku(db);
                        balanceSheetRow.LastSumAmount = 0;
                        kamokuKubunId2BalanceSheetRow.Add(kamokuRow.GetId(), balanceSheetRow);
                    }
                }
            }
        }


        private void SummarizeKurikoshi() {
            foreach (var row in db.ZenkiKurikoshiKamokuKubun.Select("where nenndo=" + StartNenndo)) {
                if (db.MTKaikeiKubun.IsChildOf((int)row.GetLong("kaikei_kubun_id", -1), KaikeiKubun) == false) {
                    continue;
                }

                int kamokuKubunId = (int)row.GetLong("kamoku_kubun_id", -1);
                long kurikoshi = row.GetLong("zenki_kurikoshi_gaku", 0);

                if (kamokuKubunId == (int)constants.MTKamokuKubun.JikiKurikoshikatsudouZougenSagakuChukubun) {
                    summaryItems[SummaryItem.JikiKurikoshiSagaku].LastSumAmount += kurikoshi;
                }
                else if (kamokuKubunId != -1) {
                    if (kamokuKubunId2BalanceSheetRow.ContainsKey(kamokuKubunId)) {
                        //kamokuKubunId2BalanceSheetRow[kamokuKubunId].CurrentSumAmount += kurikoshi;
                        kamokuKubunId2BalanceSheetRow[kamokuKubunId].LastSumAmount += kurikoshi;
                    }
                }
            }
        }


        private long CalcJikiKurikoshiSagaku(int year, int kaikeiKubun) {
            long value = 0;
            string sql = "where nenndo=" + year + " and kamoku_kubun_id=" + ((int)constants.MTKamokuKubun.JikiKurikoshikatsudouZougenSagakuChukubun);

            foreach (var row in db.ZenkiKurikoshiKamokuKubun.Select(sql)) {
                if (db.MTKaikeiKubun.IsChildOf(childId: (int)row.GetLong("kaikei_kubun_id", -1), parentId: kaikeiKubun) == false) {
                    continue;
                }

                value += row.GetLong("zenki_kurikoshi_gaku", 0);
            }

            return value;
        }


        private void CalcSummary() {
            int year = helper.Converter.GetNenndo(StartDate);

            foreach (var pair in kamokuKubunId2BalanceSheetRow) {
                switch (pair.Value.TaisyakuKamokuKubunId) {
                    case (int)models.constants.MTKamokuKubun.Shisan:     //資産
                        summaryItems[SummaryItem.ShisanSummary].Add(pair.Value);
                        break;
                    case (int)models.constants.MTKamokuKubun.Husai:      //負債
                        summaryItems[SummaryItem.HusaiSummary].Add(pair.Value);
                        break;
                    case (int)models.constants.MTKamokuKubun.Junshisan:  //純資産
                        summaryItems[SummaryItem.JunshisanSummary].Add(pair.Value);
                        break;
                }
            }

            //負債＋純資産 (この段階では、次期繰越を含まない)
            summaryItems[SummaryItem.HusaiPlusJunshisanSummary].Add(summaryItems[SummaryItem.JunshisanSummary]);
            summaryItems[SummaryItem.HusaiPlusJunshisanSummary].Add(summaryItems[SummaryItem.HusaiSummary]);

            //次期繰越活動収支差額(本年)
            summaryItems[SummaryItem.JikiKurikoshiSagaku].CurrentSumAmount = summaryItems[SummaryItem.JikiKurikoshiSagaku].LastSumAmount
                                                                           + summaryItems[SummaryItem.ShisanSummary].CurrentSumAmount
                                                                           - summaryItems[SummaryItem.HusaiPlusJunshisanSummary].CurrentSumAmount;

            //次期繰越活動収支差額(昨年)
            {
                //AddKurikoshiで計算
            }

            {

                // うち当期活動収支差額(本年)
/*                summaryItems[SummaryItem.ToukiSagaku].CurrentSumAmount = summaryItems[SummaryItem.ShisanSummary].CurrentSumAmount
                                                                        - summaryItems[SummaryItem.HusaiPlusJunshisanSummary].CurrentSumAmount;

                // うち当期活動収支差額(前年)
                summaryItems[SummaryItem.ToukiSagaku].LastSumAmount = summaryItems[SummaryItem.JikiKurikoshiSagaku].LastSumAmount
                                                                        - CalcJikiKurikoshiSagaku(StartNenndo - 1, KaikeiKubun);
*/
                // 事業活動計算書の値を持ってくる（基本金取崩額、積立金取崩額、積立金積立額などを加味しない値が必要）
                var jigyouKatsudou = new JigyouKatsudou(db);
                jigyouKatsudou.Calc(StartDate, EndDate, KaikeiKubun, hideInnerKaikeiKubunKamoku:true, targetKamokuKubunHierarchy:models.constants.MTKamokuKubunHierarchy.ChuuKubun, omitZeroRow:true);
                summaryItems[SummaryItem.ToukiSagaku].CurrentSumAmount = jigyouKatsudou.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.ToukiKatsudouZougenSagaku].CurrentYearSum;
                summaryItems[SummaryItem.ToukiSagaku].LastSumAmount = jigyouKatsudou.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.ToukiKatsudouZougenSagaku].LastYearSum;
            }


            // 資産、負債、純資産の本年に前期繰越を合計する
            summaryItems[SummaryItem.ShisanSummary].CurrentSumAmount += summaryItems[SummaryItem.ShisanSummary].LastSumAmount;
            summaryItems[SummaryItem.HusaiSummary].CurrentSumAmount += summaryItems[SummaryItem.HusaiSummary].LastSumAmount;
            summaryItems[SummaryItem.JunshisanSummary].CurrentSumAmount += summaryItems[SummaryItem.JunshisanSummary].LastSumAmount;
            summaryItems[SummaryItem.HusaiPlusJunshisanSummary].CurrentSumAmount += summaryItems[SummaryItem.HusaiPlusJunshisanSummary].LastSumAmount;
            foreach (var pair in kamokuKubunId2BalanceSheetRow) {
                pair.Value.CurrentSumAmount += pair.Value.LastSumAmount;
            }

            // 純資産に次期繰越を足す (次期繰越は純資産だが、別途計算しているため)
            //純資産
            summaryItems[SummaryItem.JunshisanSummary].Add(summaryItems[SummaryItem.JikiKurikoshiSagaku]);

            //負債＋純資産
            summaryItems[SummaryItem.HusaiPlusJunshisanSummary].Add(summaryItems[SummaryItem.JikiKurikoshiSagaku]);
        }
    }
}
