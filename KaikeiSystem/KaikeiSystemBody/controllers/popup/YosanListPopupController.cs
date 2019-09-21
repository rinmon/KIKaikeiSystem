using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.controllers.popup
{
    class YosanListPopupController
    {
        private grid.DBPanelGridController<views.grid.YosanListRow> gridController;
        private views.popup.YosanListPopup popup;

        public delegate void ShowButtonClickDelegate(int nenndo, int keiriKubun, int yosanKubun, int hoseiKaisuu);
        public event ShowButtonClickDelegate ShowButtonClicked;

        public models.Context Context {
            get;
            set;
        }


        public YosanListPopupController() {
            popup = null;
        }


        public void ShowPopup(System.Windows.Forms.Form owner) {
            if (popup != null) {
                popup.Close();
                popup = null;
            }

            popup = new views.popup.YosanListPopup();
            popup.PopupClosed += delegate() {
                popup = null;
                gridController = null;
            };
            popup.CloseButtonClicked += delegate() {
                this.ClosePopup();
            };
            popup.ShowAllButtonClicked += delegate() {
                SetQueryCondition(year: -1);
            };
            popup.ShowCurrentYearButtonClicked += delegate() {
                SetQueryCondition(year:Context.Setting.GetDateTime("nenndo_kisanbi").Value.Year);
            };
            popup.ShowButtonClicked += delegate(object sender) {
                views.grid.AbstractDBGridRow row = sender as views.grid.AbstractDBGridRow;
                int nenndo = (int)row.RowData.GetLong("nenndo", 0);
                int kaikeiKubun = (int)row.RowData.GetLong("kaikei_kubun", 0);
                int yosanKubun = (int)row.RowData.GetLong("yosan_kubun", 0);
                int hoseiKaisuu = (int)row.RowData.GetLong("hosei_kaisuu", 0);
                ShowButtonClicked(nenndo, kaikeiKubun, yosanKubun, hoseiKaisuu);
            };

            gridController = new grid.DBPanelGridController<views.grid.YosanListRow>(popup.Grid, false);
            gridController.SetTable(Context.KaikeiDatabase.YosanKamokuKubun);
            SetQueryCondition(year: -1);

            popup.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            popup.Location = new System.Drawing.Point(
                owner.Location.X + (owner.Size.Width - popup.Size.Width) / 2,
                owner.Location.Y + (owner.Size.Height - popup.Size.Height) / 2
                );

            popup.Show(owner);
        }


        private void SetQueryCondition(int year) {
            string sql = "where parent_id = -1 ";

            if (year > 0) {
                sql += "and nenndo = " + year.ToString() + " ";
            }
            sql += " order by nenndo desc, kaikei_kubun, yosan_kubun, hosei_kaisuu";
            gridController.SetQuery(sql);

        }


        public void ClosePopup() {
            if (popup != null) {
                popup.Close();
                popup = null;
            }
        }
    }
}
