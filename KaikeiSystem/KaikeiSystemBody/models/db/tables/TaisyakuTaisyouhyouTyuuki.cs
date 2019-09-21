using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.tables
{
    /// <summary>
    /// 貸借対照表注記
    /// </summary>
    class TaisyakuTaisyouhyouTyuuki : AbstractTable
    {
        public const string TABLE_NAME = "taisyaku_taisyouhyou_tyuuki";

        public TaisyakuTaisyouhyouTyuuki(AbstractDatabase db, string tableName = TABLE_NAME)
            : base(db, tableName) {
            base.AddColumn("nenndo", ColumnType.TypeInt, "");               // 年度
            base.AddColumn("juuyou_henkou", ColumnType.TypeString, "");     // 重要な会計方針の変更
            base.AddColumn("juuyou_kouhatsu", ColumnType.TypeString, "");   // 重要な後発事象
        }

        
        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    object id = CSVParser.ReadInt(token[0]);
                    if (id == null) {
                        continue;
                    }
                    row.Set("id", id);
                    row.Set("nenndo", ((DateTime)CSVParser.ReadDate(token[1])).Year);
                    row.Set("juuyou_henkou", CSVParser.ReadString(token[2]));
                    row.Set("juuyou_kouhatsu", CSVParser.ReadString(token[3]));
                    this.Insert(row);
                }
            }
        }
    }
}
