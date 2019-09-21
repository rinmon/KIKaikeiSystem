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
    /// <summary>
    ///  BalanceSheetComment担保
    /// </summary>
    partial class BSCTanpoRow : AbstractDBGridRow
    {
        public BSCTanpoRow() {
            InitializeComponent();

            cmbKamoku.SelectedValueChanged += delegate(object sender, EventArgs e) {
                SetKamokuLabel();
            };

            btnRemoveRow.Click += base.DefaultHandlerRemoveRowButtonClicked;
            SetDefaultHandlersToControls();

            SetDefaultIndicator();
        }

        private void SetKamokuLabel() {
            if (cmbKamoku.SelectedRow != null) {
                lblKamoku.Text = cmbKamoku.SelectedRow.Cells(1).ToString() + " " + cmbKamoku.SelectedRow.Cells(2).ToString();
            }
            else {
                lblKamoku.Text = "";
            }
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            cmbKaikeiKubun.SelectRowByKeyValue(rowData.GetLong("kaikei_kubun", -1));
            cmbKamoku.SelectRowByKeyValue(rowData.GetLong("kamoku_id", -1));

            int index = (int)rowData.GetLong("tanpo_kubun", -1) - 1;
            if (index >= 0) {
                cmbTanpoKubun.SelectedIndex = index;
            }
            else {
                cmbTanpoKubun.SelectedIndex = -1;
            }

            txtAmount.AmountStr = rowData.GetStr("amount");
            SetKamokuLabel();
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase db) {
            cmbKaikeiKubun.InitRowsWithMTKaikeiKubun((db as models.db.KaikeiDatabase).MTKaikeiKubun, true); 
            cmbKamoku.InitRowsWithTaisyakuKanjouKamoku(
                (db as models.db.KaikeiDatabase).MTKanjouKamoku,
                (db as models.db.KaikeiDatabase).MTKamokuKubun);
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            cmbKaikeiKubun.CopyRows((originalRow as BSCTanpoRow).cmbKaikeiKubun);
            cmbKamoku.CopyRows((originalRow as BSCTanpoRow).cmbKamoku);
        }


        public override void SetFocusToFirstControl() {
            cmbKaikeiKubun.Select();
        }


        protected override object GetControlValue(Control control) {
            if (control == cmbTanpoKubun) {
                return cmbTanpoKubun.SelectedIndex + 1;
            }
            else {
                return base.GetControlValue(control);
            }
        }
    }
}
