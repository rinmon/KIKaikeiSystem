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
    /// KanjouKamokuReport の概要の説明です。
    /// </summary>
    partial class KanjouKamokuReport : DataDynamics.ActiveReports.ActiveReport
    {
        public List<models.query.KanjouKamokuList.KanjouKamokuListRow> Rows{get;set;}

        public KanjouKamokuReport() {
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

        private void detail_Format(object sender, EventArgs e) {
            int index = helper.Converter.ObjToInt(txtId.Text, -1);

            if (index == -1) {
                return;
            }

            var row = Rows[index];
            var rows = Rows.GetRange(index, 1);

            if(row.Hierarchy == (int)models.constants.MTKanjouKamokuHierarchy.ChuuKubun){
                var report = new KanjouKamokuReportChukubunRow();
                report.DataSource = rows;
                this.subReport.Report = report;
            }
            else if (row.Hierarchy == (int)models.constants.MTKanjouKamokuHierarchy.SyouKubun) {
                var report = new KanjouKamokuReportSyoukubunRow();
                report.DataSource = rows;
                this.subReport.Report = report;
            }
            else if (row.Hierarchy == (int)models.constants.MTKanjouKamokuHierarchy.HojoKamoku) {
                var report = new KanjouKamokuReportHojokamokuRow();
                report.DataSource = rows;
                this.subReport.Report = report;
            }
        }

        private void groupHeader1_Format(object sender, EventArgs e) {
            txtDaikubun.Text = "【" + txtDaikubun.Text + "】";
        }


    }
}
