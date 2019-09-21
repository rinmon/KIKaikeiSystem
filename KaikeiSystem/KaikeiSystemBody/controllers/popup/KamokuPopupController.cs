using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.controllers.popup
{
    class KamokuPopupController : AbstractMTPopupController
    {
        views.popup.KamokuPopup popup;

        public KamokuPopupController(){
        }


        public HojoKamokuPopupController HojoKamokuController {
            get;
            set;
        }


        override protected views.popup.IMTGridPopup CreatePopup() {
            popup = new views.popup.KamokuPopup();
            popup.CloseButtonClicked += CloseKamokuPopup;
            popup.HojoKamokuButtonClicked += ShowHojoKamokuPopup;
            popup.AddKamokuButtonClicked += ShowAddKamokuView;
            popup.RowFocused += RowFocused;
            popup.PopupClosed += () => popup = null;

            popup.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            int screenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            popup.Location = new System.Drawing.Point(0, screenHeight - popup.Height - 48);
            return popup;
        }


        override protected string GetInitialSortKey() {
            return "kamoku_yomi";
        }


        override protected void SetGridRows(string orderBy, string firstChar) {
            string sql = "";

            sql = "where usable <> 0 and parent_id = -1 ";
            if (firstChar != null) {
                sql += "and kamoku_yomi like '" + firstChar + "%' ";
            }
            sql += "order by " + orderBy;

            popup.ClearGrid();
            foreach (var row in Context.KaikeiDatabase.MTKanjouKamoku.Select(sql)) {
                popup.AddGridRow(row.GetStr("kamoku_code"), row.GetStr("kamoku"));
            }

            RowFocused();
        }

        override protected void SetFirstCharList() {
            foreach (var row in Context.KaikeiDatabase.MTKanjouKamoku.ParentKamokuFirstCharList) {
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

        private void ShowAddKamokuView() {
        }

        private void RowFocused() {
            models.db.Row kamoku_row = Context.KaikeiDatabase.MTKanjouKamoku.GetRowFromCodeCache(-1, popup.SelectedKey);
            if (kamoku_row != null) {
                HojoKamokuController.KamkokuId = (int)kamoku_row.GetLong("id", 0);
            }
        }
    }
}
