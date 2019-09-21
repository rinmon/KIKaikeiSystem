using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class IkkatsuSyoriMasterFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.IkkatsuSyoriMasterForm form;
        private grid.DBPanelGridController<views.grid.IkkatsuSyoriMasterRow> gridController;
        private popup.KamokuPopupController kamokuPopupControlelr;
        private popup.HojoKamokuPopupController hojoKamokuPopupController;
        private popup.TekiyouPopupController tekiyouPopupController;

        public IkkatsuSyoriMasterFormController() {
            form = new KaikeiSystemBody.views.IkkatsuSyoriMasterForm();
            gridController = new grid.DBPanelGridController<views.grid.IkkatsuSyoriMasterRow>(form.Grid, true);
            gridController.ValidateColumnValue += Grid_ValidateColumnValue;

            form.MenuButtonClicked += () => MainController.PopActivity();
            form.KaikeiDenpyouButtonClicked += delegate() {
                MainController.SwitchActivity(
                    controllers.MainController.ActivityType.KaikeiDenpyou,
                    controllers.MainController.ActivitySwitchMethod.Change,
                    Context,
                    null);
            };
            form.KamokuButtonClicked += () => kamokuPopupControlelr.ShowPopup(form);
            form.TekiyouButtonClicked += () => tekiyouPopupController.ShowPopup(form);
            form.NewButtonClicked += () => form.Grid.SelectBottomRow();

            kamokuPopupControlelr = new popup.KamokuPopupController();
            kamokuPopupControlelr.RowClicked += this.KamokuPopupGridRowClicked;
            hojoKamokuPopupController = new popup.HojoKamokuPopupController();
            hojoKamokuPopupController.RowClicked += this.HojoKamokuPopupGridRowClicked;
            kamokuPopupControlelr.HojoKamokuController = hojoKamokuPopupController;
            tekiyouPopupController = new popup.TekiyouPopupController();
            tekiyouPopupController.RowClicked += TekiyouPopupGridRowClicked;
        }


        public override Form Form {
            get {
                return form;
            }
        }

        // events

        private void KamokuPopupGridRowClicked(string key) {
            if (key == null) {
                return;
            }
            if (form.Grid.SelectedRowControl == null) {
                return;
            }

            var control = form.Grid.SelectedRowControl.LastFocusedControl;
            string control_tag = control.Tag as string;
            if (control_tag == "kashikata_kamoku_code" || control_tag == "karikata_kamoku_code") {
                form.Grid.SelectedRowControl.SetControlValue(control_tag, key);
                form.Grid.SelectedRowControl.SetFocusToControlByTag(control_tag);
            }
        }

        private void HojoKamokuPopupGridRowClicked(string key) {
            if (key == null) {
                return;
            }
            if (form.Grid.SelectedRowControl == null) {
                return;
            }
            var control = form.Grid.SelectedRowControl.LastFocusedControl;
            string control_tag = control.Tag as string;
            if (control_tag == "karikata_hojo_seiri" || control_tag == "kashikata_hojo_seiri") {
                form.Grid.SelectedRowControl.SetControlValue(control_tag, key);
                form.Grid.SelectedRowControl.SetFocusToControlByTag(control_tag);
            }
        }

        private void TekiyouPopupGridRowClicked(string key) {
            if (key == null) {
                return;
            }
            if (form.Grid.SelectedRowControl == null) {
                return;
            }

            var control = form.Grid.SelectedRowControl.LastFocusedControl;
            string control_tag = control.Tag as string;
            if (control_tag == "tekiyou_id") {
                form.Grid.SelectedRowControl.SetControlValue(control_tag, key);
                form.Grid.SelectedRowControl.SetFocusToControlByTag("comment");
            }
        }


        override protected void OnActivated(object option) {
            kamokuPopupControlelr.Context = Context;
            hojoKamokuPopupController.Context = Context;
            tekiyouPopupController.Context = Context;

            gridController.SetTable(Context.KaikeiDatabase.MTIkkatsuSyori);
            gridController.SetQuery("order by id");
        }


        override protected void OnDeactivated() {
            kamokuPopupControlelr.ClosePopup();
            hojoKamokuPopupController.ClosePopup();
            tekiyouPopupController.ClosePopup();

            Context.KaikeiDatabase.MTIkkatsuSyori.UpdateCache();
        }


        private void Grid_ValidateColumnValue(views.grid.AbstractDBGridRow row_control, string column, object value) {
            var row = row_control.RowData;
            var db = Context.KaikeiDatabase;

            switch (column) {
                case "karikata_kamoku_code": ValidateKamokuCode(db, row, models.constants.Taisyaku.Karikata); break;
                case "kashikata_kamoku_code": ValidateKamokuCode(db, row, models.constants.Taisyaku.Kashikata); break;
                case "tekiyou_id": db.KaikeiDenpyouMeisai.UpdateCommentWithTekiyou(row); break;
            }
        }


        private void ValidateKamokuCode(models.db.KaikeiDatabase db, models.db.Row row, models.constants.Taisyaku taisyaku) {
            if (models.Validator.IsHurikaeTaisyouKamokuCode(db, row, taisyaku)) {
                gridController.ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgHurikaeTaisyouKamoku, "warn", null);
            }
        }
    }
}
