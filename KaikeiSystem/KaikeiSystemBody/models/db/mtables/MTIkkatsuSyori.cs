using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    class MTIkkatsuSyori : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_ikkatsu_syori";

        public MTIkkatsuSyori(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            //base.AddColumn("kaikei_tanni", ColumnType.TypeInt, "");                               // 会計単位
            base.AddColumn("kaikei_kubun", ColumnType.TypeInt, "");                               // 会計区分
            base.AddColumn("torihiki_kubun", ColumnType.TypeInt, "");                             // 取引区分
            base.AddColumn("karikata_kamoku_id", ColumnType.TypeInt, "");                         // 借方科目ID
            base.AddColumn("karikata_hojo_id", ColumnType.TypeInt, "");                           // 借方補助ID
            base.AddColumn("karikata_hojo_seiri", ColumnType.TypeInt, "");                        // 借方補助整理
            base.AddColumn("karikata_kingaku", ColumnType.TypeAmount, "");                        // 借方金額
            base.AddColumn("kashikata_kamoku_id", ColumnType.TypeInt, "");                        // 貸方科目ID
            base.AddColumn("kashikata_hojo_id", ColumnType.TypeInt, "");                          // 貸方補助ID
            base.AddColumn("kashikata_hojo_seiri", ColumnType.TypeInt, "");                       // 貸方補助整理
            base.AddColumn("kashikata_kingaku", ColumnType.TypeAmount, "");                       // 貸方金額
            base.AddColumn("tekiyou_id", ColumnType.TypeInt, "");                                 // 摘要ID
            base.AddColumn("comment", ColumnType.TypeString, "");                                 // コメント
            base.AddColumn("touroku", ColumnType.TypeBool, "");                                   // 登録
            base.AddColumn("karikata_kamoku_code", ColumnType.TypeString, "");                    // 借方科目コード
            base.AddColumn("kashikata_kamoku_code", ColumnType.TypeString, "");                   // 貸方科目コード
            base.AddColumn("tsuika_kubun", ColumnType.TypeString, "");                            // 追加区分
        }


        public override bool SetColumnValue(Row row, string column, object val) {
            // 会計伝票明細とカラムを共有しているので、それを呼び出す
            if (column == "kashikata_hojo_seiri") {
                return (OwnerDB as KaikeiDatabase).KaikeiDenpyouMeisai.SetColumnValue(row, column, val);
            }
            else if (column == "karikata_hojo_seiri") {
                return (OwnerDB as KaikeiDatabase).KaikeiDenpyouMeisai.SetColumnValue(row, column, val);
            }
            else if (column == "karikata_kamoku_code") {
                return (OwnerDB as KaikeiDatabase).KaikeiDenpyouMeisai.SetColumnValue(row, column, val);
            }
            else if (column == "kashikata_kamoku_code") {
                return (OwnerDB as KaikeiDatabase).KaikeiDenpyouMeisai.SetColumnValue(row, column, val);
            }
            else {
                return base.SetColumnValue(row, column, val);
            }

        }


        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("kaikei_tanni", CSVParser.ReadInt(token[2]));
                    row.Set("keiri_kubun", CSVParser.ReadInt(token[3]));
                    row.Set("torihiki_kubun", CSVParser.ReadInt(token[4]));
                    row.Set("karikata_kamoku_id", CSVParser.ReadInt(token[5]));
                    row.Set("karikata_hojo_id", CSVParser.ReadInt(token[6]));
                    row.Set("karikata_hojo_seiri", CSVParser.ReadInt(token[7]));
                    row.Set("karikata_kingaku", CSVParser.ReadAmount(token[8]));
                    row.Set("kashikata_kamoku_id", CSVParser.ReadInt(token[9]));
                    row.Set("kashikata_hojo_id", CSVParser.ReadInt(token[10]));
                    row.Set("kashikata_hojo_seiri", CSVParser.ReadInt(token[11]));
                    row.Set("kashikata_kingaku", CSVParser.ReadAmount(token[12]));
                    row.Set("tekiyou_id", CSVParser.ReadInt(token[13]));
                    row.Set("comment", CSVParser.ReadString(token[14]));
                    row.Set("touroku", CSVParser.ReadBool(token[15]));
                    row.Set("karikata_kamoku_code", CSVParser.ReadString(token[16]));
                    row.Set("kashikata_kamoku_code", CSVParser.ReadString(token[17]));
                    row.Set("tsuika_kubun", CSVParser.ReadString(token[18]));

                    this.Insert(row);
                }
            }
        }

    
    }
}
