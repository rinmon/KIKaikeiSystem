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
    partial class YosanKamokuPopup : Form
    {
        public event Action PopupClosed;

        public YosanKamokuPopup() {
            InitializeComponent();

            this.FormClosed += (s, e) => PopupClosed();
        }


        public grid.YosanKamokuGrid Grid {
            get { return grid; }
        }

        public long SumAmount {
            get {
                return amountSum.Amount;
            }
            set {
                amountSum.Amount = value;
            }
        }
    }
}
