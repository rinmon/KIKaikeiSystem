using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db
{
    class BufferedTable : AbstractVirtualTable
    {
        private AbstractTable table;
        public delegate void SyncRowListDelegate(List<models.db.Row> rowList);
        public event SyncRowListDelegate SyncRowListFunc = null;

        public BufferedTable(AbstractTable aTable)
            : base(aTable.OwnerDB) {

            table = aTable;

            // カラムコピー
            for(int i = 0; i < table.ColumnList.Count; i++){
                var col = table.ColumnList[i];
                if (col.Name == "id") {
                    continue;
                }
                base.AddColumn(col.Name, col.Type, col.Option);
            }
        }


        public string SqlCondition { get; set; }

        public override void SyncRowList() {
            rowList.Clear();

            if (SyncRowListFunc == null) {
                foreach (var row in table.Select(SqlCondition)) {
                    Row newRow = this.NewRow();
                    row.CopyColumns(newRow);
                    rowList.Add(newRow);
                }
            }
            else {
                SyncRowListFunc(rowList);
            }
        }


        public override int GetMax(string column, string condition = "") {
            return table.GetMax(column, condition);
        }


        public override Row InsertSub(Row row) {
            table.Insert(row);
            return table.LastInsertedRow();
        }

        public override void UpdateSub(Row row) {
            table.Update(row);
        }

        public override void DeleteSub(Row row) {
            table.Delete(row);
        }
    }
}
