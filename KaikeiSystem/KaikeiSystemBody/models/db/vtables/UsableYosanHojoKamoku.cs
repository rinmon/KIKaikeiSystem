using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.vtables
{
    class UsableYosanHojoKamoku : AbstractVirtualTable
    {
        private KaikeiDatabase ownerDB;

        public UsableYosanHojoKamoku(KaikeiDatabase db)
            : base(db) {

            ownerDB = db;

            // 予算補助科目テーブルのカラムをコピー
            for(int i = 0; i < db.YosanHojokamoku.ColumnList.Count; i++){
                var col = db.YosanHojokamoku.ColumnList[i];
                if (col.Name == "id") {
                    continue;
                }
                base.AddColumn(col.Name, col.Type, col.Option);
            }

            base.AddColumn("seiri_bangou", ColumnType.TypeString, "");
        }


        public int Year { get; set; }
        public int KeiriKubun { get; set; }
        public int YosanKubun { get; set; }
        public int HoseiKaisuu { get; set; }
        public int KamokuId { get; set; }


        public override void SyncRowList() {
            rowList.Clear();

            string sql = string.Format("where nenndo = {0} and keiri_kubun={1} and yosan_kubun = {2} and hosei_kaisuu = {3}",
                                        Year, KeiriKubun, YosanKubun, HoseiKaisuu);

            foreach (var row in ownerDB.YosanHojokamoku.Select(sql)) {
                int hojoId = (int)row.GetLong("hojo_id", 0);
                if(hojoId <= 0){
                    continue;
                }

                Row hojoRow = ownerDB.MTHojoKamoku.GetRowFromCache(hojoId);
                if (hojoRow == null) {
                    continue;
                }
                if (hojoRow.GetLong("kamoku_id", -1) != KamokuId) {
                    continue;
                }

                Row newRow = this.NewRow();
                row.CopyColumns(newRow);
                newRow.Set("seiri_bangou", hojoRow.GetStr("kamoku_code"));
                rowList.Add(newRow);
            }

            rowList.Sort(delegate(Row a, Row b){
                string codeA = a.GetStr("seiri_bangou", "");
                string codeB = b.GetStr("seiri_bangou", "");
                return codeA.CompareTo(codeB);
            });
        }


        public override Row InsertSub(Row row) {
            ownerDB.YosanHojokamoku.Insert(row);
            return ownerDB.YosanHojokamoku.LastInsertedRow();
        }

        public override void UpdateSub(Row row) {
            ownerDB.YosanHojokamoku.Update(row);
        }

        public override void DeleteSub(Row row) {
            ownerDB.YosanHojokamoku.Delete(row);
        }
    }
}
