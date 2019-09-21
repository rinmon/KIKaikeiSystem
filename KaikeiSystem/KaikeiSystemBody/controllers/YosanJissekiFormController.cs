using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class YosanJissekiFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.YosanJissekiForm form;
        private misc.FocusController focusController;
        models.query.YosanJisseki yosanJisseki;

        public YosanJissekiFormController() {
            form = new KaikeiSystemBody.views.YosanJissekiForm();
            focusController = new misc.FocusController(form);

            form.CalcButtonClicked += CalcButtonClicked;
            form.PrintButtonClicked += PrintButtonClicked;
            form.CloseButtonClicked += () => MainController.PopActivity();
            form.KaikeiKubunSelectionChanged += delegate() { };
            form.KamokuRowSelectionChanged += KamokuGridRowSelectionChanged;

            form.YosanButtonClicked += delegate() {
                this.MainController.SwitchActivity(
                    controllers.MainController.ActivityType.Yosan,
                    controllers.MainController.ActivitySwitchMethod.Change,
                    this.Context,
                    null
                );
            };
        }


        public override Form Form {
            get {
                return form;
            }
        }


        override protected void OnActivated(object option) {
            yosanJisseki = new models.query.YosanJisseki(Context.KaikeiDatabase);

            form.SetGengou(Context.Setting.GetStr("before_gengou", "")); 
            form.SetDatabase(Context.KaikeiDatabase);

            form.ClearKubunGrid();
            form.ClearChukubunGrid();
            form.ClearSyoukubunKamokuGrid();
        }

        override protected void OnDeactivated() {
        }


        private bool CheckParameters() {
            if (form.Year == -1) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidYear);
                return false;
            }
            if (form.HoseiKaisuu == -1) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidHoseiKaisuuInput);
                return false;
            }
            if (form.KaikeiKubun == -1) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidKaikeiKubun);
                return false;
            }

            return true;
        }


        private void CalcButtonClicked() {
            if(!CheckParameters()){
                return;
            }

            SetData();
        }


        private void PrintButtonClicked() {
            if (!CheckParameters()) {
                return;
            }

            yosanJisseki.Calc(form.Year, form.HoseiKaisuu, form.KaikeiKubun);

            string houjinMeisyou = Context.KaikeiDatabase.MTKaikeiKubun.GetRowFromCache(Context.KaikeiDatabase.MTKaikeiKubun.RootNodeId).GetStr("name");
            string kaikeiKubunName = Context.KaikeiDatabase.MTKaikeiKubun.GetRowFromCache(form.KaikeiKubun).GetStr("name");

            var report = new views.reports.YosanJissekiReport();
            report.SetDB(Context.KaikeiDatabase);
            report.SetHeader(form.YearWarekiGengou, form.YearWareki, form.HoseiKaisuu, houjinMeisyou, kaikeiKubunName);
            report.SetReportFooter(
                yosanJisseki.SyuunyuuGoukeiRow.Yosan, yosanJisseki.SyuunyuuGoukeiRow.Jisseki,
                yosanJisseki.ShisyutsuGoukeiRow.Yosan, yosanJisseki.ShisyutsuGoukeiRow.Jisseki,
                yosanJisseki.SyuushiGoukeiRow.Yosan, yosanJisseki.SyuushiGoukeiRow.Jisseki);
            report.DataSource = yosanJisseki.GetYosanJissekiRowList();
            report.Run();

            var popup = new views.popup.ReportPreviewPopup();
            popup.Document = report.Document;
            popup.ShowDialog();
        }


        private void SetData() {
            yosanJisseki.Calc(form.Year, form.HoseiKaisuu, form.KaikeiKubun);
            form.ClearKubunGrid();
            form.ClearChukubunGrid();

            foreach (var row in yosanJisseki.EnumAllChuukubun()) {
                form.AddChukubunGridRow(
                    row.KamokuId,
                    row.KamokuCode,
                    row.Name,
                    row.Yosan,
                    row.Jisseki
                );
            }

            foreach (var row in yosanJisseki.EnumSummaryRow()) {
                form.AddKubunGridRow(
                    row.Name,
                    row.Yosan,
                    row.Jisseki
                );
            }

            KamokuGridRowSelectionChanged();
        }


        private void KamokuGridRowSelectionChanged() {
            form.ClearSyoukubunKamokuGrid();

            if (form.SelectedChukubunId == -1) {
                return;
            }

            foreach (var row in yosanJisseki.EnumSyoukubunAndHojokamoku(form.SelectedChukubunId)) {
                form.AddSyoukubunGridRow(
                    row.KamokuCode,
                    row.Name,
                    row.Yosan,
                    row.Jisseki
                );
            }
        }
    }
}
