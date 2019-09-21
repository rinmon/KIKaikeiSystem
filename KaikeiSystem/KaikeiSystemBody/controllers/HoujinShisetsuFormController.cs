using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class HoujinShisetsuFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.HoujinShisetsuForm form;
        private models.db.Row houjinDantaiRowData;
        private models.db.BufferedTable bufferedKaikeiKubunTable;
        private grid.DBPanelGridController<views.grid.HoujinShisetsuRow> gridController;
        private misc.DelayTimerController delayTimerController;

        public HoujinShisetsuFormController() {
            form = new KaikeiSystemBody.views.HoujinShisetsuForm();
            gridController = new grid.DBPanelGridController<views.grid.HoujinShisetsuRow>(form.HoujinShisetsuGrid, true);

            form.HoujinDantaiRow.Column_UpdateValueAction += delegate(views.grid.AbstractPanelGridRow rowControl, string column, object value) { 
                var row = (rowControl as views.grid.AbstractDBGridRow).RowData;
                var table = row.Table;
                var db = Context.KaikeiDatabase;

                if (table.SetColumnValue(row, column, value)) {
                    table.Update(row);
                }
                else {
                    // ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgInvalidInput.Replace("%s", value.ToString()), "err", column);
                }
                (rowControl as views.grid.AbstractDBGridRow).SetRowData(row, true);    // 表示の更新
            };
            gridController.InitInsertedRow += delegate(models.db.Row row) {
                row.Table.SetColumnValue(row, "parent_id", 1);
                row.Table.SetColumnValue(row, "kubun_code", row.Table.GetMax("kubun_code") + 1);
            };
            gridController.RowUpdated += delegate(views.grid.HoujinShisetsuRow row) {
                Context.KaikeiDatabase.MTKaikeiKubun.UpdateCache();
                gridController.ResetMasterTableInfo();

                delayTimerController.SetDelayedProc(delegate() {
                    CheckParentKubunYosan(row.RowData);
                });
            };

            form.CloseButtonClicked += () => MainController.PopActivity();

            delayTimerController = new misc.DelayTimerController(form);
        }


        public override Form Form {
            get {
                return form;
            }
        }


        private void SetHoujinShisetsuRowData() {
            var rows = Context.KaikeiDatabase.MTKaikeiKubun.Select("where parent_id = -1", 0, 1);
            if (rows.Count() > 0) {
                houjinDantaiRowData = rows.First();
            }
            else {
                houjinDantaiRowData = Context.KaikeiDatabase.MTKaikeiKubun.NewRow();
                Context.KaikeiDatabase.MTKaikeiKubun.SetColumnValue(houjinDantaiRowData, "parent_id", -1);
            }

            form.HoujinDantaiRow.SetRowData(houjinDantaiRowData, false);
        }

        // events

        override protected void OnActivated(object option) {
            bufferedKaikeiKubunTable = new models.db.BufferedTable(Context.KaikeiDatabase.MTKaikeiKubun);
            bufferedKaikeiKubunTable.SqlCondition = "where parent_id <> -1 order by kubun_code";
            bufferedKaikeiKubunTable.SyncRowList();

            gridController.SetTable(bufferedKaikeiKubunTable);
            gridController.SetQuery("");

            SetHoujinShisetsuRowData();
        }


        override protected void OnDeactivated() {
            Context.KaikeiDatabase.MTKaikeiKubun.UpdateCache();
        }


        private void CheckParentKubunYosan(models.db.Row row) {
            int nenndo = Context.Setting.GetDateTime("nenndo_kisanbi").Value.Year;
            int parentKaikeiKubun = (int)row.GetLong("parent_id", -1);
            int kaikeiKubun = (int)row.GetId();
            string sql = "where kaikei_kubun = " + parentKaikeiKubun + " and nenndo = " + nenndo;
            int yosanCt = Context.KaikeiDatabase.YosanKamokuKubun.RowCount(sql);
            if (yosanCt == 0) {
                return;
            }

            helper.MsgBox.Warn(KaikeiSystemBody.Properties.Resources.MsgCheckParentKubunYosan);

            Context.KaikeiDatabase.BeginTransaction();
            foreach (var yosanRow in Context.KaikeiDatabase.YosanKamokuKubun.Select(sql)) {
                yosanRow.Set("kaikei_kubun", kaikeiKubun);
                Context.KaikeiDatabase.YosanKamokuKubun.Update(yosanRow);
            }
            Context.KaikeiDatabase.CommitTransaction();
        }
    }
}
