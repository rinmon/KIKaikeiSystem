using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.controllers.popup
{
    class YosanYobihiPopupController
    {
        private views.popup.YosanYobihiPopup popup;
        private models.db.Row rowData;
        private misc.StickyWindowController stickyWindowController;

        public event Action<object, EventArgs> CheckDataButtonClicked;

        int year;
        int kaikeiKubun;
        int hoseiKaisuu;
        int yosanKubun;

        public models.Context Context {
            get;
            set;
        }


        public YosanYobihiPopupController() {
            popup = null;
            rowData = null;
        }


        public void ShowPopup(System.Windows.Forms.Form owner, System.Drawing.Point location) {
            if (popup != null) {
                popup.Close();
                popup = null;
            }

            popup = new views.popup.YosanYobihiPopup();
            popup.PopupClosed += delegate() {
                popup = null;
                rowData = null;
            };
            popup.Row.Column_UpdateValueAction += Column_UpdateValue;
            popup.Row.CheckDataButtonClicked += (s,e) => CheckDataButtonClicked(s,e);

            popup.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            popup.Location = location;

            popup.Show(owner);

            stickyWindowController = new misc.StickyWindowController(owner, popup);
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

            string sql = string.Format("where nenndo={0} and kaikei_kubun={1} and yosan_kubun={2} and hosei_kaisuu={3}",
                    year,
                    kaikeiKubun,
                    yosanKubun,
                    hoseiKaisuu);

            var rows = Context.KaikeiDatabase.YosanYobihi.Select(sql);
            if(rows.Count() > 0){
                rowData = rows.First();
            }
            else{
                rowData = Context.KaikeiDatabase.YosanYobihi.NewRow();
                rowData.Table.SetColumnValue(rowData, "nenndo", year);
                rowData.Table.SetColumnValue(rowData, "kaikei_kubun", kaikeiKubun);
                rowData.Table.SetColumnValue(rowData, "yosan_kubun", yosanKubun);
                rowData.Table.SetColumnValue(rowData, "hosei_kaisuu", hoseiKaisuu);
                rowData.Table.Insert(rowData);
                rowData = rowData.Table.LastInsertedRow();
            }

            popup.Row.SetRowData(rowData, false);
        }


        private void Column_UpdateValue(views.grid.AbstractPanelGridRow rowControl, string column, object value) {
            var row = (rowControl as views.grid.AbstractDBGridRow).RowData;
            var table = row.Table;
            var db = Context.KaikeiDatabase;

            if (table.SetColumnValue(row, column, value)) {
                table.Update(row);
            }
            else {
                // ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgInvalidInput.Replace("%s", value.ToString()), "err", column);
            }
            (rowControl as views.grid.AbstractDBGridRow).SetRowData(row, true);    // 表示の更新
        }
    }
}
