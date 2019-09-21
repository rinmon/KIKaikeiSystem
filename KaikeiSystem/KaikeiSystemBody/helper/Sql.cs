using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.helper
{
    // sqlの条件式生成関数群
    class Sql
    {

        // 経理区分と会計単位の条件文
        public static string ConditionKeiriKubunAndKaikeiTanni(int keiriKubun, int kaikeiTanni){
            string sql = "(1=1 ";

            if (keiriKubun >= 0) {
                sql += " and keiri_kubun = " + keiriKubun.ToString() + " ";
            }

            if (kaikeiTanni >= 0) {
                sql += " and kaikei_tanni = " + kaikeiTanni.ToString() + " ";
            }
            sql += ")";

            return sql;
        }

        // 起票日の条件文
        public static string ConditionKihyoubi(DateTime? start, DateTime? end) {
            string sql = "(1=1 ";

            if (start != null) {
                sql += " and kihyoubi >= " + helper.Converter.DateTimeToInt(start.Value);
            }
            if (end != null) {
                sql += " and kihyoubi <= " + helper.Converter.DateTimeToInt(end.Value);
            }
            sql += ")";

            return sql;
        }
    }
}
