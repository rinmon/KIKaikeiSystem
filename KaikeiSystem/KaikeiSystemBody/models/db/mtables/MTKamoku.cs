using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// MT科目
    /// </summary>
    class MTKamoku : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_kamoku";

        private Dictionary<string, Row> kamokuCode2RowCache;
        private SortedList<char, int> firstCharList;

        public MTKamoku(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("kamoku", ColumnType.TypeString, "");            // 科目
            base.AddColumn("kamoku_yomi", ColumnType.TypeString, "");       // 科目よみ
            base.AddColumn("hojo_kamoku_ari", ColumnType.TypeBool, "");     // 補助科目あり
            base.AddColumn("daikubun_id", ColumnType.TypeInt, "");          // 大区分ID
            base.AddColumn("seiri_bangou", ColumnType.TypeInt, "");         // 整理番号
            base.AddColumn("zenki_kurikoshi", ColumnType.TypeInt, "");      // 前期繰越
            base.AddColumn("zenzenki_kurikoshi", ColumnType.TypeInt, "");   // 前前期繰越
            base.AddColumn("taisyaku_kubun", ColumnType.TypeString, "");    // 貸借区分
            base.AddColumn("shiyou_kubun", ColumnType.TypeBool, "");        // 使用区分
            base.AddColumn("hurikae_taisyou", ColumnType.TypeString, "");   // 振替対象
            base.AddColumn("yosan", ColumnType.TypeInt, "");                // 予算
            base.AddColumn("zennnendo_yosan", ColumnType.TypeInt, "");      // 前年度予算
            base.AddColumn("seiretsu_jun", ColumnType.TypeInt, "");         // 整列順
            base.AddColumn("kamoku_code", ColumnType.TypeString, "");       // 科目コード
            base.AddColumn("daikubun_code", ColumnType.TypeString, "");     // 大区分コード
            base.AddColumn("seiretu_code", ColumnType.TypeString, "");      // 整列コード
            base.AddColumn("hosei_yosan", ColumnType.TypeInt, "");          // 補正予算
            base.AddColumn("daitai_kamoku_code", ColumnType.TypeString, "");// 代替科目コード
            base.AddColumn("daitai_kamoku_bangou", ColumnType.TypeInt, ""); // 代替科目番号

            kamokuCode2RowCache = new Dictionary<string, Row>();
            firstCharList = new SortedList<char, int>();
        }


        public Dictionary<string, Row> KamokuCode2RowCache {
            get {
                return kamokuCode2RowCache;
            }
        }

        public SortedList<char, int> FirstCharList {
            get {
                return firstCharList;
            }
        }


        public Row GetRowFromCodeCache(string code) {
            if (code == null) {
                return null;
            }
            if(kamokuCode2RowCache.ContainsKey(code)){
                return kamokuCode2RowCache[code];
            }
            return null;
        }


        public override void UpdateCache() {
            base.UpdateCache();

            kamokuCode2RowCache.Clear();
            firstCharList.Clear();
            foreach (var row in base.RowCache.Values) {
                string code = row.GetStr("kamoku_code");
                kamokuCode2RowCache[code] = row;

                firstCharList[row.GetStr("kamoku_yomi", " ")[0]] = 1;
            }
        }


        public Row GetDaikubunFromId(int kamokuId) {
            Row kamokuRow = this.GetRowFromCache(kamokuId);
            if(kamokuRow == null){
                return null;
            }
            int daikubunId = (int)kamokuRow.GetLong("daikubun_id", 0);

            return (OwnerDB as KaikeiDatabase).MTDaikubun.GetRowFromCache(daikubunId);
        }


        public Row GetShikinSyuushiKoumokuFromId(int kamokuId) {
            Row daikubun = GetDaikubunFromId(kamokuId);

            if (daikubun == null) {
                return null;
            }

            int syuushiId = (int)daikubun.GetLong("shikin_syuushi_id", 0);
            return (OwnerDB as KaikeiDatabase).MTShikinSyuushiKoumoku.GetRowFromCache(syuushiId);
        }


        public constants.SyuushiType GetSyuushiTypeOfShikinSyuushiFromId(int kamokuId) {
            Row syuushiRow = GetShikinSyuushiKoumokuFromId(kamokuId);

            if (syuushiRow == null) {
                return constants.SyuushiType.None;
            }
            return (OwnerDB as KaikeiDatabase).MTShikinSyuushiKoumoku.GetSyuushiTypeFromId((int)syuushiRow.GetLong("id", 0));
        }


        public constants.SyuushiType GetSyuushiTypeOfJigyouKatsudouFromId(int kamokuId) {
            Row daikubunRow = GetDaikubunFromId(kamokuId);

            if (daikubunRow == null) {
                return constants.SyuushiType.None;
            }
            return (OwnerDB as KaikeiDatabase).MTDaikubun.GetSyuushiTypeOfJigyouKatsudouFromId((int)daikubunRow.GetLong("id", 0));
        }


        public constants.Taisyaku GetTaisyakuFromId(int kamokuId) {
            if (this.RowCache.ContainsKey(kamokuId)) {
                return GetTaisyakuOfRow(this.RowCache[kamokuId]);
            }
            else {
                return constants.Taisyaku.None;
            }
        }


        public constants.Taisyaku GetTaisyakuOfRow(Row row) {
            int daikubunId = (int)row.GetLong("daikubun_id", 0);
            Row daikubunRow = (this.OwnerDB as KaikeiDatabase).MTDaikubun.GetRowFromCache(daikubunId);

            if (daikubunRow == null) {
                return constants.Taisyaku.None;
            }

            int shikinSyuushiId = (int)daikubunRow.GetLong("shikin_syuushi_id", 0);

            if (shikinSyuushiId == 0) {
                int taisyakuId = (int)daikubunRow.GetLong("taisyaku_taisyou_id", 0);
                if (taisyakuId == 1) { // 資産の部
                    return constants.Taisyaku.Karikata;
                }
                else if (taisyakuId == 2 || taisyakuId == 3) {  //純資産、負債
                    return constants.Taisyaku.Kashikata;
                }
                else {
                    return constants.Taisyaku.None;
                }
            }
            else if (shikinSyuushiId == 1 || shikinSyuushiId == 3 || shikinSyuushiId == 5) { // 収入
                return constants.Taisyaku.Kashikata;
            }
            else{   // 支出
                return constants.Taisyaku.Karikata;
            }
        }


        public bool IsRyuudouShisanKamoku(int kamokuId) {
            Row daikubunRow = GetDaikubunFromId(kamokuId);

            if (daikubunRow == null) {
                return false;
            }

            return daikubunRow.GetStr("daikubun", "") == "【流動資産】";
        }


        public bool IsRyuudouHusaiKamoku(int kamokuId) {
            Row daikubunRow = GetDaikubunFromId(kamokuId);

            if (daikubunRow == null) {
                return false;
            }

            return daikubunRow.GetStr("daikubun", "") == "【流動負債】";
        }


        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("id", CSVParser.ReadInt(token[0]));
                    row.Set("kamoku", CSVParser.ReadString(token[1]));
                    row.Set("kamoku_yomi", CSVParser.ReadString(token[2]));
                    row.Set("hojo_kamoku_ari", CSVParser.ReadBool(token[3]));
                    row.Set("daikubun_id", CSVParser.ReadInt(token[4]));
                    row.Set("seiri_bangou", CSVParser.ReadInt(token[5]));
                    row.Set("zenki_kurikoshi", CSVParser.ReadAmount(token[6]));
                    row.Set("zenzenki_kurikoshi", CSVParser.ReadAmount(token[7]));
                    row.Set("taisyaku_kubun", CSVParser.ReadString(token[8]));
                    row.Set("shiyou_kubun", CSVParser.ReadBool(token[9]));
                    row.Set("hurikae_taisyou", CSVParser.ReadString(token[10]));
                    row.Set("yosan", CSVParser.ReadAmount(token[11]));
                    row.Set("zennnendo_yosan", CSVParser.ReadAmount(token[12]));
                    row.Set("seiretsu_jun", CSVParser.ReadInt(token[13]));
                    row.Set("kamoku_code", CSVParser.ReadString(token[14]));
                    row.Set("daikubun_code", CSVParser.ReadString(token[15]));
                    row.Set("seiretu_code", CSVParser.ReadString(token[16]));
                    row.Set("hosei_yosan", CSVParser.ReadAmount(token[17]));
                    row.Set("daitai_kamoku_code", CSVParser.ReadString(token[21]));
                    row.Set("daitai_kamoku_bangou", CSVParser.ReadInt(token[22]));
                    this.Insert(row);
                }
            }
        }
    }
}
