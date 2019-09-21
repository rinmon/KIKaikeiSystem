using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.query
{
    class HikiatekinMeisai
    {
        public class MeisaiRow
        {
            public int KamokuKubunId { get;set;}
            public string KamokuName{get;set;}
            public long KisyuZandaka{get;set;} // 期首残高
            public long ToukiZouka1{get;set;} // 当期増加
            public long ToukiZouka2{get;set;} // 当期増加 (カッコ内の数字)
            public long MokutekiShiyou{get;set;} //目的使用
            public long Sonota1{get;set;} //その他使用
            public long Sonota2{get;set;} //その他使用（カッコ内の数字)
            public long KimatsuZandaka { // 期末残高
                get {
                    return KisyuZandaka + ToukiZouka1 - MokutekiShiyou - Sonota1;
                }
            }

            public MeisaiRow(int kamokuKubunId, string kamokuName, long kisyuZandaka, long toukiZouka1, long toukiZouka2,
                            long mokutekiShiyou, long sonota1, long sonota2, long kimatsuZandaka) {
                KamokuKubunId = kamokuKubunId;
                KamokuName = kamokuName;
                KisyuZandaka = kisyuZandaka;
                ToukiZouka1 = toukiZouka1;
                ToukiZouka2 = toukiZouka2;
                MokutekiShiyou = mokutekiShiyou;
                Sonota1 = sonota1;
                Sonota2 = sonota2;
            }

            public void AddMeisai(MeisaiRow row){
                this.KisyuZandaka += row.KisyuZandaka;
                this.ToukiZouka1 += row.ToukiZouka1;
                this.ToukiZouka2 += row.ToukiZouka2;
                this.MokutekiShiyou += row.MokutekiShiyou;
                this.Sonota1 += row.Sonota1;
                this.Sonota2 += row.Sonota2;
            }
        };

        
        private db.KaikeiDatabase db;
        private List<MeisaiRow> meisaiList;
        public MeisaiRow SumRow { get; private set; }

        public List<MeisaiRow> GetMeisaiList() {
            return meisaiList;
        }

        public HikiatekinMeisai(db.KaikeiDatabase aDB) {
            db = aDB;
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

        public void Calc(DateTime startDate, DateTime endDate, int kaikeiKubun){
            StartDate = startDate;
            EndDate = endDate;
            KaikeiKubun = kaikeiKubun;

            SumRow = new MeisaiRow(-1, "", 0, 0, 0, 0, 0, 0, 0);

            InitList();

            SummarizeMeisaiTable();
        }

        private void InitList() {
            meisaiList = new List<MeisaiRow>();
            AddMeisaiRow((int)models.constants.MTKamokuKubun.TaisyokuKyuuhuHikiatekin);
            AddMeisaiRow((int)models.constants.MTKamokuKubun.SyouyoHikiatekin);
            AddMeisaiRow((int)models.constants.MTKamokuKubun.TyousyuuHunouHikiatekin);
        }

        private void AddMeisaiRow(int kamokuKubunId) {
            models.db.Row kamokuKubunRow = db.MTKamokuKubun.GetRowById(kamokuKubunId);

            if (kamokuKubunRow == null) {
                return;
            }

            MeisaiRow row = new MeisaiRow(kamokuKubunId, kamokuKubunRow.GetStr("name", ""), 0, 0, 0, 0, 0, 0, 0);
            meisaiList.Add(row);
        }


        private void SummarizeMeisaiTable() {
            query.KamokuKubunSummary tougetsuSummary = new KamokuKubunSummary(db);
            {
                DateTime startDate = StartDate;
                DateTime endDate = EndDate;
                tougetsuSummary.Calc(startDate, endDate, KaikeiKubun, addKurikoshi: false, addPairedShikinDenpyou: false);
            }

            query.KamokuKubunSummary zengetsuZandaka = new KamokuKubunSummary(db);
            {
                DateTime startDate = new DateTime(StartDate.Year, 4, 1);
                DateTime endDate = StartDate.AddDays(-1);
                if (startDate.Month < 4) {
                    startDate = startDate.AddYears(-1);
                }

                // 前月残高の計算では、資金と事業の伝票を合計するので、支払資金の伝票は無視する
                zengetsuZandaka.Calc(startDate, endDate, KaikeiKubun, addKurikoshi: true, addPairedShikinDenpyou: false);
            }

            foreach (MeisaiRow meisaiRow in meisaiList) {
                long zouka;
                long gensyou;
                meisaiRow.KisyuZandaka = zengetsuZandaka.SummaryItem(meisaiRow.KamokuKubunId).GetTaisyaku(db);

                models.db.Row kanjouKamokuRow = db.MTKanjouKamoku.GetRowFromKamokuKubun(meisaiRow.KamokuKubunId);

                int taisyakuKubunId = (int)kanjouKamokuRow.GetLong("taisyaku_kubun_id", -1);

                if (taisyakuKubunId == (int)models.constants.MTTaisyakuKubun.KariPlus || taisyakuKubunId == (int)models.constants.MTTaisyakuKubun.KariMinus) {
                    zouka = tougetsuSummary.SummaryItem(meisaiRow.KamokuKubunId).KarikataAmount;
                    gensyou = tougetsuSummary.SummaryItem(meisaiRow.KamokuKubunId).KashikataAmount;
                }
                else {
                    zouka = tougetsuSummary.SummaryItem(meisaiRow.KamokuKubunId).KashikataAmount;
                    gensyou = tougetsuSummary.SummaryItem(meisaiRow.KamokuKubunId).KarikataAmount;
                }
                meisaiRow.ToukiZouka1 = zouka;
                meisaiRow.ToukiZouka2 = 0;
                meisaiRow.MokutekiShiyou = gensyou;
                meisaiRow.Sonota1 = 0;
                meisaiRow.Sonota2 = 0;

                SumRow.AddMeisai(meisaiRow);
            }
        }
    }
}
