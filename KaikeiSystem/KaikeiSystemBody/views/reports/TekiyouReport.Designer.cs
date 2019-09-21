namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// TekiyouReport の概要の説明です。
    /// </summary>
    partial class TekiyouReport
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TekiyouReport));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.科目_ラベル = new DataDynamics.ActiveReports.Label();
            this.直線7 = new DataDynamics.ActiveReports.Line();
            this.ラベル10 = new DataDynamics.ActiveReports.Label();
            this.摘要 = new DataDynamics.ActiveReports.TextBox();
            this.直線9 = new DataDynamics.ActiveReports.Line();
            this.摘要コード = new DataDynamics.ActiveReports.TextBox();
            this.ラベル4 = new DataDynamics.ActiveReports.Label();
            this.reportInfoPageCount = new DataDynamics.ActiveReports.ReportInfo();
            ((System.ComponentModel.ISupportInitialize)(this.科目_ラベル)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.摘要)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.摘要コード)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfoPageCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.科目_ラベル,
            this.直線7,
            this.ラベル10,
            this.ラベル4,
            this.reportInfoPageCount});
            this.pageHeader.Height = 0.943832F;
            this.pageHeader.Name = "pageHeader";
            // 
            // detail
            // 
            this.detail.ColumnCount = 2;
            this.detail.ColumnSpacing = 0.25F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.摘要,
            this.直線9,
            this.摘要コード});
            this.detail.Height = 0.2456693F;
            this.detail.Name = "detail";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // 科目_ラベル
            // 
            this.科目_ラベル.Height = 0.1979167F;
            this.科目_ラベル.HyperLink = "";
            this.科目_ラベル.Left = 0.6625985F;
            this.科目_ラベル.Name = "科目_ラベル";
            this.科目_ラベル.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 12pt; font-weight: bold; text-align" +
    ": left; ddo-char-set: 128";
            this.科目_ラベル.Tag = "DetachedLabel";
            this.科目_ラベル.Text = "摘要";
            this.科目_ラベル.Top = 0.6948819F;
            this.科目_ラベル.Width = 2.916667F;
            // 
            // 直線7
            // 
            this.直線7.Height = 0F;
            this.直線7.Left = 0.03968174F;
            this.直線7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.直線7.LineWeight = 4.166667F;
            this.直線7.Name = "直線7";
            this.直線7.Tag = "";
            this.直線7.Top = 0.8927985F;
            this.直線7.Width = 3.539583F;
            this.直線7.X1 = 0.03968174F;
            this.直線7.X2 = 3.579265F;
            this.直線7.Y1 = 0.8927985F;
            this.直線7.Y2 = 0.8927985F;
            // 
            // ラベル10
            // 
            this.ラベル10.Height = 0.1979167F;
            this.ラベル10.HyperLink = "";
            this.ラベル10.Left = 0.07857063F;
            this.ラベル10.Name = "ラベル10";
            this.ラベル10.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 12pt; font-weight: bold; text-align" +
    ": left; ddo-char-set: 128";
            this.ラベル10.Tag = "DetachedLabel";
            this.ラベル10.Text = "ID";
            this.ラベル10.Top = 0.6948819F;
            this.ラベル10.Width = 0.5416667F;
            // 
            // 摘要
            // 
            this.摘要.DataField = "Tekiyou";
            this.摘要.Height = 0.1666667F;
            this.摘要.Left = 0.6625001F;
            this.摘要.Name = "摘要";
            this.摘要.OutputFormat = resources.GetString("摘要.OutputFormat");
            this.摘要.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 9pt; text-align: left; ddo-char-s" +
    "et: 128";
            this.摘要.Tag = "";
            this.摘要.Text = "=IIf([摘要コード]=0,\"（フリー）\",[摘要名])";
            this.摘要.Top = 0.03958332F;
            this.摘要.Width = 2.916667F;
            // 
            // 直線9
            // 
            this.直線9.Height = 0F;
            this.直線9.Left = 0.03125F;
            this.直線9.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.直線9.LineWeight = 2.083333F;
            this.直線9.Name = "直線9";
            this.直線9.Tag = "";
            this.直線9.Top = 0.21875F;
            this.直線9.Width = 3.539583F;
            this.直線9.X1 = 0.03125F;
            this.直線9.X2 = 3.570833F;
            this.直線9.Y1 = 0.21875F;
            this.直線9.Y2 = 0.21875F;
            // 
            // 摘要コード
            // 
            this.摘要コード.DataField = "TekiyouCode";
            this.摘要コード.Height = 0.1666667F;
            this.摘要コード.Left = 0.07847222F;
            this.摘要コード.Name = "摘要コード";
            this.摘要コード.OutputFormat = resources.GetString("摘要コード.OutputFormat");
            this.摘要コード.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 9pt; text-align: right; ddo-char-" +
    "set: 128";
            this.摘要コード.Tag = "";
            this.摘要コード.Text = "摘要コード";
            this.摘要コード.Top = 0.03958332F;
            this.摘要コード.Width = 0.5416667F;
            // 
            // ラベル4
            // 
            this.ラベル4.Height = 0.3333333F;
            this.ラベル4.HyperLink = "";
            this.ラベル4.Left = 0.03958333F;
            this.ラベル4.Name = "ラベル4";
            this.ラベル4.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 22pt; font" +
    "-weight: bold; text-align: left; text-decoration: underline; ddo-char-set: 128";
            this.ラベル4.Tag = "";
            this.ラベル4.Text = "摘要一覧";
            this.ラベル4.Top = 0.03958333F;
            this.ラベル4.Width = 2.239583F;
            // 
            // reportInfoPageCount
            // 
            this.reportInfoPageCount.FormatString = "{PageNumber}/{PageCount} ページ";
            this.reportInfoPageCount.Height = 0.1456693F;
            this.reportInfoPageCount.Left = 2.291732F;
            this.reportInfoPageCount.Name = "reportInfoPageCount";
            this.reportInfoPageCount.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 10pt; te" +
    "xt-align: center; ddo-char-set: 1";
            this.reportInfoPageCount.Top = 0.1251969F;
            this.reportInfoPageCount.Width = 1.181102F;
            // 
            // TekiyouReport
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 7.658267F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.科目_ラベル)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.摘要)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.摘要コード)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfoPageCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.Label 科目_ラベル;
        private DataDynamics.ActiveReports.Line 直線7;
        private DataDynamics.ActiveReports.Label ラベル10;
        private DataDynamics.ActiveReports.TextBox 摘要;
        private DataDynamics.ActiveReports.Line 直線9;
        private DataDynamics.ActiveReports.TextBox 摘要コード;
        private DataDynamics.ActiveReports.Label ラベル4;
        private DataDynamics.ActiveReports.ReportInfo reportInfoPageCount;
    }
}
