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
    partial class MenuForm : Form
    {
        // txtCommandに数値以外を入れた場合、-1で呼び出す
        public event Action<int> SwitchForm;


        public MenuForm()
        {
            InitializeComponent();
        }


        public void SetInfo(string houjinMei, string dbPath, string version, string dbVersion){
            lblHoujinMei.Text = houjinMei;
            lblVersion.Text = "System ver." + version + "\n" + "DB ver." + dbVersion;
        }

        private void SwichFormButton_Click(object sender, EventArgs e)
        {
            if (SwitchForm != null) {
                SwitchForm(int.Parse((sender as Control).Tag as string));
            }
        }

        private void txtCommand_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                int formNo = helper.Converter.ObjToInt(txtCommand.Text, -1);
                Control btn = SearchTagNo(this, formNo);
                if (btn != null && btn.Enabled == true && btn.Visible == true) {
                    SwitchForm(formNo);
                }
                else {
                    SwitchForm(-1);
                }
            }
        }


        private Control SearchTagNo(Control parent, int tagNo) {
            foreach (Control ctrl in parent.Controls) {
                if (helper.Converter.ObjToInt(ctrl.Tag, -2) == tagNo) {
                    return ctrl;
                }

                Control a = SearchTagNo(ctrl, tagNo);
                if (a != null) {
                    return a;
                }
            }
            return null;
        }
    }
}
