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
    partial class KanjouMototyouPrinntPopup : Form
    {
        public event Action CloseButtonClicked;
        public event Action PrintButtonClicked;

        private models.db.KaikeiDatabase db;

        public enum TargetKamokuTypeEnum
        {
            All,
            Selected,
            Range,

            None
        }


        public DateTime? StartDate {
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

        public int TargetKaikeiKubun {
            get {
                if (radioKaikeiKubunAll.Checked) {
                    return -1;
                }
                else {
                    return cmbKaikeiKubun.SelectedKeyAsInt;
                }
            }
        }

        public TargetKamokuTypeEnum TargetKamokuType {
            get {
                if (radioKamokuAll.Checked) {
                    return TargetKamokuTypeEnum.All;
                }
                else if(radioKamokuSelected.Checked){
                    return TargetKamokuTypeEnum.Selected;
                }
                else if (radioKamokuRange.Checked) {
                    return TargetKamokuTypeEnum.Range;
                }
                else {
                    return TargetKamokuTypeEnum.None;
                }
            }
        }

        public string TargetKamokuCode {
            get {
                return cmbKamoku.SelectedKeyAsStr;
            }
            set {
                cmbKamoku.SelectRowByKeyValue(value);
            }
        }

        public string KamokuTopCode {
            get {
                return cmbKamokuTop.SelectedKeyAsStr;
            }
            set {
                cmbKamokuTop.SelectRowByKeyValue(value);
            }
        }

        public string KamokuBottomCode {
            get {
                return cmbKamokuBottom.SelectedKeyAsStr;
            }
            set {
                cmbKamokuBottom.SelectRowByKeyValue(value);
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

        public bool PrintHojoMototyouChecked {
            get {
                return chkPrintHojoMototyou.Checked;
            }
        }

        public bool DenpyouSeiriChecked {
            get {
                return chkDenpyouSeiri.Checked;
            }
        }

        public bool RenzokuKeishikiChecked {
            get {
                return chkRenzoku.Checked;
            }
        }

        public bool DontPrintKanjouMototyouChecked {
            get {
                return chkDontPrintKanjouMototyou.Checked;
            }
        }

        public bool KaikeiKubunAllChecked {
            get {
                return radioKaikeiKubunAll.Checked;
            }
        }

        
        public KanjouMototyouPrinntPopup() {
            InitializeComponent();

            txtKamokuSelector.BindMultiColumnComboBox(cmbKamoku);
            txtKamokuSelectorTop.BindMultiColumnComboBox(cmbKamokuTop);
            txtKamokuSelectorBottom.BindMultiColumnComboBox(cmbKamokuBottom);
            cmbHojoKamoku.BindToMTKanjouKamkouComboBox(cmbKamoku, -1);

            dateStart.DateChanged += delegate(object sender, DateTime? date) {
                if (date != null) {
                    dateEnd.Date = (new DateTime(date.Value.Year, date.Value.Month, 1)).AddMonths(1).AddDays(-1);
                }
            };

            radioKamokuOrderCode.CheckedChanged += delegate(object sender, EventArgs arg) {
                if (db != null) {
                    cmbKamoku.InitRowsWithMTKanjouKamoku(db.MTKanjouKamoku, -1, "kamoku_code");
                    cmbKamokuTop.InitRowsWithMTKanjouKamoku(db.MTKanjouKamoku, -1, "kamoku_code");
                    cmbKamokuBottom.InitRowsWithMTKanjouKamoku(db.MTKanjouKamoku, -1, "kamoku_code");
                }
            };

            radioKamokuOrderAlphabet.CheckedChanged += delegate(object sender, EventArgs arg) {
                if (db != null) {
                    cmbKamoku.InitRowsWithMTKanjouKamoku(db.MTKanjouKamoku, -1, "kamoku_yomi");
                    cmbKamokuTop.InitRowsWithMTKanjouKamoku(db.MTKanjouKamoku, -1, "kamoku_yomi");
                    cmbKamokuBottom.InitRowsWithMTKanjouKamoku(db.MTKanjouKamoku, -1, "kamoku_yomi");
                }
            };

            radioKamokuSelected.Checked = true;
            radioKamokuOrderCode.Checked = true;
            radioKaikeiKubunSelect.Checked = true;

            // 暫定的に連続のみ選択できるようにする
            chkRenzoku.Checked = true;
            chkRenzoku.Enabled = false;

            radioTargetKamoku_CheckedChanged(null, null);
        }


        public void SetDatabase(KaikeiSystemBody.models.db.KaikeiDatabase aDB) {
            db = aDB;

            cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, onlyLeafNode:false);
            if (cmbKaikeiKubun.Items.Count > 0) {
                cmbKaikeiKubun.SelectedIndex = 0;
            }

            cmbKamoku.InitRowsWithMTKanjouKamoku(db.MTKanjouKamoku, parentId:-1);
            cmbKamokuTop.InitRowsWithMTKanjouKamoku(db.MTKanjouKamoku, parentId: -1);
            cmbKamokuBottom.InitRowsWithMTKanjouKamoku(db.MTKanjouKamoku, parentId: -1);
        }


        public void SetGengou(string gengou) {
            dateStart.GengouStr = gengou;
            dateEnd.GengouStr = gengou;
        }


        private void radioTargetKamoku_CheckedChanged(object sender, EventArgs e) {
            bool enHojoMototyou = radioKamokuSelected.Checked;
            chkPrintHojoMototyou.Enabled = enHojoMototyou;
            cmbHojoKamoku.Enabled = enHojoMototyou;

            cmbKamoku.Enabled = radioKamokuSelected.Checked;
            cmbKamokuTop.Enabled = radioKamokuRange.Checked;
            cmbKamokuBottom.Enabled = radioKamokuRange.Checked;

            txtKamokuSelector.Enabled = cmbKamoku.Enabled;
            txtKamokuSelectorTop.Enabled = cmbKamokuTop.Enabled;
            txtKamokuSelectorBottom.Enabled = cmbKamokuBottom.Enabled;
        }

        private void btnPrint_Click(object sender, EventArgs e) {
            PrintButtonClicked();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            CloseButtonClicked();
        }

        private void radioKaikeiKubunAll_CheckedChanged(object sender, EventArgs e) {
            cmbKaikeiKubun.Enabled = radioKaikeiKubunSelect.Checked;
        }
    }
}
