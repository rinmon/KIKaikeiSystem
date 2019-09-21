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
    partial class KaikeiTanniForm : Form
    {
        public event Action MenuButtonClicked;

        public KaikeiTanniForm() {
            InitializeComponent();

            btnMenu.Click += (s, e) => MenuButtonClicked();
        }


        public grid.KaikeiTanniGrid Grid {
            get { return grid; }
        }
    }
}
