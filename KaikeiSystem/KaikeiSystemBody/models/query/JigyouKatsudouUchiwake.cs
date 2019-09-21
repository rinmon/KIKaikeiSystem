using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.query
{
    class JigyouKatsudouUchiwake
    {
        public enum StaticCols
        {
            Summary = 0,
            NaibuTorihikiSyoukyoGaku = 1,
            HoujinSummary = 2,
            NumStaticCols = 3,
        };

        public class JigyouKatsudouUchiwakeRow
        {
            public int KubunId{get;set;}        // 区分ID
            public int DaikubunId{get;set;}     // 大区分ID
            public int KamokuKubunId{get;set;}  // 科目区分ID
            public long Col0{get;set;}
            public long Col1{get;set;}
            public long Col2{get;set;}
            public long Col3{get;set;}
            public long Col4{get;set;}
            public long Col5{get;set;}
            public long Col6{get;set;}
            public long Col7{get;set;}
            public long Col8{get;set;}
            public long Col9{get;set;}

            public long Col(int i) {
                switch (i) {
                    case 0: return Col0;
                    case 1: return Col1;
                    case 2: return Col2;
                    case 3: return Col3;
                    case 4: return Col4;
                    case 5: return Col5;
                    case 6: return Col6;
                    case 7: return Col7;
                    case 8: return Col8;
                    case 9: return Col9;
                }
                return 0;
            }

            public void SetCol(int i, long val) {
                switch (i) {
                    case 0: Col0 = val; return ;
                    case 1: Col1 = val; return;
                    case 2: Col2 = val; return;
                    case 3: Col3 = val; return;
                    case 4: Col4 = val; return;
                    case 5: Col5 = val; return;
                    case 6: Col6 = val; return;
                    case 7: Col7 = val; return;
                    case 8: Col8 = val; return;
                    case 9: Col9 = val; return;
                }
            }

            public JigyouKatsudouUchiwakeRow(int kubunId, int daikubunId, int kamokuKubunId) {
                KubunId = kubunId;
                DaikubunId = daikubunId;
                KamokuKubunId = kamokuKubunId;
            }
        };


        private List<JigyouKatsudou> jigyouKatsudouList;

        
        private db.KaikeiDatabase db;
        public JigyouKatsudouUchiwake(db.KaikeiDatabase aDB) {
            db = aDB;
            jigyouKatsudouList = new List<JigyouKatsudou>();
        }


        public DateTime StartDate {
            get;
            private set;
        }

        public int StartNenndo {
            get {
                if (StartDate.Month <= 3) {
                    return StartDate.Year - 1;
                }
                else {
                    return StartDate.Year;
                }
            }
        }

        public DateTime EndDate {
            get;
            private set;
        }

        public int KaikeiKubun {
            get;
            private set;
        }


        // -1のときはすべての予算
        public int HoseiKaisuu {
            get;
            private set;
        }


        public int NumCols {
            get {
                return jigyouKatsudouList.Count;
            }
        }


        public int NumStaticCols {
            get {
                return (int)StaticCols.NumStaticCols;
            }
        }

        public bool OmitZeroRow {
            get;
            private set;
        }


        public void Calc(DateTime startDate, DateTime endDate, int kaikeiKubun, bool hideInnerKaikeiKubunKamoku, bool omitZeroRow) {
            StartDate = helper.Converter.DateTimeToNenndoKisannbi(startDate);
            EndDate = endDate;
            KaikeiKubun = kaikeiKubun == -1 ? db.MTKaikeiKubun.RootNodeId : kaikeiKubun;
            OmitZeroRow = omitZeroRow;

            foreach (var childKaikeiKubunRow in db.MTKaikeiKubun.SelectChildren(KaikeiKubun, order: "order by kubun_code")) {
                var jigyouKatsudou = new JigyouKatsudou(db);
                jigyouKatsudou.Calc(startDate, endDate, childKaikeiKubunRow.GetId(), hideInnerKaikeiKubunKamoku, constants.MTKamokuKubunHierarchy.ChuuKubun, omitZeroRow: false);
                jigyouKatsudouList.Add(jigyouKatsudou);
            }
        }


        public List<string> GetColCaptions(int startCol, int endCol) {
            var result = new List<string>();

            result.Add(""); // 合計
            result.Add(""); // 内部取引消去
            result.Add(""); // 法人合計

            for (int i = startCol; i <= endCol; i++) {
                result.Add(db.MTKaikeiKubun.GetRowById(jigyouKatsudouList[i].KaikeiKubun).GetStr("name"));
            }

            return result;
        }


        public List<JigyouKatsudouUchiwakeRow> GetRows(int startCol, int endCol) {
            var rows = new List<JigyouKatsudouUchiwakeRow>();
            if (jigyouKatsudouList == null || jigyouKatsudouList.Count == 0) {
                return rows;
            }
            foreach (var daikubunRow in jigyouKatsudouList[0].DaikubunRows) {

                for (int i = 0; i < jigyouKatsudouList[0].ChildRowsOf[daikubunRow.Id].Count; i++) {
                    if (OmitZeroRow && IsZeroRow(daikubunRow.Id, i)) {
                        continue;
                    }
                    var row = CreateUchiwakeRow(daikubunRow.Id, i, startCol, endCol);

                    if (row.KubunId == (int)models.constants.MTKamokuKubun.KurikoshiKatsudouZougenSagaku) {
                        break;
                    }

                    rows.Add(row);
                }
            }

            return rows;
        }

        private bool IsZeroRow(int parentKubunId, int childIndex) {
            for (int kaikeiKubun = 0; kaikeiKubun < jigyouKatsudouList.Count; kaikeiKubun++) {
                var row = jigyouKatsudouList[kaikeiKubun].ChildRowsOf[parentKubunId][childIndex];
                if (row.CurrentYearSum != 0) {
                    return false;
                }
            }
            return true;
        }



        public JigyouKatsudouUchiwakeRow GetSummaryRow(models.query.JigyouKatsudou.SummaryItem item, int startKaikeiKubun, int endKaikeiKubun) {
            var uchiwakeRow = new JigyouKatsudouUchiwakeRow(-1, -1, (int)item);

            long sum = 0;
            long naibuTorihikiSyoukyoGaku = 0;

            for (int kaikeiKubun = 0; kaikeiKubun < jigyouKatsudouList.Count; kaikeiKubun++) {
                long val = jigyouKatsudouList[kaikeiKubun].SummaryRows[(int)item].CurrentYearSum;
                naibuTorihikiSyoukyoGaku -= jigyouKatsudouList[kaikeiKubun].SummaryRows[(int)item].NaibuTorihikiSyoukyoGaku;
                sum += val;

                if (kaikeiKubun >= startKaikeiKubun) {
                    uchiwakeRow.SetCol(kaikeiKubun - startKaikeiKubun + (int)StaticCols.NumStaticCols, val);
                }
            }
            uchiwakeRow.SetCol((int)StaticCols.Summary, sum);
            uchiwakeRow.SetCol((int)StaticCols.NaibuTorihikiSyoukyoGaku, naibuTorihikiSyoukyoGaku);
            uchiwakeRow.SetCol((int)StaticCols.HoujinSummary, sum + naibuTorihikiSyoukyoGaku);

            return uchiwakeRow;
        }


        private JigyouKatsudouUchiwakeRow CreateUchiwakeRow(int daikubunId, int kamokuKubunIndex, int startKaikeiKubun, int endKaikeiKubun) {
            int kubunId = db.MTKamokuKubun.GetParentOf(daikubunId).GetId();
            int kamokuKubunId = jigyouKatsudouList[0].ChildRowsOf[daikubunId][kamokuKubunIndex].Id;

            var uchiwakeRow = new JigyouKatsudouUchiwakeRow(kubunId, daikubunId, kamokuKubunId);

            long sum = 0;
            long naibuTorihikiSyoukyoGaku = 0;

            for (int kaikeiKubun = 0; kaikeiKubun < jigyouKatsudouList.Count; kaikeiKubun++) {
                long val = jigyouKatsudouList[kaikeiKubun].ChildRowsOf[daikubunId][kamokuKubunIndex].CurrentYearSum;
                sum += val;
                naibuTorihikiSyoukyoGaku -= jigyouKatsudouList[kaikeiKubun].ChildRowsOf[daikubunId][kamokuKubunIndex].NaibuTorihikiSyoukyoGaku;

                if (kaikeiKubun >= startKaikeiKubun) {
                    uchiwakeRow.SetCol(kaikeiKubun - startKaikeiKubun + (int)StaticCols.NumStaticCols, val);
                }
            }
            uchiwakeRow.SetCol((int)StaticCols.Summary, sum);
            uchiwakeRow.SetCol((int)StaticCols.NaibuTorihikiSyoukyoGaku, naibuTorihikiSyoukyoGaku);
            uchiwakeRow.SetCol((int)StaticCols.HoujinSummary, sum + naibuTorihikiSyoukyoGaku);

            return uchiwakeRow;
        }
    }
}
