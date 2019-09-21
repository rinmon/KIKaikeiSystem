using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.vtables
{
    class BufferedMTKanjouKamoku : AbstractVirtualTable
    {
        private KaikeiDatabase ownerDB;

        public BufferedMTKanjouKamoku(KaikeiDatabase db)
            : base(db) {

            ownerDB = db;

            // 勘定科目テーブルのカラムをコピー
            for(int i = 0; i < db.MTKanjouKamoku.ColumnList.Count; i++){
                var col = db.MTKanjouKamoku.ColumnList[i];
                if (col.Name == "id") {
                    continue;
                }
                base.AddColumn(col.Name, col.Type, col.Option);

                RootId = -1;
            }

            base.AddColumn("jigyou_kamoku_kubun", ColumnType.TypeString, "");
            base.AddColumn("taisyaku_kamoku_kubun", ColumnType.TypeString, "");
            base.AddColumn("shikin_kamoku_kubun", ColumnType.TypeString, "");
        }


        public int RootId { get; set; }
        public bool Recursive { get; set; }

        public override void SyncRowList() {
            rowList.Clear();

            SyncRowListSub(RootId);
        }


        private void SyncRowListSub(int parentId) {
            string sql = string.Format("where parent_id = {0} order by kamoku_code",
                                        parentId);

            foreach (var row in ownerDB.MTKanjouKamoku.Select(sql)) {
                string shikinKubunName = ownerDB.MTKamokuKubun.GetFirst("name", "where id=" + row.GetLong("shikin_kamoku_kubun_id", -1)) as string;
                string jigyouKubunName = ownerDB.MTKamokuKubun.GetFirst("name", "where id=" + row.GetLong("jigyou_kamoku_kubun_id", -1)) as string;
                string taisyakuKubunName = ownerDB.MTKamokuKubun.GetFirst("name", "where id=" + row.GetLong("taisyaku_kamoku_kubun_id", -1)) as string;

                Row newRow = this.NewRow();
                row.CopyColumns(newRow);
                newRow.Set("shikin_kamoku_kubun", shikinKubunName);
                newRow.Set("jigyou_kamoku_kubun", jigyouKubunName);
                newRow.Set("taisyaku_kamoku_kubun", taisyakuKubunName);
                rowList.Add(newRow);

                if (Recursive) {
                    SyncRowListSub((int)row.GetLong("id", -1));
                }
            }
        }


        private void UpdateKanjouKamokuIdInKubunRow(int kubunId, int kanjouKamokuId) {
            var rows = ownerDB.MTKamokuKubun.Select("where id=" + kubunId);
            if(rows.Count() != 1){
                return;
            }
            var row = rows.First();

            row.Set("kanjou_kamoku_id", kanjouKamokuId);
            ownerDB.MTKamokuKubun.Update(row);

        }

        private int InsertKubunRow(string kubunName, int parentKubunId, int displayOrder) {
            if (parentKubunId == -1) {
                return -1;
            }

            Row parentKubunRow = ownerDB.MTKamokuKubun.GetRowById(parentKubunId);
            if (parentKubunRow == null) {
                return -1;
            }

            Row kubunRow = ownerDB.MTKamokuKubun.NewRow();
            kubunRow.Set("name", kubunName);
            kubunRow.Set("has_child", false);
            kubunRow.Set("parent_id", parentKubunId);
            kubunRow.Set("parent_id", parentKubunId);
            kubunRow.Set("hierarchy", parentKubunRow.GetLong("hierarchy", 0) + 1);
            kubunRow.Set("display_order", displayOrder);
            ownerDB.MTKamokuKubun.Insert(kubunRow);
            kubunRow = ownerDB.MTKamokuKubun.LastInsertedRow();
            int id = (int)kubunRow.GetLong("id", -1);
            kubunRow.Set("display_order", id);
            ownerDB.MTKamokuKubun.Update(kubunRow);

            parentKubunRow.Set("has_child", true);
            ownerDB.MTKamokuKubun.Update(parentKubunRow);

            return id;
        }


        private void UpdateKubunRow(string kubunName, int kubunId, int displayOrder) {
            if (kubunId == -1) {
                return;
            }

            Row kubunRow = ownerDB.MTKamokuKubun.Select("where id=" + kubunId).First();
            kubunRow.Set("name", kubunName);
            kubunRow.Set("display_order", displayOrder);
            ownerDB.MTKamokuKubun.Update(kubunRow);
        }

        private void DeleteKubunRow(int kubunId) {
            if (kubunId == -1) {
                return;
            }

            Row kubunRow = ownerDB.MTKamokuKubun.GetRowById(kubunId);
            if (kubunRow == null) {
                return;
            }
            int parentId = (int)kubunRow.GetLong("parent_id", -1);
            ownerDB.MTKamokuKubun.Delete(kubunRow);

            if (ownerDB.MTKamokuKubun.RowCount("where parent_id=" + parentId) == 0) {
                Row parentRow = ownerDB.MTKamokuKubun.GetRowById(parentId);
                parentRow.Set("has_child", false);
                ownerDB.MTKamokuKubun.Update(parentRow);
            }
        }


        public int InsertChildKamoku(Row row) {
            //int parentId = (int)row.GetLong("parent_id", -1);
            Row insertedRow = InsertSub(row);
            SyncRowList();

            for (int i = 0; i < rowList.Count; i++) {
                if (rowList[i].GetLong("id", -1) == insertedRow.GetLong("id", -1)) {
                    return i;
                }
            }
            return 0;
            /*
            for (int i = 0; i < rowList.Count; i++) {
                int id = (int)rowList[i].GetLong("id", -1);
                if (parentId == id) {
                    rowList.Insert(i + 1, insertedRow);
                    break;
                }
            }*/
        }


        public override Row InsertSub(Row row) {
            int parentShikinId;
            int parentJigyouId;
            int parentTaisyakuId;
            int parentId = (int)row.GetLong("parent_id", -1);
            Row parentRow = ownerDB.MTKanjouKamoku.GetRowById(parentId);
            if (parentRow != null) {
                parentShikinId = (int)parentRow.GetLong("shikin_kamoku_kubun_id", -1);
                parentJigyouId = (int)parentRow.GetLong("jigyou_kamoku_kubun_id", -1);
                parentTaisyakuId = (int)parentRow.GetLong("taisyaku_kamoku_kubun_id", -1);
            }
            else {
                parentShikinId = (int)row.GetLong("parent_shikin_kamoku_kubun_id", -1);
                parentJigyouId = (int)row.GetLong("parent_jigyou_kamoku_kubun_id", -1);
                parentTaisyakuId = (int)row.GetLong("parent_taisyaku_kamoku_kubun_id", -1);
            }
            int displayOrder = helper.Converter.ObjToInt(row.GetStr("kamoku_code", "-1"), -1);

            int shikinId = InsertKubunRow(row.GetStr("shikin_kamoku_kubun"), parentShikinId, displayOrder);
            int jigyouId = InsertKubunRow(row.GetStr("jigyou_kamoku_kubun"), parentJigyouId, displayOrder);
            int taisyakuId = InsertKubunRow(row.GetStr("taisyaku_kamoku_kubun"), parentTaisyakuId, displayOrder);

            row.Set("shikin_kamoku_kubun_id", shikinId);
            row.Set("jigyou_kamoku_kubun_id", jigyouId);
            row.Set("taisyaku_kamoku_kubun_id", taisyakuId);

            row.Set("has_child", false);
            if (parentRow != null) {
                row.Set("taisyaku_kubun_id", parentRow.Get("taisyaku_kubun_id"));
                row.Set("hierarchy", parentRow.GetLong("hierarchy", 0) + 1);
                // set parent
                parentRow.Set("has_child", true);
                ownerDB.MTKanjouKamoku.Update(parentRow);
            }
            else {
                row.Set("taisyaku_kubun_id", (int)models.constants.MTTaisyakuKubun.KariMinus);
                row.Set("hierarchy", (int)models.constants.MTKanjouKamokuHierarchy.ChuuKubun);
            }

            ownerDB.MTKanjouKamoku.Insert(row);

            Row lastInsertedRow = ownerDB.MTKanjouKamoku.LastInsertedRow();
            int lastInsertedId = (int)lastInsertedRow.GetLong("id", -1);
            UpdateKanjouKamokuIdInKubunRow(shikinId, lastInsertedId);
            UpdateKanjouKamokuIdInKubunRow(jigyouId, lastInsertedId);
            UpdateKanjouKamokuIdInKubunRow(taisyakuId, lastInsertedId);

            return lastInsertedRow;
        }

        public override void UpdateSub(Row row) {
            int shikinId = (int)row.GetLong("shikin_kamoku_kubun_id", -1);
            int jigyouId = (int)row.GetLong("jigyou_kamoku_kubun_id", -1);
            int taisyakuId = (int)row.GetLong("taisyaku_kamoku_kubun_id", -1);
            int displayOrder = helper.Converter.ObjToInt(row.GetStr("kamoku_code", "-1"), -1);

            UpdateKubunRow(row.GetStr("shikin_kamoku_kubun"), shikinId, displayOrder);
            UpdateKubunRow(row.GetStr("jigyou_kamoku_kubun"), jigyouId, displayOrder);
            UpdateKubunRow(row.GetStr("taisyaku_kamoku_kubun"), taisyakuId, displayOrder);

            ownerDB.MTKanjouKamoku.Update(row);
        }

        public override void DeleteSub(Row row) {
        }

        public override bool Delete(Row row) {
            int id = (int)row.GetLong("id", -1);
            int parentId = (int)row.GetLong("parent_id", -1);
            int shikinId = (int)row.GetLong("shikin_kamoku_kubun_id", -1);
            int jigyouId = (int)row.GetLong("jigyou_kamoku_kubun_id", -1);
            int taisyakuId = (int)row.GetLong("taisyaku_kamoku_kubun_id", -1);

            DeleteKubunRow(shikinId);
            DeleteKubunRow(jigyouId);
            DeleteKubunRow(taisyakuId);

            ownerDB.MTKanjouKamoku.Delete(row);

            if (ownerDB.MTKanjouKamoku.RowCount("where parent_id=" + parentId) == 0) {
                Row parentRow = ownerDB.MTKanjouKamoku.GetRowById(parentId);
                if (parentRow != null) {
                    parentRow.Set("has_child", false);
                    ownerDB.MTKanjouKamoku.Update(parentRow);
                }
            }
            SyncRowList();

            return true;
        }


        override public bool IsValidColumnValue(Row row, string column, object val) {
            return true;
        }

        public int MaxCode() {
            int maxCode = 0;

            foreach (var row in rowList) {
                string codeStr = row.GetStr("kamoku_code", "");
                int code = helper.Converter.ObjToInt(codeStr, 0);

                if (code > maxCode) {
                    maxCode = code;
                }
            }

            return maxCode;
        }
    }
}
