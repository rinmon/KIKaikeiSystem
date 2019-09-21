namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// KanjjouMototyou の概要の説明です。
    /// </summary>
    partial class KanjouMototyou
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(KanjouMototyou));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.txtKaikeiKubunPageHeader = new DataDynamics.ActiveReports.TextBox();
            this.ラベル59 = new DataDynamics.ActiveReports.Label();
            this.txtHoujinmei = new DataDynamics.ActiveReports.TextBox();
            this.ラベル61 = new DataDynamics.ActiveReports.Label();
            this.txtKamokumei = new DataDynamics.ActiveReports.TextBox();
            this.ラベル44 = new DataDynamics.ActiveReports.Label();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.txtSashihikiSagaku = new DataDynamics.ActiveReports.TextBox();
            this.txtKihyoubi = new DataDynamics.ActiveReports.TextBox();
            this.txtDenpyouBangou = new DataDynamics.ActiveReports.TextBox();
            this.施設名称 = new DataDynamics.ActiveReports.TextBox();
            this.txtKarikataKingaku = new DataDynamics.ActiveReports.TextBox();
            this.txtKashikataKingaku = new DataDynamics.ActiveReports.TextBox();
            this.txtKaikeiKubun = new DataDynamics.ActiveReports.TextBox();
            this.txtComment = new DataDynamics.ActiveReports.Label();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.reportInfoPageCount = new DataDynamics.ActiveReports.ReportInfo();
            this.groupHeaderMonthly = new DataDynamics.ActiveReports.GroupHeader();
            this.txtHeaderKurikoshi = new DataDynamics.ActiveReports.TextBox();
            this.lblHeaderZengetsuKurikoshi = new DataDynamics.ActiveReports.Label();
            this.txtHeaderDate = new DataDynamics.ActiveReports.TextBox();
            this.ラベル差引残高 = new DataDynamics.ActiveReports.Label();
            this.ラベル起票日 = new DataDynamics.ActiveReports.Label();
            this.ラベル借方 = new DataDynamics.ActiveReports.Label();
            this.ラベル明細ID = new DataDynamics.ActiveReports.Label();
            this.ラベル施設名称 = new DataDynamics.ActiveReports.Label();
            this.ラベルコメント = new DataDynamics.ActiveReports.Label();
            this.ラベル相手科目 = new DataDynamics.ActiveReports.Label();
            this.ラベル貸方 = new DataDynamics.ActiveReports.Label();
            this.groupFooterMonthly = new DataDynamics.ActiveReports.GroupFooter();
            this.ボックス76 = new DataDynamics.ActiveReports.Shape();
            this.ラベル72 = new DataDynamics.ActiveReports.Label();
            this.txtFooter = new DataDynamics.ActiveReports.TextBox();
            this.textBox2 = new DataDynamics.ActiveReports.TextBox();
            this.textBox3 = new DataDynamics.ActiveReports.TextBox();
            this.lblFooterDate = new DataDynamics.ActiveReports.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubunPageHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoujinmei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKamokumei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSashihikiSagaku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKihyoubi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenpyouBangou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.施設名称)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKarikataKingaku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKashikataKingaku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfoPageCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeaderKurikoshi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHeaderZengetsuKurikoshi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeaderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル差引残高)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル起票日)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル借方)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル明細ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル施設名称)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベルコメント)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル相手科目)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル貸方)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFooterDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtKaikeiKubunPageHeader,
            this.ラベル59,
            this.txtHoujinmei,
            this.ラベル61,
            this.txtKamokumei,
            this.ラベル44});
            this.pageHeader.Height = 0.7083334F;
            this.pageHeader.Name = "pageHeader";
            // 
            // txtKaikeiKubunPageHeader
            // 
            this.txtKaikeiKubunPageHeader.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubunPageHeader.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubunPageHeader.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubunPageHeader.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubunPageHeader.CanGrow = false;
            this.txtKaikeiKubunPageHeader.Height = 0.1875F;
            this.txtKaikeiKubunPageHeader.Left = 0.7083333F;
            this.txtKaikeiKubunPageHeader.Name = "txtKaikeiKubunPageHeader";
            this.txtKaikeiKubunPageHeader.OutputFormat = resources.GetString("txtKaikeiKubunPageHeader.OutputFormat");
            this.txtKaikeiKubunPageHeader.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; te" +
    "xt-align: left; ddo-char-set: 128";
            this.txtKaikeiKubunPageHeader.Tag = "";
            this.txtKaikeiKubunPageHeader.Text = null;
            this.txtKaikeiKubunPageHeader.Top = 0.1875F;
            this.txtKaikeiKubunPageHeader.Width = 2.639583F;
            // 
            // ラベル59
            // 
            this.ラベル59.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル59.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル59.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル59.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル59.Height = 0.1875F;
            this.ラベル59.HyperLink = "";
            this.ラベル59.Left = 0F;
            this.ラベル59.Name = "ラベル59";
            this.ラベル59.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: left; ddo-char-" +
    "set: 128";
            this.ラベル59.Tag = "";
            this.ラベル59.Text = "法人名";
            this.ラベル59.Top = 0F;
            this.ラベル59.Width = 0.7083333F;
            // 
            // txtHoujinmei
            // 
            this.txtHoujinmei.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHoujinmei.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHoujinmei.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHoujinmei.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtHoujinmei.CanGrow = false;
            this.txtHoujinmei.Height = 0.1875F;
            this.txtHoujinmei.Left = 0.7083333F;
            this.txtHoujinmei.Name = "txtHoujinmei";
            this.txtHoujinmei.OutputFormat = resources.GetString("txtHoujinmei.OutputFormat");
            this.txtHoujinmei.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; te" +
    "xt-align: left; ddo-char-set: 128";
            this.txtHoujinmei.Tag = "";
            this.txtHoujinmei.Text = null;
            this.txtHoujinmei.Top = 0F;
            this.txtHoujinmei.Width = 2.639583F;
            // 
            // ラベル61
            // 
            this.ラベル61.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル61.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル61.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル61.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル61.Height = 0.1875F;
            this.ラベル61.HyperLink = "";
            this.ラベル61.Left = 0F;
            this.ラベル61.Name = "ラベル61";
            this.ラベル61.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: left; ddo-char-" +
    "set: 128";
            this.ラベル61.Tag = "";
            this.ラベル61.Text = "会計区分";
            this.ラベル61.Top = 0.1875F;
            this.ラベル61.Width = 0.7083333F;
            // 
            // txtKamokumei
            // 
            this.txtKamokumei.CanGrow = false;
            this.txtKamokumei.Height = 0.2917323F;
            this.txtKamokumei.Left = 0.9897638F;
            this.txtKamokumei.Name = "txtKamokumei";
            this.txtKamokumei.OutputFormat = resources.GetString("txtKamokumei.OutputFormat");
            this.txtKamokumei.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐゴシック; font-size: 18" +
    "pt; text-align: center; text-decoration: underline; ddo-char-set: 128";
            this.txtKamokumei.Tag = "";
            this.txtKamokumei.Text = "科目名";
            this.txtKamokumei.Top = 0.4062992F;
            this.txtKamokumei.Width = 7.472441F;
            // 
            // ラベル44
            // 
            this.ラベル44.Height = 0.2291667F;
            this.ラベル44.HyperLink = "";
            this.ラベル44.Left = 3.875F;
            this.ラベル44.Name = "ラベル44";
            this.ラベル44.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 14pt; font-weight: bold; text-align:" +
    " left; ddo-char-set: 128";
            this.ラベル44.Tag = "";
            this.ラベル44.Text = "【総勘定元帳】";
            this.ラベル44.Top = 0.01041667F;
            this.ラベル44.Width = 1.520833F;
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtSashihikiSagaku,
            this.txtKihyoubi,
            this.txtDenpyouBangou,
            this.施設名称,
            this.txtKarikataKingaku,
            this.txtKashikataKingaku,
            this.txtKaikeiKubun,
            this.txtComment});
            this.detail.Height = 0.1875F;
            this.detail.Name = "detail";
            this.detail.Format += new System.EventHandler(this.detail_Format);
            // 
            // txtSashihikiSagaku
            // 
            this.txtSashihikiSagaku.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSashihikiSagaku.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSashihikiSagaku.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSashihikiSagaku.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSashihikiSagaku.CanGrow = false;
            this.txtSashihikiSagaku.DataField = "Zandaka";
            this.txtSashihikiSagaku.Height = 0.1875F;
            this.txtSashihikiSagaku.Left = 8.289583F;
            this.txtSashihikiSagaku.Name = "txtSashihikiSagaku";
            this.txtSashihikiSagaku.OutputFormat = resources.GetString("txtSashihikiSagaku.OutputFormat");
            this.txtSashihikiSagaku.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: right; ddo-char" +
    "-set: 128";
            this.txtSashihikiSagaku.Tag = "";
            this.txtSashihikiSagaku.Text = null;
            this.txtSashihikiSagaku.Top = 0F;
            this.txtSashihikiSagaku.Width = 1.058333F;
            // 
            // txtKihyoubi
            // 
            this.txtKihyoubi.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKihyoubi.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKihyoubi.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKihyoubi.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKihyoubi.CanGrow = false;
            this.txtKihyoubi.DataField = "Kihyoubi";
            this.txtKihyoubi.Height = 0.1875F;
            this.txtKihyoubi.Left = 0.7916667F;
            this.txtKihyoubi.Name = "txtKihyoubi";
            this.txtKihyoubi.OutputFormat = resources.GetString("txtKihyoubi.OutputFormat");
            this.txtKihyoubi.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: center; ddo-cha" +
    "r-set: 128";
            this.txtKihyoubi.Tag = "";
            this.txtKihyoubi.Text = null;
            this.txtKihyoubi.Top = 0F;
            this.txtKihyoubi.Width = 0.5874999F;
            // 
            // txtDenpyouBangou
            // 
            this.txtDenpyouBangou.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDenpyouBangou.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDenpyouBangou.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDenpyouBangou.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDenpyouBangou.CanGrow = false;
            this.txtDenpyouBangou.DataField = "DenpyouBangou";
            this.txtDenpyouBangou.Height = 0.1875F;
            this.txtDenpyouBangou.Left = 0F;
            this.txtDenpyouBangou.Name = "txtDenpyouBangou";
            this.txtDenpyouBangou.OutputFormat = resources.GetString("txtDenpyouBangou.OutputFormat");
            this.txtDenpyouBangou.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: left; white-spa" +
    "ce: nowrap; ddo-char-set: 128";
            this.txtDenpyouBangou.Tag = "";
            this.txtDenpyouBangou.Text = null;
            this.txtDenpyouBangou.Top = 0F;
            this.txtDenpyouBangou.Width = 0.7916667F;
            // 
            // 施設名称
            // 
            this.施設名称.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.施設名称.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.施設名称.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.施設名称.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.施設名称.CanGrow = false;
            this.施設名称.DataField = "KaikeiKubunStr";
            this.施設名称.Height = 0.1875F;
            this.施設名称.Left = 1.379134F;
            this.施設名称.Name = "施設名称";
            this.施設名称.OutputFormat = resources.GetString("施設名称.OutputFormat");
            this.施設名称.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: left; white-spa" +
    "ce: nowrap; ddo-char-set: 128";
            this.施設名称.Tag = "";
            this.施設名称.Text = null;
            this.施設名称.Top = 0F;
            this.施設名称.Width = 0.6916667F;
            // 
            // txtKarikataKingaku
            // 
            this.txtKarikataKingaku.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKarikataKingaku.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKarikataKingaku.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKarikataKingaku.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKarikataKingaku.CanGrow = false;
            this.txtKarikataKingaku.DataField = "KarikataKingaku";
            this.txtKarikataKingaku.Height = 0.1875F;
            this.txtKarikataKingaku.Left = 6.50625F;
            this.txtKarikataKingaku.Name = "txtKarikataKingaku";
            this.txtKarikataKingaku.OutputFormat = resources.GetString("txtKarikataKingaku.OutputFormat");
            this.txtKarikataKingaku.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: right; ddo-char" +
    "-set: 128";
            this.txtKarikataKingaku.Tag = "";
            this.txtKarikataKingaku.Text = null;
            this.txtKarikataKingaku.Top = 0F;
            this.txtKarikataKingaku.Width = 0.8916667F;
            // 
            // txtKashikataKingaku
            // 
            this.txtKashikataKingaku.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKashikataKingaku.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKashikataKingaku.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKashikataKingaku.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKashikataKingaku.CanGrow = false;
            this.txtKashikataKingaku.DataField = "KashikataKingaku";
            this.txtKashikataKingaku.Height = 0.1875F;
            this.txtKashikataKingaku.Left = 7.397917F;
            this.txtKashikataKingaku.Name = "txtKashikataKingaku";
            this.txtKashikataKingaku.OutputFormat = resources.GetString("txtKashikataKingaku.OutputFormat");
            this.txtKashikataKingaku.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: right; ddo-char" +
    "-set: 128";
            this.txtKashikataKingaku.Tag = "";
            this.txtKashikataKingaku.Text = null;
            this.txtKashikataKingaku.Top = 0F;
            this.txtKashikataKingaku.Width = 0.8916667F;
            // 
            // txtKaikeiKubun
            // 
            this.txtKaikeiKubun.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun.CanGrow = false;
            this.txtKaikeiKubun.DataField = "AiteKamokuStr";
            this.txtKaikeiKubun.Height = 0.1875F;
            this.txtKaikeiKubun.Left = 2.070833F;
            this.txtKaikeiKubun.Name = "txtKaikeiKubun";
            this.txtKaikeiKubun.OutputFormat = resources.GetString("txtKaikeiKubun.OutputFormat");
            this.txtKaikeiKubun.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: left; ddo-char-" +
    "set: 128";
            this.txtKaikeiKubun.Tag = "";
            this.txtKaikeiKubun.Text = null;
            this.txtKaikeiKubun.Top = 0F;
            this.txtKaikeiKubun.Width = 1.8375F;
            // 
            // txtComment
            // 
            this.txtComment.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtComment.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtComment.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtComment.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtComment.DataField = "Comment";
            this.txtComment.Height = 0.1875F;
            this.txtComment.HyperLink = "";
            this.txtComment.Left = 3.908333F;
            this.txtComment.Name = "txtComment";
            this.txtComment.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: left; ddo-char-" +
    "set: 128";
            this.txtComment.Tag = "";
            this.txtComment.Text = "";
            this.txtComment.Top = 0F;
            this.txtComment.Width = 2.597917F;
            // 
            // pageFooter
            // 
            this.pageFooter.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.reportInfoPageCount});
            this.pageFooter.Height = 0.1665354F;
            this.pageFooter.Name = "pageFooter";
            // 
            // reportInfoPageCount
            // 
            this.reportInfoPageCount.FormatString = "{PageNumber}/{PageCount} ページ";
            this.reportInfoPageCount.Height = 0.1665354F;
            this.reportInfoPageCount.Left = 4.010236F;
            this.reportInfoPageCount.Name = "reportInfoPageCount";
            this.reportInfoPageCount.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 9pt; tex" +
    "t-align: center; ddo-char-set: 128";
            this.reportInfoPageCount.Top = 0F;
            this.reportInfoPageCount.Width = 1.181102F;
            // 
            // groupHeaderMonthly
            // 
            this.groupHeaderMonthly.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtHeaderKurikoshi,
            this.lblHeaderZengetsuKurikoshi,
            this.txtHeaderDate,
            this.ラベル差引残高,
            this.ラベル起票日,
            this.ラベル借方,
            this.ラベル明細ID,
            this.ラベル施設名称,
            this.ラベルコメント,
            this.ラベル相手科目,
            this.ラベル貸方});
            this.groupHeaderMonthly.DataField = "MonthStr";
            this.groupHeaderMonthly.Height = 0.3749344F;
            this.groupHeaderMonthly.Name = "groupHeaderMonthly";
            this.groupHeaderMonthly.Format += new System.EventHandler(this.groupHeaderMonthly_Format);
            // 
            // txtHeaderKurikoshi
            // 
            this.txtHeaderKurikoshi.CanGrow = false;
            this.txtHeaderKurikoshi.DataField = "ZengetsuKurikoshi";
            this.txtHeaderKurikoshi.Height = 0.1562992F;
            this.txtHeaderKurikoshi.Left = 8.289763F;
            this.txtHeaderKurikoshi.Name = "txtHeaderKurikoshi";
            this.txtHeaderKurikoshi.OutputFormat = resources.GetString("txtHeaderKurikoshi.OutputFormat");
            this.txtHeaderKurikoshi.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; text-align: right; " +
    "ddo-char-set: 128";
            this.txtHeaderKurikoshi.Tag = "";
            this.txtHeaderKurikoshi.Text = null;
            this.txtHeaderKurikoshi.Top = 0F;
            this.txtHeaderKurikoshi.Width = 1.058268F;
            // 
            // lblHeaderZengetsuKurikoshi
            // 
            this.lblHeaderZengetsuKurikoshi.Height = 0.15625F;
            this.lblHeaderZengetsuKurikoshi.HyperLink = "";
            this.lblHeaderZengetsuKurikoshi.Left = 7.664567F;
            this.lblHeaderZengetsuKurikoshi.Name = "lblHeaderZengetsuKurikoshi";
            this.lblHeaderZengetsuKurikoshi.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 9pt; text-align: left; ddo-char-s" +
    "et: 128";
            this.lblHeaderZengetsuKurikoshi.Tag = "";
            this.lblHeaderZengetsuKurikoshi.Text = "前月繰越";
            this.lblHeaderZengetsuKurikoshi.Top = 0F;
            this.lblHeaderZengetsuKurikoshi.Width = 0.625F;
            // 
            // txtHeaderDate
            // 
            this.txtHeaderDate.CanGrow = false;
            this.txtHeaderDate.DataField = "MonthStr";
            this.txtHeaderDate.Height = 0.15625F;
            this.txtHeaderDate.Left = 0F;
            this.txtHeaderDate.Name = "txtHeaderDate";
            this.txtHeaderDate.OutputFormat = resources.GetString("txtHeaderDate.OutputFormat");
            this.txtHeaderDate.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 9pt; tex" +
    "t-align: left; ddo-char-set: 128";
            this.txtHeaderDate.Tag = "";
            this.txtHeaderDate.Text = "表示年月";
            this.txtHeaderDate.Top = 0F;
            this.txtHeaderDate.Width = 1.18125F;
            // 
            // ラベル差引残高
            // 
            this.ラベル差引残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル差引残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル差引残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル差引残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル差引残高.Height = 0.1666667F;
            this.ラベル差引残高.HyperLink = "";
            this.ラベル差引残高.Left = 8.289583F;
            this.ラベル差引残高.Name = "ラベル差引残高";
            this.ラベル差引残高.Style = "color: Black; font-family: ＭＳ Ｐゴシック; text-align: center; ddo-char-set: 128";
            this.ラベル差引残高.Tag = "";
            this.ラベル差引残高.Text = "差引金額";
            this.ラベル差引残高.Top = 0.2082677F;
            this.ラベル差引残高.Width = 1.058333F;
            // 
            // ラベル起票日
            // 
            this.ラベル起票日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル起票日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル起票日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル起票日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル起票日.Height = 0.1666667F;
            this.ラベル起票日.HyperLink = "";
            this.ラベル起票日.Left = 0.7916667F;
            this.ラベル起票日.Name = "ラベル起票日";
            this.ラベル起票日.Style = "color: Black; font-family: ＭＳ Ｐゴシック; text-align: center; ddo-char-set: 128";
            this.ラベル起票日.Tag = "";
            this.ラベル起票日.Text = "起票日";
            this.ラベル起票日.Top = 0.2082677F;
            this.ラベル起票日.Width = 0.5874999F;
            // 
            // ラベル借方
            // 
            this.ラベル借方.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル借方.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル借方.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル借方.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル借方.Height = 0.1666667F;
            this.ラベル借方.HyperLink = "";
            this.ラベル借方.Left = 6.50625F;
            this.ラベル借方.Name = "ラベル借方";
            this.ラベル借方.Style = "color: Black; font-family: ＭＳ Ｐゴシック; text-align: center; ddo-char-set: 128";
            this.ラベル借方.Tag = "";
            this.ラベル借方.Text = "借方金額";
            this.ラベル借方.Top = 0.2082677F;
            this.ラベル借方.Width = 0.8916667F;
            // 
            // ラベル明細ID
            // 
            this.ラベル明細ID.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル明細ID.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル明細ID.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル明細ID.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル明細ID.Height = 0.1666667F;
            this.ラベル明細ID.HyperLink = "";
            this.ラベル明細ID.Left = 0F;
            this.ラベル明細ID.Name = "ラベル明細ID";
            this.ラベル明細ID.Style = "color: Black; font-family: ＭＳ Ｐゴシック; text-align: center; ddo-char-set: 128";
            this.ラベル明細ID.Tag = "";
            this.ラベル明細ID.Text = "No";
            this.ラベル明細ID.Top = 0.2082677F;
            this.ラベル明細ID.Width = 0.7916667F;
            // 
            // ラベル施設名称
            // 
            this.ラベル施設名称.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル施設名称.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル施設名称.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル施設名称.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル施設名称.Height = 0.1666667F;
            this.ラベル施設名称.HyperLink = "";
            this.ラベル施設名称.Left = 1.379167F;
            this.ラベル施設名称.Name = "ラベル施設名称";
            this.ラベル施設名称.Style = "color: Black; font-family: ＭＳ Ｐゴシック; text-align: center; ddo-char-set: 128";
            this.ラベル施設名称.Tag = "";
            this.ラベル施設名称.Text = "会計区分";
            this.ラベル施設名称.Top = 0.2082677F;
            this.ラベル施設名称.Width = 0.6916667F;
            // 
            // ラベルコメント
            // 
            this.ラベルコメント.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベルコメント.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベルコメント.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベルコメント.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベルコメント.Height = 0.1666667F;
            this.ラベルコメント.HyperLink = "";
            this.ラベルコメント.Left = 3.908333F;
            this.ラベルコメント.Name = "ラベルコメント";
            this.ラベルコメント.Style = "color: Black; font-family: ＭＳ Ｐゴシック; text-align: center; ddo-char-set: 128";
            this.ラベルコメント.Tag = "";
            this.ラベルコメント.Text = "摘要";
            this.ラベルコメント.Top = 0.2082677F;
            this.ラベルコメント.Width = 2.597917F;
            // 
            // ラベル相手科目
            // 
            this.ラベル相手科目.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル相手科目.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル相手科目.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル相手科目.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル相手科目.Height = 0.1666667F;
            this.ラベル相手科目.HyperLink = "";
            this.ラベル相手科目.Left = 2.070833F;
            this.ラベル相手科目.Name = "ラベル相手科目";
            this.ラベル相手科目.Style = "color: Black; font-family: ＭＳ Ｐゴシック; text-align: center; ddo-char-set: 128";
            this.ラベル相手科目.Tag = "";
            this.ラベル相手科目.Text = "相手科目";
            this.ラベル相手科目.Top = 0.2082677F;
            this.ラベル相手科目.Width = 1.8375F;
            // 
            // ラベル貸方
            // 
            this.ラベル貸方.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル貸方.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル貸方.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル貸方.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル貸方.Height = 0.1666667F;
            this.ラベル貸方.HyperLink = "";
            this.ラベル貸方.Left = 7.397917F;
            this.ラベル貸方.Name = "ラベル貸方";
            this.ラベル貸方.Style = "color: Black; font-family: ＭＳ Ｐゴシック; text-align: center; ddo-char-set: 128";
            this.ラベル貸方.Tag = "";
            this.ラベル貸方.Text = "貸方金額";
            this.ラベル貸方.Top = 0.2082677F;
            this.ラベル貸方.Width = 0.8916667F;
            // 
            // groupFooterMonthly
            // 
            this.groupFooterMonthly.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.ボックス76,
            this.ラベル72,
            this.txtFooter,
            this.textBox2,
            this.textBox3,
            this.lblFooterDate});
            this.groupFooterMonthly.Height = 0.4791667F;
            this.groupFooterMonthly.Name = "groupFooterMonthly";
            this.groupFooterMonthly.NewPage = DataDynamics.ActiveReports.NewPage.After;
            this.groupFooterMonthly.Format += new System.EventHandler(this.groupFooterMonthly_Format);
            // 
            // ボックス76
            // 
            this.ボックス76.Height = 0.2708333F;
            this.ボックス76.Left = 0F;
            this.ボックス76.LineWeight = 0.5F;
            this.ボックス76.Name = "ボックス76";
            this.ボックス76.RoundingRadius = 9.999999F;
            this.ボックス76.Tag = "";
            this.ボックス76.Top = 0F;
            this.ボックス76.Width = 9.347917F;
            // 
            // ラベル72
            // 
            this.ラベル72.Height = 0.1979167F;
            this.ラベル72.HyperLink = "";
            this.ラベル72.Left = 6.039764F;
            this.ラベル72.Name = "ラベル72";
            this.ラベル72.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 12pt; text-align: left; ddo-char-" +
    "set: 128";
            this.ラベル72.Tag = "";
            this.ラベル72.Text = "計";
            this.ラベル72.Top = 0.03070866F;
            this.ラベル72.Width = 0.21875F;
            // 
            // txtFooter
            // 
            this.txtFooter.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtFooter.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtFooter.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtFooter.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtFooter.CanGrow = false;
            this.txtFooter.DataField = "KarikataKingaku";
            this.txtFooter.Height = 0.2708662F;
            this.txtFooter.Left = 6.506299F;
            this.txtFooter.Name = "txtFooter";
            this.txtFooter.OutputFormat = resources.GetString("txtFooter.OutputFormat");
            this.txtFooter.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: right; ddo-char" +
    "-set: 128";
            this.txtFooter.SummaryGroup = "groupHeaderMonthly";
            this.txtFooter.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal;
            this.txtFooter.Tag = "";
            this.txtFooter.Text = null;
            this.txtFooter.Top = 0F;
            this.txtFooter.Width = 0.8916667F;
            // 
            // textBox2
            // 
            this.textBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox2.CanGrow = false;
            this.textBox2.DataField = "KashikataKingaku";
            this.textBox2.Height = 0.2708662F;
            this.textBox2.Left = 7.398032F;
            this.textBox2.Name = "textBox2";
            this.textBox2.OutputFormat = resources.GetString("textBox2.OutputFormat");
            this.textBox2.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: right; ddo-char" +
    "-set: 128";
            this.textBox2.SummaryGroup = "groupHeaderMonthly";
            this.textBox2.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal;
            this.textBox2.Tag = "";
            this.textBox2.Text = null;
            this.textBox2.Top = 0F;
            this.textBox2.Width = 0.8916667F;
            // 
            // textBox3
            // 
            this.textBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox3.CanGrow = false;
            this.textBox3.DataField = "Zandaka";
            this.textBox3.Height = 0.2708662F;
            this.textBox3.Left = 8.289764F;
            this.textBox3.Name = "textBox3";
            this.textBox3.OutputFormat = resources.GetString("textBox3.OutputFormat");
            this.textBox3.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: right; ddo-char" +
    "-set: 128";
            this.textBox3.Tag = "";
            this.textBox3.Text = null;
            this.textBox3.Top = 0F;
            this.textBox3.Width = 1.058333F;
            // 
            // lblFooterDate
            // 
            this.lblFooterDate.DataField = "MonthStr";
            this.lblFooterDate.Height = 0.1979167F;
            this.lblFooterDate.HyperLink = "";
            this.lblFooterDate.Left = 4.886614F;
            this.lblFooterDate.Name = "lblFooterDate";
            this.lblFooterDate.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 12pt; text-align: right; ddo-char" +
    "-set: 128";
            this.lblFooterDate.Tag = "";
            this.lblFooterDate.Text = "計";
            this.lblFooterDate.Top = 0.03070866F;
            this.lblFooterDate.Width = 1.091733F;
            // 
            // KanjouMototyou
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 9.348098F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.groupHeaderMonthly);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.groupFooterMonthly);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubunPageHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoujinmei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKamokumei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSashihikiSagaku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKihyoubi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenpyouBangou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.施設名称)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKarikataKingaku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKashikataKingaku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfoPageCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeaderKurikoshi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHeaderZengetsuKurikoshi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeaderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル差引残高)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル起票日)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル借方)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル明細ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル施設名称)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベルコメント)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル相手科目)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル貸方)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFooterDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.TextBox txtKaikeiKubunPageHeader;
        private DataDynamics.ActiveReports.Label ラベル59;
        private DataDynamics.ActiveReports.Label ラベル61;
        private DataDynamics.ActiveReports.Label ラベル44;
        private DataDynamics.ActiveReports.GroupHeader groupHeaderMonthly;
        private DataDynamics.ActiveReports.GroupFooter groupFooterMonthly;
        private DataDynamics.ActiveReports.TextBox txtHeaderKurikoshi;
        private DataDynamics.ActiveReports.Label lblHeaderZengetsuKurikoshi;
        private DataDynamics.ActiveReports.TextBox txtHeaderDate;
        private DataDynamics.ActiveReports.Label ラベル差引残高;
        private DataDynamics.ActiveReports.Label ラベル起票日;
        private DataDynamics.ActiveReports.Label ラベル借方;
        private DataDynamics.ActiveReports.Label ラベル明細ID;
        private DataDynamics.ActiveReports.Label ラベル施設名称;
        private DataDynamics.ActiveReports.Label ラベルコメント;
        private DataDynamics.ActiveReports.Label ラベル相手科目;
        private DataDynamics.ActiveReports.Label ラベル貸方;
        private DataDynamics.ActiveReports.TextBox txtSashihikiSagaku;
        private DataDynamics.ActiveReports.TextBox txtKihyoubi;
        private DataDynamics.ActiveReports.TextBox txtDenpyouBangou;
        private DataDynamics.ActiveReports.TextBox 施設名称;
        private DataDynamics.ActiveReports.TextBox txtKarikataKingaku;
        private DataDynamics.ActiveReports.TextBox txtKashikataKingaku;
        private DataDynamics.ActiveReports.TextBox txtKaikeiKubun;
        private DataDynamics.ActiveReports.Label txtComment;
        private DataDynamics.ActiveReports.Shape ボックス76;
        private DataDynamics.ActiveReports.Label ラベル72;
        private DataDynamics.ActiveReports.TextBox txtFooter;
        private DataDynamics.ActiveReports.TextBox textBox2;
        private DataDynamics.ActiveReports.TextBox textBox3;
        private DataDynamics.ActiveReports.Label lblFooterDate;
        private DataDynamics.ActiveReports.ReportInfo reportInfoPageCount;
        private DataDynamics.ActiveReports.TextBox txtHoujinmei;
        private DataDynamics.ActiveReports.TextBox txtKamokumei;
    }
}
