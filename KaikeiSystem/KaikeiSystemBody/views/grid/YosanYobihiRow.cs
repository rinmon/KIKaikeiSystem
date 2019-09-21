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
    partial class YosanYobihiRow : AbstractDBGridRow
    {
        public event Action<object, EventArgs> CheckDataButtonClicked;


        public YosanYobihiRow() {
            InitializeComponent();

            base.penForBottomLine = null;
            base.penForLeftLine = null;

            SetDefaultHandlersToControls();
        }

        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            amountYobihi.AmountStr = rowData.GetStr("yobihi");
            amountZenkiZandaka.AmountStr = rowData.GetStr("zenkimatsu_shiharai_shikin_zandaka");
            dateCreated.Date = rowData.GetDate("create_date");
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
        }


        public override void SetFocusToFirstControl() {
            amountYobihi.Select();
        }

        private void btnCheckData_Click(object sender, EventArgs e) {
            CheckDataButtonClicked(sender, e);
        }
    }
}
