using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;


namespace KaikeiSystemBody.models.db
{
    /// <summary>
    /// データベースの抽象クラス
    /// </summary>
    abstract class AbstractDatabase
    {
        private Dictionary<string, AbstractTable> tables_;
        private System.Data.SQLite.SQLiteConnection conn_;
        private System.Data.SQLite.SQLiteTransaction transaction_;

        public AbstractDatabase(string db_path) {
            conn_ = new SQLiteConnection("Data Source=" + db_path);
            tables_ = new Dictionary<string, AbstractTable>();
            transaction_ = null;
            DBFilePath = db_path;
        }


        public string DBFilePath {
            get;
            private set;
        }


        /// <summary>
        /// Open失敗時は例外を投げる
        /// </summary>
        public void Open() {
            conn_.Open();
        }


        public void Close() {
            conn_.Close();
        }


        public void BeginTransaction() {
            transaction_ = conn_.BeginTransaction();
        }


        public void CommitTransaction() {
            transaction_.Commit();
            transaction_ = null;
        }

        public void RollbackTransaction() {
            transaction_.Rollback();
            transaction_ = null;
        }

        /// <summary>
        ///   SQLを直接発行してDBにアクセス。
        ///   DB以外のパッケージからは使用しないこと
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SQLiteDataReader ExecuteReader(string sql) {
            SQLiteCommand cmd = conn_.CreateCommand();
            cmd.CommandText = sql;
            var reader = cmd.ExecuteReader();

            return reader;
        }

        /// <summary>
        ///   SQLを直接発行してDBにアクセス。
        ///   DB以外のパッケージからは使用しないこと
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public void ExecuteNonQuery(string sql) {
            using (SQLiteCommand cmd = new SQLiteCommand(conn_)){
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
        }


        public bool ExistTable(string tableName) {
            string cmd;
            cmd = "select count(*) from sqlite_master where type='table' and name='" + tableName + "'";
            var reader = this.ExecuteReader(cmd);

            if (reader.Read()) {
                int ct = reader.GetInt32(0);
                if (ct == 1) {
                    return true;
                }
            }
            return false;
        }


        protected void AddTable(string tableName, AbstractTable table) {
            tables_[tableName] = table;
        }

        public AbstractTable Table(string tableName){
            if (tables_.ContainsKey(tableName)) {
                return tables_[tableName];
            }
            return null;
        }

        public void ReadSchemaOfTable(AbstractTable table) {
            var schema = conn_.GetSchema(table.TableName);

            foreach (var col in schema.Columns) {
            }
        }
    

        /// <summary>
        /// 存在しないテーブルを作成
        /// </summary>
        public void InitTables(bool createNonexistTable) {
            foreach (var key in tables_.Keys) {
                tables_[key].InitTable(createNonexistTable);
            }
        }
    }
}
