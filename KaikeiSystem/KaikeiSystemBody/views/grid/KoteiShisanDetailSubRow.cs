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
    partial class KoteiShisanDetailSubRow : AbstractDBGridRow
    {
        public KoteiShisanDetailSubRow() {
            InitializeComponent();

            penForBottomLine = null;
            penForLeftLine = null;

            SetDefaultHandlersToControls();

            txtSyoukyakuRitu.FormatText += delegate(string text) {
                double value;
                if (double.TryParse(text, out value)) {
                    return value.ToString("#0.000");
                }
                return text;
            };
            txtZanzonWariai.FormatText += delegate(string text) {
                double value;
                if (double.TryParse(text, out value)) {
                    return value.ToString("#0.0");
                }
                return text;
            };

            dateSyutokubi.GengouStr = "R";
            dateGensyoubi.GengouStr = "R";
        }

        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            base.SetRowDataToDateInputPanel(dateSyutokubi, rowData);
            base.SetRowDataToDateInputPanel(dateGensyoubi, rowData);
            base.SetRowDataToAmount(amountSyutokuKagaku, rowData);
            base.SetRowDataToAmount(amountKisyuSyoukyaku, rowData);
            base.SetRowDataToMTCombo(cmbSyoukyakuHouhou, rowData);
            base.SetRowDataToTextBox(txtTaikyuuNennsuu, rowData);
            base.SetRowDataToFormattedValueTextBox(txtSyoukyakuRitu, rowData);
            base.SetRowDataToFormattedValueTextBox(txtZanzonWariai, rowData);
            base.SetRowDataToAmount(amountZanzonKagaku, rowData);
            base.SetRowDataToMTCombo(cmbSyoukyakuKahi, rowData);
            base.SetRowDataToTextBox(txtBikou, rowData);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
            cmbSyoukyakuKahi.InitRowsWithMTSyoukyakuKahi((aDB as models.db.KaikeiDatabase).MTSyoukyakuKahi);
            cmbSyoukyakuHouhou.InitRowsWithMTSyoukyakuHouhou((aDB as models.db.KaikeiDatabase).MTSyoukyakuHouhou);
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
        }


        public override void SetFocusToFirstControl() {
        }
    }
}
