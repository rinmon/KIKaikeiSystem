using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// MT法人団体
    /// </summary>
    class MTHoujinDantai : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_houjin_dantai";

        public MTHoujinDantai(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("dantai_meisyou", ColumnType.TypeString, "");            // 団体名称
            base.AddColumn("yuubin_bangou", ColumnType.TypeString, "");             // 郵便番号
            base.AddColumn("todouhuken", ColumnType.TypeString, "");                // 都道府県
            base.AddColumn("si_ku_gun", ColumnType.TypeString, "");                 // 市区群
            base.AddColumn("tyou_son_iki", ColumnType.TypeString, "");              // 町村域
            base.AddColumn("tatemono_mei", ColumnType.TypeString, "");              // 建物名
            base.AddColumn("denwa_bangou", ColumnType.TypeString, "");              // 電話番号
            base.AddColumn("fax_bangou", ColumnType.TypeString, "");                // FAX番号
            base.AddColumn("daihyousya_shimei", ColumnType.TypeString, "");         // 代表者氏名
            base.AddColumn("barcode", ColumnType.TypeString, "");                   // バーコード
        }
    }
}
