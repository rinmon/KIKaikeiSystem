using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// MT耐用年数
    /// </summary>
    class MTTaiyouNennsuu : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_taiyou_nennsuu";

        public MTTaiyouNennsuu(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("seiri_bangou", ColumnType.TypeInt, "");               // 整理番号
            base.AddColumn("shisan_meisyou", ColumnType.TypeString, "");               // 資産名称
            base.AddColumn("taiyou_nennsuu", ColumnType.TypeInt, "");               // 耐用年数
        }


        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("id", CSVParser.ReadInt(token[0]));
                    row.Set("seiri_bangou", CSVParser.ReadInt(token[1]));
                    row.Set("shisan_meisyou", CSVParser.ReadString(token[2]));
                    row.Set("taiyou_nennsuu", CSVParser.ReadInt(token[3]));
                    this.Insert(row);
                }
            }
        }
    }
}
