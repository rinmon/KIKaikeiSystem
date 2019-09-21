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
    class TaisyakuTaisyouhyouTyuuki5 : AbstractTable
    {
        public const string TABLE_NAME = "taisyaku_taisyouhyou_tyuuki5";

        public TaisyakuTaisyouhyouTyuuki5(AbstractDatabase db, string tableName = TABLE_NAME)
            : base(db, tableName) {
            base.AddColumn("tyuuki_id", ColumnType.TypeInt, "");            // 貸借対照注記ID
            base.AddColumn("kaikei_kubun", ColumnType.TypeInt, "");         // 会計区分
            base.AddColumn("tanpo_kubun", ColumnType.TypeInt, "");          // 担保区分
            base.AddColumn("kamoku_id", ColumnType.TypeInt, "");            // 勘定科目ID
            base.AddColumn("amount", ColumnType.TypeAmount, "");            // 金額
        }

        
        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("tyuuki_id", CSVParser.ReadInt(token[0]));
                    row.Set("keiri_kubun", CSVParser.ReadInt(token[1]));
                    row.Set("tanpo_kubun", CSVParser.ReadInt(token[2]));
                    row.Set("kamoku_id", CSVParser.ReadInt(token[3]));
                    row.Set("amount", CSVParser.ReadAmount(token[4]));
                    this.Insert(row);
                }
            }
        }
    }
}
