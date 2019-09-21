using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// MT勘定科目
    /// </summary>
    class MTKanjouKamoku : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_kanjou_kamoku";

        private Dictionary<string, Row> parentIdAndkamokuCode2RowCache;
        private Dictionary<string, Row> topParentIdAndkamokuCode2RowCache;
        private Dictionary<long, Row> kamokuKubunId2RowCache;
        private SortedList<char, int> parentKamokuFirstCharList;

        public MTKanjouKamoku(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("kamoku", ColumnType.TypeString, "");                    // 科目
            base.AddColumn("kamoku_yomi", ColumnType.TypeString, "");               // 科目よみ
            base.AddColumn("has_child", ColumnType.TypeBool, "");                   // 子科目あり
            base.AddColumn("parent_id", ColumnType.TypeInt, "");                    // 親科目ID
            base.AddColumn("shikin_kamoku_kubun_id", ColumnType.TypeInt, "");       // 資金科目区分ID
            base.AddColumn("jigyou_kamoku_kubun_id", ColumnType.TypeInt, "");       // 事業科目区分ID
            base.AddColumn("taisyaku_kamoku_kubun_id", ColumnType.TypeInt, "");     // 貸借科目区分ID
            base.AddColumn("taisyaku_kubun_id", ColumnType.TypeInt, "");            // 貸借区分ID
            base.AddColumn("usable", ColumnType.TypeBool, "");                      // 使用可能
            base.AddColumn("editable", ColumnType.TypeBool, "");                    // 変更可能
            base.AddColumn("kamoku_code", ColumnType.TypeString, "");               // 科目コード
            base.AddColumn("denpyou_print_target", ColumnType.TypeBool, "");        // 伝票仕訳印刷対象
            base.AddColumn("hierarchy", ColumnType.TypeInt, "");                    // 階層
            base.AddColumn("kaikei_kubun_id", ColumnType.TypeInt, "");              // 会計区分ID
            base.AddColumn("kaikei_kubun_hierarchy", ColumnType.TypeInt, "");       // 会計区分階層（取引が行われる階層）

            parentIdAndkamokuCode2RowCache = new Dictionary<string, Row>();
            topParentIdAndkamokuCode2RowCache = new Dictionary<string, Row>();
            kamokuKubunId2RowCache = new Dictionary<long, Row>();
            parentKamokuFirstCharList = new SortedList<char, int>();
        }


        public SortedList<char, int> ParentKamokuFirstCharList {
            get {
                return parentKamokuFirstCharList;
            }
        }


        public Row GetRowFromCodeCache(int parentId, string code) {
            if (code == null) {
                return null;
            }
            string key = code + "_" + parentId;
            if (parentIdAndkamokuCode2RowCache.ContainsKey(key)) {
                return parentIdAndkamokuCode2RowCache[key];
            }
            return null;
        }


        public Row GetRowFromCodeCacheByTopParent(int topParentId, string code) {
            if (code == null) {
                return null;
            }
            string key = code + "_" + topParentId;
            if (topParentIdAndkamokuCode2RowCache.ContainsKey(key)) {
                return topParentIdAndkamokuCode2RowCache[key];
            }
            return null;
        }


        public Row GetRowFromKamokuKubun(long kamokuKubunId) {
            if (kamokuKubunId2RowCache.ContainsKey(kamokuKubunId)) {
                return kamokuKubunId2RowCache[kamokuKubunId];
            }
            return null;
        }


        public string GetKamokuStr(int kanjouKamokuId, int torihikiKubun) {
            models.db.Row kamokuRow = this.GetRowFromCache(kanjouKamokuId);
            if (kamokuRow == null) {
                return "";
            }

            int kubunId = this.GetKamokuKubunId(kamokuRow, (models.constants.MTTorihikiKubun)torihikiKubun);

            models.db.Row kubunRow = (OwnerDB as KaikeiDatabase).MTKamokuKubun.GetRowFromCache(kubunId);
            return kubunRow.GetStr("name");
        }


        public int GetKamokuKubunId(Row kamokuRow, models.constants.MTTorihikiKubun torihikiKubun) {
            int kubunId = 0;
            string[] cols = new string[3];

            if (kamokuRow == null) {
                return -1;
            }

            if (torihikiKubun == models.constants.MTTorihikiKubun.Shikin) {
                cols[0] = "shikin_kamoku_kubun_id";
                cols[1] = "jigyou_kamoku_kubun_id";
                cols[2] = "taisyaku_kamoku_kubun_id";
            }
            else {
                cols[0] = "jigyou_kamoku_kubun_id";
                cols[1] = "shikin_kamoku_kubun_id";
                cols[2] = "taisyaku_kamoku_kubun_id";
            }

            for (int i = 0; i < cols.Length; i++) {
                kubunId = (int)kamokuRow.GetLong(cols[i], -1);
                if (kubunId != -1) {
                    return kubunId;
                }
            }

            return -1;
        }

        public int GetKamokuKubunId(int kanjouKamokuId, models.constants.MTTorihikiKubun torihikiKubun) {
            return GetKamokuKubunId(this.GetRowById(kanjouKamokuId), torihikiKubun);
        }

        public Row GetKamokuKubunRow(Row kanjouKamokuRow, models.constants.MTTorihikiKubun torihikiKubun) {
            if (kanjouKamokuRow == null) {
                return null;
            }
            int id = GetKamokuKubunId(kanjouKamokuRow, torihikiKubun);
            return (OwnerDB as KaikeiDatabase).MTKamokuKubun.GetRowById(id);
        }

        public Row GetKamokuKubunRow(int kanjouKamokuId, models.constants.MTTorihikiKubun torihikiKubun) {
            return GetKamokuKubunRow(this.GetRowById(kanjouKamokuId), torihikiKubun);
        }


        public int GetTopParentId(Row row) {
            while (row != null) {
                int id = (int)row.GetLong("id", -1);
                int parentId = (int)row.GetLong("parent_id", -1);
                if (parentId == -1) {
                    return id;
                }
                row = GetRowFromCache(parentId);
            }
            return -1;
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

        public override void UpdateCache() {
            base.UpdateCache();

            parentIdAndkamokuCode2RowCache.Clear();
            topParentIdAndkamokuCode2RowCache.Clear();
            parentKamokuFirstCharList.Clear();
            foreach (var row in base.RowCache.Values) {
                string code = row.GetStr("kamoku_code");
                int parentId = (int)row.GetLong("parent_id", -1);
                string key = code + "_" + parentId;
                parentIdAndkamokuCode2RowCache[key] = row;

                key = code + "_" + GetTopParentId(row);
                topParentIdAndkamokuCode2RowCache[key] = row;

                string yomi = row.GetStr("kamoku_yomi", " ");
                if(yomi != null && yomi != "" && parentId == -1){
                    parentKamokuFirstCharList[yomi[0]] = 1;
                }

                kamokuKubunId2RowCache[row.GetLong("shikin_kamoku_kubun_id", -1)] = row;
                kamokuKubunId2RowCache[row.GetLong("jigyou_kamoku_kubun_id", -1)] = row;
                kamokuKubunId2RowCache[row.GetLong("taisyaku_kamoku_kubun_id", -1)] = row;
            }

            kamokuKubunId2RowCache[-1] = null;
        }
    }
}
