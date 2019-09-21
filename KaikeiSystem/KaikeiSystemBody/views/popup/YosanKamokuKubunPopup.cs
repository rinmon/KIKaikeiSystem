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
    partial class YosanKamokuKubunPopup : Form
    {
        public YosanKamokuKubunPopup() {
            InitializeComponent();
        }

        public grid.YosanKamokuKubunGrid Grid {
            get { return yosanGrid; }
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
