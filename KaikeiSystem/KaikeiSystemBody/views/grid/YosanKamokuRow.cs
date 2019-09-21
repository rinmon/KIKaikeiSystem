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
    partial class YosanKamokuRow : AbstractDBGridRow
    {
        private models.db.KaikeiDatabase db;

        public int DaikubunId { get; set; }


        public YosanKamokuRow() {
            InitializeComponent();

            cmbKamoku.SelectedValueChanged += delegate(object sender, EventArgs e) {
                SetKamokuCodeText();
            };

            btnDelete.Click += base.DefaultHandlerRemoveRowButtonClicked;

            SetDefaultHandlersToControls();
            SetDefaultIndicator();

            db = null;
        }


        private void SetKamokuCodeText() {
            if (cmbKamoku.SelectedRow != null) {
                txtKamokuCode.Text = cmbKamoku.SelectedRow.Cells(0).ToString();
            }
            else {
                txtKamokuCode.Text = "";
            }
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            cmbKeiriKubun.SelectRowByKeyValue(rowData.GetLong("keiri_kubun", -1));
            cmbKamoku.SelectRowByKeyValue(rowData.GetLong("kamoku_id", 0));
            SetKamokuCodeText();
            amountYosan.AmountStr = rowData.GetStr("yosan");
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
            db = aDB as models.db.KaikeiDatabase;
            cmbKeiriKubun.InitRowsWithMTHoujinShisetsu(db.MTHoujinShisetsu, false);
            cmbKamoku.InitRowsWithMTKamokuFilterByMTDaikubun2(db.MTKamoku, db.MTDaikubun, DaikubunId);
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            db = (originalRow as YosanKamokuRow).db;
            cmbKeiriKubun.CopyRows((originalRow as YosanKamokuRow).cmbKeiriKubun);
            cmbKamoku.CopyRows((originalRow as YosanKamokuRow).cmbKamoku);
        }


        public override void SetFocusToFirstControl() {
            cmbKamoku.Select();
        }
    }
}
