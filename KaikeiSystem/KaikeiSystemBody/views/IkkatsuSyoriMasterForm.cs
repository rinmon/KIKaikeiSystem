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
    partial class IkkatsuSyoriMasterForm : Form
    {

        public event Action KaikeiDenpyouButtonClicked;
        public event Action MenuButtonClicked;
        public event Action NewButtonClicked;
        public event Action KamokuButtonClicked;
        public event Action TekiyouButtonClicked;

        public IkkatsuSyoriMasterForm() {
            InitializeComponent();

            btnKaikeiDenpyou.Click += (s, e) => KaikeiDenpyouButtonClicked();
            btnMenu.Click += (s, e) => MenuButtonClicked();
            btnNew.Click += (s, e) => NewButtonClicked();
            btnKamoku.Click += (s, e) => KamokuButtonClicked();
            btnTekiyou.Click += (s, e) => TekiyouButtonClicked();
            btnDummyDelete.Click += delegate(object sender, EventArgs e) {
                if (grid.SelectedRowControl != null) {
                    grid.SelectedRowControl.FireRemoveEvent();
                }
            };
        }


        public grid.IkkatsuSyoriMasterGrid Grid {
            get { return grid; }
        }

        private void IkkatsuSyoriMasterForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, this.Size.Height + this.statusStrip1.Size.Height);
        }
    }
}
