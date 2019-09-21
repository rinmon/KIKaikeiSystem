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
    partial class YosanYobihiKakuninPopup : Form
    {
        public event Action PopupClosed;

        public YosanYobihiKakuninPopup()
        {
            InitializeComponent();

            this.FormClosed += (s, e) => PopupClosed();
        }

        public grid.YosanYobihiKakuninGrid Grid {
            get { return grid; }
        }

    }
}
