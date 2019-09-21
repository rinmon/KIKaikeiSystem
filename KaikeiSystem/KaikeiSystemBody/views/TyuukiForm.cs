using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.views
{
    partial class TyuukiForm : Form
    {
        public delegate void OnTyuukiTextChangedDelegate(string columnName, string value);

        public event Action CloseButtonClicked;
        public event Action ExecButtonClicked;
        public event OnTyuukiTextChangedDelegate TyuukiTextChanged;

        private models.db.KaikeiDatabase db;

        
        public grid.Tyuuki8Grid Tyuuki8Grid {
            get { return tyuuki8Grid; }
        }

        public grid.Tyuuki10Grid Tyuuki10Grid {
            get { return tyuuki10Grid; }
        }

        public grid.Tyuuki11Grid Tyuuki11Grid {
            get { return tyuuki11Grid; }
        }

        public DateTime? InputDate {
            get {
                return dateInput.Date;
            }
        }


        public int KaikeiKubun {
            get {
                if (cmbKaikeiKubun.Enabled == true) {
                    return (int)cmbKaikeiKubun.SelectedKeyAsInt;
                }
                else {
                    return db.MTKaikeiKubun.RootNodeId;
                }
            }
        }

        public TyuukiForm() {
            InitializeComponent();
            radioKaikeiKubunAll_CheckedChanged(null, null);
        }

        public void SetDB(models.db.KaikeiDatabase db_) {
            db = db_;

            cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, false);
            cmbKaikeiKubun.SelectedIndex = 0;
        }

        public void SetTyuukiRow(models.db.Row tyuukiRow) {
            SetTextBoxValue(txtTyuuki1, tyuukiRow);
            SetTextBoxValue(txtTyuuki2, tyuukiRow);
            SetTextBoxValue(txtTyuuki3, tyuukiRow);
            SetTextBoxValue(txtTyuuki4, tyuukiRow);
            SetTextBoxValue(txtTyuuki5, tyuukiRow);
            SetTextBoxValue(txtTyuuki7, tyuukiRow);
            SetTextBoxValue(txtTyuuki12, tyuukiRow);
            SetTextBoxValue(txtTyuuki13, tyuukiRow);
            SetTextBoxValue(txtTyuuki14, tyuukiRow);
            SetTextBoxValue(txtTyuuki15, tyuukiRow);
        }

        private void SetTextBoxValue(TextBox txtBox, models.db.Row tyuukiRow) {
            if (tyuukiRow == null) {
                txtBox.Text = "";
            }
            else {
                txtBox.Text = tyuukiRow.GetStr(txtBox.Tag as string);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            CloseButtonClicked();
        }


        private void btnExec_Click(object sender, EventArgs e) {
            ExecButtonClicked();
        }

        private void txtTyuuki_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if(TyuukiTextChanged != null){
                TyuukiTextChanged(textBox.Tag as string, textBox.Text);
            }
        }

        private void radioKaikeiKubunAll_CheckedChanged(object sender, EventArgs e) {
            cmbKaikeiKubun.Enabled = false;
        }

        private void radioKaikeiKubunSelect_CheckedChanged(object sender, EventArgs e) {
            cmbKaikeiKubun.Enabled = true;
        }
    }
}
