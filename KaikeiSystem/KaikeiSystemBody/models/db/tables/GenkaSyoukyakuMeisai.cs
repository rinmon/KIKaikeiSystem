using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.tables
{
    /// <summary>
    /// 減価償却明細
    /// </summary>
    class GenkaSyoukyakuMeisai : AbstractTable
    {
        public const string TABLE_NAME = "genka_syoukyaku_meisai";

        public GenkaSyoukyakuMeisai(AbstractDatabase db, string tableName = TABLE_NAME)
            : base(db, tableName) {
            base.AddColumn("kotei_shisan_bangou", ColumnType.TypeInt, "");              // 固定資産番号
            base.AddColumn("kaisuu", ColumnType.TypeInt, "");                           // 回数
            base.AddColumn("tsukisuu", ColumnType.TypeInt, "");                         // 月数
            base.AddColumn("kisyu_tyoubo_kagaku", ColumnType.TypeAmount, "");           // 期首帳簿価額
            base.AddColumn("touki_genka_syoukyaku_kagaku", ColumnType.TypeAmount, "");  // 当期減価償却価額
            base.AddColumn("genka_syoukyaku_ruikeigaku", ColumnType.TypeAmount, "");    // 減価償却累計額
            base.AddColumn("kimatsu_tyoubo_kagaku", ColumnType.TypeAmount, "");         // 期末帳簿価額
            base.AddColumn("gensyoubi", ColumnType.TypeDate, "");                       // 減少日
            base.AddColumn("denpyou_hakkou", ColumnType.TypeBool, "");                  // 伝票発行

            base.AddIndex("create index " + tableName + "_index on " + tableName + "(kotei_shisan_bangou)");
        }
    }
}
