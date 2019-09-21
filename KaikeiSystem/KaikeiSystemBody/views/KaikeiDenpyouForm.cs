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
    partial class KaikeiDenpyouForm : Form
    {
        public event Action ReturnToMenuButtonClicked;
        public event Action CopyKarikataCalled;
        public event Action CopyKashikataCalled;
        public event Action CopyCommentCalled;
        public event Action CopyRowCalled;
        public event Action ShowKamokuPopupButtonClicked;
        public event Action ShowTekiyouPopupButtonClicked;
        public event Action ShowSubfunctionPopupButtonClicked;
        public event Action<string> SetStatusMessage;         // string message
        public event Action ShowAllDataButtonClicked;
        public event Action ShowCurrentYearButtonClicked;
        public event Action ToggleInvalidDataButtonClicked;
        public event Action NewRowButtonClicked;
            
        public KaikeiDenpyouForm() {
            InitializeComponent();

            this.MouseWheel += dbGrid.DBGrid_MouseWheel;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            btnReturn.Click += (s, e) => ReturnToMenuButtonClicked();
            btnKanjouKamoku.Click += (s, e) => ShowKamokuPopupButtonClicked();
            btnTekiyou.Click += (s, e) => ShowTekiyouPopupButtonClicked();
            btnSubfunction.Click += (s, e) => ShowSubfunctionPopupButtonClicked();
            radioShowAllData.Click += (s,e) => ShowAllDataButtonClicked();
            radioShowCurrentYearData.Click += (s, e) => ShowCurrentYearButtonClicked();
            btnShowInvalidRow.Click += (s, e) => ToggleInvalidDataButtonClicked();
            btnNewRow.Click += (s, e) => NewRowButtonClicked();

            dateKihyoubi.SetStatusMessage += (msg) => lblKihyoubiStatus.Text = msg;
        }

        public bool IdLableVisible {
            get { return lblId.Visible;}
            set { lblId.Visible = value; }
        }

        public bool UpdateDateLableVisible {
            get { return lblUpdateDate.Visible; }
            set { lblUpdateDate.Visible = value; }
        }

        public bool CreateDateLableVisible {
            get { return lblCreateDate.Visible; }
            set { lblCreateDate.Visible = value; }
        }


        public grid.PanelGrid<grid.KaikeiDenpyouRow> Grid{
            get {return dbGrid;}
        }

        public int HeaderKaikeiKubun{
            get {
                return cmbKaikeiKubun.SelectedKeyAsInt;
            }
            set {
                cmbKaikeiKubun.SelectRowByKeyValue(value);
            }
        }

        public int HeaderTorihikiKubun {
            get {
                return cmbTorihikiKubun.SelectedKeyAsInt;
            }
            set {
                cmbTorihikiKubun.SelectRowByKeyValue(value);
            }
        }

        public string HeaderKihyoubiGengouText {
            get {
                return dateKihyoubi.GengouStr;
            }
            set {
                dateKihyoubi.GengouStr = value;
            }
        }

        public string HeaderKihyoubiYearText {
            get {
                return dateKihyoubi.YearStr;
            }
            set {
                dateKihyoubi.YearStr = value;
            }
        }

        public string HeaderKihyoubiMonthText {
            get {
                return dateKihyoubi.MonthStr;
            }
            set {
                dateKihyoubi.MonthStr = value;
            }
        }

        public string HeaderKihyoubiDayText {
            get {
                return dateKihyoubi.DayStr;
            }
            set {
                dateKihyoubi.DayStr = value;
            }
        }

        public bool ShowAllDataButtonChecked{
            set{
                radioShowAllData.Checked = value;
            }
        }

        public bool ShowCurrentYearDataChecked{
            set{
                radioShowCurrentYearData.Checked = value;
            }
        }

        public bool ShowInvalidRowButtonChecked{
            set{
                if(value){
                    btnShowInvalidRow.Text = "確認終了(&C)";                
                }
                else{
                    btnShowInvalidRow.Text = "伝票確認(&C)";
                }
            }
        }

        public string StatusMessage {
            get {
                return lblStatusMessage.Text;
            }
            set {
                lblStatusMessage.Text = value;
            }
        }

        // マスタ情報の設定
        public void SetMasterTables(models.db.KaikeiDatabase db) {
            cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, true);
            cmbTorihikiKubun.InitRowsWithMTTorihikiKubun(db.MTTorihikiKubun);
        }


        // Settingの設定
        public void SetSettingValues(models.db.mtables.MTSetting setting, models.db.AbstractDatabase db) {
            cmbKaikeiKubun.SelectRowByKeyValue(setting.GetInt("nyuuryoku_basyo", -1));
            cmbTorihikiKubun.SelectRowByKeyValue(setting.GetInt("before_torihiki_kubun", -1));
            dateKihyoubi.GengouStr = setting.GetStr("before_gengou", "");
            dateKihyoubi.YearStr = setting.GetStr("before_year", "");
            dateKihyoubi.MonthStr = setting.GetStr("before_month", "");
            dateKihyoubi.DayStr = setting.GetStr("before_day", "");
        }


        // ショートカットキーの処理
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.F2) {
                if (CopyRowCalled != null) {
                    CopyRowCalled();
                }
                return true;
            }
            if (keyData == Keys.F3) {
                if (CopyKarikataCalled != null) {
                    CopyKarikataCalled();
                }
                return true;
            }
            if (keyData == Keys.F4) {
                if (CopyKashikataCalled != null) {
                    CopyKashikataCalled();
                }
                return true;
            }
            if (keyData == Keys.F6) {
                if (CopyCommentCalled != null) {
                    CopyCommentCalled();
                }
                return true;
            }
            if (keyData == Keys.F8) {
                cmbKaikeiKubun.Select();
                return true;
            }
            if (keyData == Keys.F10) {
                cmbTorihikiKubun.Select();
                return true;
            }
            if (keyData == Keys.F11) {
                dateKihyoubi.TextBoxGengou.Select();
                return true;
            }
            if (keyData == Keys.F12) {
                dbGrid.SetFocus(dbGrid.LastSelectedRowNo, "karikata_kamoku_code");
            }

            return false;
        }


        // events

        private void control_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
            }
        }

        private void Control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            var target = sender as Control;
            Control parent = null;
            if (target.Parent == dateKihyoubi) {
                parent = target.Parent.Parent;
            }
            else{
                parent = target.Parent;
            }

            if (e.KeyCode == Keys.Tab || (e.KeyCode == Keys.Enter && !(sender is Button) && !e.Shift)) {
                if (e.KeyCode == Keys.Tab && e.Shift && target == dateKihyoubi.TextBoxGengou) {
                    cmbTorihikiKubun.Select();
                }
                else {
                    parent.SelectNextControl(target, !e.Shift, true, true, true);
                }
                e.IsInputKey = true;
            }
        }
        private void control_Leave(object sender, EventArgs e) {
            if (SetStatusMessage != null) {
                SetStatusMessage("");
            }
        }

        private void cmbKaikeiTanni_Enter(object sender, EventArgs e) {
            if (SetStatusMessage != null) {
                SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusKaikeiKubun);
            }
        }

        private void cmbTorihikiKubun_Enter(object sender, EventArgs e) {
            if (SetStatusMessage != null) {
                SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusTorihikiKubun);
            }
        }

        private void btnNewRecord_Enter(object sender, EventArgs e) {
            if (SetStatusMessage != null) {
                SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusMoveToNewRow);
            }
        }

        private void btnReturn_Enter(object sender, EventArgs e) {
            if (SetStatusMessage != null) {
                SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusReturnToMenu);
            }
        }

        private void btnSubfunction_Enter(object sender, EventArgs e) {
            if (SetStatusMessage != null) {
                SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusSubfunction);
            }
        }

        private void btnShowInvalidRow_Enter(object sender, EventArgs e) {
            if (SetStatusMessage != null) {
                SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusShowInvalidRow);
            }
        }

        private void radioShowData_Enter(object sender, EventArgs e) {
            if (SetStatusMessage != null) {
                SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusDataTypeSelection);
            }
        }

        private void btnKanjouKamoku_Enter(object sender, EventArgs e) {
            if (SetStatusMessage != null) {
                SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusShowKamokuPopup);
            }
        }

        private void btnTekiyou_Enter(object sender, EventArgs e) {
            if (SetStatusMessage != null) {
                SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusShowTekiyouPopup);
            }
        }

        private void KaikeiDenpyouForm_Load(object sender, EventArgs e)
        {
            if (this.Size.Width < this.dbGrid.Size.Width)
            {
                this.Size = new Size(this.dbGrid.Size.Width + SystemInformation.VerticalScrollBarWidth, this.Size.Height);
            }
        }
    }
}
