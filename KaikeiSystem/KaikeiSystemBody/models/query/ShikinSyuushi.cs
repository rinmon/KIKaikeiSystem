using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.query
{
    class ShikinSyuushi
    {
        public enum SummaryItem {
            JigyouSyuunyuu = 0,
            JigyouShisyutsu = 1,
            JigyouSyuushi = 2,
            ShisetsuSyuunyuu = 3,
            ShisetsuShisyutsu = 4,
            ShisetsuSyuushi = 5,
            SonotaSyuunyuu = 6,
            SonotaShisyutsu = 7,
            SonotaSyuushi = 8,
            Yobihi = 9,
            ToukiShikin = 10,
            ZenkiZandaka = 11,
            ToukiZandaka = 12,
            
            SyuunyuuGoukei = 13,
            ShisyutsuGoukei = 14,
            SyuushiGoukei = 15,
        };

        public class ShikinSyuushiRow
        {
            public int PrintGroupKubunId{get;set;}     // 区分ID, 資金収支計算書の印刷用のRowでのみ使用
            public int Id { get; set; }          // 科目区分ID
            public long Yosan { get; set; }      // 予算
            public long Taisyaku { get; set; }   // 貸借
            public long Sai{get{return Yosan - Taisyaku;}}       // 差異
            public long NaibuTorihikiSyoukyoGaku { get; set; } //内部取引消去額
            public long KamokuKubunHierarchy { get; set; } // 科目区分の階層

            public bool IsSummaryRow { get; set; }

            public ShikinSyuushiRow(int id_, int kamokuKubunHierarchy_) {
                Id = id_;
                PrintGroupKubunId = 0;
                Yosan = 0;
                Taisyaku = 0;
                IsSummaryRow = false;
                KamokuKubunHierarchy = kamokuKubunHierarchy_;
            }

            public void Add(ShikinSyuushiRow row) {
                this.Yosan += row.Yosan;
                this.Taisyaku += row.Taisyaku;
                this.NaibuTorihikiSyoukyoGaku += row.NaibuTorihikiSyoukyoGaku;
            }

            public void Substract(ShikinSyuushiRow row) {
                this.Yosan -= row.Yosan;
                this.Taisyaku -= row.Taisyaku;
                this.NaibuTorihikiSyoukyoGaku -= row.NaibuTorihikiSyoukyoGaku;
            }

            public void DainyuuAMinusB(ShikinSyuushiRow a, ShikinSyuushiRow b) {
                this.Yosan = a.Yosan - b.Yosan;
                this.Taisyaku = a.Taisyaku - b.Taisyaku;
                this.NaibuTorihikiSyoukyoGaku = a.NaibuTorihikiSyoukyoGaku - b.NaibuTorihikiSyoukyoGaku;
            }
        };

        
        private db.KaikeiDatabase db;
        private query.KamokuKubunSummary kamokuKubunSummary;
        private query.YosanTable yosanTable;

        public List<ShikinSyuushiRow> DaikubunRows { get; private set; }
        public Dictionary<int, List<ShikinSyuushiRow>> ChildRowsOf { get; private set; }
        public List<ShikinSyuushiRow> SummaryRows { get; private set; }


        public ShikinSyuushi(db.KaikeiDatabase aDB) {
            db = aDB;
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

        public int KaikeiKubun{
            get;
            private set;
        }


        // -1のときはすべての予算
        public int HoseiKaisuu {
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

        public models.constants.MTKamokuKubunHierarchy TargetKamokuKubunHierarchy {
            get;
            private set;
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
        public void Calc(DateTime startDate, DateTime endDate, int kaikeiKubun, int hoseiKaisuu, bool hideInnerKaikeiKubunKamoku, models.constants.MTKamokuKubunHierarchy targetKamokuKubunHierarchy, bool omitZeroRow){
            StartDate = helper.Converter.DateTimeToNenndoKisannbi(startDate);
            EndDate = endDate;
            KaikeiKubun = kaikeiKubun == -1 ? db.MTKaikeiKubun.RootNodeId : kaikeiKubun;
            HoseiKaisuu = hoseiKaisuu == -1 ? int.MaxValue : hoseiKaisuu;
            KaikeiKubunHierarchy = (int)db.MTKaikeiKubun.GetHierarchyOf(kaikeiKubun);
            HideInnerKaikeiKubunKamoku = hideInnerKaikeiKubunKamoku;
            TargetKamokuKubunHierarchy = targetKamokuKubunHierarchy;
            OmitZeroRow = omitZeroRow;

            kamokuKubunSummary = new KamokuKubunSummary(db);
            kamokuKubunSummary.Calc(startDate, endDate, kaikeiKubun, false, true);
            yosanTable = new YosanTable(db, StartNenndo, StartNenndo - 1, 0, HoseiKaisuu);
            yosanTable.Calc((int)targetKamokuKubunHierarchy >= (int)models.constants.MTKamokuKubunHierarchy.SyouKubun,
                (int)targetKamokuKubunHierarchy >= (int)models.constants.MTKamokuKubunHierarchy.HojoKamoku);

            SummarizeMeisaiTable();
            CalcSummary();
        }


        private void SummarizeMeisaiTable() {
            string orderStr = "order by display_order";

            DaikubunRows = new List<ShikinSyuushiRow>();
            ChildRowsOf = new Dictionary<int, List<ShikinSyuushiRow>>();

            foreach (models.db.Row kubunRow in db.MTKamokuKubun.SelectChildren((int)models.constants.MTKamokuKubun.ShikinRoot, order: orderStr)) {
                foreach (models.db.Row daikubunRow in db.MTKamokuKubun.SelectChildren(kubunRow.GetId(), order: orderStr)) {
                    ShikinSyuushiRow daikubunShikinSyuushiRow = new ShikinSyuushiRow(daikubunRow.GetId(), (int)models.constants.MTKamokuKubunHierarchy.Daikubun);
                    var kamokuList = SummarizeMeisaiTableSub(daikubunShikinSyuushiRow, (int)models.constants.MTKamokuKubunHierarchy.ChuuKubun, orderStr);

/*                    foreach (models.db.Row kamokuRow in db.MTKamokuKubun.SelectChildren(daikubunRow.GetId(), order: orderStr)) {
                        if (HideInnerKaikeiKubunKamoku && db.MTKamokuKubun.IsInnerKaikeiKubunKamoku(KaikeiKubunHierarchy, kamokuRow)) {
                            continue;
                        }
                        ShikinSyuushiRow kamokuShikinSyuushiRow = new ShikinSyuushiRow(kamokuRow.GetId());
                        kamokuShikinSyuushiRow.Yosan = yosanTable.GetYosanRow(KaikeiKubun, kamokuRow.GetId()).YosanHonnenDisplay;
                        kamokuShikinSyuushiRow.Taisyaku = kamokuKubunSummary.SummaryItem(kamokuRow.GetId()).GetTaisyaku(db);

                        if (db.MTKamokuKubun.IsInnerKaikeiKubunKamoku(KaikeiKubunHierarchy - 1, kamokuRow)) {
                            kamokuShikinSyuushiRow.NaibuTorihikiSyoukyoGaku = kamokuShikinSyuushiRow.Taisyaku;
                        }

                        kamokuList.Add(kamokuShikinSyuushiRow);

                        daikubunShikinSyuushiRow.Add(kamokuShikinSyuushiRow);
                    }
                    */


                    if (kamokuList != null) {
                        DaikubunRows.Add(daikubunShikinSyuushiRow);
                        ChildRowsOf.Add(daikubunShikinSyuushiRow.Id, kamokuList);
                    }
                }
            }
        }


        private List<ShikinSyuushiRow> SummarizeMeisaiTableSub(ShikinSyuushiRow parentShikinSyuushiRow, int kamokuKubunHierarchy, string orderStr) {
            var list = new List<ShikinSyuushiRow>();
            foreach (models.db.Row row in db.MTKamokuKubun.SelectChildren(parentShikinSyuushiRow.Id, order: orderStr)) {
                if (HideInnerKaikeiKubunKamoku && db.MTKamokuKubun.IsInnerKaikeiKubunKamoku(KaikeiKubunHierarchy, row)) {
                    continue;
                }
                ShikinSyuushiRow shikinSyuushiRow = new ShikinSyuushiRow(row.GetId(), kamokuKubunHierarchy);
                shikinSyuushiRow.Yosan = yosanTable.GetYosanRow(KaikeiKubun, row.GetId()).YosanHonnenDisplay;
                shikinSyuushiRow.Taisyaku = kamokuKubunSummary.SummaryItem(row.GetId()).GetTaisyaku(db);

                if (db.MTKamokuKubun.IsInnerKaikeiKubunKamoku(KaikeiKubunHierarchy - 1, row)) {
                    shikinSyuushiRow.NaibuTorihikiSyoukyoGaku = shikinSyuushiRow.Taisyaku;
                }

                bool hasChild = false;
                if ((int)TargetKamokuKubunHierarchy > kamokuKubunHierarchy) {
                    var childList = SummarizeMeisaiTableSub(shikinSyuushiRow, kamokuKubunHierarchy + 1, orderStr);
                    if (childList != null) {
                        ChildRowsOf.Add(shikinSyuushiRow.Id, childList);
                        hasChild = true;
                    }
                }
                if (OmitZeroRow == false || hasChild || shikinSyuushiRow.Yosan != 0 || shikinSyuushiRow.Taisyaku != 0) 
                {
                    list.Add(shikinSyuushiRow);
                } else if (OmitZeroRow == true)
                {
                    list.Add(shikinSyuushiRow);
                }

                if (kamokuKubunHierarchy == (int)models.constants.MTKamokuKubunHierarchy.ChuuKubun) {
                    parentShikinSyuushiRow.Add(shikinSyuushiRow);
                }
            }

            if (list.Count > 0) {
                return list;
            }
            return null;
        }


        private void InitSummaryRows() {
            SummaryRows = new List<ShikinSyuushiRow>();
            foreach (var row in Enum.GetValues(typeof(SummaryItem))) {
                ShikinSyuushiRow summaryRow = new ShikinSyuushiRow((int)row, -1);
                SummaryRows.Add(summaryRow);
            }
        }

        private void CalcSummary() {
            InitSummaryRows();

            ShikinSyuushiRow initShikinSyuushiRow = new ShikinSyuushiRow(0, -1);
            SummaryRows[(int)SummaryItem.JigyouSyuunyuu].Add(initShikinSyuushiRow);
            SummaryRows[(int)SummaryItem.JigyouShisyutsu].Add(initShikinSyuushiRow);
            SummaryRows[(int)SummaryItem.ShisetsuSyuunyuu].Add(initShikinSyuushiRow);
            SummaryRows[(int)SummaryItem.ShisetsuShisyutsu].Add(initShikinSyuushiRow);
            SummaryRows[(int)SummaryItem.SonotaSyuunyuu].Add(initShikinSyuushiRow);
            SummaryRows[(int)SummaryItem.SonotaShisyutsu].Add(initShikinSyuushiRow);

            foreach (var daikubunShikinSyuushiRow in DaikubunRows) {
                models.db.Row daikubunRow = db.MTKamokuKubun.GetRowById(daikubunShikinSyuushiRow.Id);
                int shikinSyuushiId = (int)daikubunRow.GetLong("parent_id", 0);
                switch (shikinSyuushiId) {
                    case (int)constants.MTKamokuKubun.JigyouSyuunyuu: //事業活動収入
                        SummaryRows[(int)SummaryItem.JigyouSyuunyuu].Add(daikubunShikinSyuushiRow);
                        break;
                    case (int)constants.MTKamokuKubun.JigyouShisyutsu: //事業活動支出
                        SummaryRows[(int)SummaryItem.JigyouShisyutsu].Add(daikubunShikinSyuushiRow);
                        break;
                    case (int)constants.MTKamokuKubun.ShisetsuSyuunyuu: //施設設備収入
                        SummaryRows[(int)SummaryItem.ShisetsuSyuunyuu].Add(daikubunShikinSyuushiRow);
                        break;
                    case (int)constants.MTKamokuKubun.ShisetsuShisyutsu: //施設設備支出
                        SummaryRows[(int)SummaryItem.ShisetsuShisyutsu].Add(daikubunShikinSyuushiRow);
                        break;
                    case (int)constants.MTKamokuKubun.SonotaSyuunyuu: //その他収入
                        SummaryRows[(int)SummaryItem.SonotaSyuunyuu].Add(daikubunShikinSyuushiRow);
                        break;
                    case (int)constants.MTKamokuKubun.SonotaShisyutsu: //その他支出
                        SummaryRows[(int)SummaryItem.SonotaShisyutsu].Add(daikubunShikinSyuushiRow);
                        break;
                }
            }
           SummaryRows[(int)SummaryItem.JigyouSyuushi].DainyuuAMinusB(SummaryRows[(int)SummaryItem.JigyouSyuunyuu], SummaryRows[(int)SummaryItem.JigyouShisyutsu]);
            SummaryRows[(int)SummaryItem.ShisetsuSyuushi].DainyuuAMinusB(SummaryRows[(int)SummaryItem.ShisetsuSyuunyuu], SummaryRows[(int)SummaryItem.ShisetsuShisyutsu]);
            SummaryRows[(int)SummaryItem.SonotaSyuushi].DainyuuAMinusB(SummaryRows[(int)SummaryItem.SonotaSyuunyuu], SummaryRows[(int)SummaryItem.SonotaShisyutsu]);

            { // 予備費計算
                string sql = "where nenndo = " + StartNenndo.ToString();

                foreach (var row in db.YosanYobihi.Select(sql)) {
                    if (!db.MTKaikeiKubun.IsChildOf((int)row.GetLong("kaikei_kubun", -1), KaikeiKubun)) {
                        continue;
                    }

                    SummaryRows[(int)SummaryItem.Yobihi].Yosan += row.GetLong("yobihi", 0);

                    // 前期末支払資金残高(予算)
                    SummaryRows[(int)SummaryItem.ZenkiZandaka].Yosan += row.GetLong("zenkimatsu_shiharai_shikin_zandaka", 0);
                }
            }

            { // 前期末支払資金残高
                foreach (var row in db.ZenkiKurikoshiKamokuKubun.Select("where nenndo = " + StartNenndo + " and kamoku_kubun_id=" + (int)models.constants.MTKamokuKubun.ZenkimatsuShiharaiShikinZandaka)) {
                    if (!db.MTKaikeiKubun.IsChildOf((int)row.GetLong("kaikei_kubun_id", -1), KaikeiKubun)) {
                        continue;
                    }
                    SummaryRows[(int)SummaryItem.ZenkiZandaka].Taisyaku += row.GetLong("zenki_kurikoshi_gaku", 0);
                }
            }

            SummaryRows[(int)SummaryItem.ToukiShikin].Add(SummaryRows[(int)SummaryItem.JigyouSyuushi]);
            SummaryRows[(int)SummaryItem.ToukiShikin].Add(SummaryRows[(int)SummaryItem.ShisetsuSyuushi]);
            SummaryRows[(int)SummaryItem.ToukiShikin].Add(SummaryRows[(int)SummaryItem.SonotaSyuushi]);
            SummaryRows[(int)SummaryItem.ToukiShikin].Substract(SummaryRows[(int)SummaryItem.Yobihi]);

            SummaryRows[(int)SummaryItem.ToukiZandaka].Add(SummaryRows[(int)SummaryItem.ZenkiZandaka]);
            SummaryRows[(int)SummaryItem.ToukiZandaka].Add(SummaryRows[(int)SummaryItem.ToukiShikin]);

            /*
            SummaryRows[(int)SummaryItem.SyuunyuuGoukei].Add(SummaryRows[(int)SummaryItem.ZaimuSyuunyuu]);
            SummaryRows[(int)SummaryItem.SyuunyuuGoukei].Add(SummaryRows[(int)SummaryItem.KeijouSyuunyuu]);
            SummaryRows[(int)SummaryItem.SyuunyuuGoukei].Add(SummaryRows[(int)SummaryItem.ShisetsuSyuunyuu]);

            SummaryRows[(int)SummaryItem.ShisyutsuGoukei].Add(SummaryRows[(int)SummaryItem.ZaimuShisyutsu]);
            SummaryRows[(int)SummaryItem.ShisyutsuGoukei].Add(SummaryRows[(int)SummaryItem.KeijouShisyutsu]);
            SummaryRows[(int)SummaryItem.ShisyutsuGoukei].Add(SummaryRows[(int)SummaryItem.ShisetsuShisyutsu]);

            SummaryRows[(int)SummaryItem.SyuushiGoukei].Add(SummaryRows[(int)SummaryItem.SyuunyuuGoukei]);
            SummaryRows[(int)SummaryItem.SyuushiGoukei].Add(SummaryRows[(int)SummaryItem.ShisyutsuGoukei]);
            */
        }


        // 資金収支計算書の印刷用にRowのリストを作成して返す
        public List<ShikinSyuushiRow> GetRowsForShikinSyuushiKeisansyoReport() {
            var result = new List<ShikinSyuushiRow>();

            var dummyRow = new ShikinSyuushiRow(-1, -1);
            dummyRow.PrintGroupKubunId = -1;
            DaikubunRows.Add(dummyRow);

            int beforeKubunId = 0;
            foreach (var row in DaikubunRows) {
                row.PrintGroupKubunId = row.Id == -1 ? -1 : db.MTKamokuKubun.GetParentOf(row.Id).GetId();
                if (beforeKubunId != 0 && beforeKubunId != row.PrintGroupKubunId) {
                    var footerRows = new List<ShikinSyuushiRow>();
                    switch (beforeKubunId) {
                        case (int)models.constants.MTKamokuKubun.JigyouSyuunyuu:
                            footerRows.Add(SummaryRows[(int)SummaryItem.JigyouSyuunyuu]);
                            AddDummyRowTo(footerRows, beforeKubunId);
                            break;
                        case (int)models.constants.MTKamokuKubun.JigyouShisyutsu:
                            footerRows.Add(SummaryRows[(int)SummaryItem.JigyouShisyutsu]);
                            footerRows.Add(SummaryRows[(int)SummaryItem.JigyouSyuushi]);
                            break;
                        case (int)models.constants.MTKamokuKubun.ShisetsuSyuunyuu:
                            footerRows.Add(SummaryRows[(int)SummaryItem.ShisetsuSyuunyuu]);
                            AddDummyRowTo(footerRows, beforeKubunId);
                            break;
                        case (int)models.constants.MTKamokuKubun.ShisetsuShisyutsu:
                            footerRows.Add(SummaryRows[(int)SummaryItem.ShisetsuShisyutsu]);
                            footerRows.Add(SummaryRows[(int)SummaryItem.ShisetsuSyuushi]);
                            break;
                        case (int)models.constants.MTKamokuKubun.SonotaSyuunyuu:
                            footerRows.Add(SummaryRows[(int)SummaryItem.SonotaSyuunyuu]);
                            AddDummyRowTo(footerRows, beforeKubunId);
                            break;
                        case (int)models.constants.MTKamokuKubun.SonotaShisyutsu:
                            footerRows.Add(SummaryRows[(int)SummaryItem.SonotaShisyutsu]);
                            footerRows.Add(SummaryRows[(int)SummaryItem.SonotaSyuushi]);
                            break;
                    }
                    AddDummyRowTo(footerRows, beforeKubunId);
                    foreach (var footer in footerRows) {
                        footer.PrintGroupKubunId = beforeKubunId;
                        footer.IsSummaryRow = true;
                        result.Add(footer);
                    }
                }
                if (row != dummyRow) {
                    if (OmitZeroRow == false || row.Yosan != 0 || row.Taisyaku != 0)
                    {
                            result.Add(row);
                            AddChildRowsTo(result, row.Id, row.PrintGroupKubunId, (int)models.constants.MTKamokuKubunHierarchy.ChuuKubun);
                    }
                }

                beforeKubunId = row.PrintGroupKubunId;
            }

            DaikubunRows.Remove(dummyRow);

            return result;
        }

        private void AddDummyRowTo(List<ShikinSyuushiRow> rows, int kubunId) {
            var dummy = new ShikinSyuushiRow(-1, -1);
            dummy.PrintGroupKubunId = kubunId;
            rows.Add(dummy);
        }

        private void AddChildRowsTo(List<ShikinSyuushiRow> rows, int parentKubunId, int printGroupKubunId, int kamokuKubunHierarchy) {
            if (kamokuKubunHierarchy > (int)TargetKamokuKubunHierarchy) {
                return;
            }
            if (ChildRowsOf.ContainsKey(parentKubunId) == false) {
                return;
            }
            foreach (var row in ChildRowsOf[parentKubunId]) {
                if (OmitZeroRow == false || row.Yosan != 0 || row.Taisyaku != 0)
                {
                    row.PrintGroupKubunId = printGroupKubunId;
                    rows.Add(row);
                    AddChildRowsTo(rows, row.Id, printGroupKubunId, kamokuKubunHierarchy + 1);
                }
            }
        }
    }
}
