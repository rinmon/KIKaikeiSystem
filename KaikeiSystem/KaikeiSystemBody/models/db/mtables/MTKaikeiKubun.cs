using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// MT会計区分
    ///   法人 - 会計単位 - 拠点区分 - サービス区分 の4階層
    /// 旧システムのMT会計単位、MT法人団体、MT法人施設をまとめ、サービス区分を追加したもの
    /// </summary>
    class MTKaikeiKubun : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_kaikei_kubun";

        public Dictionary<int, List<Row>> ParentId2Child {
            get;
            private set;
        }

        public int TreeDepth {
            get;
            private set;
        }

        public int RootNodeId {
            get;
            private set;
        }

        public string RootName {
            get {
                return this.GetRowById(RootNodeId).GetStr("name");
            }
        }


        public MTKaikeiKubun(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("name", ColumnType.TypeString, "");              // 名前
            base.AddColumn("parent_id", ColumnType.TypeInt, "");            // 親区分のID
            base.AddColumn("genka_syoukyaku_ruikei_gaku", ColumnType.TypeAmount, "");  // 減価償却累計額
            base.AddColumn("yuubin_bangou", ColumnType.TypeString, "");             // 郵便番号
            base.AddColumn("todouhuken", ColumnType.TypeString, "");                // 都道府県
            base.AddColumn("si_ku_gun", ColumnType.TypeString, "");                 // 市区群
            base.AddColumn("tyou_son_iki", ColumnType.TypeString, "");              // 町村域
            base.AddColumn("tatemono_mei", ColumnType.TypeString, "");              // 建物名
            base.AddColumn("denwa_bangou", ColumnType.TypeString, "");              // 電話番号
            base.AddColumn("fax_bangou", ColumnType.TypeString, "");                // FAX番号
            base.AddColumn("daihyousya_shimei", ColumnType.TypeString, "");         // 代表者氏名
            base.AddColumn("barcode", ColumnType.TypeString, "");                   // バーコード
            base.AddColumn("shisetsu_kubun", ColumnType.TypeBool, "");              // 施設区分
            base.AddColumn("ryakusyou", ColumnType.TypeString, "");                 // 略称
            base.AddColumn("kubun_code", ColumnType.TypeInt, "");                   // 区分コード

            ParentId2Child = new Dictionary<int, List<Row>>();
            TreeDepth = 0;
            RootNodeId = 0;
        }


        public string GetJuusyoStr(Row row) {
            string buf;

            buf = row.GetStr("todouhuken") +
                row.GetStr("si_ku_gun") +
                row.GetStr("tyou_son_iki") +
                row.GetStr("tatemono_mei");

            return buf;
        }


        public Row GetParentOf(Row row) {
            int parentId = (int)row.GetLong("parent_id", -1);
            if (parentId == -1) {
                return null;
            }
            return GetRowFromCache(parentId);
        }

        public models.constants.MTKaikeiKubunHierarchy GetHierarchyOf(int id) {
            Row row = GetRowFromCache(id);
            if (row == null) {
                return models.constants.MTKaikeiKubunHierarchy.Houjin;
            }
            else {
                return GetHierarchyOf(row);
            }
        }

        public models.constants.MTKaikeiKubunHierarchy GetHierarchyOf(Row row) {
            Row parentRow = GetParentOf(row);
            if (parentRow == null) {
                return models.constants.MTKaikeiKubunHierarchy.Houjin;
            }
            else {
                return (models.constants.MTKaikeiKubunHierarchy)((int)GetHierarchyOf(parentRow) + 1);
            }
        }


        public bool IsChildOf(int  childId, int parentId) {
            int id = childId;

            while (true) {
                if (id == parentId) {
                    return true;
                }

                if (id == -1) {
                    return false;
                }

                object obj = this.GetFirst("parent_id", "where id=" + id);

                if (obj == null) {
                    return false;
                }

                id = (int)(obj as long?).Value;
            }
        }


        public override void UpdateCache() {
            base.UpdateCache();
            ParentId2Child.Clear();

            foreach (var row in RowCache.Values) {
                int parentKey = (int)row.GetLong("parent_id", -1);

                if (ParentId2Child.ContainsKey(parentKey)) {
                    ParentId2Child[parentKey].Add(row);
                }
                else {
                    var list = new List<Row>();
                    list.Add(row);
                    ParentId2Child.Add(parentKey, list);
                }
            }

            Action<int, int> traceTree = null;
            traceTree = delegate(int currentId, int currentDepth) {
                if (currentDepth > TreeDepth) {
                    TreeDepth = currentDepth;
                }
                if(ParentId2Child.ContainsKey(currentId)){
                    foreach (Row row in ParentId2Child[currentId]) {
                        traceTree((int)row.GetLong("id", -1), currentDepth + 1);
                    }
                }
            };
            traceTree(-1, 0);

            if (ParentId2Child.ContainsKey(-1) == false || ParentId2Child[-1] == null || ParentId2Child[-1].Count != 1) {
                // ルートノードが1つ以外の場合エラー！！
                throw new Exception("DBエラー：会計区分");
            }
            else {
                RootNodeId = (int)ParentId2Child[-1][0].GetLong("id", -1);
            }
        }
    }
}
