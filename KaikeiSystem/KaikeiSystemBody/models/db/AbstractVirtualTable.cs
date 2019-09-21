using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db
{

    /// <summary>
    ///   実態を持たない仮想テーブル
    ///   実テーブルと同じインタフェースを実装する。
    /// </summary>
    abstract class AbstractVirtualTable : AbstractTable
    {
        protected List<models.db.Row> rowList;

        public AbstractVirtualTable(AbstractDatabase db) : base(db, null) {
            rowList = new List<Row>();
        }


        public void ClearRows() {
            rowList.Clear();
        }

        override public IEnumerable<Row> Select(string condition, int offset = 0, int limit = 0) {
            if (limit == 0) {
                limit = rowList.Count;
            }
            for (int i = offset; i < offset + limit; i++) {
                if (i >= rowList.Count) {
                    break;
                }
                yield return rowList[i];
            }
        }


        // 実装しない。使用禁止
        override public IEnumerable<object> SelectDistinct(string column, string condition) {
            throw new NotImplementedException();
        }

        // 実装しない。使用禁止
        override public long SelectSum(string column, string condition) {
            long sum = 0;

            foreach (var row in rowList) {
                sum += row.GetLong(column, 0);
            }

            return sum;
        }


        override public Row LastInsertedRow() {
            return rowList.Last();
        }


        override public int RowCount(string condition) {
            return rowList.Count;
        }


        // 実装しない。使用禁止
        override public int GetMax(string column, string condition = "") {
            throw new NotImplementedException();
        }

        override public void Insert(Row row) {
            Row insertedRow = InsertSub(row);
            rowList.Add(insertedRow);
        }


        override public void Update(Row row) {
            UpdateSub(row);
        }


        override public bool Delete(Row row) {
            DeleteSub(row);
            return rowList.Remove(row);
        }


        // 実装しない。使用禁止
        override public Row Revert(Row row) {
            throw new NotImplementedException();
        }


        abstract public void SyncRowList();
        abstract public Row InsertSub(Row row);
        abstract public void UpdateSub(Row row);
        abstract public void DeleteSub(Row row);
    }
}
