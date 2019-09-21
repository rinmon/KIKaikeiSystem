using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.controllers.popup
{
    class TekiyouPopupController : AbstractMTPopupController
    {
        views.popup.TekiyouPopup popup;

        public TekiyouPopupController() {
        }


        public HojoKamokuPopupController HojoKamokuController {
            get;
            set;
        }


        override protected views.popup.IMTGridPopup CreatePopup() {
            popup = new views.popup.TekiyouPopup();
            popup.CloseButtonClicked += CloseKamokuPopup;
            popup.AddTekiyouButtonClicked += ShowAddTekiyouView;
            popup.PopupClosed += () => popup = null;
            popup.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            int screenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            popup.Location = new System.Drawing.Point(popup.Width*2, screenHeight - popup.Height - 48);
            return popup;
        }


        override protected string GetInitialSortKey() {
            return "tekiyou_yomi";
        }


        override protected void SetGridRows(string order_by, string first_char) {
            string sql = "";

            sql = " ";
            if (first_char != null) {
                sql += "where tekiyou_yomi like '" + first_char + "%' ";
            }
            sql += "order by " + order_by;

            popup.ClearGrid();
            foreach (var row in Context.KaikeiDatabase.MTTekiyou.Select(sql)) {
                popup.AddGridRow(row.GetStr("tekiyou_code"), row.GetStr("tekiyou_mei"));
            }
        }

        override protected void SetFirstCharList() {
            foreach (var row in Context.KaikeiDatabase.MTTekiyou.FirstCharList) {
                popup.AddFirstCharListItem("" + row.Key);
            }
        }


        // events

        private void CloseKamokuPopup() {
            popup.Close();
        }

        private void ShowHojoKamokuPopup() {
            HojoKamokuController.ShowPopup(popup.Owner);
        }

        private void ShowAddTekiyouView() {
            helper.MsgBox.Info("TBD");
        }
    }
}
