namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// TyuukiSubReportTanpoSub の概要の説明です。
    /// </summary>
    partial class TyuukiSubReportTanpo
    {
        private DataDynamics.ActiveReports.Detail detail;

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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TyuukiSubReportTanpo));
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.textBox1 = new DataDynamics.ActiveReports.TextBox();
            this.textBox2 = new DataDynamics.ActiveReports.TextBox();
            this.label1 = new DataDynamics.ActiveReports.Label();
            this.groupHeader1 = new DataDynamics.ActiveReports.GroupHeader();
            this.txtHeader = new DataDynamics.ActiveReports.TextBox();
            this.txtTanpoKubun = new DataDynamics.ActiveReports.TextBox();
            this.groupFooter1 = new DataDynamics.ActiveReports.GroupFooter();
            this.textBox3 = new DataDynamics.ActiveReports.TextBox();
            this.textBox4 = new DataDynamics.ActiveReports.TextBox();
            this.label2 = new DataDynamics.ActiveReports.Label();
            this.line1 = new DataDynamics.ActiveReports.Line();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanpoKubun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.textBox1,
            this.textBox2,
            this.label1});
            this.detail.Height = 0.1874016F;
            this.detail.Name = "detail";
            // 
            // textBox1
            // 
            this.textBox1.DataField = "Name";
            this.textBox1.Height = 0.1874016F;
            this.textBox1.Left = 0.614567F;
            this.textBox1.Name = "textBox1";
            this.textBox1.Style = "font-family: ＭＳ 明朝; font-size: 9.75pt; vertical-align: middle";
            this.textBox1.Text = "textBox1";
            this.textBox1.Top = 0F;
            this.textBox1.Width = 2.853544F;
            // 
            // textBox2
            // 
            this.textBox2.DataField = "Amount";
            this.textBox2.Height = 0.1874016F;
            this.textBox2.Left = 3.468111F;
            this.textBox2.Name = "textBox2";
            this.textBox2.OutputFormat = resources.GetString("textBox2.OutputFormat");
            this.textBox2.Style = "font-family: ＭＳ 明朝; font-size: 9.75pt; text-align: right; vertical-align: middle";
            this.textBox2.Text = "textBox1";
            this.textBox2.Top = 0F;
            this.textBox2.Width = 1.770079F;
            // 
            // label1
            // 
            this.label1.Height = 0.1770833F;
            this.label1.HyperLink = null;
            this.label1.Left = 5.238189F;
            this.label1.Name = "label1";
            this.label1.Style = "font-family: ＭＳ Ｐ明朝; font-size: 9.75pt; vertical-align: middle";
            this.label1.Text = "円";
            this.label1.Top = 0.01023623F;
            this.label1.Width = 0.59375F;
            // 
            // groupHeader1
            // 
            this.groupHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtHeader,
            this.txtTanpoKubun});
            this.groupHeader1.DataField = "TanpoKubun";
            this.groupHeader1.Height = 0.1875656F;
            this.groupHeader1.Name = "groupHeader1";
            this.groupHeader1.Format += new System.EventHandler(this.groupHeader1_Format);
            // 
            // txtHeader
            // 
            this.txtHeader.DataField = "Header";
            this.txtHeader.Height = 0.1874016F;
            this.txtHeader.Left = 0.4673229F;
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Style = "font-family: ＭＳ 明朝; font-size: 9.75pt; vertical-align: middle";
            this.txtHeader.Text = "textBox1";
            this.txtHeader.Top = 0F;
            this.txtHeader.Width = 4.437008F;
            // 
            // txtTanpoKubun
            // 
            this.txtTanpoKubun.DataField = "TanpoKubun";
            this.txtTanpoKubun.Height = 0.1458333F;
            this.txtTanpoKubun.Left = 4.822835F;
            this.txtTanpoKubun.Name = "txtTanpoKubun";
            this.txtTanpoKubun.Text = "textBox6";
            this.txtTanpoKubun.Top = 0.04173229F;
            this.txtTanpoKubun.Visible = false;
            this.txtTanpoKubun.Width = 0.1979167F;
            // 
            // groupFooter1
            // 
            this.groupFooter1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.textBox3,
            this.textBox4,
            this.label2,
            this.line1});
            this.groupFooter1.Height = 0.3540683F;
            this.groupFooter1.Name = "groupFooter1";
            // 
            // textBox3
            // 
            this.textBox3.Height = 0.1874016F;
            this.textBox3.Left = 0.614567F;
            this.textBox3.Name = "textBox3";
            this.textBox3.Style = "font-family: ＭＳ 明朝; font-size: 9.75pt; text-align: center; vertical-align: middle" +
    "";
            this.textBox3.Text = "計";
            this.textBox3.Top = 0F;
            this.textBox3.Width = 2.853544F;
            // 
            // textBox4
            // 
            this.textBox4.DataField = "Amount";
            this.textBox4.Height = 0.1874016F;
            this.textBox4.Left = 3.468111F;
            this.textBox4.Name = "textBox4";
            this.textBox4.OutputFormat = resources.GetString("textBox4.OutputFormat");
            this.textBox4.Style = "font-family: ＭＳ 明朝; font-size: 9.75pt; text-align: right; vertical-align: middle";
            this.textBox4.SummaryGroup = "groupHeader1";
            this.textBox4.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal;
            this.textBox4.Text = "textBox1";
            this.textBox4.Top = 0F;
            this.textBox4.Width = 1.770079F;
            // 
            // label2
            // 
            this.label2.Height = 0.1770833F;
            this.label2.HyperLink = null;
            this.label2.Left = 5.23819F;
            this.label2.Name = "label2";
            this.label2.Style = "font-family: ＭＳ Ｐ明朝; font-size: 9.75pt; vertical-align: middle";
            this.label2.Text = "円";
            this.label2.Top = 0.01023624F;
            this.label2.Width = 0.59375F;
            // 
            // line1
            // 
            this.line1.Height = 0F;
            this.line1.Left = 0.6145678F;
            this.line1.LineWeight = 5F;
            this.line1.Name = "line1";
            this.line1.Top = 0F;
            this.line1.Width = 5.217322F;
            this.line1.X1 = 5.83189F;
            this.line1.X2 = 0.6145678F;
            this.line1.Y1 = 0F;
            this.line1.Y2 = 0F;
            // 
            // TyuukiSubReportTanpo
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 5.831956F;
            this.Sections.Add(this.groupHeader1);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.groupFooter1);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanpoKubun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.TextBox textBox1;
        private DataDynamics.ActiveReports.TextBox textBox2;
        private DataDynamics.ActiveReports.Label label1;
        private DataDynamics.ActiveReports.GroupHeader groupHeader1;
        private DataDynamics.ActiveReports.TextBox txtHeader;
        private DataDynamics.ActiveReports.TextBox txtTanpoKubun;
        private DataDynamics.ActiveReports.GroupFooter groupFooter1;
        private DataDynamics.ActiveReports.TextBox textBox3;
        private DataDynamics.ActiveReports.TextBox textBox4;
        private DataDynamics.ActiveReports.Label label2;
        private DataDynamics.ActiveReports.Line line1;


    }
}
