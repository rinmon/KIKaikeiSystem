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
    ///  BalanceSheetComment減価償却率
    /// </summary>
    partial class BSCGenkaRow : AbstractDBGridRow
    {
        public BSCGenkaRow() {
            InitializeComponent();

            inSetRowDataFunction = false;
            modifingControlValue = false;

            btnRemoveRow.Click += base.DefaultHandlerRemoveRowButtonClicked;
            SetDefaultHandlersToControls();

            SetDefaultIndicator();
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row row_data) {
            cmbKaikeiKubun.SelectRowByKeyValue(row_data.GetLong("kaikei_kubun", -1));
            amountGenkaSyoukyakuRuikei.AmountStr = row_data.GetStr("genka_baikyaku_ruikei");
            amountTyousyuuHunouKin.AmountStr = row_data.GetStr("tyousyuu_hunou_kin");
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase db) {
            cmbKaikeiKubun.InitRowsWithMTKaikeiKubun((db as models.db.KaikeiDatabase).MTKaikeiKubun, true); 
        }

        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            cmbKaikeiKubun.CopyRows((originalRow as BSCGenkaRow).cmbKaikeiKubun);
        }

        public override void SetFocusToFirstControl() {
            cmbKaikeiKubun.Select();
        }
    }
}
