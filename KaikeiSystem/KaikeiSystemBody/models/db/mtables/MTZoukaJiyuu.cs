using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// MT増加事由
    /// </summary>
    class MTZoukaJiyuu : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_zouka_jiyuu";

        public MTZoukaJiyuu(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("zouka_jiyuu", ColumnType.TypeString, "");               // 増加事由
        }


        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("id", CSVParser.ReadInt(token[0]));
                    row.Set("zouka_jiyuu", CSVParser.ReadString(token[1]));
                    this.Insert(row);
                }
            }
        }
    }
}
