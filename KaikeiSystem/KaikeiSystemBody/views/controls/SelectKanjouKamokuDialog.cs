using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.views.controls
{
    partial class SelectKanjouKamokuDialog : Form
    {
        private DialogResult dialogResult;

        public int JigyouKamokuKubunId {
            get {
                if (cmbJigyou.SelectedKey != null) {
                    return (int)(long)cmbJigyou.SelectedKey;
                }
                else {
                    return -1;
                }
            }
        }

        public int TaisyakuKamokuKubunId {
            get {
                if (cmbTaisyaku.SelectedKey != null) {
                    return (int)(long)cmbTaisyaku.SelectedKey;
                }
                else {
                    return -1;
                }
            }
        }

        public int ShikinKamokuKubunId {
            get {
                if (cmbShikin.SelectedKey != null) {
                    return (int)(long)cmbShikin.SelectedKey;
                }
                else {
                    return -1;
                }
            }
        }

        public System.Windows.Forms.DialogResult ShowDialog(Form owner, models.Context context) {
            cmbJigyou.InitRowsWithMTKamokuKubunWithParent(context.KaikeiDatabase.MTKamokuKubun, (int)models.constants.MTKamokuKubunHierarchy.Daikubun);
            cmbTaisyaku.InitRowsWithMTKamokuKubunWithParent(context.KaikeiDatabase.MTKamokuKubun, (int)models.constants.MTKamokuKubunHierarchy.Daikubun);
            cmbShikin.InitRowsWithMTKamokuKubunWithParent(context.KaikeiDatabase.MTKamokuKubun, (int)models.constants.MTKamokuKubunHierarchy.Daikubun);

            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(
                owner.Location.X + (owner.Size.Width - this.Size.Width) / 2,
                owner.Location.Y + (owner.Size.Height - this.Size.Height) / 2
                );

            ShowDialog(owner);

            return dialogResult;
        }

        public SelectKanjouKamokuDialog() {
            InitializeComponent();
            dialogResult = System.Windows.Forms.DialogResult.Cancel;
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            dialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
