using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.query
{
    class Tyuuki
    {
        public enum RowType
        {
            KeizokuJigyouZentaiTyuuki = 1,
            JuuyouKaikeihoushin = 2,
            JuuyouKaikeihoushinHenkou = 3,
            HoujinTaisyokuKyuuhuSeido = 4,
            HoujinSakuseiZaimushyohyou = 5,
            KihonzaisanZougen = 6,
            Torikuzushi = 7,
            Tanpo = 8,
            Koteishisan = 9,
            Saiken = 10,
            MankiSyouken = 11,
            TorihikiNaiyou = 12,
            JuuyouGuhatsuSaimu = 13,
            JuuyouKouhatsuJisyou = 14,
            Sonota = 15,
        }


        public class TyuukiRow
        {
            public int RowId{get;set;}
            public int RowType{get;set;}
            public string Contents{get;set;}

            public TyuukiRow(int id, int type, string contents) {
                RowId = id;
                RowType = type;
                Contents = contents;
            }
        };

        // 固定資産の増減
        public class KoteishisanRow
        {
            public string Name { get; set; }
            public long ZenkiZandaka { get; set; }
            public long ToukiZouka { get; set; }
            public long ToukiGensyou { get; set; }
            public long ToukimatsuZandaka { get; set; }

            public KoteishisanRow(string name, long zenkiZandaka, long toukiZouka, long toukiGensyou, long toukimatsuZandaka) {
                Name = name;
                ZenkiZandaka = zenkiZandaka;
                ToukiZouka = toukiZouka;
                ToukiGensyou = toukiGensyou;
                ToukimatsuZandaka = toukimatsuZandaka;
            }
        }

        // 担保
        public class TanpoRow{
            public int TanpoKubun { get; set; }
            public string Name { get; set; }
            public long Amount { get; set; }

            public TanpoRow(int tanpoKubun, string name, long amount) {
                TanpoKubun = tanpoKubun;
                Name = name;
                Amount = amount;
            }
        }

        // 固定資産の減価償却
        public class ShisanRow {
            public string Name { get; set; }
            public long SyutokuKagaku { get; set; }
            public long GenkaSyoukyaku { get; set; }
            public long Zandaka { get; set; }
        }

        // 債権等
        public class SaikenRow {
            public string Name { get; set; }
            public long SaikenGaku { get; set; }
            public long TyousyuuFunoukin { get; set; }
            public long SaikenZandaka { get; set; }
        }

        // 満期債券
        public class MankiSaikenRow {
            public string Name { get; set; }
            public long TyouboKagaku { get; set; }
            public long Jika { get; set; }
            public long HyoukaSoneki { get; set; }
        }

        
        private db.KaikeiDatabase db;
        private List<TyuukiRow> rows;
        private List<KoteishisanRow> koteiShisanRows;
        private List<TanpoRow> tanpoKubunRows;
        private List<ShisanRow> shisanRows;
        private List<SaikenRow> saikenRows;
        private List<MankiSaikenRow> mankiSaikenRows;

        public List<TyuukiRow> GetRows() {
            return rows;
        }

        public List<KoteishisanRow> GetTKoteiShisanRows() {
            return koteiShisanRows;
        }
        public List<TanpoRow> GetTanpoRows() {
            return tanpoKubunRows;
        }
        public List<ShisanRow> GetShisanRows() {
            return shisanRows;
        }
        public List<SaikenRow> GetSaikenRows() {
            return saikenRows;
        }
        public List<MankiSaikenRow> GetMankiSaikenRows() {
            return mankiSaikenRows;
        }

        public Tyuuki(db.KaikeiDatabase aDB) {
            db = aDB;
        }


        public DateTime StartDate {
            get;
            private set;
        }

        public int KaikeiKubun {
            get;
            private set;
        }

        public int Nenndo {
            get {
                return helper.Converter.GetNenndo(StartDate);
            }
        }

        public bool IsRootKaikeiKubun {
            get {
                return KaikeiKubun == db.MTKaikeiKubun.RootNodeId;
            }
        }

        public Dictionary<int, bool> HideRows {
            get;
            private set;
        }

        public bool Calc(DateTime startDate, int kaikeiKubun, Dictionary<int, bool> hideRows){
            StartDate = startDate;
            KaikeiKubun = kaikeiKubun;
            HideRows = hideRows;

            rows = new List<TyuukiRow>();
            koteiShisanRows = new List<KoteishisanRow>();
            tanpoKubunRows = new List<TanpoRow>();
            shisanRows = new List<ShisanRow>();
            saikenRows = new List<SaikenRow>();
            mankiSaikenRows = new List<MankiSaikenRow>();

            int tyuukiId = ReadStrTyuuki();
            if (tyuukiId == -1) {
                return false;
            }

            ReadTyuukiKoteiShisan(tyuukiId);
            ReadTyuukiTanpo(tyuukiId);
            ReadTyuukiSaiken(tyuukiId);
            ReadTyuukiMankiSaiken(tyuukiId);

            return true;
        }

        public int ReadStrTyuuki() {
            var row = db.Tyuuki.GetFirstRow("where nenndo = " + Nenndo + " and kaikei_kubun_id = " + KaikeiKubun);

            if (row == null) {
                return -1;
            }

            int ct = 1;

            for (int i = (int)RowType.KeizokuJigyouZentaiTyuuki; i <= (int)RowType.Sonota; i++) {
                // 拠点の注記では表示しない項目
                if (IsRootKaikeiKubun == false) {
                    if (i == (int)RowType.KeizokuJigyouZentaiTyuuki ||
                            i == (int)RowType.TorihikiNaiyou ||
                            i == (int)RowType.JuuyouGuhatsuSaimu) {
                        continue;
                    }
                }

                if (HideRows.ContainsKey(i)) {
                    continue;
                }
                string key = "tyuuki" + i;
                if (row.ContainsColumn(key)) {
                    rows.Add(new TyuukiRow(ct, i, row.GetStr(key)));
                }
                else {
                    rows.Add(new TyuukiRow(ct, i, ""));
                }
                ct++;
            }

            return row.GetId();
        }

        private void ReadTyuukiKoteiShisan(int tyuukiId) {
            KoteiShisanMeisai kotei = new KoteiShisanMeisai(db);
            kotei.Calc(helper.Converter.DateTimeToNenndoKisannbi(StartDate),
                helper.Converter.DateTimeToNenndoKimatsubi(StartDate), KaikeiKubun);

            foreach (var row in kotei.GetMeisaiList()) {
                if (row.Type == KoteiShisanMeisai.KoteiShisanType.KihonZaisan) {
                    koteiShisanRows.Add(new KoteishisanRow(
                        row.KamokuName,
                        row.Col0,
                        row.Col1,
                        row.Col2 + row.Col3,
                        row.Col4));
                }

                if (row.Col6 != 0) {
                    var shisanRow = new ShisanRow();
                    shisanRow.Name = row.KamokuName;
                    if(row.Type == KoteiShisanMeisai.KoteiShisanType.KihonZaisan){
                        shisanRow.Name += "（基本財産）";
                    }
                    shisanRow.SyutokuKagaku = row.Col6;
                    shisanRow.GenkaSyoukyaku = row.Col5;
                    shisanRow.Zandaka = row.Col4;
                    shisanRows.Add(shisanRow);
                }
            }
        }

        private void ReadTyuukiTanpo(int tyuukiId) {
            foreach (var row in db.Tyuuki8.Select("where tyuuki_id=" + tyuukiId)) {
                string name = "";
                models.db.Row kamokuKubunRow = db.MTKamokuKubun.GetRowById((int)row.GetLong("kamoku_kubun_id", -1));
                if (kamokuKubunRow != null) {
                    name += kamokuKubunRow.GetStr("name");
                    models.db.Row parent = db.MTKamokuKubun.GetParentOf(kamokuKubunRow);
                    if(parent != null){
                        if (parent.GetId() == (int)models.constants.MTKamokuKubun.KoteiShisanKihonZaisan) {
                            name += "（基本財産）";
                        }
                        if (parent.GetId() == (int)models.constants.MTKamokuKubun.KoteiShisanSonota) {
                            name += "（その他の固定資産）";
                        }
                    }
                }

                TanpoRow tanpoRow = new TanpoRow((int)row.GetLong("tanpo_kubun_id", -1), name, row.GetLong("amount", 0));
                tanpoKubunRows.Add(tanpoRow);
            }
        }


        private void ReadTyuukiSaiken(int tyuukiId) {
            foreach (var row in db.Tyuuki10.Select("where tyuuki_id=" + tyuukiId)) {
                string name = "";
                models.db.Row kamokuKubunRow = db.MTKamokuKubun.GetRowById((int)row.GetLong("kamoku_kubun_id", -1));
                if (kamokuKubunRow != null) {
                    name += kamokuKubunRow.GetStr("name");
                }
                SaikenRow saikenRow = new SaikenRow();
                saikenRow.Name = name;
                saikenRow.SaikenGaku = row.GetLong("saiken_gaku", 0);
                saikenRow.TyousyuuFunoukin = row.GetLong("tyousyuuhunoukin_zandaka", 0);
                saikenRow.SaikenZandaka = row.GetLong("toukimatsu_zandaka", 0);
                saikenRows.Add(saikenRow);
            }
        }

    
        private void ReadTyuukiMankiSaiken(int tyuukiId) {
            foreach (var row in db.Tyuuki11.Select("where tyuuki_id=" + tyuukiId)) {
                MankiSaikenRow saikenRow = new MankiSaikenRow();
                saikenRow.Name = row.GetStr("caption");
                saikenRow.TyouboKagaku = row.GetLong("tyoubo_kagaku", 0);
                saikenRow.Jika = row.GetLong("jika", 0);
                saikenRow.HyoukaSoneki = row.GetLong("hyouka_soneki", 0);
                mankiSaikenRows.Add(saikenRow);
            }
        }
    }
}
