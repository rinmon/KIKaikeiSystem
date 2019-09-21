namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// BalanceSheetSub2Junshisan の概要の説明です。
    /// </summary>
    partial class BalanceSheetSub2Junshisan
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BalanceSheetSub2Junshisan));
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
            this.textBox7 = new DataDynamics.ActiveReports.TextBox();
            this.txtJikiTounen = new DataDynamics.ActiveReports.TextBox();
            this.txtJikiZennen = new DataDynamics.ActiveReports.TextBox();
            this.txtJikiSai = new DataDynamics.ActiveReports.TextBox();
            this.textBox1 = new DataDynamics.ActiveReports.TextBox();
            this.txtToukiTounen = new DataDynamics.ActiveReports.TextBox();
            this.txtToukiZennen = new DataDynamics.ActiveReports.TextBox();
            this.txtToukiSai = new DataDynamics.ActiveReports.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.textBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJikiTounen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJikiZennen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJikiSai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToukiTounen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToukiZennen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToukiSai)).BeginInit();
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
            this.reportFooter1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.textBox7,
            this.txtJikiTounen,
            this.txtJikiZennen,
            this.txtJikiSai,
            this.textBox1,
            this.txtToukiTounen,
            this.txtToukiZennen,
            this.txtToukiSai});
            this.reportFooter1.Height = 0.3472441F;
            this.reportFooter1.Name = "reportFooter1";
            // 
            // textBox7
            // 
            this.textBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox7.CanGrow = false;
            this.textBox7.Height = 0.1736221F;
            this.textBox7.Left = 0F;
            this.textBox7.Name = "textBox7";
            this.textBox7.OutputFormat = resources.GetString("textBox7.OutputFormat");
            this.textBox7.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 6.75pt; font-weight: normal; text" +
    "-align: left; vertical-align: middle; ddo-char-set: 128";
            this.textBox7.Tag = "";
            this.textBox7.Text = "  次期繰越活動増減差額";
            this.textBox7.Top = 0F;
            this.textBox7.Width = 1.574803F;
            // 
            // txtJikiTounen
            // 
            this.txtJikiTounen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJikiTounen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJikiTounen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJikiTounen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJikiTounen.CanGrow = false;
            this.txtJikiTounen.Height = 0.1736221F;
            this.txtJikiTounen.Left = 1.574803F;
            this.txtJikiTounen.Name = "txtJikiTounen";
            this.txtJikiTounen.OutputFormat = resources.GetString("txtJikiTounen.OutputFormat");
            this.txtJikiTounen.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: bottom; ddo-char-set: 128";
            this.txtJikiTounen.Tag = "";
            this.txtJikiTounen.Text = null;
            this.txtJikiTounen.Top = 0F;
            this.txtJikiTounen.Width = 0.6694444F;
            // 
            // txtJikiZennen
            // 
            this.txtJikiZennen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJikiZennen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJikiZennen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJikiZennen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJikiZennen.CanGrow = false;
            this.txtJikiZennen.Height = 0.1736221F;
            this.txtJikiZennen.Left = 2.244094F;
            this.txtJikiZennen.Name = "txtJikiZennen";
            this.txtJikiZennen.OutputFormat = resources.GetString("txtJikiZennen.OutputFormat");
            this.txtJikiZennen.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: bottom; ddo-char-set: 128";
            this.txtJikiZennen.Tag = "";
            this.txtJikiZennen.Text = null;
            this.txtJikiZennen.Top = 0F;
            this.txtJikiZennen.Width = 0.6694444F;
            // 
            // txtJikiSai
            // 
            this.txtJikiSai.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJikiSai.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJikiSai.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJikiSai.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJikiSai.CanGrow = false;
            this.txtJikiSai.Height = 0.1736221F;
            this.txtJikiSai.Left = 2.913386F;
            this.txtJikiSai.Name = "txtJikiSai";
            this.txtJikiSai.OutputFormat = resources.GetString("txtJikiSai.OutputFormat");
            this.txtJikiSai.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: bottom; ddo-char-set: 128";
            this.txtJikiSai.Tag = "";
            this.txtJikiSai.Text = null;
            this.txtJikiSai.Top = 0F;
            this.txtJikiSai.Width = 0.6694444F;
            // 
            // textBox1
            // 
            this.textBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox1.CanGrow = false;
            this.textBox1.Height = 0.1736221F;
            this.textBox1.Left = 0F;
            this.textBox1.Name = "textBox1";
            this.textBox1.OutputFormat = resources.GetString("textBox1.OutputFormat");
            this.textBox1.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 6.75pt; font-weight: normal; text" +
    "-align: left; vertical-align: middle; ddo-char-set: 128";
            this.textBox1.Tag = "";
            this.textBox1.Text = "  うち当期活動増減差額";
            this.textBox1.Top = 0.173622F;
            this.textBox1.Width = 1.574803F;
            // 
            // txtToukiTounen
            // 
            this.txtToukiTounen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtToukiTounen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtToukiTounen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtToukiTounen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtToukiTounen.CanGrow = false;
            this.txtToukiTounen.Height = 0.1736221F;
            this.txtToukiTounen.Left = 1.574803F;
            this.txtToukiTounen.Name = "txtToukiTounen";
            this.txtToukiTounen.OutputFormat = resources.GetString("txtToukiTounen.OutputFormat");
            this.txtToukiTounen.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: bottom; ddo-char-set: 128";
            this.txtToukiTounen.Tag = "";
            this.txtToukiTounen.Text = null;
            this.txtToukiTounen.Top = 0.1736221F;
            this.txtToukiTounen.Width = 0.6694444F;
            // 
            // txtToukiZennen
            // 
            this.txtToukiZennen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtToukiZennen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtToukiZennen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtToukiZennen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtToukiZennen.CanGrow = false;
            this.txtToukiZennen.Height = 0.1736221F;
            this.txtToukiZennen.Left = 2.244094F;
            this.txtToukiZennen.Name = "txtToukiZennen";
            this.txtToukiZennen.OutputFormat = resources.GetString("txtToukiZennen.OutputFormat");
            this.txtToukiZennen.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: bottom; ddo-char-set: 128";
            this.txtToukiZennen.Tag = "";
            this.txtToukiZennen.Text = null;
            this.txtToukiZennen.Top = 0.1736221F;
            this.txtToukiZennen.Width = 0.6694444F;
            // 
            // txtToukiSai
            // 
            this.txtToukiSai.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtToukiSai.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtToukiSai.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtToukiSai.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtToukiSai.CanGrow = false;
            this.txtToukiSai.Height = 0.1736221F;
            this.txtToukiSai.Left = 2.913386F;
            this.txtToukiSai.Name = "txtToukiSai";
            this.txtToukiSai.OutputFormat = resources.GetString("txtToukiSai.OutputFormat");
            this.txtToukiSai.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 7pt; text-align: right; vertical-al" +
    "ign: bottom; ddo-char-set: 128";
            this.txtToukiSai.Tag = "";
            this.txtToukiSai.Text = null;
            this.txtToukiSai.Top = 0.1736221F;
            this.txtToukiSai.Width = 0.6694444F;
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
            // BalanceSheetSub2Junshisan
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 3.58283F;
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
            ((System.ComponentModel.ISupportInitialize)(this.textBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJikiTounen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJikiZennen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJikiSai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToukiTounen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToukiZennen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToukiSai)).EndInit();
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
        private DataDynamics.ActiveReports.Label テキスト13;
        private DataDynamics.ActiveReports.Label テキスト16;
        private DataDynamics.ActiveReports.Label テキスト15;
        private DataDynamics.ActiveReports.Label テキスト14;
        private DataDynamics.ActiveReports.GroupHeader groupHeader1;
        private DataDynamics.ActiveReports.TextBox txtDaikubunName;
        private DataDynamics.ActiveReports.TextBox txtDaikubunId;
        private DataDynamics.ActiveReports.TextBox textBox3;
        private DataDynamics.ActiveReports.TextBox txtTounenSum;
        private DataDynamics.ActiveReports.TextBox textBox5;
        private DataDynamics.ActiveReports.GroupFooter groupFooter1;
        private DataDynamics.ActiveReports.TextBox txtKamoku;
        private DataDynamics.ActiveReports.TextBox txtKamokuId;
        private DataDynamics.ActiveReports.TextBox txtZougen;
        private DataDynamics.ActiveReports.TextBox txtTounen;
        private DataDynamics.ActiveReports.TextBox txtZennen;
        private DataDynamics.ActiveReports.TextBox textBox7;
        private DataDynamics.ActiveReports.TextBox txtJikiTounen;
        private DataDynamics.ActiveReports.TextBox txtJikiZennen;
        private DataDynamics.ActiveReports.TextBox txtJikiSai;
        private DataDynamics.ActiveReports.TextBox textBox1;
        private DataDynamics.ActiveReports.TextBox txtToukiTounen;
        private DataDynamics.ActiveReports.TextBox txtToukiZennen;
        private DataDynamics.ActiveReports.TextBox txtToukiSai;
    }
}
