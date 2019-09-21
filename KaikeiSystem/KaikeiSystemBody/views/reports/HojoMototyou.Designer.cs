namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// HojoMototyou の概要の説明です。
    /// </summary>
    partial class HojoMototyou
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(HojoMototyou));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.ラベル施設名称 = new DataDynamics.ActiveReports.Label();
            this.ラベル明細番号 = new DataDynamics.ActiveReports.Label();
            this.補助科目名 = new DataDynamics.ActiveReports.TextBox();
            this.科目ID = new DataDynamics.ActiveReports.TextBox();
            this.ラベルコメント = new DataDynamics.ActiveReports.Label();
            this.対象科目 = new DataDynamics.ActiveReports.TextBox();
            this.ラベル相手科目 = new DataDynamics.ActiveReports.Label();
            this.ラベル34 = new DataDynamics.ActiveReports.Label();
            this.ラベル起票日 = new DataDynamics.ActiveReports.Label();
            this.ラベル貸方 = new DataDynamics.ActiveReports.Label();
            this.ラベル借方 = new DataDynamics.ActiveReports.Label();
            this.前月繰越 = new DataDynamics.ActiveReports.TextBox();
            this.ラベル32 = new DataDynamics.ActiveReports.Label();
            this.補助科目ID = new DataDynamics.ActiveReports.TextBox();
            this.経理区分 = new DataDynamics.ActiveReports.TextBox();
            this.科目名 = new DataDynamics.ActiveReports.TextBox();
            this.ラベル33 = new DataDynamics.ActiveReports.Label();
            this.ラベル差引残高 = new DataDynamics.ActiveReports.Label();
            this.貸借区分 = new DataDynamics.ActiveReports.TextBox();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.借方 = new DataDynamics.ActiveReports.TextBox();
            this.貸方 = new DataDynamics.ActiveReports.TextBox();
            this.借方集計 = new DataDynamics.ActiveReports.TextBox();
            this.相手科目 = new DataDynamics.ActiveReports.TextBox();
            this.貸方科目ID = new DataDynamics.ActiveReports.TextBox();
            this.コメント = new DataDynamics.ActiveReports.TextBox();
            this.借方科目ID = new DataDynamics.ActiveReports.TextBox();
            this.伝票番号 = new DataDynamics.ActiveReports.TextBox();
            this.ID = new DataDynamics.ActiveReports.TextBox();
            this.差引残高 = new DataDynamics.ActiveReports.TextBox();
            this.明細ID = new DataDynamics.ActiveReports.TextBox();
            this.施設名 = new DataDynamics.ActiveReports.TextBox();
            this.起票日 = new DataDynamics.ActiveReports.TextBox();
            this.貸方集計 = new DataDynamics.ActiveReports.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル施設名称)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル明細番号)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.補助科目名)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.科目ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベルコメント)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.対象科目)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル相手科目)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル起票日)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル貸方)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル借方)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.前月繰越)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.補助科目ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.経理区分)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.科目名)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル差引残高)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.貸借区分)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.借方)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.貸方)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.借方集計)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.相手科目)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.貸方科目ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.コメント)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.借方科目ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.伝票番号)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.差引残高)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.明細ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.施設名)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.起票日)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.貸方集計)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.ラベル施設名称,
            this.ラベル明細番号,
            this.補助科目名,
            this.科目ID,
            this.ラベルコメント,
            this.対象科目,
            this.ラベル相手科目,
            this.ラベル34,
            this.ラベル起票日,
            this.ラベル貸方,
            this.ラベル借方,
            this.前月繰越,
            this.ラベル32,
            this.補助科目ID,
            this.経理区分,
            this.科目名,
            this.ラベル33,
            this.ラベル差引残高,
            this.貸借区分});
            this.pageHeader.Height = 1.270833F;
            this.pageHeader.Name = "pageHeader";
            // 
            // ラベル施設名称
            // 
            this.ラベル施設名称.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル施設名称.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル施設名称.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル施設名称.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル施設名称.Height = 0.1666667F;
            this.ラベル施設名称.HyperLink = "";
            this.ラベル施設名称.Left = 1.285417F;
            this.ラベル施設名称.Name = "ラベル施設名称";
            this.ラベル施設名称.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; text-align: center;" +
    " ddo-char-set: 128";
            this.ラベル施設名称.Tag = "";
            this.ラベル施設名称.Text = "経理区分";
            this.ラベル施設名称.Top = 1.104167F;
            this.ラベル施設名称.Width = 0.7395833F;
            // 
            // ラベル明細番号
            // 
            this.ラベル明細番号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル明細番号.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル明細番号.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル明細番号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル明細番号.Height = 0.1666667F;
            this.ラベル明細番号.HyperLink = "";
            this.ラベル明細番号.Left = 0F;
            this.ラベル明細番号.Name = "ラベル明細番号";
            this.ラベル明細番号.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; text-align: center;" +
    " ddo-char-set: 128";
            this.ラベル明細番号.Tag = "";
            this.ラベル明細番号.Text = "No";
            this.ラベル明細番号.Top = 1.104167F;
            this.ラベル明細番号.Width = 0.7604167F;
            // 
            // 補助科目名
            // 
            this.補助科目名.CanGrow = false;
            this.補助科目名.Height = 0.1875F;
            this.補助科目名.Left = 0.7083333F;
            this.補助科目名.Name = "補助科目名";
            this.補助科目名.OutputFormat = resources.GetString("補助科目名.OutputFormat");
            this.補助科目名.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; te" +
    "xt-align: left; ddo-char-set: 128";
            this.補助科目名.Tag = "";
            this.補助科目名.Text = "=DLookUp(\"補助科目\",\"MT補助科目\",\"[補助科目ID]=[Forms]![勘定元帳印刷]![コンボ補助科目]\")";
            this.補助科目名.Top = 0.7395833F;
            this.補助科目名.Width = 2.983333F;
            // 
            // 科目ID
            // 
            this.科目ID.CanGrow = false;
            this.科目ID.Height = 0.1666667F;
            this.科目ID.Left = 3.927083F;
            this.科目ID.Name = "科目ID";
            this.科目ID.OutputFormat = resources.GetString("科目ID.OutputFormat");
            this.科目ID.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; text-align: left; d" +
    "do-char-set: 128";
            this.科目ID.Tag = "";
            this.科目ID.Text = "=[Forms]![勘定元帳印刷]![コンボ対象科目]";
            this.科目ID.Top = 0.75F;
            this.科目ID.Visible = false;
            this.科目ID.Width = 0.8895833F;
            // 
            // ラベルコメント
            // 
            this.ラベルコメント.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベルコメント.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベルコメント.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベルコメント.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベルコメント.Height = 0.1666667F;
            this.ラベルコメント.HyperLink = "";
            this.ラベルコメント.Left = 3.1375F;
            this.ラベルコメント.Name = "ラベルコメント";
            this.ラベルコメント.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; text-align: center;" +
    " ddo-char-set: 128";
            this.ラベルコメント.Tag = "";
            this.ラベルコメント.Text = "摘要";
            this.ラベルコメント.Top = 1.104167F;
            this.ラベルコメント.Width = 1.514583F;
            // 
            // 対象科目
            // 
            this.対象科目.CanGrow = false;
            this.対象科目.Height = 0.1666667F;
            this.対象科目.Left = 4.989583F;
            this.対象科目.Name = "対象科目";
            this.対象科目.OutputFormat = resources.GetString("対象科目.OutputFormat");
            this.対象科目.Style = "color: Blue; font-family: ＭＳ Ｐゴシック; text-align: right; ddo-char-set: 128";
            this.対象科目.Tag = "";
            this.対象科目.Text = null;
            this.対象科目.Top = 0.5833333F;
            this.対象科目.Width = 2.072917F;
            // 
            // ラベル相手科目
            // 
            this.ラベル相手科目.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル相手科目.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル相手科目.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル相手科目.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル相手科目.Height = 0.1666667F;
            this.ラベル相手科目.HyperLink = "";
            this.ラベル相手科目.Left = 2.01875F;
            this.ラベル相手科目.Name = "ラベル相手科目";
            this.ラベル相手科目.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; text-align: center;" +
    " ddo-char-set: 128";
            this.ラベル相手科目.Tag = "";
            this.ラベル相手科目.Text = "相手科目";
            this.ラベル相手科目.Top = 1.104167F;
            this.ラベル相手科目.Width = 1.11875F;
            // 
            // ラベル34
            // 
            this.ラベル34.Height = 0.2291667F;
            this.ラベル34.HyperLink = "";
            this.ラベル34.Left = 3.166667F;
            this.ラベル34.Name = "ラベル34";
            this.ラベル34.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-ali" +
    "gn: left; ddo-char-set: 128";
            this.ラベル34.Tag = "";
            this.ラベル34.Text = "【補助元帳】";
            this.ラベル34.Top = 0F;
            this.ラベル34.Width = 1.125F;
            // 
            // ラベル起票日
            // 
            this.ラベル起票日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル起票日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル起票日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル起票日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル起票日.Height = 0.1666667F;
            this.ラベル起票日.HyperLink = "";
            this.ラベル起票日.Left = 0.7604167F;
            this.ラベル起票日.Name = "ラベル起票日";
            this.ラベル起票日.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; text-align: center;" +
    " ddo-char-set: 128";
            this.ラベル起票日.Tag = "";
            this.ラベル起票日.Text = "起票日";
            this.ラベル起票日.Top = 1.104167F;
            this.ラベル起票日.Width = 0.5249999F;
            // 
            // ラベル貸方
            // 
            this.ラベル貸方.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル貸方.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル貸方.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル貸方.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル貸方.Height = 0.1666667F;
            this.ラベル貸方.HyperLink = "";
            this.ラベル貸方.Left = 5.54375F;
            this.ラベル貸方.Name = "ラベル貸方";
            this.ラベル貸方.Style = "color: Black; font-family: ＭＳ Ｐゴシック; text-align: center; ddo-char-set: 128";
            this.ラベル貸方.Tag = "";
            this.ラベル貸方.Text = "貸方金額";
            this.ラベル貸方.Top = 1.104167F;
            this.ラベル貸方.Width = 0.8916667F;
            // 
            // ラベル借方
            // 
            this.ラベル借方.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル借方.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル借方.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル借方.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル借方.Height = 0.1666667F;
            this.ラベル借方.HyperLink = "";
            this.ラベル借方.Left = 4.652083F;
            this.ラベル借方.Name = "ラベル借方";
            this.ラベル借方.Style = "color: Black; font-family: ＭＳ Ｐゴシック; text-align: center; ddo-char-set: 128";
            this.ラベル借方.Tag = "";
            this.ラベル借方.Text = "借方金額";
            this.ラベル借方.Top = 1.104167F;
            this.ラベル借方.Width = 0.8916667F;
            // 
            // 前月繰越
            // 
            this.前月繰越.CanGrow = false;
            this.前月繰越.Height = 0.1666667F;
            this.前月繰越.Left = 6.122917F;
            this.前月繰越.Name = "前月繰越";
            this.前月繰越.OutputFormat = resources.GetString("前月繰越.OutputFormat");
            this.前月繰越.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; text-align: left; d" +
    "do-char-set: 128";
            this.前月繰越.Tag = "";
            this.前月繰越.Text = null;
            this.前月繰越.Top = 0.7708333F;
            this.前月繰越.Width = 1.017361F;
            // 
            // ラベル32
            // 
            this.ラベル32.Height = 0.1875F;
            this.ラベル32.HyperLink = "";
            this.ラベル32.Left = 0F;
            this.ラベル32.Name = "ラベル32";
            this.ラベル32.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: left; ddo-char-" +
    "set: 128";
            this.ラベル32.Tag = "";
            this.ラベル32.Text = "補助科目:";
            this.ラベル32.Top = 0.7395833F;
            this.ラベル32.Width = 0.7083333F;
            // 
            // 補助科目ID
            // 
            this.補助科目ID.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.補助科目ID.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.補助科目ID.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.補助科目ID.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.補助科目ID.Border.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.補助科目ID.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.補助科目ID.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.補助科目ID.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.補助科目ID.CanGrow = false;
            this.補助科目ID.Height = 0.1666667F;
            this.補助科目ID.Left = 3.927083F;
            this.補助科目ID.Name = "補助科目ID";
            this.補助科目ID.OutputFormat = resources.GetString("補助科目ID.OutputFormat");
            this.補助科目ID.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; text-align: left; d" +
    "do-char-set: 128";
            this.補助科目ID.Tag = "";
            this.補助科目ID.Text = "=[Forms]![勘定元帳印刷]![コンボ補助科目]";
            this.補助科目ID.Top = 0.5833333F;
            this.補助科目ID.Visible = false;
            this.補助科目ID.Width = 0.8895833F;
            // 
            // 経理区分
            // 
            this.経理区分.CanGrow = false;
            this.経理区分.Height = 0.1875F;
            this.経理区分.Left = 0F;
            this.経理区分.Name = "経理区分";
            this.経理区分.OutputFormat = resources.GetString("経理区分.OutputFormat");
            this.経理区分.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; te" +
    "xt-align: left; ddo-char-set: 128";
            this.経理区分.Tag = "";
            this.経理区分.Text = "=DLookUp(\"施設名称\",\"MT法人施設\",\"[施設番号]=[Forms]![勘定元帳印刷]![経理区分]\")";
            this.経理区分.Top = 0.3645833F;
            this.経理区分.Width = 3.025F;
            // 
            // 科目名
            // 
            this.科目名.CanGrow = false;
            this.科目名.Height = 0.1875F;
            this.科目名.Left = 0.7083333F;
            this.科目名.Name = "科目名";
            this.科目名.OutputFormat = resources.GetString("科目名.OutputFormat");
            this.科目名.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; te" +
    "xt-align: left; ddo-char-set: 128";
            this.科目名.Tag = "";
            this.科目名.Text = "=DLookUp(\"科目\",\"MT科目\",\"[科目ID]=[Forms]![勘定元帳印刷]![コンボ対象科目]\")";
            this.科目名.Top = 0.5520833F;
            this.科目名.Width = 2.983333F;
            // 
            // ラベル33
            // 
            this.ラベル33.Height = 0.1875F;
            this.ラベル33.HyperLink = "";
            this.ラベル33.Left = 0F;
            this.ラベル33.Name = "ラベル33";
            this.ラベル33.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: left; ddo-char-" +
    "set: 128";
            this.ラベル33.Tag = "";
            this.ラベル33.Text = "科目:";
            this.ラベル33.Top = 0.5520833F;
            this.ラベル33.Width = 0.7083333F;
            // 
            // ラベル差引残高
            // 
            this.ラベル差引残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル差引残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル差引残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル差引残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル差引残高.Height = 0.1666667F;
            this.ラベル差引残高.HyperLink = "";
            this.ラベル差引残高.Left = 6.435417F;
            this.ラベル差引残高.Name = "ラベル差引残高";
            this.ラベル差引残高.Style = "color: Black; font-family: ＭＳ Ｐゴシック; text-align: center; ddo-char-set: 128";
            this.ラベル差引残高.Tag = "";
            this.ラベル差引残高.Text = "差引残高";
            this.ラベル差引残高.Top = 1.104167F;
            this.ラベル差引残高.Width = 0.8916667F;
            // 
            // 貸借区分
            // 
            this.貸借区分.CanGrow = false;
            this.貸借区分.Height = 0.1666667F;
            this.貸借区分.Left = 5.729167F;
            this.貸借区分.Name = "貸借区分";
            this.貸借区分.OutputFormat = resources.GetString("貸借区分.OutputFormat");
            this.貸借区分.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; text-align: center;" +
    " ddo-char-set: 128";
            this.貸借区分.Tag = "";
            this.貸借区分.Text = null;
            this.貸借区分.Top = 0.7708333F;
            this.貸借区分.Width = 0.3395833F;
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.借方,
            this.貸方,
            this.借方集計,
            this.相手科目,
            this.貸方科目ID,
            this.コメント,
            this.借方科目ID,
            this.伝票番号,
            this.ID,
            this.差引残高,
            this.明細ID,
            this.施設名,
            this.起票日,
            this.貸方集計});
            this.detail.Height = 0.1666667F;
            this.detail.Name = "detail";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0.25F;
            this.pageFooter.Name = "pageFooter";
            // 
            // 借方
            // 
            this.借方.DataField = "借方";
            this.借方.Height = 0.1666667F;
            this.借方.Left = 4.652083F;
            this.借方.Name = "借方";
            this.借方.OutputFormat = resources.GetString("借方.OutputFormat");
            this.借方.Style = "color: Black; font-family: ＭＳ Ｐゴシック; text-align: left; ddo-char-set: 128";
            this.借方.Tag = "";
            this.借方.Text = "借方";
            this.借方.Top = 0F;
            this.借方.Width = 0.8916667F;
            // 
            // 貸方
            // 
            this.貸方.DataField = "貸方";
            this.貸方.Height = 0.1666667F;
            this.貸方.Left = 5.54375F;
            this.貸方.Name = "貸方";
            this.貸方.OutputFormat = resources.GetString("貸方.OutputFormat");
            this.貸方.Style = "color: Black; font-family: ＭＳ Ｐゴシック; text-align: left; ddo-char-set: 128";
            this.貸方.Tag = "";
            this.貸方.Text = "貸方";
            this.貸方.Top = 0F;
            this.貸方.Width = 0.8916667F;
            // 
            // 借方集計
            // 
            this.借方集計.DataField = "借方";
            this.借方集計.Height = 0.15625F;
            this.借方集計.Left = 1.447917F;
            this.借方集計.Name = "借方集計";
            this.借方集計.OutputFormat = resources.GetString("借方集計.OutputFormat");
            this.借方集計.Style = "background-color: White; color: Red; font-family: ＭＳ Ｐゴシック; font-size: 9pt; text-" +
    "align: left; ddo-char-set: 128";
            this.借方集計.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All;
            this.借方集計.Tag = "";
            this.借方集計.Text = "借方";
            this.借方集計.Top = 0F;
            this.借方集計.Visible = false;
            this.借方集計.Width = 0.4125F;
            // 
            // 相手科目
            // 
            this.相手科目.Height = 0.1666667F;
            this.相手科目.Left = 2.01875F;
            this.相手科目.Name = "相手科目";
            this.相手科目.OutputFormat = resources.GetString("相手科目.OutputFormat");
            this.相手科目.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; text-align: left; d" +
    "do-char-set: 128";
            this.相手科目.Tag = "";
            this.相手科目.Text = "=IIf([貸方]=0,DLookUp(\"科目\",\"MT科目\",\"[科目ID]= [貸方科目ID] \"),DLookUp(\"科目\",\"MT科目\",\"[科目ID]=" +
    "[借方科目ID]\"))";
            this.相手科目.Top = 0F;
            this.相手科目.Width = 1.11875F;
            // 
            // 貸方科目ID
            // 
            this.貸方科目ID.DataField = "貸方科目ID";
            this.貸方科目ID.Height = 0.15625F;
            this.貸方科目ID.Left = 3.583333F;
            this.貸方科目ID.Name = "貸方科目ID";
            this.貸方科目ID.OutputFormat = resources.GetString("貸方科目ID.OutputFormat");
            this.貸方科目ID.Style = "background-color: White; color: Red; font-family: ＭＳ Ｐゴシック; font-size: 9pt; text-" +
    "align: left; ddo-char-set: 128";
            this.貸方科目ID.Tag = "";
            this.貸方科目ID.Text = "貸方科目ID";
            this.貸方科目ID.Top = 0F;
            this.貸方科目ID.Visible = false;
            this.貸方科目ID.Width = 0.7541667F;
            // 
            // コメント
            // 
            this.コメント.DataField = "コメント";
            this.コメント.Height = 0.1666667F;
            this.コメント.Left = 3.1375F;
            this.コメント.Name = "コメント";
            this.コメント.OutputFormat = resources.GetString("コメント.OutputFormat");
            this.コメント.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; text-align: left; d" +
    "do-char-set: 128";
            this.コメント.Tag = "";
            this.コメント.Text = "コメント";
            this.コメント.Top = 0F;
            this.コメント.Width = 1.514583F;
            // 
            // 借方科目ID
            // 
            this.借方科目ID.DataField = "借方科目ID";
            this.借方科目ID.Height = 0.15625F;
            this.借方科目ID.Left = 2.783333F;
            this.借方科目ID.Name = "借方科目ID";
            this.借方科目ID.OutputFormat = resources.GetString("借方科目ID.OutputFormat");
            this.借方科目ID.Style = "background-color: White; color: Red; font-family: ＭＳ Ｐゴシック; font-size: 9pt; text-" +
    "align: left; ddo-char-set: 128";
            this.借方科目ID.Tag = "";
            this.借方科目ID.Text = "借方科目ID";
            this.借方科目ID.Top = 0F;
            this.借方科目ID.Visible = false;
            this.借方科目ID.Width = 0.5458333F;
            // 
            // 伝票番号
            // 
            this.伝票番号.DataField = "伝票番号";
            this.伝票番号.Height = 0.1666667F;
            this.伝票番号.Left = 0F;
            this.伝票番号.Name = "伝票番号";
            this.伝票番号.OutputFormat = resources.GetString("伝票番号.OutputFormat");
            this.伝票番号.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; text-align: left; d" +
    "do-char-set: 128";
            this.伝票番号.Tag = "";
            this.伝票番号.Text = "伝票番号";
            this.伝票番号.Top = 0F;
            this.伝票番号.Width = 0.7604167F;
            // 
            // ID
            // 
            this.ID.DataField = "ID";
            this.ID.Height = 0.15625F;
            this.ID.Left = 3.329167F;
            this.ID.Name = "ID";
            this.ID.OutputFormat = resources.GetString("ID.OutputFormat");
            this.ID.Style = "background-color: White; color: Red; font-family: ＭＳ Ｐゴシック; font-size: 9pt; text-" +
    "align: left; ddo-char-set: 128";
            this.ID.Tag = "";
            this.ID.Text = "ID";
            this.ID.Top = 0F;
            this.ID.Visible = false;
            this.ID.Width = 0.2541667F;
            // 
            // 差引残高
            // 
            this.差引残高.Height = 0.1666667F;
            this.差引残高.Left = 6.435417F;
            this.差引残高.Name = "差引残高";
            this.差引残高.OutputFormat = resources.GetString("差引残高.OutputFormat");
            this.差引残高.Style = "color: Black; font-family: ＭＳ Ｐゴシック; text-align: left; ddo-char-set: 128";
            this.差引残高.Tag = "";
            this.差引残高.Text = "=HojoZandakaRR()";
            this.差引残高.Top = 0F;
            this.差引残高.Width = 0.8916667F;
            // 
            // 明細ID
            // 
            this.明細ID.CanGrow = false;
            this.明細ID.DataField = "明細ID";
            this.明細ID.Height = 0.1666667F;
            this.明細ID.Left = 6.010417F;
            this.明細ID.Name = "明細ID";
            this.明細ID.OutputFormat = resources.GetString("明細ID.OutputFormat");
            this.明細ID.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 9pt; tex" +
    "t-align: left; ddo-char-set: 128";
            this.明細ID.Tag = "";
            this.明細ID.Text = "明細ID";
            this.明細ID.Top = 0F;
            this.明細ID.Visible = false;
            this.明細ID.Width = 0.4104167F;
            // 
            // 施設名
            // 
            this.施設名.Height = 0.1666667F;
            this.施設名.Left = 1.285417F;
            this.施設名.Name = "施設名";
            this.施設名.OutputFormat = resources.GetString("施設名.OutputFormat");
            this.施設名.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; text-align: left; d" +
    "do-char-set: 128";
            this.施設名.Tag = "";
            this.施設名.Text = "=Left([施設名称],6)";
            this.施設名.Top = 0F;
            this.施設名.Width = 0.7395833F;
            // 
            // 起票日
            // 
            this.起票日.DataField = "起票日";
            this.起票日.Height = 0.1666667F;
            this.起票日.Left = 0.7604167F;
            this.起票日.Name = "起票日";
            this.起票日.OutputFormat = resources.GetString("起票日.OutputFormat");
            this.起票日.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; text-align: center;" +
    " ddo-char-set: 128";
            this.起票日.Tag = "";
            this.起票日.Text = "起票日";
            this.起票日.Top = 0F;
            this.起票日.Width = 0.5249999F;
            // 
            // 貸方集計
            // 
            this.貸方集計.DataField = "貸方";
            this.貸方集計.Height = 0.15625F;
            this.貸方集計.Left = 2.38125F;
            this.貸方集計.Name = "貸方集計";
            this.貸方集計.OutputFormat = resources.GetString("貸方集計.OutputFormat");
            this.貸方集計.Style = "background-color: White; color: Red; font-family: ＭＳ Ｐゴシック; font-size: 9pt; text-" +
    "align: left; ddo-char-set: 128";
            this.貸方集計.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All;
            this.貸方集計.Tag = "";
            this.貸方集計.Text = "貸方";
            this.貸方集計.Top = 0F;
            this.貸方集計.Visible = false;
            this.貸方集計.Width = 0.4020833F;
            // 
            // HojoMototyou
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 7.327084F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.ラベル施設名称)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル明細番号)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.補助科目名)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.科目ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベルコメント)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.対象科目)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル相手科目)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル起票日)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル貸方)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル借方)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.前月繰越)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.補助科目ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.経理区分)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.科目名)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル差引残高)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.貸借区分)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.借方)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.貸方)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.借方集計)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.相手科目)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.貸方科目ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.コメント)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.借方科目ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.伝票番号)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.差引残高)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.明細ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.施設名)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.起票日)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.貸方集計)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.Label ラベル施設名称;
        private DataDynamics.ActiveReports.Label ラベル明細番号;
        private DataDynamics.ActiveReports.TextBox 補助科目名;
        private DataDynamics.ActiveReports.TextBox 科目ID;
        private DataDynamics.ActiveReports.Label ラベルコメント;
        private DataDynamics.ActiveReports.TextBox 対象科目;
        private DataDynamics.ActiveReports.Label ラベル相手科目;
        private DataDynamics.ActiveReports.Label ラベル34;
        private DataDynamics.ActiveReports.Label ラベル起票日;
        private DataDynamics.ActiveReports.Label ラベル貸方;
        private DataDynamics.ActiveReports.Label ラベル借方;
        private DataDynamics.ActiveReports.TextBox 前月繰越;
        private DataDynamics.ActiveReports.Label ラベル32;
        private DataDynamics.ActiveReports.TextBox 補助科目ID;
        private DataDynamics.ActiveReports.TextBox 経理区分;
        private DataDynamics.ActiveReports.TextBox 科目名;
        private DataDynamics.ActiveReports.Label ラベル33;
        private DataDynamics.ActiveReports.Label ラベル差引残高;
        private DataDynamics.ActiveReports.TextBox 貸借区分;
        private DataDynamics.ActiveReports.TextBox 借方;
        private DataDynamics.ActiveReports.TextBox 貸方;
        private DataDynamics.ActiveReports.TextBox 借方集計;
        private DataDynamics.ActiveReports.TextBox 相手科目;
        private DataDynamics.ActiveReports.TextBox 貸方科目ID;
        private DataDynamics.ActiveReports.TextBox コメント;
        private DataDynamics.ActiveReports.TextBox 借方科目ID;
        private DataDynamics.ActiveReports.TextBox 伝票番号;
        private DataDynamics.ActiveReports.TextBox ID;
        private DataDynamics.ActiveReports.TextBox 差引残高;
        private DataDynamics.ActiveReports.TextBox 明細ID;
        private DataDynamics.ActiveReports.TextBox 施設名;
        private DataDynamics.ActiveReports.TextBox 起票日;
        private DataDynamics.ActiveReports.TextBox 貸方集計;
    }
}
