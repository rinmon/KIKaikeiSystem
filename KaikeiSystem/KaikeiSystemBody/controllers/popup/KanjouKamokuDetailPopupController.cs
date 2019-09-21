using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.controllers.popup
{
    class KanjouKamokuDetailPopupController
    {
        private grid.DBPanelGridController<views.grid.HojoKamokuRow> hojoKamokuGridController;
        private views.popup.KanjouKamokuDetailPopup popup;
        private models.db.vtables.BufferedMTKanjouKamoku bufferedHojoKamokuTable;
        private models.db.Row kanjouKamokuRow;
        private models.db.vtables.BufferedMTKanjouKamoku bufferedKanjouKamokuTable;

        public models.Context Context {
            get;
            set;
        }


        public KanjouKamokuDetailPopupController() {
            popup = null;
            bufferedHojoKamokuTable = null;
            kanjouKamokuRow = null;
        }


        // selectedKamokuRow=nullの場合は新規作成
        public void ShowPopup(System.Windows.Forms.Form owner, models.db.Row selectedKamokuRow, models.db.vtables.BufferedMTKanjouKamoku table) {
            bufferedKanjouKamokuTable = table;
            kanjouKamokuRow = CreateKanjouKamokuDetailRow(owner, selectedKamokuRow);
            if (kanjouKamokuRow == null) {
                return;
            }
            
            if (popup != null) {
                popup.Close();
                popup = null;
            }

            popup = new views.popup.KanjouKamokuDetailPopup();
            popup.PopupClosed += delegate() {
                popup = null;
                hojoKamokuGridController = null;
                bufferedHojoKamokuTable = null;
            };
            popup.CloseButtonClicked += delegate() {
                this.ClosePopup();
            };
            popup.AddSubButtonClicked += delegate(object sender) {
                var row = sender as views.grid.HojoKamokuRow;
                bufferedHojoKamokuTable.Update(row.RowData);
                models.db.Row rowData = Context.KaikeiDatabase.MTKanjouKamoku.NewRow();
                rowData.Set("usable", true);
                rowData.Set("editable", true);
                rowData.Set("denpyou_print_target", false);
                rowData.Set("parent_id", row.RowData.GetLong("id", -1));
                rowData.Set("kamoku_code", "" + (bufferedHojoKamokuTable.MaxCode() + 1));
                int insertedRowNo = bufferedHojoKamokuTable.InsertChildKamoku(rowData);
                hojoKamokuGridController.SetQuery("");
                hojoKamokuGridController.SetFocus(insertedRowNo, null);
            };
            popup.FormClosing += delegate(object sender, System.Windows.Forms.FormClosingEventArgs e) {
                Dictionary<string, bool> codeHash = new Dictionary<string,bool>();
                int rowCt = 0;
                foreach (var row in bufferedHojoKamokuTable.Select("")) {
                    string code = row.GetStr("kamoku_code");
                    if (codeHash.ContainsKey(code)) {
                        helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgDuplicatedKamokuCode);
                        hojoKamokuGridController.SetFocus(rowCt, "kamoku_code");
                        e.Cancel = true;
                        return;
                    }
                    codeHash[code] = true;
                    rowCt++;
                }
                e.Cancel = false;
            };

            bufferedHojoKamokuTable = new models.db.vtables.BufferedMTKanjouKamoku(Context.KaikeiDatabase);
            bufferedHojoKamokuTable.RootId = (int)kanjouKamokuRow.GetLong("id", -1);
            bufferedHojoKamokuTable.Recursive = true;
            bufferedHojoKamokuTable.SyncRowList();

            hojoKamokuGridController = new grid.DBPanelGridController<views.grid.HojoKamokuRow>(popup.Grid, true);
            hojoKamokuGridController.SetTable(bufferedHojoKamokuTable);
            hojoKamokuGridController.InitInsertedRow += delegate(models.db.Row row) {
                row.Set("usable", true);
                row.Set("editable", true);
                row.Set("denpyou_print_target", true);
                row.Set("parent_id", (int)kanjouKamokuRow.GetLong("id", -1));
                row.Set("kamoku_code", "" + (bufferedHojoKamokuTable.MaxCode() + 1));
            };
            hojoKamokuGridController.ValidateColumnValue += delegate(views.grid.HojoKamokuRow row, string column, object value) {
                if (column == "kamoku") {
                    if (row.RowData.GetLong("shikin_kamoku_kubun_id", -1) != -1) {
                        row.RowData.Set("shikin_kamoku_kubun", value);
                    }
                    if (row.RowData.GetLong("jigyou_kamoku_kubun_id", -1) != -1) {
                        row.RowData.Set("jigyou_kamoku_kubun", value);
                    }
                    if (row.RowData.GetLong("taisyaku_kamoku_kubun_id", -1) != -1) {
                        row.RowData.Set("taisyaku_kamoku_kubun", value);
                    }
                }
            };
            hojoKamokuGridController.ValidateRemoveRow += delegate(views.grid.HojoKamokuRow row) {
                if ((row.RowData.Table.OwnerDB as models.db.KaikeiDatabase).KaikeiDenpyouMeisai.IsUsedKanjouKamoku(row.RowData.GetId())) {
                    helper.MsgBox.Err(Properties.Resources.MsgUsedKamokuCanNotDelete);
                    return false;
                }
                return true;
            };
            hojoKamokuGridController.SetQuery("");

            popup.KanjouKamokuDetailRow.SetMasterTables(Context.KaikeiDatabase);
            popup.KanjouKamokuDetailRow.SetRowData(kanjouKamokuRow, false);
            popup.KanjouKamokuDetailRow.Column_UpdateValueAction += DetailRowColumn_UpdateValue;
            popup.KanjouKamokuDetailRow.DeleteButtonClicked += DetailRowDeleteButtonClicked;

            popup.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            popup.Location = new System.Drawing.Point(
                owner.Location.X + (owner.Size.Width - popup.Size.Width) / 2,
                owner.Location.Y + (owner.Size.Height - popup.Size.Height) / 2
                );

            popup.ShowDialog(owner);
        }


        private void DetailRowDeleteButtonClicked() {
            if (bufferedHojoKamokuTable.RowCount("") > 0) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgDeleteHojoKamoku);
                return;
            }

            var res = System.Windows.Forms.MessageBox.Show(KaikeiSystemBody.Properties.Resources.MsgConfirmToDeleteRow,
                        KaikeiSystemBody.Properties.Resources.CaptionConfirm,
                        System.Windows.Forms.MessageBoxButtons.OKCancel,
                        System.Windows.Forms.MessageBoxIcon.Warning);
            if (res == System.Windows.Forms.DialogResult.OK) {
                if(Context.KaikeiDatabase.KaikeiDenpyouMeisai.IsUsedKanjouKamoku(kanjouKamokuRow.GetId())){
                    helper.MsgBox.Err(Properties.Resources.MsgUsedKamokuCanNotDelete);
                }
                else if (bufferedKanjouKamokuTable.Delete(kanjouKamokuRow)) {
                }
                else {
                    helper.MsgBox.ShowMsg("DB error", "err");
                }
                popup.Close();
            }

        }


        private void DetailRowColumn_UpdateValue(views.grid.AbstractPanelGridRow rowControl, string column, object value) {
            var row = (rowControl as views.grid.AbstractDBGridRow).RowData;
            var table = bufferedKanjouKamokuTable;
            var db = Context.KaikeiDatabase;

            row.Set(column, value);
            table.Update(row);
            (rowControl as views.grid.AbstractDBGridRow).SetRowData(row, true);    // 表示の更新
        }
 


        // row = nullのときは新規作成
        private models.db.Row CreateKanjouKamokuDetailRow(System.Windows.Forms.Form owner, models.db.Row row) {
            if (row == null) {
                views.controls.SelectKanjouKamokuDialog dlg = new views.controls.SelectKanjouKamokuDialog();
                if (dlg.ShowDialog(owner, Context) != System.Windows.Forms.DialogResult.OK) {
                    return null;
                }

                row = bufferedKanjouKamokuTable.NewRow();
                row.Set("parent_id", -1);
                row.Set("has_child", false);
                row.Set("parent_shikin_kamoku_kubun_id", dlg.ShikinKamokuKubunId);
                row.Set("parent_jigyou_kamoku_kubun_id", dlg.JigyouKamokuKubunId);
                row.Set("parent_taisyaku_kamoku_kubun_id", dlg.TaisyakuKamokuKubunId);
                row.Set("taisyaku_kubun_id", (int)models.constants.MTTaisyakuKubun.KariMinus);
                row.Set("usable", true);
                row.Set("editable", true);
                row.Set("denpyou_print_target", true);
                row.Set("hierarchy", (int)models.constants.MTKanjouKamokuHierarchy.ChuuKubun);

                int kamokuCode = 0;
                var maxKamokuRows = Context.KaikeiDatabase.MTKanjouKamoku.Select("where parent_id = -1 order by kamoku_code desc limit 1");
                if (maxKamokuRows.Count() == 1) {
                    string maxKamokuCodeStr = maxKamokuRows.First().GetStr("kamoku_code");
                    kamokuCode = helper.Converter.ObjToInt(maxKamokuCodeStr, 0) + 1;
                }
                else {
                    kamokuCode = 1;
                }
                string kamokuCodeStr = string.Format("{0:D5}", kamokuCode);
                row.Set("kamoku_code", kamokuCodeStr);
                bufferedKanjouKamokuTable.Insert(row);
                row = bufferedKanjouKamokuTable.LastInsertedRow();
            }

            int jigyouKubunId = (int)row.GetLong("jigyou_kamoku_kubun_id", -1);
            int taisyakuKubunId = (int)row.GetLong("taisyaku_kamoku_kubun_id", -1);
            int shikinKubunId = (int)row.GetLong("shikin_kamoku_kubun_id", -1);
            models.db.Row jigyouRow = Context.KaikeiDatabase.MTKamokuKubun.GetRowById(jigyouKubunId);
            models.db.Row taisyakuRow = Context.KaikeiDatabase.MTKamokuKubun.GetRowById(taisyakuKubunId);
            models.db.Row shikinRow = Context.KaikeiDatabase.MTKamokuKubun.GetRowById(shikinKubunId);
            if (jigyouRow != null) {
                row.Set("parent_jigyou_kamoku_kubun_id", jigyouRow.GetLong("parent_id", -1));
                row.Set("parent_jigyou_kamoku_kubun", jigyouRow.GetMasterStr("parent_id", "name", "", Context.KaikeiDatabase.MTKamokuKubun));
            }
            if (taisyakuRow != null) {
                row.Set("parent_taisyaku_kamoku_kubun_id", taisyakuRow.GetLong("parent_id", -1));
                row.Set("parent_taisyaku_kamoku_kubun", taisyakuRow.GetMasterStr("parent_id", "name", "", Context.KaikeiDatabase.MTKamokuKubun));
            }
            if (shikinRow != null) {
                row.Set("parent_shikin_kamoku_kubun_id", shikinRow.GetLong("parent_id", -1));
                row.Set("parent_shikin_kamoku_kubun", shikinRow.GetMasterStr("parent_id", "name", "", Context.KaikeiDatabase.MTKamokuKubun));
            }

            return row;
        }


        public void ClosePopup() {
            if (popup != null) {
                popup.Close();
            }
        }
    }
}
