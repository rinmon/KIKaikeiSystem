using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.query
{
    class BalanceSheetTyuuki
    {
        public class BalanceSheetTyuuki1Row{
            public int SeiriBangou{get;set;}
            public string KoumokuMei{get;set;}
            public string Naiyou{get;set;}

            public BalanceSheetTyuuki1Row(int seiriBangou, string koumokuMei, string naiyou){
                SeiriBangou = seiriBangou;
                KoumokuMei = koumokuMei;
                Naiyou = naiyou;
            }
        }

        public class BalanceSheetTyuuki3Row{
            public string Kamoku{get;set;}
            public string Tekiyou{get;set;}
            public long Kingaku{get;set;}
            public string KaikeiKubun{get;set;}

            public BalanceSheetTyuuki3Row(string kamoku, string tekiyou, long kingaku, string kaikeiKubun){
                Kamoku = kamoku;
                Tekiyou = tekiyou;
                Kingaku = kingaku;
                KaikeiKubun = kaikeiKubun;
            }
        }

        public class BalanceSheetTyuuki4Row{
            public string Naiyou{get;set;}
            public string KaikeiKubun{get;set;}

            public BalanceSheetTyuuki4Row(string naiyou, string kaikeiKubun){
                Naiyou = naiyou;
                KaikeiKubun = kaikeiKubun;
            }
        }

        public class BalanceSheetTyuuki5Row{
            public string TanpoKubun{get;set;}
            public int TanpoKubunId{get;set;}
            public string Kamoku{get;set;}
            public long Kingaku{get;set;}
            public string KaikeiKubun{get;set;}

            public BalanceSheetTyuuki5Row(string tanpoKubun, int tanpoKubunId, string kamoku, long kingaku, string kaikeiKubun){
                TanpoKubun = tanpoKubun;
                TanpoKubunId = tanpoKubunId;
                Kamoku = kamoku;
                Kingaku = kingaku;
                KaikeiKubun = kaikeiKubun;
            }
        }

        
        private db.KaikeiDatabase db;

        public List<BalanceSheetTyuuki1Row> Tyuuki1Rows{get;private set;}
        public List<BalanceSheetTyuuki3Row> Tyuuki3Rows{get;private set;}
        public List<BalanceSheetTyuuki4Row> Tyuuki4Rows{get;private set;}
        public List<BalanceSheetTyuuki5Row> Tyuuki5Rows{get;private set;}

        public long GenkaSyoukyakuRuikeiGaku { get; private set; }
        public long TyousyuuHunouKin { get; private set; }
        public string Tyuuki2 { get; private set; } // 重要な会計方針の変更
        public string Tyuuki6 { get; private set; } // 重要な後発事項

        public int Nenndo { get; private set; }
        public int KaikeiKubun { get; private set; }
        private int tyuukiId;

        public BalanceSheetTyuuki(db.KaikeiDatabase aDB) {
            db = aDB;
        }

        public void Calc(int nenndo, int kaikeiKubun){
            KaikeiKubun = kaikeiKubun == -1 ? db.MTKaikeiKubun.RootNodeId : kaikeiKubun;
            Nenndo = nenndo;

            GenkaSyoukyakuRuikeiGaku = 0;
            TyousyuuHunouKin = 0;
            Tyuuki2 = "";
            Tyuuki6 = "";
            Tyuuki1Rows = new List<BalanceSheetTyuuki1Row>();
            Tyuuki3Rows = new List<BalanceSheetTyuuki3Row>();
            Tyuuki4Rows = new List<BalanceSheetTyuuki4Row>();
            Tyuuki5Rows = new List<BalanceSheetTyuuki5Row>();

            models.db.Row row = db.TaisyakuTaisyouhyouTyuuki.GetFirstRow("where nenndo=" + Nenndo);

            if (row != null) {
                tyuukiId = row.GetId();
                Tyuuki2 = row.GetStr("juuyou_henkou");
                Tyuuki6 = row.GetStr("juuyou_kouhatsu");

                CalcKyakutyuu();
                CalcTyuuki1();
                CalcTyuuki3();
                CalcTyuuki4();
                CalcTyuuki5();
            }
        }


        // 減価償却、徴収不能金
        private void CalcKyakutyuu() {
            foreach (var row in db.TaisyakuTaisyouhyouKyakutyuu.Select("where tyuuki_id=" + tyuukiId)) {
                if (!db.MTKaikeiKubun.IsChildOf(childId: (int)row.GetLong("kaikei_kubun", -1), parentId:KaikeiKubun)) {
                    continue;
                }

                GenkaSyoukyakuRuikeiGaku += row.GetLong("genka_baikyaku_ruikei", 0);
                TyousyuuHunouKin += row.GetLong("tyousyuu_hunou_kin", 0);
            }
        }

        private void CalcTyuuki1() {
            foreach (var row in db.TaisyakuTaisyouhyouTyuuki1.Select("where tyuuki_id=" + tyuukiId + " order by seiri_bangou")) {
                var tyuuki1Row = new BalanceSheetTyuuki1Row(
                    (int)row.GetLong("seiri_bangou", 0),
                    row.GetStr("koumoku_mei"),
                    row.GetStr("naiyou"));
                Tyuuki1Rows.Add(tyuuki1Row);
            }
        }

        private void CalcTyuuki3() {
            foreach (var row in db.TaisyakuTaisyouhyouTyuuki3.Select("where tyuuki_id=" + tyuukiId + " order by kaikei_kubun")) {
                if (!db.MTKaikeiKubun.IsChildOf(childId: (int)row.GetLong("kaikei_kubun", -1), parentId:KaikeiKubun)) {
                    continue;
                }

                var tyuuki3Row = new BalanceSheetTyuuki3Row(
                    GetKamokuLabelOfTyuukiRow(row),
                    row.GetStr("tekiyou"),
                    row.GetLong("amount", 0),
                    GetKaikeiKubunNameOfTyuukiRow(row));

                Tyuuki3Rows.Add(tyuuki3Row);
            }
        }

        private void CalcTyuuki4() {
            foreach (var row in db.TaisyakuTaisyouhyouTyuuki4.Select("where tyuuki_id=" + tyuukiId + " order by kaikei_kubun")) {
                if (!db.MTKaikeiKubun.IsChildOf(childId: (int)row.GetLong("kaikei_kubun", -1), parentId: KaikeiKubun)) {
                    continue;
                }

                var tyuuki4Row = new BalanceSheetTyuuki4Row(
                    row.GetStr("naiyou"),
                    GetKaikeiKubunNameOfTyuukiRow(row));

                Tyuuki4Rows.Add(tyuuki4Row);
            }
        }

        private void CalcTyuuki5() {
            foreach (var row in db.TaisyakuTaisyouhyouTyuuki5.Select("where tyuuki_id=" + tyuukiId + " order by tanpo_kubun")) {
                if (!db.MTKaikeiKubun.IsChildOf(childId: (int)row.GetLong("kaikei_kubun", -1), parentId: KaikeiKubun)) {
                    continue;
                }
                int tanpoKubunId = (int)row.GetLong("tanpo_kubun", -1);
                string tanpoStr = models.constants.Labels.TanpoKubun[tanpoKubunId];

                var tyuuki5Row = new BalanceSheetTyuuki5Row(
                    tanpoStr,
                    tanpoKubunId,
                    GetKamokuLabelOfTyuukiRow(row),
                    row.GetLong("amount", 0),
                    GetKaikeiKubunNameOfTyuukiRow(row));

                Tyuuki5Rows.Add(tyuuki5Row);
            }
        }


        private string GetKaikeiKubunNameOfTyuukiRow(models.db.Row tyuukiRow) {
            return db.MTKaikeiKubun.GetFirst("name", "where id=" + tyuukiRow.GetLong("kaikei_kubun", -1)) as string;
        }

        private string GetKamokuLabelOfTyuukiRow(models.db.Row tyuukiRow){
            int kanjouKamokuId = (int)tyuukiRow.GetLong("kamoku_id", -1);
            if (kanjouKamokuId >= 1) {
                var kanjouRow = db.MTKanjouKamoku.GetRowById(kanjouKamokuId);
                var kubunRow = db.MTKamokuKubun.GetFirstRow("where id = " + kanjouRow.GetLong("taisyaku_kamoku_kubun_id", -1));
                int parentKamokuId = (int)kubunRow.GetLong("parent_id", -1);
                var parentKamokuRow = db.MTKamokuKubun.GetRowById(parentKamokuId);

                return "【" + parentKamokuRow.GetStr("name") + "】" + kanjouRow.GetStr("kamoku");
            }
            else {
                return "";
            }
        }
    }
}
