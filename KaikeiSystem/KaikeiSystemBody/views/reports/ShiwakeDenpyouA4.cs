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
    /// ShiwakeDenpyouA4 の概要の説明です。
    /// </summary>
    public partial class ShiwakeDenpyouA4 : DataDynamics.ActiveReports.ActiveReport
    {
        private int detailCt;

        public ShiwakeDenpyouA4() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.50f);
            this.PageSettings.Margins.Bottom = CmToInch(1.49f);
            this.PageSettings.Margins.Left = CmToInch(2.0f);
            this.PageSettings.Margins.Right = CmToInch(1.0f);

            detailCt = 0;
        }

        private void detail_Format(object sender, EventArgs e) {
            txtKihyoubi.Text = helper.Converter.DateTimeToWarekiStrKanji(helper.Converter.DateStrToDateTime(txtKihyoubi.Text));
            txtSeiriBangou.Text = txtDenpyouBangou.Text + "-" + txtId.Text;

            bool shiwake2Visible = txtKarikataKamoku2.Text != "";
            txtKarikataKamoku2.Visible = shiwake2Visible;
            txtKashikataKamoku2.Visible = shiwake2Visible;
            txtKarikataHojo2.Visible = shiwake2Visible;
            txtKashikataHojo2.Visible = shiwake2Visible;

            bool shiwake3Visible = txtKarikataKamoku3.Text != "";
            txtKarikataKamoku3.Visible = shiwake3Visible;
            txtKashikataKamoku3.Visible = shiwake3Visible;
            txtKarikataHojo3.Visible = shiwake3Visible;
            txtKashikataHojo3.Visible = shiwake3Visible;

            bool shiwake4Visible = txtKarikataKamoku4.Text != "";
            txtKarikataKamoku4.Visible = shiwake4Visible;
            txtKashikataKamoku4.Visible = shiwake4Visible;
            txtKarikataHojo4.Visible = shiwake4Visible;
            txtKashikataHojo4.Visible = shiwake4Visible;

            if (detailCt % 2 == 0) {
                detail.Height = CmToInch(14.85f);
            }
            else {
                detail.Height = CmToInch(14.85f - 1.50f - 1.50f);
            }

            detailCt++;
        }
    }
}
