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
    /// KanjjouMototyou の概要の説明です。
    /// </summary>
    public partial class KanjouMototyou : DataDynamics.ActiveReports.ActiveReport
    {

        public bool ZenkiKurikoshiOnly {
            get;
            set;
        }


        public KanjouMototyou() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.00f);
            this.PageSettings.Margins.Bottom = CmToInch(1.00f);
            this.PageSettings.Margins.Left = CmToInch(3.00f);
            this.PageSettings.Margins.Right = CmToInch(0.50f);

            // 横向き
            this.PageSettings.Orientation = PageOrientation.Landscape;
        }


        public void SetHeader(string houjinMei, string kaikeiKubun, string kamokuMei) {
            txtHoujinmei.Text = houjinMei;
            txtKaikeiKubunPageHeader.Text = kaikeiKubun;
            txtKamokumei.Text = kamokuMei;
        }

        private void detail_Format(object sender, EventArgs e) {
            if (ZenkiKurikoshiOnly) {
                txtKihyoubi.Text = "";
                txtComment.Text = "前期繰越額";
            }
        }

        private void groupFooterMonthly_Format(object sender, EventArgs e) {
            if (ZenkiKurikoshiOnly) {
                lblFooterDate.Visible = false;
            }
        }

        private void groupHeaderMonthly_Format(object sender, EventArgs e) {
            if (ZenkiKurikoshiOnly) {
                lblHeaderZengetsuKurikoshi.Visible = false;
                txtHeaderKurikoshi.Visible = false;
                txtHeaderDate.Visible = false;
            }
        }
    }
}
