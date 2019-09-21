using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.helper
{

    // 分類できなかったヘルパ関数
    class Helper
    {

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        public const int WM_SETREDRAW = 0x000B;
        public const int Win32False = 0;
        public const int Win32True = 1;


        public static string GetStatusMessage(string columnName) {
            if (columnName == "denpyou_bangou_cache") {
                return KaikeiSystemBody.Properties.Resources.StatusDenpyouSeiriBangou;
            }
            if (columnName == "kaikei_kubun") {
                return KaikeiSystemBody.Properties.Resources.StatusKaikeiKubun;
            }
            if (columnName == "kihyoubi_gengou") {
                return KaikeiSystemBody.Properties.Resources.StatusGengou;
            }
            if (columnName == "kihyoubi_year") {
                return KaikeiSystemBody.Properties.Resources.StatusYear;
            }
            if (columnName == "kihyoubi_month") {
                return KaikeiSystemBody.Properties.Resources.StatusMonth;
            }
            if (columnName == "kihyoubi_day") {
                return KaikeiSystemBody.Properties.Resources.StatusDay;
            }
            if (columnName == "karikata_kamoku_code") {
                return KaikeiSystemBody.Properties.Resources.StatusKarikataKamokuCode;
            }
            if (columnName == "kashikata_kamoku_code") {
                return KaikeiSystemBody.Properties.Resources.StatusKashikataKamokuCode;
            }
            if (columnName == "karikata_kingaku") {
                return KaikeiSystemBody.Properties.Resources.StatusKingaku;
            }
            if (columnName == "tekiyou_id") {
                return KaikeiSystemBody.Properties.Resources.StatusTekiyou;
            }
            if (columnName == "kessan_syuuryou") {
                return "";
            }
            if (columnName == "denpyou_kakunin") {
                return KaikeiSystemBody.Properties.Resources.StatusDenpyouKakunin;
            }
            if (columnName == "keiri_kubun") {
                return KaikeiSystemBody.Properties.Resources.StatusKeiriKubun;
            }
            if (columnName == "torihiki_kubun") {
                return KaikeiSystemBody.Properties.Resources.StatusTorihikiKubun;
            }
            if (columnName == "karikata_hojo_seiri") {
                return KaikeiSystemBody.Properties.Resources.StatusHojoSeiri;
            }
            if (columnName == "kashikata_hojo_seiri") {
                return KaikeiSystemBody.Properties.Resources.StatusHojoSeiri;
            }
            if (columnName == "comment") {
                return KaikeiSystemBody.Properties.Resources.StatusComment;
            }
            return "";
        }


        public static string GetHoseiKaisuuMsg(int year, int hoseiKaisuu) {
            DateTime date = new DateTime(year, 4, 1);
            string nenndoStr = helper.Converter.DateTimeToWarekiGengou(date) +
                                helper.Converter.DateTimeToWarekiYear(date).ToString();

            if (hoseiKaisuu == 0) {
                return string.Format(KaikeiSystemBody.Properties.Resources.CaptionNoHoseiYosan, nenndoStr);
            }
            else {
                return string.Format(KaikeiSystemBody.Properties.Resources.CaptionHoseiKaisuu, nenndoStr, hoseiKaisuu);
            }
        }


        public static int GetNenndoOfDate(DateTime date) {
            if (date.Month < 4) {
                return date.Year - 1;
            }
            else {
                return date.Year;
            }
        }

        public static DateTime GetNenndoKisanbi(DateTime date) {
            if (date.Month >= 4) {
                return new DateTime(date.Year, 4, 1);
            }
            else {
                return new DateTime(date.Year - 1, 4, 1);
            }
        }

        public static DateTime GetNenndoKimatsubi(DateTime date) {
            if (date.Month >= 4) {
                return new DateTime(date.Year + 1, 3, 31);
            }
            else {
                return new DateTime(date.Year, 3, 31);
            }
        }

        public static DateTime GetNenndoKisanbi(int year) {
            return new DateTime(year, 4, 1);
        }

        public static DateTime GetNenndoKimatsubi(int year) {
            return new DateTime(year + 1, 3, 31);
        }

        public static string GetShikinSyuushiKeisansyoSummaryCaption(models.query.ShikinSyuushi.SummaryItem item) {
            switch (item) {
                case models.query.ShikinSyuushi.SummaryItem.JigyouSyuunyuu:
                    return Properties.Resources.CaptionJigyouSyuunyuuKei + "(1)";
                case models.query.ShikinSyuushi.SummaryItem.JigyouShisyutsu:
                    return Properties.Resources.CaptionJigyouShisyutsuKei + "(2)";
                case models.query.ShikinSyuushi.SummaryItem.JigyouSyuushi:
                    return Properties.Resources.CaptionJigyouSyuushiSagaku + "(3)=(1)-(2)";
                case models.query.ShikinSyuushi.SummaryItem.ShisetsuSyuunyuu:
                    return Properties.Resources.CaptionShisetsuSyuunyuuKei + "(4)";
                case models.query.ShikinSyuushi.SummaryItem.ShisetsuShisyutsu:
                    return Properties.Resources.CaptionShisetsuShisyutsuKei + "(5)";
                case models.query.ShikinSyuushi.SummaryItem.ShisetsuSyuushi:
                    return Properties.Resources.CaptionShisetsuSyuushiSagaku + "(6)=(4)-(5)";
                case models.query.ShikinSyuushi.SummaryItem.SonotaSyuunyuu:
                    return Properties.Resources.CaptionSonotaSyuunyuuKei + "(7)";
                case models.query.ShikinSyuushi.SummaryItem.SonotaShisyutsu:
                    return Properties.Resources.CaptionSonotaShisyutsuKei + "(8)";
                case models.query.ShikinSyuushi.SummaryItem.SonotaSyuushi:
                    return Properties.Resources.CaptionSonotaSyuushiSagaku + "(9)=(7)-(8)";
            }
            return "";
        }

        public static string GetJigyouKatsudouSummaryCaption(models.query.JigyouKatsudou.SummaryItem item, bool withoutNum = false) {
            string result = "";

            switch (item) {
                case models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouSyuunyuu:
                    result = Properties.Resources.CaptionServiceKatsudouSyuuekiKei;
                    break;
                case models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouShisyutsu:
                    result = Properties.Resources.CaptionServiceKatsudouHiyouKei;
                    break;
                case models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouSagaku:
                    result = Properties.Resources.CaptionServiceKatsudouZougenSagaku;
                    break;
                case models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouGaiSyuunyuu:
                    result = Properties.Resources.CaptionServiceKatsudouGaiSyuuekiKei;
                    break;
                case models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouGaiShisyutsu:
                    result = Properties.Resources.CaptionServiceKatsudouGaiHiyouKei;
                    break;
                case models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouGaiSagaku:
                    result = Properties.Resources.CaptionServiceKatsudouGaiZougenSagaku;
                    break;
                case models.query.JigyouKatsudou.SummaryItem.KeijouZougenSagaku:
                    result = Properties.Resources.CaptionKeijouZougenSagaku;
                    break;
                case models.query.JigyouKatsudou.SummaryItem.TokubetsuSyuunyuu:
                    result = Properties.Resources.CaptionTokubetsuSyuuekiKei;
                    break;
                case models.query.JigyouKatsudou.SummaryItem.TokubetsuShisyutsu:
                    result = Properties.Resources.CaptionTokubetsuHiyouKei;
                    break;
                case models.query.JigyouKatsudou.SummaryItem.TokubetsuSagaku:
                    result = Properties.Resources.CaptionTokubetsuZougenSagaku;
                    break;
            }

            if (withoutNum == false) {
                switch (item) {
                    case models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouSyuunyuu:
                        return result + "(1)";
                    case models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouShisyutsu:
                        return result + "(2)";
                    case models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouSagaku:
                        return result + "(3)=(1)-(2)";
                    case models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouGaiSyuunyuu:
                        return result + "(4)";
                    case models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouGaiShisyutsu:
                        return result + "(5)";
                    case models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouGaiSagaku:
                        return result + "(6)=(4)-(5)";
                    case models.query.JigyouKatsudou.SummaryItem.KeijouZougenSagaku:
                        return result + "(7)=(3)+(6)";
                    case models.query.JigyouKatsudou.SummaryItem.TokubetsuSyuunyuu:
                        return result + "(8)";
                    case models.query.JigyouKatsudou.SummaryItem.TokubetsuShisyutsu:
                        return result + "(9)";
                    case models.query.JigyouKatsudou.SummaryItem.TokubetsuSagaku:
                        return result + "(11)=(8)-(9)";
                }
            }

            return result;
        }
    }
}
