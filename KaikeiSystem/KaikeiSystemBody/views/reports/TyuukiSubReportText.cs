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
    /// BalanceSheetTyuuki1 の概要の説明です。
    /// </summary>
    public partial class TyuukiSubReportText : DataDynamics.ActiveReports.ActiveReport
    {
        public string Contents { get; set; }

        public TyuukiSubReportText() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();
        }

        private void reportHeader1_Format(object sender, EventArgs e) {
            txtContents.Text = Contents;
        }


    }
}
