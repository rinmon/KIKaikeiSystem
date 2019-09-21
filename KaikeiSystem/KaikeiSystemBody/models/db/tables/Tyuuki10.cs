using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.tables
{
    /// <summary>
    /// 注記10
    /// </summary>
    class Tyuuki10 : AbstractTable
    {
        public const string TABLE_NAME = "tyuuki10";

        public Tyuuki10(AbstractDatabase db, string tableName = TABLE_NAME)
            : base(db, tableName) {
            base.AddColumn("tyuuki_id", ColumnType.TypeInt, "");          //注記ID
            base.AddColumn("kamoku_kubun_id", ColumnType.TypeInt, "");   // 科目区分
            base.AddColumn("saiken_gaku", ColumnType.TypeAmount, "");         // 債権額
            base.AddColumn("tyousyuuhunoukin_zandaka", ColumnType.TypeAmount, "");         // 徴収不能金残高
            base.AddColumn("toukimatsu_zandaka", ColumnType.TypeAmount, "");         // 当期末残高

            base.AddIndex("create index " + tableName + "_index on " + tableName + "(tyuuki_id)");
        }

        
        override public void LoadCSV(string filename) {
        }
    }
}
