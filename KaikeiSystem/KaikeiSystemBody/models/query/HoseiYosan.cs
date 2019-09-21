using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaikeiSystemBody.models.query
{
    class HoseiYosan
    {
        // 収支予算書と同じレポートを使うので、プロパティ名を収支予算書に合わせている
        public class HoseiYosanRow
        {
            public long YosanHonnen { get; set; }               // 予算現額
            public long YosanZennen { get; set; }               // 今回補正額
            public long YosanHonnenDisplay { get; set; }        // 予算現額
            public long YosanZennenDisplay { get; set; }        // 今回補正額
            public long YosanSagaku { get { return YosanHonnen + YosanZennen; } }                       // 補正後予算額
            public long YosanSagakuDisplay { get { return YosanHonnenDisplay + YosanZennenDisplay; } }  // 補正後予算額
            public string DetailName { get; set; }
            public long DaikubunId { get; set; }
            public long KubunId { get; set; }
            public long DetailKubunId { get; set; }
            public bool DisplayOnly { get; set; }

            public HoseiYosanRow(YosanTable.YosanRow gengaku, YosanTable.YosanRow konkaiHosei) {
                YosanHonnen = gengaku.YosanHonnen;
                YosanZennen = konkaiHosei.YosanHonnen;
                YosanHonnenDisplay = gengaku.YosanHonnenDisplay;
                YosanZennenDisplay = konkaiHosei.YosanHonnenDisplay;
                DetailName = gengaku.DetailName;
                DaikubunId = gengaku.DaikubunId;
                KubunId = gengaku.KubunId;
                DetailKubunId = gengaku.DetailKubunId;
                DisplayOnly = gengaku.DisplayOnly;
            }
        }
            
        private YosanTable yosanGengakuTable;
        private YosanTable konkaiHoseigakuTable;

        public HoseiYosan(models.db.KaikeiDatabase db, int currentYear, int lastYear, int hoseiKaisuu) {
            yosanGengakuTable = new YosanTable(db, currentYear, lastYear, 0, hoseiKaisuu - 1);
            konkaiHoseigakuTable = new YosanTable(db, currentYear, lastYear, hoseiKaisuu, hoseiKaisuu);
        }


        public void Calc(bool withSyoukubun, bool withHojokamoku) {
            yosanGengakuTable.Calc(withSyoukubun, withHojokamoku);
            konkaiHoseigakuTable.Calc(withSyoukubun, withHojokamoku);
        }


        public HoseiYosanRow GetYobihiRow(int kaikeiKubunId) {
            return new HoseiYosanRow(
                yosanGengakuTable.GetYobihiRow(kaikeiKubunId),
                konkaiHoseigakuTable.GetYobihiRow(kaikeiKubunId));
        }

        public HoseiYosanRow GetZenkimatsuZandakaRow(int kaikeiKubunId) {
            return new HoseiYosanRow(
                yosanGengakuTable.GetZenkimatsuZandakaRow(kaikeiKubunId),
                konkaiHoseigakuTable.GetZenkimatsuZandakaRow(kaikeiKubunId));
        }

        public List<HoseiYosanRow> GetHoseiYosanList(int kaikeiKubunId) {
            List<YosanTable.YosanRow> gengakuList = yosanGengakuTable.GetYosanList(kaikeiKubunId);
            List<YosanTable.YosanRow> hoseigakuList = konkaiHoseigakuTable.GetYosanList(kaikeiKubunId);

            List<HoseiYosanRow> result = new List<HoseiYosanRow>();

            if(gengakuList.Count != hoseigakuList.Count){
                throw new Exception("GetHoseiYosanList error");
            }

            for (int i = 0; i < gengakuList.Count; i++) {
                if (gengakuList[i].DetailName != hoseigakuList[i].DetailName) {
                    throw new Exception("error: calc hosei yosan row", null);
                }

                result.Add(new HoseiYosanRow(gengakuList[i], hoseigakuList[i]));
            }

            return result;
        }
    }
}
