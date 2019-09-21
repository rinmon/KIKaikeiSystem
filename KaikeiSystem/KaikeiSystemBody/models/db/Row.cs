using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db
{
    class Row
    {
        private Dictionary<string, object> columns_;
        
        public Row(AbstractTable table) {
            columns_ = new Dictionary<string, object>();
            Table = table;
        }


        public AbstractTable Table {
            get;
            private set;
        }


        public void AddColumn(string key, object value) {
            columns_.Add(key, value);
        }

        public void RemoveColumn(string key) {
            columns_.Remove(key);
        }


        public void CopyColumns(Row dest) {
            foreach (string key in columns_.Keys) {
                dest.Set(key, columns_[key]);
            }
        }


        public bool IsNull(string key) {
            return !(columns_.ContainsKey(key) && (columns_[key] != null));
        }

        public bool ContainsColumn(string key) {
            return columns_.ContainsKey(key);
        }


        public object Get(string key) {
            return columns_[key];
        }

        public void Set(string key, object obj) {
            columns_[key] = obj;
        }

        public string GetStr(string key, string ret_val_when_null = "") {
            if (IsNull(key)) {
                return ret_val_when_null;
            }
            else {
                return columns_[key].ToString();
            }
        }

        public string GetAmountStr(string key, string ret_val_when_null = "") {
            if (IsNull(key)) {
                return ret_val_when_null;
            }
            else {
                return helper.Converter.LongToAmount((int)columns_[key]);
            }
        }

        public long GetLong(string key, int ret_val_when_null) {
            if (IsNull(key)) {
                return ret_val_when_null;
            }

            object val = columns_[key];
            if (val is int?) {
                return (long)(columns_[key] as int?).Value;
            }
            else if (val is long?) {
                return (columns_[key] as long?).Value;
            }

            return ret_val_when_null;
        }


        public DateTime? GetDate(string key) {
            return (DateTime?)columns_[key];
        }

        public string GetDateStr(string key, string ret_val_when_null = "") {
            if (IsNull(key)) {
                return ret_val_when_null;
            }
            else {
                return ((DateTime)columns_[key]).ToString();
            }            
        }

        public string GetWarekiGengoStr(string key, string ret_val_when_null = "") {
            if (IsNull(key)) {
                return ret_val_when_null;
            }
            else {
                var buf = helper.Converter.DateTimeToWarekiStr((DateTime)columns_[key]);
                return buf.Substring(0, 1);
            }
        }

        public string GetWarekiYearStr(string key, string ret_val_when_null = "") {
            if (IsNull(key)) {
                return ret_val_when_null;
            }
            else {
                var buf = helper.Converter.DateTimeToWarekiStr((DateTime)columns_[key]);
                return buf.Substring(1, 2);
            }
        }

        public string GetYearStr(string key, string ret_val_when_null = "") {
            if (IsNull(key)) {
                return ret_val_when_null;
            }
            else {
                return ((DateTime)columns_[key]).Year.ToString();
            }
        }

        public string GetMonthStr(string key, string ret_val_when_null = "") {
            if (IsNull(key)) {
                return ret_val_when_null;
            }
            else {
                return ((DateTime)columns_[key]).Month.ToString();
            }
        }

        public string GetDayStr(string key, string ret_val_when_null = "") {
            if (IsNull(key)) {
                return ret_val_when_null;
            }
            else {
                return ((DateTime)columns_[key]).Day.ToString();
            }
        }


        public int GetYear(string key, int ret_val_when_null) {
            if (IsNull(key)) {
                return ret_val_when_null;
            }
            else {
                return ((DateTime)columns_[key]).Year;
            }
        }

        public int GetMonth(string key, int ret_val_when_null) {
            if (IsNull(key)) {
                return ret_val_when_null;
            }
            else {
                return ((DateTime)columns_[key]).Month;
            }
        }

        public int GetDay(string key, int ret_val_when_null) {
            if (IsNull(key)) {
                return ret_val_when_null;
            }
            else {
                return ((DateTime)columns_[key]).Day;
            }
        }

        public bool GetBool(string key, bool ret_val_when_null) {
            if (IsNull(key)) {
                return ret_val_when_null;
            }
            else {
                return (bool)columns_[key];
            }
        }

        public string GetMasterStr(string key, string master_key, string ret_val_when_null, AbstractMasterTable master) {
            int master_id = (int)this.GetLong(key, -1);
            if (master.RowCache.ContainsKey(master_id)) {
                return master.RowCache[master_id].GetStr(master_key, "");
            }
            return "";
        }

        public double GetDouble(string key, double ret_val_when_null) {
            if (IsNull(key)) {
                return ret_val_when_null;
            }
            else {
                return (double)columns_[key];
            }
        }

        public int GetId() {
            return (int)this.GetLong("id", -1);
        }
    }
}
