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
    ///  注記10
    /// </summary>
    partial class Tyuuki10Row : AbstractDBGridRow
    {
        public Tyuuki10Row() {
            InitializeComponent();

            btnRemoveRow.Click += base.DefaultHandlerRemoveRowButtonClicked;
            SetDefaultHandlersToControls();

            SetDefaultIndicator();
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            base.SetRowDataToMTCombo(cmbKamokuKubun, rowData);
            base.SetRowDataToAmount(amountSaikenGaku, rowData);
            base.SetRowDataToAmount(amountTyousyuuhunouZandaka, rowData);
            base.SetRowDataToAmount(amountToukimatsuZandaka, rowData);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase db) {
            cmbKamokuKubun.InitRowsWithMTKamokuKubunWithParentFilterByKubun(
                (db as models.db.KaikeiDatabase).MTKamokuKubun,
                (int)models.constants.MTKamokuKubun.Shisan);
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            cmbKamokuKubun.CopyRows((originalRow as Tyuuki10Row).cmbKamokuKubun);
        }


        public override void SetFocusToFirstControl() {
            cmbKamokuKubun.Select();
        }
    }
}
