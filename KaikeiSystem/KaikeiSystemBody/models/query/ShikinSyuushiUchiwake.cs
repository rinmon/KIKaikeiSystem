using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.query
{
    class ShikinSyuushiUchiwake
    {
        public enum StaticCols
        {
            Summary = 0,
            NaibuTorihikiSyoukyoGaku = 1,
            HoujinSummary = 2,
            NumStaticCols = 3,
        };

        public class ShikinSyuushiUchiwakeRow
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

            public ShikinSyuushiUchiwakeRow(int kubunId, int daikubunId, int kamokuKubunId) {
                KubunId = kubunId;
                DaikubunId = daikubunId;
                KamokuKubunId = kamokuKubunId;
            }
        };


        private List<ShikinSyuushi> shikinSyuushiList;

        
        private db.KaikeiDatabase db;
        public ShikinSyuushiUchiwake(db.KaikeiDatabase aDB) {
            db = aDB;
            shikinSyuushiList = new List<ShikinSyuushi>();
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
                return shikinSyuushiList.Count;
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



        /// <summary>
        /// 
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="kaikeiKubun"></param>
        /// <param name="hoseiKaisuu">指定した補正予算までの合計を計算する。通常予算は0。-1を指定したときはすべての予算の合計を計算する。</param>
        public void Calc(DateTime startDate, DateTime endDate, int kaikeiKubun, int hoseiKaisuu, bool hideInnerKaikeiKubunKamoku, bool omitZeroRow) {
            StartDate = helper.Converter.DateTimeToNenndoKisannbi(startDate);
            EndDate = endDate;
            KaikeiKubun = kaikeiKubun == -1 ? db.MTKaikeiKubun.RootNodeId : kaikeiKubun;
            HoseiKaisuu = hoseiKaisuu == -1 ? int.MaxValue : hoseiKaisuu;
            OmitZeroRow = omitZeroRow;

            foreach (var childKaikeiKubunRow in db.MTKaikeiKubun.SelectChildren(KaikeiKubun, order: "order by kubun_code")) {
                var shikinSyuushi = new ShikinSyuushi(db);
                shikinSyuushi.Calc(startDate, endDate, childKaikeiKubunRow.GetId(), hoseiKaisuu, hideInnerKaikeiKubunKamoku, models.constants.MTKamokuKubunHierarchy.ChuuKubun, omitZeroRow:false);
                shikinSyuushiList.Add(shikinSyuushi);
            }
        }


        public List<string> GetColCaptions(int startCol, int endCol) {
            var result = new List<string>();

            result.Add(""); // 合計
            result.Add(""); // 内部取引消去
            result.Add(""); // 法人合計

            for (int i = startCol; i <= endCol; i++) {
                result.Add(db.MTKaikeiKubun.GetRowById(shikinSyuushiList[i].KaikeiKubun).GetStr("name"));
            }

            return result;
        }


        public List<ShikinSyuushiUchiwakeRow> GetRows(int startCol, int endCol) {
            var rows = new List<ShikinSyuushiUchiwakeRow>();

            if (shikinSyuushiList.Count == 0) {
                return rows;
            }

            foreach (var daikubunRow in shikinSyuushiList[0].DaikubunRows) {
                for (int i = 0; i < shikinSyuushiList[0].ChildRowsOf[daikubunRow.Id].Count; i++) {
                    if (OmitZeroRow && IsZeroRow(daikubunRow.Id, i)) {
                        continue;
                    }
                    rows.Add(CreateUchiwakeRow(daikubunRow.Id, i, startCol, endCol));
                }
            }

            return rows;
        }


        private bool IsZeroRow(int parentKubunId, int childIndex) {
            for (int kaikeiKubun = 0; kaikeiKubun < shikinSyuushiList.Count; kaikeiKubun++) {
                var row = shikinSyuushiList[kaikeiKubun].ChildRowsOf[parentKubunId][childIndex];
                if (row.Taisyaku != 0) {
                    return false;
                }
            }
            return true;
        }


        public ShikinSyuushiUchiwakeRow GetSummaryRow(models.query.ShikinSyuushi.SummaryItem item, int startKaikeiKubun, int endKaikeiKubun) {
            var uchiwakeRow = new ShikinSyuushiUchiwakeRow(-1, -1, (int)item);

            long sum = 0;
            long naibuTorihikiSyoukyoGaku = 0;

            for (int kaikeiKubun = 0; kaikeiKubun < shikinSyuushiList.Count; kaikeiKubun++) {
                long taisyaku = shikinSyuushiList[kaikeiKubun].SummaryRows[(int)item].Taisyaku;
                sum += taisyaku;
                naibuTorihikiSyoukyoGaku += shikinSyuushiList[kaikeiKubun].SummaryRows[(int)item].NaibuTorihikiSyoukyoGaku;

                if (kaikeiKubun >= startKaikeiKubun) {
                    uchiwakeRow.SetCol(kaikeiKubun - startKaikeiKubun + (int)StaticCols.NumStaticCols, taisyaku);
                }
            }
            uchiwakeRow.SetCol((int)StaticCols.Summary, sum);
            uchiwakeRow.SetCol((int)StaticCols.NaibuTorihikiSyoukyoGaku, naibuTorihikiSyoukyoGaku);
            uchiwakeRow.SetCol((int)StaticCols.HoujinSummary, sum - naibuTorihikiSyoukyoGaku);

            return uchiwakeRow;
        }


        private ShikinSyuushiUchiwakeRow CreateUchiwakeRow(int daikubunId, int kamokuKubunIndex, int startKaikeiKubun, int endKaikeiKubun) {
            int kubunId = db.MTKamokuKubun.GetParentOf(daikubunId).GetId();
            int kamokuKubunId = shikinSyuushiList[0].ChildRowsOf[daikubunId][kamokuKubunIndex].Id;

            var uchiwakeRow = new ShikinSyuushiUchiwakeRow(kubunId, daikubunId, kamokuKubunId);

            long sum = 0;
            long naibuTorihikiSyoukyoGaku = 0;

            for (int kaikeiKubun = 0; kaikeiKubun < shikinSyuushiList.Count; kaikeiKubun++) {
                long taisyaku = shikinSyuushiList[kaikeiKubun].ChildRowsOf[daikubunId][kamokuKubunIndex].Taisyaku;
                sum += taisyaku;
                naibuTorihikiSyoukyoGaku -= shikinSyuushiList[kaikeiKubun].ChildRowsOf[daikubunId][kamokuKubunIndex].NaibuTorihikiSyoukyoGaku;

                if (kaikeiKubun >= startKaikeiKubun) {
                    uchiwakeRow.SetCol(kaikeiKubun - startKaikeiKubun + (int)StaticCols.NumStaticCols, taisyaku);
                }
            }
            uchiwakeRow.SetCol((int)StaticCols.Summary, sum);
            uchiwakeRow.SetCol((int)StaticCols.NaibuTorihikiSyoukyoGaku, naibuTorihikiSyoukyoGaku);
            uchiwakeRow.SetCol((int)StaticCols.HoujinSummary, sum + naibuTorihikiSyoukyoGaku);

            return uchiwakeRow;
        }
    }
}
