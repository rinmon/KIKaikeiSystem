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
    /// TyuukiSubReportTanpoSub の概要の説明です。
    /// </summary>
    public partial class TyuukiSubReportTanpo : DataDynamics.ActiveReports.ActiveReport
    {
        public TyuukiSubReportTanpo() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();
        }

        private void groupHeader1_Format(object sender, EventArgs e) {
            int tanpoKubun = helper.Converter.ObjToInt(txtTanpoKubun.Text, -1);

            if (tanpoKubun == (int)models.constants.MTTanpoKubun.TanpoShisan) {
                txtHeader.Text = "担保に供されている資産は以下のとおりである。";
            }
            else {
                txtHeader.Text = "担保している債務の種類および金額は以下のとおりである。";
            }
        }


    }
}
