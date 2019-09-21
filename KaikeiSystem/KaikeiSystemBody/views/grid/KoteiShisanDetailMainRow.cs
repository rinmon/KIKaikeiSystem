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
    partial class KoteiShisanDetailMainRow : AbstractDBGridRow
    {
        public KoteiShisanDetailMainRow() {
            InitializeComponent();

            txtId.FormatText += delegate(string value) {
                if (value == null || value.Length == 0) {
                    return KaikeiSystemBody.Properties.Resources.CaptionNewRowId;
                }
                else {
                    return value;
                }
            };

            penForBottomLine = null;
            penForLeftLine = null;

            SetDefaultHandlersToControls();
        }

        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            base.SetRowDataToFormattedValueTextBox(txtId, rowData);
            base.SetRowDataToTextBox(txtSuuryou, rowData);
            base.SetRowDataToTextBox(txtName, rowData);
            base.SetRowDataToMTCombo(cmbKamokuKubun, rowData);
            base.SetRowDataToMTCombo(cmbKaikeiKubun, rowData);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
            cmbKaikeiKubun.InitRowsWithMTKaikeiKubun((aDB as models.db.KaikeiDatabase).MTKaikeiKubun, true);
            cmbKamokuKubun.InitRowsWithMTKamokuKubunWithParentFilterByKubun((aDB as models.db.KaikeiDatabase).MTKamokuKubun, (int)models.constants.MTKamokuKubun.Shisan);
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
        }


        public override void SetFocusToFirstControl() {
        }
    }
}
