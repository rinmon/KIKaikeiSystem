namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// KanjouKamokuReport の概要の説明です。
    /// </summary>
    partial class KanjouKamokuReport
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(KanjouKamokuReport));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.大区分_ラベル = new DataDynamics.ActiveReports.Label();
            this.科目_ラベル = new DataDynamics.ActiveReports.Label();
            this.ラベル4 = new DataDynamics.ActiveReports.Label();
            this.直線7 = new DataDynamics.ActiveReports.Line();
            this.reportInfoPageCount = new DataDynamics.ActiveReports.ReportInfo();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.subReport = new DataDynamics.ActiveReports.SubReport();
            this.txtId = new DataDynamics.ActiveReports.TextBox();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.groupHeader1 = new DataDynamics.ActiveReports.GroupHeader();
            this.txtDaikubun = new DataDynamics.ActiveReports.TextBox();
            this.txtDaikubunCode = new DataDynamics.ActiveReports.TextBox();
            this.groupFooter1 = new DataDynamics.ActiveReports.GroupFooter();
            ((System.ComponentModel.ISupportInitialize)(this.大区分_ラベル)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.科目_ラベル)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfoPageCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubunCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.大区分_ラベル,
            this.科目_ラベル,
            this.ラベル4,
            this.直線7,
            this.reportInfoPageCount});
            this.pageHeader.Height = 0.5937008F;
            this.pageHeader.Name = "pageHeader";
            // 
            // 大区分_ラベル
            // 
            this.大区分_ラベル.Height = 0.1979167F;
            this.大区分_ラベル.HyperLink = "";
            this.大区分_ラベル.Left = 0.04166667F;
            this.大区分_ラベル.Name = "大区分_ラベル";
            this.大区分_ラベル.Style = "color: Navy; font-family: ＭＳ Ｐ明朝; font-size: 12pt; font-weight: bold; text-align:" +
    " left; ddo-char-set: 128";
            this.大区分_ラベル.Tag = "DetachedLabel";
            this.大区分_ラベル.Text = "コード";
            this.大区分_ラベル.Top = 0.375F;
            this.大区分_ラベル.Width = 0.5416667F;
            // 
            // 科目_ラベル
            // 
            this.科目_ラベル.Height = 0.1979167F;
            this.科目_ラベル.HyperLink = "";
            this.科目_ラベル.Left = 0.79375F;
            this.科目_ラベル.Name = "科目_ラベル";
            this.科目_ラベル.Style = "color: Navy; font-family: ＭＳ Ｐ明朝; font-size: 12pt; font-weight: bold; text-align:" +
    " left; ddo-char-set: 128";
            this.科目_ラベル.Tag = "DetachedLabel";
            this.科目_ラベル.Text = "科目";
            this.科目_ラベル.Top = 0.375F;
            this.科目_ラベル.Width = 1.65625F;
            // 
            // ラベル4
            // 
            this.ラベル4.Height = 0.3125F;
            this.ラベル4.HyperLink = "";
            this.ラベル4.Left = 0.04166667F;
            this.ラベル4.Name = "ラベル4";
            this.ラベル4.Style = "background-color: White; color: Navy; font-family: ＭＳ Ｐ明朝; font-size: 20pt; font-" +
    "weight: bold; text-align: left; ddo-char-set: 128";
            this.ラベル4.Tag = "";
            this.ラベル4.Text = "勘定科目一覧";
            this.ラベル4.Top = 0F;
            this.ラベル4.Width = 1.895833F;
            // 
            // 直線7
            // 
            this.直線7.Height = 0F;
            this.直線7.Left = 0.04166667F;
            this.直線7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.直線7.LineWeight = 4.166667F;
            this.直線7.Name = "直線7";
            this.直線7.Tag = "";
            this.直線7.Top = 0.5729167F;
            this.直線7.Width = 3.539583F;
            this.直線7.X1 = 0.04166667F;
            this.直線7.X2 = 3.58125F;
            this.直線7.Y1 = 0.5729167F;
            this.直線7.Y2 = 0.5729167F;
            // 
            // reportInfoPageCount
            // 
            this.reportInfoPageCount.FormatString = "{PageNumber}/{PageCount} ページ";
            this.reportInfoPageCount.Height = 0.1456693F;
            this.reportInfoPageCount.Left = 2.083465F;
            this.reportInfoPageCount.Name = "reportInfoPageCount";
            this.reportInfoPageCount.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 10pt; te" +
    "xt-align: center; ddo-char-set: 1";
            this.reportInfoPageCount.Top = 0.09370079F;
            this.reportInfoPageCount.Width = 1.181102F;
            // 
            // detail
            // 
            this.detail.ColumnCount = 2;
            this.detail.ColumnSpacing = 0.2362205F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.subReport,
            this.txtId});
            this.detail.Height = 0.2291339F;
            this.detail.KeepTogether = true;
            this.detail.Name = "detail";
            this.detail.Format += new System.EventHandler(this.detail_Format);
            // 
            // subReport
            // 
            this.subReport.CloseBorder = false;
            this.subReport.Height = 0.2291339F;
            this.subReport.Left = 3.72529E-09F;
            this.subReport.Name = "subReport";
            this.subReport.Report = null;
            this.subReport.ReportName = "";
            this.subReport.Top = 0F;
            this.subReport.Width = 3.531103F;
            // 
            // txtId
            // 
            this.txtId.DataField = "Index";
            this.txtId.Height = 0.2291339F;
            this.txtId.Left = 0F;
            this.txtId.Name = "txtId";
            this.txtId.Text = "Id";
            this.txtId.Top = 0F;
            this.txtId.Visible = false;
            this.txtId.Width = 1F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // groupHeader1
            // 
            this.groupHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtDaikubun,
            this.txtDaikubunCode});
            this.groupHeader1.DataField = "DaikubunCode";
            this.groupHeader1.Height = 0.3541667F;
            this.groupHeader1.Name = "groupHeader1";
            this.groupHeader1.Format += new System.EventHandler(this.groupHeader1_Format);
            // 
            // txtDaikubun
            // 
            this.txtDaikubun.DataField = "DaikubunName";
            this.txtDaikubun.Height = 0.1875F;
            this.txtDaikubun.Left = 0.6248032F;
            this.txtDaikubun.Name = "txtDaikubun";
            this.txtDaikubun.OutputFormat = resources.GetString("txtDaikubun.OutputFormat");
            this.txtDaikubun.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; font-weight: bold; text-ali" +
    "gn: left; ddo-char-set: 128";
            this.txtDaikubun.Tag = "";
            this.txtDaikubun.Text = "大区分";
            this.txtDaikubun.Top = 0.1236221F;
            this.txtDaikubun.Width = 2.947917F;
            // 
            // txtDaikubunCode
            // 
            this.txtDaikubunCode.CanGrow = false;
            this.txtDaikubunCode.DataField = "DaikubunCode";
            this.txtDaikubunCode.Height = 0.1875F;
            this.txtDaikubunCode.Left = 0.03938651F;
            this.txtDaikubunCode.Name = "txtDaikubunCode";
            this.txtDaikubunCode.OutputFormat = resources.GetString("txtDaikubunCode.OutputFormat");
            this.txtDaikubunCode.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; font-weight: bold; text-ali" +
    "gn: left; ddo-char-set: 128";
            this.txtDaikubunCode.Tag = "";
            this.txtDaikubunCode.Text = "大区分コード";
            this.txtDaikubunCode.Top = 0.1236221F;
            this.txtDaikubunCode.Width = 0.5416667F;
            // 
            // groupFooter1
            // 
            this.groupFooter1.Height = 0F;
            this.groupFooter1.Name = "groupFooter1";
            // 
            // KanjouKamokuReport
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 7.498819F;
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
            ((System.ComponentModel.ISupportInitialize)(this.大区分_ラベル)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.科目_ラベル)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfoPageCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubunCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.GroupHeader groupHeader1;
        private DataDynamics.ActiveReports.GroupFooter groupFooter1;
        private DataDynamics.ActiveReports.TextBox txtDaikubun;
        private DataDynamics.ActiveReports.TextBox txtDaikubunCode;
        private DataDynamics.ActiveReports.Label 大区分_ラベル;
        private DataDynamics.ActiveReports.Label 科目_ラベル;
        private DataDynamics.ActiveReports.Label ラベル4;
        private DataDynamics.ActiveReports.Line 直線7;
        private DataDynamics.ActiveReports.SubReport subReport;
        private DataDynamics.ActiveReports.TextBox txtId;
        private DataDynamics.ActiveReports.ReportInfo reportInfoPageCount;
    }
}
