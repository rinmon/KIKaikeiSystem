using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.views.grid
{
    partial class YosanDaikubunGrid : YosanDaikubunGridWrapper
    {
        public YosanDaikubunGrid() {
            InitializeComponent();
        }
    }


    class YosanDaikubunGridWrapper : PanelGrid<YosanDaikubunRow> {
    
    }
}
