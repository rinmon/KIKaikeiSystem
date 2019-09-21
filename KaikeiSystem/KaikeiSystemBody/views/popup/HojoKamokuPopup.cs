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
    partial class HojoKamokuPopup : Form, IMTGridPopup
    {
        public event Action RowClicked;
        public event Action PopupClosed;
        public event Action<string> ChangeSortKey = delegate { };
        public event Action<string> ChangeFirstChar = delegate { };

        public event Action AddHojoKamokuButtonClicked;
        public event Action CloseButtonClicked;

        public HojoKamokuPopup() {
            InitializeComponent();
            grid.RowHeadersWidth = 24;
        }


        public void ShowPopup(Form owner) {
            base.Show(owner);
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


        public string SelectedKey {
            get {
                if (grid.SelectedRows.Count >= 1) {
                    return grid.SelectedRows[0].Cells[0].Value.ToString();
                }
                return null;
            }
        }

        public void ClearFirstCharList() {
        }

        public void AddFirstCharListItem(string key) {
        }

        public void ChangeSortKeySelection(string key) {
        }


        private void btnClose_Click(object sender, EventArgs e) {
            if (this.CloseButtonClicked != null) {
                this.CloseButtonClicked();
            }
        }

        private void KamokuPopup_FormClosed(object sender, FormClosedEventArgs e) {
            if (PopupClosed != null) {
                PopupClosed();
            }
        }

        private void gridKamoku_Click(object sender, EventArgs e) {
            if (RowClicked != null) {
                RowClicked();
            }
        }

        private void btnHojoKamoku_Click(object sender, EventArgs e) {
            if (AddHojoKamokuButtonClicked != null) {
                AddHojoKamokuButtonClicked();
            }
        }
    }
}
