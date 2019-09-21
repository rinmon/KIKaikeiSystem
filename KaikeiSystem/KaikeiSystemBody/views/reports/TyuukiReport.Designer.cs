namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// TyuukiReport の概要の説明です。
    /// </summary>
    partial class TyuukiReport
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TyuukiReport));
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.subReport1 = new DataDynamics.ActiveReports.SubReport();
            this.txtRowType = new DataDynamics.ActiveReports.TextBox();
            this.txtRowId = new DataDynamics.ActiveReports.TextBox();
            this.txtContents = new DataDynamics.ActiveReports.TextBox();
            this.txtCaption = new DataDynamics.ActiveReports.TextBox();
            this.reportHeader1 = new DataDynamics.ActiveReports.ReportHeader();
            this.ラベル17 = new DataDynamics.ActiveReports.Label();
            this.reportFooter1 = new DataDynamics.ActiveReports.ReportFooter();
            this.label1 = new DataDynamics.ActiveReports.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtRowType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRowId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.subReport1,
            this.txtRowType,
            this.txtRowId,
            this.txtContents,
            this.txtCaption,
            this.label1});
            this.detail.Height = 0.7084645F;
            this.detail.Name = "detail";
            this.detail.Format += new System.EventHandler(this.detail_Format);
            // 
            // subReport1
            // 
            this.subReport1.CloseBorder = false;
            this.subReport1.Height = 0.2220472F;
            this.subReport1.Left = 0F;
            this.subReport1.Name = "subReport1";
            this.subReport1.Report = null;
            this.subReport1.ReportName = "";
            this.subReport1.Top = 0.2814961F;
            this.subReport1.Width = 6.361024F;
            // 
            // txtRowType
            // 
            this.txtRowType.DataField = "RowType";
            this.txtRowType.Height = 0.125F;
            this.txtRowType.Left = 0.1354331F;
            this.txtRowType.Name = "txtRowType";
            this.txtRowType.Tag = "";
            this.txtRowType.Text = "textBox1";
            this.txtRowType.Top = 0.2814961F;
            this.txtRowType.Visible = false;
            this.txtRowType.Width = 0.3541667F;
            // 
            // txtRowId
            // 
            this.txtRowId.DataField = "RowId";
            this.txtRowId.Height = 0.125F;
            this.txtRowId.Left = 0.6248032F;
            this.txtRowId.Name = "txtRowId";
            this.txtRowId.Tag = "";
            this.txtRowId.Text = "textBox1";
            this.txtRowId.Top = 0.2814961F;
            this.txtRowId.Visible = false;
            this.txtRowId.Width = 0.3541667F;
            // 
            // txtContents
            // 
            this.txtContents.DataField = "Contents";
            this.txtContents.Height = 0.125F;
            this.txtContents.Left = 1.114567F;
            this.txtContents.Name = "txtContents";
            this.txtContents.Tag = "";
            this.txtContents.Text = "textBox1";
            this.txtContents.Top = 0.2814961F;
            this.txtContents.Visible = false;
            this.txtContents.Width = 0.3541667F;
            // 
            // txtCaption
            // 
            this.txtCaption.Height = 0.2082677F;
            this.txtCaption.Left = 0F;
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Style = "font-family: ＭＳ Ｐゴシック; font-size: 11.25pt";
            this.txtCaption.Text = "重要な会計方針";
            this.txtCaption.Top = 0F;
            this.txtCaption.Width = 6.361024F;
            // 
            // reportHeader1
            // 
            this.reportHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.ラベル17});
            this.reportHeader1.Height = 0.5208333F;
            this.reportHeader1.Name = "reportHeader1";
            // 
            // ラベル17
            // 
            this.ラベル17.Height = 0.2397638F;
            this.ラベル17.HyperLink = "";
            this.ラベル17.Left = 0F;
            this.ラベル17.Name = "ラベル17";
            this.ラベル17.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 14.25pt; font-weight: bold; text-" +
    "align: center; ddo-char-set: 128";
            this.ラベル17.Tag = "";
            this.ラベル17.Text = "財務諸表に対する注記";
            this.ラベル17.Top = 0F;
            this.ラベル17.Width = 6.361024F;
            // 
            // reportFooter1
            // 
            this.reportFooter1.Height = 0F;
            this.reportFooter1.Name = "reportFooter1";
            // 
            // label1
            // 
            this.label1.Height = 0.2049212F;
            this.label1.HyperLink = null;
            this.label1.Left = 2.645669F;
            this.label1.Name = "label1";
            this.label1.Style = "";
            this.label1.Text = "";
            this.label1.Top = 0.5035433F;
            this.label1.Width = 0.7708333F;
            // 
            // TyuukiReport
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 6.361024F;
            this.Sections.Add(this.reportHeader1);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.reportFooter1);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.txtRowType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRowId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.SubReport subReport;
        private DataDynamics.ActiveReports.ReportHeader reportHeader1;
        private DataDynamics.ActiveReports.Label ラベル17;
        private DataDynamics.ActiveReports.ReportFooter reportFooter1;
        private DataDynamics.ActiveReports.TextBox txtRowType;
        private DataDynamics.ActiveReports.TextBox txtRowId;
        private DataDynamics.ActiveReports.TextBox txtContents;
        private DataDynamics.ActiveReports.TextBox txtCaption;
        private DataDynamics.ActiveReports.SubReport subReport1;
        private DataDynamics.ActiveReports.Label label1;
    }
}
