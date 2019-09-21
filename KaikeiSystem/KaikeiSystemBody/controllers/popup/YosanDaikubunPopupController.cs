using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.controllers.popup
{
    class YosanDaikubunPopupController
    {
        private grid.DBPanelGridController<views.grid.YosanDaikubunRow> gridController;
        private views.popup.YosanDaikubunPopup popup;

        private models.db.vtables.UsableYosanDaikubun yosanDaikubunTable;

        public event Action RowSelectionChanged;

        int year;
        int kaikeiKubun;
        int hoseiKaisuu;
        int yosanKubun;

        public models.Context Context {
            get;
            set;
        }
        
        
        public YosanDaikubunPopupController() {
            popup = null;
        }


        public int SelectedKamokuKubunId {
            get {
                if (popup == null || popup.Grid.SelectedRowControl.RowData == null) {
                    return 0;
                }
                else {
                    return (int)popup.Grid.SelectedRowControl.RowData.GetLong("kamoku_kubun_id", -1);
                }
            }
        }

        public models.db.Row SelectedRow {
            get {
                if (popup == null) {
                    return null;
                }
                else {
                    return popup.Grid.SelectedRowControl.RowData;
                }
            }
        }


        public void ShowPopup(System.Windows.Forms.Form owner, System.Drawing.Point location) {
            if (popup != null) {
                popup.Close();
                popup = null;
            }

            popup = new views.popup.YosanDaikubunPopup();
            /*popup.PopupClosed += delegate() {
                popup = null;
                gridController = null;
                yosanDaikubunTable = null;
            };*/

            yosanDaikubunTable = new models.db.vtables.UsableYosanDaikubun(Context.KaikeiDatabase);

            gridController = new grid.DBPanelGridController<views.grid.YosanDaikubunRow>(popup.Grid, false);
            gridController.SetTable(yosanDaikubunTable);
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



        public void SetQueryCondition(int year_, int kaikeiKubun_, int yosanKubun_, int hoseiKaisuu_) {
            year = year_;
            kaikeiKubun = kaikeiKubun_;
            hoseiKaisuu = hoseiKaisuu_;
            yosanKubun = yosanKubun_;

            yosanDaikubunTable.Year = year;
            yosanDaikubunTable.KaikeiKubun = kaikeiKubun;
            yosanDaikubunTable.YosanKubun = yosanKubun;
            yosanDaikubunTable.HoseiKaisuu = hoseiKaisuu;
            yosanDaikubunTable.SyncRowList();
            gridController.SetQuery("");

            RowSelectionChanged();
        }
    }
}
