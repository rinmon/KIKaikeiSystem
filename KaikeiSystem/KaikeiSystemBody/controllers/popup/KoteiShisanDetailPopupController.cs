using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers.popup
{
    class KoteiShisanDetailPopupController
    {
        private misc.FocusController focusController;
        private grid.DBPanelGridController<views.grid.SyoukyakuMeisaiRow> meisaiGridController;
        private models.db.BufferedTable meisaiTable;
        private views.popup.KoteiShisanDetailPopup popup;
        private int selectedRowNo;
        private models.db.Row selectedRow;

        public KoteiShisanDetailPopupController() {
            selectedRow = null;
        }

        public models.Context Context {
            get;
            set;
        }


        public void ShowPopupModal(Form parent, int rowId) {
            popup = new views.popup.KoteiShisanDetailPopup();

            popup.PopupClosed += delegate() { };
            popup.CloseButtonClicked += () => popup.Close();
            popup.ColumnValueChanged += ColumnValueChanged;
            popup.FirstButtonClickekd += () => SelectRow(0);
            popup.EndButtonClicked += () => SelectRow(RowCount - 1);
            popup.PrevButtonClicked += () => SelectRow(Math.Max(selectedRowNo - 1, 0));
            popup.NextButtonClicked += () => SelectRow(Math.Min(selectedRowNo + 1, RowCount));
            popup.NewButtonClicked += () => SelectRow(RowCount);
            popup.DeleteButtonClicked += delegate() {
                if (SelectedRowId != -1) {
                    selectedRow.Table.Delete(selectedRow);
                    SelectRow(selectedRowNo);
                }
            };
            popup.IkkatsuSyoukyakuButtonClicked += delegate() {
                foreach (var row in Context.KaikeiDatabase.MTKoteiShisan.Select("")) {
                    int id = (int)row.GetLong("id", -1);
                    if(id != -1){
                        models.KoteiShisanFunc.CreateGenkaSyoukyakuMeisai(Context, id);
                    }
                }
                meisaiTable.SyncRowList();
                meisaiGridController.SetQuery("");
                helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgSucceeded);
            };
            popup.SyoukyakuButtonClicked += delegate() {
                if (SelectedRowId != -1) {
                    if (models.KoteiShisanFunc.CreateGenkaSyoukyakuMeisai(Context, SelectedRowId)) {
                        meisaiTable.SyncRowList();
                        meisaiGridController.SetQuery("");
                        helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgSucceeded);
                    }
                    else {
                        helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInputDataIncomplete);
                    }
                }
            };
            popup.DeleteMeisaiButtonClicked += delegate() {
                if (SelectedRowId != -1) {
                    var res = System.Windows.Forms.MessageBox.Show(KaikeiSystemBody.Properties.Resources.MsgConfirmToDeleteRow,
                                KaikeiSystemBody.Properties.Resources.CaptionConfirm,
                                System.Windows.Forms.MessageBoxButtons.OKCancel,
                                System.Windows.Forms.MessageBoxIcon.Warning);
                    if (res == System.Windows.Forms.DialogResult.OK) {
                        string sql = "delete from " + models.db.tables.GenkaSyoukyakuMeisai.TABLE_NAME +
                                    " where kotei_shisan_bangou = " + SelectedRowId;
                        Context.KaikeiDatabase.ExecuteNonQuery(sql);
                        meisaiTable.SyncRowList();
                        meisaiGridController.SetQuery("");
                    }
                }
            };

            popup.SetDatabase(Context.KaikeiDatabase);
            popup.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            popup.Location = new System.Drawing.Point(
                Math.Max(parent.Left + (parent.Width - popup.Width) / 2, 0),
                Math.Max(parent.Top + (parent.Height - popup.Height) / 2, 0));

            meisaiTable = new models.db.BufferedTable(Context.KaikeiDatabase.GenkaSyoukyakuMeisai);

            meisaiGridController = new grid.DBPanelGridController<views.grid.SyoukyakuMeisaiRow>(popup.SyoukyakuMeisaiGrid, true);
            meisaiGridController.SetTable(meisaiTable);
            meisaiGridController.InitInsertedRow += delegate(models.db.Row row) {
                if (SelectedRowId != -1) {
                    row.Table.SetColumnValue(row, "kotei_shisan_bangou", SelectedRowId);
                }
            };
            foreach (var row in popup.SyoukyakuMeisaiGrid.AllRowControls()) {
                (row as views.grid.SyoukyakuMeisaiRow).DenpyouHakkouButtonClicked += DenpyouHakkouButtonClicked;
            }

            SelectRow(RowId2RowNo(rowId));

            focusController = new misc.FocusController(popup);
            popup.ShowDialog();
        }


        private int RowId2RowNo(int rowId) {
            int rowNo = 0;
            foreach (var row in Context.KaikeiDatabase.MTKoteiShisan.Select("")) {
                if (row.GetLong("id", 0) == rowId) {
                    return rowNo;
                }
                rowNo++;
            }

            return RowCount;
        }


        private int RowCount {
            get{return Context.KaikeiDatabase.MTKoteiShisan.RowCount("");}
        }

        private int SelectedRowId {
            get { return (int)selectedRow.GetLong("id", -1); }
        }


        private void SelectRow(int rowNo) {
            selectedRowNo = rowNo;

            var rows = Context.KaikeiDatabase.MTKoteiShisan.Select("", rowNo, 1);
            if (rows.Count() > 0) {
                selectedRow = rows.First();
            }
            else {
                selectedRow = Context.KaikeiDatabase.MTKoteiShisan.NewRow();
            }

            popup.SetRowData(selectedRow);
            meisaiTable.SqlCondition = "where kotei_shisan_bangou = " + SelectedRowId + " order by kaisuu";
            meisaiTable.SyncRowList();
            meisaiGridController.SetQuery("");
        }


        private void OnChangeZanzonWariai(models.db.Row row) {
            long zanzonKakaku = (long)Math.Ceiling(row.GetLong("syutoku_kakaku", 0) * row.GetDouble("zanzon_wariai", 0) / 100);
            row.Table.SetColumnValue(row, "zanzon_kakaku", zanzonKakaku);
        }

        private void OnChangeGensyoubi(models.db.Row row) {
            OnChangeTaiyouNennsuu(row);
        }

        private void OnChangeSyutokuKagaku(models.db.Row row) {
            long syutokuKagaku = row.GetLong("syutoku_kakaku", 0);
            row.Table.SetColumnValue(row, "syoukyaku_kiso", (long)Math.Ceiling(syutokuKagaku * 0.9));
            OnChangeTaiyouNennsuu(row);
        }

        private void OnChangeSyutokuNenngappi(models.db.Row row) {
            DateTime? date = row.GetDate("syutoku_nenngappi");
            DateTime gensyoubi;
            if (date == null) {
                gensyoubi = DateTime.Now;
            }
            else if (date.Value.Month > 3) {
                gensyoubi = new DateTime(date.Value.Year + 1, 3, 31);
            }
            else {
                gensyoubi = new DateTime(date.Value.Year, 3, 31);
            }
            row.Table.SetColumnValue(row, "gensyoubi", gensyoubi);

            OnChangeTaiyouNennsuu(row);
        }


        private void OnChangeSyoukyakuHouhou(models.db.Row row) {
            OnChangeTaiyouNennsuu(row);
        }


        private void OnChangeTaiyouNennsuu(models.db.Row row) {
            int syoukyakuHouhou = (int)row.GetLong("syoukyaku_houhou", 0);
            int taiyouNennsuu = (int)row.GetLong("taiyou_nennsuu", 0);
            double syoukyakuritsu = models.KoteiShisanFunc.Syoukyakuritu(syoukyakuHouhou, taiyouNennsuu);
            row.Table.SetColumnValue(row, "syoukyaku_ritsu", syoukyakuritsu);
        }


        private void ColumnValueChanged(object sender, string columnName, object value) {
            if (selectedRow.Table.SetColumnValue(selectedRow, columnName, value)) {
                switch(columnName){
                    case "gensyoubi": OnChangeGensyoubi(selectedRow); break;
                    case "zanzon_wariai": OnChangeZanzonWariai(selectedRow); break;
                    case "syutoku_nenngappi": OnChangeSyutokuNenngappi(selectedRow); break;
                    case "syutoku_kakaku": OnChangeSyutokuKagaku(selectedRow); break;
                    case "syoukyaku_houhou": OnChangeSyoukyakuHouhou(selectedRow); break;
                    case "taiyou_nennsuu": OnChangeTaiyouNennsuu(selectedRow); break;
                }

                if ((int)selectedRow.GetLong("id", -1) == -1) {
                    selectedRow.Table.Insert(selectedRow);
                    selectedRow = selectedRow.Table.LastInsertedRow();
                }
                else {
                    selectedRow.Table.Update(selectedRow);
                    (selectedRow.Table as models.db.AbstractMasterTable).UpdateCache();
                }
            }
            else {
                //ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgInvalidInput.Replace("%s", value.ToString()), "err", columnName);
            }
            popup.SetRowData(selectedRow);    // 表示の更新
        }


        private void DenpyouHakkouButtonClicked(object sender){
            models.db.Row syoukyakuRow = (sender as views.grid.AbstractDBGridRow).RowData;
            if (syoukyakuRow == null) {
                return;
            }
            if(SelectedRowId == -1){
                return;
            }
            syoukyakuRow.Table.SetColumnValue(syoukyakuRow, "denpyou_hakkou", true);
            (sender as views.grid.AbstractDBGridRow).SetRowData(syoukyakuRow, true);

            models.db.Row newRow = Context.KaikeiDatabase.KaikeiDenpyouMeisai.NewRow();
            //newRow.Table.SetColumnValue(newRow, "kaikei_tanni", (int)models.constants.MTKaikeiTanni.Hukushi);
            newRow.Table.SetColumnValue(newRow, "kaikei_kubun", selectedRow.GetLong("kaikei_kubun", -1));
            newRow.Table.SetColumnValue(newRow, "torihiki_kubun", (int)models.constants.MTTorihikiKubun.Jigyou);
            if (syoukyakuRow.GetDate("gensyoubi") != null) {
                DateTime? date = syoukyakuRow.GetDate("gensyoubi");
                Context.KaikeiDatabase.KaikeiDenpyouMeisai.SetKihyoubiAndDenpyouBangouCache(newRow, date.Value);
            }

            models.db.Row karikataKamokuRow = Context.KaikeiDatabase.MTKanjouKamoku.GetRowById((int)models.constants.MTKanjouKamoku.GenkaSyoukyakuhi);
            if (karikataKamokuRow != null) {
                newRow.Table.SetColumnValue(newRow, "karikata_kamoku_code", karikataKamokuRow.GetStr("kamoku_code"));
            }

            models.db.Row kashikataKamokuKubunRow = Context.KaikeiDatabase.MTKamokuKubun.GetRowById((int)selectedRow.GetLong("kamoku_kubun_id", -1));
            models.db.Row kashikataKamokuRow = Context.KaikeiDatabase.MTKanjouKamoku.GetRowById((int)kashikataKamokuKubunRow.GetLong("kanjou_kamoku_id", -1));
            if (kashikataKamokuRow != null) {
                newRow.Table.SetColumnValue(newRow, "kashikata_kamoku_code", kashikataKamokuRow.GetStr("kamoku_code"));
            }

            newRow.Table.SetColumnValue(newRow, "karikata_kingaku", syoukyakuRow.GetLong("touki_genka_syoukyaku_kagaku", 0));
            newRow.Table.SetColumnValue(newRow, "comment", selectedRow.GetStr("shisan_meisyou"));

            newRow.Table.Insert(newRow);
            models.db.Row insertedRow = newRow.Table.LastInsertedRow();

            helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgConfirmSyoukyakuMeisaiDenpyouHakkou);
            var denpyouPopupController = new popup.DenpyouInfoPopupController();
            denpyouPopupController.ShowPopupModal(popup, insertedRow, Context);
        }
    }
}
