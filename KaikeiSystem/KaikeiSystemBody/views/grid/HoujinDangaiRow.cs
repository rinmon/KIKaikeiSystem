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
    partial class HoujinDangaiRow : AbstractDBGridRow
    {
        public HoujinDangaiRow() {
            InitializeComponent();

            penForBottomLine = null;
            penForLeftLine = null;

            SetDefaultHandlersToControls();
        }

        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            base.SetRowDataToTextBox(txtHoujinMeisyou, rowData);
            base.SetRowDataToTextBox(txtYuubinBangou, rowData);
            base.SetRowDataToTextBox(txtTodouhuken, rowData);
            base.SetRowDataToTextBox(txtShiKuGun, rowData);
            base.SetRowDataToTextBox(txtTyouSonIki, rowData);
            base.SetRowDataToTextBox(txtBanchiTatemonomei, rowData);
            base.SetRowDataToTextBox(txtTel, rowData);
            base.SetRowDataToTextBox(txtFAX, rowData);
            base.SetRowDataToTextBox(txtDaihyousyaShimei, rowData);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
        }


        public override void SetFocusToFirstControl() {
        }
    }
}
