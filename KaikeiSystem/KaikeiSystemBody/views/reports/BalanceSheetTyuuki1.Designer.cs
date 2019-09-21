namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// BalanceSheetTyuuki1 の概要の説明です。
    /// </summary>
    partial class BalanceSheetTyuuki1
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BalanceSheetTyuuki1));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.txtKoumokuMei = new DataDynamics.ActiveReports.TextBox();
            this.txtSeiriBangou = new DataDynamics.ActiveReports.TextBox();
            this.貸借番号 = new DataDynamics.ActiveReports.TextBox();
            this.txtNaiyou = new DataDynamics.ActiveReports.TextBox();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            ((System.ComponentModel.ISupportInitialize)(this.txtKoumokuMei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeiriBangou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.貸借番号)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNaiyou)).BeginInit();
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
            this.txtKoumokuMei,
            this.txtSeiriBangou,
            this.貸借番号,
            this.txtNaiyou});
            this.detail.Height = 0.1458333F;
            this.detail.Name = "detail";
            // 
            // txtKoumokuMei
            // 
            this.txtKoumokuMei.DataField = "KoumokuMei";
            this.txtKoumokuMei.Height = 0.1458333F;
            this.txtKoumokuMei.Left = 0.34375F;
            this.txtKoumokuMei.Name = "txtKoumokuMei";
            this.txtKoumokuMei.OutputFormat = resources.GetString("txtKoumokuMei.OutputFormat");
            this.txtKoumokuMei.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 8pt;" +
    " text-align: left; ddo-char-set: 128";
            this.txtKoumokuMei.Tag = "";
            this.txtKoumokuMei.Text = "項目名";
            this.txtKoumokuMei.Top = 0F;
            this.txtKoumokuMei.Width = 1.604167F;
            // 
            // txtSeiriBangou
            // 
            this.txtSeiriBangou.CanGrow = false;
            this.txtSeiriBangou.DataField = "SeiriBangou";
            this.txtSeiriBangou.Height = 0.1458333F;
            this.txtSeiriBangou.Left = 0F;
            this.txtSeiriBangou.Name = "txtSeiriBangou";
            this.txtSeiriBangou.OutputFormat = resources.GetString("txtSeiriBangou.OutputFormat");
            this.txtSeiriBangou.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 8pt;" +
    " text-align: left; ddo-char-set: 128";
            this.txtSeiriBangou.Tag = "";
            this.txtSeiriBangou.Text = "整理番号";
            this.txtSeiriBangou.Top = 0F;
            this.txtSeiriBangou.Width = 0.2729167F;
            // 
            // 貸借番号
            // 
            this.貸借番号.CanGrow = false;
            this.貸借番号.DataField = "貸借番号";
            this.貸借番号.Height = 0.1458333F;
            this.貸借番号.Left = 4.4375F;
            this.貸借番号.Name = "貸借番号";
            this.貸借番号.OutputFormat = resources.GetString("貸借番号.OutputFormat");
            this.貸借番号.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 8pt;" +
    " text-align: left; ddo-char-set: 128";
            this.貸借番号.Tag = "";
            this.貸借番号.Text = "貸借番号";
            this.貸借番号.Top = 0F;
            this.貸借番号.Visible = false;
            this.貸借番号.Width = 0.5541667F;
            // 
            // txtNaiyou
            // 
            this.txtNaiyou.DataField = "Naiyou";
            this.txtNaiyou.Height = 0.1458333F;
            this.txtNaiyou.Left = 1.948032F;
            this.txtNaiyou.Name = "txtNaiyou";
            this.txtNaiyou.OutputFormat = resources.GetString("txtNaiyou.OutputFormat");
            this.txtNaiyou.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 8pt;" +
    " text-align: left; ddo-char-set: 128";
            this.txtNaiyou.Tag = "";
            this.txtNaiyou.Text = "内容";
            this.txtNaiyou.Top = 0F;
            this.txtNaiyou.Width = 3.3875F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // BalanceSheetTyuuki1
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 5.335532F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.txtKoumokuMei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeiriBangou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.貸借番号)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNaiyou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.TextBox txtKoumokuMei;
        private DataDynamics.ActiveReports.TextBox txtSeiriBangou;
        private DataDynamics.ActiveReports.TextBox 貸借番号;
        private DataDynamics.ActiveReports.TextBox txtNaiyou;
    }
}
