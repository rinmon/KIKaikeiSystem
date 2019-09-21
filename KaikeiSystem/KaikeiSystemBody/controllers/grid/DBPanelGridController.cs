using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaikeiSystemBody.views.grid;

namespace KaikeiSystemBody.controllers.grid
{
    class DBPanelGridController<Type> where Type: views.grid.AbstractDBGridRow, new()
    {
        private models.db.AbstractTable table_;
        private models.db.Row new_row_;
        private string sql_;

        private PanelGrid<Type> grid_;

        private misc.DelayTimerController delayTimerController;

        // actins

        // 行を追加する前に、挿入をキャンセルするかを判定(falseでキャンセル)
        public delegate bool IsValidNewRowDelegate(models.db.Row newRow);

        // 新規行を追加したときに、行の初期化を行う 
        public delegate void InitInsertedRowDelegate(models.db.Row newRow);

        ///   カラムの値が変化し、カラムからフォーカスが移動するときに、カラムの値が有効かチェックする。
        public delegate void ValidateColumnValueDelegate(Type row, string column, object value);

        ///  行が選択解除されたときに、行の内容が変化していた場合、内容が有効かチェックする。
        ///  falseを返した場合、行の内容を編集前に戻す。
        public delegate bool ValidateRowValueDelegate(Type row);

        // 行を削除するときに、削除してよいか確認
        public delegate bool ValidateRemoveRowDelegate(Type row);

        // 行の内容が変更された後に呼ばれる
        public delegate void RowUpdatedDelegate(Type row);

        // DBから行が削除された後に呼ばれる
        public delegate void RowDeletedDelegate(models.db.Row row);

        ///   行が選択されたときに呼ばれる
        public delegate void Row_GotFocusDelegate(Type row);

        // カラムからフォーカスが移動したときに呼ばれる
        public delegate void Column_LostFocusDelegate(Type row, string column);

        public event IsValidNewRowDelegate IsValidNewRow = null;
        public event InitInsertedRowDelegate InitInsertedRow = null;
        public event ValidateColumnValueDelegate ValidateColumnValue = null;
        public event ValidateRowValueDelegate ValidateRowValue = null;
        public event RowUpdatedDelegate RowUpdated = null;
        public event RowDeletedDelegate RowDeleted = null;
        public event ValidateRemoveRowDelegate ValidateRemoveRow = null;
        public event Row_GotFocusDelegate Row_GotFocusAction = null;
        public event Column_LostFocusDelegate Column_LostFocusAction = null;

        public event Action<Type> RowClicked;
        public event Action<string> SetStatusMessage;


        public models.db.AbstractTable DBTable {
            get { return table_; }
        }


        public bool ShowInvalidColumnValueMessage { get; set; }



        public DBPanelGridController(PanelGrid<Type> grid, bool newRowIsVisible) {
            table_ = null;
            new_row_ = null;
            sql_ = "";
            ShowInvalidColumnValueMessage = true;

            grid_ = grid;
            grid_.UpdateRowsAction += (begin, end) => RefreshRows(begin, end, false);

            grid_.NewRowIsVisible = newRowIsVisible;

            foreach (var row in grid_.AllRowControls()) {
                row.Column_BeforeChangeValueAction += Column_BeforeChangeValue;
                row.Column_UpdateValueAction += Column_UpdateValue;
                row.Column_LostFocusAction += Column_LostFocus;
                row.RemoveAction += Row_Remove;

                row.Leave += Row_LostFocus;
                row.Enter += Row_GotFocus;
                row.SetStatusMessageAction += delegate(string msg) {
                    if (SetStatusMessage != null) {
                        SetStatusMessage(msg);
                    }
                };
                row.RowClicked += delegate(AbstractPanelGridRow sender) {
                    if (RowClicked != null) {
                        RowClicked(sender as Type);
                    }
                };
            }

            delayTimerController = new misc.DelayTimerController();
        }

        
        public void SetTable(models.db.AbstractTable table) {
            table_ = table;
            new_row_ = table_.NewRow();
            SetMasterTableForRows(table.OwnerDB);
        }


        public void ResetMasterTableInfo() {
            SetMasterTableForRows(table_.OwnerDB);
        }

        private void SetMasterTableForRows(models.db.AbstractDatabase db) {
            views.grid.AbstractDBGridRow firstRow = null;

            foreach (var row in grid_.AllRowControls()) {
                if (firstRow == null) {
                    row.SetMasterTables(db);
                    firstRow = row;
                }
                else {
                    row.CopyMasterTableContoller(firstRow);
                }
            }
        }


        public void FlushEditingData() {
            if (grid_.SelectedRowControl != null) {
                if (grid_.SelectedRowControl.RowEditing) {
                    grid_.TopDummyRowControl.Focus();
                }
            }
        }


        public void UpdateDataCount() {
            grid_.DataCount = table_.RowCount(sql_);
        }


        public void SetFocus(int rowNo, string columnName) {
            grid_.SetFocus(rowNo, columnName);
        }

        public void SetQuery(string sql, bool dontMoveFocus = false) {
            sql_ = sql;

            FlushEditingData();

            grid_.SuspendDrawRows();
            UpdateDataCount();
            if (!dontMoveFocus) {
                grid_.SelectTopRow();
            }
            grid_.ResumeDrawRows();

            Refresh();
        }

        public void InsertNewRowToLast(bool not_update_focused_control, string column = null, object value = null) {
            models.db.Row row = table_.NewRow();
            if (InitInsertedRow != null) {
                InitInsertedRow(row);
            }
            if (IsValidNewRow != null) {
                if (IsValidNewRow(row) == false) {
                    return;
                }
            }
            table_.Insert(row);

            models.db.Row insertedRow = table_.LastInsertedRow();

            if (column != null) {
                insertedRow.Set(column, value);
            }

            if (grid_.SelectedRowNo == grid_.RowCount - 1 && grid_.NewRowIsVisible) {
                grid_.SelectedRowControl.SetRowData(insertedRow, true);
                grid_.SelectedRowControl.IsNewRow = false;
            }
            grid_.DataCount = grid_.DataCount + 1;
        }


        public void Refresh(bool dontMoveFocus = false) {
            FlushEditingData();
            if (!dontMoveFocus) {
                RefreshRows(grid_.VisibleRowTop, grid_.VisibleRowBottom, true);
            }
        }


        // 列情報の設定
        private void SetRowData(int rowCt, models.db.Row rowData, bool refreshSelectedRow) {
            if (!(0 <= rowCt && rowCt <= grid_.VisibleRowCount + 1)) {
                return;
            }

            // 選択されている行が新しいrowDataと同じなら更新しない。
            if (refreshSelectedRow == false && 
                rowData != null && 
                grid_.SelectedRowControl != null &&
                grid_.SelectedRowControl.RowData != null &&
                rowCt + grid_.VisibleRowTop == grid_.SelectedRowNo &&
                grid_.SelectedRowControl.RowData.GetLong("id", -1) == rowData.GetLong("id", -2)) {
                    return;
            }

            AbstractDBGridRow row = grid_.RowControl(rowCt) as AbstractDBGridRow;
            if (rowData != null) {
                row.SetRowData(rowData, false);
                if (row.Visible == false) {
                    row.Show();
                }
            }
            else {
                row.Hide();
            }

            row.IsNewRow = (rowData == new_row_);
        }


        private void RefreshRows(int begin, int end, bool refreshSelectedRow) {
            int offset = begin - grid_.VisibleRowTop;
            int row_ct = end - begin + 1;

            //System.Diagnostics.Debug.WriteLine("Refresh : b=" + begin + " e=" + end + "  refresh=" + refreshSelectedRow);

            if (row_ct <= 0 || table_ == null) {
                return;
            }

            grid_.SuspendDrawRows();

            int i = 0;
            foreach (var row in table_.Select(sql_, begin, row_ct)) {
                SetRowData(offset + i, row, refreshSelectedRow);
                i++;
            }

            if (i < row_ct && begin + i == grid_.RowCount - 1 && grid_.NewRowIsVisible) {
                SetRowData(offset + i, new_row_, refreshSelectedRow);
                i++;
            }

            for (; i < row_ct; i++) {
                SetRowData(offset + i, null, refreshSelectedRow);
            }

            grid_.ResumeDrawRows();
        }


        // メッセージを表示してフォーカスを移動する（Leaveイベント中にMessageBoxを表示できなかったので、Timerで遅延させて実行）
        public void ShowMsgAndChangeFocus(string msg, string msg_type, string next_focus) {
            int row_no = grid_.SelectedRowNo;
            delayTimerController.SetDelayedProc(delegate() {
                if (next_focus != null) {
                    grid_.SetFocus(row_no, next_focus);
                }
                helper.MsgBox.ShowMsg(msg, msg_type);
            });
        }

        
        // events

        private void Column_BeforeChangeValue(AbstractPanelGridRow sender, string column, object value) {
            Type row = sender as Type;

            if (row.RowData == this.new_row_) {
                InsertNewRowToLast(true, column, value);
            }
        }


        private void Column_UpdateValue(AbstractPanelGridRow sender, string column, object value) {
            Type row = sender as Type;
            models.db.Row rowData = (sender as AbstractDBGridRow).RowData;

            if (table_.SetColumnValue(rowData, column, value)) {
                if (ValidateColumnValue != null) {
                    ValidateColumnValue(row, column, value);
                }
            }
            else {
                if (ShowInvalidColumnValueMessage == true) {
                    ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgInvalidInput.Replace("%s", value.ToString()), "err", column);
                }
            }
            row.SetRowData(rowData, true);    // 表示の更新
        }


        private void Column_LostFocus(AbstractPanelGridRow sender, string column) {
            if (Column_LostFocusAction != null) {
                Column_LostFocusAction(sender as Type, column);
            }
        }


        private void Row_LostFocus(object sender, EventArgs e) {
            Type rowControl = sender as Type;
            models.db.Row row = rowControl.RowData;

            if (rowControl.RowEditing) {
                if (ValidateRowValue != null && ValidateRowValue(rowControl) == false) {
                    row = table_.Revert(row);
                }
                else {
                    table_.Update(row);
                }
                rowControl.SetRowData(row, false);        // rowの再描画

                if (RowUpdated != null) {
                    RowUpdated(rowControl);
                }
            }
        }

        private void Row_GotFocus(object sender, EventArgs e) {
            if (Row_GotFocusAction != null) {
                Type row = sender as Type;
                if (row.RowData != null) {
                    Row_GotFocusAction(row);
                }
            }
        }

        private void Row_Remove(AbstractPanelGridRow sender) {
            int row_no = sender.RowNo + grid_.VisibleRowTop;
            if (0 <= row_no && row_no < grid_.DataCount) {
                bool removeOk = false;

                if (ValidateRemoveRow != null) {
                    removeOk = ValidateRemoveRow(sender as Type);
                }
                else {
                    var res = System.Windows.Forms.MessageBox.Show(KaikeiSystemBody.Properties.Resources.MsgConfirmToDeleteRow,
                                KaikeiSystemBody.Properties.Resources.CaptionConfirm,
                                System.Windows.Forms.MessageBoxButtons.OKCancel,
                                System.Windows.Forms.MessageBoxIcon.Warning);
                    removeOk = (res == System.Windows.Forms.DialogResult.OK);
                }
                if (removeOk) {
                    models.db.Row row = (sender as Type).RowData;
                    if (table_.Delete(row)) {
                        if (RowDeleted != null) {
                            RowDeleted(row);
                        }
                    }
                    else {
                        helper.MsgBox.ShowMsg("DB error", "err");
                    }
                }

                UpdateDataCount();
            }
        }
    }
}
