using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class KaikeiTanniFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.KaikeiTanniForm form;
        private grid.DBPanelGridController<views.grid.KaikeiTanniRow> gridController;
        private models.db.BufferedTable kaikeiTanniTable;

        public KaikeiTanniFormController() {
            form = new KaikeiSystemBody.views.KaikeiTanniForm();
            gridController = new grid.DBPanelGridController<views.grid.KaikeiTanniRow>(form.Grid, true);

            form.MenuButtonClicked += () => MainController.PopActivity();
        }


        public override Form Form {
            get {
                return form;
            }
        }

        // events

        override protected void OnActivated(object option) {
            kaikeiTanniTable = new models.db.BufferedTable(Context.KaikeiDatabase.MTKaikeiTanni);
            kaikeiTanniTable.SqlCondition = "order by id";
            kaikeiTanniTable.SyncRowList();
            gridController.SetTable(kaikeiTanniTable);
            gridController.SetQuery("");
        }


        override protected void OnDeactivated() {
            Context.KaikeiDatabase.MTKaikeiTanni.UpdateCache();
        }
    }
}
