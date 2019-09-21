using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.query
{
    class YosanTable
    {
        public class YosanRow
        {
            public long YosanHonnen { get; set; }
            public long YosanZennen { get; set; }
            public long YosanHonnenDisplay { get; set; }
            public long YosanZennenDisplay { get; set; }
            public long YosanSagaku { get { return YosanHonnen - YosanZennen; } }
            public long YosanSagakuDisplay { get { return YosanHonnenDisplay - YosanZennenDisplay; } }
            public string DetailName { get; set; }
            public long DaikubunId { get; set; }
            public long KubunId { get; set; }
            public long DetailKubunId { get; set; }
            public bool DisplayOnly{get;set;}

            public YosanRow(long honnen, long zennen, string detailName, long daikubunId, long kubunId, long detailId, bool displayOnly) {
                YosanHonnenDisplay = honnen;
                YosanZennenDisplay = zennen;
                DetailName = detailName;
                DaikubunId = daikubunId;
                KubunId = kubunId;
                DetailKubunId = detailId;
                DisplayOnly = displayOnly;

                if (!displayOnly) {
                    YosanHonnen = YosanHonnenDisplay;
                    YosanZennen = YosanZennenDisplay;
                }
                else {
                    YosanHonnen = 0;
                    YosanZennen = 0;
                }
            }


            public void AddYosan(long honnen, long zennen){
                YosanHonnenDisplay += honnen;
                YosanZennenDisplay += zennen;

                if(!DisplayOnly){
                    YosanHonnen = YosanHonnenDisplay;
                    YosanZennen = YosanZennenDisplay;
                }
            }
        }

        public int CurrentYear { get; set; }
        public int LastYear { get; set; }
        public int HoseiKaisuuBegin { get; set; }
        public int HoseiKaisuuEnd { get; set; }
        public models.db.KaikeiDatabase Db;

        public List<YosanRow> GetYosanList(int kaikeiKubunId) {
            if (kaikeiKubunId == -1) {
                kaikeiKubunId = Db.MTKaikeiKubun.RootNodeId;
            }
            return kaikeiKubunId2YosanList[kaikeiKubunId];
        }

        public YosanRow GetYosanRow(int kaikeiKubunId, int kamokuKubunId) {
            List<YosanRow> list = kaikeiKubunId2YosanList[kaikeiKubunId];
            if(kamokuKubunId2YosanListIndex.ContainsKey(kamokuKubunId)){
                return list[kamokuKubunId2YosanListIndex[kamokuKubunId]];
            }
            else{
                return dummyRow;
            }
        }

        public YosanRow GetYobihiRow(int kaikeiKubunId) {
            if (kaikeiKubunId == -1) {
                kaikeiKubunId = Db.MTKaikeiKubun.RootNodeId;
            }
            return kaikeiKubunId2YobihiRow[kaikeiKubunId];
        }

        public YosanRow GetZenkimatsuZandakaRow(int kaikeiKubunId) {
            if (kaikeiKubunId == -1) {
                kaikeiKubunId = Db.MTKaikeiKubun.RootNodeId;
            }
            return kaikeiKubunId2ZenkimatsuZandakaRow[kaikeiKubunId];
        }

        private Dictionary<int, List<YosanRow>> kaikeiKubunId2YosanList;
        private Dictionary<int, int> kamokuKubunId2YosanListIndex;
        private Dictionary<int, YosanRow> kaikeiKubunId2YobihiRow;
        private Dictionary<int, YosanRow> kaikeiKubunId2ZenkimatsuZandakaRow;
        private YosanRow dummyRow;


        public YosanTable(models.db.KaikeiDatabase db, int currentYear, int lastYear, int hoseiKaisuuBegin, int hoseiKaisuuEnd) {
            CurrentYear = currentYear;
            LastYear = lastYear;
            HoseiKaisuuBegin = hoseiKaisuuBegin;
            HoseiKaisuuEnd = hoseiKaisuuEnd;
            Db = db;

            kaikeiKubunId2YosanList = null;
            kamokuKubunId2YosanListIndex = null;
            kaikeiKubunId2YobihiRow = null;
            kaikeiKubunId2ZenkimatsuZandakaRow = null;

            dummyRow = new YosanRow(0, 0, "", 0, 0, 0, false);
        }


        public void Calc(bool withSyoukubun, bool withHojokamoku){
            InitYosanList(withSyoukubun, withHojokamoku);
            AddYosan(CurrentYear, LastYear, HoseiKaisuuBegin, HoseiKaisuuEnd);
            LoadYobihi(CurrentYear, LastYear, HoseiKaisuuBegin, HoseiKaisuuEnd);
        }


        public void InitYosanList(bool withSyoukubun, bool withHojokamoku) {
            kamokuKubunId2YosanListIndex = new Dictionary<int, int>();
            kaikeiKubunId2YosanList = new Dictionary<int, List<YosanRow>>();
            kaikeiKubunId2YobihiRow = new Dictionary<int, YosanRow>();
            kaikeiKubunId2ZenkimatsuZandakaRow = new Dictionary<int, YosanRow>();

            foreach (var row in Db.MTKaikeiKubun.Select("")) {
                int id = (int)row.GetLong("id", -1);
                kaikeiKubunId2YosanList[id] = new List<YosanRow>();
                kaikeiKubunId2YobihiRow[id] = new YosanRow(0, 0, "yobihi", -1, -1, -1, true);
                kaikeiKubunId2ZenkimatsuZandakaRow[id] = new YosanRow(0, 0, "zandaka", -1, -1, -1, true);
            }

            int rootId = (int)models.constants.MTKamokuKubun.ShikinRoot;

            foreach (var kubunRow in Db.MTKamokuKubun.Select("where parent_id = " + rootId + " order by display_order")) {
                int kubunId = (int)kubunRow.GetLong("id", -1);

                foreach (var daikubunRow in Db.MTKamokuKubun.Select("where parent_id = " + kubunId + " order by display_order")) {
                    int daikubunId = (int)daikubunRow.GetLong("id", -1);
                    foreach (var kamokuRow in Db.MTKamokuKubun.Select("where parent_id = " + daikubunId + " order by display_order")) {
                        var kanjouKamokuRow = Db.MTKanjouKamoku.Select("where id=" + kamokuRow.GetLong("kanjou_kamoku_id", -1)).First();
                        if (!kanjouKamokuRow.GetBool("usable", false)) {
                            continue;
                        }
                        int kamokuId = (int)kamokuRow.GetLong("id", -1);
                        string kamokuStr = "　" + kamokuRow.GetStr("name", "");

                        kamokuKubunId2YosanListIndex[kamokuId] = kaikeiKubunId2YosanList.First().Value.Count;
                        foreach (var pair in kaikeiKubunId2YosanList) {
                            pair.Value.Add(new YosanRow(0, 0, kamokuStr, daikubunId, kubunId, kamokuId, false));
                        }

                        if (withSyoukubun) {
                            foreach (var syoukubunRow in Db.MTKamokuKubun.Select("where parent_id = " + kamokuId + " order by display_order")) {
                                int syoukubunId = (int)syoukubunRow.GetLong("id", -1);
                                string syoukubunStr = "　　" + syoukubunRow.GetStr("name", "");

                                kamokuKubunId2YosanListIndex[syoukubunId] = kaikeiKubunId2YosanList.First().Value.Count;
                                foreach (var pair in kaikeiKubunId2YosanList) {
                                    pair.Value.Add(new YosanRow(0, 0, syoukubunStr, daikubunId, kubunId, syoukubunId, true));
                                }

                                if (withHojokamoku) {
                                    foreach (var hojoRow in Db.MTKamokuKubun.Select("where parent_id = " + syoukubunId + " order by display_order")) {
                                        int hojoId = (int)hojoRow.GetLong("id", -1);
                                        string hojoStr = "　　　　" + hojoRow.GetStr("name", "");

                                        kamokuKubunId2YosanListIndex[hojoId] = kaikeiKubunId2YosanList.First().Value.Count;
                                        foreach (var pair in kaikeiKubunId2YosanList) {
                                            pair.Value.Add(new YosanRow(0, 0, hojoStr, daikubunId, kubunId, hojoId, true));
                                        }
                                    }                                
                                }
                            }
                        }
                    }
                }
            }
        }


        public void AddYosan(int currentYear, int lastYear, int hoseiKaisuuBegin, int hoseiKaisuuEnd) {
            foreach (var year in new int[] { currentYear, lastYear }) {
                string sql = "where nenndo = " + year + " and hosei_kaisuu >= " + hoseiKaisuuBegin + " and hosei_kaisuu <= " + hoseiKaisuuEnd;
                foreach (var row in Db.YosanKamokuKubun.Select(sql)) {
                    int kamokuKubunId = (int)row.GetLong("kamoku_kubun_id", -1);
                    int kaikeiKubunId = (int)row.GetLong("kaikei_kubun", -1);
                    long yosan = row.GetLong("yosan", 0);

                    if (!kamokuKubunId2YosanListIndex.ContainsKey(kamokuKubunId)) {
                        continue;
                    }

                    while (kaikeiKubunId != -1 && kaikeiKubunId2YosanList.ContainsKey(kaikeiKubunId)) {
                        var yosanList = kaikeiKubunId2YosanList[kaikeiKubunId];
                        var yosanRow = yosanList[kamokuKubunId2YosanListIndex[kamokuKubunId]];

                        if (year == currentYear) {
                            yosanRow.AddYosan(yosan, 0);
                        }
                        else {
                            yosanRow.AddYosan(0, yosan);
                        }

                        models.db.Row kaikeiKubunRow = Db.MTKaikeiKubun.GetRowFromCache(kaikeiKubunId);
                        kaikeiKubunId = (int)kaikeiKubunRow.GetLong("parent_id", -1);
                    }
                }
            }
        }


        public void LoadYobihi(int currentYear, int lastYear, int hoseiKaisuuBegin, int hoseiKaisuuEnd) {
            foreach (var year in new int[] { currentYear, lastYear }) {
                string sql = "where nenndo = " + year + " and hosei_kaisuu >= " + hoseiKaisuuBegin + " and hosei_kaisuu <= " + hoseiKaisuuEnd;
                foreach (var row in Db.YosanYobihi.Select(sql)) {
                    int kaikeiKubunId = (int)row.GetLong("kaikei_kubun", -1);
                    long yobihi = row.GetLong("yobihi", 0);
                    long zandaka = row.GetLong("zenkimatsu_shiharai_shikin_zandaka", 0);

                    if(!kaikeiKubunId2YobihiRow.ContainsKey(kaikeiKubunId)){
                        continue;
                    }

                    while (kaikeiKubunId != -1) {
                        var yobihiRow = kaikeiKubunId2YobihiRow[kaikeiKubunId];
                        var zandakaRow = kaikeiKubunId2ZenkimatsuZandakaRow[kaikeiKubunId];

                        if (year == currentYear) {
                            yobihiRow.AddYosan(yobihi, 0);
                            zandakaRow.AddYosan(zandaka, 0);
                        }
                        else {
                            yobihiRow.AddYosan(0, yobihi);
                            zandakaRow.AddYosan(0, zandaka);
                        }

                        models.db.Row kaikeiKubunRow = Db.MTKaikeiKubun.GetRowFromCache(kaikeiKubunId);
                        kaikeiKubunId = (int)kaikeiKubunRow.GetLong("parent_id", -1);
                    }
                }
            }
        }

        public void OmitZeroRow() {
        
        }
    }
}

