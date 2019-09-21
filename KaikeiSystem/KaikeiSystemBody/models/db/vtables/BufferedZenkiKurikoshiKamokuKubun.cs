using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.vtables
{
    class BufferedZenkiKurikoshiKamokuKubun : AbstractVirtualTable
    {
        private KaikeiDatabase ownerDB;

        public BufferedZenkiKurikoshiKamokuKubun(KaikeiDatabase db)
            : base(db) {

            ownerDB = db;

            // 前期繰越科目区分テーブルのカラムをコピー
            for(int i = 0; i < db.ZenkiKurikoshiKamokuKubun.ColumnList.Count; i++){
                var col = db.ZenkiKurikoshiKamokuKubun.ColumnList[i];
                if (col.Name == "id") {
                    continue;
                }
                base.AddColumn(col.Name, col.Type, col.Option);

                KamokuKubunParentId = -1;
            }

            WithoutJikiKurikoshi = false;
        }


        public int KamokuKubunDepth { get; set; }
        public int KamokuKubunParentId { get; set; }
        public int Year { get; set; }
        public int KaikeiKubunId { get; set; }
        public bool WithoutJikiKurikoshi { get; set; }

        public override void SyncRowList() {
            rowList.Clear();

            foreach (var kamokuRow in ownerDB.MTKamokuKubun.SelectChildren(parentId:KamokuKubunParentId, depth:KamokuKubunDepth, order:"order by display_order")) {
                if (WithoutJikiKurikoshi) {
                    if (kamokuRow.GetId() == (int)models.constants.MTKamokuKubun.JikiKurikoshikatsudouZougenSagakuDaikubun) {
                        continue;
                    }
                    if (kamokuRow.GetId() == (int)models.constants.MTKamokuKubun.JikiKurikoshikatsudouZougenSagakuChukubun) {
                        continue;
                    }
                }

                string condition = string.Format("where kamoku_kubun_id={0} and nenndo={1} and kaikei_kubun_id={2}",
                    kamokuRow.GetId(), Year, KaikeiKubunId);
                var kurikoshiRow = ownerDB.ZenkiKurikoshiKamokuKubun.GetFirstRow(condition);

                if (kurikoshiRow != null) {
                    Row newRow = this.NewRow();
                    kurikoshiRow.CopyColumns(newRow);
                    rowList.Add(newRow);
                }
            }
        }


        public override Row InsertSub(Row row) {
            throw new NotImplementedException();
        }

        public override void UpdateSub(Row row) {
            ownerDB.ZenkiKurikoshiKamokuKubun.Update(row);
        }

        public override void DeleteSub(Row row) {
            throw new NotImplementedException();
        }

        //override public bool IsValidColumnValue(Row row, string column, object val) {
        //    return true;
        //}
        
        public long SumZenkiKurikoshiGaku() {
            long sum = 0;

            foreach (var row in rowList) {
                sum += row.GetLong("zenki_kurikoshi_gaku", 0);
            }

            return sum;
        }
    }
}
