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
    partial class KoteiShisanForm : Form
    {
        public event Action SelectButtonClicked;
        public event Action ShowAllButtonClicked;
        public event Action DetailButtonClicked;
        public event Action MenuButtonClicked;
        public event Action NewButtonClicked;
        
        public KoteiShisanForm() {
            InitializeComponent();

            btnSelect.Click += (s, e) => SelectButtonClicked();
            btnShowAll.Click += (s, e) => ShowAllButtonClicked();
            btnShowDetail.Click += (s, e) => DetailButtonClicked();
            btnMenu.Click += (s, e) => MenuButtonClicked();
            btnNew.Click += (s, e) => NewButtonClicked();
        }


        public grid.KoteiShisanGrid Grid {
            get { return grid; }
        }


        public int KaikeiKubun {
            get {
                return cmbKaikeiKubun.SelectedKeyAsInt;
            }
        }


        public void SetDatabase(models.db.KaikeiDatabase db) {
            cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, true);
        }

        private void KoteiShisanForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, this.Size.Height + this.statusStrip1.Size.Height);
        }
    }
}
