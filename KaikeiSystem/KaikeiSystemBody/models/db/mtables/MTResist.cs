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
    class MTKanrisya : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_kanrisya";

        public MTKanrisya(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("user_name", ColumnType.TypeString, "");                 // ユーザ名
            base.AddColumn("password", ColumnType.TypeString, "");                  // パスワード
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
            Row row = this.RowCache.First().Value;
            return row.GetDate("expire_date");
        }
    }
}
