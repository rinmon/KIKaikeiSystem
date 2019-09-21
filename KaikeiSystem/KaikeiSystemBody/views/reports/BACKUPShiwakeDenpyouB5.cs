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
    /// </summary>
    public partial class BACKUPShiwakeDenpyouB5 : DataDynamics.ActiveReports.ActiveReport
    {

        public BACKUPShiwakeDenpyouB5() {
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
        }
    }
}
