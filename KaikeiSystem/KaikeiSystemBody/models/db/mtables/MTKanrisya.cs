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
    class MTResist : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_resist";

        public MTResist(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("expire_date", ColumnType.TypeDate, "");               // 有効期限
        }


        public void SetExpireDate(DateTime date){
            Row row;
            bool insert = false;

            if (this.RowCount("") == 0) {
                row = this.NewRow();
                insert = true;
            }
            else {
                row = this.Select("").First();
            }

            row.Set("expire_date", date);

            if (insert) {
                this.Insert(row);
            }
            else {
                this.Update(row);
            }
        }


        public DateTime? GetExpireDate() {
            if (this.RowCache.Count > 0) {
                Row row = this.RowCache.First().Value;
                return row.GetDate("expire_date");
            }
            return null;
        }
    }
}
