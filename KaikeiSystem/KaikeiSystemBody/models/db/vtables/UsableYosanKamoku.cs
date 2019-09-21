using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.vtables
{
    class UsableYosanKamoku : AbstractVirtualTable
    {
        private KaikeiDatabase ownerDB;

        public UsableYosanKamoku(KaikeiDatabase db) : base(db) {

            ownerDB = db;

            // 予算科目テーブルのカラムをコピー
            for(int i = 0; i < db.YosanKamoku.ColumnList.Count; i++){
                var col = db.YosanKamoku.ColumnList[i];
                if (col.Name == "id") {
                    continue;
                }
                base.AddColumn(col.Name, col.Type, col.Option);
            }

            base.AddColumn("kamoku_code", ColumnType.TypeString, "");
        }


        public int Year { get; set; }
        public int KeiriKubun { get; set; }
        public int YosanKubun { get; set; }
        public int HoseiKaisuu { get; set; }
        public int DaikubunId { get; set; }


        public override void SyncRowList() {
            rowList.Clear();

            string sql = string.Format("left join mt_kamoku k on k.id = kamoku_id where nenndo = {0} and keiri_kubun={1} and yosan_kubun = {2} and hosei_kaisuu = {3} and k.daikubun_id = {4} order by k.kamoku_code",
                                        Year, KeiriKubun, YosanKubun, HoseiKaisuu, DaikubunId);
            foreach (var row in ownerDB.YosanKamoku.Select(sql)) {
                Row newRow = this.NewRow();
                row.CopyColumns(newRow);
                rowList.Add(newRow);
            }

            /*
            string sql = string.Format("where nenndo = {0} and keiri_kubun={1} and yosan_kubun = {2} and hosei_kaisuu = {3}",
                                        Year, KeiriKubun, YosanKubun, HoseiKaisuu);

            foreach (var row in ownerDB.YosanKamoku.Select(sql)) {
                int kamokuId = (int)row.GetLong("kamoku_id", 0);
                if(kamokuId <= 0){
                    continue;
                }

                Row kamokuRow = ownerDB.MTKamoku.GetRowFromCache(kamokuId);
                if (kamokuRow == null) {
                    continue;
                }
                if (kamokuRow.GetLong("daikubun_id", -1) != DaikubunId) {
                    continue;
                }

                Row newRow = this.NewRow();
                row.CopyColumns(newRow);
                newRow.Set("kamoku_code", kamokuRow.GetStr("kamoku_code"));
                rowList.Add(newRow);
            }

            rowList.Sort(delegate(Row a, Row b){
                string codeA = a.GetStr("kamoku_code", "");
                string codeB = b.GetStr("kamoku_code", "");
                return codeA.CompareTo(codeB);
            });
            */
        }


        public override Row InsertSub(Row row) {
            ownerDB.YosanKamoku.Insert(row);
            return ownerDB.YosanKamoku.LastInsertedRow();
        }

        public override void UpdateSub(Row row) {
            ownerDB.YosanKamoku.Update(row);
        }

        public override void DeleteSub(Row row) {
            ownerDB.YosanKamoku.Delete(row);
        }
    }
}
