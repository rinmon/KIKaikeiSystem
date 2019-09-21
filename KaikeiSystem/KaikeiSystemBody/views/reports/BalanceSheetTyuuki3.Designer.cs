namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// BalanceSheetTyuuki3 の概要の説明です。
    /// </summary>
    partial class BalanceSheetTyuuki3
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BalanceSheetTyuuki3));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.txtKingaku = new DataDynamics.ActiveReports.TextBox();
            this.txtTekiyou = new DataDynamics.ActiveReports.TextBox();
            this.txtKamoku = new DataDynamics.ActiveReports.TextBox();
            this.txtKaikeiKubun = new DataDynamics.ActiveReports.TextBox();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            ((System.ComponentModel.ISupportInitialize)(this.txtKingaku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTekiyou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKamoku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubun)).BeginInit();
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
            this.txtKingaku,
            this.txtTekiyou,
            this.txtKamoku,
            this.txtKaikeiKubun});
            this.detail.Height = 0.1458333F;
            this.detail.Name = "detail";
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
            // txtTekiyou
            // 
            this.txtTekiyou.DataField = "Tekiyou";
            this.txtTekiyou.Height = 0.1458333F;
            this.txtTekiyou.Left = 1.979167F;
            this.txtTekiyou.Name = "txtTekiyou";
            this.txtTekiyou.OutputFormat = resources.GetString("txtTekiyou.OutputFormat");
            this.txtTekiyou.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 8pt;" +
    " text-align: left; ddo-char-set: 128";
            this.txtTekiyou.Tag = "";
            this.txtTekiyou.Text = "摘要";
            this.txtTekiyou.Top = 0F;
            this.txtTekiyou.Width = 1.920833F;
            // 
            // txtKamoku
            // 
            this.txtKamoku.DataField = "Kamoku";
            this.txtKamoku.Height = 0.1458333F;
            this.txtKamoku.Left = 0F;
            this.txtKamoku.Name = "txtKamoku";
            this.txtKamoku.OutputFormat = resources.GetString("txtKamoku.OutputFormat");
            this.txtKamoku.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 8pt;" +
    " text-align: left; ddo-char-set: 128";
            this.txtKamoku.Tag = "";
            this.txtKamoku.Text = "科目";
            this.txtKamoku.Top = 0F;
            this.txtKamoku.Width = 1.924306F;
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
            this.txtKaikeiKubun.Width = 1.968504F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // BalanceSheetTyuuki3
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 7.3125F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.txtKingaku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTekiyou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKamoku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.TextBox txtKingaku;
        private DataDynamics.ActiveReports.TextBox txtTekiyou;
        private DataDynamics.ActiveReports.TextBox txtKamoku;
        private DataDynamics.ActiveReports.TextBox txtKaikeiKubun;

    }
}
