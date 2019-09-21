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
    partial class HoujinShisetsuForm : Form
    {
        public event Action CloseButtonClicked;

        public HoujinShisetsuForm() {
            InitializeComponent();

            btnClose.Click += (s, e) => CloseButtonClicked();
        }


        public grid.HoujinDangaiRow HoujinDantaiRow {
            get { return houjinDantaiRow; }
        }


        public grid.HoujinShisetsuGrid HoujinShisetsuGrid {
            get { return gridHoujinShisetsu; }
        }
    }
}
