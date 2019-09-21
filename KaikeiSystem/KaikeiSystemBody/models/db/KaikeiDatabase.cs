using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

using KaikeiSystemBody.models.db.tables;
using KaikeiSystemBody.models.db.mtables;


namespace KaikeiSystemBody.models.db
{
    class KaikeiDatabase : AbstractDatabase
    {
        public KaikeiDatabase(string db_path) : base(db_path) {
            AddTable(KaikeiDenpyouMeisai.TABLE_NAME, new KaikeiDenpyouMeisai(this));
            AddTable(MTKamoku.TABLE_NAME, new MTKamoku(this));
            AddTable(MTKaikeiTanni.TABLE_NAME, new MTKaikeiTanni(this));
            AddTable(MTTorihikiKubun.TABLE_NAME, new MTTorihikiKubun(this));
            AddTable(MTDaikubun.TABLE_NAME, new MTDaikubun(this));
            AddTable(MTTekiyou.TABLE_NAME, new MTTekiyou(this));
            AddTable(MTHojoKamoku.TABLE_NAME, new MTHojoKamoku(this));
            AddTable(MTHoujinShisetsu.TABLE_NAME, new MTHoujinShisetsu(this));
            AddTable(MTSetting.TABLE_NAME, new MTSetting(this));
            AddTable(MTIkkatsuSyori.TABLE_NAME, new MTIkkatsuSyori(this));
            AddTable(ZenkiKurikoshiKamoku.TABLE_NAME, new ZenkiKurikoshiKamoku(this));
            AddTable(ZenkiKurikoshiHojoKamoku.TABLE_NAME, new ZenkiKurikoshiHojoKamoku(this));
            AddTable(MTResist.TABLE_NAME, new MTResist(this));
            AddTable(MTShikinSyuushiKoumoku.TABLE_NAME, new MTShikinSyuushiKoumoku(this));
            AddTable(YosanKamoku.TABLE_NAME, new YosanKamoku(this));
            AddTable(YosanHojokamoku.TABLE_NAME, new YosanHojokamoku(this));
            AddTable(YosanDaikubun.TABLE_NAME, new YosanDaikubun(this));
            AddTable(YosanYobihi.TABLE_NAME, new YosanYobihi(this));
            AddTable(MTJigyouKatsudouSyuushiKoumoku.TABLE_NAME, new MTJigyouKatsudouSyuushiKoumoku(this));
            AddTable(TaisyakuTaisyouhyouTyuuki.TABLE_NAME, new TaisyakuTaisyouhyouTyuuki(this));
            AddTable(TaisyakuTaisyouhyouTyuuki1.TABLE_NAME, new TaisyakuTaisyouhyouTyuuki1(this));
            AddTable(TaisyakuTaisyouhyouTyuuki3.TABLE_NAME, new TaisyakuTaisyouhyouTyuuki3(this));
            AddTable(TaisyakuTaisyouhyouTyuuki4.TABLE_NAME, new TaisyakuTaisyouhyouTyuuki4(this));
            AddTable(TaisyakuTaisyouhyouTyuuki5.TABLE_NAME, new TaisyakuTaisyouhyouTyuuki5(this));
            AddTable(TaisyakuTaisyouhyouKyakutyuu.TABLE_NAME, new TaisyakuTaisyouhyouKyakutyuu(this));
            AddTable(MTYosanKubun.TABLE_NAME, new MTYosanKubun(this));
            AddTable(MTSyoukyakuKahi.TABLE_NAME, new MTSyoukyakuKahi(this));
            AddTable(MTSyoukyakuKubun.TABLE_NAME, new MTSyoukyakuKubun(this));
            AddTable(MTSyoukyakuHouhou.TABLE_NAME, new MTSyoukyakuHouhou(this));
            AddTable(MTZoukaJiyuu.TABLE_NAME, new MTZoukaJiyuu(this));
            AddTable(MTTaiyouNennsuu.TABLE_NAME, new MTTaiyouNennsuu(this));
            AddTable(MTKoteiShisan.TABLE_NAME, new MTKoteiShisan(this));
            AddTable(MTKeijouHouhou.TABLE_NAME, new MTKeijouHouhou(this));
            AddTable(MTGensyouJiyuu.TABLE_NAME, new MTGensyouJiyuu(this));
            AddTable(GenkaSyoukyakuMeisai.TABLE_NAME, new GenkaSyoukyakuMeisai(this));
            AddTable(MTKanrisya.TABLE_NAME, new MTKanrisya(this));
            AddTable(MTTaisyakuTaisyouKoumoku.TABLE_NAME, new MTTaisyakuTaisyouKoumoku(this));
            AddTable(MTHoujinDantai.TABLE_NAME, new MTHoujinDantai(this));
            AddTable(MTKaikeiKubun.TABLE_NAME, new MTKaikeiKubun(this));
            //AddTable(MTKaikeiKubunShisetsuInfo.TABLE_NAME, new MTKaikeiKubunShisetsuInfo(this));
            AddTable(MTKamokuKubun.TABLE_NAME, new MTKamokuKubun(this));
            AddTable(MTKanjouKamoku.TABLE_NAME, new MTKanjouKamoku(this));
            AddTable(MTTaisyakuKubun.TABLE_NAME, new MTTaisyakuKubun(this));
            AddTable(YosanKamokuKubun.TABLE_NAME, new YosanKamokuKubun(this));
            AddTable(ZenkiKurikoshiKamokuKubun.TABLE_NAME, new ZenkiKurikoshiKamokuKubun(this));
            AddTable(Tyuuki.TABLE_NAME, new Tyuuki(this));
            AddTable(Tyuuki8.TABLE_NAME, new Tyuuki8(this));
            AddTable(Tyuuki10.TABLE_NAME, new Tyuuki10(this));
            AddTable(Tyuuki11.TABLE_NAME, new Tyuuki11(this));
            AddTable(MTTanpoKubun.TABLE_NAME, new MTTanpoKubun(this));
        }

        public T BackupTable<T>(string baseName, int year, bool createWhenNotExist = false) where T : AbstractTable{
            string tableName = "backup" + year + "_" + baseName;

            AbstractTable table = Table(tableName);

            if (table == null) {
                if (ExistTable(tableName) || createWhenNotExist) {
                    Type type = typeof(T);
                    System.Reflection.ConstructorInfo ctor = type.GetConstructor(new Type[] { typeof(AbstractDatabase), typeof(string) });
                    table = (T)ctor.Invoke(new object[] { this, tableName });
                    AddTable(tableName, table);
                    table.InitTable(createWhenNotExist);
                }
            }

            return table as T;
        }


/*        public KaikeiDenpyouMeisai KaikeiDenpyouMeisaiBackup(int year) {
            return BackupTable<KaikeiDenpyouMeisai>(KaikeiDenpyouMeisai.TABLE_NAME, year, false);
        }

        public ZenkiKurikoshiKamokuKubun ZenkiKurikoshiKamokuKubunBackup(int year) {
            return BackupTable<ZenkiKurikoshiKamokuKubun>(ZenkiKurikoshiKamokuKubun.TABLE_NAME, year, false);
        }

        public ZenkiKurikoshiKamoku ZenkiKurikoshiKamokuBackup(int year) {
            return BackupTable<ZenkiKurikoshiKamoku>(ZenkiKurikoshiKamoku.TABLE_NAME, year, false);
        }
        public ZenkiKurikoshiHojoKamoku ZenkiKurikoshiHojoKamokuBackup(int year) {
            return BackupTable<ZenkiKurikoshiHojoKamoku>(ZenkiKurikoshiHojoKamoku.TABLE_NAME, year, false);
        }

        public bool ExistBackupTables(int year) {
            if (KaikeiDenpyouMeisaiBackup(year) == null || ZenkiKurikoshiKamokuBackup(year) == null) {
                return false;
            }
            return true;
        }


        public db.tables.KaikeiDenpyouMeisai GetMeisaiTable(int year) {
            if (ExistBackupTables(year)) {
                return KaikeiDenpyouMeisaiBackup(year);
            }
            return KaikeiDenpyouMeisai;
        }


        public db.tables.ZenkiKurikoshiKamokuKubun GetZenkiKurikoshiKamokuKubun(int year) {
            if (ExistBackupTables(year)) {
                return ZenkiKurikoshiKamokuKubunBackup(year);
            }
            return ZenkiKurikoshiKamokuKubun;
        }*/


        public KaikeiDenpyouMeisai KaikeiDenpyouMeisai{
            get {
                return this.Table(KaikeiDenpyouMeisai.TABLE_NAME) as KaikeiDenpyouMeisai;
            }
        }

        public MTKamoku MTKamoku {
            get {
                return this.Table(MTKamoku.TABLE_NAME) as MTKamoku;
            }
        }

        public MTKaikeiTanni MTKaikeiTanni {
            get {
                return this.Table(MTKaikeiTanni.TABLE_NAME) as MTKaikeiTanni;
            }
        }

        public MTTorihikiKubun MTTorihikiKubun {
            get {
                return this.Table(MTTorihikiKubun.TABLE_NAME) as MTTorihikiKubun;
            }
        }

        public MTDaikubun MTDaikubun {
            get {
                return this.Table(MTDaikubun.TABLE_NAME) as MTDaikubun;
            }
        }

        public MTTekiyou MTTekiyou {
            get {
                return this.Table(MTTekiyou.TABLE_NAME) as MTTekiyou;
            }
        }

        public MTHojoKamoku MTHojoKamoku {
            get {
                return this.Table(MTHojoKamoku.TABLE_NAME) as MTHojoKamoku;
            }
        }

        public MTHoujinShisetsu MTHoujinShisetsu {
            get {
                return this.Table(MTHoujinShisetsu.TABLE_NAME) as MTHoujinShisetsu;
            }
        }

        public MTSetting MTSetting {
            get {
                return this.Table(MTSetting.TABLE_NAME) as MTSetting;
            }
        }

        public MTIkkatsuSyori MTIkkatsuSyori {
            get {
                return this.Table(MTIkkatsuSyori.TABLE_NAME) as MTIkkatsuSyori;
            }
        }

        public ZenkiKurikoshiKamoku ZenkiKurikoshiKamoku {
            get {
                return this.Table(ZenkiKurikoshiKamoku.TABLE_NAME) as ZenkiKurikoshiKamoku;
            }
        }

        public ZenkiKurikoshiHojoKamoku ZenkiKurikoshiHojoKamoku {
            get {
                return this.Table(ZenkiKurikoshiHojoKamoku.TABLE_NAME) as ZenkiKurikoshiHojoKamoku;
            }
        }

        public MTResist MTResist {
            get {
                return this.Table(MTResist.TABLE_NAME) as MTResist;
            }
        }

        public MTShikinSyuushiKoumoku MTShikinSyuushiKoumoku {
            get {
                return this.Table(MTShikinSyuushiKoumoku.TABLE_NAME) as MTShikinSyuushiKoumoku;
            }
        }

        public YosanKamoku YosanKamoku {
            get {
                return this.Table(YosanKamoku.TABLE_NAME) as YosanKamoku;
            }
        }

        public YosanHojokamoku YosanHojokamoku {
            get {
                return this.Table(YosanHojokamoku.TABLE_NAME) as YosanHojokamoku;
            }
        }

        public YosanDaikubun YosanDaikubun {
            get {
                return this.Table(YosanDaikubun.TABLE_NAME) as YosanDaikubun;
            }
        }

        public YosanYobihi YosanYobihi {
            get {
                return this.Table(YosanYobihi.TABLE_NAME) as YosanYobihi;
            }
        }

        public MTJigyouKatsudouSyuushiKoumoku MTJigyouKatsudouSyuushiKoumoku {
            get {
                return this.Table(MTJigyouKatsudouSyuushiKoumoku.TABLE_NAME) as MTJigyouKatsudouSyuushiKoumoku;
            }
        }

        public TaisyakuTaisyouhyouTyuuki TaisyakuTaisyouhyouTyuuki {
            get {
                return this.Table(TaisyakuTaisyouhyouTyuuki.TABLE_NAME) as TaisyakuTaisyouhyouTyuuki;
            }
        }

        public TaisyakuTaisyouhyouTyuuki1 TaisyakuTaisyouhyouTyuuki1 {
            get {
                return this.Table(TaisyakuTaisyouhyouTyuuki1.TABLE_NAME) as TaisyakuTaisyouhyouTyuuki1;
            }
        }

        public TaisyakuTaisyouhyouTyuuki3 TaisyakuTaisyouhyouTyuuki3 {
            get {
                return this.Table(TaisyakuTaisyouhyouTyuuki3.TABLE_NAME) as TaisyakuTaisyouhyouTyuuki3;
            }
        }

        public TaisyakuTaisyouhyouTyuuki4 TaisyakuTaisyouhyouTyuuki4 {
            get {
                return this.Table(TaisyakuTaisyouhyouTyuuki4.TABLE_NAME) as TaisyakuTaisyouhyouTyuuki4;
            }
        }

        public TaisyakuTaisyouhyouTyuuki5 TaisyakuTaisyouhyouTyuuki5 {
            get {
                return this.Table(TaisyakuTaisyouhyouTyuuki5.TABLE_NAME) as TaisyakuTaisyouhyouTyuuki5;
            }
        }

        public TaisyakuTaisyouhyouKyakutyuu TaisyakuTaisyouhyouKyakutyuu {
            get {
                return this.Table(TaisyakuTaisyouhyouKyakutyuu.TABLE_NAME) as TaisyakuTaisyouhyouKyakutyuu;
            }
        }

        public MTYosanKubun MTYosanKubun {
            get {
                return this.Table(MTYosanKubun.TABLE_NAME) as MTYosanKubun;
            }
        }

        public MTSyoukyakuKahi MTSyoukyakuKahi {
            get {
                return this.Table(MTSyoukyakuKahi.TABLE_NAME) as MTSyoukyakuKahi;
            }
        }

        public MTSyoukyakuKubun MTSyoukyakuKubun {
            get {
                return this.Table(MTSyoukyakuKubun.TABLE_NAME) as MTSyoukyakuKubun;
            }
        }

        public MTSyoukyakuHouhou MTSyoukyakuHouhou {
            get {
                return this.Table(MTSyoukyakuHouhou.TABLE_NAME) as MTSyoukyakuHouhou;
            }
        }

        public MTZoukaJiyuu MTZoukaJiyuu {
            get {
                return this.Table(MTZoukaJiyuu.TABLE_NAME) as MTZoukaJiyuu;
            }
        }

        public MTTaiyouNennsuu MTTaiyouNennsuu {
            get {
                return this.Table(MTTaiyouNennsuu.TABLE_NAME) as MTTaiyouNennsuu;
            }
        }

        public MTKoteiShisan MTKoteiShisan {
            get {
                return this.Table(MTKoteiShisan.TABLE_NAME) as MTKoteiShisan;
            }
        }

        public MTKeijouHouhou MTKeijouHouhou {
            get {
                return this.Table(MTKeijouHouhou.TABLE_NAME) as MTKeijouHouhou;
            }
        }

        public MTGensyouJiyuu MTGensyouJiyuu {
            get {
                return this.Table(MTGensyouJiyuu.TABLE_NAME) as MTGensyouJiyuu;
            }
        }

        public GenkaSyoukyakuMeisai GenkaSyoukyakuMeisai {
            get {
                return this.Table(GenkaSyoukyakuMeisai.TABLE_NAME) as GenkaSyoukyakuMeisai;
            }
        }

        public MTKanrisya MTKanrisya {
            get {
                return this.Table(MTKanrisya.TABLE_NAME) as MTKanrisya;
            }
        }

        public MTTaisyakuTaisyouKoumoku MTTaisyakuTaisyouKoumoku {
            get {
                return this.Table(MTTaisyakuTaisyouKoumoku.TABLE_NAME) as MTTaisyakuTaisyouKoumoku;
            }
        }

        public MTHoujinDantai MTHoujinDantai {
            get {
                return this.Table(MTHoujinDantai.TABLE_NAME) as MTHoujinDantai;
            }
        }

        public MTKaikeiKubun MTKaikeiKubun {
            get {
                return this.Table(MTKaikeiKubun.TABLE_NAME) as MTKaikeiKubun;
            }
        }
/*
        public MTKaikeiKubunShisetsuInfo MTKaikeiKubunShisetsuInfo {
            get {
                return this.Table(MTKaikeiKubunShisetsuInfo.TABLE_NAME) as MTKaikeiKubunShisetsuInfo;
            }
        }
        */
        public MTKamokuKubun MTKamokuKubun {
            get {
                return this.Table(MTKamokuKubun.TABLE_NAME) as MTKamokuKubun;
            }
        }

        public MTKanjouKamoku MTKanjouKamoku {
            get {
                return this.Table(MTKanjouKamoku.TABLE_NAME) as MTKanjouKamoku;
            }
        }

        public MTTaisyakuKubun MTTaisyakuKubun {
            get {
                return this.Table(MTTaisyakuKubun.TABLE_NAME) as MTTaisyakuKubun;
            }
        }

        public YosanKamokuKubun YosanKamokuKubun {
            get {
                return this.Table(YosanKamokuKubun.TABLE_NAME) as YosanKamokuKubun;
            }
        }

        public ZenkiKurikoshiKamokuKubun ZenkiKurikoshiKamokuKubun {
            get {
                return this.Table(ZenkiKurikoshiKamokuKubun.TABLE_NAME) as ZenkiKurikoshiKamokuKubun;
            }
        }

        public Tyuuki Tyuuki {
            get {
                return this.Table(Tyuuki.TABLE_NAME) as Tyuuki;
            }
        }

        public Tyuuki8 Tyuuki8 {
            get {
                return this.Table(Tyuuki8.TABLE_NAME) as Tyuuki8;
            }
        }

        public Tyuuki10 Tyuuki10 {
            get {
                return this.Table(Tyuuki10.TABLE_NAME) as Tyuuki10;
            }
        }

        public Tyuuki11 Tyuuki11 {
            get {
                return this.Table(Tyuuki11.TABLE_NAME) as Tyuuki11;
            }
        }

        public MTTanpoKubun MTTanpoKubun {
            get {
                return this.Table(MTTanpoKubun.TABLE_NAME) as MTTanpoKubun;
            }
        }
    }
}
