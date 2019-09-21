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
    /// TekiyouReport の概要の説明です。
    /// </summary>
    public partial class TekiyouReport : DataDynamics.ActiveReports.ActiveReport
    {

        public TekiyouReport() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.503f);
            this.PageSettings.Margins.Bottom = CmToInch(0.99f);
            this.PageSettings.Margins.Left = CmToInch(1.00f);
            this.PageSettings.Margins.Right = CmToInch(0.99f);
        }
    }
}
