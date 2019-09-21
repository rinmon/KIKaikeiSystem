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
    /// ShiwakeDenpyouB5 の概要の説明です。
    /// 仕訳伝票のサイズをA4に変更したので、B5は使用しない。（2014.06.03）
    /// </summary>
    public partial class ShiwakeDenpyouB5 : DataDynamics.ActiveReports.ActiveReport
    {

        public ShiwakeDenpyouB5() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.001f);
            this.PageSettings.Margins.Bottom = CmToInch(2.00f);
            this.PageSettings.Margins.Left = CmToInch(2.0f);
            this.PageSettings.Margins.Right = CmToInch(1.0f);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PageSettings.PaperHeight = CmToInch(25.0f);
            this.PageSettings.PaperWidth = CmToInch(17.6f);
        }

        private void detail_Format(object sender, EventArgs e) {
            txtSeiriBangou.Text = txtDenpyouBangou.Text + "-" + txtId.Text;

            bool shiwake2Visible = txtKarikataKamoku2.Text != "";
            txtKarikataKamoku2.Visible = shiwake2Visible;
            txtKashikataKamoku2.Visible = shiwake2Visible;
            txtKarikataHojo2.Visible = shiwake2Visible;
            txtKashikataHojo2.Visible = shiwake2Visible;
        }
    }
}
