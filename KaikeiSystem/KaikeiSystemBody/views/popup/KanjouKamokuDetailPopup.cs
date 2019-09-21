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
    partial class KanjouKamokuDetailPopup : Form
    {
        public event Action PopupClosed;
        public event Action CloseButtonClicked;
        public event Action<object> AddSubButtonClicked;  // AddSubButtonClicked(object sender)

        public KanjouKamokuDetailPopup() {
            InitializeComponent();

            this.FormClosed += (s, e) => PopupClosed();
            btnClose.Click += (s, e) => CloseButtonClicked();

            foreach (var row in Grid.AllRowControls()) {
                row.AddSubButtonClicked += (sender) => AddSubButtonClicked(sender);
            }
        }


        public grid.HojoKamokuGrid Grid {
            get { return hojoKamokuGrid1; }
        }


        public grid.KanjouKamokuDetailRow KanjouKamokuDetailRow {
            get { return kanjouKamokuDetailRow; }
        }
    }
}
