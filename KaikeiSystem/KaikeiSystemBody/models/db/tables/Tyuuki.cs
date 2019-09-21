using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.tables
{
    /// <summary>
    /// 注記
    /// </summary>
    class Tyuuki : AbstractTable
    {
        public const string TABLE_NAME = "tyuuki";

        public Tyuuki(AbstractDatabase db, string tableName = TABLE_NAME)
            : base(db, tableName) {
            base.AddColumn("nenndo", ColumnType.TypeInt, "");               // 年度
            base.AddColumn("kaikei_kubun_id", ColumnType.TypeInt, "");      // 会計区分
            base.AddColumn("tyuuki1", ColumnType.TypeString, "");           // 注記1
            base.AddColumn("tyuuki2", ColumnType.TypeString, "");           // 注記2
            base.AddColumn("tyuuki3", ColumnType.TypeString, "");           // 注記3
            base.AddColumn("tyuuki4", ColumnType.TypeString, "");           // 注記4
            base.AddColumn("tyuuki5", ColumnType.TypeString, "");           // 注記5
            base.AddColumn("tyuuki7", ColumnType.TypeString, "");           // 注記7
            base.AddColumn("tyuuki12", ColumnType.TypeString, "");           // 注記12
            base.AddColumn("tyuuki13", ColumnType.TypeString, "");           // 注記13
            base.AddColumn("tyuuki14", ColumnType.TypeString, "");           // 注記14
            base.AddColumn("tyuuki15", ColumnType.TypeString, "");           // 注記15

            base.AddIndex("create index " + tableName + "_index on " + tableName + "(nenndo, kaikei_kubun_id)");
        }

        
        override public void LoadCSV(string filename) {
        }
    }
}
