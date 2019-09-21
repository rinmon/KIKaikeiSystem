using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaikeiSystemBody.models.query
{
    class YosanJisseki
    {
        public const int SummaryKubunIdSyuunyuuGoukei = -2;
        public const int SummaryKubunIdShisyutsuGoukei = -3;
        public const int SummaryKubunIdSyuushiGoukei = -4;

        public class YosanJissekiRow {
            public int KubunId { get; set; }
            public int DaikubunId { get; set; }
            public int KamokuId { get; private set; }
            public string KamokuCode { get; private set; }
            public string Name { get; private set; }

            public long Yosan { get; private set; }
            public long Jisseki { get; private set; }
            public long Sagaku {
                get {
                    return Yosan - Jisseki;
                }
            }

            public double Hiritsu {
                get {
                    if (Yosan == 0) {
                        return 0;
                    }
                    else {
                        return ((double)Jisseki) / ((double)Yosan);
                    }
                }
            }


            public long YosanDaikubun { get; set; }
            public long JissekiDaikubun { get; set; }
            public long SagakuDaikubun { get { return YosanDaikubun - JissekiDaikubun; } }
            public double HiritsuDaikubun {
                get {
                    if (YosanDaikubun == 0) {
                        return 0;
                    }
                    else {
                        return ((double)JissekiDaikubun) / ((double)YosanDaikubun);
                    }
                }
            }

            public long YosanKubun { get; set; }
            public long JissekiKubun { get; set; }
            public long SagakuKubun { get { return YosanKubun - JissekiKubun; } }
            public double HiritsuKubun {
                get {
                    if (YosanKubun == 0) {
                        return 0;
                    }
                    else {
                        return ((double)JissekiKubun) / ((double)YosanKubun);
                    }
                }
            }

/*            public YosanJissekiRow(int kamokuId, string kamokuCode, string name, long yosan, long jisseki) {
                KamokuId = kamokuId;
                KamokuCode = kamokuCode;
                Name = name;
                YosanDisplay = yosan;
                JissekiDisplay = jisseki;
            }
            */


            public YosanJissekiRow(int kamokuId, string name, long yosan, long jisseki, models.db.KaikeiDatabase db) {
                KamokuId = kamokuId;
                Yosan = yosan;
                Jisseki = jisseki;
                Name = name;

                YosanDaikubun = 0;
                JissekiDaikubun = 0;
                YosanKubun = 0;
                JissekiKubun = 0;

                models.db.Row kamokuKubunRow = db.MTKamokuKubun.GetRowById(kamokuId);
                if (kamokuKubunRow != null) {
                    if (name == null) {
                        Name = kamokuKubunRow.GetStr("name");
                    }

                    models.db.Row kanjouKamokuRow = db.MTKanjouKamoku.GetRowById((int)kamokuKubunRow.GetLong("kanjou_kamoku_id", -1));
                    if (kanjouKamokuRow != null) {
                        KamokuCode = kanjouKamokuRow.GetStr("kamoku_code");
                    }
                    else {
                        KamokuCode = "";
                    }
                }
            }

            public void AddYosan(long val) {
                Yosan += val;
            }

            public void AddJisseki(long val) {
                Jisseki += val;
            }
        }


        private db.KaikeiDatabase db;
        private YosanTable yosanTable;
        private KamokuKubunSummary kamokuKubunSummary;

        private List<YosanJissekiRow> summaryRows;

        public YosanJissekiRow SyuunyuuGoukeiRow { get; private set; }
        public YosanJissekiRow ShisyutsuGoukeiRow { get; private set; }
        public YosanJissekiRow SyuushiGoukeiRow { get; private set; }


        public int Year {get;private set;}
        public int HoseiKaisuu{get; private set;}
        public int KaikeiKubun {get; private set;}

        public YosanJissekiRow GetYosanJissekiRow(int kamokuKubunId) {
            YosanTable.YosanRow yosanRow = yosanTable.GetYosanRow(KaikeiKubun, kamokuKubunId);

            if (yosanRow == null) {
                return null;
            }
            else {
                long yosan = yosanRow.YosanHonnenDisplay;
                long jisseki = kamokuKubunSummary.SummaryItem(kamokuKubunId).GetTaisyaku(db);
                return new YosanJissekiRow(kamokuKubunId, yosanRow.DetailName, yosan, jisseki, db);
            }
        }


        // 帳票で使用
        public List<YosanJissekiRow> GetYosanJissekiRowList() {
            List<YosanJissekiRow> list = new List<YosanJissekiRow>();

            YosanJissekiRow kubunStartRow = null;
            YosanJissekiRow daikubunStartRow = null;

            foreach (var yosanRow in yosanTable.GetYosanList(KaikeiKubun)) {

                YosanJissekiRow row = GetYosanJissekiRow((int)yosanRow.DetailKubunId);
                row.KubunId = (int)yosanRow.KubunId;
                row.DaikubunId = (int)yosanRow.DaikubunId;

                if (kubunStartRow == null || kubunStartRow.KubunId != yosanRow.KubunId) {
                    kubunStartRow = row;
                }
                if (daikubunStartRow == null || daikubunStartRow.DaikubunId != yosanRow.DaikubunId) {
                    daikubunStartRow = row;
                }
                if (yosanRow.DisplayOnly == false) {
                    kubunStartRow.YosanKubun += row.Yosan;
                    kubunStartRow.JissekiKubun += row.Jisseki;
                    daikubunStartRow.YosanDaikubun += row.Yosan;
                    daikubunStartRow.JissekiDaikubun += row.Jisseki;
                }

                list.Add(row);
            }

            return list;
        }


        // 画面表示で使用
        public IEnumerable<YosanJissekiRow> EnumAllChuukubun() {
            foreach (var yosanRow in yosanTable.GetYosanList(KaikeiKubun)) {
                if (yosanRow.DisplayOnly) {
                    continue;
                }

                yield return GetYosanJissekiRow((int)yosanRow.DetailKubunId);
            }
        }

        public IEnumerable<YosanJissekiRow> EnumSyoukubunAndHojokamoku(int parentKamokuKubunId) {
            foreach (var syoukubunRow in db.MTKamokuKubun.SelectChildren(parentKamokuKubunId, order: "order by display_order")) {
                yield return GetYosanJissekiRow(syoukubunRow.GetId());

                foreach (var hojokamokuRow in db.MTKamokuKubun.SelectChildren(syoukubunRow.GetId(), order: "order by display_order")) {
                    yield return GetYosanJissekiRow(hojokamokuRow.GetId());
                }
            }
        }


        public IEnumerable<YosanJissekiRow> EnumSummaryRow() {
            foreach (var row in summaryRows) {
                yield return row;
            }
        }


        public YosanJisseki(db.KaikeiDatabase aDB) {
            db = aDB;
        }


        public void Calc(int year, int hoseiKaisuu, int kaikeiKubun) {
            Year = year;
            HoseiKaisuu = hoseiKaisuu;
            KaikeiKubun = kaikeiKubun;

            summaryRows = new List<YosanJissekiRow>();
            yosanTable = new YosanTable(db, year, year - 1, 0, hoseiKaisuu);
            kamokuKubunSummary = new KamokuKubunSummary(db);

            yosanTable.Calc(withSyoukubun:true, withHojokamoku:true);
            kamokuKubunSummary.Calc(helper.Helper.GetNenndoKisanbi(year), helper.Helper.GetNenndoKimatsubi(year), kaikeiKubun, addKurikoshi:false, addPairedShikinDenpyou:true);

            CalcSummaryRows();
        }


        private void CalcSummaryRows(){
            int rootId = (int)models.constants.MTKamokuKubun.ShikinRoot;
            Dictionary<int, int> kubunId2summaryRowsIndex = new Dictionary<int, int>();

            foreach (var kubunRow in db.MTKamokuKubun.SelectChildren(rootId, order:"order by display_order")) {
                int kubunId = kubunRow.GetId();
                summaryRows.Add(new YosanJissekiRow(kubunId, null, 0, 0, db));
                kubunId2summaryRowsIndex[kubunId] = summaryRows.Count - 1;
            }

            SyuunyuuGoukeiRow = new YosanJissekiRow(SummaryKubunIdSyuunyuuGoukei, "収入合計", 0, 0, db);
            summaryRows.Add(SyuunyuuGoukeiRow);

            ShisyutsuGoukeiRow = new YosanJissekiRow(SummaryKubunIdShisyutsuGoukei, "支出合計", 0, 0, db);
            summaryRows.Add(ShisyutsuGoukeiRow);

            SyuushiGoukeiRow = new YosanJissekiRow(SummaryKubunIdSyuushiGoukei, "収支合計", 0, 0, db);
            summaryRows.Add(SyuushiGoukeiRow);

            foreach (var yosanRow in yosanTable.GetYosanList(KaikeiKubun)) {
                int kubunId = (int)yosanRow.KubunId;
                int kamokuId = (int)yosanRow.DetailKubunId;
                int index = kubunId2summaryRowsIndex[kubunId];
                long yosan = yosanRow.YosanHonnenDisplay;
                long jisseki = kamokuKubunSummary.SummaryItem(kamokuId).GetTaisyaku(db); ;

                if (yosanRow.DisplayOnly) {
                    continue;
                }

                if (db.MTKamokuKubun.IsSyuunyuuKamoku(kubunId)) {
                    SyuunyuuGoukeiRow.AddYosan(yosan);
                    SyuunyuuGoukeiRow.AddJisseki(jisseki);
                    SyuushiGoukeiRow.AddYosan(yosan);
                    SyuushiGoukeiRow.AddJisseki(jisseki);
                }
                else {
                    ShisyutsuGoukeiRow.AddYosan(yosan);
                    ShisyutsuGoukeiRow.AddJisseki(jisseki);
                    SyuushiGoukeiRow.AddYosan(-yosan);
                    SyuushiGoukeiRow.AddJisseki(-jisseki);
                }

                summaryRows[index].AddYosan(yosan);
                summaryRows[index].AddJisseki(jisseki);
            }
        }
    }
}
