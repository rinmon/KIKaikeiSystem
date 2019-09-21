namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// BalanceSheetTyuuki5 の概要の説明です。
    /// </summary>
    partial class BalanceSheetTyuuki5
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BalanceSheetTyuuki5));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.txtKamoku = new DataDynamics.ActiveReports.TextBox();
            this.txtKingaku = new DataDynamics.ActiveReports.TextBox();
            this.txtKaikeiKubun = new DataDynamics.ActiveReports.TextBox();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.groupHeader1 = new DataDynamics.ActiveReports.GroupHeader();
            this.txtTanpoKubun = new DataDynamics.ActiveReports.TextBox();
            this.groupFooter1 = new DataDynamics.ActiveReports.GroupFooter();
            ((System.ComponentModel.ISupportInitialize)(this.txtKamoku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKingaku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanpoKubun)).BeginInit();
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
            this.txtKingaku,
            this.txtKaikeiKubun});
            this.detail.Height = 0.1458333F;
            this.detail.Name = "detail";
            // 
            // txtKamoku
            // 
            this.txtKamoku.DataField = "Kamoku";
            this.txtKamoku.Height = 0.1458333F;
            this.txtKamoku.Left = 0.4479166F;
            this.txtKamoku.Name = "txtKamoku";
            this.txtKamoku.OutputFormat = resources.GetString("txtKamoku.OutputFormat");
            this.txtKamoku.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 8pt;" +
    " text-align: left; ddo-char-set: 128";
            this.txtKamoku.Tag = "";
            this.txtKamoku.Text = "科目";
            this.txtKamoku.Top = 0F;
            this.txtKamoku.Width = 3.413889F;
            // 
            // txtKingaku
            // 
            this.txtKingaku.CanGrow = false;
            this.txtKingaku.DataField = "Kingaku";
            this.txtKingaku.Height = 0.1458333F;
            this.txtKingaku.Left = 3.9375F;
            this.txtKingaku.Name = "txtKingaku";
            this.txtKingaku.OutputFormat = resources.GetString("txtKingaku.OutputFormat");
            this.txtKingaku.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 8pt;" +
    " text-align: right; ddo-char-set: 128";
            this.txtKingaku.Tag = "";
            this.txtKingaku.Text = "金額";
            this.txtKingaku.Top = 0F;
            this.txtKingaku.Width = 0.7875F;
            // 
            // txtKaikeiKubun
            // 
            this.txtKaikeiKubun.DataField = "KaikeiKubun";
            this.txtKaikeiKubun.Height = 0.1456693F;
            this.txtKaikeiKubun.Left = 4.84252F;
            this.txtKaikeiKubun.Name = "txtKaikeiKubun";
            this.txtKaikeiKubun.OutputFormat = resources.GetString("txtKaikeiKubun.OutputFormat");
            this.txtKaikeiKubun.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 8pt;" +
    " text-align: left; ddo-char-set: 128";
            this.txtKaikeiKubun.Tag = "";
            this.txtKaikeiKubun.Text = "会計区分";
            this.txtKaikeiKubun.Top = 0F;
            this.txtKaikeiKubun.Width = 1.574803F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // groupHeader1
            // 
            this.groupHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtTanpoKubun});
            this.groupHeader1.DataField = "TanpoKubunId";
            this.groupHeader1.Height = 0.1665354F;
            this.groupHeader1.Name = "groupHeader1";
            // 
            // txtTanpoKubun
            // 
            this.txtTanpoKubun.DataField = "TanpoKubun";
            this.txtTanpoKubun.Height = 0.1665354F;
            this.txtTanpoKubun.Left = 0F;
            this.txtTanpoKubun.Name = "txtTanpoKubun";
            this.txtTanpoKubun.OutputFormat = resources.GetString("txtTanpoKubun.OutputFormat");
            this.txtTanpoKubun.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 8pt;" +
    " text-align: left; ddo-char-set: 128";
            this.txtTanpoKubun.Tag = "";
            this.txtTanpoKubun.Text = "担保区分";
            this.txtTanpoKubun.Top = 0F;
            this.txtTanpoKubun.Width = 3.538976F;
            // 
            // groupFooter1
            // 
            this.groupFooter1.Height = 0F;
            this.groupFooter1.Name = "groupFooter1";
            // 
            // BalanceSheetTyuuki5
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 6.417323F;
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
            ((System.ComponentModel.ISupportInitialize)(this.txtKamoku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKingaku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanpoKubun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.TextBox txtKamoku;
        private DataDynamics.ActiveReports.TextBox txtKingaku;
        private DataDynamics.ActiveReports.GroupHeader groupHeader1;
        private DataDynamics.ActiveReports.TextBox txtTanpoKubun;
        private DataDynamics.ActiveReports.GroupFooter groupFooter1;
        private DataDynamics.ActiveReports.TextBox txtKaikeiKubun;

    }
}
