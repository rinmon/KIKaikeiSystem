using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class ShikinSyuushiFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.ShikinSyuushiForm form;
        private models.query.ShikinSyuushi shikinSyuushi;
        private misc.FocusController focusController;

        public ShikinSyuushiFormController() {
            form = new KaikeiSystemBody.views.ShikinSyuushiForm();
            form.CalcButtonClicked += CalcButtonClicked;
            form.ReturnButtonClicked += () => MainController.PopActivity();
            form.ShowJigyouSyuushiButtonClicked += delegate(){
                MainController.SwitchActivity(
                    controllers.MainController.ActivityType.JigyouSyuushi,
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

            shikinSyuushi = new models.query.ShikinSyuushi(Context.KaikeiDatabase);
            shikinSyuushi.Calc(form.StartDate.Value, form.EndDate.Value, form.KaikeiKubun, hoseiKaisuu:-1, hideInnerKaikeiKubunKamoku:true, targetKamokuKubunHierarchy:models.constants.MTKamokuKubunHierarchy.ChuuKubun, omitZeroRow:false);

            form.ClearDaikubunGrid();
            form.ClearKamokuGrid();

            foreach (var row in shikinSyuushi.DaikubunRows) {
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
                    row.Yosan,
                    row.Taisyaku,
                    row.Sai
                );
            }

            form.SetSummaryGrid(shikinSyuushi);
            form.FireDaikubunGridSelectionChanged();

            helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgSucceeded);
        }


        private void DaikubunGridRowSelected(int daikubunId) {
            form.ClearKamokuGrid();

            if(shikinSyuushi.ChildRowsOf.ContainsKey(daikubunId) == false){
                return;
            }

            foreach (var row in shikinSyuushi.ChildRowsOf[daikubunId]) {
                int kamokuId = row.Id;
                models.db.Row kamokuRow = Context.KaikeiDatabase.MTKamokuKubun.GetRowById(kamokuId);

                if (kamokuRow == null) {
                    continue;
                }

                form.AddKamokuGridRow(
                    kamokuRow.GetStr("name"),
                    row.Taisyaku
                );
            }
        }
    }
}
