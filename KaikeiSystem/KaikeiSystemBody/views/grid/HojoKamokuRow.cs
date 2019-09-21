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
    partial class HojoKamokuRow : AbstractDBGridRow
    {
        private models.db.KaikeiDatabase db;

        public event Action<object> AddSubButtonClicked;  // AddSubButtonClicked(object sender)

        public HojoKamokuRow() {
            InitializeComponent();

            SetDefaultHandlersToControls();
            SetDefaultIndicator();

            db = null;

            btnAddHojoKamoku.Click += delegate(object sender, EventArgs e) {
                if (!IsNewRow) {
                    AddSubButtonClicked(this);
                }
            };
            btnDelete.Click += base.DefaultHandlerRemoveRowButtonClicked;
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            base.SetRowDataToTextBox(txtKamokuCode, rowData);
            base.SetRowDataToTextBox(txtKamoku, rowData);
            base.SetRowDataToTextBox(txtJigyouKamokuKubun, rowData);
            base.SetRowDataToTextBox(txtTaisyakuKamokuKubun, rowData);
            base.SetRowDataToTextBox(txtShikinKamokuKubun, rowData);
            base.SetRowDataToCheckBox(chkPrintTarget, rowData);
            base.SetRowDataToMTCombo(cmbKaikeiKubun, rowData);

            txtJigyouKamokuKubun.Enabled = (rowData.GetLong("jigyou_kamoku_kubun_id", -1) != -1);
            txtTaisyakuKamokuKubun.Enabled = (rowData.GetLong("taisyaku_kamoku_kubun_id", -1) != -1);
            txtShikinKamokuKubun.Enabled = (rowData.GetLong("shikin_kamoku_kubun_id", -1) != -1);

            if (rowData.GetBool("has_child", false)) {
                btnDelete.Enabled = false;
            }
            else {
                btnDelete.Enabled = true;
            }

            int hierarchy = (int)rowData.GetLong("hierarchy", -1);
            if (hierarchy == (int)models.constants.MTKanjouKamokuHierarchy.HojoKamoku) {
                btnAddHojoKamoku.Enabled = false;
                chkPrintTarget.Enabled = false;
                pictChild.Show();

                txtKamoku.Bounds = new Rectangle(
                    pictChild.Location.X + pictChild.Size.Width,
                    txtKamoku.Location.Y,
                    txtJigyouKamokuKubun.Size.Width - pictChild.Size.Width,
                    txtJigyouKamokuKubun.Size.Height
                );
                    
            }
            else {
                btnAddHojoKamoku.Enabled = true;
                chkPrintTarget.Enabled = true;
                pictChild.Hide();

                txtKamoku.Bounds = new Rectangle(
                    pictChild.Location.X,
                    txtKamoku.Location.Y,
                    txtJigyouKamokuKubun.Size.Width,
                    txtJigyouKamokuKubun.Size.Height
                );
            }
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
            db = aDB as models.db.KaikeiDatabase;
            cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, onlyLeafNode: false);
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            db = (originalRow as HojoKamokuRow).db;
            cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, onlyLeafNode: false);
        }


        public override void SetFocusToFirstControl() {
            txtKamokuCode.Select();
        }
    }
}
