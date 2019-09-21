using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.controllers.popup
{
    class YosanKakuninPopupController
    {
        private grid.DBPanelGridController<views.grid.YosanKamokuKakuninRow> kamokuGridController;
        private grid.DBPanelGridController<views.grid.YosanHojoKakuninRow> hojoGridController;
        private views.popup.YosanKakuninPopup popup;

        public models.Context Context {
            get;
            set;
        }


        public YosanKakuninPopupController() {
            popup = null;
        }


        public void ShowPopup(System.Windows.Forms.Form owner) {
            if (popup != null) {
                popup.Close();
                popup = null;
            }

            popup = new views.popup.YosanKakuninPopup();
            popup.PopupClosed += delegate() {
                popup = null;
                kamokuGridController = null;
            };
            popup.CloseButtonClicked += delegate() {
                ClosePopup();
            };
            popup.SearchKamokuButtonClicked += delegate() {
                SetQueryConditionForKamoku(
                    false,
                    popup.KamokuSearchConditionYear,
                    popup.KamokuSearchConditionKeiriKubun,
                    popup.KamokuSearchConditionYosanKubun);
            };
            popup.SearchHojoButtonClicked += delegate() {
                SetQueryConditionForHojo(
                    false,
                    popup.HojoSearchConditionYear,
                    popup.HojoSearchConditionKeiriKubun,
                    popup.HojoSearchConditionYosanKubun);
            };

            popup.SetDatabase(Context.KaikeiDatabase);

            kamokuGridController = new grid.DBPanelGridController<views.grid.YosanKamokuKakuninRow>(popup.KamokuGrid, false);
            kamokuGridController.SetTable(Context.KaikeiDatabase.YosanKamokuKubun);

            hojoGridController = new grid.DBPanelGridController<views.grid.YosanHojoKakuninRow>(popup.HojoGrid, false);
            hojoGridController.SetTable(Context.KaikeiDatabase.YosanKamokuKubun);

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


        public void SetQueryConditionForKamoku(bool showAll, int year, int kaikeiKubun, int yosanKubun) {
            if (popup == null) {
                return;
            }

            string sql =
                " as t1 " +
                " inner join " + models.db.tables.YosanKamokuKubun.TABLE_NAME + " as t2 on t1.parent_id = t2.id " +
                " inner join " + models.db.tables.YosanKamokuKubun.TABLE_NAME + " as t3 on t2.parent_id = t3.id " +
                " where t3.parent_id = -1 ";

            if(showAll == false){
                sql += string.Format(
                    " and" +
                    " t1.nenndo = {0} and " +
                    " t1.kaikei_kubun = {1} and " +
                    " t1.yosan_kubun = {2} ",
                    year,
                    kaikeiKubun,
                    yosanKubun
                );
            }
            sql +=
                "order by t1.nenndo desc, " +
                "t1.kaikei_kubun, " +
                "t1.yosan_kubun, " +
                "t1.hosei_kaisuu, " +
                "t1.id";
            
            kamokuGridController.SetQuery(sql);
        }


        public void SetQueryConditionForHojo(bool showAll, int year, int keiriKubun, int yosanKubun) {
            if (popup == null) {
                return;
            }

            string sql =
                " as t1 " +
                " inner join " + models.db.tables.YosanKamokuKubun.TABLE_NAME + " as t2 on t1.parent_id = t2.id " +
                " inner join " + models.db.tables.YosanKamokuKubun.TABLE_NAME + " as t3 on t2.parent_id = t3.id " +
                " inner join " + models.db.tables.YosanKamokuKubun.TABLE_NAME + " as t4 on t3.parent_id = t4.id " +
                " where t4.parent_id = -1 ";

            if (showAll == false) {
                sql += string.Format(
                    " and" +
                    " t1.nenndo = {0} and " +
                    " t1.kaikei_kubun = {1} and " +
                    " t1.yosan_kubun = {2} ",
                    year,
                    keiriKubun,
                    yosanKubun
                );
            }
            sql +=
                "order by t1.nenndo desc, " +
                "t1.kaikei_kubun, " +
                "t1.yosan_kubun, " +
                "t1.hosei_kaisuu, " +
                "t1.id";

            hojoGridController.SetQuery(sql);
        }
    }
}
