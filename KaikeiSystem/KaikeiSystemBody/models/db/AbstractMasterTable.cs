using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db
{
    /// <summary>
    /// マスタテーブル用クラス
    /// データのキャッシュを行う
    /// </summary>
    abstract class AbstractMasterTable : AbstractTable
    {
        private Dictionary<int, Row> row_cache_;

        public Dictionary<int, Row> RowCache {
            get {
                return row_cache_;
            }
        }


        public Row GetRowFromCache(int key) {
            if (row_cache_.ContainsKey(key)) {
                return row_cache_[key];
            }
            return null;
        }


        public AbstractMasterTable(AbstractDatabase db, string tableName)
            : base(db, tableName) {
            row_cache_ = new Dictionary<int, Row>();
        }


        override public void InitTable(bool createNonexistTable) {
            base.InitTable(createNonexistTable);

            UpdateCache();
        }


        virtual public void UpdateCache() {
            row_cache_.Clear();
            foreach (var row in base.Select("")) {
                row_cache_.Add((int)row.GetLong("id", -1), row);
            }
        }
    }
}
