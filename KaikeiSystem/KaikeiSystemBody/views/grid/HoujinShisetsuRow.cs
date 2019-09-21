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
    partial class HoujinShisetsuRow : AbstractDBGridRow
    {
        private models.db.KaikeiDatabase db;

        public HoujinShisetsuRow() {
            InitializeComponent();

            SetDefaultHandlersToControls();
            SetDefaultIndicator();

            btnDelete.Click += base.DefaultHandlerRemoveRowButtonClicked;
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            base.SetRowDataToTextBox(txtCode, rowData);
            base.SetRowDataToTextBox(txtShisetsuMeisyou, rowData);
            base.SetRowDataToTextBox(txtRyakusyou, rowData);
            base.SetRowDataToTextBox(txtTel, rowData);
            base.SetRowDataToTextBox(txtFAX, rowData);
            base.SetRowDataToTextBox(txtDaihyousyaShimei, rowData);
            base.SetRowDataToMTCombo(cmbParentKaikeiKubun, rowData);
            base.SetRowDataToTextBox(txtYuubinBangou, rowData);
            base.SetRowDataToTextBox(txtTodouhuken, rowData);
            base.SetRowDataToTextBox(txtShiKuGun, rowData);
            base.SetRowDataToTextBox(txtChouSonIki, rowData);
            base.SetRowDataToTextBox(txtBanchiTatemonomei, rowData);
            base.SetRowDataToAmount(amountGenkaSyoukyaku, rowData);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
            db = aDB as models.db.KaikeiDatabase;
            cmbParentKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, false, (int)models.constants.MTKaikeiKubunHierarchy.Kyoten);
            cmbParentKaikeiKubun.SelectionLength = 0;
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            cmbParentKaikeiKubun.InitRowsWithMTKaikeiKubun((originalRow as HoujinShisetsuRow).db.MTKaikeiKubun, false, (int)models.constants.MTKaikeiKubunHierarchy.Kyoten);
            cmbParentKaikeiKubun.SelectionLength = 0;
        }

        public override void SetFocusToFirstControl() {
            txtCode.Select();
        }
    }
}
