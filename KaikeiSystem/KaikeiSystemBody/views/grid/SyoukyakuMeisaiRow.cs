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
    partial class SyoukyakuMeisaiRow : AbstractDBGridRow
    {
        public delegate void DenpyouHakkouButtonClickedDelegate(object sender);
        public event DenpyouHakkouButtonClickedDelegate DenpyouHakkouButtonClicked;


        public SyoukyakuMeisaiRow() {
            InitializeComponent();

            SetDefaultHandlersToControls();
            SetDefaultIndicator();

            btnDelete.Click += base.DefaultHandlerRemoveRowButtonClicked;
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            base.SetRowDataToTextBox(txtKaisuu, rowData);
            base.SetRowDataToDateInputPanel(dateGensyoubi, rowData);
            base.SetRowDataToTextBox(txtTsukisuu, rowData);
            base.SetRowDataToAmount(amountKisyuTyouboKagaku, rowData);
            base.SetRowDataToAmount(amountToukiGenkaSyoukyakuKagaku, rowData);
            base.SetRowDataToAmount(amountGenkaSyoukyakuRuikeigaku, rowData);
            base.SetRowDataToAmount(amountKimatsuTyouboKagaku, rowData);
            base.SetRowDataToCheckBox(chkDenpyouHakkou, rowData);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
        }


        public override void SetFocusToFirstControl() {
        }

        private void btnDenpyouHakkou_Click(object sender, EventArgs e) {
            DenpyouHakkouButtonClicked(this);
        }
    }
}
