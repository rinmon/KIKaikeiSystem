using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KaikeiSystemBody.views
{
    partial class RootMenuForm : Form
    {
        public event Action MargeDatabaseKanjouKamokuTableButtonClicked;
        public event Action MargeDatabaseDenpyouButtonClicked;
        public event Action CloseButtonClicked;


        public string DBFilePath {
            get {
                return txtMargeDBFilePath.Text;
            }
        }

        public RootMenuForm() {
            InitializeComponent();
            openDBFileDialog.Multiselect = false;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            CloseButtonClicked();
        }

        private void btnMargeDBKanjouKamoku_Click(object sender, EventArgs e) {
            MargeDatabaseKanjouKamokuTableButtonClicked();
        }

        private void btnShowOpenDBFileDlg_Click(object sender, EventArgs e) {
            DialogResult dlgResult = openDBFileDialog.ShowDialog();

            if (dlgResult == System.Windows.Forms.DialogResult.OK) {
                txtMargeDBFilePath.Text = openDBFileDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            MargeDatabaseDenpyouButtonClicked();
        }
    }
}
