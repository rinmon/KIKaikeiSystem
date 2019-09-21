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
    /// ShiwakeNikkityou の概要の説明です。
    /// </summary>
    public partial class ShiwakeNikkityou : DataDynamics.ActiveReports.ActiveReport
    {

        public ShiwakeNikkityou() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.501f);
            this.PageSettings.Margins.Bottom = CmToInch(1.404f);
            this.PageSettings.Margins.Left = CmToInch(1.0f);
            this.PageSettings.Margins.Right = CmToInch(1.0f);
        }


        public void SetHeader(DateTime startDate, DateTime endDate) {
            txtStartDate.Text = helper.Converter.DateTimeToWarekiStrKanji(startDate);
            txtEndDate.Text = helper.Converter.DateTimeToWarekiStrKanji(endDate);
        }

        private void detail_Format(object sender, EventArgs e) {
            txtKashikataKamokuCodeStr.Text = txtKashikataKamokuCode.Text;
            if(txtKashikataHojoSeiri.Text.Length > 0){
                txtKashikataKamokuCodeStr.Text += "-" + txtKashikataHojoSeiri.Text;
            }
            txtKarikataKamokuCodeStr.Text = txtKarikataKamokuCode.Text;
            if (txtKarikataHojoSeiri.Text.Length > 0) {
                txtKarikataKamokuCodeStr.Text += "-" + txtKarikataHojoSeiri.Text;
            }
        }
    }
}
