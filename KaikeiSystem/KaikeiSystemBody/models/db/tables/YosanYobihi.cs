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
    class YosanYobihi : AbstractTable
    {
        public const string TABLE_NAME = "yosan_yobihi";

        public YosanYobihi(AbstractDatabase db, string tableName = TABLE_NAME)
            : base(db, tableName) {
            base.AddColumn("nenndo", ColumnType.TypeInt, "");           // 年度
            base.AddColumn("kaikei_kubun", ColumnType.TypeInt, "");      // 会計区分
            base.AddColumn("yosan_kubun", ColumnType.TypeInt, "");   // 予算区分
            base.AddColumn("hosei_kaisuu", ColumnType.TypeInt, "");     // 補正回数
            base.AddColumn("yobihi", ColumnType.TypeAmount, "");         // 予算額
            base.AddColumn("zenkimatsu_shiharai_shikin_zandaka", ColumnType.TypeAmount, "");         // 前期末支払資金残高
            base.AddColumn("create_date", ColumnType.TypeDate, "");           // 作成日
            base.AddColumn("created_at", ColumnType.TypeDate, "");           // 登録日 (insert時に自動で登録される)
            base.AddColumn("updated_at", ColumnType.TypeDate, "");           // 更新日

            base.AddIndex("create index " + tableName + "_index on " + tableName + "(nenndo, kaikei_kubun, yosan_kubun, hosei_kaisuu)");
        }

        
        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("id", CSVParser.ReadInt(token[0]));
                    row.Set("nenndo", ((DateTime)CSVParser.ReadDate(token[1])).Year);
                    row.Set("keiri_kubun", CSVParser.ReadInt(token[2]));
                    row.Set("yosan_kubun", CSVParser.ReadInt(token[3]));
                    row.Set("hosei_kaisuu", CSVParser.ReadInt(token[4]));
                    row.Set("yobihi", CSVParser.ReadAmount(token[5]));
                    row.Set("zenkimatsu_shiharai_shikin_zandaka", CSVParser.ReadAmount(token[6]));
                    this.Insert(row);
                }
            }
        }
    }
}
