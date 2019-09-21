using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.views.popup
{
    partial class TekiyouPopup : Form, IMTGridPopup
    {
        public event Action RowClicked;
        public event Action PopupClosed;
        public event Action<string> ChangeSortKey;
        public event Action<string> ChangeFirstChar;

        public event Action AddTekiyouButtonClicked;
        public event Action CloseButtonClicked;

        public TekiyouPopup() {
            InitializeComponent();
            grid.RowHeadersWidth = 24;
        }


        public void ShowPopup(Form owner) {
            base.Show(owner);
        }


        public string SelectedKey {
            get {
                if (grid.SelectedRows.Count >= 1 && grid.SelectedRows[0].Cells[0].Value != null) {
                    return grid.SelectedRows[0].Cells[0].Value.ToString();
                }
                return null;
            }
        }


        public void ClearGrid() {
            grid.Rows.Clear();
        }

        public void AddGridRow(string code, string kamoku){
            grid.Rows.Add();

            int i = grid.Rows.Count - 1;
            grid.Rows[i].Cells[0].Value = code;
            grid.Rows[i].Cells[1].Value = kamoku;
        }


        public void ClearFirstCharList() {
            cmbFirstChar.Items.Clear();
        }

        public void AddFirstCharListItem(string key) {
            cmbFirstChar.Items.Add(key);
        }

        public void ChangeSortKeySelection(string key) {
            if (key == radioSortTypeAlphabet.Tag as string && !radioSortTypeAlphabet.Checked) {
                radioSortTypeAlphabet.Select();
            }
            if (key == radioSortTypeCode.Tag as string && !radioSortTypeCode.Checked) {
                radioSortTypeCode.Select();
            }
            cmbFirstChar.Text = "";
        }


        private void btnClose_Click(object sender, EventArgs e) {
            if (this.CloseButtonClicked != null) {
                this.CloseButtonClicked();
            }
        }

        private void cmbFirstChar_SelectedIndexChanged(object sender, EventArgs e) {
            if (ChangeFirstChar != null) {
                ChangeFirstChar(cmbFirstChar.Text);
            }
        }

        private void btnAddTekiyou_Click(object sender, EventArgs e) {
            if (AddTekiyouButtonClicked != null) {
                AddTekiyouButtonClicked();
            }
        }

        private void radioSortType_CheckedChanged(object sender, EventArgs e) {
            if (ChangeSortKey != null) {
                ChangeSortKey((sender as Control).Tag as string);
            }
        }

        private void TekiyouPopup_FormClosed(object sender, FormClosedEventArgs e) {
            if (PopupClosed != null) {
                PopupClosed();
            }
        }

        private void grid_Click(object sender, EventArgs e) {
            if (RowClicked != null) {
                RowClicked();
            }
        }
    }
}
