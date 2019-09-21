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
    partial class TorihikiKubunForm : Form
    {
        public event Action MenuButtonClicked;

        public TorihikiKubunForm() {
            InitializeComponent();

            btnMenu.Click += (s, e) => MenuButtonClicked();
        }


        public grid.TorihikiKubunGrid Grid {
            get { return grid; }
        }
    }
}
