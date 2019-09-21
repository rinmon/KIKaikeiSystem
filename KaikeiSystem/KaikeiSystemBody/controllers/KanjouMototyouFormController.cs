using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class KanjouMototyouFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.KanjouMototyouForm form;
        private models.query.KanjouMototyou mototyou;


        public KanjouMototyouFormController() {
            mototyou = null;

            form = new KaikeiSystemBody.views.KanjouMototyouForm();
            form.SelectViewMode(views.KanjouMototyouForm.ViewMode.ViewKamoku);

            form.SearchButtonClicked += SearchButtonClicked;
            form.ReturnButtonClicked += () => MainController.PopActivity();
            form.ShowDenpyouViewButtonClicked += () => MainController.SwitchActivity(
                controllers.MainController.ActivityType.KaikeiDenpyou,
                controllers.MainController.ActivitySwitchMethod.Change,
                Context,
                controllers.KaikeiDenpyouFormController.QueryType.CurrentYear);

            form.AddDenpyouButtonClicked += delegate() {
                var popupController = new popup.DenpyouInfoPopupController();
                popup.DenpyouInfoPopupController.Result result;
                var row = mototyou.MeisaiTable.NewRow();

                string wareki =  Context.Setting.GetStr("before_gengou", "") +
                                Context.Setting.GetStr("before_year", "") + "/" +
                                Context.Setting.GetStr("before_month", "") + "/" +
                                Context.Setting.GetStr("before_day", "");
                if (helper.Converter.IsWareki(wareki)) {
                    DateTime date = helper.Converter.DateStrToDateTime(wareki);
                    mototyou.MeisaiTable.SetKihyoubiAndDenpyouBangouCache(row, date);
                }

                result = popupController.ShowPopupModal(form, row, Context);
                if (result != popup.DenpyouInfoPopupController.Result.None) {
                    form.SaveGridScrollAndSelection();
                    RefreshView();
                    form.LoadGridScrollAndSelection();
                }
            };
            form.RowDetailButtonClicked += delegate(int rowIndex) {
                var popupController = new popup.DenpyouInfoPopupController();
                popup.DenpyouInfoPopupController.Result result;
                result = popupController.ShowPopupModal(form, mototyou.GetDenpyouMeisaiRow(rowIndex), Context);
                if (result != popup.DenpyouInfoPopupController.Result.None) {
                    form.SaveGridScrollAndSelection();
                    RefreshView();
                    form.LoadGridScrollAndSelection();
                }
            };
            form.PrintButtonClicked += delegate() {
                var popupController = new popup.KanjouMototyouPrintPopupController();
                popupController.ShowPopupModal(form, Context);
            };


            form.ShowHojoMototyouButtonClicked += delegate() {
                HojoMototyouFormController hojoController = new HojoMototyouFormController();
                hojoController.ShowDialog(Context, 
                                        form.StartDate, form.EndDate, form.TargetKamokuCode, form.TargetKaikeiKubun);
            };

            form.SetStatusMessage += delegate(string msg) {
                form.SetStatusbarMessage(msg);
            };
        }


        public override Form Form {
            get { return form; }
        }


        override protected void OnActivated(object option) {
            mototyou = new models.query.KanjouMototyou(Context.KaikeiDatabase);

            form.SetDatabase(Context.KaikeiDatabase);
            form.ClearControls(Context.Setting.GetStr("before_gengou", "H"));
        }

        override protected void OnDeactivated() {
        }


        private void SearchButtonClicked() {
            if (form.StartDate == null || form.EndDate == null) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidDate);
                return;
            }
            if (form.TargetKamokuCode == null) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidKamoku);
                return;
            }

            models.db.Row kamokuRow = Context.KaikeiDatabase.MTKanjouKamoku.GetRowFromCodeCache(-1, form.TargetKamokuCode);
            if(kamokuRow == null){
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidKamoku);
                return;
            }
            int kamokuId = (int)kamokuRow.GetLong("id", -1);

            mototyou.Calc(form.StartDate.Value, form.EndDate.Value, kamokuId, form.TargetKaikeiKubun, form.DenpyouSeiriChecked, isHojoKamoku: false);
            form.SetMototyouData(mototyou);
        }


        private void RefreshView() {
            mototyou.Recalc();
            form.SetMototyouData(mototyou);
        }
    }
}
