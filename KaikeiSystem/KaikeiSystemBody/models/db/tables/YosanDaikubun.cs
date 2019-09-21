using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.tables
{
    /// <summary>
    /// 予算（科目）
    /// </summary>
    class YosanDaikubun : AbstractTable
    {
        public const string TABLE_NAME = "yosan_daikubun";

        public YosanDaikubun(AbstractDatabase db, string tableName = TABLE_NAME)
            : base(db, tableName) {
            base.AddColumn("yosan_kubun", ColumnType.TypeInt, "");      // 予算区分
            base.AddColumn("keiri_kubun", ColumnType.TypeInt, "");      // 経理区分
            base.AddColumn("nenndo", ColumnType.TypeInt, "");           // 年度
            base.AddColumn("daikubun_id", ColumnType.TypeInt, "");       // 科目ID
            base.AddColumn("yosan", ColumnType.TypeAmount, "");         // 予算額
            base.AddColumn("hosei_kaisuu", ColumnType.TypeInt, "");     // 補正回数
            base.AddColumn("daikubun_yosan", ColumnType.TypeAmount, "");// 予算額

            base.AddIndex("create index " + tableName + "_index on " + tableName + "(nenndo, keiri_kubun, yosan_kubun, hosei_kaisuu)");
        }

        
        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("id", CSVParser.ReadInt(token[0]));
                    row.Set("yosan_kubun", CSVParser.ReadInt(token[1]));
                    row.Set("keiri_kubun", CSVParser.ReadInt(token[2]));
                    row.Set("nenndo", ((DateTime)CSVParser.ReadDate(token[4])).Year);
                    row.Set("daikubun_id", CSVParser.ReadInt(token[3]));
                    row.Set("yosan", CSVParser.ReadAmount(token[5]));
                    row.Set("hosei_kaisuu", CSVParser.ReadInt(token[6]));
                    row.Set("daikubun_yosan", CSVParser.ReadAmount(token[7]));
                    this.Insert(row);
                }
            }
        }
    }
}
