using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.tables
{
    /// <summary>
    /// 前期繰越科目区分
    /// </summary>
    class ZenkiKurikoshiKamokuKubun : AbstractTable
    {
        public const string TABLE_NAME = "zenki_kurikoshi_kamoku_kubun";

        public ZenkiKurikoshiKamokuKubun(AbstractDatabase db, string tableName = TABLE_NAME)
            : base(db, tableName) {
            base.AddColumn("kaikei_kubun_id", ColumnType.TypeInt, "");                            // 会計区分
            base.AddColumn("nenndo", ColumnType.TypeInt, "");                                     // 年度
            base.AddColumn("kamoku_kubun_id", ColumnType.TypeInt, "");                            // 科目区分ID
            base.AddColumn("zenki_kurikoshi_gaku", ColumnType.TypeAmount, "");                    // 前期繰越額
            base.AddColumn("taisyaku_kubun_id", ColumnType.TypeInt, "");                          // 貸借区分ID  !!使用しない. 表示時にmt_kanjou_kamokuからデータを取り出すように変更（貸借区分は変更される可能性があるため）
        }


        public void ConstructZenkiKurikoshi(int kaikeiKubunId, int year) {
            KaikeiDatabase db = OwnerDB as KaikeiDatabase;
            db.BeginTransaction();

            int rootId = (int)models.constants.MTKamokuKubun.TaisyakuRoot;
            foreach (var kubunRow in db.MTKamokuKubun.Select("where parent_id = " + rootId + " order by display_order")) {
                int kubunId = (int)kubunRow.GetId();
                foreach (var daikubunRow in db.MTKamokuKubun.Select("where parent_id = " + kubunId + " order by display_order")) {
                    int daikubunId = (int)daikubunRow.GetId();
                    AddNewKurikoshiRow(kaikeiKubunId, year, daikubunId);
                    foreach (var chukubunRow in db.MTKamokuKubun.Select("where parent_id = " + daikubunId + " order by display_order")) {
                        int chukubunId = (int)chukubunRow.GetId();
                        AddNewKurikoshiRow(kaikeiKubunId, year, chukubunId);
                        foreach (var syoukubunRow in db.MTKamokuKubun.Select("where parent_id = " + chukubunId + " order by display_order")) {
                            int syoukubunId = (int)syoukubunRow.GetId();
                            AddNewKurikoshiRow(kaikeiKubunId, year, syoukubunId);
                            foreach (var hojoRow in db.MTKamokuKubun.Select("where parent_id = " + syoukubunId + " order by display_order")) {
                                int hojoId = (int)hojoRow.GetId();
                                AddNewKurikoshiRow(kaikeiKubunId, year, hojoId);
                            }
                        }
                    }
                }
            }

            // 前期末支払資金残高
            AddNewZenkimatsuShiharaiShikinZandaka(kaikeiKubunId, year);

            db.CommitTransaction();
        }


        public void AddNewZenkimatsuShiharaiShikinZandaka(int kaikeiKubun, int nenndo) {
            AddNewKurikoshiRow(kaikeiKubun, nenndo, (int)models.constants.MTKamokuKubun.ZenkimatsuShiharaiShikinZandaka);
        }


        private void AddNewKurikoshiRow(int kaikeiKubun, int nenndo, int kamokuKubunId) {
            KaikeiDatabase db = OwnerDB as KaikeiDatabase;
            string sql = string.Format(
                "where nenndo={0} and kaikei_kubun_id={1} and kamoku_kubun_id={2}",
                nenndo, kaikeiKubun, kamokuKubunId
                );
            var row = db.ZenkiKurikoshiKamokuKubun.GetFirstRow(sql);

            if (row == null) {
                var newRow = db.ZenkiKurikoshiKamokuKubun.NewRow();
                newRow.Set("kaikei_kubun_id", kaikeiKubun);
                newRow.Set("kamoku_kubun_id", kamokuKubunId);
                newRow.Set("nenndo", nenndo);
                newRow.Set("zenki_kurikoshi_gaku", 0);
                newRow.Set("taisyaku_kubun_id", -1);  // 表示時にmt_kanjou_kamokuからデータを取り出すように変更（貸借区分は変更される可能性があるため）
                db.ZenkiKurikoshiKamokuKubun.Insert(newRow);
            }
        }
    }
}
