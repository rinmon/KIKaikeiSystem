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
    partial class IkkatsuTourokuPopup : Form
    {
        public event Action SelectKubunButtonClicked;
        public event Action SelectAllButtonClicked;
        public event Action UnselectAllButtonClicked;
        public event Action CloseButtonClicked;
        public event Action TourokuButtonClicked;

        public IkkatsuTourokuPopup() {
            InitializeComponent();

            radioCommentPrefix.Checked = true;
            chkModifyComment.Checked = true;
            chkModifyComment.Checked = false;

            btnSelectKubun.Click += (s, e) => SelectKubunButtonClicked();
            btnSelectAll.Click += (s, e) => SelectAllButtonClicked();
            btnUnselectAll.Click += (s, e) => UnselectAllButtonClicked();
            btnClose.Click += (s, e) => CloseButtonClicked();
            btnTouroku.Click += (s, e) => TourokuButtonClicked();

            dateKihyoubi.SetStatusMessage += (msg) => lblKihyoubiInfo.Text = msg;
        }


        public grid.PanelGrid<grid.IkkatsuSyoriRow> Grid {
            get { return this.grid; }
        }


        public DateTime? TargetDate {
            get {
                return dateKihyoubi.Date;
            }
        }

        public string TargetGengou {
            set {
                dateKihyoubi.GengouStr = value;
            }
        }

        public string SelectedKubun {
            get {
                return cmbShiteiKubun.Text;
            }
        }

        public string AddTextForComment {
            get {
                return txtAddTextForComment.Text;
            }
        }

        public bool CommentPrefixIsEnabled {
            get {
                return chkModifyComment.Checked && radioCommentPrefix.Checked;
            }
        }

        public bool CommentSuffixIsEnabled {
            get {
                return chkModifyComment.Checked && radioCommentSuffix.Checked;
            }
        }

        public void AddTsuikaKubun(string kubun) {
            cmbShiteiKubun.Items.Add(kubun);
        }

        // events
        private void chkModifyComment_CheckedChanged(object sender, EventArgs e) {
            txtAddTextForComment.Enabled = chkModifyComment.Checked;
            radioCommentPrefix.Enabled = chkModifyComment.Checked;
            radioCommentSuffix.Enabled = chkModifyComment.Checked;
        }
        
        private void control_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
            }
        }

        private void Control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            var target = sender as System.Windows.Forms.Control;

            if (e.KeyCode == Keys.Enter && !(sender is Button) && !e.Shift) {
                this.SelectNextControl(target, true, true, true, true);
                e.IsInputKey = true;
            }
        }
    }
}
