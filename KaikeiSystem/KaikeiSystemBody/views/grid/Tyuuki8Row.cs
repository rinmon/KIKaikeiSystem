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
    ///  注記8
    /// </summary>
    partial class Tyuuki8Row : AbstractDBGridRow
    {
        public Tyuuki8Row() {
            InitializeComponent();

            btnRemoveRow.Click += base.DefaultHandlerRemoveRowButtonClicked;
            SetDefaultHandlersToControls();

            SetDefaultIndicator();
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            base.SetRowDataToMTCombo(cmbKamokuKubun, rowData);
            base.SetRowDataToMTCombo(cmbTanpoKubun, rowData);
            base.SetRowDataToAmount(txtAmount, rowData);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase db) {
            cmbKamokuKubun.InitRowsWithMTKamokuKubunWithParentFilterByKubun(
                (db as models.db.KaikeiDatabase).MTKamokuKubun,
                (int)models.constants.MTKamokuKubun.Shisan);
            cmbTanpoKubun.InitRowsWithMTTanpoKubun((db as models.db.KaikeiDatabase).MTTanpoKubun);
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            cmbKamokuKubun.CopyRows((originalRow as Tyuuki8Row).cmbKamokuKubun);
            cmbTanpoKubun.CopyRows((originalRow as Tyuuki8Row).cmbTanpoKubun);
        }


        public override void SetFocusToFirstControl() {
            cmbTanpoKubun.Select();
        }
    }
}
