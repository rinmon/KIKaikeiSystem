namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// BalanceSheetTyuuki4 の概要の説明です。
    /// </summary>
    partial class BalanceSheetTyuuki4
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BalanceSheetTyuuki4));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.txtTorikuzushiNaiyou = new DataDynamics.ActiveReports.TextBox();
            this.txtKaikeiKubun = new DataDynamics.ActiveReports.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtTorikuzushiNaiyou)).BeginInit();
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
            this.txtTorikuzushiNaiyou,
            this.txtKaikeiKubun});
            this.detail.Height = 0.1458333F;
            this.detail.Name = "detail";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // txtTorikuzushiNaiyou
            // 
            this.txtTorikuzushiNaiyou.DataField = "Naiyou";
            this.txtTorikuzushiNaiyou.Height = 0.1458333F;
            this.txtTorikuzushiNaiyou.Left = 0F;
            this.txtTorikuzushiNaiyou.Name = "txtTorikuzushiNaiyou";
            this.txtTorikuzushiNaiyou.OutputFormat = resources.GetString("txtTorikuzushiNaiyou.OutputFormat");
            this.txtTorikuzushiNaiyou.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 8pt;" +
    " text-align: left; ddo-char-set: 128";
            this.txtTorikuzushiNaiyou.Tag = "";
            this.txtTorikuzushiNaiyou.Text = "取崩しの内容";
            this.txtTorikuzushiNaiyou.Top = 0F;
            this.txtTorikuzushiNaiyou.Width = 4.725F;
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
            // BalanceSheetTyuuki4
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 6.417323F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.txtTorikuzushiNaiyou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.TextBox txtTorikuzushiNaiyou;
        private DataDynamics.ActiveReports.TextBox txtKaikeiKubun;
    }
}
