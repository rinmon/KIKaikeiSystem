using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.vtables
{
    class BufferedYosanKamokuKubun : AbstractVirtualTable
    {
        private KaikeiDatabase ownerDB;

        public BufferedYosanKamokuKubun(KaikeiDatabase db)
            : base(db) {

            ownerDB = db;

            // 予算科目区分テーブルのカラムをコピー
            for(int i = 0; i < db.YosanKamokuKubun.ColumnList.Count; i++){
                var col = db.YosanKamokuKubun.ColumnList[i];
                if (col.Name == "id") {
                    continue;
                }
                base.AddColumn(col.Name, col.Type, col.Option);

                ParentId = -1;
            }
        }


        public int ParentId { get; set; }
        public bool UsableOnly { get; set; }

        public override void SyncRowList() {
            rowList.Clear();

            string sql = " as a left join " + models.db.mtables.MTKamokuKubun.TABLE_NAME + " as b on a.kamoku_kubun_id = b.id " +
                " where a.parent_id = " + ParentId + " order by display_order";
            foreach (var row in ownerDB.YosanKamokuKubun.Select(sql)) {
                var kubunRow = ownerDB.MTKamokuKubun.GetRowById((int)row.GetLong("kamoku_kubun_id", -1));
                if (kubunRow == null) {
                    continue;
                }
                var kanjouRow = ownerDB.MTKanjouKamoku.GetRowById((int)kubunRow.GetLong("kanjou_kamoku_id", -1));
                bool usable = false;
                if (kanjouRow == null) {
                    int kubunId = (int)kubunRow.GetLong("id", -1);
                    if (ownerDB.MTKamokuKubun.RowCount(
                        "as a left join " + models.db.mtables.MTKanjouKamoku.TABLE_NAME +
                        " as b on a.kanjou_kamoku_id = b.id where a.parent_id = " + kubunId + " and b.usable = 1") > 0) {
                        usable = true;
                    }
                }
                else if(kanjouRow.GetBool("usable", false)){
                    usable = true;
                }

                if ((!UsableOnly) || usable) {
                    Row newRow = this.NewRow();
                    row.CopyColumns(newRow);
                    rowList.Add(newRow);
                }
            }

        }


        public override Row InsertSub(Row row) {
            throw new NotImplementedException();
        }

        public override void UpdateSub(Row row) {
            ownerDB.YosanKamokuKubun.Update(row);
        }

        public override void DeleteSub(Row row) {
            throw new NotImplementedException();
        }

        //override public bool IsValidColumnValue(Row row, string column, object val) {
        //    return true;
        //}
        
        public long SumYosan() {
            long sum = 0;

            foreach (var row in rowList) {
                sum += row.GetLong("yosan", 0);
            }

            return sum;
        }
    }
}
