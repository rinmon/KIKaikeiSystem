namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// BalanceSheetSubHusaiJunshisan の概要の説明です。
    /// </summary>
    partial class BalanceSheetSubHusaiJunshisan
    {
        private DataDynamics.ActiveReports.PageHeader pageHeader;
        private DataDynamics.ActiveReports.Detail detail;
        private DataDynamics.ActiveReports.PageFooter pageFooter;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
            }
            base.Dispose(disposing);
        }

        #region ActiveReport デザイナで生成されたコード
        /// <summary>
        /// デザイナ サポートに必要なメソッドです。
        /// このメソッドの内容をコード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BalanceSheetSubHusaiJunshisan));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.subBalanceSheetHusai = new DataDynamics.ActiveReports.SubReport();
            this.subBalanceSheetJunshisan = new DataDynamics.ActiveReports.SubReport();
            this.txtDaikubunName = new DataDynamics.ActiveReports.TextBox();
            this.txtHusaiSumSai = new DataDynamics.ActiveReports.TextBox();
            this.txtHusaiSumZennen = new DataDynamics.ActiveReports.TextBox();
            this.txtHusaiSumTounen = new DataDynamics.ActiveReports.TextBox();
            this.txtJunshisanSummaryCaption = new DataDynamics.ActiveReports.TextBox();
            this.txtJunshisanSumTounen = new DataDynamics.ActiveReports.TextBox();
            this.txtJunshisanSumZennen = new DataDynamics.ActiveReports.TextBox();
            this.txtJunshisanSumSai = new DataDynamics.ActiveReports.TextBox();
            this.textBox15 = new DataDynamics.ActiveReports.TextBox();
            this.textBox17 = new DataDynamics.ActiveReports.TextBox();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubunName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHusaiSumSai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHusaiSumZennen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHusaiSumTounen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJunshisanSummaryCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJunshisanSumTounen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJunshisanSumZennen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJunshisanSumSai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Height = 0F;
            this.pageHeader.Name = "pageHeader";
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.subBalanceSheetHusai,
            this.subBalanceSheetJunshisan,
            this.txtDaikubunName,
            this.txtHusaiSumSai,
            this.txtHusaiSumZennen,
            this.txtHusaiSumTounen,
            this.txtJunshisanSummaryCaption,
            this.txtJunshisanSumTounen,
            this.txtJunshisanSumZennen,
            this.txtJunshisanSumSai,
            this.textBox15,
            this.textBox17});
            this.detail.Height = 1.886221F;
            this.detail.Name = "detail";
            this.detail.Format += new System.EventHandler(this.detail_Format);
            // 
            // subBalanceSheetHusai
            // 
            this.subBalanceSheetHusai.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.subBalanceSheetHusai.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.subBalanceSheetHusai.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.subBalanceSheetHusai.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.subBalanceSheetHusai.CloseBorder = false;
            this.subBalanceSheetHusai.Height = 0.3220473F;
            this.subBalanceSheetHusai.Left = 0F;
            this.subBalanceSheetHusai.Name = "subBalanceSheetHusai";
            this.subBalanceSheetHusai.Report = null;
            this.subBalanceSheetHusai.ReportName = "";
            this.subBalanceSheetHusai.Top = 0.1771654F;
            this.subBalanceSheetHusai.Width = 3.583465F;
            // 
            // subBalanceSheetJunshisan
            // 
            this.subBalanceSheetJunshisan.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.subBalanceSheetJunshisan.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.subBalanceSheetJunshisan.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.subBalanceSheetJunshisan.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.subBalanceSheetJunshisan.CloseBorder = false;
            this.subBalanceSheetJunshisan.Height = 0.6736221F;
            this.subBalanceSheetJunshisan.Left = 0F;
            this.subBalanceSheetJunshisan.Name = "subBalanceSheetJunshisan";
            this.subBalanceSheetJunshisan.Report = null;
            this.subBalanceSheetJunshisan.ReportName = "";
            this.subBalanceSheetJunshisan.Top = 1.038976F;
            this.subBalanceSheetJunshisan.Width = 3.583465F;
            // 
            // txtDaikubunName
            // 
            this.txtDaikubunName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDaikubunName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDaikubunName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDaikubunName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDaikubunName.CanGrow = false;
            this.txtDaikubunName.Height = 0.1736221F;
            this.txtDaikubunName.Left = 0F;
            this.txtDaikubunName.Name = "txtDaikubunName";
            this.txtDaikubunName.OutputFormat = resources.GetString("txtDaikubunName.OutputFormat");
            this.txtDaikubunName.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 7pt; font-weight: normal; text-al" +
    "ign: center; vertical-align: middle; ddo-char-set: 1";
            this.txtDaikubunName.Tag = "";
            this.txtDaikubunName.Text = "負債の部合計";
            this.txtDaikubunName.Top = 0.4996063F;
            this.txtDaikubunName.Width = 1.574803F;
            // 
            // txtHusaiSumSai
            // 
            this.txtHusaiSumSai.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiSumSai.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiSumSai.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiSumSai.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiSumSai.CanGrow = false;
            this.txtHusaiSumSai.Height = 0.1736221F;
            this.txtHusaiSumSai.Left = 2.913386F;
            this.txtHusaiSumSai.Name = "txtHusaiSumSai";
            this.txtHusaiSumSai.OutputFormat = resources.GetString("txtHusaiSumSai.OutputFormat");
            this.txtHusaiSumSai.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: middle; ddo-char-set: 128";
            this.txtHusaiSumSai.Tag = "";
            this.txtHusaiSumSai.Text = null;
            this.txtHusaiSumSai.Top = 0.4996063F;
            this.txtHusaiSumSai.Width = 0.6692914F;
            // 
            // txtHusaiSumZennen
            // 
            this.txtHusaiSumZennen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiSumZennen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiSumZennen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiSumZennen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiSumZennen.CanGrow = false;
            this.txtHusaiSumZennen.Height = 0.1736221F;
            this.txtHusaiSumZennen.Left = 2.244094F;
            this.txtHusaiSumZennen.Name = "txtHusaiSumZennen";
            this.txtHusaiSumZennen.OutputFormat = resources.GetString("txtHusaiSumZennen.OutputFormat");
            this.txtHusaiSumZennen.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: middle; ddo-char-set: 128";
            this.txtHusaiSumZennen.Tag = "";
            this.txtHusaiSumZennen.Text = null;
            this.txtHusaiSumZennen.Top = 0.4996063F;
            this.txtHusaiSumZennen.Width = 0.6692911F;
            // 
            // txtHusaiSumTounen
            // 
            this.txtHusaiSumTounen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiSumTounen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiSumTounen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiSumTounen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiSumTounen.CanGrow = false;
            this.txtHusaiSumTounen.Height = 0.1736221F;
            this.txtHusaiSumTounen.Left = 1.574803F;
            this.txtHusaiSumTounen.Name = "txtHusaiSumTounen";
            this.txtHusaiSumTounen.OutputFormat = resources.GetString("txtHusaiSumTounen.OutputFormat");
            this.txtHusaiSumTounen.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: middle; ddo-char-set: 128";
            this.txtHusaiSumTounen.Tag = "";
            this.txtHusaiSumTounen.Text = null;
            this.txtHusaiSumTounen.Top = 0.4996063F;
            this.txtHusaiSumTounen.Width = 0.6692914F;
            // 
            // txtJunshisanSummaryCaption
            // 
            this.txtJunshisanSummaryCaption.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJunshisanSummaryCaption.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJunshisanSummaryCaption.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJunshisanSummaryCaption.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJunshisanSummaryCaption.CanGrow = false;
            this.txtJunshisanSummaryCaption.Height = 0.1736221F;
            this.txtJunshisanSummaryCaption.Left = 0F;
            this.txtJunshisanSummaryCaption.Name = "txtJunshisanSummaryCaption";
            this.txtJunshisanSummaryCaption.OutputFormat = resources.GetString("txtJunshisanSummaryCaption.OutputFormat");
            this.txtJunshisanSummaryCaption.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 6.75pt; font-weight: normal; text" +
    "-align: center; vertical-align: middle; ddo-char-set: 128";
            this.txtJunshisanSummaryCaption.Tag = "";
            this.txtJunshisanSummaryCaption.Text = "純資産の部合計";
            this.txtJunshisanSummaryCaption.Top = 1.712992F;
            this.txtJunshisanSummaryCaption.Width = 1.574803F;
            // 
            // txtJunshisanSumTounen
            // 
            this.txtJunshisanSumTounen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJunshisanSumTounen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJunshisanSumTounen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJunshisanSumTounen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJunshisanSumTounen.CanGrow = false;
            this.txtJunshisanSumTounen.Height = 0.1736221F;
            this.txtJunshisanSumTounen.Left = 1.574803F;
            this.txtJunshisanSumTounen.Name = "txtJunshisanSumTounen";
            this.txtJunshisanSumTounen.OutputFormat = resources.GetString("txtJunshisanSumTounen.OutputFormat");
            this.txtJunshisanSumTounen.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: bottom; ddo-char-set: 128";
            this.txtJunshisanSumTounen.Tag = "";
            this.txtJunshisanSumTounen.Text = null;
            this.txtJunshisanSumTounen.Top = 1.712992F;
            this.txtJunshisanSumTounen.Width = 0.6692914F;
            // 
            // txtJunshisanSumZennen
            // 
            this.txtJunshisanSumZennen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJunshisanSumZennen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJunshisanSumZennen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJunshisanSumZennen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJunshisanSumZennen.CanGrow = false;
            this.txtJunshisanSumZennen.Height = 0.1736221F;
            this.txtJunshisanSumZennen.Left = 2.244094F;
            this.txtJunshisanSumZennen.Name = "txtJunshisanSumZennen";
            this.txtJunshisanSumZennen.OutputFormat = resources.GetString("txtJunshisanSumZennen.OutputFormat");
            this.txtJunshisanSumZennen.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: bottom; ddo-char-set: 128";
            this.txtJunshisanSumZennen.Tag = "";
            this.txtJunshisanSumZennen.Text = null;
            this.txtJunshisanSumZennen.Top = 1.712992F;
            this.txtJunshisanSumZennen.Width = 0.6692911F;
            // 
            // txtJunshisanSumSai
            // 
            this.txtJunshisanSumSai.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJunshisanSumSai.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJunshisanSumSai.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJunshisanSumSai.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJunshisanSumSai.CanGrow = false;
            this.txtJunshisanSumSai.Height = 0.1736221F;
            this.txtJunshisanSumSai.Left = 2.913386F;
            this.txtJunshisanSumSai.Name = "txtJunshisanSumSai";
            this.txtJunshisanSumSai.OutputFormat = resources.GetString("txtJunshisanSumSai.OutputFormat");
            this.txtJunshisanSumSai.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: bottom; ddo-char-set: 128";
            this.txtJunshisanSumSai.Tag = "";
            this.txtJunshisanSumSai.Text = null;
            this.txtJunshisanSumSai.Top = 1.712992F;
            this.txtJunshisanSumSai.Width = 0.6692915F;
            // 
            // textBox15
            // 
            this.textBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox15.CanGrow = false;
            this.textBox15.Height = 0.1771654F;
            this.textBox15.Left = 0F;
            this.textBox15.Name = "textBox15";
            this.textBox15.OutputFormat = resources.GetString("textBox15.OutputFormat");
            this.textBox15.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 6.75pt; font-weight: normal; text" +
    "-align: center; vertical-align: middle; ddo-char-set: 128";
            this.textBox15.Tag = "";
            this.textBox15.Text = "負 債 の 部";
            this.textBox15.Top = 0F;
            this.textBox15.Width = 3.582677F;
            // 
            // textBox17
            // 
            this.textBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox17.CanGrow = false;
            this.textBox17.Height = 0.1771654F;
            this.textBox17.Left = 0F;
            this.textBox17.Name = "textBox17";
            this.textBox17.OutputFormat = resources.GetString("textBox17.OutputFormat");
            this.textBox17.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 7pt; font-weight: normal; text-al" +
    "ign: center; vertical-align: middle; ddo-char-set: 1";
            this.textBox17.Tag = "";
            this.textBox17.Text = "純 資 産 の 部";
            this.textBox17.Top = 0.8618112F;
            this.textBox17.Width = 3.582677F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // BalanceSheetSubHusaiJunshisan
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 3.582677F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubunName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHusaiSumSai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHusaiSumZennen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHusaiSumTounen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJunshisanSummaryCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJunshisanSumTounen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJunshisanSumZennen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJunshisanSumSai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.SubReport subBalanceSheetHusai;
        private DataDynamics.ActiveReports.SubReport subBalanceSheetJunshisan;
        private DataDynamics.ActiveReports.TextBox txtDaikubunName;
        private DataDynamics.ActiveReports.TextBox txtHusaiSumSai;
        private DataDynamics.ActiveReports.TextBox txtHusaiSumZennen;
        private DataDynamics.ActiveReports.TextBox txtHusaiSumTounen;
        private DataDynamics.ActiveReports.TextBox txtJunshisanSummaryCaption;
        private DataDynamics.ActiveReports.TextBox txtJunshisanSumTounen;
        private DataDynamics.ActiveReports.TextBox txtJunshisanSumZennen;
        private DataDynamics.ActiveReports.TextBox txtJunshisanSumSai;
        private DataDynamics.ActiveReports.TextBox textBox15;
        private DataDynamics.ActiveReports.TextBox textBox17;
    }
}
