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
    class MTTaisyakuTaisyouKoumoku : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_taisyaku_taisyou_koumoku";

        public MTTaisyakuTaisyouKoumoku(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("caption", ColumnType.TypeString, "");
        }
    }
}
