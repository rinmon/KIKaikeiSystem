using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// MT償却区分
    /// </summary>
    class MTSyoukyakuKubun : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_syoukyaku_kubun";

        public MTSyoukyakuKubun(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("syoukyaku_kubun", ColumnType.TypeString, "");               // 償却区分
        }


        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("id", CSVParser.ReadInt(token[0]));
                    row.Set("syoukyaku_kubun", CSVParser.ReadString(token[1]));
                    this.Insert(row);
                }
            }
        }
    }
}
