using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.controllers.popup
{
    class YosanKamokuKubunPopupController<RowType> where RowType : views.grid.AbstractDBGridRow, new()
    {
        public event Action SumAmountIsChanged;

        private grid.DBPanelGridController<RowType> gridController;
        private models.db.vtables.BufferedYosanKamokuKubun bufferedTable;
        private views.grid.PanelGrid<RowType> grid;
        private System.Windows.Forms.Form popup;
        private misc.StickyWindowController stickyWindowController;

        public event Action RowSelectionChanged;

        public models.Context Context {
            get;
            set;
        }


        public int SelectedKamokuKubunId {
            get {
                if (popup == null || grid.RowCount == 0 || grid.SelectedRowControl.RowData == null) {
                    return 0;
                }
                else {
                    return (int)grid.SelectedRowControl.RowData.GetLong("kamoku_kubun_id", -1);
                }
            }
        }


        public int SelectedYosanId {
            get {
                if (popup == null || grid.RowCount == 0 || grid.SelectedRowControl.RowData == null) {
                    return 0;
                }
                else {
                    return (int)grid.SelectedRowControl.RowData.GetLong("id", -1);
                }
            }
        }


        public long SelectedYosan {
            get {
                if (popup == null || grid.RowCount == 0 || grid.SelectedRowControl.RowData == null) {
                    return 0;
                }
                else {
                    return (int)grid.SelectedRowControl.RowData.GetLong("yosan", -1);
                }
            }
        }

        public models.db.Row SelectedRow {
            get {
                if (popup == null || grid.RowCount == 0 || grid.SelectedRowControl.RowData == null) {
                    return null;
                }
                else {
                    return grid.SelectedRowControl.RowData;
                }
            }
        }


        public long SumYosan {
            get {
                if (bufferedTable != null) {
                    return bufferedTable.SumYosan();
                }
                return 0;
            }
        }


        public int DataCount {
            get {
                if (popup == null || grid.RowCount == 0 || grid.SelectedRowControl.RowData == null) {
                    return 0;
                }
                else {
                    return grid.DataCount;
                }
            }
        }


        public YosanKamokuKubunPopupController() {
            SumAmountIsChanged += delegate() { };
            popup = null;
        }


        public void ShowPopup(System.Windows.Forms.Form owner, System.Drawing.Rectangle pos, string caption, bool daikubun, bool showUsableOnly, bool embedded) {
            if (popup != null) {
                popup.Close();
                popup = null;
            }

            if (daikubun) {
                popup = new views.popup.YosanKamokuDaikubunPopup();
            }
            else {
                popup = new views.popup.YosanKamokuKubunPopup();
            }

            popup.FormClosed += delegate(object sender, System.Windows.Forms.FormClosedEventArgs e) {
                popup = null;
                gridController = null;
            };

            if (popup is views.popup.YosanKamokuDaikubunPopup) {
                grid = (popup as views.popup.YosanKamokuDaikubunPopup).Grid as views.grid.PanelGrid<RowType>;
            }
            else if (popup is views.popup.YosanKamokuKubunPopup) {
                grid = (popup as views.popup.YosanKamokuKubunPopup).Grid as views.grid.PanelGrid<RowType>;
            }

            bufferedTable = new models.db.vtables.BufferedYosanKamokuKubun(Context.KaikeiDatabase);
            bufferedTable.UsableOnly = showUsableOnly;

            gridController = new grid.DBPanelGridController<RowType>(grid, false);
            gridController.SetTable(bufferedTable);
            gridController.RowUpdated += (row) => ChangeSumAmount();
            gridController.Row_GotFocusAction += (row) => RowSelectionChanged();

            //popup.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //popup.Parent = owner;
            popup.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            popup.Location = pos.Location;
            popup.Size = pos.Size;
            popup.Text = caption;

            popup.Show(owner);

            stickyWindowController = new misc.StickyWindowController(owner, popup);
        }


        public void ClosePopup() {
            if (popup != null) {
                popup.Close();
                popup = null;
            }
        }

        public void SetYosanToSelectedKamoku(long yosan) {
            if (popup == null) {
                return;
            }
            if (grid.SelectedRowControl == null) {
                return;
            }
            grid.SelectedRowControl.SetFocusToControlByTag("yosan");
            grid.SelectedRowControl.SetControlValue("yosan", helper.Converter.LongToAmount(yosan));
        }


        public void ChangeSumAmount() {
            if (popup is views.popup.YosanKamokuKubunPopup) {
                (popup as views.popup.YosanKamokuKubunPopup).SumAmount = SumYosan;
            }

            SumAmountIsChanged();
        }


        public void SetQueryCondition(int parentYosanId) {
            bufferedTable.ParentId = parentYosanId;
            //bufferedTable.UsableOnly = true;
            bufferedTable.SyncRowList();
            gridController.SetQuery("");
            ChangeSumAmount();
            RowSelectionChanged();
        }


        public void UpdateGrid() {
            gridController.Refresh();
        }
    }
}
