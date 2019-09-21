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
    partial class TekiyouForm : Form
    {
        public event Action MenuButtonClicked;
        public event Action NewButtonClicked;

        public TekiyouForm() {
            InitializeComponent();

            btnMenu.Click += (s, e) => MenuButtonClicked();
            btnNew.Click += (s, e) => NewButtonClicked();
        }

        public grid.TekiyouGrid Grid {
            get { return grid; }
        }

        private void btnDummyDelete_Click(object sender, EventArgs e) {
            if (grid.SelectedRowControl != null) {
                grid.SelectedRowControl.FireRemoveEvent();
            }
        }
    }
}
