using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.tables
{
    /// <summary>
    /// 注記11
    /// </summary>
    class Tyuuki11 : AbstractTable
    {
        public const string TABLE_NAME = "tyuuki11";

        public Tyuuki11(AbstractDatabase db, string tableName = TABLE_NAME)
            : base(db, tableName) {
            base.AddColumn("tyuuki_id", ColumnType.TypeInt, "");          //注記ID
            base.AddColumn("caption", ColumnType.TypeString, "");   // キャプション
            base.AddColumn("tyoubo_kagaku", ColumnType.TypeAmount, "");         // 帳簿価額
            base.AddColumn("jika", ColumnType.TypeAmount, "");         // 時価
            base.AddColumn("hyouka_soneki", ColumnType.TypeAmount, "");         // 評価損益

            base.AddIndex("create index " + tableName + "_index on " + tableName + "(tyuuki_id)");
        }

        
        override public void LoadCSV(string filename) {
        }
    }
}
