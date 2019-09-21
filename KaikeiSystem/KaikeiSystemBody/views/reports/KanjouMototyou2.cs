using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// 連続形式の勘定元帳
    /// </summary>
    public partial class KanjouMototyou2 : DataDynamics.ActiveReports.ActiveReport
    {

        private bool zenkiKurikoshiOnly = false;
        public bool ZenkiKurikoshiOnly {
            get{
                return zenkiKurikoshiOnly;
            }
            set {
                zenkiKurikoshiOnly = value;
                if (zenkiKurikoshiOnly) {
                    groupHeaderMonthly.Visible = false;
                    groupFooterMonthly.Visible = false;
                }
            }
        }

        
        public KanjouMototyou2() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.00f);
            this.PageSettings.Margins.Bottom = CmToInch(1.00f);
            this.PageSettings.Margins.Left = CmToInch(1.00f);
            this.PageSettings.Margins.Right = CmToInch(0.90f);
        }

        public void SetHeader(string houjinMei, string kaikeiKubun, string kamokuMei, string hojoKamokuMei, bool isHojoMototyou) {
            txtHoujinmeiForKanjouMototyou.Text = houjinMei;
            txtKaikeiKubunForKanjouMototyou.Text = kaikeiKubun;
            txtKaikeiKubunForHojoMototyou.Text = kaikeiKubun;
            txtKamokuMeiForKanjouMototyou.Text = kamokuMei;

            txtKamokuMeiForHojoMototyou.Text = kamokuMei;
            txtHojoKamokuMeiForHojoMototyou.Text = hojoKamokuMei;

            txtKamokuMeiForKanjouMototyou.Visible = !isHojoMototyou;
            lblHojoKamokuMeiForHojoMototyou.Visible = isHojoMototyou;
            lblKamokuForHojoMototyou.Visible = isHojoMototyou;
            txtHojoKamokuMeiForHojoMototyou.Visible = isHojoMototyou;
            txtKamokuMeiForHojoMototyou.Visible = isHojoMototyou;
            lblHoujinMeiForKanjouMototyou.Visible = !isHojoMototyou;
            lblKaikeiKubunForKanjouMototyou.Visible = !isHojoMototyou;
            txtHoujinmeiForKanjouMototyou.Visible = !isHojoMototyou;
            txtKaikeiKubunForKanjouMototyou.Visible = !isHojoMototyou;
            txtKaikeiKubunForHojoMototyou.Visible = isHojoMototyou;

            if (isHojoMototyou) {
                lblTitle.Text = "【補助元帳】";
            }
        }


        private void detail_Format(object sender, EventArgs e) {
            if (ZenkiKurikoshiOnly) {
                txtKihyoubi.Text = "";
                lblComment.Text = "前期繰越額";
            }
        }

        private void groupHeaderMonthly_BeforePrint(object sender, EventArgs e) {
            if (ZenkiKurikoshiOnly) {
                groupHeaderMonthly.Height = 0;
            }
        }

        private void groupFooterMonthly_BeforePrint(object sender, EventArgs e) {
            if (ZenkiKurikoshiOnly) {
                groupFooterMonthly.Height = 0;
            }
        }
    }
}
