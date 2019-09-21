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
    partial class DenpyouBangouSeiriPopup : Form
    {
        public System.EventHandler CloseButtonClicked;
        public System.EventHandler ReturnToSubfunctionPopupButtonClicked;
        public System.EventHandler OrderByKihyoubiAndNoButtonClicked;
        public System.EventHandler OrderByKaikeiKubunAndKihyoubiAndNoButtonClicked;

        public DenpyouBangouSeiriPopup() {
            InitializeComponent();
        }


        public views.controls.DateInputPanel TargetDateInput {
            get {
                return dateTarget;
            }
        }

        public void InitEvents() {
            btnClose.Click += CloseButtonClicked;
            btnReturnToSubfunctionPopup.Click += ReturnToSubfunctionPopupButtonClicked;
            btnOrderByKihyoubiAndNo.Click += OrderByKihyoubiAndNoButtonClicked;
            btnOrderByKaikeiKubunAndKihyoubiAndNo.Click += OrderByKaikeiKubunAndKihyoubiAndNoButtonClicked;
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
