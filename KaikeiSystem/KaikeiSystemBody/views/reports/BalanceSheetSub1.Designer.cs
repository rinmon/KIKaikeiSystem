namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// BalanceSheetSub1 の概要の説明です。
    /// </summary>
    partial class BalanceSheetSub1
    {
        private DataDynamics.ActiveReports.PageHeader pageHeader;
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BalanceSheetSub1));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.subBalanceSheetShisan = new DataDynamics.ActiveReports.SubReport();
            this.textBox16 = new DataDynamics.ActiveReports.TextBox();
            this.subHusaiJunshisan = new DataDynamics.ActiveReports.SubReport();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.groupHeader1 = new DataDynamics.ActiveReports.GroupHeader();
            this.groupFooter1 = new DataDynamics.ActiveReports.GroupFooter();
            this.textBox7 = new DataDynamics.ActiveReports.TextBox();
            this.txtHusaiJunshisanTounen = new DataDynamics.ActiveReports.TextBox();
            this.txtHusaiJunshisanZennen = new DataDynamics.ActiveReports.TextBox();
            this.txtHusaiJunshisanSai = new DataDynamics.ActiveReports.TextBox();
            this.textBox11 = new DataDynamics.ActiveReports.TextBox();
            this.txtShisanSumTounen = new DataDynamics.ActiveReports.TextBox();
            this.txtShisanSumZennen = new DataDynamics.ActiveReports.TextBox();
            this.txtShisanSumSai = new DataDynamics.ActiveReports.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.textBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHusaiJunshisanTounen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHusaiJunshisanZennen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHusaiJunshisanSai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisanSumTounen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisanSumZennen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisanSumSai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Height = 0F;
            this.pageHeader.Name = "pageHeader";
            // 
            // detail
            // 
            this.detail.CanShrink = true;
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.subBalanceSheetShisan,
            this.textBox16,
            this.subHusaiJunshisan});
            this.detail.Height = 1.88622F;
            this.detail.Name = "detail";
            this.detail.Format += new System.EventHandler(this.detail_Format);
            this.detail.BeforePrint += new System.EventHandler(this.detail_BeforePrint);
            this.detail.AfterPrint += new System.EventHandler(this.detail_AfterPrint);
            // 
            // subBalanceSheetShisan
            // 
            this.subBalanceSheetShisan.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.subBalanceSheetShisan.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.subBalanceSheetShisan.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.subBalanceSheetShisan.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.subBalanceSheetShisan.CloseBorder = false;
            this.subBalanceSheetShisan.Height = 1.709055F;
            this.subBalanceSheetShisan.Left = 0.003543307F;
            this.subBalanceSheetShisan.Name = "subBalanceSheetShisan";
            this.subBalanceSheetShisan.Report = null;
            this.subBalanceSheetShisan.ReportName = "";
            this.subBalanceSheetShisan.Top = 0.1771654F;
            this.subBalanceSheetShisan.Width = 3.583465F;
            // 
            // textBox16
            // 
            this.textBox16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox16.CanGrow = false;
            this.textBox16.Height = 0.1771654F;
            this.textBox16.Left = -2.910383E-10F;
            this.textBox16.Name = "textBox16";
            this.textBox16.OutputFormat = resources.GetString("textBox16.OutputFormat");
            this.textBox16.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 7pt; font-weight: normal; text-al" +
    "ign: center; vertical-align: middle; ddo-char-set: 1";
            this.textBox16.Tag = "";
            this.textBox16.Text = "資 産 の 部";
            this.textBox16.Top = 0F;
            this.textBox16.Width = 3.582677F;
            // 
            // subHusaiJunshisan
            // 
            this.subHusaiJunshisan.CloseBorder = false;
            this.subHusaiJunshisan.Height = 1.88622F;
            this.subHusaiJunshisan.Left = 3.587008F;
            this.subHusaiJunshisan.Name = "subHusaiJunshisan";
            this.subHusaiJunshisan.Report = null;
            this.subHusaiJunshisan.ReportName = "subReport1";
            this.subHusaiJunshisan.Top = 0F;
            this.subHusaiJunshisan.Width = 3.583465F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // groupHeader1
            // 
            this.groupHeader1.Height = 0F;
            this.groupHeader1.Name = "groupHeader1";
            // 
            // groupFooter1
            // 
            this.groupFooter1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.textBox7,
            this.txtHusaiJunshisanTounen,
            this.txtHusaiJunshisanZennen,
            this.txtHusaiJunshisanSai,
            this.textBox11,
            this.txtShisanSumTounen,
            this.txtShisanSumZennen,
            this.txtShisanSumSai});
            this.groupFooter1.Height = 0.1736221F;
            this.groupFooter1.Name = "groupFooter1";
            // 
            // textBox7
            // 
            this.textBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox7.CanGrow = false;
            this.textBox7.Height = 0.1736221F;
            this.textBox7.Left = 3.582677F;
            this.textBox7.Name = "textBox7";
            this.textBox7.OutputFormat = resources.GetString("textBox7.OutputFormat");
            this.textBox7.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 6.75pt; font-weight: normal; text" +
    "-align: center; vertical-align: middle; ddo-char-set: 128";
            this.textBox7.Tag = "";
            this.textBox7.Text = "負債及び純資産の部合計";
            this.textBox7.Top = 0F;
            this.textBox7.Width = 1.574803F;
            // 
            // txtHusaiJunshisanTounen
            // 
            this.txtHusaiJunshisanTounen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiJunshisanTounen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiJunshisanTounen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiJunshisanTounen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiJunshisanTounen.CanGrow = false;
            this.txtHusaiJunshisanTounen.Height = 0.1736221F;
            this.txtHusaiJunshisanTounen.Left = 5.157481F;
            this.txtHusaiJunshisanTounen.Name = "txtHusaiJunshisanTounen";
            this.txtHusaiJunshisanTounen.OutputFormat = resources.GetString("txtHusaiJunshisanTounen.OutputFormat");
            this.txtHusaiJunshisanTounen.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: bottom; ddo-char-set: 128";
            this.txtHusaiJunshisanTounen.Tag = "";
            this.txtHusaiJunshisanTounen.Text = null;
            this.txtHusaiJunshisanTounen.Top = 0F;
            this.txtHusaiJunshisanTounen.Width = 0.6694444F;
            // 
            // txtHusaiJunshisanZennen
            // 
            this.txtHusaiJunshisanZennen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiJunshisanZennen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiJunshisanZennen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiJunshisanZennen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiJunshisanZennen.CanGrow = false;
            this.txtHusaiJunshisanZennen.Height = 0.1736221F;
            this.txtHusaiJunshisanZennen.Left = 5.826772F;
            this.txtHusaiJunshisanZennen.Name = "txtHusaiJunshisanZennen";
            this.txtHusaiJunshisanZennen.OutputFormat = resources.GetString("txtHusaiJunshisanZennen.OutputFormat");
            this.txtHusaiJunshisanZennen.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: bottom; ddo-char-set: 128";
            this.txtHusaiJunshisanZennen.Tag = "";
            this.txtHusaiJunshisanZennen.Text = null;
            this.txtHusaiJunshisanZennen.Top = 0F;
            this.txtHusaiJunshisanZennen.Width = 0.6694444F;
            // 
            // txtHusaiJunshisanSai
            // 
            this.txtHusaiJunshisanSai.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiJunshisanSai.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiJunshisanSai.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiJunshisanSai.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHusaiJunshisanSai.CanGrow = false;
            this.txtHusaiJunshisanSai.Height = 0.1736221F;
            this.txtHusaiJunshisanSai.Left = 6.496063F;
            this.txtHusaiJunshisanSai.Name = "txtHusaiJunshisanSai";
            this.txtHusaiJunshisanSai.OutputFormat = resources.GetString("txtHusaiJunshisanSai.OutputFormat");
            this.txtHusaiJunshisanSai.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: bottom; ddo-char-set: 128";
            this.txtHusaiJunshisanSai.Tag = "";
            this.txtHusaiJunshisanSai.Text = null;
            this.txtHusaiJunshisanSai.Top = 0F;
            this.txtHusaiJunshisanSai.Width = 0.6694444F;
            // 
            // textBox11
            // 
            this.textBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox11.CanGrow = false;
            this.textBox11.Height = 0.1736221F;
            this.textBox11.Left = -5.529728E-09F;
            this.textBox11.Name = "textBox11";
            this.textBox11.OutputFormat = resources.GetString("textBox11.OutputFormat");
            this.textBox11.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 6.75pt; font-weight: normal; text" +
    "-align: center; vertical-align: middle; ddo-char-set: 128";
            this.textBox11.Tag = "";
            this.textBox11.Text = "資産の部合計";
            this.textBox11.Top = 0F;
            this.textBox11.Width = 1.574803F;
            // 
            // txtShisanSumTounen
            // 
            this.txtShisanSumTounen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisanSumTounen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisanSumTounen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisanSumTounen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisanSumTounen.CanGrow = false;
            this.txtShisanSumTounen.Height = 0.1736221F;
            this.txtShisanSumTounen.Left = 1.574803F;
            this.txtShisanSumTounen.Name = "txtShisanSumTounen";
            this.txtShisanSumTounen.OutputFormat = resources.GetString("txtShisanSumTounen.OutputFormat");
            this.txtShisanSumTounen.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: bottom; ddo-char-set: 128";
            this.txtShisanSumTounen.Tag = "";
            this.txtShisanSumTounen.Text = null;
            this.txtShisanSumTounen.Top = 0F;
            this.txtShisanSumTounen.Width = 0.6694444F;
            // 
            // txtShisanSumZennen
            // 
            this.txtShisanSumZennen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisanSumZennen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisanSumZennen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisanSumZennen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisanSumZennen.CanGrow = false;
            this.txtShisanSumZennen.Height = 0.1736221F;
            this.txtShisanSumZennen.Left = 2.244094F;
            this.txtShisanSumZennen.Name = "txtShisanSumZennen";
            this.txtShisanSumZennen.OutputFormat = resources.GetString("txtShisanSumZennen.OutputFormat");
            this.txtShisanSumZennen.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: bottom; ddo-char-set: 128";
            this.txtShisanSumZennen.Tag = "";
            this.txtShisanSumZennen.Text = null;
            this.txtShisanSumZennen.Top = 0F;
            this.txtShisanSumZennen.Width = 0.6694444F;
            // 
            // txtShisanSumSai
            // 
            this.txtShisanSumSai.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisanSumSai.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisanSumSai.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisanSumSai.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisanSumSai.CanGrow = false;
            this.txtShisanSumSai.Height = 0.1736221F;
            this.txtShisanSumSai.Left = 2.913386F;
            this.txtShisanSumSai.Name = "txtShisanSumSai";
            this.txtShisanSumSai.OutputFormat = resources.GetString("txtShisanSumSai.OutputFormat");
            this.txtShisanSumSai.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: bottom; ddo-char-set: 128";
            this.txtShisanSumSai.Tag = "";
            this.txtShisanSumSai.Text = null;
            this.txtShisanSumSai.Top = 0F;
            this.txtShisanSumSai.Width = 0.6694444F;
            // 
            // BalanceSheetSub1
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 7.165508F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.groupHeader1);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.groupFooter1);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.textBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHusaiJunshisanTounen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHusaiJunshisanZennen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHusaiJunshisanSai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisanSumTounen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisanSumZennen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisanSumSai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.SubReport subBalanceSheetShisan;
        private DataDynamics.ActiveReports.GroupHeader groupHeader1;
        private DataDynamics.ActiveReports.GroupFooter groupFooter1;
        private DataDynamics.ActiveReports.TextBox textBox7;
        private DataDynamics.ActiveReports.TextBox txtHusaiJunshisanTounen;
        private DataDynamics.ActiveReports.TextBox txtHusaiJunshisanZennen;
        private DataDynamics.ActiveReports.TextBox txtHusaiJunshisanSai;
        private DataDynamics.ActiveReports.TextBox textBox11;
        private DataDynamics.ActiveReports.TextBox txtShisanSumTounen;
        private DataDynamics.ActiveReports.TextBox txtShisanSumZennen;
        private DataDynamics.ActiveReports.TextBox txtShisanSumSai;
        private DataDynamics.ActiveReports.TextBox textBox16;
        private DataDynamics.ActiveReports.Detail detail;
        private DataDynamics.ActiveReports.SubReport subHusaiJunshisan;
    }
}
