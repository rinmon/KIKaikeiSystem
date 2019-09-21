using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// MT法人施設
    /// </summary>
    class MTHoujinShisetsu : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_houjin_shisetsu";

        public MTHoujinShisetsu(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("dantai_bangou", ColumnType.TypeInt, "");                // 団体番号
            base.AddColumn("shisetsu_meisyou", ColumnType.TypeString, "");          // 施設名称
            base.AddColumn("yuubin_bangou", ColumnType.TypeString, "");             // 郵便番号
            base.AddColumn("todouhuken", ColumnType.TypeString, "");                // 都道府県
            base.AddColumn("si_ku_gun", ColumnType.TypeString, "");                 // 市区群
            base.AddColumn("tyou_son_iki", ColumnType.TypeString, "");              // 町村域
            base.AddColumn("tatemono_mei", ColumnType.TypeString, "");              // 建物名
            base.AddColumn("denwa_bangou", ColumnType.TypeString, "");              // 電話番号
            base.AddColumn("fax_bangou", ColumnType.TypeString, "");                // FAX番号
            base.AddColumn("daihyousya_shimei", ColumnType.TypeString, "");         // 代表者氏名
            base.AddColumn("barcode", ColumnType.TypeString, "");                   // バーコード
            base.AddColumn("shisetsu_kubun", ColumnType.TypeBool, "");              // 施設区分
            base.AddColumn("kaikei_tanni", ColumnType.TypeInt, "");                 // 会計単位
            base.AddColumn("ryakusyou", ColumnType.TypeString, "");                 // 略称
            base.AddColumn("genka_syoukyaku_ruikei_gaku", ColumnType.TypeInt, "");  // 減価償却累計額
        }


        static public bool Shisetsu1IncludeShisetsu2(object val1, object val2) {
            int id1 = helper.Converter.ObjToInt(val1, -1);
            int id2 = helper.Converter.ObjToInt(val2, -1);
            if (id1 == -1 || id2 == -1) {
                return false;
            }
            if (id1 == id2 || id1 == 99) {  // ID=99 はすべての施設
                return true;
            }
            return false;
        }



        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("id", CSVParser.ReadInt(token[0]));
                    row.Set("dantai_bangou", CSVParser.ReadInt(token[1]));
                    row.Set("shisetsu_meisyou", CSVParser.ReadString(token[2]));
                    row.Set("yuubin_bangou", CSVParser.ReadString(token[3]));
                    row.Set("todouhuken", CSVParser.ReadString(token[4]));
                    row.Set("si_ku_gun", CSVParser.ReadString(token[5]));
                    row.Set("tyou_son_iki", CSVParser.ReadString(token[6]));
                    row.Set("tatemono_mei", CSVParser.ReadString(token[7]));
                    row.Set("denwa_bangou", CSVParser.ReadString(token[8]));
                    row.Set("fax_bangou", CSVParser.ReadString(token[9]));
                    row.Set("daihyousya_shimei", CSVParser.ReadString(token[10]));
                    row.Set("barcode", CSVParser.ReadString(token[11]));
                    row.Set("shisetsu_kubun", CSVParser.ReadBool(token[12]));
                    row.Set("kaikei_tanni", CSVParser.ReadInt(token[13]));
                    row.Set("ryakusyou", CSVParser.ReadString(token[14]));
                    row.Set("genka_syoukyaku_ruikei_gaku", CSVParser.ReadAmount(token[15]));
                    this.Insert(row);
                }
            }
        }
    }
}
