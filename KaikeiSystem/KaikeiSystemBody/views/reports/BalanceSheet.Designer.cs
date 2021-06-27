namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// BalanceSheet の概要の説明です。
    /// </summary>
    partial class BalanceSheet
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BalanceSheet));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.txtHoujinmei = new DataDynamics.ActiveReports.TextBox();
            this.labelTitle = new DataDynamics.ActiveReports.Label();
            this.ラベル64 = new DataDynamics.ActiveReports.Label();
            this.txtKaikeiKubun = new DataDynamics.ActiveReports.TextBox();
            this.txtDate = new DataDynamics.ActiveReports.TextBox();
            this.ラベル66 = new DataDynamics.ActiveReports.Label();
            this.ラベル19 = new DataDynamics.ActiveReports.Label();
            this.labelYoushiki = new DataDynamics.ActiveReports.Label();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.subBalanceSheet = new DataDynamics.ActiveReports.SubReport();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.ラベル5 = new DataDynamics.ActiveReports.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoujinmei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelYoushiki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtHoujinmei,
            this.labelTitle,
            this.ラベル64,
            this.txtKaikeiKubun,
            this.txtDate,
            this.ラベル66,
            this.ラベル19,
            this.labelYoushiki,
            this.ラベル5});
            this.pageHeader.Height = 0.4582677F;
            this.pageHeader.Name = "pageHeader";
            // 
            // txtHoujinmei
            // 
            this.txtHoujinmei.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHoujinmei.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHoujinmei.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHoujinmei.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHoujinmei.CanGrow = false;
            this.txtHoujinmei.Height = 0.1458333F;
            this.txtHoujinmei.Left = 0.6041667F;
            this.txtHoujinmei.Name = "txtHoujinmei";
            this.txtHoujinmei.OutputFormat = resources.GetString("txtHoujinmei.OutputFormat");
            this.txtHoujinmei.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; tex" +
    "t-align: left; ddo-char-set: 128";
            this.txtHoujinmei.Tag = "";
            this.txtHoujinmei.Text = null;
            this.txtHoujinmei.Top = 0.08333334F;
            this.txtHoujinmei.Width = 2.15F;
            // 
            // labelTitle
            // 
            this.labelTitle.Height = 0.1979167F;
            this.labelTitle.HyperLink = "";
            this.labelTitle.Left = 3.025694F;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 12pt; font-weight: bold; text-align" +
    ": center; ddo-char-set: 128";
            this.labelTitle.Tag = "";
            this.labelTitle.Text = "";
            this.labelTitle.Top = 0F;
            this.labelTitle.Width = 1.583333F;
            // 
            // ラベル64
            // 
            this.ラベル64.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル64.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル64.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル64.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル64.Height = 0.1458333F;
            this.ラベル64.HyperLink = "";
            this.ラベル64.Left = 0F;
            this.ラベル64.Name = "ラベル64";
            this.ラベル64.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; text-align: center; ddo-char" +
    "-set: 128";
            this.ラベル64.Tag = "";
            this.ラベル64.Text = "法人名";
            this.ラベル64.Top = 0.08333334F;
            this.ラベル64.Width = 0.6041667F;
            // 
            // txtKaikeiKubun
            // 
            this.txtKaikeiKubun.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun.CanGrow = false;
            this.txtKaikeiKubun.Height = 0.1458333F;
            this.txtKaikeiKubun.Left = 0.6041667F;
            this.txtKaikeiKubun.Name = "txtKaikeiKubun";
            this.txtKaikeiKubun.OutputFormat = resources.GetString("txtKaikeiKubun.OutputFormat");
            this.txtKaikeiKubun.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; tex" +
    "t-align: left; ddo-char-set: 128";
            this.txtKaikeiKubun.Tag = "";
            this.txtKaikeiKubun.Text = null;
            this.txtKaikeiKubun.Top = 0.2291667F;
            this.txtKaikeiKubun.Width = 2.15F;
            // 
            // txtDate
            // 
            this.txtDate.CanGrow = false;
            this.txtDate.Height = 0.1458333F;
            this.txtDate.Left = 2.96875F;
            this.txtDate.Name = "txtDate";
            this.txtDate.OutputFormat = resources.GetString("txtDate.OutputFormat");
            this.txtDate.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; tex" +
    "t-align: center; ddo-char-set: 128";
            this.txtDate.Tag = "";
            this.txtDate.Text = null;
            this.txtDate.Top = 0.2291667F;
            this.txtDate.Width = 1.347917F;
            // 
            // ラベル66
            // 
            this.ラベル66.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル66.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル66.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル66.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル66.Height = 0.1458333F;
            this.ラベル66.HyperLink = "";
            this.ラベル66.Left = 0F;
            this.ラベル66.Name = "ラベル66";
            this.ラベル66.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; text-align: center; ddo-char" +
    "-set: 128";
            this.ラベル66.Tag = "";
            this.ラベル66.Text = "会計区分";
            this.ラベル66.Top = 0.2291667F;
            this.ラベル66.Width = 0.6041667F;
            // 
            // ラベル19
            // 
            this.ラベル19.Height = 0.1458333F;
            this.ラベル19.HyperLink = "";
            this.ラベル19.Left = 4.34375F;
            this.ラベル19.Name = "ラベル19";
            this.ラベル19.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; text-align: left; ddo-char-s" +
    "et: 128";
            this.ラベル19.Tag = "";
            this.ラベル19.Text = "現在";
            this.ラベル19.Top = 0.2395833F;
            this.ラベル19.Width = 0.2708333F;
            // 
            // labelYoushiki
            // 
            this.labelYoushiki.Height = 0.2F;
            this.labelYoushiki.HyperLink = null;
            this.labelYoushiki.Left = 5.917F;
            this.labelYoushiki.Name = "labelYoushiki";
            this.labelYoushiki.Style = "";
            this.labelYoushiki.Text = "";
            this.labelYoushiki.Top = 0F;
            this.labelYoushiki.Width = 1F;
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.subBalanceSheet});
            this.detail.Height = 6.041732F;
            this.detail.Name = "detail";
            this.detail.Format += new System.EventHandler(this.detail_Format);
            // 
            // subBalanceSheet
            // 
            this.subBalanceSheet.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.subBalanceSheet.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.subBalanceSheet.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.subBalanceSheet.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.subBalanceSheet.CloseBorder = false;
            this.subBalanceSheet.Height = 6.041732F;
            this.subBalanceSheet.Left = 0F;
            this.subBalanceSheet.Name = "subBalanceSheet";
            this.subBalanceSheet.Report = null;
            this.subBalanceSheet.ReportName = "";
            this.subBalanceSheet.Top = 0F;
            this.subBalanceSheet.Width = 7.168898F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // ラベル5
            // 
            this.ラベル5.Height = 0.15625F;
            this.ラベル5.HyperLink = "";
            this.ラベル5.Left = 6.552001F;
            this.ラベル5.Name = "ラベル5";
            this.ラベル5.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8.25pt; text-align: left; ddo-cha" +
    "r-set: 0";
            this.ラベル5.Tag = "";
            this.ラベル5.Text = "（単位：円）";
            this.ラベル5.Top = 0.322F;
            this.ラベル5.Width = 0.6145833F;
            // 
            // BalanceSheet
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 7.18125F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.txtHoujinmei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelYoushiki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.TextBox txtHoujinmei;
        private DataDynamics.ActiveReports.Label labelTitle;
        private DataDynamics.ActiveReports.Label ラベル64;
        private DataDynamics.ActiveReports.TextBox txtKaikeiKubun;
        private DataDynamics.ActiveReports.TextBox txtDate;
        private DataDynamics.ActiveReports.Label ラベル66;
        private DataDynamics.ActiveReports.Label ラベル19;
        private DataDynamics.ActiveReports.SubReport subBalanceSheet;
        private DataDynamics.ActiveReports.Label labelYoushiki;
        private DataDynamics.ActiveReports.Label ラベル5;
    }
}
