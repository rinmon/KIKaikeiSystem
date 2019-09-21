using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.views.grid
{
    partial class KanjouKamokuRow : AbstractDBGridRow
    {
        private models.db.KaikeiDatabase db;

        public event Action<object> ShowDetailButtonClicked;   // ShowDetailButtonClicked(object sender)

        public KanjouKamokuRow() {
            InitializeComponent();

            SetDefaultHandlersToControls();
            SetDefaultIndicator();

            btnDetail.Click += (s, e) => ShowDetailButtonClicked(this);
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            base.SetRowDataToTextBox(txtKamokuCode, rowData);
            base.SetRowDataToTextBox(txtKamoku, rowData);
            base.SetRowDataToCheckBox(chkUsable, rowData);
            base.SetRowDataToCheckBox(chkPrintTarget, rowData);
            
            { // parent
                int kubunId = 0;
                kubunId = (int)rowData.GetLong("jigyou_kamoku_kubun_id", -1);
                if (kubunId == -1) {
                    kubunId = (int)rowData.GetLong("shikin_kamoku_kubun_id", -1);
                }
                if (kubunId == -1) {
                    kubunId = (int)rowData.GetLong("taisyaku_kamoku_kubun_id", -1);
                }

                if (kubunId != -1) {
                    models.db.Row parentKubunRow = db.MTKamokuKubun.GetParentOf(db.MTKamokuKubun.GetRowFromCache(kubunId));
                    if (parentKubunRow != null) {
                        txtParent.Text = parentKubunRow.GetStr("name");
                    }
                    else {
                        txtParent.Text = "";
                    }
                }
                else {
                    txtParent.Text = "";
                }
            }

            txtTaisyakuKubun.Text = rowData.GetMasterStr("taisyaku_kubun_id", "caption", "", db.MTTaisyakuKubun);

            SetKamokuKubunParentText(txtShikinKamokuKubun, rowData, "shikin_kamoku_kubun_id", (int)models.constants.MTKamokuKubunHierarchy.Kubun);
            SetKamokuKubunParentText(txtJigyouKamokuKubun, rowData, "jigyou_kamoku_kubun_id", (int)models.constants.MTKamokuKubunHierarchy.Kubun);
            SetKamokuKubunParentText(txtTaisyakuKamokuKubun, rowData, "taisyaku_kamoku_kubun_id", (int)models.constants.MTKamokuKubunHierarchy.Kubun);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
            db = aDB as models.db.KaikeiDatabase;
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            db = (originalRow as KanjouKamokuRow).db;
        }

        public override void SetFocusToFirstControl() {
            txtKamokuCode.Select();
        }


        private void SetKamokuKubunParentText(TextBox textBox, models.db.Row row, string column, int hierarchy) {
            int kubunId = (int)row.GetLong(column, -1);
            if (kubunId != -1) {
                models.db.Row kubunRow = db.MTKamokuKubun.GetParentOf(db.MTKamokuKubun.GetRowFromCache(kubunId), hierarchy);
                if (kubunRow != null) {
                    textBox.Text = kubunRow.GetStr("name");
                }
                else {
                    textBox.Text = "";
                }
            }
            else {
                textBox.Text = "";
            }
        }
    }
}
