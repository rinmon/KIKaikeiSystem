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
    partial class YosanKamokuKubunRow : AbstractDBGridRow
    {
        private models.db.KaikeiDatabase db;

        public YosanKamokuKubunRow() {
            InitializeComponent();

            SetDefaultHandlersToControls();
            SetDefaultIndicator();

            db = null;
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            models.db.Row kamokuRow = db.MTKanjouKamoku.GetRowFromKamokuKubun(rowData.GetLong("kamoku_kubun_id", -1));
            if (kamokuRow != null) {
                txtKamokuCode.Text = kamokuRow.GetStr("kamoku_code");
            }
            else{
                txtKamokuCode.Text = "";
            }

            txtKaikeiKubun.Text = rowData.GetMasterStr("kaikei_kubun", "name", "", db.MTKaikeiKubun);
            txtKamokuKubun.Text = rowData.GetMasterStr("kamoku_kubun_id", "name", "", db.MTKamokuKubun);
            amountYosan.AmountStr = rowData.GetStr("yosan");
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
            db = aDB as models.db.KaikeiDatabase;
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            db = (originalRow as YosanKamokuKubunRow).db;
        }


        public override void SetFocusToFirstControl() {
            txtKaikeiKubun.Select();
        }
    }
}
