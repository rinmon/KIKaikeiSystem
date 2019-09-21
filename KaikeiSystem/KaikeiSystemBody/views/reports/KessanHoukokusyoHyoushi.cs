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
    /// KessanHoukokusyoHyoushi の概要の説明です。
    /// </summary>
    public partial class KessanHoukokusyoHyoushi : DataDynamics.ActiveReports.ActiveReport
    {

        public KessanHoukokusyoHyoushi() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.501f);
            this.PageSettings.Margins.Bottom = CmToInch(1.501f);
            this.PageSettings.Margins.Left = CmToInch(1.501f);
            this.PageSettings.Margins.Right = CmToInch(1.501f);
        }


        public void SetHeader(DateTime kisanbi, DateTime kimatsubi, string houjinMei, string yuubinBangou, string juusyo) {
            txtKisanbi.Text = helper.Converter.DateTimeToWarekiStrKanji(kisanbi);
            txtKimatsubi.Text = helper.Converter.DateTimeToWarekiStrKanji(kimatsubi);
            txtHoujinMei.Text = houjinMei;
            txtYuubinBangou.Text = KaikeiSystemBody.Properties.Resources.CaptionYuubinMark + yuubinBangou;
            txtJuusyo.Text = juusyo;
        }
    }
}
