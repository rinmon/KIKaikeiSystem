namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// KanjouKamokuReportChukubunRow の概要の説明です。
    /// </summary>
    partial class KanjouKamokuReportChukubunRow
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(KanjouKamokuReportChukubunRow));
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.txtKamokuCode = new DataDynamics.ActiveReports.TextBox();
            this.txtKamokuName = new DataDynamics.ActiveReports.TextBox();
            this.直線9 = new DataDynamics.ActiveReports.Line();
            ((System.ComponentModel.ISupportInitialize)(this.txtKamokuCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKamokuName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtKamokuCode,
            this.txtKamokuName,
            this.直線9});
            this.detail.Height = 0.3125F;
            this.detail.Name = "detail";
            // 
            // txtKamokuCode
            // 
            this.txtKamokuCode.DataField = "KamokuCode";
            this.txtKamokuCode.Height = 0.1666667F;
            this.txtKamokuCode.Left = 0.03976378F;
            this.txtKamokuCode.Name = "txtKamokuCode";
            this.txtKamokuCode.OutputFormat = resources.GetString("txtKamokuCode.OutputFormat");
            this.txtKamokuCode.Style = "color: Black; font-family: ＭＳ Ｐ明朝; text-align: left; ddo-char-set: 128";
            this.txtKamokuCode.Tag = "";
            this.txtKamokuCode.Text = "科目コード";
            this.txtKamokuCode.Top = 0.09251969F;
            this.txtKamokuCode.Width = 0.5416667F;
            // 
            // txtKamokuName
            // 
            this.txtKamokuName.DataField = "KamokuName";
            this.txtKamokuName.Height = 0.1666667F;
            this.txtKamokuName.Left = 0.6562992F;
            this.txtKamokuName.Name = "txtKamokuName";
            this.txtKamokuName.OutputFormat = resources.GetString("txtKamokuName.OutputFormat");
            this.txtKamokuName.Style = "color: Black; font-family: ＭＳ Ｐ明朝; text-align: left; ddo-char-set: 128";
            this.txtKamokuName.Tag = "";
            this.txtKamokuName.Text = "科目";
            this.txtKamokuName.Top = 0.09251969F;
            this.txtKamokuName.Width = 2.916667F;
            // 
            // 直線9
            // 
            this.直線9.Height = 0F;
            this.直線9.Left = 0.03110236F;
            this.直線9.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.直線9.LineWeight = 2.083333F;
            this.直線9.Name = "直線9";
            this.直線9.Tag = "";
            this.直線9.Top = 0.280315F;
            this.直線9.Width = 3.538976F;
            this.直線9.X1 = 0.03110236F;
            this.直線9.X2 = 3.570079F;
            this.直線9.Y1 = 0.280315F;
            this.直線9.Y2 = 0.280315F;
            // 
            // KanjouKamokuReportChukubunRow
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 3.572966F;
            this.Sections.Add(this.detail);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.txtKamokuCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKamokuName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.TextBox txtKamokuCode;
        private DataDynamics.ActiveReports.TextBox txtKamokuName;
        private DataDynamics.ActiveReports.Line 直線9;
    }
}
