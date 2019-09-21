using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.controllers.popup
{
    class YosanHojoKamokuPopupController
    {
        private grid.DBPanelGridController<views.grid.YosanHojoKamokuRow> gridController;
        private views.popup.YosanHojoKamokuPopup popup;
        private models.db.vtables.UsableYosanHojoKamoku yosanHojoKamokuTable;

        public event Action RowSelectionChanged;

        int year;
        int keiriKubun;
        int hoseiKaisuu;
        int yosanKubun;
        int kamokuId;

        public models.Context Context {
            get;
            set;
        }


        public long SumYosan {
            get;
            private set;
        }


        public int SelectedHojoKamokuId {
            get {
                if (popup == null || popup.Grid.SelectedRowControl.RowData == null) {
                    return 0;
                }
                else {
                    return (int)popup.Grid.SelectedRowControl.RowData.GetLong("hojo_id", -1);
                }
            }
        }


        public YosanHojoKamokuPopupController() {
            popup = null;
        }


        public void ShowPopup(System.Windows.Forms.Form owner, System.Drawing.Point location) {
            if (popup != null) {
                popup.Close();
                popup = null;
            }

            popup = new views.popup.YosanHojoKamokuPopup();
            popup.PopupClosed += delegate() {
                popup = null;
                gridController = null;
                yosanHojoKamokuTable = null;
            };

            yosanHojoKamokuTable = new models.db.vtables.UsableYosanHojoKamoku(Context.KaikeiDatabase);

            gridController = new grid.DBPanelGridController<views.grid.YosanHojoKamokuRow>(popup.Grid, true);
            gridController.SetTable(yosanHojoKamokuTable);
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


        public void SetQueryCondition(int year_, int keiriKubun_, int yosanKubun_, int hoseiKaisuu_, int kamokuId_) {
            if (popup == null) {
                return;
            }

            year = year_;
            keiriKubun = keiriKubun_;
            hoseiKaisuu = hoseiKaisuu_;
            yosanKubun = yosanKubun_;
            kamokuId = kamokuId_;

            yosanHojoKamokuTable.Year = year;
            yosanHojoKamokuTable.KeiriKubun = keiriKubun;
            yosanHojoKamokuTable.HoseiKaisuu = hoseiKaisuu;
            yosanHojoKamokuTable.YosanKubun = yosanKubun;
            yosanHojoKamokuTable.KamokuId = kamokuId;
            yosanHojoKamokuTable.SyncRowList();

            foreach (var row in popup.Grid.AllRowControls()) {
                (row as views.grid.YosanHojoKamokuRow).ParentKamokuId = kamokuId;
            }
            gridController.ResetMasterTableInfo();
            gridController.SetQuery("");

            SetSumAmount();

            RowSelectionChanged();
        }


        private void SetSumAmount() {
            this.SumYosan = yosanHojoKamokuTable.SelectSum("yosan", "");
            popup.SumAmount = this.SumYosan;
        }


        private void Grid_InitInsertedRow(models.db.Row row) {
            row.Table.SetColumnValue(row, "nenndo", year);
            row.Table.SetColumnValue(row, "keiri_kubun", keiriKubun);
            row.Table.SetColumnValue(row, "yosan_kubun", yosanKubun);
            row.Table.SetColumnValue(row, "hosei_kaisuu", hoseiKaisuu);
        }
    }
}
