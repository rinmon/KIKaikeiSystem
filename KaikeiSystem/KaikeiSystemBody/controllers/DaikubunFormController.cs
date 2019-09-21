using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class DaikubunFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.DaikubunForm form;
        private grid.DBPanelGridController<views.grid.DaikubunRow> gridController;
        private models.db.BufferedTable daikubunTable;

        public DaikubunFormController() {
            form = new KaikeiSystemBody.views.DaikubunForm();
            gridController = new grid.DBPanelGridController<views.grid.DaikubunRow>(form.Grid, true);
            gridController.InitInsertedRow += delegate(models.db.Row row) {
                row.Table.SetColumnValue(row, "has_child", false);
                row.Table.SetColumnValue(row, "parent_id", -1);
                row.Table.SetColumnValue(row, "hierarchy", (int)models.constants.MTKamokuKubunHierarchy.Daikubun);
                row.Table.SetColumnValue(row, "kanjou_kamoku_id", -1);

                int maxDisplayOrder = row.Table.GetMax("display_order", "where hierarchy=" + (int)models.constants.MTKamokuKubunHierarchy.Daikubun);
                row.Table.SetColumnValue(row, "display_order", maxDisplayOrder + 1);
            };

            form.MenuButtonClicked += () => MainController.PopActivity();
        }


        public override Form Form {
            get {
                return form;
            }
        }

        // events

        override protected void OnActivated(object option) {
            daikubunTable = new models.db.BufferedTable(Context.KaikeiDatabase.MTKamokuKubun);
            daikubunTable.SyncRowListFunc += delegate(List<models.db.Row> rowList) {
                foreach (var kubunRow in Context.KaikeiDatabase.MTKamokuKubun.Select("where hierarchy=" + ((int)models.constants.MTKamokuKubunHierarchy.Kubun) + " order by display_order")) {
                    foreach(var row in Context.KaikeiDatabase.MTKamokuKubun.Select("where parent_id=" + kubunRow.GetLong("id", -1) + " order by display_order")){
                        models.db.Row newRow = daikubunTable.NewRow();
                        row.CopyColumns(newRow);
                        rowList.Add(newRow);
                    }
                }
            };
            daikubunTable.SyncRowList();
            gridController.SetTable(daikubunTable);
            gridController.SetQuery("");
        }


        override protected void OnDeactivated() {
            Context.KaikeiDatabase.MTKamokuKubun.UpdateCache();
        }
    }
}
