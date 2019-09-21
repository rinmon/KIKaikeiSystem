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
    partial class DaikubunForm : Form
    {
        public event Action MenuButtonClicked;

        public DaikubunForm() {
            InitializeComponent();

            btnMenu.Click += (s, e) => MenuButtonClicked();
        }


        public grid.DaikubunGrid Grid {
            get { return grid; }
        }
    }
}
