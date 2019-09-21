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
    class TaisyakuTaisyouhyouKyakutyuu : AbstractTable
    {
        public const string TABLE_NAME = "taisyaku_taisyouhyou_kyakutyuu";

        public TaisyakuTaisyouhyouKyakutyuu(AbstractDatabase db, string tableName = TABLE_NAME)
            : base(db, tableName) {
            base.AddColumn("tyuuki_id", ColumnType.TypeInt, "");                            // 貸借対照注記ID
            base.AddColumn("kaikei_kubun", ColumnType.TypeInt, "");                          // 経理区分
            base.AddColumn("genka_baikyaku_ruikei", ColumnType.TypeAmount, "");             // 減価償却累計額
            base.AddColumn("tyousyuu_hunou_kin", ColumnType.TypeAmount, "");                // 徴収不能金
        }

        
        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("tyuuki_id", CSVParser.ReadInt(token[0]));
                    row.Set("keiri_kubun", CSVParser.ReadInt(token[1]));
                    row.Set("genka_baikyaku_ruikei", CSVParser.ReadAmount(token[2]));
                    row.Set("tyousyuu_hunou_kin", CSVParser.ReadAmount(token[3]));
                    this.Insert(row);
                }
            }
        }
    }
}
