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
    partial class KanjouKamokuForm : Form
    {
        public event Action MenuButtonClicked;
        public event Action<object> DetailButtonClicked;  // DetailButtonClicked(object sender)
        public event Action AddButtonClicked;

        public KanjouKamokuForm() {
            InitializeComponent();

            btnMenu.Click += (s, e) => MenuButtonClicked();
            btnAdd.Click += (s, e) => AddButtonClicked();

            foreach (var row in grid.AllRowControls()) {
                row.ShowDetailButtonClicked += (sender) => DetailButtonClicked(sender);
            }
        }

        public grid.KanjouKamokuGrid Grid {
            get { return grid; }
        }
    }
}
