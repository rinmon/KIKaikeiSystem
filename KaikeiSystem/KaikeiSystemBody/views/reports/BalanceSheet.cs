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
    /// BalanceSheet の概要の説明です。
    /// </summary>
    partial class BalanceSheet : DataDynamics.ActiveReports.ActiveReport
    {
        private models.db.KaikeiDatabase db;

        private object shisanDataSource;
        private object husaiDataSource;
        private object junshisanDataSource;
        private object tyuuki1DataSource;
        private object tyuuki3DataSource;
        private object tyuuki4DataSource;
        private object tyuuki5DataSource;

        private models.query.BalanceSheet.BalanceSheetRow shisanSumRow;
        private models.query.BalanceSheet.BalanceSheetRow husaiSumRow;
        private models.query.BalanceSheet.BalanceSheetRow junshisanSumRow;
        private models.query.BalanceSheet.BalanceSheetRow husaiAndJunshisanSumRow;
        private models.query.BalanceSheet.BalanceSheetRow jikiKurikoshiSumRow;
        private models.query.BalanceSheet.BalanceSheetRow toukiKatsudouSumRow;

        public BalanceSheet() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.500f);
            this.PageSettings.Margins.Bottom = CmToInch(0.50f);
            this.PageSettings.Margins.Left = CmToInch(1.50f);
            this.PageSettings.Margins.Right = CmToInch(0.500f);
        }

        public void SetDB(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }

        public void SetHeader(string houjinMei, string kaikeiKubun, DateTime date, string title, string youshiki) {
            txtHoujinmei.Text = houjinMei;
            txtKaikeiKubun.Text = kaikeiKubun;
            txtDate.Text = helper.Converter.DateTimeToWarekiStrKanji(date);
            labelTitle.Text = title;
            labelYoushiki.Text = youshiki;
        }

        public void SetSummaryRow(models.query.BalanceSheet.BalanceSheetRow shisanRow,
            models.query.BalanceSheet.BalanceSheetRow husaiRow,
            models.query.BalanceSheet.BalanceSheetRow junshisanRow,
            models.query.BalanceSheet.BalanceSheetRow husaiJunshisanRow,
            models.query.BalanceSheet.BalanceSheetRow jikiKurikoshiRow,
            models.query.BalanceSheet.BalanceSheetRow toukiKatsudouRow) {

            shisanSumRow = shisanRow;
            husaiSumRow = husaiRow;
            junshisanSumRow = junshisanRow;
            husaiAndJunshisanSumRow = husaiJunshisanRow;
            jikiKurikoshiSumRow = jikiKurikoshiRow;
            toukiKatsudouSumRow = toukiKatsudouRow;
        }

        public void SetDataSource(object shisan, object husai, object junshisan, object tyuuki1, object tyuuki3, object tyuuki4, object tyuuki5) {
            shisanDataSource = shisan;
            husaiDataSource = husai;
            junshisanDataSource = junshisan;
            tyuuki1DataSource = tyuuki1;
            tyuuki3DataSource = tyuuki3;
            tyuuki4DataSource = tyuuki4;
            tyuuki5DataSource = tyuuki5;
        }

        public void SetTyuukiData(long genkaSyoukyakuRuikei, long tyousyuuHunouGaku, string tyuuki2, string tyuuki6) {
/*            txtGenkaSyoukyaku.Value = genkaSyoukyakuRuikei;
            txtTyousyuuHunouGaku.Value = tyousyuuHunouGaku;
            txtBalanceSheetTyuuki2.Text = tyuuki2;
            txtBalanceSheetTyuuki6.Text = tyuuki6;
*/        }

        private void detail_Format(object sender, EventArgs e) {

            var subBalanceSheetReport = new BalanceSheetSub1();
            subBalanceSheetReport.SetDB(db);
            subBalanceSheetReport.SetDataSource(shisanDataSource, husaiDataSource, junshisanDataSource);
            subBalanceSheetReport.SetSummaryRow(
                shisanSumRow,
                husaiSumRow,
                junshisanSumRow,
                husaiAndJunshisanSumRow,
                jikiKurikoshiSumRow,
                toukiKatsudouSumRow);
            this.subBalanceSheet.Report = subBalanceSheetReport;

/*            var tyuuki1Report = new BalanceSheetTyuuki1();
            tyuuki1Report.DataSource = tyuuki1DataSource;
            this.subBalanceSheetTyuuki1.Report = tyuuki1Report;

            var tyuuki3Report = new BalanceSheetTyuuki3();
            tyuuki3Report.DataSource = tyuuki3DataSource;
            this.subBalanceSheetTyuuki3.Report = tyuuki3Report;

            var tyuuki4Report = new BalanceSheetTyuuki4();
            tyuuki4Report.DataSource = tyuuki4DataSource;
            this.subBalanceSheetTyuuki4.Report = tyuuki4Report;

            var tyuuki5Report = new BalanceSheetTyuuki5();
            tyuuki5Report.DataSource = tyuuki5DataSource;
            this.subBalanceSheetTyuuki5.Report = tyuuki5Report;
*/        }
    }
}
