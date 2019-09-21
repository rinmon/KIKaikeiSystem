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
    /// BalanceSheetSub2Junshisan の概要の説明です。
    /// </summary>
    partial class BalanceSheetSub2Junshisan : DataDynamics.ActiveReports.ActiveReport
    {
        private models.db.KaikeiDatabase db;

        public BalanceSheetSub2Junshisan() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();
        }


        public void SetDB(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }

        public void SetSummaryRow(models.query.BalanceSheet.BalanceSheetRow jikiKurikoshiRow,
                models.query.BalanceSheet.BalanceSheetRow toukiKatsudouRow) {

            txtJikiTounen.Value = jikiKurikoshiRow.CurrentSumAmount;
            txtJikiZennen.Value = jikiKurikoshiRow.LastSumAmount;
            txtJikiSai.Value = jikiKurikoshiRow.Sai;

            txtToukiTounen.Value = toukiKatsudouRow.CurrentSumAmount;
            txtToukiZennen.Value = toukiKatsudouRow.LastSumAmount;
            txtToukiSai.Value = toukiKatsudouRow.Sai;
        }


        private void detail_Format(object sender, EventArgs e) {
            int id = helper.Converter.ObjToInt(txtKamokuId.Text, -1);
            txtKamoku.Text = "  " + db.MTKamokuKubun.GetRowById(id).GetStr("name");
        }

        private void groupHeader1_Format(object sender, EventArgs e) {
            int id = helper.Converter.ObjToInt(txtDaikubunId.Text, -1);
            txtDaikubunName.Text = "【" + db.MTKamokuKubun.GetRowById(id).GetStr("name") + "】";
        }
    }
}
