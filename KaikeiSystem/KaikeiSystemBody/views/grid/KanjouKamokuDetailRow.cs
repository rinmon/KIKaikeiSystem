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
    partial class KanjouKamokuDetailRow : AbstractDBGridRow
    {
        public event Action DeleteButtonClicked;

        public KanjouKamokuDetailRow() {
            InitializeComponent();

            penForBottomLine = null;
            penForLeftLine = null;

            SetDefaultHandlersToControls();
        }

        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            base.SetRowDataToTextBox(txtKamokuCode, rowData);
            base.SetRowDataToMTCombo(cmbTaisyaku, rowData);
            base.SetRowDataToCheckBox(chkUsable, rowData);
            base.SetRowDataToCheckBox(chkPrintTarget, rowData);
            base.SetRowDataToTextBox(txtKamoku, rowData);
            base.SetRowDataToTextBox(txtKamokuYomi, rowData);
            base.SetRowDataToTextBox(txtJigyouKamokuKubun, rowData);
            base.SetRowDataToTextBox(txtTaisyakuKamokuKubun, rowData);
            base.SetRowDataToTextBox(txtShikinKamokuKubun, rowData);
            base.SetRowDataToTextBox(txtParentShikin, rowData);
            base.SetRowDataToTextBox(txtParentJigyou, rowData);
            base.SetRowDataToTextBox(txtParentTaisyaku, rowData);

            bool editable = rowData.GetBool("editable", false);
            txtKamokuCode.Enabled = editable;
            cmbTaisyaku.Enabled = editable;
            chkPrintTarget.Enabled = editable;
            txtKamoku.Enabled = editable;
            txtKamokuYomi.Enabled = editable;
            txtJigyouKamokuKubun.Enabled = editable;
            txtTaisyakuKamokuKubun.Enabled = editable;
            txtShikinKamokuKubun.Enabled = editable;
            lblNotEditable.Visible = !editable;
            btnDelete.Enabled = editable;

            txtJigyouKamokuKubun.Enabled = editable && (rowData.GetLong("parent_jigyou_kamoku_kubun_id", -1) != -1);
            txtShikinKamokuKubun.Enabled = editable && (rowData.GetLong("parent_shikin_kamoku_kubun_id", -1) != -1);
            txtTaisyakuKamokuKubun.Enabled = editable && (rowData.GetLong("parent_taisyaku_kamoku_kubun_id", -1) != -1);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
            cmbTaisyaku.InitRowsWithMTTaisyakuKubun((aDB as models.db.KaikeiDatabase).MTTaisyakuKubun);
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            cmbTaisyaku.CopyRows((originalRow as KanjouKamokuDetailRow).cmbTaisyaku);
        }


        public override void SetFocusToFirstControl() {
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DeleteButtonClicked();
        }
    }
}
