using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.tables
{
    /// <summary>
    /// 予算（科目区分）
    /// </summary>
    class YosanKamokuKubun : AbstractTable
    {
        public const string TABLE_NAME = "yosan_kamoku_kubun";

        public YosanKamokuKubun(AbstractDatabase db, string tableName = TABLE_NAME)
            : base(db, tableName) {
            base.AddColumn("yosan_kubun", ColumnType.TypeInt, "");   // 予算区分
            base.AddColumn("kaikei_kubun", ColumnType.TypeInt, "");      // 会計区分
            base.AddColumn("nenndo", ColumnType.TypeInt, "");           // 年度
            base.AddColumn("kamoku_kubun_id", ColumnType.TypeInt, "");       // 科目区分ID
            base.AddColumn("yosan", ColumnType.TypeAmount, "");         // 予算額
            base.AddColumn("hosei_kaisuu", ColumnType.TypeInt, "");     // 補正回数
            base.AddColumn("parent_id", ColumnType.TypeInt, "");     // 

            base.AddIndex("create index " + tableName + "_index on " + tableName + "(parent_id, nenndo, kaikei_kubun, yosan_kubun, hosei_kaisuu)");
            base.AddIndex("create index " + tableName + "_index2 on " + tableName + "(parent_id, id)");
            base.AddIndex("create index " + tableName + "_index3 on " + tableName + "(nenndo, kamoku_kubun_id, kaikei_kubun, hosei_kaisuu)");
        }
    }
}
