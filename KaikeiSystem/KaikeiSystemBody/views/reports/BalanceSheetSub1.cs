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
    /// BalanceSheetSub1 の概要の説明です。
    /// </summary>
    partial class BalanceSheetSub1 : DataDynamics.ActiveReports.ActiveReport
    {
        private models.db.KaikeiDatabase db;

        private object shisanDataSource;
        private object husaiDataSource;
        private object junshisanDataSource;

        private models.query.BalanceSheet.BalanceSheetRow husaiSumRow;
        private models.query.BalanceSheet.BalanceSheetRow junshisanSumRow;
        private models.query.BalanceSheet.BalanceSheetRow jikiKurikoshiSumRow;
        private models.query.BalanceSheet.BalanceSheetRow toukiKatsudouSumRow;


        //private float husaiHeightBeforeLayout;
        //private float junshisanHeightBeforeLayout;

        //private List<ARControl> controlsBelowHusaiTable;
        //private List<ARControl> controlsBelowJunshisanTable;

        public BalanceSheetSub1() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();
/*
            controlsBelowHusaiTable = new List<ARControl>();
            controlsBelowJunshisanTable = new List<ARControl>();

            float husaiTableCenter = subBalanceSheetHusai.Height / 2 + subBalanceSheetHusai.Top;
            float junshisanTableCenter = subBalanceSheetJunshisan.Height / 2 + subBalanceSheetJunshisan.Top;
            for (int i = 0; i < detail.Controls.Count; i++) {
                ARControl ctrl = detail.Controls[i];

                if (ctrl.Top >= junshisanTableCenter) {
                    controlsBelowJunshisanTable.Add(ctrl);
                }
                else if (ctrl.Top >= husaiTableCenter) {
                    controlsBelowHusaiTable.Add(ctrl);
                }
            }*/
        }

        public void SetDB(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }

        public void SetDataSource(object shisan, object husai, object junshisan) {
            shisanDataSource = shisan;
            husaiDataSource = husai;
            junshisanDataSource = junshisan;
        }

        public void SetSummaryRow(models.query.BalanceSheet.BalanceSheetRow shisanRow,
            models.query.BalanceSheet.BalanceSheetRow husaiRow,
            models.query.BalanceSheet.BalanceSheetRow junshisanRow,
            models.query.BalanceSheet.BalanceSheetRow husaiJunshisanRow,
            models.query.BalanceSheet.BalanceSheetRow jikiKurikoshiRow,
            models.query.BalanceSheet.BalanceSheetRow toukiKatsudouRow) {

            txtShisanSumTounen.Value = shisanRow.CurrentSumAmount;
            txtShisanSumZennen.Value = shisanRow.LastSumAmount;
            txtShisanSumSai.Value = shisanRow.Sai;

            txtHusaiJunshisanTounen.Value = husaiJunshisanRow.CurrentSumAmount;
            txtHusaiJunshisanZennen.Value = husaiJunshisanRow.LastSumAmount;
            txtHusaiJunshisanSai.Value = husaiJunshisanRow.Sai;

            husaiSumRow = husaiRow;
            junshisanSumRow = junshisanRow;
            jikiKurikoshiSumRow = jikiKurikoshiRow;
            toukiKatsudouSumRow = toukiKatsudouRow;
        }

        private void detail_Format(object sender, EventArgs e) {
            //husaiHeightBeforeLayout = subBalanceSheetHusai.Height;
            //junshisanHeightBeforeLayout = subBalanceSheetJunshisan.Height;

            // 負債
            //var husaiSubReport = new BalanceSheetSub2();
            //husaiSubReport.SetDB(db);
            //husaiSubReport.DataSource = husaiDataSource;
            //this.subBalanceSheetHusai.Report = husaiSubReport;

            // 資産
            var shisanSubReport = new BalanceSheetSub2();
            shisanSubReport.SetDB(db);
            shisanSubReport.DataSource = shisanDataSource;
            this.subBalanceSheetShisan.Report = shisanSubReport;


            // 純資産
            //var junshisanSubReport = new BalanceSheetSub2Junshisan();
            //junshisanSubReport.SetDB(db);
            //junshisanSubReport.DataSource = junshisanDataSource;
            //this.subBalanceSheetJunshisan.Report = junshisanSubReport;

            var husaiJunshisanReport = new BalanceSheetSubHusaiJunshisan();
            husaiJunshisanReport.SetDB(db);
            husaiJunshisanReport.SetDataSource(husaiDataSource, junshisanDataSource);
            husaiJunshisanReport.SetSummaryRow(
                husaiSumRow,
                junshisanSumRow,
                jikiKurikoshiSumRow,
                toukiKatsudouSumRow);
            this.subHusaiJunshisan.Report = husaiJunshisanReport;
        }

        private void detail_BeforePrint(object sender, EventArgs e) {
/*            float husaiDelta = subBalanceSheetHusai.Height - husaiHeightBeforeLayout;

            foreach (var ctrl in controlsBelowHusaiTable) {
                ctrl.Top = ctrl.Top + husaiDelta;
            }

            float junshisanSumDelta = subBalanceSheetJunshisan.Height - junshisanHeightBeforeLayout;
            junshisanSumDelta += husaiDelta;

            float wk = subBalanceSheetShisan.Top + subBalanceSheetShisan.Height -
                        (subBalanceSheetJunshisan.Top + subBalanceSheetJunshisan.Height + txtJunshisanSummaryCaption.Height);
            if (wk > 0) {
                junshisanSumDelta += wk;
            }

            foreach (var ctrl in controlsBelowJunshisanTable) {
                ctrl.Top = ctrl.Top + junshisanSumDelta;
            }

            //detail.SizeToFit(true);
            detail.Height = txtJunshisanSummaryCaption.Top;*/
        }

        private void detail_AfterPrint(object sender, EventArgs e) {

        }
    }
}
