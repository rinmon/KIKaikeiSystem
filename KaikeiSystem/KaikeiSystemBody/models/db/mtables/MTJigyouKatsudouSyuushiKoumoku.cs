using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// MT摘要
    /// </summary>
    class MTJigyouKatsudouSyuushiKoumoku : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_jigyou_katsudou_syuushi_koumoku";

        public MTJigyouKatsudouSyuushiKoumoku(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("caption", ColumnType.TypeString, "");
        }


        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("id", CSVParser.ReadInt(token[0]));
                    row.Set("caption", CSVParser.ReadString(token[1]));
                    this.Insert(row);
                }
            }
        }
    }
}
