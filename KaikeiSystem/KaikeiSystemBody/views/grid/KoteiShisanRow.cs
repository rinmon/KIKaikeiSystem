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
    partial class KoteiShisanRow : AbstractDBGridRow
    {
        private models.db.KaikeiDatabase db;


        public event Action DetailButtonClicked;


        public KoteiShisanRow() {
            InitializeComponent();

            SetDefaultHandlersToControls();
            SetDefaultIndicator();

            btnDetail.Click += DetailButtonClickedHandler;

            db = null;
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            base.SetRowDataToMTCombo(cmbKaikeiKubun, rowData);
            base.SetRowDataToMTCombo(cmbKamoku, rowData);
            base.SetRowDataToTextBox(txtName, rowData);
            base.SetRowDataToTextBox(txtSuuryou, rowData);
            base.SetRowDataToTextBox(txtTaikyuuNennsuu, rowData);
            base.SetRowDataToAmount(amountSyutokuKakaku, rowData);
            base.SetRowDataToDateInputPanel(dateSyutokuNenngappi, rowData);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
            db = aDB as models.db.KaikeiDatabase;
            cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, true);
            cmbKamoku.InitRowsWithMTKamokuKubunWithParentFilterByKubun(db.MTKamokuKubun, (int)models.constants.MTKamokuKubun.Shisan);
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            db = (originalRow as KoteiShisanRow).db;
            cmbKamoku.CopyRows((originalRow as KoteiShisanRow).cmbKamoku);
            cmbKaikeiKubun.CopyRows((originalRow as KoteiShisanRow).cmbKaikeiKubun);
        }


        public override void SetFocusToFirstControl() {
            btnDetail.Select();
        }


        private void DetailButtonClickedHandler(object sender, EventArgs e) {
            DetailButtonClicked();
        }
    }
}
