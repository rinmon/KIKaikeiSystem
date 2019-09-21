using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class KanjouKamokuFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.KanjouKamokuForm form;
        private grid.DBPanelGridController<views.grid.KanjouKamokuRow> gridController;
        private models.db.vtables.BufferedMTKanjouKamoku bufferedKanjouKamokuTable;

        public KanjouKamokuFormController() {
            form = new KaikeiSystemBody.views.KanjouKamokuForm();

            gridController = new grid.DBPanelGridController<views.grid.KanjouKamokuRow>(form.Grid, false);

            form.MenuButtonClicked += () => MainController.PopActivity();
            form.DetailButtonClicked += delegate(object sender) {
                if (sender != null && (sender as views.grid.AbstractDBGridRow).RowData != null) {
                    var popupController = new controllers.popup.KanjouKamokuDetailPopupController();
                    popupController.Context = this.Context;
                    popupController.ShowPopup(form, form.Grid.SelectedRowControl.RowData, bufferedKanjouKamokuTable);
                    Context.KaikeiDatabase.MTKanjouKamoku.UpdateCache();
                    Context.KaikeiDatabase.MTKamokuKubun.UpdateCache();
                    gridController.Refresh();
                }
            };
            form.AddButtonClicked += delegate() {
                var popupController = new controllers.popup.KanjouKamokuDetailPopupController();
                popupController.Context = this.Context;
                popupController.ShowPopup(form, null, bufferedKanjouKamokuTable);
                Context.KaikeiDatabase.MTKanjouKamoku.UpdateCache();
                Context.KaikeiDatabase.MTKamokuKubun.UpdateCache();
                gridController.Refresh();
            };
        }


        public override Form Form {
            get {
                return form;
            }
        }

        // events

        override protected void OnActivated(object option) {
            bufferedKanjouKamokuTable = new models.db.vtables.BufferedMTKanjouKamoku(Context.KaikeiDatabase);
            bufferedKanjouKamokuTable.Recursive = false;
            bufferedKanjouKamokuTable.RootId = -1;
            bufferedKanjouKamokuTable.SyncRowList();

            gridController.SetTable(bufferedKanjouKamokuTable);
            gridController.SetQuery("");
        }


        override protected void OnDeactivated() {
            Context.KaikeiDatabase.MTKanjouKamoku.UpdateCache();
            Context.KaikeiDatabase.MTKamokuKubun.UpdateCache();
        }
    }
}
