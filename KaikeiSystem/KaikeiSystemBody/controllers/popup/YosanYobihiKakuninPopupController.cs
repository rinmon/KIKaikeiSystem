using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.controllers.popup
{
    class YosanYobihiKakuninPopupController
    {
        private grid.DBPanelGridController<views.grid.YosanYobihiKakuninRow> gridController;
        private views.popup.YosanYobihiKakuninPopup popup;

        int year;
        int kaikeiKubun;
        int hoseiKaisuu;
        int yosanKubun;

        public models.Context Context {
            get;
            set;
        }


        public YosanYobihiKakuninPopupController()
        {
            popup = null;
        }


        public void ShowPopup(System.Windows.Forms.Form owner) {
            if (popup != null) {
                popup.Close();
                popup = null;
            }

            popup = new views.popup.YosanYobihiKakuninPopup();
            popup.PopupClosed += delegate() {
                popup = null;
                gridController = null;
            };

            gridController = new grid.DBPanelGridController<views.grid.YosanYobihiKakuninRow>(popup.Grid, false);
            gridController.SetTable(Context.KaikeiDatabase.YosanYobihi);

            popup.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            popup.Location = new System.Drawing.Point(
                owner.Location.X + (owner.Size.Width - popup.Size.Width) / 2,
                owner.Location.Y + (owner.Size.Height - popup.Size.Height) / 2
                );
            popup.Show(owner);
        }


        public void ClosePopup() {
            if (popup != null) {
                popup.Close();
                popup = null;
            }
        }


        public void SetQueryCondition(int year_, int kaikeiKubun_, int yosanKubun_, int hoseiKaisuu_) {
            if (popup == null) {
                return;
            }

            year = year_;
            kaikeiKubun = kaikeiKubun_;
            hoseiKaisuu = hoseiKaisuu_;
            yosanKubun = yosanKubun_;

            string sql = string.Format(
                "where nenndo = {0} and " +
                " kaikei_kubun = {1} and " +
                " yosan_kubun = {2} and " +
                " hosei_kaisuu = {3} ",
                year,
                kaikeiKubun,
                yosanKubun,
                hoseiKaisuu
                );
            gridController.SetQuery(sql);

        }
    }
}
