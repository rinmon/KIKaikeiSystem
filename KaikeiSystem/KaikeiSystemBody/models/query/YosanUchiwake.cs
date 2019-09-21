using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaikeiSystemBody.models.query
{
    class YosanUchiwake
    {
        public class YosanUchiwakeRow
        {
            public long YosanSummaryDisplay { get; set; }
            public long Yosan0Display { get; set; }
            public long Yosan1Display { get; set; }
            public long Yosan2Display { get; set; }
            public long Yosan3Display { get; set; }
            public long Yosan4Display { get; set; }
            public long Yosan5Display { get; set; }
            public long Yosan6Display { get; set; }

            public long YosanSummary { get; set; }
            public long Yosan0 { get; set; }
            public long Yosan1 { get; set; }
            public long Yosan2 { get; set; }
            public long Yosan3 { get; set; }
            public long Yosan4 { get; set; }
            public long Yosan5 { get; set; }
            public long Yosan6 { get; set; }

            public long JissekiSummaryDisplay { get; set; }
            public long Jisseki0Display { get; set; }
            public long Jisseki1Display { get; set; }
            public long Jisseki2Display { get; set; }
            public long Jisseki3Display { get; set; }
            public long Jisseki4Display { get; set; }
            public long Jisseki5Display { get; set; }
            public long Jisseki6Display { get; set; }

            public long JissekiSummary { get; set; }
            public long Jisseki0 { get; set; }
            public long Jisseki1 { get; set; }
            public long Jisseki2 { get; set; }
            public long Jisseki3 { get; set; }
            public long Jisseki4 { get; set; }
            public long Jisseki5 { get; set; }
            public long Jisseki6 { get; set; }

            public long SagakuSummaryDisplay { get; set; }
            public long Sagaku0Display { get; set; }
            public long Sagaku1Display { get; set; }
            public long Sagaku2Display { get; set; }
            public long Sagaku3Display { get; set; }
            public long Sagaku4Display { get; set; }
            public long Sagaku5Display { get; set; }
            public long Sagaku6Display { get; set; }

            public long SagakuSummary { get; set; }
            public long Sagaku0 { get; set; }
            public long Sagaku1 { get; set; }
            public long Sagaku2 { get; set; }
            public long Sagaku3 { get; set; }
            public long Sagaku4 { get; set; }
            public long Sagaku5 { get; set; }
            public long Sagaku6 { get; set; }

            public string DetailName { get; set; }
            public long KubunId { get; set; }
            public long DaikubunId { get; set; }
        };


        public List<int> KaikeiKubunList { get; private set; }
        public List<string> ChildKaikeiKubunNameList { get; private set; }
        public List<YosanUchiwakeRow> YosanUchiwakeRowList { get; private set; }

        public models.query.YosanTable YosanTable{get;private set;}


        public void Calc(models.db.KaikeiDatabase db, int currentYear, int lastYear, int hoseiKaisuu, int kaikeiKubun, bool withJisseki, bool withSyoukubun, bool withHojoKamoku) {
            YosanTable = new models.query.YosanTable(db, currentYear, lastYear, 0, hoseiKaisuu);
            YosanTable.Calc(withSyoukubun: withSyoukubun, withHojokamoku: withHojoKamoku);

            if (kaikeiKubun == -1) {
                kaikeiKubun = db.MTKaikeiKubun.RootNodeId;
            }

            KaikeiKubunList = new List<int>();
            KaikeiKubunList.Add(kaikeiKubun);

            ChildKaikeiKubunNameList = new List<string>();

            foreach (var row in db.MTKaikeiKubun.Select("where parent_id = " + kaikeiKubun + " order by kubun_code")) {
                int childKaikeiKubun = (int)row.GetLong("id", -1);
                KaikeiKubunList.Add(childKaikeiKubun);
                ChildKaikeiKubunNameList.Add(row.GetStr("name"));
            }

            YosanUchiwakeRowList = new List<YosanUchiwakeRow>();
            for (int colCt = 0; colCt < KaikeiKubunList.Count; colCt++) {
                var yosanList = YosanTable.GetYosanList(KaikeiKubunList[colCt]);
                KamokuKubunSummary kamokuKubunSummary = null;

                if(withJisseki){
                    kamokuKubunSummary = new KamokuKubunSummary(db);
                    kamokuKubunSummary.Calc(helper.Helper.GetNenndoKisanbi(currentYear), helper.Helper.GetNenndoKimatsubi(currentYear), kaikeiKubun, addKurikoshi: false, addPairedShikinDenpyou: true);
                }

                for (int rowCt = 0; rowCt < yosanList.Count; rowCt++) {
                    if (YosanUchiwakeRowList.Count <= rowCt) {
                        YosanUchiwakeRowList.Add(new YosanUchiwakeRow());
                    }
                    var row = YosanUchiwakeRowList[rowCt];
                    row.DaikubunId = yosanList[rowCt].DaikubunId;
                    row.KubunId = yosanList[rowCt].KubunId;
                    row.DetailName = yosanList[rowCt].DetailName;// db.MTKamokuKubun.GetRowFromCache((int)yosanList[rowCt].DetailKubunId).GetStr("name");

                    int kamokuKubunId = (int)yosanList[rowCt].DetailKubunId;

                    long jisseki = 0;
                    long jissekiDisplay = 0;

                    if (withJisseki) {
                        jissekiDisplay = kamokuKubunSummary.SummaryItem(kamokuKubunId).GetTaisyaku(db);
                        if (yosanList[rowCt].DisplayOnly == false) {
                            jisseki = jissekiDisplay;
                        }
                    }

                    switch (colCt) {
                        case 0:
                            row.YosanSummaryDisplay = yosanList[rowCt].YosanHonnenDisplay;
                            row.YosanSummary = yosanList[rowCt].YosanHonnen;
                            row.JissekiSummaryDisplay = jissekiDisplay;
                            row.JissekiSummary = jisseki;
                            row.SagakuSummaryDisplay = row.YosanSummaryDisplay - row.JissekiSummaryDisplay;
                            row.SagakuSummary = row.YosanSummary - row.JissekiSummary;
                            break;
                        case 1:
                            row.Yosan0Display = yosanList[rowCt].YosanHonnenDisplay;
                            row.Yosan0 = yosanList[rowCt].YosanHonnen;
                            row.Jisseki0Display = jissekiDisplay;
                            row.Jisseki0 = jisseki;
                            row.Sagaku0Display = row.Yosan0Display - row.Jisseki0Display;
                            row.Sagaku0 = row.Yosan0 - row.Jisseki0;
                            break;
                        case 2:
                            row.Yosan1Display = yosanList[rowCt].YosanHonnenDisplay;
                            row.Yosan1 = yosanList[rowCt].YosanHonnen;
                            row.Jisseki1Display = jissekiDisplay;
                            row.Jisseki1 = jisseki;
                            row.Sagaku1Display = row.Yosan1Display - row.Jisseki1Display;
                            row.Sagaku1 = row.Yosan1 - row.Jisseki1;
                            break;
                        case 3:
                            row.Yosan2Display = yosanList[rowCt].YosanHonnenDisplay;
                            row.Yosan2 = yosanList[rowCt].YosanHonnen;
                            row.Jisseki2Display = jissekiDisplay;
                            row.Jisseki2 = jisseki;
                            row.Sagaku2Display = row.Yosan2Display - row.Jisseki2Display;
                            row.Sagaku2 = row.Yosan2 - row.Jisseki2;
                            break;
                        case 4:
                            row.Yosan3Display = yosanList[rowCt].YosanHonnenDisplay;
                            row.Yosan3 = yosanList[rowCt].YosanHonnen;
                            row.Jisseki3Display = jissekiDisplay;
                            row.Jisseki3 = jisseki;
                            row.Sagaku3Display = row.Yosan3Display - row.Jisseki3Display;
                            row.Sagaku3 = row.Yosan3 - row.Jisseki3;
                            break;
                        case 5:
                            row.Yosan4Display = yosanList[rowCt].YosanHonnenDisplay;
                            row.Yosan4 = yosanList[rowCt].YosanHonnen;
                            row.Jisseki4Display = jissekiDisplay;
                            row.Jisseki4 = jisseki;
                            row.Sagaku4Display = row.Yosan4Display - row.Jisseki4Display;
                            row.Sagaku4 = row.Yosan4 - row.Jisseki4;
                            break;
                        case 6:
                            row.Yosan5Display = yosanList[rowCt].YosanHonnenDisplay;
                            row.Yosan5 = yosanList[rowCt].YosanHonnen;
                            row.Jisseki5Display = jissekiDisplay;
                            row.Jisseki5 = jisseki;
                            row.Sagaku5Display = row.Yosan5Display - row.Jisseki5Display;
                            row.Sagaku5 = row.Yosan5 - row.Jisseki5;
                            break;
                        case 7:
                            row.Yosan6Display = yosanList[rowCt].YosanHonnenDisplay;
                            row.Yosan6 = yosanList[rowCt].YosanHonnen;
                            row.Jisseki6Display = jissekiDisplay;
                            row.Jisseki6 = jisseki;
                            row.Sagaku6Display = row.Yosan6Display - row.Jisseki6Display;
                            row.Sagaku6 = row.Yosan6 - row.Jisseki6;
                            break;
                    }
                }
            }
        }
    }
}
