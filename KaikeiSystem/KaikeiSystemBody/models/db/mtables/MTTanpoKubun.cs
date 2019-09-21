using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// 担保区分
    /// </summary>
    class MTTanpoKubun : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_tanpo_kubun";

        public MTTanpoKubun(AbstractDatabase db, string tableName = TABLE_NAME)
            : base(db, tableName) {
            base.AddColumn("caption", ColumnType.TypeString, "");
        }

        
        override public void LoadCSV(string filename) {
        }
    }
}
