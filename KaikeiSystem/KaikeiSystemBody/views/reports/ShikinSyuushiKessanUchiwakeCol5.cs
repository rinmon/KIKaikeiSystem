﻿using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// ShikinSyuushiKessanUchiwake の概要の説明です。
    /// </summary>
    partial class ShikinSyuushiKessanUchiwakeCol5 : DataDynamics.ActiveReports.ActiveReport
    {
        public ShikinSyuushiKessanUchiwakeEngine Engine {
            get;
            private set;
        }


        public ShikinSyuushiKessanUchiwakeCol5() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(2.001f);
            this.PageSettings.Margins.Bottom = CmToInch(1.00f);
            this.PageSettings.Margins.Left = CmToInch(1.001f);
            this.PageSettings.Margins.Right = CmToInch(1.00f);

            Engine = new ShikinSyuushiKessanUchiwakeEngine(numCols: 5);
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
                txtKamoku,
                txtKamokuId,
                txtDaikubunId,
                txtKubunId,
                txtShisyutsuKeiCaption,
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
