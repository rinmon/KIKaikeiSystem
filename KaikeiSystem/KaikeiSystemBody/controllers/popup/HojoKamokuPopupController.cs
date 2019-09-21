using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.controllers.popup
{
    class HojoKamokuPopupController : AbstractMTPopupController
    {
        views.popup.HojoKamokuPopup popup;
        int kamokuId;

        public HojoKamokuPopupController(){
            popup = null;
            kamokuId = 0;
            ShowChildren = true;
        }


        override protected views.popup.IMTGridPopup CreatePopup() {
            popup = new views.popup.HojoKamokuPopup();
            popup.AddHojoKamokuButtonClicked += ShowAddHojoKamokuView;
            popup.CloseButtonClicked += CloseButtonClicked;
            popup.PopupClosed += () => popup = null;

            popup.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            int screenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            popup.Location = new System.Drawing.Point(popup.Width, screenHeight - popup.Height - 48);

            return popup;
        }


        public int KamkokuId {
            get {
                return kamokuId;
            }
            set{
                kamokuId = value;
                if (popup != null) {
                    SetGridRows(null, null);
                }
            }
        }


        public bool ShowChildren {
            get;
            set;
        }

        override protected string GetInitialSortKey() {
            return "";
        }


        override protected void SetGridRows(string order_by, string first_char) {
            popup.ClearGrid();
            SetGridRowsSub(kamokuId, "");
        }


        private void SetGridRowsSub(int parentId, string prefix) {
            string sql = "";

            sql = " where parent_id=" + parentId;
            sql += " order by kamoku_code ";

            foreach (var row in Context.KaikeiDatabase.MTKanjouKamoku.Select(sql)) {
                popup.AddGridRow(row.GetStr("kamoku_code"), prefix + row.GetStr("kamoku"));
                if (ShowChildren) {
                    SetGridRowsSub((int)row.GetLong("id", -1), prefix + "  ");
                }
            }
        }


        override protected void SetFirstCharList() {
        }


        // events

        private void ShowAddHojoKamokuView() {
            helper.MsgBox.Info("TBD");
        
        }

        private void CloseButtonClicked() {
            popup.Close();
        }
    }
}
