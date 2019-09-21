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
    /// TyuukiSubReportKoteiShisan の概要の説明です。
    /// </summary>
    public partial class TyuukiSubReportKoteiShisan : DataDynamics.ActiveReports.ActiveReport
    {
        public string Contents { get; set; }

        public TyuukiSubReportKoteiShisan() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();
        }
    }
}
