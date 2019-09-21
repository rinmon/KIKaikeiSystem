using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.tables
{
    /// <summary>
    /// 注記8
    /// </summary>
    class Tyuuki8 : AbstractTable
    {
        public const string TABLE_NAME = "tyuuki8";

        public Tyuuki8(AbstractDatabase db, string tableName = TABLE_NAME)
            : base(db, tableName) {
            base.AddColumn("tyuuki_id", ColumnType.TypeInt, "");          //注記ID
            base.AddColumn("tanpo_kubun_id", ColumnType.TypeInt, "");    // 担保区分
            base.AddColumn("kamoku_kubun_id", ColumnType.TypeInt, "");   // 科目区分
            base.AddColumn("amount", ColumnType.TypeAmount, "");         // 金額

            base.AddIndex("create index " + tableName + "_index on " + tableName + "(tyuuki_id)");
        }

        
        override public void LoadCSV(string filename) {
        }
    }
}
