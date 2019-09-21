using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.views.controls
{
    partial class MTComboBox : MultiColumnComboBox
    {
        private models.db.AbstractTable bindedTable;

        public MTComboBox() {
            InitializeComponent();
        }


        // 会計区分
        public void InitRowsWithMTKaikeiKubun(models.db.mtables.MTKaikeiKubun table, bool onlyLeafNode, int maxNumCol = int.MaxValue-1) {
            int numCol = Math.Min(table.TreeDepth + 1, maxNumCol + 1);

            this.ClearRows();
            this.InitColumns(numCol, 0, 0);
            this.SetColumnVisibility(0, false);

            if (onlyLeafNode) {
                this.SetColumnVisibility(1, false);
            }

            object[] columns = new object[numCol];
            for (int i = 0; i < columns.Length; i++) {
                columns[i] = "";
            }

            models.db.Row root = table.RowCache[table.RootNodeId];

            Action<models.db.Row, int> traceTree = null;

            traceTree = delegate(models.db.Row row, int depth) {
                if (depth >= maxNumCol) {
                    return;
                }

                int id = (int)row.GetLong("id", -1);
                columns[depth + 1] = row.GetStr("name");
                columns[0] = id;

                if (!onlyLeafNode || !table.ParentId2Child.ContainsKey(id)) {
                    this.AddRowWithCaption(depth + 1, columns);
                }

                foreach(var child in table.Select("where parent_id = " + id + " order by kubun_code")){
                    traceTree(child, depth + 1);
                }

                columns[depth + 1] = "";
            };

            traceTree(root, 0);
            this.AdjustDropDownWidth();
            bindedTable = table;

            if(!onlyLeafNode) {
                this.ChangeToTreeView();
            }
        }


        //会計単位
        //  kaikei_tanni_id (invisible, key)
        //  kaikei_tanni (caption)
        public void InitRowsWithMTKaikeiTanni(models.db.mtables.MTKaikeiTanni table) {
            this.ClearRows();
            this.InitColumns(2, 0, 1);
            this.SetColumnVisibility(0, false);
            foreach (var key in table.RowCache.Keys) {
                this.AddRow(key, table.RowCache[key].GetStr("kaikei_tanni"));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }



        // 取引区分
        //  torihiki_kubun_id (invisible, key)
        //  torihiki_kubun (caption)
        public void InitRowsWithMTTorihikiKubun(models.db.mtables.MTTorihikiKubun table) {
            this.ClearRows();
            this.InitColumns(2, 0, 1);
            this.SetColumnVisibility(0, false);
            foreach (var key in table.RowCache.Keys) {
                this.AddRow(key, table.RowCache[key].GetStr("torihiki_kubun"));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }

        // 担保区分
        //  tanpo_kubun_id (invisible, key)
        //  caption (caption)
        public void InitRowsWithMTTanpoKubun(models.db.mtables.MTTanpoKubun table) {
            this.ClearRows();
            this.InitColumns(2, 0, 1);
            this.SetColumnVisibility(0, false);
            foreach (var key in table.RowCache.Keys) {
                this.AddRow(key, table.RowCache[key].GetStr("caption"));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }


        // 法人施設（経理区分）
        //  keiri_kubun_id (invisible, key)
        //  keiri_kubun (caption)
        public void InitRowsWithMTHoujinShisetsu(models.db.mtables.MTHoujinShisetsu table, bool showAll) {
            this.ClearRows();
            this.InitColumns(2, 0, 1);
            this.SetColumnVisibility(0, false);
            foreach (var key in table.RowCache.Keys) {
                if (key == 99 && showAll == false) { // "すべて"は表示しない
                    continue;
                }
                this.AddRow(key, table.RowCache[key].GetStr("shisetsu_meisyou"));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }


        // 予算区分
        //  yosan_kubun_id (invisible, key)
        //  yosan_kubun (caption)
        public void InitRowsWithMTYosanKubun(models.db.mtables.MTYosanKubun table) {
            this.ClearRows();
            this.InitColumns(2, 0, 1);
            this.SetColumnVisibility(0, false);
            foreach (var key in table.RowCache.Keys) {
                this.AddRow(key, table.RowCache[key].GetStr("yosan_kubun"));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }


        // 資金収支項目
        //  id (invisible, key)
        //  caption (caption)
        public void InitRowsWithMTShikinSyuushiKoumoku(models.db.mtables.MTShikinSyuushiKoumoku table) {
            this.ClearRows();
            this.InitColumns(2, 0, 1);
            this.SetColumnVisibility(0, false);
            foreach (var key in table.RowCache.Keys) {
                this.AddRow(key, table.RowCache[key].GetStr("caption"));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }


        // 事業活動収支項目
        //  id (invisible, key)
        //  caption (caption)
        public void InitRowsWithMTJigyouKatsudouSyuushiKoumoku(models.db.mtables.MTJigyouKatsudouSyuushiKoumoku table) {
            this.ClearRows();
            this.InitColumns(2, 0, 1);
            this.SetColumnVisibility(0, false);
            foreach (var key in table.RowCache.Keys) {
                this.AddRow(key, table.RowCache[key].GetStr("caption"));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }


        // 貸借対照項目
        //  id (invisible, key)
        //  caption (caption)
        public void InitRowsWithMTTaisyakuTaisyouKoumoku(models.db.mtables.MTTaisyakuTaisyouKoumoku table) {
            this.ClearRows();
            this.InitColumns(2, 0, 1);
            this.SetColumnVisibility(0, false);
            foreach (var key in table.RowCache.Keys) {
                this.AddRow(key, table.RowCache[key].GetStr("caption"));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }


        // 大区分
        public void InitRowsWithMTDaikubun(models.db.mtables.MTDaikubun table, string orderBy = "daikubun_code") {
            this.ClearRows();
            this.InitColumns(2, 1, 0);
            this.SetColumnVisibility(1, false);
            foreach (var row in table.Select("order by " + orderBy)) {
                this.AddRow(row.GetStr("daikubun", ""), row.GetStr("daikubun_code", "000"));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }

        
        // 科目
        public void InitRowsWithMTKanjouKamoku(models.db.mtables.MTKanjouKamoku table, int parentId, string orderBy = "kamoku_code", int hierarchy = 1) {
            this.ClearRows();
            this.InitColumns(2, 1, 0);
            foreach (var row in table.Select("where parent_id = " + parentId + " order by " + orderBy)) {
                this.AddRow(row.GetStr("kamoku", ""), row.GetStr("kamoku_code", "00000"));

                if (hierarchy == 1) {
                    continue;
                }
                foreach (var row2 in table.Select("where parent_id = " + row.GetLong("id", -1) + " order by " + orderBy)) {
                    this.AddRow("　" + row2.GetStr("kamoku", ""), row2.GetStr("kamoku_code", "00000"));
                }
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }

        // 科目 (caption: 科目コード)
        public void InitRowsWithMTKanjouKamokuWithKamokuCodeCaption(models.db.mtables.MTKanjouKamoku table, int parentId, string orderBy = "kamoku_code", int hierarchy = 1) {
            this.ClearRows();
            this.InitColumns(2, 0, 0);
            foreach (var row in table.Select("where parent_id = " + parentId + " order by " + orderBy)) {
                this.AddRow(row.GetStr("kamoku_code", "00000"), row.GetStr("kamoku", ""));

                if (hierarchy == 1) {
                    continue;
                }
                foreach (var row2 in table.Select("where parent_id = " + row.GetLong("id", -1) + " order by " + orderBy)) {
                    this.AddRow(row2.GetStr("kamoku_code", "00000"), "　" + row2.GetStr("kamoku", ""));
                }
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }

        // 科目区分 (親区分も表示, 区分で選択
        public void InitRowsWithMTKamokuKubunWithParentFilterByKubun(models.db.mtables.MTKamokuKubun table, int kubunId, string orderBy = "display_order") {
            this.ClearRows();
            this.InitColumns(3, 0, 1);
            this.SetColumnVisibility(0, false);
            foreach (var parentRow in table.Select("where parent_id = " + kubunId + " order by " + orderBy)) {
                foreach (var row in table.Select("where parent_id = " + parentRow.GetLong("id", -1) + " order by " + orderBy)) {
                    this.AddRow(row.GetLong("id", -1), row.GetStr("name", ""), parentRow.GetStr("name", ""));
                }
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }

        // 科目区分 (親区分も表示
        public void InitRowsWithMTKamokuKubunWithParent(models.db.mtables.MTKamokuKubun table, int hierarchy, string orderBy = "display_order") {
            this.ClearRows();
            this.InitColumns(3, 0, 1);
            this.SetColumnVisibility(0, false);
            foreach (var parentRow in table.Select("where hierarchy = " + (hierarchy - 1) + " order by " + orderBy)) {
                foreach (var row in table.Select("where parent_id = " + parentRow.GetLong("id", -1) + " order by " + orderBy)) {
                    this.AddRow(row.GetLong("id", -1), row.GetStr("name", ""), parentRow.GetStr("name", ""));
                }
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }

        // 科目区分 (親区分は表示しない)
        public void InitRowsWithMTKamokuKubunWithoutParent(models.db.mtables.MTKamokuKubun table, int hierarchy, string orderBy = "display_order") {
            this.ClearRows();
            this.InitColumns(2, 0, 1);
            this.SetColumnVisibility(0, false);
            foreach (var parentRow in table.Select("where hierarchy = " + (hierarchy - 1) + " order by " + orderBy)) {
                foreach (var row in table.Select("where parent_id = " + parentRow.GetLong("id", -1) + " order by " + orderBy)) {
                    this.AddRow(row.GetLong("id", -1), row.GetStr("name", ""));
                }
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }

        // 貸借区分
        public void InitRowsWithMTTaisyakuKubun(models.db.mtables.MTTaisyakuKubun table, string orderBy = "id") {
            this.ClearRows();
            this.InitColumns(2, 1, 0);
            this.SetColumnVisibility(1, false);
            foreach (var row in table.Select(" order by " + orderBy)) {
                this.AddRow(row.GetStr("caption", ""), row.GetLong("id", -1));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }


        public void InitRowsWithMTKamoku(models.db.mtables.MTKamoku table, string orderBy = "kamoku_code") {
            this.ClearRows();
            this.InitColumns(2, 1, 0);
            foreach (var row in table.Select("order by " + orderBy)) {
                this.AddRow(row.GetStr("kamoku", ""), row.GetStr("kamoku_code", "00000"));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }

        public void InitRowsWithMTKamokuUsableOnly(models.db.mtables.MTKamoku table, string orderBy = "kamoku_code") {
            this.ClearRows();
            this.InitColumns(2, 1, 0);
            this.SetColumnVisibility(1, false);
            foreach (var row in table.Select("where shiyou_kubun = 0 order by " + orderBy)) {
                this.AddRow(row.GetStr("kamoku", ""), row.GetLong("id", 0));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }

        public void InitRowsWithMTKanjouKamokuFilterByDaikubun(models.db.mtables.MTKanjouKamoku table, models.db.mtables.MTKamokuKubun kubunTable, int daikubunId, string kubunColName, string orderBy = "kamoku_code") {
            this.ClearRows();
            this.InitColumns(4, 3, 0);
            this.SetColumnVisibility(3, false);

            string daikubunStr = "";
            string sql = string.Format(
                " as a left join {0} as kubun1 on a.{3} = kubun1.id" +
                " left join {0} as kubun2 on kubun1.parent_id = kubun2.id where kubun2.id = {1} order by {2}",
                kubunTable.TableName,
                daikubunId,
                orderBy,
                kubunColName
            );
            daikubunStr = kubunTable.GetFirst("name", "where id = " + daikubunId) as string;
            if (daikubunStr == null) {
                daikubunStr = "";
            }

            foreach (var row in table.Select(sql)) {
                this.AddRow(row.GetStr("kamoku_code", "00000"), daikubunStr, row.GetStr("kamoku", ""), row.GetLong("id", 0));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }

        public void InitRowsWithMTKamokuFilterByMTDaikubun(models.db.mtables.MTKamoku table, models.db.mtables.MTDaikubun daikubun, int daikubunCode, string orderBy = "kamoku_code") {
            this.ClearRows();
            this.InitColumns(4, 3, 0);
            this.SetColumnVisibility(3, false);

            string daikubunStr = "";
            int daikubunId = 0;
            var daikubunRow = daikubun.Select("where daikubun_code = '" + daikubunCode + "'");
            if (daikubunRow.Count() > 0) {
                daikubunStr = daikubunRow.First().GetStr("daikubun");
                daikubunId = (int)daikubunRow.First().GetLong("id", 0);
            }

            foreach (var row in table.Select("where daikubun_id = " + daikubunId + " order by " + orderBy)) {
                this.AddRow(row.GetStr("kamoku_code", "00000"), daikubunStr, row.GetStr("kamoku", ""), row.GetLong("id", 0));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }

        public void InitRowsWithMTKamokuFilterByMTDaikubun2(models.db.mtables.MTKamoku table, models.db.mtables.MTDaikubun daikubun, int daikubunId, string orderBy = "kamoku_code") {
            this.ClearRows();
            this.InitColumns(3, 2, 1);
            this.SetColumnVisibility(0, false);
            this.SetColumnVisibility(2, false);

            foreach (var row in table.Select("where daikubun_id = " + daikubunId + " order by " + orderBy)) {
                this.AddRow(row.GetStr("kamoku_code", "00000"), row.GetStr("kamoku", ""), row.GetLong("id", 0));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }

        public void InitRowsWithShisanKamoku(models.db.mtables.MTKamoku table, models.db.mtables.MTDaikubun daikubun) {
            this.ClearRows();
            this.InitColumns(3, 2, 0);
            this.SetColumnVisibility(2, false);

            foreach (var row in table.Select("where shiyou_kubun = 0 order by daikubun_id, kamoku_yomi")) {
                models.db.Row daikubunRow = daikubun.GetRowFromCache((int)row.GetLong("daikubun_id", -1));
                if(daikubunRow == null){
                    continue;
                }
                int taisyakuId = (int)daikubunRow.GetLong("taisyaku_taisyou_id", -1);
                if (taisyakuId != 1) {
                    continue;
                }
                if (table.IsRyuudouShisanKamoku((int)row.GetLong("id", -1))) {
                    continue;
                }
                this.AddRow(row.GetStr("kamoku", ""), daikubunRow.GetStr("daikubun"), row.GetLong("id", 0));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }

        public void InitRowsWithTaisyakuKamoku(models.db.mtables.MTKamoku table, models.db.mtables.MTDaikubun daikubun, string orderBy = "kamoku_code") {
            this.ClearRows();
            this.InitColumns(4, 3, 0);
            this.SetColumnVisibility(3, false);
            
            foreach (var row in table.Select("order by " + orderBy)) {
                string daikubunStr = "";

                var daikubunRow = daikubun.Select("where id = " + row.GetLong("daikubun_id", -1));
                if (daikubunRow.Count() > 0) {
                    daikubunStr = daikubunRow.First().GetStr("daikubun");
                    string daikubunCode = daikubunRow.First().GetStr("daikubun_code");
                    if (int.Parse(daikubunCode) == (int)models.constants.MTDaikubunCode.JikiKurikoshikatsudouSyuushiSagaku) {
                        continue;
                    }
                    if (daikubunRow.First().GetLong("taisyaku_taisyou_id", 0) <= 0) {
                        continue;
                    }
                }
                this.AddRow(row.GetStr("kamoku_code", "00000"), daikubunStr, row.GetStr("kamoku", ""), row.GetLong("id", 0));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }


        public void InitRowsWithTaisyakuKanjouKamoku(models.db.mtables.MTKanjouKamoku table, models.db.mtables.MTKamokuKubun kamokuKubun, string orderBy = "kamoku_code") {
            this.ClearRows();
            this.InitColumns(4, 3, 0);
            this.SetColumnVisibility(3, false);

            string sql = string.Format(
                "where hierarchy = {0} and taisyaku_kamoku_kubun_id <> -1 order by {1}",
                (int)models.constants.MTKanjouKamokuHierarchy.ChuuKubun,
                orderBy
            );

            foreach (var row in table.Select(sql)) {
                string daikubunStr = "";

                models.db.Row kubunRow = kamokuKubun.GetFirstRow("where id = " + row.GetLong("taisyaku_kamoku_kubun_id", -1));
                if (kubunRow == null) {
                    continue;
                }
                models.db.Row daikubunRow = kamokuKubun.GetFirstRow("where id = " + kubunRow.GetLong("parent_id", -1));
                if(daikubunRow != null){
                    if((int)daikubunRow.GetLong("id", -1) == (int)models.constants.MTKamokuKubun.JikiKurikoshikatsudouZougenSagakuDaikubun){
                        continue;
                    }
                    daikubunStr = daikubunRow.GetStr("name", "");
                }

                this.AddRow(row.GetStr("kamoku_code", "00000"), daikubunStr, row.GetStr("kamoku", ""), row.GetLong("id", 0));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }


        public void BindToMTKanjouKamkouComboBox(MTComboBox combo, int parentId) {
            var self = this;
            combo.SelectedIndexChanged += delegate(object sender, EventArgs arg) {
                models.db.Row kamokuRow = (combo.bindedTable as models.db.mtables.MTKanjouKamoku).GetRowFromCodeCache(parentId, combo.SelectedKeyAsStr);
                self.ClearRows();
                self.Text = "";
                if (kamokuRow != null) {
                    self.InitRowsWithMTKanjouKamoku((combo.bindedTable.OwnerDB as models.db.KaikeiDatabase).MTKanjouKamoku, (int)kamokuRow.GetLong("id", 0), "kamoku_code", 2);
                }
            };
        }

        public void BindToMTKanjouKamkouComboBoxWithKamokuCodeCaption(MTComboBox combo, int parentId) {
            var self = this;
            combo.SelectedIndexChanged += delegate(object sender, EventArgs arg) {
                models.db.Row kamokuRow = (combo.bindedTable as models.db.mtables.MTKanjouKamoku).GetRowFromCodeCache(parentId, combo.SelectedKeyAsStr);
                self.ClearRows();
                self.Text = "";
                if (kamokuRow != null) {
                    self.InitRowsWithMTKanjouKamokuWithKamokuCodeCaption((combo.bindedTable.OwnerDB as models.db.KaikeiDatabase).MTKanjouKamoku, (int)kamokuRow.GetLong("id", 0), "kamoku_code", 2);
                }
            };
        }


        // 科目 (ID, 名称)
        public void InitRowsWithMTKamokuReverse(models.db.mtables.MTKamoku table, string orderBy = "kamoku_code") {
            this.ClearRows();
            this.InitColumns(2, 0, 0);
            foreach (var row in table.Select("order by " + orderBy)) {
                this.AddRow(row.GetStr("kamoku_code", "00000"), row.GetStr("kamoku", ""));
            }
            this.AdjustDropDownWidth();
            bindedTable = table;
        }


        // 補助科目
        public void InitRowsWithMTHojoKamokuWhereKeyIsId(models.db.mtables.MTHojoKamoku table, int parentKamokuId) {
            this.ClearRows();
            this.InitColumns(2, 0, 1);
            this.SetColumnVisibility(0, false);
            //this.SetColumnWidth(0, this.Width - 16);
            foreach (var row in table.Select("where kamoku_id = " + parentKamokuId + " order by seiri_bangou")) {
                this.AddRow((int)row.GetLong("id", 0), row.GetStr("hojo_kamoku", ""));
            }
            this.AdjustDropDownWidth();
        }

        public void InitRowsWithMTHojoKamokuReverse(models.db.mtables.MTHojoKamoku table, int parentKamokuId) {
            this.ClearRows();
            this.InitColumns(2, 0, 0);
            //this.SetColumnVisibility(1, false);
            this.SetColumnWidth(0, this.Width - 16);
            foreach (var row in table.Select("where kamoku_id = " + parentKamokuId + " order by seiri_bangou")) {
                this.AddRow((int)row.GetLong("seiri_bangou", 0), row.GetStr("hojo_kamoku", ""));
            }
            this.AdjustDropDownWidth();
        }


        public void BindToMTKamkouComboBoxReverse(MTComboBox combo) {
            var self = this;
            combo.SelectedIndexChanged += delegate(object sender, EventArgs arg) {
                models.db.Row kamokuRow = (combo.bindedTable as models.db.mtables.MTKamoku).GetRowFromCodeCache(combo.SelectedKeyAsStr);
                self.ClearRows();
                self.Text = "";
                self.OnSelectedIndexChanged(null);
                if (kamokuRow != null) {
                    self.InitRowsWithMTHojoKamokuReverse((combo.bindedTable.OwnerDB as models.db.KaikeiDatabase).MTHojoKamoku, (int)kamokuRow.GetLong("id", 0));
                }
            };
        }


        // 償却方法
        public void InitRowsWithMTSyoukyakuHouhou(models.db.mtables.MTSyoukyakuHouhou table) {
            this.ClearRows();
            this.InitColumns(2, 1, 0);
            this.SetColumnVisibility(1, false);
            foreach (var row in table.Select("")) {
                this.AddRow(row.GetStr("syoukyaku_houhou"), (int)row.GetLong("id", -1));
            }
            this.AdjustDropDownWidth();
        }

        
        // 償却可否
        public void InitRowsWithMTSyoukyakuKahi(models.db.mtables.MTSyoukyakuKahi table) {
            this.ClearRows();
            this.InitColumns(2, 1, 0);
            this.SetColumnVisibility(1, false);
            foreach (var row in table.Select("")) {
                this.AddRow(row.GetStr("syoukyaku_kahi"), (int)row.GetLong("id", -1));
            }
            this.AdjustDropDownWidth();
        }
    }
}
