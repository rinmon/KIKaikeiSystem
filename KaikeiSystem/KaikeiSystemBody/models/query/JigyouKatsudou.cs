using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.query
{
    class JigyouKatsudou
    {
        public enum SummaryItem {
            ServiceKatsudouSyuunyuu = 0,
            ServiceKatsudouShisyutsu = 1,
            ServiceKatsudouSagaku = 2,
            ServiceKatsudouGaiSyuunyuu = 3,
            ServiceKatsudouGaiShisyutsu = 4,
            ServiceKatsudouGaiSagaku = 5,
            KeijouZougenSagaku = 6,
            TokubetsuSyuunyuu = 7,
            TokubetsuShisyutsu = 8,
            TokubetsuSagaku = 9,
            ToukiKatsudouZougenSagaku = 10,
            ZenkiKurikoshiZougenSagaku = 11,
            ToukimatsuKurikoshiKatsudouZougenSagaku = 12,
            KihonkinTorikuzushiGaku = 13,
            SonotaTsumitateTorikuzushiGaku = 14,
            SonotaTsumitateGaku = 15,
            JikiKurikoshiKatsudouZougenSagaku = 16
        };


        // 年度ごとの金額
        public class JigyouSyuushiRow
        {
            public int PrintGroupKubunId { get; set; }     // 区分ID, 資金収支計算書の印刷用のRowでのみ使用
            public int Id { get; set; }          // 科目区分ID
            public bool IsSummaryRow { get; set; }

            public long CurrentYearSum { get; set; }
            public long LastYearSum { get; set; }
            public long Sai { get { return CurrentYearSum - LastYearSum; } }
            public long NaibuTorihikiSyoukyoGaku { get; set; } //内部取引消去額
            public long KamokuKubunHierarchy { get; set; } // 科目区分の階層

            public JigyouSyuushiRow(int id_, int kamokuKubunHierarchy_) {
                Id = id_;
                Id = id_;
                CurrentYearSum = 0;
                LastYearSum = 0;
                IsSummaryRow = false;
                PrintGroupKubunId = 0;
                KamokuKubunHierarchy = kamokuKubunHierarchy_;
            }
            public void Add(JigyouSyuushiRow row){
                CurrentYearSum += row.CurrentYearSum;
                LastYearSum += row.LastYearSum;
                this.NaibuTorihikiSyoukyoGaku += row.NaibuTorihikiSyoukyoGaku;
            }

            public void Substract(JigyouSyuushiRow row) {
                CurrentYearSum -= row.CurrentYearSum;
                LastYearSum -= row.LastYearSum;
                this.NaibuTorihikiSyoukyoGaku -= row.NaibuTorihikiSyoukyoGaku;
            }

            public void DainyuuAMinusB(JigyouSyuushiRow a, JigyouSyuushiRow b) {
                this.Add(a);
                this.Substract(b);
            }
        };


        private db.KaikeiDatabase db;
        private query.KamokuKubunSummary currentKamokuKubunSummary;
        private query.KamokuKubunSummary lastKamokuKubunSummary;

        public List<JigyouSyuushiRow> DaikubunRows { get; private set; }
        public Dictionary<int, List<JigyouSyuushiRow>> ChildRowsOf { get; private set; }
        public List<JigyouSyuushiRow> SummaryRows { get; private set; }


        public JigyouKatsudou(db.KaikeiDatabase aDB) {
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

        public void Calc(DateTime startDate, DateTime endDate, int kaikeiKubun, bool hideInnerKaikeiKubunKamoku, models.constants.MTKamokuKubunHierarchy targetKamokuKubunHierarchy, bool omitZeroRow) {
            StartDate = helper.Converter.DateTimeToNenndoKisannbi(startDate);
            EndDate = endDate;
            KaikeiKubun = kaikeiKubun == -1 ? db.MTKaikeiKubun.RootNodeId : kaikeiKubun;
            DateTime lastYearStartDate = helper.Helper.GetNenndoKisanbi(helper.Converter.GetNenndo(StartDate) - 1);
            DateTime lastYearEndDate = helper.Helper.GetNenndoKimatsubi(helper.Converter.GetNenndo(StartDate) - 1);
            KaikeiKubunHierarchy = (int)db.MTKaikeiKubun.GetHierarchyOf(kaikeiKubun);
            HideInnerKaikeiKubunKamoku = hideInnerKaikeiKubunKamoku;
            TargetKamokuKubunHierarchy = targetKamokuKubunHierarchy;
            OmitZeroRow = omitZeroRow;

            currentKamokuKubunSummary = new KamokuKubunSummary(db);
            currentKamokuKubunSummary.Calc(startDate, endDate, kaikeiKubun, addKurikoshi:false, addPairedShikinDenpyou:true);
            lastKamokuKubunSummary = new KamokuKubunSummary(db);
            lastKamokuKubunSummary.Calc(lastYearStartDate, lastYearEndDate, kaikeiKubun, addKurikoshi:false, addPairedShikinDenpyou:true);

            SummarizeMeisaiTable();
            CalcSummary();
        }


        private void SummarizeMeisaiTable() {
            string orderStr = "order by display_order";

            DaikubunRows = new List<JigyouSyuushiRow>();
            ChildRowsOf = new Dictionary<int, List<JigyouSyuushiRow>>();

            foreach (models.db.Row kubunRow in db.MTKamokuKubun.SelectChildren((int)models.constants.MTKamokuKubun.JigyouRoot, order: orderStr)) {
                foreach (models.db.Row daikubunRow in db.MTKamokuKubun.SelectChildren(kubunRow.GetId(), order: orderStr)) {
                    JigyouSyuushiRow daikubunJigyouSyuushiRow = new JigyouSyuushiRow(daikubunRow.GetId(), (int)models.constants.MTKamokuKubunHierarchy.Daikubun);
                    var kamokuList = SummarizeMeisaiTableSub(daikubunJigyouSyuushiRow, (int)models.constants.MTKamokuKubunHierarchy.ChuuKubun, orderStr);

/*                    foreach (models.db.Row kamokuRow in db.MTKamokuKubun.SelectChildren(daikubunRow.GetId(), order: orderStr)) {
                        if (HideInnerKaikeiKubunKamoku && db.MTKamokuKubun.IsInnerKaikeiKubunKamoku(KaikeiKubunHierarchy, kamokuRow)) {
                            continue;
                        }
                        JigyouSyuushiRow kamokuJigyouSyuushiRow = new JigyouSyuushiRow(kamokuRow.GetId());
                        kamokuJigyouSyuushiRow.CurrentYearSum = currentKamokuKubunSummary.SummaryItem(kamokuRow.GetId()).GetTaisyaku(db);
                        kamokuJigyouSyuushiRow.LastYearSum = lastKamokuKubunSummary.SummaryItem(kamokuRow.GetId()).GetTaisyaku(db);

                        if (db.MTKamokuKubun.IsInnerKaikeiKubunKamoku(KaikeiKubunHierarchy - 1, kamokuRow)) {
                            kamokuJigyouSyuushiRow.NaibuTorihikiSyoukyoGaku = kamokuJigyouSyuushiRow.CurrentYearSum;
                        }

                        kamokuList.Add(kamokuJigyouSyuushiRow);

                        daikubunJigyouSyuushiRow.Add(kamokuJigyouSyuushiRow);
                    }*/

                    if (kamokuList != null) {
                        DaikubunRows.Add(daikubunJigyouSyuushiRow);
                        ChildRowsOf.Add(daikubunJigyouSyuushiRow.Id, kamokuList);

                    }
                }
            }
        }


        private List<JigyouSyuushiRow> SummarizeMeisaiTableSub(JigyouSyuushiRow parentJigyouSyuushiRow, int kamokuKubunHierarchy, string orderStr) {
            var list = new List<JigyouSyuushiRow>();
            foreach (models.db.Row row in db.MTKamokuKubun.SelectChildren(parentJigyouSyuushiRow.Id, order: orderStr)) {
                if (HideInnerKaikeiKubunKamoku && db.MTKamokuKubun.IsInnerKaikeiKubunKamoku(KaikeiKubunHierarchy, row)) {
                    continue;
                }
                JigyouSyuushiRow jigyouSyuushiRow = new JigyouSyuushiRow(row.GetId(), kamokuKubunHierarchy);
                jigyouSyuushiRow.CurrentYearSum = currentKamokuKubunSummary.SummaryItem(row.GetId()).GetTaisyaku(db);
                jigyouSyuushiRow.LastYearSum = lastKamokuKubunSummary.SummaryItem(row.GetId()).GetTaisyaku(db);

                if (db.MTKamokuKubun.IsInnerKaikeiKubunKamoku(KaikeiKubunHierarchy - 1, row)) {
                    jigyouSyuushiRow.NaibuTorihikiSyoukyoGaku = jigyouSyuushiRow.CurrentYearSum;
                }

                bool hasChild = false;
                if ((int)TargetKamokuKubunHierarchy > kamokuKubunHierarchy) {
                    var childList = SummarizeMeisaiTableSub(jigyouSyuushiRow, kamokuKubunHierarchy + 1, orderStr);
                    if (childList != null) {
                        ChildRowsOf.Add(jigyouSyuushiRow.Id, childList);
                        hasChild = true;
                    }
                }

                if (OmitZeroRow == false || hasChild || jigyouSyuushiRow.CurrentYearSum != 0 || jigyouSyuushiRow.LastYearSum != 0)
                    {               
                        list.Add(jigyouSyuushiRow);
                    } else if(OmitZeroRow == true ) {
                        list.Add(jigyouSyuushiRow);
                }

                if (kamokuKubunHierarchy == (int)models.constants.MTKamokuKubunHierarchy.ChuuKubun) {
                    parentJigyouSyuushiRow.Add(jigyouSyuushiRow);
                }
            }

            if (list.Count > 0) {
                return list;
            }
            return null;
        }


        private long GetZenkiKurikoshiZougenSagaku(int year) {
            long amount = 0;

            foreach (var row in db.ZenkiKurikoshiKamokuKubun.Select("where nenndo=" + year)) {
                if (!db.MTKaikeiKubun.IsChildOf((int)row.GetLong("kaikei_kubun_id", -1), KaikeiKubun)) {
                    continue;
                }

                int kamokuKubunId = (int)row.GetLong("kamoku_kubun_id", 0);
                if (kamokuKubunId == (int)constants.MTKamokuKubun.JikiKurikoshikatsudouZougenSagakuChukubun) {
                    amount += row.GetLong("zenki_kurikoshi_gaku", 0);
                }
            }

            return amount;
        }


        private void InitSummaryRows() {
            SummaryRows = new List<JigyouSyuushiRow>();
            foreach (var row in Enum.GetValues(typeof(SummaryItem))) {
                SummaryRows.Add(new JigyouSyuushiRow((int)row, -1));
            }
        }


        private void CalcSummary() {
            InitSummaryRows();
           
            JigyouSyuushiRow jigyouSyuushiRow = new JigyouSyuushiRow(0, -1);
            SummaryRows[(int)SummaryItem.ServiceKatsudouSyuunyuu].Add(jigyouSyuushiRow);
            SummaryRows[(int)SummaryItem.ServiceKatsudouShisyutsu].Add(jigyouSyuushiRow);
            SummaryRows[(int)SummaryItem.ServiceKatsudouGaiSyuunyuu].Add(jigyouSyuushiRow);
            SummaryRows[(int)SummaryItem.ServiceKatsudouGaiShisyutsu].Add(jigyouSyuushiRow);
            SummaryRows[(int)SummaryItem.TokubetsuSyuunyuu].Add(jigyouSyuushiRow);
            SummaryRows[(int)SummaryItem.TokubetsuShisyutsu].Add(jigyouSyuushiRow);


            foreach (var daikubunJigyouSyuusjiRow in DaikubunRows) {
                models.db.Row daikubunRow = db.MTKamokuKubun.GetRowById(daikubunJigyouSyuusjiRow.Id);
                int jigyouSyuushiId = (int)daikubunRow.GetLong("parent_id", 0);
                int daikubunId = daikubunJigyouSyuusjiRow.Id;

                switch (jigyouSyuushiId) {
                    case (int)constants.MTKamokuKubun.ServiceKatsudouZougenSyuueki:     //サービス活動収益
                        SummaryRows[(int)SummaryItem.ServiceKatsudouSyuunyuu].Add(daikubunJigyouSyuusjiRow);
                        break;
                    case (int)constants.MTKamokuKubun.ServiceKatsudouZougenHiyou:       //サービス活動費用
                        SummaryRows[(int)SummaryItem.ServiceKatsudouShisyutsu].Add(daikubunJigyouSyuusjiRow);
                        break;
                    case (int)constants.MTKamokuKubun.ServiceKatsudouGaiZougenSyuueki:  //サービス活動外収益
                        SummaryRows[(int)SummaryItem.ServiceKatsudouGaiSyuunyuu].Add(daikubunJigyouSyuusjiRow);
                        break;
                    case (int)constants.MTKamokuKubun.ServiceKatsudouGaiZougenHiyou:    //サービス活動外費用
                        SummaryRows[(int)SummaryItem.ServiceKatsudouGaiShisyutsu].Add(daikubunJigyouSyuusjiRow);
                        break;
                    case (int)constants.MTKamokuKubun.TokubetsuZougenSyuueki:           //特別収益
                        SummaryRows[(int)SummaryItem.TokubetsuSyuunyuu].Add(daikubunJigyouSyuusjiRow);
                        break;
                    case (int)constants.MTKamokuKubun.TokubetsuZougenHiyou:             //特別費用
                        SummaryRows[(int)SummaryItem.TokubetsuShisyutsu].Add(daikubunJigyouSyuusjiRow);
                        break;
                    case (int)constants.MTKamokuKubun.KurikoshiKatsudouZougenSagaku:    //繰越活動収支差額
                        // nothing to do
                        break;
                }

                switch (daikubunId) {
                    case (int)constants.MTKamokuKubun.KihonkinTorikuzushiGakuDaikubun:      // 基本金取崩額
                        SummaryRows[(int)SummaryItem.KihonkinTorikuzushiGaku].Add(daikubunJigyouSyuusjiRow);
                        break;
                    case (int)constants.MTKamokuKubun.SonotaTsumitatekinTorikuzushiGaku:    // その他積立金取崩額
                        SummaryRows[(int)SummaryItem.SonotaTsumitateTorikuzushiGaku].Add(daikubunJigyouSyuusjiRow);
                        break;
                    case (int)constants.MTKamokuKubun.SonotaTsumitatekinTsumitateGaku:      // その他積立金積立額
                        SummaryRows[(int)SummaryItem.SonotaTsumitateGaku].Add(daikubunJigyouSyuusjiRow);
                        break;
                }
            }
            SummaryRows[(int)SummaryItem.ServiceKatsudouSagaku].DainyuuAMinusB(
                SummaryRows[(int)SummaryItem.ServiceKatsudouSyuunyuu], SummaryRows[(int)SummaryItem.ServiceKatsudouShisyutsu]);
            SummaryRows[(int)SummaryItem.ServiceKatsudouGaiSagaku].DainyuuAMinusB(
                SummaryRows[(int)SummaryItem.ServiceKatsudouGaiSyuunyuu], SummaryRows[(int)SummaryItem.ServiceKatsudouGaiShisyutsu]);
            SummaryRows[(int)SummaryItem.TokubetsuSagaku].DainyuuAMinusB(
                SummaryRows[(int)SummaryItem.TokubetsuSyuunyuu], SummaryRows[(int)SummaryItem.TokubetsuShisyutsu]);

            // 経常増減差額
            SummaryRows[(int)SummaryItem.KeijouZougenSagaku].Add(SummaryRows[(int)SummaryItem.ServiceKatsudouSagaku]);
            SummaryRows[(int)SummaryItem.KeijouZougenSagaku].Add(SummaryRows[(int)SummaryItem.ServiceKatsudouGaiSagaku]);

            //当期活動収支差額
            SummaryRows[(int)SummaryItem.ToukiKatsudouZougenSagaku].Add(SummaryRows[(int)SummaryItem.KeijouZougenSagaku]);
            SummaryRows[(int)SummaryItem.ToukiKatsudouZougenSagaku].Add(SummaryRows[(int)SummaryItem.TokubetsuSagaku]);

            //前期繰越活動収支差額
            SummaryRows[(int)SummaryItem.ZenkiKurikoshiZougenSagaku].CurrentYearSum = this.GetZenkiKurikoshiZougenSagaku(helper.Converter.GetNenndo(StartDate));
            SummaryRows[(int)SummaryItem.ZenkiKurikoshiZougenSagaku].LastYearSum = this.GetZenkiKurikoshiZougenSagaku(helper.Converter.GetNenndo(StartDate) - 1);

            // 当期末繰越活動増減差額
            SummaryRows[(int)SummaryItem.ToukimatsuKurikoshiKatsudouZougenSagaku].Add(SummaryRows[(int)SummaryItem.ToukiKatsudouZougenSagaku]);
            SummaryRows[(int)SummaryItem.ToukimatsuKurikoshiKatsudouZougenSagaku].Add(SummaryRows[(int)SummaryItem.ZenkiKurikoshiZougenSagaku]);

            //次期繰越活動収支差額
            SummaryRows[(int)SummaryItem.JikiKurikoshiKatsudouZougenSagaku].Add(SummaryRows[(int)SummaryItem.ToukimatsuKurikoshiKatsudouZougenSagaku]);
            SummaryRows[(int)SummaryItem.JikiKurikoshiKatsudouZougenSagaku].Add(SummaryRows[(int)SummaryItem.KihonkinTorikuzushiGaku]);
            SummaryRows[(int)SummaryItem.JikiKurikoshiKatsudouZougenSagaku].Add(SummaryRows[(int)SummaryItem.SonotaTsumitateTorikuzushiGaku]);
            SummaryRows[(int)SummaryItem.JikiKurikoshiKatsudouZougenSagaku].Substract(SummaryRows[(int)SummaryItem.SonotaTsumitateGaku]);
        }


        // 事業活動計算書の印刷用にRowのリストを作成して返す
        public List<JigyouSyuushiRow> GetRowsForJigyouKatsudouKeisansyoReport() {
            var result = new List<JigyouSyuushiRow>();

            var dummyRow = new JigyouSyuushiRow(-1, -1);
            dummyRow.PrintGroupKubunId = -1;
            DaikubunRows.Add(dummyRow);

            int beforeKubunId = 0;
            foreach (var row in DaikubunRows) {
                row.PrintGroupKubunId = row.Id == -1 ? -1 : db.MTKamokuKubun.GetParentOf(row.Id).GetId();
                if (beforeKubunId != 0 && beforeKubunId != row.PrintGroupKubunId) {
                    var footerRows = new List<JigyouSyuushiRow>();
                    switch (beforeKubunId) {
                        case (int)models.constants.MTKamokuKubun.ServiceKatsudouZougenSyuueki:
                            footerRows.Add(SummaryRows[(int)SummaryItem.ServiceKatsudouSyuunyuu]);
                            AddDummyRow(footerRows, beforeKubunId);
                            AddDummyRow(footerRows, beforeKubunId);
                            break;
                        case (int)models.constants.MTKamokuKubun.ServiceKatsudouZougenHiyou:
                            footerRows.Add(SummaryRows[(int)SummaryItem.ServiceKatsudouShisyutsu]);
                            footerRows.Add(SummaryRows[(int)SummaryItem.ServiceKatsudouSagaku]);
                            AddDummyRow(footerRows, beforeKubunId);
                            break;
                        case (int)models.constants.MTKamokuKubun.ServiceKatsudouGaiZougenSyuueki:
                            footerRows.Add(SummaryRows[(int)SummaryItem.ServiceKatsudouGaiSyuunyuu]);
                            AddDummyRow(footerRows, beforeKubunId);
                            AddDummyRow(footerRows, beforeKubunId);
                            break;
                        case (int)models.constants.MTKamokuKubun.ServiceKatsudouGaiZougenHiyou:
                            footerRows.Add(SummaryRows[(int)SummaryItem.ServiceKatsudouGaiShisyutsu]);
                            footerRows.Add(SummaryRows[(int)SummaryItem.ServiceKatsudouGaiSagaku]);
                            footerRows.Add(SummaryRows[(int)SummaryItem.KeijouZougenSagaku]);
                            AddDummyRow(footerRows, beforeKubunId);
                            break;
                        case (int)models.constants.MTKamokuKubun.TokubetsuZougenSyuueki:
                            footerRows.Add(SummaryRows[(int)SummaryItem.TokubetsuSyuunyuu]);
                            AddDummyRow(footerRows, beforeKubunId);
                            AddDummyRow(footerRows, beforeKubunId);
                            break;
                        case (int)models.constants.MTKamokuKubun.TokubetsuZougenHiyou:
                            footerRows.Add(SummaryRows[(int)SummaryItem.TokubetsuShisyutsu]);
                            footerRows.Add(SummaryRows[(int)SummaryItem.TokubetsuSagaku]);
                            AddDummyRow(footerRows, beforeKubunId);
                            break;
                    }
                    foreach (var footer in footerRows)
                    {
                        footer.PrintGroupKubunId = beforeKubunId;
                        footer.IsSummaryRow = true;
                        result.Add(footer);
                    }

                    if (beforeKubunId == (int)models.constants.MTKamokuKubun.TokubetsuZougenHiyou) {
                        break;
                    }
                }
                if (row != dummyRow)
                {
                    if (OmitZeroRow == false || row.CurrentYearSum != 0 || row.LastYearSum != 0)
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

        private void AddDummyRow(List<JigyouSyuushiRow> list, int beforeKubunId) {
            var dummy = new JigyouSyuushiRow(-1, -1);
            dummy.PrintGroupKubunId = beforeKubunId;
            list.Add(dummy);
        }

        private void AddChildRowsTo(List<JigyouSyuushiRow> rows, int parentKubunId, int printGroupKubunId, int kamokuKubunHierarchy) {
            if (kamokuKubunHierarchy > (int)TargetKamokuKubunHierarchy) {
                return;
            }
            if (ChildRowsOf.ContainsKey(parentKubunId) == false) {
                return;
            }
            foreach (var row in ChildRowsOf[parentKubunId]) {
                if (OmitZeroRow == false || row.CurrentYearSum != 0 || row.LastYearSum != 0)
                {
                    row.PrintGroupKubunId = printGroupKubunId;
                    rows.Add(row);
                    AddChildRowsTo(rows, row.Id, printGroupKubunId, kamokuKubunHierarchy + 1);
                }
            }
        }
    }
}
