using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db
{
    /// <summary>
    /// データベースのテーブルを表現するクラス
    /// </summary>
    abstract class AbstractTable
    {
        public enum ColumnType
        {
            TypeInt,
            TypeString,
            TypeDate,
            TypeBool,
            TypeAmount,  //金額
            TypeReal,
        }

        public class ColumnClass
        {
            public string Name{ get; private set; }
            public ColumnType Type{ get; private set; }
            public string Option { get; private set; }
            public int ColIndex { get; private set; }   // テーブル中のカラムの順番

            public ColumnClass(string name, ColumnType type, string option, int col_index){
                Name = name;
                Type = type;
                Option = option;
                ColIndex = col_index;
            }
        }


        private List<ColumnClass> columns_;
        private Dictionary<string, int> col_name2num_;       //カラム名→columns_リストの添え字のハッシュテーブル
        private List<string> indexes_;
        private string table_name_;
        private int max_col_index_;


        public string TableName {
            get {
                return table_name_;
            }
        }

        public AbstractDatabase OwnerDB {
            get;
            private set;
        }

        public AbstractTable(AbstractDatabase db, string tableName) {
            OwnerDB = db;
            table_name_ = tableName;
            columns_ = new List<ColumnClass>();
            col_name2num_ = new Dictionary<string, int>();
            indexes_ = new List<string>();
            max_col_index_ = 0;

            this.AddColumn("id", ColumnType.TypeInt, "not null primary key autoincrement");
        }


        virtual public void InitTable(bool createNonexistTable) {
            if (createNonexistTable && !OwnerDB.ExistTable(table_name_)) {
                string sql =
                    "create table " + table_name_ + " (";

                // column
                for (int i = 0; i < columns_.Count; i++) {
                    if (i != 0) {
                        sql += ",";
                    }

                    var col = columns_[i];
                    switch (col.Type) {
                        case ColumnType.TypeInt:
                            sql += col.Name + " integer ";
                            break;
                        case ColumnType.TypeString:
                            sql += col.Name + " text ";
                            break;
                        case ColumnType.TypeBool:
                            sql += col.Name + " integer ";
                            break;
                        case ColumnType.TypeDate:
                            sql += col.Name + " integer ";
                            break;
                        case ColumnType.TypeAmount:
                            sql += col.Name + " integer ";
                            break;
                        case ColumnType.TypeReal:
                            sql += col.Name + " real ";
                            break;
                    }
                    sql += col.Option;
                }

                sql += ")";
                OwnerDB.ExecuteNonQuery(sql);

                // index
                for (int i = 0; i < indexes_.Count; i++) {
                    OwnerDB.ExecuteNonQuery(indexes_[i]);
                }
            }
        }

        object tmp;

        /// <summary>
        /// Rowをメモリにコピーして返す
        /// 速度的にあまり良くないかも
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        virtual public IEnumerable<Row> Select(string condition, int offset = 0, int limit = 0) {
            string sql = "select * from " + table_name_ + " " + condition;
            if (limit > 0) {
                sql += " limit " + limit.ToString();
            }
            if (offset > 0) {
                sql += " offset " + offset.ToString();
            }
            var reader = OwnerDB.ExecuteReader(sql);

            while (reader.Read()) {
                var row = new Row(this);
                for (int i = 0; i < reader.FieldCount; i++) {
                    if (ColumnList.Count <= i) {
                        break;
                    }
                    var col = columns_[col_name2num_[reader.GetName(i)]];
                    if(reader.IsDBNull(i)){
                        row.AddColumn(col.Name, null);
                    } 
                    else if (col.Type == ColumnType.TypeDate) {
                        var val = reader.GetInt32(i);
                        row.AddColumn(col.Name, helper.Converter.IntToDateTime(val));
                    }
                    else if (col.Type == ColumnType.TypeBool) {
                        row.AddColumn(col.Name, reader.GetBoolean(i));
                    }
                    else {
                        row.AddColumn(col.Name, reader.GetValue(i));
                    }
                }

                yield return row;
            }
        }


        virtual public IEnumerable<object> SelectDistinct(string column, string condition) {
            var reader = OwnerDB.ExecuteReader("select distinct " + column + " from " + table_name_ + " " + condition);

            while (reader.Read()) {
                yield return reader.GetValue(0);
            }
        }


        virtual public long SelectSum(string column, string condition) {
            var reader = OwnerDB.ExecuteReader("select sum(" + column + ") from " + table_name_ + " " + condition);

            if (reader.Read()) {
                if(reader.IsDBNull(0)){
                    return 0;
                }
                else{
                    return reader.GetInt64(0);
                }
            }
            else {
                return 0;
            }
        }



        virtual public Row LastInsertedRow() {
            var rows = Select("where ROWID = last_insert_rowid()");
            if (rows.Count() > 0) {
                return rows.First();
            }
            return null;
        }


        virtual public Row NewRow() {
            Row row = new Row(this);
            foreach (var col in columns_) {
                row.AddColumn(col.Name, null);
            }
            return row;
        }


        virtual public int RowCount(string condition) {
            string sql = "select count(*) from " + table_name_ + " " + condition;
            var reader = OwnerDB.ExecuteReader(sql);

            if (reader.Read()) {
                return reader.GetInt32(0);
            }
            else {
                return -1;
            }
        }

        virtual public int GetMax(string column, string condition = "") {
            var reader = OwnerDB.ExecuteReader(string.Format("select {0} from {1} {2} order by {0} desc limit 1", column, table_name_, condition));

            if (reader.Read()) {
                return reader.GetInt32(0);
            }
            else {
                return 0;
            }
        }

        virtual public object GetFirst(string column, string condition = "") {
            var reader = OwnerDB.ExecuteReader(string.Format("select {0} from {1} {2} limit 1", column, table_name_, condition));

            if (reader.Read()) {
                object val = reader.GetValue(0);
                return val;
            }
            else {
                return null;
            }
        }


        virtual public Row GetFirstRow(string condition = "") {
            var rows = this.Select(condition, offset:0, limit:1);
            if (rows.Count() >= 1) {
                return rows.First();
            }
            else {
                return null;
            }
        }


        virtual public Row GetRowById(int id) {
            return GetFirstRow("where id=" + id);
        }


        virtual public void Insert(Row row) {
            string sql = "insert into " + table_name_;
            string columns = "";
            string values = "";

            bool first = true;

            row.Set("updated_at", DateTime.Now);
            row.Set("created_at",  DateTime.Now);
            FormalizeRow(row);

            for (int i = 0; i < columns_.Count; i++) {
                var col_name = columns_[i].Name;
                if (!row.IsNull(col_name)) {
                    if(!first){
                        columns += ",";
                        values += ",";
                    }
                    switch (columns_[i].Type) {
                        case ColumnType.TypeInt:
                            columns += col_name;
                            values += row.GetLong(col_name, 0).ToString();
                            break;
                        case ColumnType.TypeString:
                            columns += col_name;
                            values += "'" + row.GetStr(col_name) + "'";
                            break;
                        case ColumnType.TypeBool:
                            columns += col_name;
                            values += row.GetBool(col_name, false) ? "1" : "0";
                            break;
                        case ColumnType.TypeDate:
                            columns += col_name;
                            values += helper.Converter.DateTimeToInt(row.GetDate(col_name).Value).ToString();
                            break;
                        case ColumnType.TypeAmount:
                            columns += col_name;
                            values += row.GetLong(col_name, 0).ToString();
                            break;
                        case ColumnType.TypeReal:
                            columns += col_name;
                            values += row.GetDouble(col_name, 0).ToString();
                            break;
                    }
                    first = false;
                }
            }

            if (columns.Length == 0 || values.Length == 0) {
                sql += "(id) values (null)";
            }
            else {
                sql += " (" + columns + ") values (" + values + ")";
            }
            OwnerDB.ExecuteNonQuery(sql);
        }


        virtual public void Update(Row row) {
            if (row.IsNull("id")) {
                return;
            }

            row.Set("updated_at", DateTime.Now);
            FormalizeRow(row);

            foreach (var col in this.columns_) {
                if(row.ContainsColumn(col.Name)){
                    if (SetColumnValue(row, col.Name, row.Get(col.Name)) == false) {
                        row.Set(col.Name, null);
                    }
                }
            }

            string sql = "update " + table_name_ + " set ";

            bool first = true;

            for (int i = 0; i < columns_.Count; i++) {
                var col_name = columns_[i].Name;
                if (col_name == "id") {
                    continue;
                }
                if (row.ContainsColumn(col_name)) {
                    if (!first) {
                        sql += ",";
                    }

                    if (row.IsNull(col_name)) {
                        sql += col_name + "=NULL";
                    }
                    else {
                        switch (columns_[i].Type) {
                            case ColumnType.TypeInt:
                                sql += col_name + "=" + row.GetLong(col_name, 0).ToString();
                                break;
                            case ColumnType.TypeString:
                                sql += col_name + "=" + "'" + row.GetStr(col_name) + "'";
                                break;
                            case ColumnType.TypeBool:
                                sql += col_name + "=" + (row.GetBool(col_name, false) ? "1" : "0");
                                break;
                            case ColumnType.TypeDate:
                                    sql += col_name + "=" + helper.Converter.DateTimeToInt(row.GetDate(col_name).Value).ToString();
                                break;
                            case ColumnType.TypeAmount:
                                sql += col_name + "=" + row.GetLong(col_name, 0).ToString();
                                break;
                            case ColumnType.TypeReal:
                                sql += col_name + "=" + row.GetDouble(col_name, 0).ToString();
                                break;
                        }
                    }
                    first = false;
                }
            }

            sql += " where id = " + row.GetStr("id");
            OwnerDB.ExecuteNonQuery(sql);
        }


        virtual public bool Delete(Row row) {
            if (row.IsNull("id")) {
                return false;
            }

            OwnerDB.ExecuteNonQuery("delete from " + table_name_ + " where id = " + row.GetLong("id", 0).ToString());
            return true;
        }

        virtual public bool Delete(int id) {
            OwnerDB.ExecuteNonQuery("delete from " + table_name_ + " where id = " + id);
            return true;        
        }


        // Rowをデータベースの状態に戻す
        virtual public Row Revert(Row row) {
            if (row.ContainsColumn("id")) {
                var rows = Select("where id = " + row.GetStr("id"));
                if (rows.Count() > 0) {
                    return rows.First();
                }
            }
            return null;
        }


        /// <summary>
        /// カラム名から、DB上のカラムの順番を返す
        /// </summary>
        /// <param name="col_name"></param>
        /// <returns></returns>
        public int ColumnIndex(string col_name) {
            int num = col_name2num_[col_name];
            return columns_[num].ColIndex;
        }


        protected ColumnClass Column(string col_name) {
            int num = col_name2num_[col_name];
            return columns_[num];
        }


        protected void AddColumn(string name, ColumnType type, string option) {
            columns_.Add(new ColumnClass(name, type, option, max_col_index_));
            col_name2num_.Add(name, columns_.Count - 1);
            max_col_index_++;
        }


        protected void AddIndex(string index_str) {
            indexes_.Add(index_str);
        }

        // valがcolumnの値として有効かどうかをチェックする
        // valの型チェック（論理的な値チェックは行わない）
        virtual public bool IsValidColumnValue(Row row, string column, object val){
            ColumnClass col = this.Column(column);

            if (val == null || (val is string && (val as string).Length == 0)) {
                return true;
            }

            if (col.Type == ColumnType.TypeBool) {
                return val is bool?;
            }
            else if(col.Type == ColumnType.TypeDate){
                if (val is string) {
                    return helper.Converter.IsDateStr(val as string);
                }
                else if (val is DateTime?) {
                    return true;
                }
                else {
                    return false;
                }
            }
            else if (col.Type == ColumnType.TypeInt) {
                return helper.Converter.ObjToLongObj(val) != null;
            }
            else if (col.Type == ColumnType.TypeString) {
                return val is string;
            }
            else if (col.Type == ColumnType.TypeAmount) {
                return helper.Converter.AmountToLongObj(val) != null;
            }
            else if (col.Type == ColumnType.TypeReal) {
                return helper.Converter.ObjToDoubleObj(val) != null;
            }

            return false;
        }


        // カラムに値を代入
        // valが不正な値の場合はfalseを返す
        // valが正当な値の場合はvalを型変換して代入し、trueを返す
        // 型チェックのみ。行全体としての正当性チェックは行わない
        virtual public bool SetColumnValue(Row row, string column, object val) {
            if(!IsValidColumnValue(row, column, val)){
                //row.Set(column, val);
                return false;
            }

            if (val == null || (val is string && (val as string).Length == 0)) {
                row.Set(column, null);
                return true;
            }

            ColumnClass col = this.Column(column);

            if (col.Type == ColumnType.TypeBool) {
                row.Set(column, val as bool?);
            }
            else if (col.Type == ColumnType.TypeDate) {
                row.Set(column, helper.Converter.ObjToDateTime(val));
            }
            else if (col.Type == ColumnType.TypeInt) {
                row.Set(column, helper.Converter.ObjToLongObj(val));
            }
            else if (col.Type == ColumnType.TypeString) {
                row.Set(column, helper.Converter.ObjToString(val));
            }
            else if (col.Type == ColumnType.TypeAmount) {
                row.Set(column, helper.Converter.AmountToLongObj(val));
            }
            else if (col.Type == ColumnType.TypeReal) {
                row.Set(column, helper.Converter.ObjToDoubleObj(val));
            }

            return true;
        }


        // 行全体として正当な値に整形する
        public virtual void FormalizeRow(Row row) {
        }


        public List<ColumnClass> ColumnList {
            get {
                return columns_;
            }
        }


        // 子ノードを列挙する
        public IEnumerable<Row> SelectChildren(int parentId, int depth = 1, string parentIdColName = "parent_id", string condition = "where (1=1)", string order = "") {
            foreach(var row in Select(condition + " and " + parentIdColName + " = " + parentId + " " + order)){
                if (depth == 1) {
                    yield return row;
                }
                else {
                    foreach (var childRow in SelectChildren((int)row.GetId(), depth - 1, parentIdColName, condition, order)) {
                        yield return childRow;
                    }
                }
            }
        }

        // 先祖ノードかどうかを判断する
        // depth=-1のときは、最上位の先祖まで検索
        public bool IsAncestorOf(int id, int ancestorId, int depth=-1, string parentIdColName = "parent_id") {
            int parentId = id;

            while (true) {
                if (parentId == ancestorId) {
                    return true;
                }
                if (parentId == -1) {
                    return false;
                }
                if (depth == 0) {
                    return false;
                }

                Row parentRow = this.GetFirstRow("where id = " + parentId);
                if (parentRow == null) {
                    return false;
                }

                parentId = (int)parentRow.GetLong(parentIdColName, -1);
                depth--;
            }
        }


        virtual public void LoadCSV(string filename) {
            OwnerDB.BeginTransaction();

            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    for (int col = 0; col < this.ColumnList.Count; col++) {
                        row.Set(this.ColumnList[col].Name, CSVParser.ReadColumn(token[col], this.ColumnList[col].Type));
                    }
                    this.Insert(row);
                }
            }

            OwnerDB.CommitTransaction();
        }
    }
}
