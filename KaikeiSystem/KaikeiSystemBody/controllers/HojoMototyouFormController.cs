using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class HojoMototyouFormController
    {
        private KaikeiSystemBody.views.KanjouMototyouForm form;
        private models.query.KanjouMototyou mototyou;

        public HojoMototyouFormController() {
            mototyou = null;

            form = new KaikeiSystemBody.views.KanjouMototyouForm();
            form.SelectViewMode(views.KanjouMototyouForm.ViewMode.ViewHojoKamoku);

            form.SearchButtonClicked += SearchButtonClicked;
            form.ReturnButtonClicked += () => form.Close();

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

            form.SetStatusMessage += delegate(string msg) {
                form.SetStatusbarMessage(msg);
            };
        }


        public Form Form {
            get { return form; }
        }

        private models.Context Context {
            get;
            set;
        }

        public void ShowDialog(models.Context context,
                                            DateTime? startDate,
                                            DateTime? endDate,
                                            string kamokuCode,
                                            int kaikeiKubun) {
            Context = context;

            mototyou = new models.query.KanjouMototyou(context.KaikeiDatabase);

            form.SetDatabase(Context.KaikeiDatabase);
            form.ClearControls(Context.Setting.GetStr("before_gengou", "H"));

            form.StartDate = startDate;
            form.EndDate = endDate;
            form.TargetKamokuCode = kamokuCode;
            form.TargetKaikeiKubun = kaikeiKubun;

            form.ShowDialog();
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
            if (form.TargetHojoKamokuSeiri == null) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidHojoKamoku);
                return;
            }

            models.db.Row kamokuRow = Context.KaikeiDatabase.MTKanjouKamoku.GetRowFromCodeCache(-1, form.TargetKamokuCode);
            if (kamokuRow == null) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidKamoku);
                return;
            }
            models.db.Row hojoRow = Context.KaikeiDatabase.MTKanjouKamoku.GetRowFromCodeCacheByTopParent((int)kamokuRow.GetLong("id", -1), form.TargetHojoKamokuSeiri);
            if (hojoRow == null) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidKamoku);
                return;
            }

            int hojoId = (int)hojoRow.GetLong("id", -1);

            mototyou.Calc(form.StartDate.Value, form.EndDate.Value, hojoId, form.TargetKaikeiKubun, form.DenpyouSeiriChecked, isHojoKamoku: true);
            form.SetMototyouData(mototyou);
        }


        private void RefreshView() {
            mototyou.Recalc();
            form.SetMototyouData(mototyou);
        }
    }
}
