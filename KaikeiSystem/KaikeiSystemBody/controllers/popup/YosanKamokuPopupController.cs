using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.controllers.popup
{
    class YosanKamokuPopupController
    {
        private grid.DBPanelGridController<views.grid.YosanKamokuRow> gridController;
        private views.popup.YosanKamokuPopup popup;
        private models.db.vtables.UsableYosanKamoku yosanKamokuTable;

        public event Action RowSelectionChanged;

        int year;
        int keiriKubun;
        int hoseiKaisuu;
        int yosanKubun;
        int daikubunId;

        public models.Context Context {
            get;
            set;
        }


        public int SelectedKamokuId {
            get {
                if (popup == null || popup.Grid.SelectedRowControl.RowData == null) {
                    return 0;
                }
                else {
                    return (int)popup.Grid.SelectedRowControl.RowData.GetLong("kamoku_id", -1);
                }
            }
        }

        public long SumYosan {
            get;
            private set;
        }


        public YosanKamokuPopupController() {
            popup = null;
        }


        public void ShowPopup(System.Windows.Forms.Form owner, System.Drawing.Point location) {
            if (popup != null) {
                popup.Close();
                popup = null;
            }

            popup = new views.popup.YosanKamokuPopup();
            popup.PopupClosed += delegate() {
                popup = null;
                gridController = null;
                yosanKamokuTable = null;
            };

            yosanKamokuTable = new models.db.vtables.UsableYosanKamoku(Context.KaikeiDatabase);

            gridController = new grid.DBPanelGridController<views.grid.YosanKamokuRow>(popup.Grid, true);
            gridController.SetTable(yosanKamokuTable);
            gridController.RowUpdated += (row) => SetSumAmount();
            gridController.InitInsertedRow += Grid_InitInsertedRow;
            gridController.RowDeleted += (row) => SetSumAmount();
            gridController.Row_GotFocusAction += (row) => RowSelectionChanged();
            gridController.SetQuery("");

            popup.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            popup.Location = location;

            popup.Show(owner);
        }


        public void ClosePopup() {
            if (popup != null) {
                popup.Close();
                popup = null;
            }
        }


        public void SetQueryCondition(int year_, int keiriKubun_, int yosanKubun_, int hoseiKaisuu_, int daikubunId_) {
            if (popup == null) {
                return;
            }

            year = year_;
            keiriKubun = keiriKubun_;
            hoseiKaisuu = hoseiKaisuu_;
            yosanKubun = yosanKubun_;
            daikubunId = daikubunId_;

            yosanKamokuTable.Year = year;
            yosanKamokuTable.KeiriKubun = keiriKubun;
            yosanKamokuTable.HoseiKaisuu = hoseiKaisuu;
            yosanKamokuTable.YosanKubun = yosanKubun;
            yosanKamokuTable.DaikubunId = daikubunId;
            yosanKamokuTable.SyncRowList();

            foreach (var row in popup.Grid.AllRowControls()) {
                (row as views.grid.YosanKamokuRow).DaikubunId = daikubunId;
            }
            gridController.ResetMasterTableInfo();
            gridController.SetQuery("");

            SetSumAmount();

            RowSelectionChanged();
        }


        public void SetYosanToSelectedKamoku(long yosan) {
            if (popup == null) {
                return;
            }
            if (popup.Grid.SelectedRowControl == null) {
                return;
            }
            popup.Grid.SelectedRowControl.SetFocusToControlByTag("yosan");
            popup.Grid.SelectedRowControl.SetControlValue("yosan", helper.Converter.LongToAmount(yosan));
        }


        private void SetSumAmount() {
            SumYosan = yosanKamokuTable.SelectSum("yosan", "");
            popup.SumAmount = SumYosan;
        }


        private void Grid_InitInsertedRow(models.db.Row row) {
            row.Table.SetColumnValue(row, "nenndo", year);
            row.Table.SetColumnValue(row, "keiri_kubun", keiriKubun);
            row.Table.SetColumnValue(row, "yosan_kubun", yosanKubun);
            row.Table.SetColumnValue(row, "hosei_kaisuu", hoseiKaisuu);
        }
    }
}
