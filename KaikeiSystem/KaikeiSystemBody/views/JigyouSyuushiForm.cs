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
    partial class JigyouSyuushiForm : Form
    {
        public delegate void DaikubunGridRowSelectedDelegate(int selectedDaikubunId);
        public event Action CalcButtonClicked;
        public event DaikubunGridRowSelectedDelegate DaikubunGridRowSelected;
        public event Action ReturnButtonClicked;
        public event Action ShowShikinSyuushiButtonClicked;

        private models.db.KaikeiDatabase db;
        private Dictionary<int, int> rowIndex2DaikubunId;

        
        public JigyouSyuushiForm() {
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
            btnShowShikinSyuushi.Click += (s, e) => ShowShikinSyuushiButtonClicked();

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


        public void SetSummaryGrid(models.query.JigyouKatsudou jigyouSyuushi) {
            summaryGrid.Rows.Clear();

            summaryGrid.Rows.Add("サービス活動増減の部", "", "", "", "");
            BoldLastRow(summaryGrid);
            AddRowToSummaryGrid("　サービス活動収益計", jigyouSyuushi.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouSyuunyuu]);
            AddRowToSummaryGrid("　サービス活動費用計", jigyouSyuushi.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouShisyutsu]);
            AddRowToSummaryGrid("　サービス活動増減差額", jigyouSyuushi.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouSagaku]);

            summaryGrid.Rows.Add("サービス活動外増減の部", "", "", "", "");
            BoldLastRow(summaryGrid);
            AddRowToSummaryGrid("　サービス活動外収益計", jigyouSyuushi.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouGaiSyuunyuu]);
            AddRowToSummaryGrid("　サービス活動外費用計", jigyouSyuushi.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouGaiShisyutsu]);
            AddRowToSummaryGrid("　サービス活動外増減差額", jigyouSyuushi.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouGaiSagaku]);

            AddRowToSummaryGrid("経常増減差額", jigyouSyuushi.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.KeijouZougenSagaku]);
            BoldLastRow(summaryGrid);

            summaryGrid.Rows.Add("特別増減の部", "", "", "", "");
            BoldLastRow(summaryGrid);
            AddRowToSummaryGrid("　特別収益計", jigyouSyuushi.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.TokubetsuSyuunyuu]);
            AddRowToSummaryGrid("　特別費用計", jigyouSyuushi.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.TokubetsuShisyutsu]);
            AddRowToSummaryGrid("　特別増減差額", jigyouSyuushi.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.TokubetsuSagaku]);

            AddRowToSummaryGrid("当期活動増減差額", jigyouSyuushi.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.ToukiKatsudouZougenSagaku]);
            BoldLastRow(summaryGrid);

            summaryGrid.Rows.Add("繰越活動増減差額の部", "", "", "", "");
            BoldLastRow(summaryGrid);
            AddRowToSummaryGrid("　前期繰越活動増減差額", jigyouSyuushi.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.ZenkiKurikoshiZougenSagaku]);
            AddRowToSummaryGrid("　当期末繰越活動増減差額", jigyouSyuushi.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.ToukimatsuKurikoshiKatsudouZougenSagaku]);
            AddRowToSummaryGrid("　基本金取崩額", jigyouSyuushi.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.KihonkinTorikuzushiGaku]);
            AddRowToSummaryGrid("　その他の積立金取崩額", jigyouSyuushi.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.SonotaTsumitateTorikuzushiGaku]);
            AddRowToSummaryGrid("　その他の積立金積立額", jigyouSyuushi.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.SonotaTsumitateGaku]);
            AddRowToSummaryGrid("　次期繰越活動増減差額", jigyouSyuushi.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.JikiKurikoshiKatsudouZougenSagaku]);
        }


        private void AddRowToSummaryGrid(string caption, models.query.JigyouKatsudou.JigyouSyuushiRow row) {
            summaryGrid.Rows.Add(
                caption,
                helper.Converter.LongToAmountWithoutYen(row.CurrentYearSum),
                helper.Converter.LongToAmountWithoutYen(row.LastYearSum),
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

        public void FireDaikubunGridSelectionChanged() {
            daikubunGrid_SelectionChanged(null, null);
        }

        public void AddDaikubunGridRow(int daikubunId, string syuushi, string daikubun, long current, long prev, long delta) {
            daikubunGrid.Rows.Add(
                syuushi,
                daikubun,
                helper.Converter.LongToAmountWithoutYen(current),
                helper.Converter.LongToAmountWithoutYen(prev),
                helper.Converter.LongToAmountWithoutYen(delta)
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

        private void daikubunGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void jigyouSyuushiForm_load(object sender, EventArgs e) {
            this.Size = new Size(this.Size.Width, this.Size.Height + this.statusStrip.Size.Height);
        }
    }
}
