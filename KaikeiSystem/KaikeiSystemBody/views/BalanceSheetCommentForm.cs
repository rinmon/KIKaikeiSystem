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
    partial class BalanceSheetCommentForm : Form
    {
        public event Action CloseButtonClicked;
        public event Action ExecButtonClicked;

        public event Action JuuyouKaikeiHoushinHenkouChanged;
        public event Action JuuyouKouhatsuJisyouChanged;


        public BalanceSheetCommentForm() {
            InitializeComponent();
        }


        public grid.BSCGenkaGrid GenkaGrid {
            get { return gridGenka; }
        }

        public grid.BSCKaikeiHoushinGrid KaikeiHoushinGrid {
            get { return gridKaikeiHoushin; }
        }

        public grid.BSCZaisanGrid ZaisanGrid {
            get { return gridZaisan; }
        }

        public grid.BSCTorikuzushiGrid TorikuzushiGrid {
            get { return gridTorikuzushi; }
        }

        public grid.BSCTanpoGrid TanpoGrid {
            get { return gridTanpo; }
        }

        public string JuuyouKaikeiHoushinHenkou {
            get {
                return txtJuuyouKaikeiHoushinHenkou.Text;
            }
            set {
                txtJuuyouKaikeiHoushinHenkou.Text = value;
            }
        }

        public string JuuyouKouhatsuJisyou {
            get {
                return txtJuuyouKouhatsuJisyou.Text;
            }
            set {
                txtJuuyouKouhatsuJisyou.Text = value;
            }
        }


        public DateTime? InputDate {
            get {
                return dateInput.Date;
            }
        }

        public void InitInputDateStr(string gengou, string year) {
            dateInput.GengouStr = gengou;
            dateInput.YearStr = year;
        }

        public void SetCurrentYear(int year) {
            DateTime date = new DateTime(year, 4, 1);

            labelCurrentGengou.Text = helper.Converter.DateTimeToWarekiGengou(date);
            labelCurrentYear.Text = helper.Converter.DateTimeToWarekiYear(date).ToString();
        }


        private void btnClose_Click(object sender, EventArgs e) {
            CloseButtonClicked();
        }

        private void txtJuuyouKouhatsuJisyou_Leave(object sender, EventArgs e) {
            if (JuuyouKouhatsuJisyouChanged != null) {
                JuuyouKouhatsuJisyouChanged();
            }
        }

        private void txtJuuyouKaikeiHoushinHenkou_Leave(object sender, EventArgs e) {
            if (JuuyouKaikeiHoushinHenkouChanged != null) {
                JuuyouKaikeiHoushinHenkouChanged();
            }
        }

        private void btnExec_Click(object sender, EventArgs e) {
            ExecButtonClicked();
        }
    }
}
