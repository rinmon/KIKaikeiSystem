using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class KoteiShisanFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.KoteiShisanForm form;
        private popup.KoteiShisanDetailPopupController popupController;
        private misc.FocusController focusController;
        private grid.DBPanelGridController<views.grid.KoteiShisanRow> gridController;
        private models.db.BufferedTable table;

        public KoteiShisanFormController() {
            form = new KaikeiSystemBody.views.KoteiShisanForm();
            focusController = new misc.FocusController(form);
            gridController = new grid.DBPanelGridController<views.grid.KoteiShisanRow>(form.Grid, false);
            popupController = new popup.KoteiShisanDetailPopupController();

            form.ShowAllButtonClicked += ShowAllRows;
            form.SelectButtonClicked += () => ShowSelectedKaikeiKubunRows(form.KaikeiKubun);
            form.DetailButtonClicked += DetailButtonClicked;
            form.NewButtonClicked += () => ShowDetailPopup(-1);
            form.MenuButtonClicked += () => MainController.PopActivity();

            foreach (var row in form.Grid.AllRowControls()) {
                (row as views.grid.KoteiShisanRow).DetailButtonClicked += DetailButtonClicked;
            }

        }


        public override Form Form {
            get {
                return form;
            }
        }


        override protected void OnActivated(object option) {
            table = new models.db.BufferedTable(Context.KaikeiDatabase.MTKoteiShisan);
            gridController.SetTable(table);
            ShowAllRows();
            form.SetDatabase(Context.KaikeiDatabase);
            popupController.Context = Context;
        }

        override protected void OnDeactivated() {
        }



        private void ShowAllRows() {
            table.SqlCondition = "";
            table.SyncRowList();
            gridController.SetQuery("");
        }


        private void ShowSelectedKaikeiKubunRows(int kaikeiKubun) {
            table.SqlCondition = "where kaikei_kubun = " + kaikeiKubun;
            table.SyncRowList();
            gridController.SetQuery("");
        }


        private int SelectedRowId() {
            if (form.Grid.SelectedRowControl != null && form.Grid.SelectedRowControl.RowData != null) {
                return (int)form.Grid.SelectedRowControl.RowData.GetLong("id", 0);
            }

            return -1;
        }


        private void ShowDetailPopup(int rowId) {
            popupController.ShowPopupModal(form, rowId);
            ShowAllRows();
        }


        private void DetailButtonClicked() {
            ShowDetailPopup(SelectedRowId());
        }
    }
}
