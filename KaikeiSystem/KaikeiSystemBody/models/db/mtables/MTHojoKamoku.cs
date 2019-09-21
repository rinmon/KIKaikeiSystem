using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// MT補助科目
    /// </summary>
    class MTHojoKamoku : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_hojo_kamoku";

        private Dictionary<int, Row> seiri2row_cache_;

        public MTHojoKamoku(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("hojo_kamoku", ColumnType.TypeString, "");           // 補助科目
            base.AddColumn("kamoku_id", ColumnType.TypeInt, "");                // 科目ID
            base.AddColumn("zenki_kurikoshi", ColumnType.TypeInt, "");          // 前期繰越
            base.AddColumn("zenzenki_kurikoshi", ColumnType.TypeInt, "");       // 前前期繰越
            base.AddColumn("kimatsu_zandaka", ColumnType.TypeInt, "");          // 期末残高
            base.AddColumn("seiri_bangou", ColumnType.TypeInt, "");             // 整理番号
            base.AddColumn("yosan", ColumnType.TypeInt, "");                    // 予算
            base.AddColumn("zennnendo_yosan", ColumnType.TypeInt, "");          // 前年度予算
            base.AddColumn("hosei_yosan", ColumnType.TypeInt, "");              // 補正予算
            base.AddColumn("keiri_kubun", ColumnType.TypeInt, "");              // 経理区分

            seiri2row_cache_ = new Dictionary<int, Row>();
        }

        public Row SearchFromSeiri(int kamoku_id, int seiri_bangou) {
            foreach (var row in base.RowCache.Values) {
                if(row.IsNull("kamoku_id") || row.IsNull("seiri_bangou")){
                    continue;
                }
                else if (row.GetLong("kamoku_id", -1) == kamoku_id && row.GetLong("seiri_bangou", -1) == seiri_bangou) {
                    return row;
                }
            }
            return null;
        }


        public Dictionary<int, Row> Seiri2RowCache {
            get {
                return seiri2row_cache_;
            }
        }

        public override void UpdateCache() {
            base.UpdateCache();

            seiri2row_cache_.Clear();
            foreach (var row in base.RowCache.Values) {
                int seiri = (int)row.GetLong("seiri_bangou", -1);
                seiri2row_cache_[seiri] = row;
            }
        }


        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("id", CSVParser.ReadInt(token[0]));
                    row.Set("hojo_kamoku", CSVParser.ReadString(token[1]));
                    row.Set("kamoku_id", CSVParser.ReadInt(token[2]));
                    row.Set("zenki_kurikoshi", CSVParser.ReadAmount(token[3]));
                    row.Set("zenzenki_kurikoshi", CSVParser.ReadAmount(token[4]));
                    row.Set("kimatsu_zandaka", CSVParser.ReadAmount(token[5]));
                    row.Set("seiri_bangou", CSVParser.ReadInt(token[6]));
                    row.Set("yosan", CSVParser.ReadAmount(token[7]));
                    row.Set("zennnendo_yosan", CSVParser.ReadAmount(token[8]));
                    row.Set("hosei_yosan", CSVParser.ReadAmount(token[9]));
                    row.Set("keiri_kubun", CSVParser.ReadInt(token[10]));
                    this.Insert(row);
                }
            }
        }
    }
}
