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
    partial class DaikubunRow : AbstractDBGridRow
    {
        public DaikubunRow() {
            InitializeComponent();

            SetDefaultHandlersToControls();
            SetDefaultIndicator();
            btnDelete.Click += base.DefaultHandlerRemoveRowButtonClicked;
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            base.SetRowDataToTextBox(txtDaikubunCode, rowData);
            base.SetRowDataToTextBox(txtName, rowData);
            base.SetRowDataToMTCombo(cmbParent, rowData);

            bool editable = rowData.GetBool("editable", false);//(rowData.GetLong("id", ((int)models.constants.MTKamokuKubun.ReservedMax) + 1)
                            //        > (long)models.constants.MTKamokuKubun.ReservedMax);
            txtDaikubunCode.Enabled = editable;
            txtName.Enabled = editable;
            cmbParent.Enabled = editable;
            btnDelete.Enabled = editable;
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase db) {
            cmbParent.InitRowsWithMTKamokuKubunWithoutParent((db as models.db.KaikeiDatabase).MTKamokuKubun, (int)models.constants.MTKamokuKubunHierarchy.Kubun);
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            cmbParent.CopyRows((originalRow as DaikubunRow).cmbParent);
        }

        public override void SetFocusToFirstControl() {
            txtDaikubunCode.Select();
        }
    }
}
