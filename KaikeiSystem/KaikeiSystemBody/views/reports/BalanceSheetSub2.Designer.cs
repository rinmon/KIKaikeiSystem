namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// BalanceSheetShisan の概要の説明です。
    /// </summary>
    partial class BalanceSheetSub2
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BalanceSheetSub2));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.txtKamoku = new DataDynamics.ActiveReports.TextBox();
            this.txtKamokuId = new DataDynamics.ActiveReports.TextBox();
            this.txtZougen = new DataDynamics.ActiveReports.TextBox();
            this.txtTounen = new DataDynamics.ActiveReports.TextBox();
            this.txtZennen = new DataDynamics.ActiveReports.TextBox();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.reportHeader1 = new DataDynamics.ActiveReports.ReportHeader();
            this.テキスト13 = new DataDynamics.ActiveReports.Label();
            this.テキスト16 = new DataDynamics.ActiveReports.Label();
            this.テキスト15 = new DataDynamics.ActiveReports.Label();
            this.テキスト14 = new DataDynamics.ActiveReports.Label();
            this.reportFooter1 = new DataDynamics.ActiveReports.ReportFooter();
            this.groupHeader1 = new DataDynamics.ActiveReports.GroupHeader();
            this.txtDaikubunName = new DataDynamics.ActiveReports.TextBox();
            this.txtDaikubunId = new DataDynamics.ActiveReports.TextBox();
            this.textBox3 = new DataDynamics.ActiveReports.TextBox();
            this.txtTounenSum = new DataDynamics.ActiveReports.TextBox();
            this.textBox5 = new DataDynamics.ActiveReports.TextBox();
            this.groupFooter1 = new DataDynamics.ActiveReports.GroupFooter();
            ((System.ComponentModel.ISupportInitialize)(this.txtKamoku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKamokuId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZougen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTounen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZennen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.テキスト13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.テキスト16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.テキスト15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.テキスト14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubunName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubunId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTounenSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).BeginInit();
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
            this.txtKamoku,
            this.txtKamokuId,
            this.txtZougen,
            this.txtTounen,
            this.txtZennen});
            this.detail.Height = 0.125F;
            this.detail.Name = "detail";
            this.detail.Format += new System.EventHandler(this.detail_Format);
            // 
            // txtKamoku
            // 
            this.txtKamoku.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKamoku.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKamoku.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKamoku.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKamoku.CanGrow = false;
            this.txtKamoku.Height = 0.1251968F;
            this.txtKamoku.Left = 0F;
            this.txtKamoku.Name = "txtKamoku";
            this.txtKamoku.OutputFormat = resources.GetString("txtKamoku.OutputFormat");
            this.txtKamoku.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: left; ddo-char-set" +
    ": 128";
            this.txtKamoku.Tag = "";
            this.txtKamoku.Text = "=\"  \" & [科目]";
            this.txtKamoku.Top = 0F;
            this.txtKamoku.Width = 1.574803F;
            // 
            // txtKamokuId
            // 
            this.txtKamokuId.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKamokuId.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKamokuId.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKamokuId.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKamokuId.CanGrow = false;
            this.txtKamokuId.DataField = "Id";
            this.txtKamokuId.Height = 0.125F;
            this.txtKamokuId.Left = 0.78125F;
            this.txtKamokuId.Name = "txtKamokuId";
            this.txtKamokuId.OutputFormat = resources.GetString("txtKamokuId.OutputFormat");
            this.txtKamokuId.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: left; ddo-char-set" +
    ": 128";
            this.txtKamokuId.Tag = "";
            this.txtKamokuId.Text = "科目ID";
            this.txtKamokuId.Top = 0F;
            this.txtKamokuId.Visible = false;
            this.txtKamokuId.Width = 0.43125F;
            // 
            // txtZougen
            // 
            this.txtZougen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtZougen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtZougen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtZougen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtZougen.CanGrow = false;
            this.txtZougen.DataField = "Sai";
            this.txtZougen.Height = 0.125F;
            this.txtZougen.Left = 2.913386F;
            this.txtZougen.Name = "txtZougen";
            this.txtZougen.OutputFormat = resources.GetString("txtZougen.OutputFormat");
            this.txtZougen.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; ddo-char-se" +
    "t: 128";
            this.txtZougen.Tag = "";
            this.txtZougen.Text = null;
            this.txtZougen.Top = 0F;
            this.txtZougen.Width = 0.6694444F;
            // 
            // txtTounen
            // 
            this.txtTounen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtTounen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtTounen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtTounen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtTounen.CanGrow = false;
            this.txtTounen.DataField = "CurrentSumAmount";
            this.txtTounen.Height = 0.125F;
            this.txtTounen.Left = 1.574803F;
            this.txtTounen.Name = "txtTounen";
            this.txtTounen.OutputFormat = resources.GetString("txtTounen.OutputFormat");
            this.txtTounen.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; ddo-char-se" +
    "t: 128";
            this.txtTounen.Tag = "";
            this.txtTounen.Text = null;
            this.txtTounen.Top = 0F;
            this.txtTounen.Width = 0.6694444F;
            // 
            // txtZennen
            // 
            this.txtZennen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtZennen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtZennen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtZennen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtZennen.CanGrow = false;
            this.txtZennen.DataField = "LastSumAmount";
            this.txtZennen.Height = 0.125F;
            this.txtZennen.Left = 2.244094F;
            this.txtZennen.Name = "txtZennen";
            this.txtZennen.OutputFormat = resources.GetString("txtZennen.OutputFormat");
            this.txtZennen.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; ddo-char-se" +
    "t: 128";
            this.txtZennen.Tag = "";
            this.txtZennen.Text = null;
            this.txtZennen.Top = 0F;
            this.txtZennen.Width = 0.6694444F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // reportHeader1
            // 
            this.reportHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.テキスト13,
            this.テキスト16,
            this.テキスト15,
            this.テキスト14});
            this.reportHeader1.Height = 0.125F;
            this.reportHeader1.Name = "reportHeader1";
            // 
            // テキスト13
            // 
            this.テキスト13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト13.Height = 0.125F;
            this.テキスト13.HyperLink = "";
            this.テキスト13.Left = 1.574803F;
            this.テキスト13.Name = "テキスト13";
            this.テキスト13.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.テキスト13.Tag = "";
            this.テキスト13.Text = "当年度末";
            this.テキスト13.Top = 0F;
            this.テキスト13.Width = 0.6694444F;
            // 
            // テキスト16
            // 
            this.テキスト16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト16.Height = 0.1251968F;
            this.テキスト16.HyperLink = "";
            this.テキスト16.Left = 0F;
            this.テキスト16.Name = "テキスト16";
            this.テキスト16.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.テキスト16.Tag = "";
            this.テキスト16.Text = "";
            this.テキスト16.Top = 0F;
            this.テキスト16.Width = 1.574803F;
            // 
            // テキスト15
            // 
            this.テキスト15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト15.Height = 0.125F;
            this.テキスト15.HyperLink = "";
            this.テキスト15.Left = 2.913386F;
            this.テキスト15.Name = "テキスト15";
            this.テキスト15.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.テキスト15.Tag = "";
            this.テキスト15.Text = "増減";
            this.テキスト15.Top = 0F;
            this.テキスト15.Width = 0.6694444F;
            // 
            // テキスト14
            // 
            this.テキスト14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト14.Height = 0.125F;
            this.テキスト14.HyperLink = "";
            this.テキスト14.Left = 2.244094F;
            this.テキスト14.Name = "テキスト14";
            this.テキスト14.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.テキスト14.Tag = "";
            this.テキスト14.Text = "前年度末";
            this.テキスト14.Top = 0F;
            this.テキスト14.Width = 0.6694444F;
            // 
            // reportFooter1
            // 
            this.reportFooter1.Height = 0F;
            this.reportFooter1.Name = "reportFooter1";
            // 
            // groupHeader1
            // 
            this.groupHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtDaikubunName,
            this.txtDaikubunId,
            this.textBox3,
            this.txtTounenSum,
            this.textBox5});
            this.groupHeader1.DataField = "DaikubunId";
            this.groupHeader1.Height = 0.125F;
            this.groupHeader1.Name = "groupHeader1";
            this.groupHeader1.Format += new System.EventHandler(this.groupHeader1_Format);
            // 
            // txtDaikubunName
            // 
            this.txtDaikubunName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDaikubunName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDaikubunName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDaikubunName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDaikubunName.CanGrow = false;
            this.txtDaikubunName.Height = 0.1251968F;
            this.txtDaikubunName.Left = 0F;
            this.txtDaikubunName.Name = "txtDaikubunName";
            this.txtDaikubunName.OutputFormat = resources.GetString("txtDaikubunName.OutputFormat");
            this.txtDaikubunName.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 6.75pt; font-weight: bold; text-a" +
    "lign: left; ddo-char-set: 128";
            this.txtDaikubunName.Tag = "";
            this.txtDaikubunName.Text = "=\"  \" & [科目]";
            this.txtDaikubunName.Top = 0F;
            this.txtDaikubunName.Width = 1.574803F;
            // 
            // txtDaikubunId
            // 
            this.txtDaikubunId.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDaikubunId.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDaikubunId.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDaikubunId.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDaikubunId.CanGrow = false;
            this.txtDaikubunId.DataField = "DaikubunId";
            this.txtDaikubunId.Height = 0.125F;
            this.txtDaikubunId.Left = 0.78125F;
            this.txtDaikubunId.Name = "txtDaikubunId";
            this.txtDaikubunId.OutputFormat = resources.GetString("txtDaikubunId.OutputFormat");
            this.txtDaikubunId.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: left; ddo-char-set" +
    ": 128";
            this.txtDaikubunId.Tag = "";
            this.txtDaikubunId.Text = "ID";
            this.txtDaikubunId.Top = 0F;
            this.txtDaikubunId.Visible = false;
            this.txtDaikubunId.Width = 0.43125F;
            // 
            // textBox3
            // 
            this.textBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox3.CanGrow = false;
            this.textBox3.DataField = "Sai";
            this.textBox3.Height = 0.125F;
            this.textBox3.Left = 2.913386F;
            this.textBox3.Name = "textBox3";
            this.textBox3.OutputFormat = resources.GetString("textBox3.OutputFormat");
            this.textBox3.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; ddo-char-se" +
    "t: 128";
            this.textBox3.SummaryGroup = "groupHeader1";
            this.textBox3.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal;
            this.textBox3.Tag = "";
            this.textBox3.Text = null;
            this.textBox3.Top = 0F;
            this.textBox3.Width = 0.6694444F;
            // 
            // txtTounenSum
            // 
            this.txtTounenSum.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtTounenSum.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtTounenSum.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtTounenSum.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtTounenSum.CanGrow = false;
            this.txtTounenSum.DataField = "CurrentSumAmount";
            this.txtTounenSum.Height = 0.125F;
            this.txtTounenSum.Left = 1.574803F;
            this.txtTounenSum.Name = "txtTounenSum";
            this.txtTounenSum.OutputFormat = resources.GetString("txtTounenSum.OutputFormat");
            this.txtTounenSum.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; ddo-char-se" +
    "t: 128";
            this.txtTounenSum.SummaryGroup = "groupHeader1";
            this.txtTounenSum.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal;
            this.txtTounenSum.Tag = "";
            this.txtTounenSum.Text = null;
            this.txtTounenSum.Top = 0F;
            this.txtTounenSum.Width = 0.6694444F;
            // 
            // textBox5
            // 
            this.textBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox5.CanGrow = false;
            this.textBox5.DataField = "LastSumAmount";
            this.textBox5.Height = 0.125F;
            this.textBox5.Left = 2.244094F;
            this.textBox5.Name = "textBox5";
            this.textBox5.OutputFormat = resources.GetString("textBox5.OutputFormat");
            this.textBox5.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; ddo-char-se" +
    "t: 128";
            this.textBox5.SummaryGroup = "groupHeader1";
            this.textBox5.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal;
            this.textBox5.Tag = "";
            this.textBox5.Text = null;
            this.textBox5.Top = 0F;
            this.textBox5.Width = 0.6694444F;
            // 
            // groupFooter1
            // 
            this.groupFooter1.Height = 0F;
            this.groupFooter1.Name = "groupFooter1";
            // 
            // BalanceSheetSub2
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 3.582677F;
            this.Sections.Add(this.reportHeader1);
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.groupHeader1);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.groupFooter1);
            this.Sections.Add(this.pageFooter);
            this.Sections.Add(this.reportFooter1);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.txtKamoku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKamokuId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZougen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTounen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZennen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.テキスト13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.テキスト16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.テキスト15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.テキスト14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubunName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubunId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTounenSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.ReportHeader reportHeader1;
        private DataDynamics.ActiveReports.ReportFooter reportFooter1;
        private DataDynamics.ActiveReports.TextBox txtKamoku;
        private DataDynamics.ActiveReports.TextBox txtKamokuId;
        private DataDynamics.ActiveReports.TextBox txtZougen;
        private DataDynamics.ActiveReports.TextBox txtTounen;
        private DataDynamics.ActiveReports.TextBox txtZennen;
        private DataDynamics.ActiveReports.GroupHeader groupHeader1;
        private DataDynamics.ActiveReports.TextBox txtDaikubunName;
        private DataDynamics.ActiveReports.TextBox txtDaikubunId;
        private DataDynamics.ActiveReports.TextBox textBox3;
        private DataDynamics.ActiveReports.TextBox txtTounenSum;
        private DataDynamics.ActiveReports.TextBox textBox5;
        private DataDynamics.ActiveReports.GroupFooter groupFooter1;
        private DataDynamics.ActiveReports.Label テキスト13;
        private DataDynamics.ActiveReports.Label テキスト16;
        private DataDynamics.ActiveReports.Label テキスト15;
        private DataDynamics.ActiveReports.Label テキスト14;
    }
}
