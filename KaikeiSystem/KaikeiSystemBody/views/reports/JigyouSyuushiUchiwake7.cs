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
    /// JigyouSyuushiUchiwake7 の概要の説明です。
    /// </summary>
    partial class JigyouSyuushiUchiwake7 : DataDynamics.ActiveReports.ActiveReport
    {
        public JigyouSyuushiUchiwakeEngine Engine { get; private set; }

        public JigyouSyuushiUchiwake7() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();
            
            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.501f);
            this.PageSettings.Margins.Bottom = CmToInch(1.00f);
            this.PageSettings.Margins.Left = CmToInch(1.001f);
            this.PageSettings.Margins.Right = CmToInch(0.50f);

            Engine = new JigyouSyuushiUchiwakeEngine(numCols: 7);
            Engine.InitComponents(
                pageHeader.Controls,
                detail.Controls,
                groupFooterKubun.Controls,
                reportFooter1.Controls,
                txtKisanbi,
                txtKimatsubi,
                txtHoujinMei,
                txtKubunName,
                txtDaikubunName,
                txtKamokuCode,
                txtKamokuName,
                txtKamokuId,
                txtDaikubunId,
                txtKubunId,
                txtSyuunyuuKeiCaption,
                labelTitle,
                labelYoushiki);


            groupHeaderKubun.Format += Engine.groupHeaderKubun_Format;
            groupHeaderDaikubun.Format += Engine.groupHeaderDaikubun_Format;
            groupFooterKubun.Format += Engine.groupFooterKubun_Format;
            detail.Format += Engine.detail_Format;
        }
    }
}
