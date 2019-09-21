using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaikeiSystemBody.models.query
{
    class GoukeiZandakaShisanhyou
    {
        public const int GroupIdShisan = 1;
        public const int GroupIdHusaiJunsisan = 2;
        public const int GroupIdSyuunyuu = 3;
        public const int GroupIdShisyutsu = 4;

        public class ShisanRow {
            public int GroupId { get; set; }

            public int KanjouKamokuId { get; set; }
            //public int KamokuKubunId { get; set; }
            public int DaikubunId { get; set; }
            public int TaisyakuKubun { get; set; }
            public int KanjouKamokuHierarchy { get; set; }

            public long ZengetsuKarikata { get; set; }
            public long ZengetsuKashikata { get; set; }
            public long ShikinTougetsuKarikata { get; set; }
            public long ShikinTougetsuKashikata { get; set; }
            public long ShikinZandakaKarikata { get; set; }
            public long ShikinZandakaKashikata { get; set; }
            public long JigyouTougetsuKarikata { get; set; }
            public long JigyouTougetsuKashikata { get; set; }
            public long JigyouZandakaKarikata { get; set; }
            public long JigyouZandakaKashikata { get; set; }

            public long ZengetsuKarikataDisplay { get; set; }
            public long ZengetsuKashikataDisplay { get; set; }
            public long ShikinTougetsuKarikataDisplay { get; set; }
            public long ShikinTougetsuKashikataDisplay { get; set; }
            public long ShikinZandakaKarikataDisplay { get; set; }
            public long ShikinZandakaKashikataDisplay { get; set; }
            public long JigyouTougetsuKarikataDisplay { get; set; }
            public long JigyouTougetsuKashikataDisplay { get; set; }
            public long JigyouZandakaKarikataDisplay { get; set; }
            public long JigyouZandakaKashikataDisplay { get; set; }

            public bool IsShikinKamoku { get; set; }
            public bool IsJigyouKamoku { get; set; }

            public ShisanRow() {
                ZengetsuKarikata = 0;
                ZengetsuKashikata = 0;
                ShikinTougetsuKarikata = 0;
                ShikinTougetsuKashikata = 0;
                ShikinZandakaKarikata = 0;
                ShikinZandakaKashikata = 0;
                JigyouTougetsuKarikata = 0;
                JigyouTougetsuKashikata = 0;
                JigyouZandakaKarikata = 0;
                JigyouZandakaKashikata = 0;
            }

            public void Add(ShisanRow rhs) {
                this.ZengetsuKarikata += rhs.ZengetsuKarikata;
                this.ZengetsuKashikata += rhs.ZengetsuKashikata;
                this.ShikinTougetsuKarikata += rhs.ShikinTougetsuKarikata;
                this.ShikinTougetsuKashikata += rhs.ShikinTougetsuKashikata;
                this.ShikinZandakaKarikata += rhs.ShikinZandakaKarikata;
                this.ShikinZandakaKashikata += rhs.ShikinZandakaKashikata;
                this.JigyouTougetsuKarikata += rhs.JigyouTougetsuKarikata;
                this.JigyouTougetsuKashikata += rhs.JigyouTougetsuKashikata;
                this.JigyouZandakaKarikata += rhs.JigyouZandakaKarikata;
                this.JigyouZandakaKashikata += rhs.JigyouZandakaKashikata;
            }

            public void SetDisplayData(bool isDisplayOnly) {
                ZengetsuKarikataDisplay = ZengetsuKarikata;
                ZengetsuKashikataDisplay = ZengetsuKashikata;
                ShikinTougetsuKarikataDisplay = ShikinTougetsuKarikata;
                ShikinTougetsuKashikataDisplay = ShikinTougetsuKashikata;
                ShikinZandakaKarikataDisplay = ShikinZandakaKarikata;
                ShikinZandakaKashikataDisplay = ShikinZandakaKashikata;
                JigyouTougetsuKarikataDisplay = JigyouTougetsuKarikata;
                JigyouTougetsuKashikataDisplay = JigyouTougetsuKashikata;
                JigyouZandakaKarikataDisplay = JigyouZandakaKarikata;
                JigyouZandakaKashikataDisplay = JigyouZandakaKashikata;

                if (isDisplayOnly) {
                    ZengetsuKarikata = 0;
                    ZengetsuKashikata = 0;
                    ShikinTougetsuKarikata = 0;
                    ShikinTougetsuKashikata = 0;
                    ShikinZandakaKarikata = 0;
                    ShikinZandakaKashikata = 0;
                    JigyouTougetsuKarikata = 0;
                    JigyouTougetsuKashikata = 0;
                    JigyouZandakaKarikata = 0;
                    JigyouZandakaKashikata = 0;
                }
            }
        }

        public List<ShisanRow> RowList { get; private set; }

        private int jikiKurikoshiIndex;
        private Dictionary<int, bool> kanjouKamokuHash;
        private models.db.KaikeiDatabase db;
        private bool chukubunOnly;


        public GoukeiZandakaShisanhyou(models.db.KaikeiDatabase aDB) {
            RowList = new List<ShisanRow>();
            kanjouKamokuHash = new Dictionary<int, bool>();

            db = aDB;
        }


        public void Calc(int kaikeiKubun, DateTime targetMonth, bool chukubunOnly_) {
            chukubunOnly = chukubunOnly_;
            InitRowList();

            query.KamokuKubunSummary tougetsuSummary = new KamokuKubunSummary(db);
            {
                DateTime startDate = new DateTime(targetMonth.Year, targetMonth.Month, 1);
                DateTime endDate = new DateTime(targetMonth.Year, targetMonth.Month, 1).AddMonths(1).AddDays(-1);

                // 当月の計算では、資金と事業の伝票を別々に合計するので、支払資金の伝票も合計する
                tougetsuSummary.Calc(startDate, endDate, kaikeiKubun, addKurikoshi: false, addPairedShikinDenpyou:true);
            }

            query.KamokuKubunSummary zengetsuZandaka = new KamokuKubunSummary(db);
            {
                DateTime startDate = new DateTime(targetMonth.Year, 4, 1);
                DateTime endDate = new DateTime(targetMonth.Year, targetMonth.Month, 1).AddDays(-1);
                if (targetMonth.Month < 4) {
                    startDate = startDate.AddYears(-1);
                }

                // 前月残高の計算では、資金と事業の伝票を合計するので、支払資金の伝票は無視する
                zengetsuZandaka.Calc(startDate, endDate, kaikeiKubun, addKurikoshi: true, addPairedShikinDenpyou:false);
            }

            ShisanRow shisanRowSum = new ShisanRow();
            ShisanRow husaiJunshisanRowSum = new ShisanRow();

            for (int i = 0; i < RowList.Count; i++) {
                ShisanRow shisanRow = RowList[i];
                models.db.Row kanjouKamokuRow = db.MTKanjouKamoku.GetFirstRow("where id = " + shisanRow.KanjouKamokuId);
                int jigyouKamokuId = (int)kanjouKamokuRow.GetLong("jigyou_kamoku_kubun_id", -1);
                int shikinKamokuId = (int)kanjouKamokuRow.GetLong("shikin_kamoku_kubun_id", -1);
                int taisyakuKamokuId = (int)kanjouKamokuRow.GetLong("taisyaku_kamoku_kubun_id", -1);

                KamokuKubunSummary.SummaryRow zengetsuJigyouRow = zengetsuZandaka.SummaryItem(jigyouKamokuId);
                KamokuKubunSummary.SummaryRow tougetsuJigyouRow = tougetsuSummary.SummaryItem(jigyouKamokuId);
                KamokuKubunSummary.SummaryRow zengetsuShikinRow = zengetsuZandaka.SummaryItem(shikinKamokuId);
                KamokuKubunSummary.SummaryRow tougetsuShikinRow = tougetsuSummary.SummaryItem(shikinKamokuId);
                KamokuKubunSummary.SummaryRow zengetsuTaisyakuRow = zengetsuZandaka.SummaryItem(taisyakuKamokuId);
                KamokuKubunSummary.SummaryRow tougetsuTaisyakuRow = tougetsuSummary.SummaryItem(taisyakuKamokuId);

                KamokuKubunSummary.SummaryRow zengetsuSumRow = new KamokuKubunSummary.SummaryRow(0, 0, 0);
                zengetsuSumRow.AddAmount(zengetsuJigyouRow);
                zengetsuSumRow.AddAmount(zengetsuShikinRow);
                zengetsuSumRow.AddAmount(zengetsuTaisyakuRow);

                KamokuKubunSummary.SummaryRow tougetsuShikinAndTaisyakuRow = new KamokuKubunSummary.SummaryRow(0, 0, 0);
                tougetsuShikinAndTaisyakuRow.AddAmount(tougetsuShikinRow);
                tougetsuShikinAndTaisyakuRow.AddAmount(tougetsuTaisyakuRow);

                KamokuKubunSummary.SummaryRow tougetsuJigyouAndTaisyakuRow = new KamokuKubunSummary.SummaryRow(0, 0, 0);
                tougetsuJigyouAndTaisyakuRow.AddAmount(tougetsuJigyouRow);
                tougetsuJigyouAndTaisyakuRow.AddAmount(tougetsuTaisyakuRow);

                if (shisanRow.KanjouKamokuId == (int)models.constants.MTKanjouKamoku.JikiKurikoshikatsudouZougenSagaku) {
                    continue;
                }

                if (shisanRow.TaisyakuKubun == (int)models.constants.MTTaisyakuKubun.KariPlus ||
                        shisanRow.TaisyakuKubun == (int)models.constants.MTTaisyakuKubun.KariMinus) {
                    shisanRow.ZengetsuKarikata = zengetsuSumRow.KarikataAmount - zengetsuSumRow.KashikataAmount;
                    if (shisanRow.IsShikinKamoku) {
                        shisanRow.ShikinZandakaKarikata = tougetsuShikinAndTaisyakuRow.KarikataAmount
                                                        - tougetsuShikinAndTaisyakuRow.KashikataAmount
                                                        + shisanRow.ZengetsuKarikata;
                    }
                    if (shisanRow.IsJigyouKamoku) {
                        shisanRow.JigyouZandakaKarikata = tougetsuJigyouAndTaisyakuRow.KarikataAmount
                                                        - tougetsuJigyouAndTaisyakuRow.KashikataAmount
                                                        + shisanRow.ZengetsuKarikata;
                    }
                }
                else {
                    shisanRow.ZengetsuKashikata = zengetsuSumRow.KashikataAmount - zengetsuSumRow.KarikataAmount;
                    if (shisanRow.IsShikinKamoku) {
                        shisanRow.ShikinZandakaKashikata = tougetsuShikinAndTaisyakuRow.KashikataAmount
                                                            - tougetsuShikinAndTaisyakuRow.KarikataAmount
                                                            + shisanRow.ZengetsuKashikata;
                    }
                    if (shisanRow.IsJigyouKamoku) {
                        shisanRow.JigyouZandakaKashikata = tougetsuJigyouAndTaisyakuRow.KashikataAmount
                                                            - tougetsuJigyouAndTaisyakuRow.KarikataAmount
                                                            + shisanRow.ZengetsuKashikata;
                    }
                }
                if (shisanRow.IsShikinKamoku) {
                    shisanRow.ShikinTougetsuKashikata = tougetsuShikinAndTaisyakuRow.KashikataAmount;
                    shisanRow.ShikinTougetsuKarikata = tougetsuShikinAndTaisyakuRow.KarikataAmount;
                }
                if (shisanRow.IsJigyouKamoku) {
                    shisanRow.JigyouTougetsuKashikata = tougetsuJigyouAndTaisyakuRow.KashikataAmount;
                    shisanRow.JigyouTougetsuKarikata = tougetsuJigyouAndTaisyakuRow.KarikataAmount;
                }

                shisanRow.SetDisplayData(isDisplayOnly: shisanRow.KanjouKamokuHierarchy != (int)models.constants.MTKanjouKamokuHierarchy.ChuuKubun);

                // 次期繰越活動収支差額の計算のために合計を計算する
                if (shisanRow.GroupId == GroupIdShisan) {
                    shisanRowSum.Add(shisanRow);
                }
                else if (shisanRow.GroupId == GroupIdHusaiJunsisan) {
                    husaiJunshisanRowSum.Add(shisanRow);
                }
            }

            { // 次期繰越活動収支差額
                ShisanRow kurikoshi = RowList[jikiKurikoshiIndex];

                kurikoshi.ZengetsuKashikata = shisanRowSum.ZengetsuKarikata - husaiJunshisanRowSum.ZengetsuKashikata;
                kurikoshi.ShikinTougetsuKashikata = (shisanRowSum.ShikinTougetsuKarikata - shisanRowSum.ShikinTougetsuKashikata)
                                                        - (husaiJunshisanRowSum.ShikinTougetsuKashikata - husaiJunshisanRowSum.ShikinTougetsuKarikata);
                kurikoshi.ShikinZandakaKashikata = shisanRowSum.ShikinZandakaKarikata - husaiJunshisanRowSum.ShikinZandakaKashikata;

                kurikoshi.JigyouTougetsuKashikata = (shisanRowSum.JigyouTougetsuKarikata - shisanRowSum.JigyouTougetsuKashikata)
                                                        - (husaiJunshisanRowSum.JigyouTougetsuKashikata - husaiJunshisanRowSum.JigyouTougetsuKarikata);
                kurikoshi.JigyouZandakaKashikata = shisanRowSum.JigyouZandakaKarikata - husaiJunshisanRowSum.JigyouZandakaKashikata;
            }
        }


        private void InitRowList() {
            RowList.Clear();
            kanjouKamokuHash.Clear();

            // 資産
            AddKamokuRowsChildrenOfKubun((int)models.constants.MTKamokuKubun.Shisan, GroupIdShisan);

            // 負債・純資産
            AddKamokuRowsChildrenOfKubun((int)models.constants.MTKamokuKubun.Husai, GroupIdHusaiJunsisan);
            AddKamokuRowsChildrenOfKubun((int)models.constants.MTKamokuKubun.Junshisan, GroupIdHusaiJunsisan);

            // 収入
            AddKamokuRowsChildrenOfKubun((int)models.constants.MTKamokuKubun.ServiceKatsudouZougenSyuueki, GroupIdSyuunyuu);
            AddKamokuRowsChildrenOfKubun((int)models.constants.MTKamokuKubun.ServiceKatsudouGaiZougenSyuueki, GroupIdSyuunyuu);
            AddKamokuRowsChildrenOfKubun((int)models.constants.MTKamokuKubun.TokubetsuZougenSyuueki, GroupIdSyuunyuu);
            AddKamokuRowsChildrenOfKubun((int)models.constants.MTKamokuKubun.ShisetsuSyuunyuu, GroupIdSyuunyuu);
            AddKamokuRowsChildrenOfKubun((int)models.constants.MTKamokuKubun.SonotaSyuunyuu, GroupIdSyuunyuu);
            AddKamokuRowsChildrenOfKubun((int)models.constants.MTKamokuKubun.KurikoshiKatsudouZougenSagaku, GroupIdSyuunyuu);

            // 支出
            AddKamokuRowsChildrenOfKubun((int)models.constants.MTKamokuKubun.ServiceKatsudouZougenHiyou, GroupIdShisyutsu);
            AddKamokuRowsChildrenOfKubun((int)models.constants.MTKamokuKubun.ServiceKatsudouGaiZougenHiyou, GroupIdShisyutsu);
            AddKamokuRowsChildrenOfKubun((int)models.constants.MTKamokuKubun.TokubetsuZougenHiyou, GroupIdShisyutsu);
            AddKamokuRowsChildrenOfKubun((int)models.constants.MTKamokuKubun.JigyouShisyutsu, GroupIdShisyutsu);
            AddKamokuRowsChildrenOfKubun((int)models.constants.MTKamokuKubun.ShisetsuShisyutsu, GroupIdShisyutsu);
            AddKamokuRowsChildrenOfKubun((int)models.constants.MTKamokuKubun.SonotaShisyutsu, GroupIdShisyutsu);
            AddKamokuRowsChildrenOfKubun((int)models.constants.MTKamokuKubun.KurikoshiKatsudouZougenSagaku, GroupIdShisyutsu);
        }


        private void AddKamokuRowsChildrenOfKubun(int kubunId, int groupId) {
            foreach (models.db.Row daikubunRow in db.MTKamokuKubun.SelectChildren(kubunId, order: "order by display_order")) {
                foreach (models.db.Row chukubunRow in db.MTKamokuKubun.SelectChildren(daikubunRow.GetId(), order: "order by display_order")) {
                    AddKamokuRow(daikubunRow, chukubunRow, groupId);

                    if (chukubunOnly == false) {
                        foreach (models.db.Row syoukubunRow in db.MTKamokuKubun.SelectChildren(chukubunRow.GetId(), order: "order by display_order")) {
                            AddKamokuRow(daikubunRow, syoukubunRow, groupId);
                            foreach (models.db.Row hojokamokuRow in db.MTKamokuKubun.SelectChildren(syoukubunRow.GetId(), order: "order by display_order")) {
                                AddKamokuRow(daikubunRow, hojokamokuRow, groupId);
                            }
                        }
                    }
                }
            }
        }

        private void AddKamokuRow(models.db.Row daikubunRow, models.db.Row kamokuKubunRow, int groupId) {
            int kamokuKubunId = (int)kamokuKubunRow.GetId();

            models.db.Row kanjouKamokuRow = db.MTKanjouKamoku.GetFirstRow("where id=" + kamokuKubunRow.GetLong("kanjou_kamoku_id", -1));
            if (kanjouKamokuRow == null) {
                return;
            }
            if (kanjouKamokuRow.GetBool("usable", false) == false) {
                return;
            }

            int taisyakuKubunId = (int)kanjouKamokuRow.GetLong("taisyaku_kubun_id", -1);
            if ((taisyakuKubunId == (int)models.constants.MTTaisyakuKubun.KariPlus || taisyakuKubunId == (int)models.constants.MTTaisyakuKubun.KariMinus)
                    && groupId == GroupIdSyuunyuu) {
                        return;
            }
            if ((taisyakuKubunId == (int)models.constants.MTTaisyakuKubun.KashiPlus || taisyakuKubunId == (int)models.constants.MTTaisyakuKubun.KashiMinus)
                    && groupId == GroupIdShisyutsu) {
                        return;
            }

            if (kanjouKamokuHash.ContainsKey(kanjouKamokuRow.GetId())) {
                return;
            }
            kanjouKamokuHash.Add(kanjouKamokuRow.GetId(), true);

            ShisanRow shisanRow = new ShisanRow();
            shisanRow.GroupId = groupId;
            shisanRow.KanjouKamokuId = kanjouKamokuRow.GetId();
            //shisanRow.KamokuKubunId = kamokuRow.GetId();
            shisanRow.DaikubunId = daikubunRow.GetId();
            shisanRow.TaisyakuKubun = taisyakuKubunId;
            shisanRow.IsShikinKamoku = (kanjouKamokuRow.GetLong("shikin_kamoku_kubun_id", -1) != -1) || (kanjouKamokuRow.GetLong("taisyaku_kamoku_kubun_id", -1) != -1);
            shisanRow.IsJigyouKamoku = kanjouKamokuRow.GetLong("jigyou_kamoku_kubun_id", -1) != -1 || (kanjouKamokuRow.GetLong("taisyaku_kamoku_kubun_id", -1) != -1);
            shisanRow.KanjouKamokuHierarchy = (int)kanjouKamokuRow.GetLong("hierarchy", -1);
            RowList.Add(shisanRow);

            if (kamokuKubunId == (int)models.constants.MTKamokuKubun.JikiKurikoshikatsudouZougenSagakuChukubun) {
                jikiKurikoshiIndex = RowList.Count - 1;
            }
        }
    }
}
