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
    class MTShikinSyuushiKoumoku : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_shikin_syuushi_koumoku";

        public MTShikinSyuushiKoumoku(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("caption", ColumnType.TypeString, "");
        }


        public constants.SyuushiType GetSyuushiTypeFromId(int id) {
            Row row = GetRowFromCache(id);
            if (row == null) {
                return constants.SyuushiType.None;
            }

            string caption = row.GetStr("caption");

            if (caption.Length < 2) {
                return constants.SyuushiType.None;
            }

            string suffix = caption.Substring(caption.Length - 2, 2);
            if (suffix == "収入") {
                return constants.SyuushiType.Syuunyuu;
            }
            else if (suffix == "支出") {
                return constants.SyuushiType.Shisyutsu;
            }
            else {
                return constants.SyuushiType.None;
            }
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
