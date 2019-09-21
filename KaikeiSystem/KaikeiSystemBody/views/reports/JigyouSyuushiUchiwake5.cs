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
    /// JigyouSyuushiUchiwake5 の概要の説明です。
    /// </summary>
    partial class JigyouSyuushiUchiwake5 : DataDynamics.ActiveReports.ActiveReport
    {
        public JigyouSyuushiUchiwakeEngine Engine { get; private set; }

        public JigyouSyuushiUchiwake5() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.501f);
            this.PageSettings.Margins.Bottom = CmToInch(1.00f);
            this.PageSettings.Margins.Left = CmToInch(1.501f);
            this.PageSettings.Margins.Right = CmToInch(1.00f);

            Engine = new JigyouSyuushiUchiwakeEngine(numCols: 5);
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
