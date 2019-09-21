using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class BalanceSheetFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.BalanceSheetForm form;
        private models.query.BalanceSheet balanceSheet;
        private misc.FocusController focusController;

        public BalanceSheetFormController() {
            form = new KaikeiSystemBody.views.BalanceSheetForm();
            form.CalcButtonClicked += CalcButtonClicked;
            form.ReturnButtonClicked += () => MainController.PopActivity();

            focusController = new misc.FocusController(form);
        }


        public override Form Form {
            get {
                return form;
            }
        }


        override protected void OnActivated(object option) {
            balanceSheet = new models.query.BalanceSheet(Context.KaikeiDatabase);

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

            form.ClearGrid();

            balanceSheet.Calc(form.StartDate.Value, form.EndDate.Value, form.KaikeiKubun, hideInnerKaikeiKubunKamoku:true);

            int year = helper.Converter.GetNenndo(form.StartDate.Value);

            foreach (var row in balanceSheet.AllKamokuSummary()) {
                int kamokuId = row.Id;
                models.db.Row kamokuKubunRow = Context.KaikeiDatabase.MTKamokuKubun.GetRowFromCache(kamokuId);
                models.db.Row daikubunRow = Context.KaikeiDatabase.MTKamokuKubun.GetRowFromCache((int)kamokuKubunRow.GetLong("parent_id", -1));
                string daikubunStr = daikubunRow != null ? daikubunRow.GetStr("name", "") : "";

                if(row.TaisyakuKamokuKubunId == (int)models.constants.MTKamokuKubun.Shisan){
                    form.AddShisanGridRow(
                        daikubunStr,
                        kamokuKubunRow.GetStr("name", ""),
                        row.CurrentSumAmount,
                        row.LastSumAmount,
                        row.Sai
                    );
                }
                if (row.TaisyakuKamokuKubunId == (int)models.constants.MTKamokuKubun.Husai) {
                    form.AddHusaiGridRow(
                        daikubunStr,
                        kamokuKubunRow.GetStr("name", ""),
                        row.CurrentSumAmount,
                        row.LastSumAmount,
                        row.Sai
                    );
                }
                if (row.TaisyakuKamokuKubunId == (int)models.constants.MTKamokuKubun.Junshisan) {
                    form.AddJunshisanGridRow(
                        daikubunStr,
                        kamokuKubunRow.GetStr("name", ""),
                        row.CurrentSumAmount,
                        row.LastSumAmount,
                        row.Sai
                    );
                }
            }

            foreach (models.query.BalanceSheet.SummaryItem item in Enum.GetValues(typeof(models.query.BalanceSheet.SummaryItem))) {
                models.query.BalanceSheet.BalanceSheetRow row = balanceSheet.GetSummaryItem(item);
                form.SetSummaryItem(item, row.CurrentSumAmount, row.LastSumAmount, row.Sai);
            }

            helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgSucceeded);
        }
    }
}
