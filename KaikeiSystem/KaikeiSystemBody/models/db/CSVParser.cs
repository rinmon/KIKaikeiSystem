using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db
{
    class CSVParser
    {
        public static object ReadInt(string token) {
            return token.Length > 0 ? (object)int.Parse(token) : null;
        }

        public static object ReadString(string token) {
            return token.Length > 0 ? token.Trim(new char[] { '"' }): null;
        }

        public static object ReadBool(string token) {
            if (token.Length > 0) {
                return int.Parse(token) == 0 ? false : true;
            }
            else {
                return null;
            }
        }

        public static object ReadAmount(string token) {
            return token.Length > 0 ? (object)int.Parse(token.Replace("\\", "")) : null;
        }

        public static object ReadDate(string token) {
            return token.Length > 0 ? (object)DateTime.Parse(token) : null;
        }

        public static object ReadReal(string token) {
            return token.Length > 0 ? (object)double.Parse(token) : null;
        }

        public static object ReadColumn(string token, AbstractTable.ColumnType colType){
            switch (colType) {
                case AbstractTable.ColumnType.TypeInt:
                    return CSVParser.ReadInt(token);
                case AbstractTable.ColumnType.TypeString:
                    return CSVParser.ReadString(token);
                case AbstractTable.ColumnType.TypeBool:
                    return CSVParser.ReadBool(token);
                case AbstractTable.ColumnType.TypeDate:
                    return CSVParser.ReadDate(token);
                case AbstractTable.ColumnType.TypeAmount:
                    return CSVParser.ReadAmount(token);
                case AbstractTable.ColumnType.TypeReal:
                    return CSVParser.ReadReal(token);
            }
            return null;
        }
    }
}
