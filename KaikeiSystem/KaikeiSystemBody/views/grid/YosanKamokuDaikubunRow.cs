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
    partial class YosanKamokuDaikubunRow : AbstractDBGridRow
    {
        private models.db.KaikeiDatabase db;

        public YosanKamokuDaikubunRow() {
            InitializeComponent();

            SetDefaultHandlersToControls();
            SetDefaultIndicator();

            db = null;
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            txtKaikeiKubun.Text = rowData.GetMasterStr("kaikei_kubun", "name", "", db.MTKaikeiKubun);
            txtKamokuKubun.Text = rowData.GetMasterStr("kamoku_kubun_id", "name", "", db.MTKamokuKubun);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
            db = aDB as models.db.KaikeiDatabase;
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            db = (originalRow as YosanKamokuDaikubunRow).db;
        }


        public override void SetFocusToFirstControl() {
            txtKaikeiKubun.Select();
        }
    }
}
