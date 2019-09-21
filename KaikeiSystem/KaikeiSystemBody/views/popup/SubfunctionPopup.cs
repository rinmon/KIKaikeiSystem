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

    partial class SubfunctionPopup : Form
    {
        public enum DateFilterTypeEnum
        {
            Kihyoubi,
            UpdateAt,
            CreatedAt
        }

        public event System.EventHandler KaikeiKubunFilterButtonClicked;
        public event System.EventHandler DateFilterButtonClicked;
        public event System.EventHandler KamokuFilterButtonClicked;
        public event System.EventHandler KingakuFilterButtonClicked;
        public event System.EventHandler CommentFilterButtonClicked;
        public event System.EventHandler IdFilterButtonClicked;
        public event System.EventHandler TorihikiKubunFilterButtonClicked;
        public event System.EventHandler CheckedFilterButtonClicked;
        public event System.EventHandler NotCheckedFilterButtonClicked;
        public event System.EventHandler NoFilterButtonClicked;
        public event System.EventHandler MoveToTopButtonClicked;
        public event System.EventHandler MoveToEndButtonClicked;
        public event System.EventHandler DenpyouBangouSeiriButtonClicked;
        public event System.EventHandler IkkatsuSyoriButtonClicked;
        public event System.EventHandler UncheckAllButtonClicked;
        public event System.EventHandler CloseButtonClicked;


        public SubfunctionPopup() {
            InitializeComponent();

            radioKihyoubi.Checked = true;
            selectorKamokuCode.BindMultiColumnComboBox(cmbKamoku);

            dateStart.DateChanged += delegate(object sender, DateTime? date){
                if (date != null) {
                    dateEnd.Date = dateStart.Date.Value;
                }
            };
        }

        public void InitGengou(string gengou) {
            dateStart.GengouStr = gengou;
            dateEnd.GengouStr = gengou;
        }

        public void InitEvents(){
            btnKaikeiKubunFilter.Click += KaikeiKubunFilterButtonClicked;
            btnDateFilter.Click += DateFilterButtonClicked;
            btnKamokuFilter.Click += KamokuFilterButtonClicked;
            btnKingakuFilter.Click += KingakuFilterButtonClicked;
            btnCommentFilter.Click += CommentFilterButtonClicked;
            btnIdFilter.Click += IdFilterButtonClicked;
            btnTorihikiKubunFilter.Click += TorihikiKubunFilterButtonClicked;
            btnCheckedFilter.Click += CheckedFilterButtonClicked;
            btnNotCheckedFilter.Click += NotCheckedFilterButtonClicked;
            btnNoFilter.Click += NoFilterButtonClicked;
            btnMoveToTop.Click += MoveToTopButtonClicked;
            btnMoveToEnd.Click += MoveToEndButtonClicked;
            btnDenpyouBangouSeiri.Click += DenpyouBangouSeiriButtonClicked;
            btnIkkatsuSyori.Click += IkkatsuSyoriButtonClicked;
            btnUncheckAll.Click += UncheckAllButtonClicked;
            btnClose.Click += CloseButtonClicked;
        }


        public int KaikeiKubun {
            get{
                return cmbKaikeiKubun.SelectedKeyAsInt;
            }
        }

        public bool KaikeiKubunFilterIsEnabled {
            get {
                return chkKaikeiKubunFilterIsEnabled.Checked;
            }
        }

        public int TorihikiKubun {
            get {
                return cmbTorihikiKubun.SelectedKeyAsInt;
            }
        }

        public DateFilterTypeEnum DateFilterType {
            get {
                if (radioKihyoubi.Checked) {
                    return DateFilterTypeEnum.Kihyoubi;
                }
                else if (radioCreatedAt.Checked) {
                    return DateFilterTypeEnum.CreatedAt;
                }
                else {
                    return DateFilterTypeEnum.UpdateAt;
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

        public bool DateFilterIsEnabled {
            get {
                return chkDateFilterIsEnabled.Checked;
            }
        }

        public string KamokuCode {
            get {
                return selectorKamokuCode.Text;
            }
        }

        public string SearchWordForComment {
            get {
                return txtSearchWordForComment.Text;
            }
        }

        public string KingakuStr {
            get {
                return txtKingaku.Text;
            }
        }

        public string IdStr {
            get {
                return txtID.Text;
            }
        }
        
        // マスタ情報の設定
        public void SetMasterTables(models.db.KaikeiDatabase db) {
            cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, true);
            if (cmbKaikeiKubun.Items.Count > 0) {
                cmbKaikeiKubun.SelectedIndex = 0;
            }
            cmbTorihikiKubun.InitRowsWithMTTorihikiKubun(db.MTTorihikiKubun);
            cmbKamoku.InitRowsWithMTKanjouKamoku(db.MTKanjouKamoku, -1);
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

        private void cmbKamoku_SelectedIndexChanged(object sender, EventArgs e) {
            this.SelectNextControl(sender as Control, true, true, true, true);
        }
    }
}
