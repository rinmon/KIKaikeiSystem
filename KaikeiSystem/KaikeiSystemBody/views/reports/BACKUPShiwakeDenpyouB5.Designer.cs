namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// ShiwakeDenpyouB5 の概要の説明です。
    /// </summary>
    partial class BACKUPShiwakeDenpyouB5
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ShiwakeDenpyouB5));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.txtKarikataKamoku = new DataDynamics.ActiveReports.TextBox();
            this.ラベル3 = new DataDynamics.ActiveReports.Label();
            this.ラベル11 = new DataDynamics.ActiveReports.Label();
            this.ラベル0 = new DataDynamics.ActiveReports.Label();
            this.txtTorihikiKubun = new DataDynamics.ActiveReports.TextBox();
            this.ラベル14 = new DataDynamics.ActiveReports.Label();
            this.ラベル13 = new DataDynamics.ActiveReports.Label();
            this.ラベル6 = new DataDynamics.ActiveReports.Label();
            this.ラベル15 = new DataDynamics.ActiveReports.Label();
            this.txtKarikataHojo = new DataDynamics.ActiveReports.TextBox();
            this.txtKingaku = new DataDynamics.ActiveReports.TextBox();
            this.ラベル2 = new DataDynamics.ActiveReports.Label();
            this.txtKashikataHojo = new DataDynamics.ActiveReports.TextBox();
            this.ラベル12 = new DataDynamics.ActiveReports.Label();
            this.txtTekiyou = new DataDynamics.ActiveReports.TextBox();
            this.txtSeiriBangou = new DataDynamics.ActiveReports.TextBox();
            this.txtKihyoubi = new DataDynamics.ActiveReports.TextBox();
            this.txtKaikeiKubun = new DataDynamics.ActiveReports.TextBox();
            this.txtKashikataKamoku = new DataDynamics.ActiveReports.TextBox();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.txtId = new DataDynamics.ActiveReports.TextBox();
            this.txtDenpyouBangou = new DataDynamics.ActiveReports.TextBox();
            this.直線20 = new DataDynamics.ActiveReports.Line();
            this.直線19 = new DataDynamics.ActiveReports.Line();
            this.ボックス16 = new DataDynamics.ActiveReports.Shape();
            this.直線17 = new DataDynamics.ActiveReports.Line();
            this.直線18 = new DataDynamics.ActiveReports.Line();
            ((System.ComponentModel.ISupportInitialize)(this.txtKarikataKamoku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTorihikiKubun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKarikataHojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKingaku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKashikataHojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTekiyou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeiriBangou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKihyoubi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKashikataKamoku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenpyouBangou)).BeginInit();
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
            this.txtKarikataKamoku,
            this.ラベル3,
            this.ラベル11,
            this.ラベル0,
            this.txtTorihikiKubun,
            this.ラベル14,
            this.ラベル13,
            this.ラベル6,
            this.ラベル15,
            this.txtKarikataHojo,
            this.ボックス16,
            this.txtKingaku,
            this.直線19,
            this.ラベル2,
            this.直線20,
            this.txtKashikataHojo,
            this.ラベル12,
            this.txtTekiyou,
            this.txtSeiriBangou,
            this.txtKihyoubi,
            this.txtKaikeiKubun,
            this.txtKashikataKamoku,
            this.txtId,
            this.txtDenpyouBangou,
            this.直線18,
            this.直線17});
            this.detail.Height = 4.263071F;
            this.detail.Name = "detail";
            this.detail.Format += new System.EventHandler(this.detail_Format);
            // 
            // txtKarikataKamoku
            // 
            this.txtKarikataKamoku.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKarikataKamoku.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKarikataKamoku.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKarikataKamoku.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKarikataKamoku.CanGrow = false;
            this.txtKarikataKamoku.DataField = "KarikataKamoku";
            this.txtKarikataKamoku.Height = 0.1875F;
            this.txtKarikataKamoku.Left = 0.06259843F;
            this.txtKarikataKamoku.Name = "txtKarikataKamoku";
            this.txtKarikataKamoku.OutputFormat = resources.GetString("txtKarikataKamoku.OutputFormat");
            this.txtKarikataKamoku.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; te" +
    "xt-align: left; ddo-char-set: 128";
            this.txtKarikataKamoku.Tag = "";
            this.txtKarikataKamoku.Text = "借方科目";
            this.txtKarikataKamoku.Top = 1.632284F;
            this.txtKarikataKamoku.Width = 2.677083F;
            // 
            // ラベル3
            // 
            this.ラベル3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル3.Height = 0.1875F;
            this.ラベル3.HyperLink = "";
            this.ラベル3.Left = 0.06259843F;
            this.ラベル3.Name = "ラベル3";
            this.ラベル3.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: left; ddo-char-" +
    "set: 128";
            this.ラベル3.Tag = "";
            this.ラベル3.Text = "起票日:";
            this.ラベル3.Top = 0.9271654F;
            this.ラベル3.Width = 0.8229167F;
            // 
            // ラベル11
            // 
            this.ラベル11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル11.Height = 0.1875F;
            this.ラベル11.HyperLink = "";
            this.ラベル11.Left = 0.06259843F;
            this.ラベル11.Name = "ラベル11";
            this.ラベル11.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: left; ddo-char-" +
    "set: 128";
            this.ラベル11.Tag = "";
            this.ラベル11.Text = "摘要:";
            this.ラベル11.Top = 2.1427F;
            this.ラベル11.Width = 5.358333F;
            // 
            // ラベル0
            // 
            this.ラベル0.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル0.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル0.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル0.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル0.Height = 0.1875F;
            this.ラベル0.HyperLink = "";
            this.ラベル0.Left = 0.06259843F;
            this.ラベル0.Name = "ラベル0";
            this.ラベル0.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: left; ddo-char-" +
    "set: 128";
            this.ラベル0.Tag = "";
            this.ラベル0.Text = "会計区分:";
            this.ラベル0.Top = 0.5489497F;
            this.ラベル0.Width = 0.8229167F;
            // 
            // txtTorihikiKubun
            // 
            this.txtTorihikiKubun.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtTorihikiKubun.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtTorihikiKubun.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtTorihikiKubun.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtTorihikiKubun.CanGrow = false;
            this.txtTorihikiKubun.DataField = "TorihikiKubun";
            this.txtTorihikiKubun.Height = 0.1875F;
            this.txtTorihikiKubun.Left = 0.8855151F;
            this.txtTorihikiKubun.Name = "txtTorihikiKubun";
            this.txtTorihikiKubun.OutputFormat = resources.GetString("txtTorihikiKubun.OutputFormat");
            this.txtTorihikiKubun.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; te" +
    "xt-align: left; ddo-char-set: 128";
            this.txtTorihikiKubun.Tag = "";
            this.txtTorihikiKubun.Text = "MT取引区分.取引区分";
            this.txtTorihikiKubun.Top = 0.7396649F;
            this.txtTorihikiKubun.Width = 4.535417F;
            // 
            // ラベル14
            // 
            this.ラベル14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル14.Height = 0.1875F;
            this.ラベル14.HyperLink = "";
            this.ラベル14.Left = 2.739682F;
            this.ラベル14.Name = "ラベル14";
            this.ラベル14.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: left; ddo-char-" +
    "set: 128";
            this.ラベル14.Tag = "";
            this.ラベル14.Text = "金額:";
            this.ラベル14.Top = 3.226034F;
            this.ラベル14.Width = 0.6979167F;
            // 
            // ラベル13
            // 
            this.ラベル13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル13.Height = 0.1875F;
            this.ラベル13.HyperLink = "";
            this.ラベル13.Left = 2.739682F;
            this.ラベル13.Name = "ラベル13";
            this.ラベル13.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: center; ddo-cha" +
    "r-set: 128";
            this.ラベル13.Tag = "";
            this.ラベル13.Text = "貸　　　方";
            this.ラベル13.Top = 1.444784F;
            this.ラベル13.Width = 2.677083F;
            // 
            // ラベル6
            // 
            this.ラベル6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル6.Height = 0.1875F;
            this.ラベル6.HyperLink = "";
            this.ラベル6.Left = 0.06259843F;
            this.ラベル6.Name = "ラベル6";
            this.ラベル6.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: center; ddo-cha" +
    "r-set: 128";
            this.ラベル6.Tag = "";
            this.ラベル6.Text = "借　　　方";
            this.ラベル6.Top = 1.444784F;
            this.ラベル6.Width = 2.677083F;
            // 
            // ラベル15
            // 
            this.ラベル15.Height = 0.1979167F;
            this.ラベル15.HyperLink = "";
            this.ラベル15.Left = 9.842962E-05F;
            this.ラベル15.Name = "ラベル15";
            this.ラベル15.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 12pt; font-weight: bold; text-ali" +
    "gn: left; text-decoration: underline; ddo-char-set: 128";
            this.ラベル15.Tag = "";
            this.ラベル15.Text = "仕訳伝票";
            this.ラベル15.Top = 0.1843664F;
            this.ラベル15.Width = 1.03125F;
            // 
            // txtKarikataHojo
            // 
            this.txtKarikataHojo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKarikataHojo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKarikataHojo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKarikataHojo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKarikataHojo.CanGrow = false;
            this.txtKarikataHojo.DataField = "KarikataHojo";
            this.txtKarikataHojo.Height = 0.1875F;
            this.txtKarikataHojo.Left = 0.06259843F;
            this.txtKarikataHojo.Name = "txtKarikataHojo";
            this.txtKarikataHojo.OutputFormat = resources.GetString("txtKarikataHojo.OutputFormat");
            this.txtKarikataHojo.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; te" +
    "xt-align: left; ddo-char-set: 128";
            this.txtKarikataHojo.Tag = "";
            this.txtKarikataHojo.Text = "借方補助科目";
            this.txtKarikataHojo.Top = 1.819784F;
            this.txtKarikataHojo.Width = 2.677083F;
            // 
            // txtKingaku
            // 
            this.txtKingaku.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKingaku.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKingaku.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKingaku.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKingaku.CanGrow = false;
            this.txtKingaku.DataField = "Kingaku";
            this.txtKingaku.Height = 0.1875F;
            this.txtKingaku.Left = 3.437402F;
            this.txtKingaku.Name = "txtKingaku";
            this.txtKingaku.OutputFormat = resources.GetString("txtKingaku.OutputFormat");
            this.txtKingaku.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; te" +
    "xt-align: right; ddo-char-set: 128";
            this.txtKingaku.Tag = "";
            this.txtKingaku.Text = "借方金額";
            this.txtKingaku.Top = 3.225985F;
            this.txtKingaku.Width = 1.983333F;
            // 
            // ラベル2
            // 
            this.ラベル2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル2.Height = 0.1875F;
            this.ラベル2.HyperLink = "";
            this.ラベル2.Left = 0.06259843F;
            this.ラベル2.Name = "ラベル2";
            this.ラベル2.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: left; ddo-char-" +
    "set: 128";
            this.ラベル2.Tag = "";
            this.ラベル2.Text = "取引区分:";
            this.ラベル2.Top = 0.7396649F;
            this.ラベル2.Width = 0.8229167F;
            // 
            // txtKashikataHojo
            // 
            this.txtKashikataHojo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKashikataHojo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKashikataHojo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKashikataHojo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKashikataHojo.CanGrow = false;
            this.txtKashikataHojo.DataField = "KashikataHojo";
            this.txtKashikataHojo.Height = 0.1875F;
            this.txtKashikataHojo.Left = 2.739682F;
            this.txtKashikataHojo.Name = "txtKashikataHojo";
            this.txtKashikataHojo.OutputFormat = resources.GetString("txtKashikataHojo.OutputFormat");
            this.txtKashikataHojo.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; te" +
    "xt-align: left; ddo-char-set: 128";
            this.txtKashikataHojo.Tag = "";
            this.txtKashikataHojo.Text = "貸方補助科目";
            this.txtKashikataHojo.Top = 1.819784F;
            this.txtKashikataHojo.Width = 2.677083F;
            // 
            // ラベル12
            // 
            this.ラベル12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル12.Height = 0.1875F;
            this.ラベル12.HyperLink = "";
            this.ラベル12.Left = 2.891765F;
            this.ラベル12.Name = "ラベル12";
            this.ラベル12.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: left; ddo-char-" +
    "set: 128";
            this.ラベル12.Tag = "";
            this.ラベル12.Text = "伝票整理番号";
            this.ラベル12.Top = 0.1843664F;
            this.ラベル12.Width = 0.9895833F;
            // 
            // txtTekiyou
            // 
            this.txtTekiyou.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtTekiyou.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtTekiyou.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtTekiyou.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtTekiyou.CanGrow = false;
            this.txtTekiyou.DataField = "Tekiyou";
            this.txtTekiyou.Height = 0.7708333F;
            this.txtTekiyou.Left = 0.06259843F;
            this.txtTekiyou.Name = "txtTekiyou";
            this.txtTekiyou.OutputFormat = resources.GetString("txtTekiyou.OutputFormat");
            this.txtTekiyou.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; te" +
    "xt-align: left; ddo-char-set: 128";
            this.txtTekiyou.Tag = "";
            this.txtTekiyou.Text = "コメント";
            this.txtTekiyou.Top = 2.330201F;
            this.txtTekiyou.Width = 5.358333F;
            // 
            // txtSeiriBangou
            // 
            this.txtSeiriBangou.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSeiriBangou.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSeiriBangou.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSeiriBangou.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSeiriBangou.CanGrow = false;
            this.txtSeiriBangou.DataField = "SeiriBangou";
            this.txtSeiriBangou.Height = 0.1875F;
            this.txtSeiriBangou.Left = 3.881348F;
            this.txtSeiriBangou.Name = "txtSeiriBangou";
            this.txtSeiriBangou.OutputFormat = resources.GetString("txtSeiriBangou.OutputFormat");
            this.txtSeiriBangou.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; te" +
    "xt-align: center; ddo-char-set: 128";
            this.txtSeiriBangou.Tag = "";
            this.txtSeiriBangou.Text = "=[伝票番号] & \"-\" & [ID]";
            this.txtSeiriBangou.Top = 0.1843664F;
            this.txtSeiriBangou.Width = 1.535417F;
            // 
            // txtKihyoubi
            // 
            this.txtKihyoubi.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKihyoubi.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKihyoubi.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKihyoubi.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKihyoubi.CanGrow = false;
            this.txtKihyoubi.DataField = "KihyoubiFormat1";
            this.txtKihyoubi.Height = 0.1875F;
            this.txtKihyoubi.Left = 0.8855151F;
            this.txtKihyoubi.Name = "txtKihyoubi";
            this.txtKihyoubi.OutputFormat = resources.GetString("txtKihyoubi.OutputFormat");
            this.txtKihyoubi.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; te" +
    "xt-align: left; ddo-char-set: 128";
            this.txtKihyoubi.Tag = "";
            this.txtKihyoubi.Text = "起票日";
            this.txtKihyoubi.Top = 0.9271654F;
            this.txtKihyoubi.Width = 4.535417F;
            // 
            // txtKaikeiKubun
            // 
            this.txtKaikeiKubun.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun.CanGrow = false;
            this.txtKaikeiKubun.DataField = "KaikeiKubun";
            this.txtKaikeiKubun.Height = 0.1875F;
            this.txtKaikeiKubun.Left = 0.8855151F;
            this.txtKaikeiKubun.Name = "txtKaikeiKubun";
            this.txtKaikeiKubun.OutputFormat = resources.GetString("txtKaikeiKubun.OutputFormat");
            this.txtKaikeiKubun.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; te" +
    "xt-align: left; ddo-char-set: 128";
            this.txtKaikeiKubun.Tag = "";
            this.txtKaikeiKubun.Text = "MT会計単位.会計単位";
            this.txtKaikeiKubun.Top = 0.5489497F;
            this.txtKaikeiKubun.Width = 4.535417F;
            // 
            // txtKashikataKamoku
            // 
            this.txtKashikataKamoku.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKashikataKamoku.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKashikataKamoku.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKashikataKamoku.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKashikataKamoku.CanGrow = false;
            this.txtKashikataKamoku.DataField = "KashikataKamoku";
            this.txtKashikataKamoku.Height = 0.1875F;
            this.txtKashikataKamoku.Left = 2.739682F;
            this.txtKashikataKamoku.Name = "txtKashikataKamoku";
            this.txtKashikataKamoku.OutputFormat = resources.GetString("txtKashikataKamoku.OutputFormat");
            this.txtKashikataKamoku.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; te" +
    "xt-align: left; ddo-char-set: 128";
            this.txtKashikataKamoku.Tag = "";
            this.txtKashikataKamoku.Text = "貸方科目";
            this.txtKashikataKamoku.Top = 1.632284F;
            this.txtKashikataKamoku.Width = 2.677083F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // txtId
            // 
            this.txtId.CanGrow = false;
            this.txtId.DataField = "Id";
            this.txtId.Height = 0.1145833F;
            this.txtId.Left = 3.881496F;
            this.txtId.Name = "txtId";
            this.txtId.OutputFormat = resources.GetString("txtId.OutputFormat");
            this.txtId.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 6pt; text-" +
    "align: left; ddo-char-set: 128";
            this.txtId.Tag = "";
            this.txtId.Text = "科目ID";
            this.txtId.Top = 0.4129921F;
            this.txtId.Visible = false;
            this.txtId.Width = 0.4375F;
            // 
            // txtDenpyouBangou
            // 
            this.txtDenpyouBangou.CanGrow = false;
            this.txtDenpyouBangou.DataField = "DenpyouBangou";
            this.txtDenpyouBangou.Height = 0.1145833F;
            this.txtDenpyouBangou.Left = 4.322835F;
            this.txtDenpyouBangou.Name = "txtDenpyouBangou";
            this.txtDenpyouBangou.OutputFormat = resources.GetString("txtDenpyouBangou.OutputFormat");
            this.txtDenpyouBangou.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 6pt; text-" +
    "align: left; ddo-char-set: 128";
            this.txtDenpyouBangou.Tag = "";
            this.txtDenpyouBangou.Text = "科目ID";
            this.txtDenpyouBangou.Top = 0.4129921F;
            this.txtDenpyouBangou.Visible = false;
            this.txtDenpyouBangou.Width = 0.4375F;
            // 
            // 直線20
            // 
            this.直線20.Height = 0.5208333F;
            this.直線20.Left = 3.437598F;
            this.直線20.LineWeight = 0.8333334F;
            this.直線20.Name = "直線20";
            this.直線20.Tag = "";
            this.直線20.Top = 3.528117F;
            this.直線20.Width = 0F;
            this.直線20.X1 = 3.437598F;
            this.直線20.X2 = 3.437598F;
            this.直線20.Y1 = 3.528117F;
            this.直線20.Y2 = 4.04895F;
            // 
            // 直線19
            // 
            this.直線19.Height = 0.5208333F;
            this.直線19.Left = 2.760515F;
            this.直線19.LineWeight = 0.8333334F;
            this.直線19.Name = "直線19";
            this.直線19.Tag = "";
            this.直線19.Top = 3.528117F;
            this.直線19.Width = 0F;
            this.直線19.X1 = 2.760515F;
            this.直線19.X2 = 2.760515F;
            this.直線19.Y1 = 3.528117F;
            this.直線19.Y2 = 4.04895F;
            // 
            // ボックス16
            // 
            this.ボックス16.BackColor = System.Drawing.Color.White;
            this.ボックス16.Height = 0.5208333F;
            this.ボックス16.Left = 0.06259843F;
            this.ボックス16.LineWeight = 0.5F;
            this.ボックス16.Name = "ボックス16";
            this.ボックス16.RoundingRadius = 9.999999F;
            this.ボックス16.Tag = "";
            this.ボックス16.Top = 3.528117F;
            this.ボックス16.Width = 5.358333F;
            // 
            // 直線17
            // 
            this.直線17.Height = 0.5208333F;
            this.直線17.Left = 4.104265F;
            this.直線17.LineWeight = 0.8333334F;
            this.直線17.Name = "直線17";
            this.直線17.Tag = "";
            this.直線17.Top = 3.528117F;
            this.直線17.Width = 0F;
            this.直線17.X1 = 4.104265F;
            this.直線17.X2 = 4.104265F;
            this.直線17.Y1 = 3.528117F;
            this.直線17.Y2 = 4.04895F;
            // 
            // 直線18
            // 
            this.直線18.Height = 0.5208333F;
            this.直線18.Left = 4.760515F;
            this.直線18.LineWeight = 0.8333334F;
            this.直線18.Name = "直線18";
            this.直線18.Tag = "";
            this.直線18.Top = 3.528117F;
            this.直線18.Width = 0F;
            this.直線18.X1 = 4.760515F;
            this.直線18.X2 = 4.760515F;
            this.直線18.Y1 = 3.528117F;
            this.直線18.Y2 = 4.04895F;
            // 
            // ShiwakeDenpyouB5
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 5.420932F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.txtKarikataKamoku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTorihikiKubun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKarikataHojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKingaku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKashikataHojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTekiyou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeiriBangou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKihyoubi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKashikataKamoku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenpyouBangou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.TextBox txtKarikataKamoku;
        private DataDynamics.ActiveReports.Label ラベル3;
        private DataDynamics.ActiveReports.Label ラベル11;
        private DataDynamics.ActiveReports.Label ラベル0;
        private DataDynamics.ActiveReports.TextBox txtTorihikiKubun;
        private DataDynamics.ActiveReports.Label ラベル14;
        private DataDynamics.ActiveReports.Label ラベル13;
        private DataDynamics.ActiveReports.Label ラベル6;
        private DataDynamics.ActiveReports.Label ラベル15;
        private DataDynamics.ActiveReports.TextBox txtKarikataHojo;
        private DataDynamics.ActiveReports.TextBox txtKingaku;
        private DataDynamics.ActiveReports.Label ラベル2;
        private DataDynamics.ActiveReports.TextBox txtKashikataHojo;
        private DataDynamics.ActiveReports.Label ラベル12;
        private DataDynamics.ActiveReports.TextBox txtTekiyou;
        private DataDynamics.ActiveReports.TextBox txtSeiriBangou;
        private DataDynamics.ActiveReports.TextBox txtKihyoubi;
        private DataDynamics.ActiveReports.TextBox txtKaikeiKubun;
        private DataDynamics.ActiveReports.TextBox txtKashikataKamoku;
        private DataDynamics.ActiveReports.TextBox txtId;
        private DataDynamics.ActiveReports.TextBox txtDenpyouBangou;
        private DataDynamics.ActiveReports.Line 直線17;
        private DataDynamics.ActiveReports.Shape ボックス16;
        private DataDynamics.ActiveReports.Line 直線19;
        private DataDynamics.ActiveReports.Line 直線20;
        private DataDynamics.ActiveReports.Line 直線18;
    }
}
