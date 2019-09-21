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
    class MTTekiyou : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_tekiyou";
        private SortedList<char, int> firstCharList;

        public MTTekiyou(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("tekiyou_code", ColumnType.TypeInt, "");                 // 摘要コード
            base.AddColumn("tekiyou_mei", ColumnType.TypeString, "");               // 摘要名
            base.AddColumn("tekiyou_yomi", ColumnType.TypeString, "");              // 摘要読み

            firstCharList = new SortedList<char, int>();
        }


        public SortedList<char, int> FirstCharList {
            get {
                return firstCharList;
            }
        }


        public override void UpdateCache() {
            base.UpdateCache();

            firstCharList.Clear();
            foreach (var row in base.RowCache.Values) {
                firstCharList[row.GetStr("tekiyou_yomi", " ")[0]] = 1;
            }
        }

        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("tekiyou_code", CSVParser.ReadInt(token[0]));
                    row.Set("tekiyou_mei", CSVParser.ReadString(token[1]));
                    row.Set("tekiyou_yomi", CSVParser.ReadString(token[2]));
                    this.Insert(row);
                }
            }
        }
    }
}
