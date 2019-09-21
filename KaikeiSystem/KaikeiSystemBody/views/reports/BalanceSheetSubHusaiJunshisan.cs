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
    /// BalanceSheetSubHusaiJunshisan の概要の説明です。
    /// </summary>
    partial class BalanceSheetSubHusaiJunshisan : DataDynamics.ActiveReports.ActiveReport
    {
        private models.db.KaikeiDatabase db;

        private object husaiDataSource;
        private object junshisanDataSource;

        private models.query.BalanceSheet.BalanceSheetRow jikiKurikoshiRow;
        private models.query.BalanceSheet.BalanceSheetRow toukiKatsudouRow;


        public BalanceSheetSubHusaiJunshisan() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();
        }
    
        public void SetDB(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }

        public void SetDataSource(object husai, object junshisan) {
            husaiDataSource = husai;
            junshisanDataSource = junshisan;
        }

        public void SetSummaryRow(models.query.BalanceSheet.BalanceSheetRow husaiRow,
                models.query.BalanceSheet.BalanceSheetRow junshisanRow,
                models.query.BalanceSheet.BalanceSheetRow jikiKurikoshiRow_,
                models.query.BalanceSheet.BalanceSheetRow toukiKatsudouRow_) {

            txtHusaiSumTounen.Value = husaiRow.CurrentSumAmount;
            txtHusaiSumZennen.Value = husaiRow.LastSumAmount;
            txtHusaiSumSai.Value = husaiRow.Sai;

            txtJunshisanSumTounen.Value = junshisanRow.CurrentSumAmount;
            txtJunshisanSumZennen.Value = junshisanRow.LastSumAmount;
            txtJunshisanSumSai.Value = junshisanRow.Sai;

            jikiKurikoshiRow = jikiKurikoshiRow_;
            toukiKatsudouRow = toukiKatsudouRow_;
        }

        private void detail_Format(object sender, EventArgs e) {
            // 負債
            var husaiSubReport = new BalanceSheetSub2();
            husaiSubReport.SetDB(db);
            husaiSubReport.DataSource = husaiDataSource;
            this.subBalanceSheetHusai.Report = husaiSubReport;

            // 純資産
            var junshisanSubReport = new BalanceSheetSub2Junshisan();
            junshisanSubReport.SetDB(db);
            junshisanSubReport.DataSource = junshisanDataSource;
            junshisanSubReport.SetSummaryRow(jikiKurikoshiRow, toukiKatsudouRow);
            this.subBalanceSheetJunshisan.Report = junshisanSubReport;
        }

    }
}
