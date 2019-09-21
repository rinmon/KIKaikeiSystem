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
    partial class BalanceSheetForm : Form
    {
        public event Action CalcButtonClicked;
        public event Action ReturnButtonClicked;

        private models.db.KaikeiDatabase db;


        public BalanceSheetForm() {
            db = null;

            InitializeComponent();

            dateStart.DateChanged += delegate(object sender, DateTime? date) {
                if (date != null) {

                    dateEnd.Date = (new DateTime(date.Value.Year, date.Value.Month, 1)).AddMonths(1).AddDays(-1);
                }
            };

            btnCalc.Click += (s, e) => CalcButtonClicked();
            btnReturn.Click += (s, e) => ReturnButtonClicked();

            radioKaikeiKubun_CheckedChanged(null, null);
        }


        public int KaikeiKubun {
            get {
                if (radioKaikeiKubunAll.Checked) {
                    return -1;
                }
                else {
                    return cmbKaikeiKubun.SelectedKeyAsInt;
                }
            }
        }


        public DateTime? StartDate {
            get {
                return dateStart.Date;
            }
        }

        public DateTime? EndDate {
            get {
                return dateEnd.Date;
            }
        }

        public void SetSummaryItem(models.query.BalanceSheet.SummaryItem item, long current, long prev, long delta) {
            string currentStr = helper.Converter.LongToAmountWithoutYen(current);
            string prevStr = helper.Converter.LongToAmountWithoutYen(prev);
            string deltaStr = helper.Converter.LongToAmountWithoutYen(delta);

            switch (item) {
                case models.query.BalanceSheet.SummaryItem.HusaiSummary:
                    labelHusaiCurrentSum.Text = txtHusaiCurrentSum.Text = currentStr;
                    labelHusaiPrevSum.Text = txtHusaiPrevSum.Text = prevStr;
                    labelHusaiDeltaSum.Text = txtHusaiDeltaSum.Text = deltaStr;
                    break;
                case models.query.BalanceSheet.SummaryItem.JunshisanSummary:
                    labelJunshisanCurrentSum.Text = txtJunshisanCurrentSum.Text = currentStr;
                    labelJunshisanPrevSum.Text = txtJunshisanPrevSum.Text = prevStr;
                    labelJunshisanDeltaSum.Text = txtJunshisanDeltaSum.Text = deltaStr;
                    break;
                case models.query.BalanceSheet.SummaryItem.ShisanSummary:
                    labelShisanCurrentSum.Text = txtShisanCurrentSum.Text = currentStr;
                    labelShisanPrevSum.Text = txtShisanPrevSum.Text = prevStr;
                    labelShisanDeltaSum.Text = txtShisanDeltaSum.Text = deltaStr;
                    break;
                case models.query.BalanceSheet.SummaryItem.HusaiPlusJunshisanSummary:
                    txtHusaiAndJunshisanCurrentSum.Text = currentStr;
                    txtHusaiAndJunshisanPrevSum.Text = prevStr;
                    txtHusaiAndJunshisanDeltaSum.Text = deltaStr;
                    break;
                case models.query.BalanceSheet.SummaryItem.JikiKurikoshiSagaku:
                    labelJikiKurikoshiSagakuCurrent.Text = currentStr;
                    labelJikiKurikoshiSagakuPrev.Text = prevStr;
                    labelJikiKurikoshiSagakuDelta.Text = deltaStr;
                    break;
                case models.query.BalanceSheet.SummaryItem.ToukiSagaku:
                    labelToukiSagakuCurrent.Text = currentStr;
                    labelToukiSagakuPrev.Text = prevStr;
                    labelToukiSagakuDelta.Text = deltaStr;
                    break;
            }
        }

        public void ClearGrid() {
            gridShisan.Rows.Clear();
            gridJunshisan.Rows.Clear();
            gridHusai.Rows.Clear();
        }

        public void AddShisanGridRow(string daikubun, string kamoku, long current, long prev, long delta) {
            gridShisan.Rows.Add(
                daikubun,
                kamoku,
                helper.Converter.LongToAmountWithoutYen(current),
                helper.Converter.LongToAmountWithoutYen(prev),
                helper.Converter.LongToAmountWithoutYen(delta)
            );
        }

        public void AddHusaiGridRow(string daikubun, string kamoku, long current, long prev, long delta) {
            gridHusai.Rows.Add(
                daikubun,
                kamoku,
                helper.Converter.LongToAmountWithoutYen(current),
                helper.Converter.LongToAmountWithoutYen(prev),
                helper.Converter.LongToAmountWithoutYen(delta)
            );
        }
        public void AddJunshisanGridRow(string daikubun, string kamoku, long current, long prev, long delta) {
            gridJunshisan.Rows.Add(
                daikubun,
                kamoku,
                helper.Converter.LongToAmountWithoutYen(current),
                helper.Converter.LongToAmountWithoutYen(prev),
                helper.Converter.LongToAmountWithoutYen(delta)
            );
        }

        public void SetDatabase(KaikeiSystemBody.models.db.KaikeiDatabase aDB) {
            if (db != aDB) {
                db = aDB;

                cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, onlyLeafNode: false);
                cmbKaikeiKubun.SelectedIndex = -1;
            }
        }

        public void SetGengou(string gengou) {
            dateStart.GengouStr = gengou;
            dateEnd.GengouStr = gengou;
        }


        public void SetStatusBarText(string txt) {
            toolStripStatusLabel.Text = txt;
        }


        protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
            base.ScaleControl(factor, specified);

            helper.View.SetDataGridViewFixedColumnAndAutoScale(factor, gridShisan);
            helper.View.SetDataGridViewFixedColumnAndAutoScale(factor, gridHusai);
            helper.View.SetDataGridViewFixedColumnAndAutoScale(factor, gridJunshisan);
        }


        private void radioKaikeiKubun_CheckedChanged(object sender, EventArgs e) {
            if (radioKaikeiKubunAll.Checked) {
                cmbKaikeiKubun.Enabled = false;
            }
            else {
                cmbKaikeiKubun.Enabled = true;
            }
        }

        private void BalanceSheetForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, this.Size.Height + this.statusStrip.Size.Height);
        }
    }
}
