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
    ///  注記11
    /// </summary>
    partial class Tyuuki11Row : AbstractDBGridRow
    {
        public Tyuuki11Row() {
            InitializeComponent();

            btnRemoveRow.Click += base.DefaultHandlerRemoveRowButtonClicked;
            SetDefaultHandlersToControls();

            SetDefaultIndicator();
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            base.SetRowDataToTextBox(txtCaption, rowData);
            base.SetRowDataToAmount(amountTyouboKagaku, rowData);
            base.SetRowDataToAmount(amountJika, rowData);
            base.SetRowDataToAmount(amountHyoukaSoneki, rowData);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase db) {
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
        }


        public override void SetFocusToFirstControl() {
            txtCaption.Select();
        }
    }
}
