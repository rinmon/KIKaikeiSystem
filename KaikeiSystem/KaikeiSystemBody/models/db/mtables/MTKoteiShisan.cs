using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// MT固定資産
    /// </summary>
    class MTKoteiShisan : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_kotei_shisan";

        public MTKoteiShisan(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("kamoku_kubun_id", ColumnType.TypeInt, "");                  // 科目区分ID
            base.AddColumn("shisan_meisyou", ColumnType.TypeString, "");                // 資産名称
            base.AddColumn("syoukyaku_kubun", ColumnType.TypeInt, "");                  // 償却区分
            base.AddColumn("kaikei_kubun", ColumnType.TypeInt, "");                     // 会計区分
            base.AddColumn("suuryou", ColumnType.TypeInt, "");                          // 数量
            base.AddColumn("syutoku_nenngappi", ColumnType.TypeDate, "");               // 取得年月日
            base.AddColumn("gensyoubi", ColumnType.TypeDate, "");                       // 減少日
            base.AddColumn("syutoku_kakaku", ColumnType.TypeAmount, "");                // 取得価格
            base.AddColumn("assyuku_kityougaku", ColumnType.TypeAmount, "");            // 圧縮記帳額
            base.AddColumn("kisyu_syoukyakugaku_ruikei", ColumnType.TypeAmount, "");    // 期首償却額累計
            base.AddColumn("syoukyaku_houhou", ColumnType.TypeInt, "");                 // 償却方法
            base.AddColumn("taiyou_nennsuu", ColumnType.TypeInt, "");                   // 耐用年数
            base.AddColumn("syoukyaku_ritsu", ColumnType.TypeReal, "");                 // 償却率
            base.AddColumn("syoukyaku_kahi", ColumnType.TypeInt, "");                   // 償却可否
            base.AddColumn("keijou_houhou", ColumnType.TypeInt, "");                    // 計上方法
            base.AddColumn("zouka_jiyuu", ColumnType.TypeInt, "");                      // 増加事由
            base.AddColumn("gensyou_jiyuu", ColumnType.TypeInt, "");                    // 減少事由
            base.AddColumn("syoukyaku_shisan_zei", ColumnType.TypeInt, "");             // 償却資産税
            base.AddColumn("kyouyou_kaishibi", ColumnType.TypeDate, "");                // 供用開始日
            base.AddColumn("kyouyou_syuuryoubi", ColumnType.TypeDate, "");              // 供用終了日
            base.AddColumn("zanzon_wariai", ColumnType.TypeReal, "");                   // 残存割合
            base.AddColumn("zanzon_kakaku", ColumnType.TypeAmount, "");                 // 残存価格
            base.AddColumn("zanzon_gendo_wariai", ColumnType.TypeReal, "");             // 残存限度割合
            base.AddColumn("zanzon_gendo_gaku", ColumnType.TypeAmount, "");             // 残存限度額
            base.AddColumn("hutsuu_syoukyaku_hi", ColumnType.TypeAmount, "");           // 普通償却費
            base.AddColumn("zouka_syoukyaku_gaku", ColumnType.TypeAmount, "");          // 増加償却額
            base.AddColumn("warimashi_syoukyaku_hi", ColumnType.TypeAmount, "");        // 割増償却費
            base.AddColumn("tokubetsu_syoukyaku_hi", ColumnType.TypeAmount, "");        // 特別償却費
            base.AddColumn("bikou", ColumnType.TypeString, "");                         // 備考
            base.AddColumn("kisyu_tyoubo_kakaku", ColumnType.TypeAmount, "");           // 期首帳簿価格
            base.AddColumn("syoukyaku_kiso", ColumnType.TypeAmount, "");                // 償却の基礎
            base.AddColumn("hojokin_gaku", ColumnType.TypeAmount, "");                  // 補助金の額
        }


        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    for (int col = 0; col < this.ColumnList.Count; col++) {
                        row.Set(this.ColumnList[col].Name, CSVParser.ReadColumn(token[col], this.ColumnList[col].Type));
                    }
                    this.Insert(row);
                }
            }
        }
    }
}
