using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.helper
{

    //型変換関係の関数ごったに
    class Converter
    {
        public static System.Globalization.Calendar JpCalendar;
        public static System.Globalization.CultureInfo JpCultureInfo;



        public static void Init(){
            JpCalendar = new System.Globalization.JapaneseCalendar();
            JpCultureInfo = new System.Globalization.CultureInfo("ja-JP");
            JpCultureInfo.DateTimeFormat.Calendar = JpCalendar;
        }


        // 元号を表す文字かどうか
        public static bool IsGengouChar(char ch) {
            if (ch == 'R' || ch == 'H' || ch == 'S' || ch == 'T' || ch == 'M') {
                return true;
            }
            else {
                return false;
            }
        }


        // 文字列が和暦（"H12/12/32"など）かどうか判定
        public static bool IsWareki(string buf) {
            if (IsGengouChar(buf[0]) && IsDateStr(buf)) {
                return true;
            }
            else {
                return false;
            }
        }


        // 文字列が日付(和暦 or 西暦)かどうか判定
        public static bool IsDateStr(string buf){
            DateTime date;
            bool res = DateTime.TryParse(buf, out date);
            return res;
            /*
            try {
                var date = Convert.ToDateTime(buf);
                return true;
            }
            catch (FormatException) {
                return false;
            }*/
        }

        // 日付の文字列（"H12/12/30" or "2012/12/30"など）をDatetimeに変換
        public static DateTime DateStrToDateTime(string buf) {
            return Convert.ToDateTime(buf);
        }

        // DateTimeを和暦の文字列に変換
        public static string DateTimeToWarekiStr(DateTime date) {
            var buf = date.ToString("gyy/MM/dd ", JpCultureInfo);
            buf = buf.Replace("令和", "R").Replace("平成", "H").Replace("昭和", "S").Replace("大正", "T").Replace("明治", "M");
            return buf;
        }

        // DateTimeを和暦の文字列に変換
        public static string DateTimeToWarekiStrKanji(DateTime date, bool withoutDay=false, bool withoutMonth=false) {
            string buf;

            if (withoutMonth) {
                buf = date.ToString("gyy年", JpCultureInfo);
            }
            else if (withoutDay) {
                buf = date.ToString("gyy年MM月", JpCultureInfo);
            }
            else {
                buf = date.ToString("gyy年MM月dd日", JpCultureInfo);
            }
            return buf;
        }

        public static string DateTimeToWarekiGengou(DateTime date) {
            return DateTimeToWarekiStr(date).Substring(0, 1);
        }

        public static string DateTimeToWarekiGengouKanji(DateTime date) {
            var buf = date.ToString("gg", JpCultureInfo);
            return buf;
        }

        public static int DateTimeToWarekiYear(DateTime date) {
            var buf = date.ToString("yy", JpCultureInfo);
            return ObjToInt(buf, 0);
        }

        public static int GetNenndo(DateTime date) {
            if (date.Month <= 3) {
                return date.Year - 1;
            }
            else {
                return date.Year;
            }
        }

        public static DateTime DateTimeToNenndoKisannbi(DateTime date){
            return new DateTime(GetNenndo(date), 4, 1);
        }

        public static DateTime DateTimeToNenndoKimatsubi(DateTime date) {
            return new DateTime(GetNenndo(date)+1, 3, 31);
        }

        // 文字列の長さが0のときにNULLに変換
        public static string Len0ToNull(string buf) {
            return buf.Length > 0 ? buf : null;
        }

        // nullを長さ0の文字列に変換
        public static string NullToLen0(string buf) {
            if (buf == null) {
                return "";
            }
            else {
                return buf;
            }
        }

        // 金額をIntに変換
        public static long? AmountToLongObj(object obj) {
            if (obj == null) {
                return null;
            }
            if (obj is string) {
                string buf = obj as string;
                if (buf.Length == 0) {
                    return null;
                }
                else {
                    long result;
                    if (long.TryParse(buf.Replace("\\", "").Replace(",", ""), out result)) {
                        return result;
                    }
                    else {
                        return null;
                    }
                }
            }
            else if (obj is long?) {
                return (obj as long?);
            }
            else if (obj is int?){
                return (long?)(obj as int?).Value;
            }

            return null;

        }

        // intを金額の文字列に変換
        public static string LongToAmount(long val) {
            string buf = "";
            if (val < 0) {
                buf += "-";
                val *= -1;
            }
            buf += String.Format("\\{0:#,0}", val);

            return buf;
        }

        public static string LongToAmountWithoutYen(long val) {
            string buf = "";
            if (val < 0) {
                buf += "-";
                val *= -1;
            }

            buf += String.Format("{0:#,0}", val);

            return buf;
        }


        // 日付を数字に変換
        public static int DateTimeToInt(DateTime date) {
            return date.Year * 10000 + date.Month * 100 + date.Day;
        }
        public static int DateToInt(int year, int month, int day) {
            return year * 10000 + month * 100 + day;
        }

        // 数字を日付に変換
        public static DateTime IntToDateTime(int val) {
            int year = val / 10000;
            int month = (val - year * 10000) / 100;
            int day = val - year * 10000 - month * 100;
            return new DateTime(year, month, day);
        }

        public static string IntToDateStr(int val) {
            DateTime date = IntToDateTime(val);
            return date.Year.ToString() + "/" + date.Month.ToString() + "/" + date.Day.ToString();
        }

        public static int ObjToInt(object val, int ret_val_when_fail) {
            if (val == null) {
                return ret_val_when_fail;
            }
            else if(val is int?){
                return (int)val;
            }
            else if (val is long?) {
                return (int)(val as long?).Value;
            }
            else if (val is string) {
                int result = 0;
                if (int.TryParse(val as string, out result)) {
                    return result;
                }
            }
            return ret_val_when_fail;
        }

        public static long ObjToLong(object val, long ret_val_when_fail) {
            if (val == null) {
                return ret_val_when_fail;
            }
            else if (val is int?) {
                return (long)(val as int?).Value;
            }
            else if (val is long?) {
                return (long)val;
            }
            else if (val is string) {
                long result = 0;
                if (long.TryParse(val as string, out result)) {
                    return result;
                }
            }
            return ret_val_when_fail;
        }

        public static string ObjToString(object val) {
            if (val == null) {
                return null;
            }
            if (val is string) {
                if ((val as string).Length == 0) {
                    return null;
                }
                else {
                    return val as string;
                }
            }
            return null;
        }

        public static int? ObjToIntObj(object val) {
            if (val == null) {
                return null;
            }
            else if (val is int?) {
                return val as int?;
            }
            else if (val is long?) {
                return (int?)(val as long?).Value;
            }
            else if (val is string) {
                int result = 0;
                if ((val as string).Length == 0 || !int.TryParse(val as string, out result)) {
                    return null;
                }
                return result;
            }
            return null;
        }

        public static long? ObjToLongObj(object val) {
            if (val == null) {
                return null;
            }
            else if (val is long?) {
                return val as long?;
            }
            else if (val is int?) {
                return (long?)(val as int?).Value;
            }
            else if (val is string) {
                int result = 0;
                if ((val as string).Length == 0 || !int.TryParse(val as string, out result)) {
                    return null;
                }
                return result;
            }
            return null;
        }

        public static double? ObjToDoubleObj(object val) {
            if (val == null) {
                return null;
            }
            else if (val is double?) {
                return val as double?;
            }
            else if (val is string) {
                double result = 0;
                if ((val as string).Length == 0 || !double.TryParse(val as string, out result)) {
                    return null;
                }
                return result;
            }
            return null;
        }

        public static DateTime? ObjToDateTime(object val) {
            if (val == null) {
                return null;
            }
            else if (val is string) {
                if (IsDateStr(val as string)) {
                    return DateStrToDateTime(val as string);
                }
            }
            else if (val is DateTime?) {
                return (val as DateTime?).Value;
            }
            return null;
        }

        public static DateTime? ObjToDateTime(object gengou, object year, object month, object day) {
            if (gengou == null || year == null || month == null || day == null) {
                return null;
            }

            int year_int = helper.Converter.ObjToInt(year, 0);
            int month_int = helper.Converter.ObjToInt(month, 0);
            int day_int = helper.Converter.ObjToInt(day, 0);
            string date_str = string.Format("{0}{1:00}/{2:00}/{3:00}", gengou, year_int, month_int, day_int);

            if (IsWareki(date_str)) {
                return helper.Converter.DateStrToDateTime(date_str);
            }
            return null;
        }

        public static string HankakuNumToZenkakuNum(string num) {
            string result = "";
            foreach (char ch in num) {
                switch (ch) {
                    case '0': result += "０"; break;
                    case '1': result += "１"; break;
                    case '2': result += "２"; break;
                    case '3': result += "３"; break;
                    case '4': result += "４"; break;
                    case '5': result += "５"; break;
                    case '6': result += "６"; break;
                    case '7': result += "７"; break;
                    case '8': result += "８"; break;
                    case '9': result += "９"; break;
                }
            }
            return result;
        }
    }
}
