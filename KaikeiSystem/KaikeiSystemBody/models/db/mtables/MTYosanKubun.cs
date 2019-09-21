using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// M予算区分
    /// </summary>
    class MTYosanKubun : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_yosan_kubun";

        public MTYosanKubun(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("yosan_kubun", ColumnType.TypeString, "");            // 予算区分
        }


        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("id", CSVParser.ReadInt(token[0]));
                    row.Set("yosan_kubun", CSVParser.ReadString(token[1]));
                    this.Insert(row);
                }
            }
        }
    }
}
