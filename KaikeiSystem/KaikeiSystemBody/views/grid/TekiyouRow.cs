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
    partial class TekiyouRow : AbstractDBGridRow
    {
        private string furigana;

        public TekiyouRow() {
            InitializeComponent();

            SetDefaultHandlersToControls();
            SetDefaultIndicator();

            btnDelete.Click += base.DefaultHandlerRemoveRowButtonClicked;
            txtTekiyouMei.Enter += (s, e) => furigana = "";
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            base.SetRowDataToTextBox(txtTekiyouCode, rowData);
            base.SetRowDataToTextBox(txtTekiyouMei, rowData);
            base.SetRowDataToTextBox(txtTekiyouYomi, rowData);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase db) {
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
        }

        public override void SetFocusToFirstControl() {
            txtTekiyouCode.Select();
        }

        private void txtTekiyouMei_CompositionCompleted(object sender, controls.CompositionCompletedEventArgs e) {
            furigana += e.Hiragana;
            txtTekiyouYomi.Text = furigana;
            //base.SetControlValue("tekiyou_yomi", e.Hiragana);
        }
    }
}
