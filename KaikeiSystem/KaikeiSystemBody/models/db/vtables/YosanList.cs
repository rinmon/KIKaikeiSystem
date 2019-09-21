using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.vtables
{
    class YosanList : AbstractVirtualTable
    {
        private KaikeiDatabase ownerDB;

        public int Year {
            get;
            set;
        }

        public YosanList(KaikeiDatabase db)
            : base(db) {

            ownerDB = db;

            base.AddColumn("nenndo", ColumnType.TypeInt, "");
            base.AddColumn("keiri_kubun", ColumnType.TypeInt, "");
            base.AddColumn("yosan_kubun", ColumnType.TypeInt, "");
            base.AddColumn("hosei_kaisuu", ColumnType.TypeInt, "");
        }

        public override void SyncRowList() {
            rowList.Clear();

            string sql = "where nenndo > 0 ";

            if (Year > 0) {
                sql += "and nenndo = " + Year.ToString() + " ";
            }
            sql += "group by nenndo, keiri_kubun, yosan_kubun, hosei_kaisuu " +
                    " order by nenndo desc, keiri_kubun, yosan_kubun, hosei_kaisuu";
            foreach (var row in ownerDB.YosanDaikubun.Select(sql)) {
                Row newRow = this.NewRow();
                row.CopyColumns(newRow);
                rowList.Add(newRow);
            }
        }

        public override void DeleteSub(Row row) {
            throw new NotImplementedException();
        }

        public override void UpdateSub(Row row) {
            throw new NotImplementedException();
        }

        public override Row InsertSub(Row row) {
            throw new NotImplementedException();
        }

        public override long SelectSum(string column, string condition) {
            return base.SelectSum(column, condition);
        }
    }
}
