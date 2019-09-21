using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// MT科目区分
    /// </summary>
    class MTKamokuKubun : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_kamoku_kubun";


        private Dictionary<int, int> childId2parentId;


        public MTKamokuKubun(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("name", ColumnType.TypeString, "");                      // 名前
            base.AddColumn("has_child", ColumnType.TypeBool, "");                   // 子科目あり
            base.AddColumn("parent_id", ColumnType.TypeInt, "");                    // 親区分ID
            base.AddColumn("hierarchy", ColumnType.TypeInt, "");                    // 階層
            //base.AddColumn("hide_in_summary", ColumnType.TypeBool, "");              // 集計表で表示しない
            base.AddColumn("display_order", ColumnType.TypeInt, "");                // 表示順
            base.AddColumn("kanjou_kamoku_id", ColumnType.TypeInt, "");             // 対応するMT勘定科目のID
            base.AddColumn("editable", ColumnType.TypeBool, "");             // 編集可能かどうか
            base.AddColumn("deleted", ColumnType.TypeBool, "");             // 削除されたかどうか

            base.AddIndex("create index " + TABLE_NAME + "_index on " + TABLE_NAME + "(display_order)");
            base.AddIndex("create index " + TABLE_NAME + "_index2 on " + TABLE_NAME + "(parent_id, display_order)");

            childId2parentId = new Dictionary<int, int>();
        }


        public long CalcHierarchy(Row row) {
            int parentId = (int)row.GetLong("parent_id", -1);
            if (parentId == -1) {
                return 0;
            }
            else {
                return CalcHierarchy(RowCache[parentId]) + 1;
            }
        }


        public override void UpdateCache() {
            base.UpdateCache();

            foreach (var row in base.RowCache.Values) {
                int id = (int)row.GetLong("id", -1);
                int parentId = (int)row.GetLong("parent_id", -1);

                childId2parentId[id] = parentId;

                //row.Set("hierarchy", CalcHierarchy(row));
                //this.Update(row);
            }
        }


        public bool IsParentOf(int childId, int parentId){
            int id = childId;

            while (true) {
                if (id == parentId) {
                    return true;
                }
                if (childId2parentId.ContainsKey(id)) {
                    id = childId2parentId[id];
                }
                else {
                    return false;
                }
            }
        }


        public Row GetParentOf(int id, int hierarchy = -1) {
            return GetParentOf(GetRowFromCache(id), hierarchy);
        }


        public Row GetParentOf(Row target, int hierarchy = -1) {
            if (hierarchy == -1) {
                hierarchy = (int)target.GetLong("hierarchy", 0) - 1;
            }

            Row row = target;
            while (true) {
                if ((int)row.GetLong("hierarchy", 0) == hierarchy) {
                    break;
                }
                int parentId = (int)row.GetLong("parent_id", -1);
                if (parentId == -1) {
                    row = null;
                    break;
                }
                row = GetRowFromCache(parentId);
            }

            return row;
        }


        public bool HasInvalidParent(Row target) {
            int parentId = (int)target.GetLong("parent_id", -1);

            if (parentId != -1 && GetRowFromCache(parentId) == null) {
                return true;
            }
            return false;
        }


        public bool IsSyuunyuuKamoku(int kamokuId) {
            if (IsParentOf(kamokuId, (int)constants.MTKamokuKubun.JigyouSyuunyuu) ||
                    IsParentOf(kamokuId, (int)constants.MTKamokuKubun.ShisetsuSyuunyuu) ||
                    IsParentOf(kamokuId, (int)constants.MTKamokuKubun.SonotaSyuunyuu)) {
                return true;
            }
            return false;
        }

        
        public bool IsShisyutsuKamoku(int kamokuId) {
            if (IsParentOf(kamokuId, (int)constants.MTKamokuKubun.JigyouShisyutsu) ||
                    IsParentOf(kamokuId, (int)constants.MTKamokuKubun.ShisetsuShisyutsu) ||
                    IsParentOf(kamokuId, (int)constants.MTKamokuKubun.SonotaShisyutsu)) {
                return true;
            }
            return false;
        }


        private bool SetKanjouKamokuIdSub(int id, int kanjouKamokuId) {
            if (id == -1) {
                return true;
            }

            var rows = this.Select("where id = " + id);
            if (rows.Count() != 1) {
                return false;
            }
            Row row = rows.First();

            row.Set("kanjou_kamoku_id", kanjouKamokuId);
            this.Update(row);

            return true;
        }

        public bool SetKanjouKamokuIdForAllRow() {
            foreach(var row in (OwnerDB as KaikeiDatabase).MTKanjouKamoku.Select("")){
                int kanjouKamokuId = (int)row.GetLong("id", -1);
                int shikin = (int)row.GetLong("shikin_kamoku_kubun_id", -2);
                int jigyou = (int)row.GetLong("jigyou_kamoku_kubun_id", -2);
                int taisyaku = (int)row.GetLong("taisyaku_kamoku_kubun_id", -2);

                bool res = SetKanjouKamokuIdSub(shikin, kanjouKamokuId);
                res &= SetKanjouKamokuIdSub(jigyou, kanjouKamokuId);
                res &= SetKanjouKamokuIdSub(taisyaku, kanjouKamokuId);

                if (res == false) {
                    return false;
                }
            }

            return true;
        }

        public void SetDislayOrderForAllRow() {
            foreach (var row in (OwnerDB as KaikeiDatabase).MTKamokuKubun.Select("")) {
                int kanjouKamokuId = (int)row.GetLong("kanjou_kamoku_id", -1);
                if (kanjouKamokuId != -1) {
                    Row kanjouKamokuRow = (OwnerDB as KaikeiDatabase).MTKanjouKamoku.Select("where id=" + kanjouKamokuId).First();
                    int displayOrder = helper.Converter.ObjToInt(kanjouKamokuRow.GetStr("kamoku_code", "-1"), -1);
                    row.Set("display_order", displayOrder);
                    this.Update(row);
                }
            }        
        }

        public bool IsInnerKaikeiKubunKamoku(int kaikeiKubunHierarchy, Row kamokuKubunRow) {
            Row kanjouKamokuRow = (OwnerDB as KaikeiDatabase).MTKanjouKamoku.GetRowById((int)kamokuKubunRow.GetLong("kanjou_kamoku_id", -1));

            if (kaikeiKubunHierarchy < (int)kanjouKamokuRow.GetLong("kaikei_kubun_hierarchy", -1)) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
