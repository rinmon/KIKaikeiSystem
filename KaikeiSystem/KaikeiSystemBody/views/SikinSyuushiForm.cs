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
    partial class ShikinSyuushiForm : Form
    {
        public delegate void DaikubunGridRowSelectedDelegate(int selectedDaikubunId);
        public event Action CalcButtonClicked;
        public event DaikubunGridRowSelectedDelegate DaikubunGridRowSelected;
        public event Action ReturnButtonClicked;
        public event Action ShowJigyouSyuushiButtonClicked;

        private models.db.KaikeiDatabase db;
        private Dictionary<int, int> rowIndex2DaikubunId;


        public ShikinSyuushiForm() {
            rowIndex2DaikubunId = new Dictionary<int, int>();
            db = null;

            InitializeComponent();

            dateStart.DateChanged += delegate(object sender, DateTime? date) {
                if (date != null) {
                    dateEnd.Date = (new DateTime(date.Value.Year, date.Value.Month, 1)).AddMonths(1).AddDays(-1);
                }
            };

            btnCalc.Click += (s, e) => CalcButtonClicked();
            btnReturn.Click += (s, e) => ReturnButtonClicked();
            btnShowJigyouSyuushi.Click += (s, e) => ShowJigyouSyuushiButtonClicked();

            radioKaikeiKubunAll.Checked = true;
            radioKaikeiKubun_CheckedChanged(null, null);
        }


        protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
            base.ScaleControl(factor, specified);

            helper.View.SetDataGridViewFixedColumnAndAutoScale(factor, daikubunGrid);
            helper.View.SetDataGridViewFixedColumnAndAutoScale(factor, kamokuGrid);
            helper.View.SetDataGridViewFixedColumnAndAutoScale(factor, summaryGrid);
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

        public void SetSummaryGrid(models.query.ShikinSyuushi shikinSyuushi) {
            summaryGrid.Rows.Clear();

            summaryGrid.Rows.Add(Properties.Resources.CaptionJigyouSyuushi, "", "", "", "");
            BoldLastRow(summaryGrid);
            AddRowToSummaryGrid("　" + Properties.Resources.CaptionJigyouSyuunyuuKei, shikinSyuushi.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.JigyouSyuunyuu]);
            AddRowToSummaryGrid("　" + Properties.Resources.CaptionJigyouShisyutsuKei, shikinSyuushi.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.JigyouShisyutsu]);
            AddRowToSummaryGrid("　" + Properties.Resources.CaptionJigyouSyuushiSagaku, shikinSyuushi.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.JigyouSyuushi]);

            summaryGrid.Rows.Add(Properties.Resources.CaptionShisetsuSyuushi, "", "", "", "");
            BoldLastRow(summaryGrid);
            AddRowToSummaryGrid("　" + Properties.Resources.CaptionShisetsuSyuunyuuKei, shikinSyuushi.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.ShisetsuSyuunyuu]);
            AddRowToSummaryGrid("　" + Properties.Resources.CaptionShisetsuShisyutsuKei, shikinSyuushi.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.ShisetsuShisyutsu]);
            AddRowToSummaryGrid("　" + Properties.Resources.CaptionShisetsuSyuushiSagaku, shikinSyuushi.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.ShisetsuSyuushi]);

            summaryGrid.Rows.Add(Properties.Resources.CaptionSonotaSyuushi, "", "", "", "");
            BoldLastRow(summaryGrid);
            AddRowToSummaryGrid("　" + Properties.Resources.CaptionSonotaSyuunyuuKei, shikinSyuushi.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.SonotaSyuunyuu]);
            AddRowToSummaryGrid("　" + Properties.Resources.CaptionSonotaShisyutsuKei, shikinSyuushi.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.SonotaShisyutsu]);
            AddRowToSummaryGrid("　" + Properties.Resources.CaptionSonotaSyuushiSagaku, shikinSyuushi.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.SonotaSyuushi]);

            AddRowToSummaryGrid(Properties.Resources.CaptionYobihiShisyutsu, shikinSyuushi.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.Yobihi]);
            BoldLastRow(summaryGrid);
            AddRowToSummaryGrid(Properties.Resources.CaptionToukiShikinSyuushiSagakuGoukei, shikinSyuushi.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.ToukiShikin]);
            BoldLastRow(summaryGrid);
            AddRowToSummaryGrid(Properties.Resources.CaptionZenkimatsuShiharaiShikinZandaka, shikinSyuushi.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.ZenkiZandaka]);
            BoldLastRow(summaryGrid);
            AddRowToSummaryGrid(Properties.Resources.CaptionToukimatsuShiharaiShikinZandaka, shikinSyuushi.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.ToukiZandaka]);
            BoldLastRow(summaryGrid);
        }


        private void AddRowToSummaryGrid(string caption, models.query.ShikinSyuushi.ShikinSyuushiRow row) {
            summaryGrid.Rows.Add(
                caption,
                helper.Converter.LongToAmountWithoutYen(row.Yosan),
                helper.Converter.LongToAmountWithoutYen(row.Taisyaku),
                helper.Converter.LongToAmountWithoutYen(row.Sai)
            );
        }


        private void BoldLastRow(System.Windows.Forms.DataGridView grid) {
            var cell = grid.Rows[grid.Rows.Count - 1].Cells[0];
            cell.Style.Font = new Font(grid.DefaultCellStyle.Font, FontStyle.Bold);
        }


        public void ClearDaikubunGrid() {
            daikubunGrid.Rows.Clear();
            rowIndex2DaikubunId.Clear();
        }

        public void ClearKamokuGrid() {
            kamokuGrid.Rows.Clear();
        }

        public void AddDaikubunGridRow(int daikubunId, string syuushi, string daikubun, long yosan, long taisyaku, long sai) {
            daikubunGrid.Rows.Add(
                syuushi,
                daikubun,
                helper.Converter.LongToAmountWithoutYen(yosan),
                helper.Converter.LongToAmountWithoutYen(taisyaku),
                helper.Converter.LongToAmountWithoutYen(sai)
            );
            rowIndex2DaikubunId.Add(daikubunGrid.RowCount - 1, daikubunId);
        }

        public void AddKamokuGridRow(string kamoku, long taisyaku) {
            kamokuGrid.Rows.Add(
                kamoku,
                helper.Converter.LongToAmountWithoutYen(taisyaku)
            );
        }

        public void SetDatabase(KaikeiSystemBody.models.db.KaikeiDatabase aDB) {
            if (db != aDB) {
                db = aDB;
                cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, false);
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

        public void FireDaikubunGridSelectionChanged() {
            daikubunGrid_SelectionChanged(null, null);
        }

        private void radioKaikeiKubun_CheckedChanged(object sender, EventArgs e) {
            if (radioKaikeiKubunAll.Checked) {
                cmbKaikeiKubun.Enabled = false;
            }
            else {
                cmbKaikeiKubun.Enabled = true;
            }
        }

        private void daikubunGrid_SelectionChanged(object sender, EventArgs e) {
            if (daikubunGrid.SelectedRows.Count > 0 &&
                    rowIndex2DaikubunId.ContainsKey(daikubunGrid.SelectedRows[0].Index)) {
                DaikubunGridRowSelected(rowIndex2DaikubunId[daikubunGrid.SelectedRows[0].Index]);
            }
            else {
                DaikubunGridRowSelected(0);
            }
        }
    }
}
