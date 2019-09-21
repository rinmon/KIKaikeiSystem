using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class TekiyouFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.TekiyouForm form;
        private grid.DBPanelGridController<views.grid.TekiyouRow> gridController;
        private models.db.BufferedTable tekiyouTable;

        public TekiyouFormController() {
            form = new KaikeiSystemBody.views.TekiyouForm();
            gridController = new grid.DBPanelGridController<views.grid.TekiyouRow>(form.Grid, true);
            gridController.InitInsertedRow += delegate(models.db.Row row) {
                tekiyouTable.SetColumnValue(row, "tekiyou_code", tekiyouTable.GetMax("tekiyou_code") + 1);
            };
            gridController.ValidateColumnValue += delegate(views.grid.TekiyouRow row_control, string column, object value) {
                var row = row_control.RowData;
                var db = Context.KaikeiDatabase;

                if (column == "tekiyou_mei") {
                    row_control.FireColumnUpdateValueEvent("tekiyou_yomi");
                }
            };
            gridController.ValidateRemoveRow += delegate(views.grid.TekiyouRow rowControl) {
                long ct = Context.KaikeiDatabase.KaikeiDenpyouMeisai.RowCount("where tekiyou_id = " + rowControl.RowData.GetLong("tekiyou_code", -1));

                if (ct > 0) {
                    helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgUsedTekiyouCanntRemove);
                    return false;
                }
                else {
                    var res = System.Windows.Forms.MessageBox.Show(KaikeiSystemBody.Properties.Resources.MsgConfirmToDeleteRow,
                        KaikeiSystemBody.Properties.Resources.CaptionConfirm,
                        System.Windows.Forms.MessageBoxButtons.OKCancel,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                    return res == System.Windows.Forms.DialogResult.OK;
                }
            };

            form.MenuButtonClicked += () => MainController.PopActivity();
            form.NewButtonClicked += () => form.Grid.SelectBottomRow();
        }


        public override Form Form {
            get {
                return form;
            }
        }

        // events

        override protected void OnActivated(object option) {
            tekiyouTable = new models.db.BufferedTable(Context.KaikeiDatabase.MTTekiyou);
            tekiyouTable.SqlCondition = "order by tekiyou_code";
            tekiyouTable.SyncRowList();
            gridController.SetTable(tekiyouTable);
            gridController.SetQuery("");
        }


        override protected void OnDeactivated() {
            Context.KaikeiDatabase.MTTekiyou.UpdateCache();
        }
    }
}
