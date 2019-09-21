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
    ///  BalanceSheetComment重要な会計方針の変更
    /// </summary>
    partial class BSCKaikeiHoushinRow : AbstractDBGridRow
    {
        public BSCKaikeiHoushinRow() {
            InitializeComponent();

            btnRemoveRow.Click += base.DefaultHandlerRemoveRowButtonClicked;
            SetDefaultHandlersToControls();

            SetDefaultIndicator();
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row row_data) {
            txtSeiriBangou.Text = row_data.GetStr("seiri_bangou");
            txtKoumoku.Text = row_data.GetStr("koumoku_mei");
            txtNaiyou.Text = row_data.GetStr("naiyou");
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase db) {
        }


        public override void SetFocusToFirstControl() {
            txtSeiriBangou.Select();
        }
    }
}
