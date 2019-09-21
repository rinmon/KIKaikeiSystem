using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// MT会計単位
    /// </summary>
    class MTSetting : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_setting";


        private Dictionary<string, Row> key2row_;

        
        public MTSetting(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("key",   ColumnType.TypeString, "");            // キー
            base.AddColumn("value", ColumnType.TypeString, "");            // 値

            key2row_ = new Dictionary<string, Row>();
        }

        public override void UpdateCache() {
            base.UpdateCache();

            key2row_.Clear();
            foreach (var row in base.RowCache.Values) {
                string key = row.GetStr("key");
                key2row_[key] = row;
            }
        }

        
        public string GetValue(string key) {
            if (key2row_.ContainsKey(key)) {
                return key2row_[key].GetStr("value");
            }
            return null;
        }

        public int? GetInt(string key) {
            string value = GetValue(key);
            if(value == null || value == ""){
                return null;
            }
            else{
                return int.Parse(value);
            }
        }

        public int GetInt(string key, int ret_val_when_null){
            string value = GetValue(key);
            return (value == null || value == "") ? ret_val_when_null : int.Parse(value);
        }

        public string GetStr(string key, string ret_val_when_null) {
            string value = GetValue(key);
            return (value == null) ? ret_val_when_null : value;
        }

        public DateTime? GetDateTime(string key) {
            string value = GetValue(key);
            if(value != null && helper.Converter.IsDateStr(value)){
                return helper.Converter.DateStrToDateTime(value);
            }
            return null;
        }


        public void SetStr(string key, string val) {
            if (key2row_.ContainsKey(key)) {
                Row row = key2row_[key];
                row.Set("value", val);
                this.Update(row);
            }
            else {
                Row row = this.NewRow();
                row.Set("key", key);
                row.Set("value", val);
                this.Insert(row);
                UpdateCache();
            }
        }

        public void SetDateTime(string key, DateTime? date) {
            string value = "";
            if (date != null) {
                value = helper.Converter.DateTimeToWarekiStr(date.Value);
            }
            SetStr(key, value);
        }


        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("key", CSVParser.ReadString(token[0]));
                    row.Set("value", CSVParser.ReadString(token[1]));
                    this.Insert(row);
                }
            }
        }
    }
}
