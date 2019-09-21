using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// MT計上方法
    /// </summary>
    class MTKeijouHouhou : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_keijou_houhou";

        public MTKeijouHouhou(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("keijou_houhou", ColumnType.TypeString, "");               // 計上方法
        }
    }
}
