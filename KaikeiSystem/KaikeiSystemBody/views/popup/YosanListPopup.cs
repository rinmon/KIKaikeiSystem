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
    partial class YosanListPopup : Form
    {
        public event Action PopupClosed;
        public event Action CloseButtonClicked;
        public event Action ShowCurrentYearButtonClicked;
        public event Action ShowAllButtonClicked;
        public event Action<object> ShowButtonClicked;  // ShowButtonClicked(object sender)

        public YosanListPopup() {
            InitializeComponent();

            this.FormClosed += (s, e) => PopupClosed();
            btnClose.Click += (s, e) => CloseButtonClicked();

            btnShowCurrentYear.Click += delegate(object sender, EventArgs e) {
                ShowCurrentYearButtonClicked();
                btnShowCurrentYear.Hide();
                btnShowAll.Show();
            };
            btnShowAll.Click += delegate(object sender, EventArgs e) {
                ShowAllButtonClicked();
                btnShowCurrentYear.Show();
                btnShowAll.Hide();
            };

            foreach (var row in grid.AllRowControls()) {
                row.ShowButtonClicked += ShowButtonClickedHandler;
            }
        }


        public grid.YosanListGrid Grid {
            get { return grid; }
        }


        private void ShowButtonClickedHandler(object sender) {
            ShowButtonClicked(sender);
        }
    }
}
