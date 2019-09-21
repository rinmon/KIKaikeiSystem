namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// KessanHoukokusyoHyoushi の概要の説明です。
    /// </summary>
    partial class KessanHoukokusyoHyoushi
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(KessanHoukokusyoHyoushi));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.txtHoujinMei = new DataDynamics.ActiveReports.TextBox();
            this.ラベル11 = new DataDynamics.ActiveReports.Label();
            this.ボックス0 = new DataDynamics.ActiveReports.Shape();
            this.txtKimatsubi = new DataDynamics.ActiveReports.TextBox();
            this.txtKisanbi = new DataDynamics.ActiveReports.TextBox();
            this.ラベル1 = new DataDynamics.ActiveReports.Label();
            this.txtJuusyo = new DataDynamics.ActiveReports.TextBox();
            this.ラベル9 = new DataDynamics.ActiveReports.Label();
            this.txtYuubinBangou = new DataDynamics.ActiveReports.TextBox();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoujinMei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKimatsubi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKisanbi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJuusyo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYuubinBangou)).BeginInit();
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
            this.txtHoujinMei,
            this.ラベル11,
            this.ボックス0,
            this.txtKimatsubi,
            this.txtKisanbi,
            this.ラベル1,
            this.txtJuusyo,
            this.ラベル9,
            this.txtYuubinBangou});
            this.detail.Height = 7.8375F;
            this.detail.Name = "detail";
            // 
            // txtHoujinMei
            // 
            this.txtHoujinMei.CanGrow = false;
            this.txtHoujinMei.Height = 0.2291667F;
            this.txtHoujinMei.Left = 1.479167F;
            this.txtHoujinMei.Name = "txtHoujinMei";
            this.txtHoujinMei.OutputFormat = resources.GetString("txtHoujinMei.OutputFormat");
            this.txtHoujinMei.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 14pt; fo" +
    "nt-weight: bold; text-align: left; ddo-char-set: 128";
            this.txtHoujinMei.Tag = "";
            this.txtHoujinMei.Text = "法人名";
            this.txtHoujinMei.Top = 6.916667F;
            this.txtHoujinMei.Width = 4.525F;
            // 
            // ラベル11
            // 
            this.ラベル11.Height = 0.1979167F;
            this.ラベル11.HyperLink = "";
            this.ラベル11.Left = 2.422917F;
            this.ラベル11.Name = "ラベル11";
            this.ラベル11.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 12pt; text-align: center; ddo-cha" +
    "r-set: 128";
            this.ラベル11.Tag = "";
            this.ラベル11.Text = "至";
            this.ラベル11.Top = 5.333333F;
            this.ラベル11.Width = 0.3333333F;
            // 
            // ボックス0
            // 
            this.ボックス0.BackColor = System.Drawing.Color.White;
            this.ボックス0.Height = 1.21875F;
            this.ボックス0.Left = 1.135417F;
            this.ボックス0.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDotDot;
            this.ボックス0.LineWeight = 10.41667F;
            this.ボックス0.Name = "ボックス0";
            this.ボックス0.RoundingRadius = 9.999999F;
            this.ボックス0.Tag = "";
            this.ボックス0.Top = 2.427083F;
            this.ボックス0.Width = 5.020833F;
            // 
            // txtKimatsubi
            // 
            this.txtKimatsubi.CanGrow = false;
            this.txtKimatsubi.Height = 0.1875F;
            this.txtKimatsubi.Left = 2.885417F;
            this.txtKimatsubi.Name = "txtKimatsubi";
            this.txtKimatsubi.OutputFormat = resources.GetString("txtKimatsubi.OutputFormat");
            this.txtKimatsubi.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; te" +
    "xt-align: left; ddo-char-set: 128";
            this.txtKimatsubi.Tag = "";
            this.txtKimatsubi.Text = "期末日";
            this.txtKimatsubi.Top = 5.333333F;
            this.txtKimatsubi.Width = 1.785417F;
            // 
            // txtKisanbi
            // 
            this.txtKisanbi.CanGrow = false;
            this.txtKisanbi.Height = 0.1875F;
            this.txtKisanbi.Left = 2.885417F;
            this.txtKisanbi.Name = "txtKisanbi";
            this.txtKisanbi.OutputFormat = resources.GetString("txtKisanbi.OutputFormat");
            this.txtKisanbi.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; te" +
    "xt-align: left; ddo-char-set: 128";
            this.txtKisanbi.Tag = "";
            this.txtKisanbi.Text = "起算日";
            this.txtKisanbi.Top = 5.083333F;
            this.txtKisanbi.Width = 1.785417F;
            // 
            // ラベル1
            // 
            this.ラベル1.Height = 0.3125F;
            this.ラベル1.HyperLink = "";
            this.ラベル1.Left = 2.28125F;
            this.ラベル1.Name = "ラベル1";
            this.ラベル1.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 20pt; text-align: center; ddo-cha" +
    "r-set: 128";
            this.ラベル1.Tag = "";
            this.ラベル1.Text = "決　算　報　告　書";
            this.ラベル1.Top = 2.947917F;
            this.ラベル1.Width = 2.729167F;
            // 
            // txtJuusyo
            // 
            this.txtJuusyo.Height = 0.2291667F;
            this.txtJuusyo.Left = 1.479167F;
            this.txtJuusyo.Name = "txtJuusyo";
            this.txtJuusyo.OutputFormat = resources.GetString("txtJuusyo.OutputFormat");
            this.txtJuusyo.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 12pt; te" +
    "xt-align: left; ddo-char-set: 128";
            this.txtJuusyo.Tag = "";
            this.txtJuusyo.Text = "住所";
            this.txtJuusyo.Top = 7.608333F;
            this.txtJuusyo.Width = 4.525F;
            // 
            // ラベル9
            // 
            this.ラベル9.Height = 0.1979167F;
            this.ラベル9.HyperLink = "";
            this.ラベル9.Left = 2.422917F;
            this.ラベル9.Name = "ラベル9";
            this.ラベル9.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 12pt; text-align: center; ddo-cha" +
    "r-set: 128";
            this.ラベル9.Tag = "";
            this.ラベル9.Text = "自";
            this.ラベル9.Top = 5.083333F;
            this.ラベル9.Width = 0.3333333F;
            // 
            // txtYuubinBangou
            // 
            this.txtYuubinBangou.CanGrow = false;
            this.txtYuubinBangou.Height = 0.2291667F;
            this.txtYuubinBangou.Left = 1.479167F;
            this.txtYuubinBangou.Name = "txtYuubinBangou";
            this.txtYuubinBangou.OutputFormat = resources.GetString("txtYuubinBangou.OutputFormat");
            this.txtYuubinBangou.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 12pt; te" +
    "xt-align: left; ddo-char-set: 128";
            this.txtYuubinBangou.Tag = "";
            this.txtYuubinBangou.Text = "郵便番号";
            this.txtYuubinBangou.Top = 7.2625F;
            this.txtYuubinBangou.Width = 4.525F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // KessanHoukokusyoHyoushi
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 6.698032F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.txtHoujinMei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKimatsubi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKisanbi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJuusyo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYuubinBangou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.TextBox txtHoujinMei;
        private DataDynamics.ActiveReports.Label ラベル11;
        private DataDynamics.ActiveReports.Shape ボックス0;
        private DataDynamics.ActiveReports.TextBox txtKimatsubi;
        private DataDynamics.ActiveReports.TextBox txtKisanbi;
        private DataDynamics.ActiveReports.Label ラベル1;
        private DataDynamics.ActiveReports.TextBox txtJuusyo;
        private DataDynamics.ActiveReports.Label ラベル9;
        private DataDynamics.ActiveReports.TextBox txtYuubinBangou;

    }
}
