using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KaikeiSystemBody.views
{
    partial class KurikoshiSyoriForm : Form
    {
        public event Action ExecuteButtonClicked;
        public event Action RecalcButtonClicked;
        public event Action CloseButtonClicked;


        public DateTime? NextYear {
            get {
                return dateNextYear.Date;
            }
        }

        public KurikoshiSyoriForm() {
            InitializeComponent();

            btnExecute.Click += (s, e) => ExecuteButtonClicked();
            btnRecalc.Click += (s, e) => RecalcButtonClicked();
            btnClose.Click += (s, e) => CloseButtonClicked();
        }

        public void SetCurrentYear(DateTime currentYear) {
            txtCurrentYear.Text = helper.Converter.DateTimeToWarekiGengou(currentYear) +
                                    helper.Converter.DateTimeToWarekiYear(currentYear);

            dateNextYear.Date = currentYear.AddYears(1);
        }
    }
}
