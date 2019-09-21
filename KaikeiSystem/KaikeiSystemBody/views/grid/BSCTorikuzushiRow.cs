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
    ///  BalanceSheetComment基本金・積立金の取り崩し
    /// </summary>
    partial class BSCTorikuzushiRow : AbstractDBGridRow
    {
        public BSCTorikuzushiRow() {
            InitializeComponent();

            btnRemoveRow.Click += base.DefaultHandlerRemoveRowButtonClicked;
            SetDefaultHandlersToControls();

            SetDefaultIndicator();
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row row_data) {
            cmbKaikeiKubun.SelectRowByKeyValue(row_data.GetLong("kaikei_kubun", -1));
            txtNaiyou.Text = row_data.GetStr("naiyou");
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase db) {
            cmbKaikeiKubun.InitRowsWithMTKaikeiKubun((db as models.db.KaikeiDatabase).MTKaikeiKubun, true);
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            cmbKaikeiKubun.CopyRows((originalRow as BSCTorikuzushiRow).cmbKaikeiKubun);
        }


        public override void SetFocusToFirstControl() {
            cmbKaikeiKubun.Select();
        }
    }
}
