using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KaikeiSystemBody.models
{
    class Validator
    {
        private static string GetTaisyakuStr(constants.Taisyaku taisyaku, string prefix) {
            return (taisyaku == constants.Taisyaku.Karikata ? "karikata" : "kashikata") + prefix;
        }

        /// <summary>
        /// 補助科目のサポートがONで、補助科目のサポートされている科目のときに、補助科目が登録されていないとFalse
        /// </summary>
        public static bool CheckHojoKamokuIsLacking(models.db.KaikeiDatabase db, models.db.Row row, constants.Taisyaku taisyaku) {
            if ((db.MTSetting.GetInt("hojo_kamoku_support") != 0)) {
                var kamokuRow = db.MTKanjouKamoku.GetRowFromCache((int)row.GetLong(taisyaku == constants.Taisyaku.Karikata ? "karikata_kamoku_id" : "kashikata_kamoku_id", -1));
                if (kamokuRow != null && kamokuRow.GetBool("has_child", false)) {
                    if (row.GetLong(GetTaisyakuStr(taisyaku, "_hojo_seiri"), 0) == 0) {
                        return true;
                    }
                }
            }
            return false;
        }


        public static bool CheckKihyoubiIsInLisenceDate(models.db.KaikeiDatabase db, models.db.Row row) {
            DateTime? expireDate = db.MTResist.GetExpireDate();
            DateTime? kihyoubi =row.GetDate("kihyoubi");

            if (expireDate == null) {
                return false;
            }

            if (kihyoubi != null && kihyoubi > expireDate) {
                return false;
            }

            return true;
        }


        /// <summary>
        ///  科目コードに対応した補助整理番号かどうか
        ///  補助整理がNullなら0を設定
        /// </summary>
        public static bool CheckHojoSeiriIsFitInKamokuCode(models.db.KaikeiDatabase db, models.db.Row row, constants.Taisyaku taisyaku) {
            int kamokuId = (int)row.GetLong(GetTaisyakuStr(taisyaku, "_kamoku_id"), -1);
            int hojoSeiri = (int)row.GetLong(GetTaisyakuStr(taisyaku, "_hojo_seiri"), 0);

            if (hojoSeiri == 0) {
                row.Table.SetColumnValue(row, GetTaisyakuStr(taisyaku, "_hojo_seiri"), 0);
                return true;
            }

            var seiriRow = db.MTKanjouKamoku.GetRowFromCodeCacheByTopParent(kamokuId, hojoSeiri.ToString());

            if (seiriRow != null) {
                return true;
            }
            return false;
        }


        /// <summary>
        ///  経理区分に対応した補助整理かどうか
        ///  補助整理がNullなら0を設定
        ///  経理区分に対応した補助整理でなければ補助IDをnullに設定
        /// </summary>
        public static bool CheckHojoSeiriIsFitInKaikeiKubun(models.db.KaikeiDatabase db, models.db.Row row, constants.Taisyaku taisyaku) {
            int kamokuId = (int)row.GetLong(GetTaisyakuStr(taisyaku, "_kamoku_id"), -1);
            int hojoSeiri = (int)row.GetLong(GetTaisyakuStr(taisyaku, "_hojo_seiri"), 0);

            if (hojoSeiri == 0) {
                row.Table.SetColumnValue(row, GetTaisyakuStr(taisyaku, "_hojo_seiri"), 0);
                return true;
            }

            var seiriRow = db.MTKanjouKamoku.GetRowFromCodeCacheByTopParent(kamokuId, hojoSeiri.ToString());
            if (seiriRow == null) {
                row.Table.SetColumnValue(row, GetTaisyakuStr(taisyaku, "_hojo_id"), null);
                return false;
            }
            
            int kamokuKaikeiKubunId = (int)seiriRow.GetLong("kaikei_kubun_id", -1);
            int denpyouKaikeiKubunId = (int)row.GetLong("kaikei_kubun", -1);

            if(kamokuKaikeiKubunId == -1 || denpyouKaikeiKubunId == -1){
                return true;
            }

            if (!db.MTKaikeiKubun.IsChildOf(childId:denpyouKaikeiKubunId, parentId:kamokuKaikeiKubunId) ) {
                return false;
            }
            return true;
        }


        /// <summary>
        ///   科目コードがNull or 0以外かどうか
        /// </summary>
        public static bool CheckKamokuCodeIsNotNull(models.db.KaikeiDatabase db, models.db.Row row, constants.Taisyaku taisyaku) {
            string karikata = row.GetStr(GetTaisyakuStr(taisyaku, "_kamoku_code"), "");
            return karikata != "" && karikata != "0";
        }


        /// <summary>
        ///   科目コードのフォーマットをチェック（5ケタの文字列)
        /// </summary>
        public static bool CheckKamokuCodeFormatIsValid(models.db.KaikeiDatabase db, models.db.Row row, constants.Taisyaku taisyaku) {
            string karikata = row.GetStr(GetTaisyakuStr(taisyaku, "_kamoku_code"), "");
            return karikata.Length == 5;
        }


        /// <summary>
        ///  科目が振替対象かどうか
        /// </summary>
        public static bool IsHurikaeTaisyouKamokuCode(models.db.KaikeiDatabase db, models.db.Row row, constants.Taisyaku taisyaku) {
            /*
            var kamoku = db.MTKamoku.GetRowFromCodeCache(row.GetStr(GetTaisyakuStr(taisyaku, "_kamoku_code")));
            string hurikaeStr = taisyaku == constants.Taisyaku.Karikata ? "借方" : "貸方";

            if (kamoku != null) {
                if (kamoku.GetStr("hurikae_taisyou", "") == hurikaeStr) {
                    return true;
                }
            }
             */
            return false;
        }

        /// <summary>
        ///  使用区分のチェック ( 使用区分がONの科目は使用できない）
        /// </summary>
        public static bool IsUseableKamokuCode(models.db.KaikeiDatabase db, models.db.Row row, constants.Taisyaku taisyaku) {
            var kamoku = db.MTKanjouKamoku.GetRowFromCodeCache(-1, row.GetStr(GetTaisyakuStr(taisyaku, "_kamoku_code")));

            if (kamoku != null) {
                if (kamoku.GetBool("usable", true) == false) {
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        ///   起票日のフォーマットをチェック
        /// </summary>
        public static bool CheckKihyoubiFormatIsValid(models.db.KaikeiDatabase db, models.db.Row row) {
            string gengou = row.GetStr("kihyoubi_gengou", "");
            int year = (int)row.GetLong("kihyoubi_year", 0);
            int month = (int)row.GetLong("kihyoubi_month", 0);
            int day = (int)row.GetLong("kihyoubi_day", 0);

            if (gengou.Length != 1 || !(1 <= year && year <= 99) || !(1 <= month && month <= 12) || !(1 <= day && day <= 31)) {
                return false;
            }

            DateTime? date = helper.Converter.ObjToDateTime(row.Get("kihyoubi_gengou"), row.Get("kihyoubi_year"), row.Get("kihyoubi_month"), row.Get("kihyoubi_day"));
            if (date == null) {
                return false;
            }
            return true;
        }


        // 年度起算日に入っているかチェック
        public static bool CheckKihyoubiIsInNendoKisanbi(models.db.KaikeiDatabase db, models.db.Row row) {
            if (!row.IsNull("kihyoubi")) {
                string kisanbiStr = db.MTSetting.GetStr("nenndo_kisanbi", "");
                if (helper.Converter.IsDateStr(kisanbiStr)) {
                    DateTime dateStart = helper.Converter.DateStrToDateTime(kisanbiStr);
                    DateTime dateEnd = dateStart.AddYears(1).AddDays(-1);
                    DateTime kihyoubi = row.GetDate("kihyoubi").Value;

                    if (dateStart <= kihyoubi && kihyoubi <= dateEnd) {
                        return true;
                    }
                    else {
                        return false;
                    }
                }
            }
            return false;
        }


    }
}
