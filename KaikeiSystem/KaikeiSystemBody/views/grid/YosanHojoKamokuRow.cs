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
    partial class YosanHojoKamokuRow : AbstractDBGridRow
    {
        private models.db.KaikeiDatabase db;

        public int ParentKamokuId { get; set; }


        public YosanHojoKamokuRow() {
            InitializeComponent();

            btnDelete.Click += base.DefaultHandlerRemoveRowButtonClicked;
            SetDefaultHandlersToControls();

            SetDefaultIndicator();

            db = null;
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            cmbKeiriKubun.SelectRowByKeyValue(rowData.GetLong("keiri_kubun", -1));
            cmbHojoKamoku.SelectRowByKeyValue(rowData.GetLong("hojo_id", 0));
            amountYosan.AmountStr = rowData.GetStr("yosan");
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
            db = aDB as models.db.KaikeiDatabase;

            cmbKeiriKubun.InitRowsWithMTHoujinShisetsu(db.MTHoujinShisetsu, false);
            cmbHojoKamoku.InitRowsWithMTHojoKamokuWhereKeyIsId(db.MTHojoKamoku, ParentKamokuId);
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            db = (originalRow as YosanHojoKamokuRow).db;
            cmbKeiriKubun.CopyRows((originalRow as YosanHojoKamokuRow).cmbKeiriKubun);
            cmbHojoKamoku.CopyRows((originalRow as YosanHojoKamokuRow).cmbHojoKamoku);
        }


        public override void SetFocusToFirstControl() {
            cmbHojoKamoku.Select();
        }
    }
}
