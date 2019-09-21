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
    partial class KanjouMototyouForm : Form
    {
        public enum ViewMode{
            ViewKamoku,
            ViewHojoKamoku,
        }

        public event Action ReturnButtonClicked;
        public event Action AddDenpyouButtonClicked;
        public event Action PrintButtonClicked;
        public event Action ShowDenpyouViewButtonClicked;
        public event Action SearchButtonClicked;
        public event Action ShowHojoMototyouButtonClicked;
        public event Action<int> RowDetailButtonClicked;    // int RowIndex
        public event Action<string> SetStatusMessage;         // string message

        private KaikeiSystemBody.models.db.KaikeiDatabase db;
        private ViewMode viewMode;
        private int savedFirstDisplayScrollingRowIndex;
        private int savedSelectedRowIndex;

        private int kaikeiKubunPanelTopWhenKanjouMototyou;
        private int kaikeiKubunPanelTopWhenHojoMototyou;

        public KanjouMototyouForm() {
            savedFirstDisplayScrollingRowIndex = 0;
            savedSelectedRowIndex = 0;

            InitializeComponent();

            grid.RowHeadersWidth = 24;
            grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grid.RowTemplate.Height = 28;

            selectorKamokuCode.BindMultiColumnComboBox(cmbKanjouKamoku);
            selectorHojoKamoku.BindMultiColumnComboBox(cmbHojoKamoku);
            selectorKaikeiKubun.BindMultiColumnComboBox(cmbKaikeiKubun);

            selectorKaikeiKubun.ComboKey2Text += delegate(string comboKey) {
                return db.MTKaikeiKubun.GetFirst("kubun_code", "where id=" + comboKey).ToString();
            };
            selectorKaikeiKubun.Text2ComboKey += delegate(string text) {
                return db.MTKaikeiKubun.GetFirst("id", "where kubun_code=" + text).ToString();
            };

            cmbHojoKamoku.BindToMTKanjouKamkouComboBox(cmbKanjouKamoku, -1);

            btnReturn.Click += (s, e) => ReturnButtonClicked();
            btnAddDenpyou.Click += (s, e) => AddDenpyouButtonClicked();
            btnPrint.Click += (s, e) => PrintButtonClicked();
            btnShowDenpyouView.Click += (s, e) => ShowDenpyouViewButtonClicked();
            btnSearch.Click += (s, e) => SearchButtonClicked();
            btnShowHojoMototyou.Click += (s, e) => ShowHojoMototyouButtonClicked();

            dateStart.DateChanged += delegate(object sender, DateTime? date) {
                if(date != null){
                    dateEnd.Date = (new DateTime(date.Value.Year, date.Value.Month, 1)).AddMonths(1).AddDays(-1);
                }
            };

            radioKamokuOrderCode.CheckedChanged += delegate(object sender, EventArgs arg) {
                if (db != null) {
                    cmbKanjouKamoku.InitRowsWithMTKanjouKamoku(db.MTKanjouKamoku, -1, "kamoku_code");
                }
            };

            radioKamokuOrderAlphabet.CheckedChanged += delegate(object sender, EventArgs arg) {
                if (db != null) {
                    cmbKanjouKamoku.InitRowsWithMTKanjouKamoku(db.MTKanjouKamoku, -1, "kamoku_yomi");
                }
            };

            dateStart.SetStatusMessage += (msg) => SetStatusMessage(msg);
            dateEnd.SetStatusMessage += (msg) => SetStatusMessage(msg);

            kaikeiKubunPanelTopWhenKanjouMototyou = panelHojoKamoku.Top;
            kaikeiKubunPanelTopWhenHojoMototyou = panelKaikeiKubun.Top;
        }


        protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
            base.ScaleControl(factor, specified);

            helper.View.SetDataGridViewFixedColumnAndAutoScale(factor, grid);
        }


        public void SelectViewMode(ViewMode mode) {
            viewMode = mode;

            if (viewMode == ViewMode.ViewKamoku) {
                btnAddDenpyou.Show();
                btnPrint.Show();
                btnShowDenpyouView.Show();
                btnShowHojoMototyou.Show();
                //checkDenpyouSeiri.Show();
                panelHojoKamoku.Hide();
                panelKaikeiKubun.Top = kaikeiKubunPanelTopWhenKanjouMototyou;
                this.Text = "総勘定元帳";
                btnReturn.Text = "メニューへ(&M)";
            }
            else if(viewMode == ViewMode.ViewHojoKamoku){
                btnAddDenpyou.Hide();
                btnPrint.Hide();
                btnShowDenpyouView.Hide();
                btnShowHojoMototyou.Hide();
                //checkDenpyouSeiri.Hide();
                panelHojoKamoku.Show();
                panelKaikeiKubun.Top = kaikeiKubunPanelTopWhenHojoMototyou;
                this.Text = "補助元帳";
                btnReturn.Text = "閉じる(&X)";
            }
        }


        public void SetDatabase(KaikeiSystemBody.models.db.KaikeiDatabase aDB) {
            db = aDB;

            cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, onlyLeafNode:false);
            if (cmbKaikeiKubun.Items.Count > 0) {
                cmbKaikeiKubun.SelectedIndex = 0;
            }

            cmbKanjouKamoku.InitRowsWithMTKanjouKamoku(db.MTKanjouKamoku, -1);
        }


        public void SetStatusbarMessage(string msg) {
            statusbarMsgText.Text = msg;
        }


        public void ClearControls(string gengou) {
            dateStart.GengouStr = gengou;
            dateStart.YearStr = "";
            dateStart.MonthStr = "";
            dateStart.DayStr = "";

            dateEnd.GengouStr = gengou;
            dateEnd.YearStr = "";
            dateEnd.MonthStr = "";
            dateEnd.DayStr = "";

            cmbHojoKamoku.Text = "";
            cmbKanjouKamoku.Text = "";
            selectorKamokuCode.Text = "";
            selectorHojoKamoku.Text = "";
            cmbKaikeiKubun.SelectedIndex = 1;

            radioKamokuOrderCode.Checked = true;
            checkDenpyouSeiri.Checked = true;

            lblTargetKamoku.Text = "";
            lblTaragetKamokuKarikashiKubun.Text = "";
            lblZengetsuKurikoshi.Text = "";

            lblKarikataSum.Text = "";
            lblKashikataSum.Text = "";
            lblSashihikiSum.Text = "";

            grid.Rows.Clear();
        }


        private void SetZengetsuKurikoshiData(string kamoku, string karikashi, long amount) {
            lblTargetKamoku.Text = kamoku;
            lblTaragetKamokuKarikashiKubun.Text = karikashi;
            lblZengetsuKurikoshi.Text = helper.Converter.LongToAmountWithoutYen(amount);
        }


        public void SaveGridScrollAndSelection() {
            savedFirstDisplayScrollingRowIndex = grid.FirstDisplayedScrollingRowIndex;
            if (grid.SelectedRows.Count > 0) {
                savedSelectedRowIndex = grid.SelectedRows[0].Index;
            }
            else {
                savedSelectedRowIndex = 0;
            }
        }


        public void LoadGridScrollAndSelection() {
            if (savedFirstDisplayScrollingRowIndex < 0) {
                // nothing
            }
            else if (savedFirstDisplayScrollingRowIndex < grid.Rows.Count) {
                grid.FirstDisplayedScrollingRowIndex = savedFirstDisplayScrollingRowIndex;
            }
            else if(grid.Rows.Count > 0){
                grid.FirstDisplayedScrollingRowIndex = grid.Rows.Count - 1;
            }
            else{
                // nothing
            }

            if (savedSelectedRowIndex < 0) {
                //nothing
            }
            else if (savedSelectedRowIndex < grid.Rows.Count) {
                grid.CurrentCell = grid[1, savedSelectedRowIndex];
            }
        }


        public void SetMototyouData(models.query.KanjouMototyou mototyou) {
            grid.Rows.Clear();

            foreach (var row in mototyou.MototyouRows) {
                AddRow(
                    row.DenpyouRenban,
                    row.Kihyoubi,
                    row.AiteKamokuStr,
                    row.Comment,
                    row.KarikataKingaku,
                    row.KashikataKingaku,
                    row.Zandaka,
                    row.HasHojoKamoku ? "*" : ""
                );
            }

            this.KashikataSum = mototyou.KashikataSum;
            this.KarikataSum = mototyou.KarikataSum;
            this.SashihikiSum = mototyou.SashihikiSum;
            SetZengetsuKurikoshiData(mototyou.KanjouKamokuStr, mototyou.TaisyakuKubunStr, mototyou.ZengetsuKurikoshiGaku);
        }


        private void AddRow(int denpyouRenban, DateTime? kihyoubi, string aiteKamoku, string comment, long karikataKingaku, long kashikataKingaku, long sashihikiZanndaka, string hojoKamokuTouroku) {
            string kihyoubiStr;

            if(kihyoubi != null){
                kihyoubiStr = kihyoubi.Value.Month + "/" + kihyoubi.Value.Day;
            }
            else{
                kihyoubiStr = "";
            }

            grid.Rows.Add(
                "詳細（D）",
                denpyouRenban,
                kihyoubiStr,
                aiteKamoku,
                comment,
                helper.Converter.LongToAmountWithoutYen(karikataKingaku),
                helper.Converter.LongToAmountWithoutYen(kashikataKingaku),
                helper.Converter.LongToAmountWithoutYen(sashihikiZanndaka),
                hojoKamokuTouroku
            );
        }


        public DateTime? StartDate{
            get {
                return dateStart.Date;
            }
            set {
                dateStart.Date = value;
            }
        }

        public DateTime? EndDate {
            get {
                return dateEnd.Date;
            }
            set {
                dateEnd.Date = value;
            }
        }

        public string TargetKamokuCode {
            get {
                return cmbKanjouKamoku.SelectedKeyAsStr;
            }
            set {
                cmbKanjouKamoku.SelectRowByKeyValue(value);
            }
        }

        public string TargetHojoKamokuSeiri {
            get {
                return cmbHojoKamoku.SelectedKeyAsStr;
            }
            set {
                cmbHojoKamoku.SelectRowByKeyValue(value);
            }
        }

        public int TargetKaikeiKubun {
            get {
                return cmbKaikeiKubun.SelectedKeyAsInt;
            }
            set {
                cmbKaikeiKubun.SelectRowByKeyValue(value);
            }
        }

        public bool DenpyouSeiriChecked {
            get {
                return checkDenpyouSeiri.Checked;
            }
        }

        private long KarikataSum {
            set {
                lblKarikataSum.Text = helper.Converter.LongToAmountWithoutYen(value);
            }
        }

        private long KashikataSum {
            set {
                lblKashikataSum.Text = helper.Converter.LongToAmountWithoutYen(value);
            }
        }

        private long SashihikiSum {
            set {
                lblSashihikiSum.Text = helper.Converter.LongToAmountWithoutYen(value);
            }
        }

        // events
        private void control_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
            }
        }

        private void Control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            var target = sender as System.Windows.Forms.Control;

            if (e.KeyCode == Keys.Enter && !(sender is Button) && !e.Shift) {
                this.SelectNextControl(target, true, true, true, true);
                e.IsInputKey = true;
            }
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.Columns[e.ColumnIndex].Name == "ColumnDetailButton") {
                if (RowDetailButtonClicked != null) {
                    RowDetailButtonClicked(e.RowIndex);
                } 
            }
        }

        private void btnDummy_Click(object sender, EventArgs e) {
            if(grid.SelectedRows.Count > 0){
                if (RowDetailButtonClicked != null) {
                    RowDetailButtonClicked(grid.SelectedRows[0].Index);
                } 
            }
        }

        private void control_Leave(object sender, EventArgs e) {
            SetStatusMessage("");
        }

        private void cmbKamoku_Enter(object sender, EventArgs e) {
            SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusSelectKamoku);
        }

        private void cmbHojoKamoku_Enter(object sender, EventArgs e) {
            SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusSelectHojoKamoku);
        }

        private void cmbKaikeiKubun_Enter(object sender, EventArgs e) {
            SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusSelectKaikeiKubun);
        }

        private void btnSearch_Enter(object sender, EventArgs e) {
            SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusShowMototyou);
        }

        private void btnShowHojoMototyou_Enter(object sender, EventArgs e) {
            SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusShowHojoMototyou);
        }
    }
}
