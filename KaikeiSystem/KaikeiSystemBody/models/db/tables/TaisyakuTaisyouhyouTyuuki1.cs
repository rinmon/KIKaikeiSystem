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
    class TaisyakuTaisyouhyouTyuuki1 : AbstractTable
    {
        public const string TABLE_NAME = "taisyaku_taisyouhyou_tyuuki1";

        public TaisyakuTaisyouhyouTyuuki1(AbstractDatabase db, string tableName = TABLE_NAME)
            : base(db, tableName) {
            base.AddColumn("tyuuki_id", ColumnType.TypeInt, "");            // 貸借対照注記ID
            base.AddColumn("seiri_bangou", ColumnType.TypeInt, "");         // 整理番号
            base.AddColumn("koumoku_mei", ColumnType.TypeString, "");       // 項目名
            base.AddColumn("naiyou", ColumnType.TypeString, "");            // 内容
        }

        
        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("tyuuki_id", CSVParser.ReadInt(token[0]));
                    row.Set("seiri_bangou", CSVParser.ReadInt(token[1]));
                    row.Set("koumoku_mei", CSVParser.ReadString(token[2]));
                    row.Set("naiyou", CSVParser.ReadString(token[3]));
                    this.Insert(row);
                }
            }
        }
    }
}
