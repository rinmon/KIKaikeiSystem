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
    partial class KaikeiTanniRow : AbstractDBGridRow
    {
        public KaikeiTanniRow() {
            InitializeComponent();

            SetDefaultHandlersToControls();
            SetDefaultIndicator();
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            base.SetRowDataToTextBox(txtId, rowData);
            base.SetRowDataToTextBox(txtKaikeiTanni, rowData);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase db) {

        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
        }

        public override void SetFocusToFirstControl() {
            txtId.Select();
        }
    }
}
