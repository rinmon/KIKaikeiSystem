using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.tables
{
    /// <summary>
    /// 会計伝票明細
    /// </summary>
    class ZenkiKurikoshiHojoKamoku : AbstractTable
    {
        public const string TABLE_NAME = "zenki_kurikoshi_hojo_kamoku";

        public ZenkiKurikoshiHojoKamoku(AbstractDatabase db, string tableName = TABLE_NAME)
            : base(db, tableName) {
            base.AddColumn("keiri_kubun", ColumnType.TypeInt, "");                                // 経理区分
            base.AddColumn("nenndo", ColumnType.TypeDate, "");                                    // 年度
            base.AddColumn("hojo_id", ColumnType.TypeInt, "");                                    // 補助科目ID
            base.AddColumn("zenki_kurikoshi_gaku", ColumnType.TypeAmount, "");                    // 前期繰越額
            base.AddColumn("taisyaku_kubun", ColumnType.TypeString, "");                          // 貸借区分
        }

        
        override public void LoadCSV(string filename) {
            OwnerDB.BeginTransaction();

            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("keiri_kubun", CSVParser.ReadInt(token[1]));
                    row.Set("nenndo", CSVParser.ReadDate(token[2]));
                    row.Set("hojo_id", CSVParser.ReadInt(token[3]));
                    row.Set("zenki_kurikoshi_gaku", CSVParser.ReadAmount(token[4]));
                    row.Set("taisyaku_kubun", CSVParser.ReadString(token[5]));
                    this.Insert(row);
                }
            }

            OwnerDB.CommitTransaction();
        }
    }
}
