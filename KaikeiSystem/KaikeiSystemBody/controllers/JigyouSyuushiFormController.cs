using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class JigyouSyuushiFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.JigyouSyuushiForm form;
        private models.query.JigyouKatsudou jigyouSyuushi;
        private misc.FocusController focusController;

        public JigyouSyuushiFormController() {
            form = new KaikeiSystemBody.views.JigyouSyuushiForm();
            form.CalcButtonClicked += CalcButtonClicked;
            form.ReturnButtonClicked += () => MainController.PopActivity();
            form.ShowShikinSyuushiButtonClicked += delegate() {
                MainController.SwitchActivity(
                    controllers.MainController.ActivityType.ShikinSyuushi,
                    controllers.MainController.ActivitySwitchMethod.Change,
                    Context
                );
            };

            form.DaikubunGridRowSelected += DaikubunGridRowSelected;

            focusController = new misc.FocusController(form);
        }


        public override Form Form {
            get {
                return form;
            }
        }


        override protected void OnActivated(object option) {
            form.SetGengou(Context.Setting.GetStr("before_gengou", ""));
            form.SetDatabase(Context.KaikeiDatabase);
        }

        override protected void OnDeactivated() {
        }


        private void CalcButtonClicked() {
            if (form.StartDate == null || form.EndDate == null) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidDate);
                return;
            }

            form.ClearDaikubunGrid();
            form.ClearKamokuGrid();

            jigyouSyuushi = new models.query.JigyouKatsudou(Context.KaikeiDatabase);
            jigyouSyuushi.Calc(form.StartDate.Value, form.EndDate.Value, form.KaikeiKubun, hideInnerKaikeiKubunKamoku:true, targetKamokuKubunHierarchy:models.constants.MTKamokuKubunHierarchy.ChuuKubun, omitZeroRow:false);

            foreach (var row in jigyouSyuushi.DaikubunRows) {
                int daikubunId = row.Id;
                models.db.Row daikubunRow = Context.KaikeiDatabase.MTKamokuKubun.GetRowById(daikubunId);
                if (daikubunRow == null) {
                    continue;
                }
                int shikinSyuushiId = (int)daikubunRow.GetLong("parent_id", 0);
                models.db.Row shikinRow = Context.KaikeiDatabase.MTKamokuKubun.GetRowById(shikinSyuushiId);
                if (shikinRow == null) {
                    continue;
                }

                form.AddDaikubunGridRow(
                    daikubunId,
                    shikinRow.GetStr("name"),
                    daikubunRow.GetStr("name"),
                    row.CurrentYearSum,
                    row.LastYearSum,
                    row.Sai
                );
            }

            form.SetSummaryGrid(jigyouSyuushi);
            form.FireDaikubunGridSelectionChanged();

            helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgSucceeded);
        }


        private void DaikubunGridRowSelected(int daikubunId) {
            form.ClearKamokuGrid();

            if (jigyouSyuushi.ChildRowsOf.ContainsKey(daikubunId) == false) {
                return;
            }

            foreach (var row in jigyouSyuushi.ChildRowsOf[daikubunId]) {
                int kamokuId = row.Id;
                models.db.Row kamokuRow = Context.KaikeiDatabase.MTKamokuKubun.GetRowById(kamokuId);

                if (kamokuRow == null) {
                    continue;
                }

                form.AddKamokuGridRow(
                    kamokuRow.GetStr("name"),
                    row.CurrentYearSum
                );
            }
        }
    }
}
