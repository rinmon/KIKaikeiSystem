using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.vtables
{
    class UsableYosanDaikubun : AbstractVirtualTable
    {
        private KaikeiDatabase ownerDB;

        public UsableYosanDaikubun(KaikeiDatabase db) : base(db) {

            ownerDB = db;

            // 予算大区分テーブルのカラムをコピー
            for(int i = 0; i < db.YosanKamokuKubun.ColumnList.Count; i++){
                var col = db.YosanKamokuKubun.ColumnList[i];
                if (col.Name == "id") {
                    continue;
                }
                base.AddColumn(col.Name, col.Type, col.Option);
            }

            base.AddColumn("parent_kamoku_kubun_id", ColumnType.TypeInt, "");
        }


        public int Year { get; set; }
        public int KaikeiKubun { get; set; }
        public int YosanKubun { get; set; }
        public int HoseiKaisuu { get; set; }


        public override void SyncRowList() {
            rowList.Clear();

            string sql = string.Format("where nenndo = {0} and kaikei_kubun={1} and yosan_kubun = {2} and hosei_kaisuu = {3}",
                                        Year, KaikeiKubun, YosanKubun, HoseiKaisuu);


            foreach (var row in ownerDB.YosanDaikubun.Select(sql)) {
                int daikubunId = (int)row.GetLong("daikubun_id", 0);
                if(daikubunId <= 0){
                    continue;
                }

                Row daikubunRow = ownerDB.MTDaikubun.GetRowFromCache(daikubunId);
                if (daikubunRow == null) {
                    continue;
                }
                int shikinSyuushiId = (int)daikubunRow.GetLong("shikin_syuushi_id", 0);
                if (shikinSyuushiId <= 0) {
                    continue;
                }
                if (ownerDB.MTKamoku.RowCount("where shiyou_kubun = 0 and daikubun_id = " + daikubunId) <= 0) {
                    continue;
                }

                Row newRow = this.NewRow();
                row.CopyColumns(newRow);
                newRow.Set("shikin_syuushi_id", shikinSyuushiId);
                newRow.Set("daikubun_code", daikubunRow.GetStr("daikubun_code"));
                rowList.Add(newRow);
            }

            rowList.Sort(delegate(Row a, Row b){
                int shikinSyuushiIdA = (int)a.GetLong("shikin_syuushi_id", -1);
                int shikinSyuushiIdB = (int)b.GetLong("shikin_syuushi_id", -1);
                if(shikinSyuushiIdA != shikinSyuushiIdB){
                    return shikinSyuushiIdA - shikinSyuushiIdB;
                }
                else{
                    string codeA = a.GetStr("daikubun_code", "");
                    string codeB = b.GetStr("daikubun_code", "");
                    return codeA.CompareTo(codeB);
                }
            });
        }


        public override Row InsertSub(Row row) {
            ownerDB.YosanDaikubun.Insert(row);
            return ownerDB.YosanDaikubun.LastInsertedRow();
        }

        public override void UpdateSub(Row row) {
            //throw new NotImplementedException();
            ownerDB.YosanDaikubun.Update(row);
        }

        public override void DeleteSub(Row row) {
            throw new NotImplementedException();
        }
    }
}
