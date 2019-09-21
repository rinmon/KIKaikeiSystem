using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class TorihikiKubunFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.TorihikiKubunForm form;
        private grid.DBPanelGridController<views.grid.TorihikiKubunRow> gridController;
        private models.db.BufferedTable torihikiKubunTable;

        public TorihikiKubunFormController() {
            form = new KaikeiSystemBody.views.TorihikiKubunForm();
            gridController = new grid.DBPanelGridController<views.grid.TorihikiKubunRow>(form.Grid, true);

            form.MenuButtonClicked += () => MainController.PopActivity();
        }


        public override Form Form {
            get {
                return form;
            }
        }

        // events

        override protected void OnActivated(object option) {
            torihikiKubunTable = new models.db.BufferedTable(Context.KaikeiDatabase.MTTorihikiKubun);
            torihikiKubunTable.SqlCondition = "order by id";
            torihikiKubunTable.SyncRowList();
            gridController.SetTable(torihikiKubunTable);
            gridController.SetQuery("");
        }


        override protected void OnDeactivated() {
            Context.KaikeiDatabase.MTTorihikiKubun.UpdateCache();
        }
    }
}
