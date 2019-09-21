using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// 大区分
    /// </summary>
    class MTDaikubun : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_daikubun";
        private Dictionary<string, Row> daikubunCode2RowCache;

        public MTDaikubun(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("daikubun", ColumnType.TypeString, "");              // 大区分
            base.AddColumn("shikin_syuushi_id", ColumnType.TypeInt, "");        // 資金収支ID
            base.AddColumn("jigyou_katsudou_id", ColumnType.TypeInt, "");       // 事業活動ID
            base.AddColumn("taisyaku_taisyou_id", ColumnType.TypeInt, "");      // 貸借対照ID
            base.AddColumn("id2", ColumnType.TypeInt, "");                      // ID
            base.AddColumn("yosan", ColumnType.TypeInt, "");                    // 予算
            base.AddColumn("zennnendo_yosan", ColumnType.TypeInt, "");          // 前年度予算
            base.AddColumn("daikubun_code", ColumnType.TypeString, "");         // 大区分コード

            daikubunCode2RowCache = new Dictionary<string, Row>();
        }

        public Row GetRowFromCodeCache(string code) {
            if (code == null) {
                return null;
            }
            if (daikubunCode2RowCache.ContainsKey(code)) {
                return daikubunCode2RowCache[code];
            }
            return null;
        }
        
        
        public override void UpdateCache() {
            base.UpdateCache();

            daikubunCode2RowCache.Clear();
            foreach (var row in base.RowCache.Values) {
                string code = row.GetStr("daikubun_code");
                daikubunCode2RowCache[code] = row;
            }
        }


        public constants.SyuushiType GetSyuushiTypeOfShikinSyuushiFromId(int daikubunId) {
            Row daikubunRow = this.GetRowFromCache(daikubunId);
            if (daikubunRow == null) {
                return constants.SyuushiType.None;
            }

            int syuushi = (int)daikubunRow.GetLong("shikin_syuushi_id", 0);

            return (OwnerDB as KaikeiDatabase).MTShikinSyuushiKoumoku.GetSyuushiTypeFromId(syuushi);
        }


        public constants.SyuushiType GetSyuushiTypeOfJigyouKatsudouFromId(int daikubunId) {
            Row daikubunRow = this.GetRowFromCache(daikubunId);
            if (daikubunRow == null) {
                return constants.SyuushiType.None;
            }

            int jigyouKatsudou = (int)daikubunRow.GetLong("jigyou_katsudou_id", 0);
            if (jigyouKatsudou == 1 || jigyouKatsudou == 3 || jigyouKatsudou == 5) {
                return constants.SyuushiType.Syuunyuu;
            }
            if (daikubunId == 47 || daikubunId == 49) {
                return constants.SyuushiType.Syuunyuu;
            }

            return constants.SyuushiType.Shisyutsu;
        }



        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("id", CSVParser.ReadInt(token[0]));
                    row.Set("daikubun", CSVParser.ReadString(token[1]));
                    row.Set("shikin_syuushi_id", CSVParser.ReadInt(token[2]));
                    row.Set("jigyou_katsudou_id", CSVParser.ReadInt(token[3]));
                    row.Set("taisyaku_taisyou_id", CSVParser.ReadInt(token[4]));
                    row.Set("id2", CSVParser.ReadInt(token[5]));
                    row.Set("yosan", CSVParser.ReadAmount(token[6]));
                    row.Set("zennnendo_yosan", CSVParser.ReadAmount(token[7]));
                    row.Set("daikubun_code", CSVParser.ReadString(token[8]));
                    this.Insert(row);
                }
            }
        }
    }
}
