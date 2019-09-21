using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// MT減少事由
    /// </summary>
    class MTGensyouJiyuu : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_gensyou_jiyuu";

        public MTGensyouJiyuu(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("gensyou_jiyuu", ColumnType.TypeString, "");               // 減少事由
        }
    }
}
