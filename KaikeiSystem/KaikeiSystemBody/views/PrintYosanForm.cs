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
    partial class PrintYosanForm : Form
    {
        private models.db.KaikeiDatabase db;

        public event Action CloseButtonClicked;
        public event Action PrintButtonClicked;
        public event Action CurrentYearChanged;


        [Flags]
        public enum PrintFormat {
            SyuushiYosan = 0x01,        // 収支予算書
            HoseiYosan = 0x02,          // 補正予算書
            YosanUchiwake = 0x04,       // 予算内訳
            YosanJissekiTaihi = 0x08,   // 予算実績対比表
        }


        public PrintYosanForm() {
            InitializeComponent();

            dateCurrentYear.DateChanged += delegate(object sender, DateTime? date) {
                if (date != null) {
                    dateLastYear.Date = (new DateTime(date.Value.Year, 1, 1)).AddYears(-1);
                    CurrentYearChanged();
                }
            };

            radioAll.Checked = true;

            chkPrintDate_CheckedChanged(null, null);
            radioSelectedKeiriKubun_CheckedChanged(null, null);

            btnClose.Click += (s, e) => CloseButtonClicked();
            btnPrint.Click += (s, e) => PrintButtonClicked();
        }


        public int CurrentYear {
            get {
                if (dateCurrentYear.Date == null) {
                    return -1;
                }
                return dateCurrentYear.Date.Value.Year;
            }
        }

        public int LastYear {
            get {
                if (dateLastYear.Date == null) {
                    return -1;
                }
                return dateLastYear.Date.Value.Year;
            }
        }

        public int HoseiKaisuu {
            get {
                return helper.Converter.ObjToInt(txtHoseiKaisuu.Text, -1);
            }
        }

        public bool AllKaikeiKubunIsChecked {
            get { return radioAll.Checked; }
        }

        public int KaikeiKubun {
            get {
                object key = mtKaikeiKubun.SelectedKey;
                if(key != null){
                    return (int)key;
                }
                return -1;
            }
        }

        public bool OmitZeroRow {
            get {
                return chkOmitZeroRow.Checked;
            }
        }

        public bool AddDateIsChecked {
            get { return chkAddDate.Checked; }
        }

        public DateTime? DateToAdd {
            get { return datePrint.Date; }
        }

        public PrintFormat SelectedPrintFormat {
            get {
                PrintFormat res = 0;
                if (chkSyuusiYosan.Checked) res |= PrintFormat.SyuushiYosan;
                if (chkHoseiYosan.Checked) res |= PrintFormat.HoseiYosan;
                if (chkYosanUchiwake.Checked) res |= PrintFormat.YosanUchiwake;
                if (chkYosanJissekiTaihi.Checked) res |= PrintFormat.YosanJissekiTaihi;

                return res;
            }
        }


        public void SetGengou(string gengou) {
            dateCurrentYear.GengouStr = gengou;
            dateLastYear.GengouStr = gengou;
            datePrint.GengouStr = gengou;
        }

        public void SetDatabase(KaikeiSystemBody.models.db.KaikeiDatabase aDB) {
            if (db != aDB) {
                db = aDB;
                mtKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, false);
                mtKaikeiKubun.SelectedIndex = -1;
            }
        }

        public void ClearHoseiKaisuuMsg() {
            lblCurrentYearHoseiKaisuuMsg.Text = "";
            lblLastYearHoseiKaisuuMsg.Text = "";
        }

        public void SetCurrentYearHoseiKaisuuMsg(int year, int hoseiKaisuu) {
            lblCurrentYearHoseiKaisuuMsg.Text = helper.Helper.GetHoseiKaisuuMsg(year, hoseiKaisuu);
        }

        public void SetLastYearHoseiKaisuuMsg(int year, int hoseiKaisuu) {
            lblLastYearHoseiKaisuuMsg.Text = helper.Helper.GetHoseiKaisuuMsg(year, hoseiKaisuu);
        }

        private void chkPrintDate_CheckedChanged(object sender, EventArgs e) {
            panelPrintDate.Enabled = chkAddDate.Checked;
        }

        private void radioSelectedKeiriKubun_CheckedChanged(object sender, EventArgs e) {
            mtKaikeiKubun.Enabled = radioSelectedKeiriKubun.Checked;
        }
    }
}
