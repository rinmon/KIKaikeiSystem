﻿namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// BalanceSheetTyuuki1 の概要の説明です。
    /// </summary>
    partial class TyuukiSubReportKoteiShisan
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TyuukiSubReportKoteiShisan));
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.txtKubunName = new DataDynamics.ActiveReports.TextBox();
            this.textBox1 = new DataDynamics.ActiveReports.TextBox();
            this.textBox2 = new DataDynamics.ActiveReports.TextBox();
            this.textBox3 = new DataDynamics.ActiveReports.TextBox();
            this.textBox4 = new DataDynamics.ActiveReports.TextBox();
            this.reportHeader1 = new DataDynamics.ActiveReports.ReportHeader();
            this.label1 = new DataDynamics.ActiveReports.Label();
            this.科目_ラベル = new DataDynamics.ActiveReports.Label();
            this.label2 = new DataDynamics.ActiveReports.Label();
            this.label3 = new DataDynamics.ActiveReports.Label();
            this.label4 = new DataDynamics.ActiveReports.Label();
            this.label5 = new DataDynamics.ActiveReports.Label();
            this.label6 = new DataDynamics.ActiveReports.Label();
            this.reportFooter1 = new DataDynamics.ActiveReports.ReportFooter();
            this.textBox5 = new DataDynamics.ActiveReports.TextBox();
            this.textBox6 = new DataDynamics.ActiveReports.TextBox();
            this.textBox7 = new DataDynamics.ActiveReports.TextBox();
            this.textBox8 = new DataDynamics.ActiveReports.TextBox();
            this.textBox9 = new DataDynamics.ActiveReports.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtKubunName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.科目_ラベル)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtKubunName,
            this.textBox1,
            this.textBox2,
            this.textBox3,
            this.textBox4});
            this.detail.Height = 0.1875F;
            this.detail.Name = "detail";
            // 
            // txtKubunName
            // 
            this.txtKubunName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKubunName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKubunName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKubunName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKubunName.CanGrow = false;
            this.txtKubunName.DataField = "Name";
            this.txtKubunName.Height = 0.1875F;
            this.txtKubunName.Left = 0F;
            this.txtKubunName.Name = "txtKubunName";
            this.txtKubunName.OutputFormat = resources.GetString("txtKubunName.OutputFormat");
            this.txtKubunName.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 9.75" +
    "pt; text-align: left; vertical-align: middle; ddo-char-set: 1";
            this.txtKubunName.Tag = "";
            this.txtKubunName.Text = "科目名";
            this.txtKubunName.Top = 0F;
            this.txtKubunName.Width = 1.457874F;
            // 
            // textBox1
            // 
            this.textBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox1.CanGrow = false;
            this.textBox1.DataField = "ZenkiZandaka";
            this.textBox1.Height = 0.1875F;
            this.textBox1.Left = 1.457874F;
            this.textBox1.Name = "textBox1";
            this.textBox1.OutputFormat = resources.GetString("textBox1.OutputFormat");
            this.textBox1.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 9.75" +
    "pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
            this.textBox1.Tag = "";
            this.textBox1.Text = "科目名";
            this.textBox1.Top = 0F;
            this.textBox1.Width = 1.223229F;
            // 
            // textBox2
            // 
            this.textBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox2.CanGrow = false;
            this.textBox2.DataField = "ToukiZouka";
            this.textBox2.Height = 0.1875F;
            this.textBox2.Left = 2.681103F;
            this.textBox2.Name = "textBox2";
            this.textBox2.OutputFormat = resources.GetString("textBox2.OutputFormat");
            this.textBox2.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 9.75" +
    "pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
            this.textBox2.Tag = "";
            this.textBox2.Text = "科目名";
            this.textBox2.Top = 0F;
            this.textBox2.Width = 1.223228F;
            // 
            // textBox3
            // 
            this.textBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox3.CanGrow = false;
            this.textBox3.DataField = "ToukiGensyou";
            this.textBox3.Height = 0.1875F;
            this.textBox3.Left = 3.904331F;
            this.textBox3.Name = "textBox3";
            this.textBox3.OutputFormat = resources.GetString("textBox3.OutputFormat");
            this.textBox3.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 9.75" +
    "pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
            this.textBox3.Tag = "";
            this.textBox3.Text = "科目名";
            this.textBox3.Top = 0F;
            this.textBox3.Width = 1.223228F;
            // 
            // textBox4
            // 
            this.textBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox4.CanGrow = false;
            this.textBox4.DataField = "ToukimatsuZandaka";
            this.textBox4.Height = 0.1875F;
            this.textBox4.Left = 5.127559F;
            this.textBox4.Name = "textBox4";
            this.textBox4.OutputFormat = resources.GetString("textBox4.OutputFormat");
            this.textBox4.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 9.75" +
    "pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
            this.textBox4.Tag = "";
            this.textBox4.Text = "科目名";
            this.textBox4.Top = 0F;
            this.textBox4.Width = 1.223228F;
            // 
            // reportHeader1
            // 
            this.reportHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.label1,
            this.科目_ラベル,
            this.label2,
            this.label3,
            this.label4,
            this.label5,
            this.label6});
            this.reportHeader1.Height = 0.3901575F;
            this.reportHeader1.Name = "reportHeader1";
            // 
            // label1
            // 
            this.label1.Height = 0.2082677F;
            this.label1.HyperLink = null;
            this.label1.Left = 0.2811024F;
            this.label1.Name = "label1";
            this.label1.Style = "font-family: ＭＳ Ｐ明朝; font-size: 9.75pt";
            this.label1.Text = "基本財産の増減の内容及び金額は以下のとおりである。";
            this.label1.Top = 0F;
            this.label1.Width = 3.718898F;
            // 
            // 科目_ラベル
            // 
            this.科目_ラベル.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.科目_ラベル.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.科目_ラベル.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.科目_ラベル.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.科目_ラベル.Height = 0.1818898F;
            this.科目_ラベル.HyperLink = "";
            this.科目_ラベル.Left = 0F;
            this.科目_ラベル.Name = "科目_ラベル";
            this.科目_ラベル.Style = "color: buttontext; font-family: ＭＳ Ｐ明朝; font-size: 9.75pt; text-align: center; ve" +
    "rtical-align: middle; ddo-char-set: 128";
            this.科目_ラベル.Tag = "DetachedLabel";
            this.科目_ラベル.Text = "科目";
            this.科目_ラベル.Top = 0.2082677F;
            this.科目_ラベル.Width = 1.457874F;
            // 
            // label2
            // 
            this.label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label2.Height = 0.1818898F;
            this.label2.HyperLink = "";
            this.label2.Left = 1.457874F;
            this.label2.Name = "label2";
            this.label2.Style = "color: buttontext; font-family: ＭＳ Ｐ明朝; font-size: 9.75pt; text-align: center; ve" +
    "rtical-align: middle; ddo-char-set: 128";
            this.label2.Tag = "DetachedLabel";
            this.label2.Text = "前期末残高";
            this.label2.Top = 0.2082677F;
            this.label2.Width = 1.223228F;
            // 
            // label3
            // 
            this.label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label3.Height = 0.1818898F;
            this.label3.HyperLink = "";
            this.label3.Left = 2.681103F;
            this.label3.Name = "label3";
            this.label3.Style = "color: buttontext; font-family: ＭＳ Ｐ明朝; font-size: 9.75pt; text-align: center; ve" +
    "rtical-align: middle; ddo-char-set: 128";
            this.label3.Tag = "DetachedLabel";
            this.label3.Text = "当期増加額";
            this.label3.Top = 0.2082677F;
            this.label3.Width = 1.223228F;
            // 
            // label4
            // 
            this.label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label4.Height = 0.1818898F;
            this.label4.HyperLink = "";
            this.label4.Left = 3.904331F;
            this.label4.Name = "label4";
            this.label4.Style = "color: buttontext; font-family: ＭＳ Ｐ明朝; font-size: 9.75pt; text-align: center; ve" +
    "rtical-align: middle; ddo-char-set: 128";
            this.label4.Tag = "DetachedLabel";
            this.label4.Text = "当期減少額";
            this.label4.Top = 0.2082677F;
            this.label4.Width = 1.223228F;
            // 
            // label5
            // 
            this.label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label5.Height = 0.1818898F;
            this.label5.HyperLink = "";
            this.label5.Left = 5.127559F;
            this.label5.Name = "label5";
            this.label5.Style = "color: buttontext; font-family: ＭＳ Ｐ明朝; font-size: 9.75pt; text-align: center; ve" +
    "rtical-align: middle; ddo-char-set: 128";
            this.label5.Tag = "DetachedLabel";
            this.label5.Text = "当期末残高";
            this.label5.Top = 0.2082677F;
            this.label5.Width = 1.223228F;
            // 
            // label6
            // 
            this.label6.Height = 0.1980315F;
            this.label6.HyperLink = null;
            this.label6.Left = 5.527953F;
            this.label6.Name = "label6";
            this.label6.Style = "font-family: ＭＳ Ｐ明朝; font-size: 9.75pt; vertical-align: bottom";
            this.label6.Text = "（単位：円）";
            this.label6.Top = 0F;
            this.label6.Width = 0.6771655F;
            // 
            // reportFooter1
            // 
            this.reportFooter1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.textBox5,
            this.textBox6,
            this.textBox7,
            this.textBox8,
            this.textBox9});
            this.reportFooter1.Height = 0.1875F;
            this.reportFooter1.Name = "reportFooter1";
            // 
            // textBox5
            // 
            this.textBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox5.CanGrow = false;
            this.textBox5.Height = 0.1875F;
            this.textBox5.Left = 0F;
            this.textBox5.Name = "textBox5";
            this.textBox5.OutputFormat = resources.GetString("textBox5.OutputFormat");
            this.textBox5.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 9.75" +
    "pt; text-align: center; vertical-align: middle; ddo-char-set: 1";
            this.textBox5.Tag = "";
            this.textBox5.Text = "合計";
            this.textBox5.Top = 0F;
            this.textBox5.Width = 1.457874F;
            // 
            // textBox6
            // 
            this.textBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox6.CanGrow = false;
            this.textBox6.DataField = "ZenkiZandaka";
            this.textBox6.Height = 0.1875F;
            this.textBox6.Left = 1.457874F;
            this.textBox6.Name = "textBox6";
            this.textBox6.OutputFormat = resources.GetString("textBox6.OutputFormat");
            this.textBox6.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 9.75" +
    "pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
            this.textBox6.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal;
            this.textBox6.Tag = "";
            this.textBox6.Text = "科目名";
            this.textBox6.Top = 0F;
            this.textBox6.Width = 1.223228F;
            // 
            // textBox7
            // 
            this.textBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox7.CanGrow = false;
            this.textBox7.DataField = "ToukiZouka";
            this.textBox7.Height = 0.1875F;
            this.textBox7.Left = 2.681103F;
            this.textBox7.Name = "textBox7";
            this.textBox7.OutputFormat = resources.GetString("textBox7.OutputFormat");
            this.textBox7.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 9.75" +
    "pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
            this.textBox7.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal;
            this.textBox7.Tag = "";
            this.textBox7.Text = "科目名";
            this.textBox7.Top = 0F;
            this.textBox7.Width = 1.223228F;
            // 
            // textBox8
            // 
            this.textBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox8.CanGrow = false;
            this.textBox8.DataField = "ToukiGensyou";
            this.textBox8.Height = 0.1875F;
            this.textBox8.Left = 3.904331F;
            this.textBox8.Name = "textBox8";
            this.textBox8.OutputFormat = resources.GetString("textBox8.OutputFormat");
            this.textBox8.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 9.75" +
    "pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
            this.textBox8.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal;
            this.textBox8.Tag = "";
            this.textBox8.Text = "科目名";
            this.textBox8.Top = 0F;
            this.textBox8.Width = 1.223228F;
            // 
            // textBox9
            // 
            this.textBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox9.CanGrow = false;
            this.textBox9.DataField = "ToukimatsuZandaka";
            this.textBox9.Height = 0.1875F;
            this.textBox9.Left = 5.127559F;
            this.textBox9.Name = "textBox9";
            this.textBox9.OutputFormat = resources.GetString("textBox9.OutputFormat");
            this.textBox9.Style = "background-color: window; color: windowtext; font-family: ＭＳ Ｐ明朝; font-size: 9.75" +
    "pt; text-align: right; vertical-align: middle; ddo-char-set: 1";
            this.textBox9.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal;
            this.textBox9.Tag = "";
            this.textBox9.Text = "科目名";
            this.textBox9.Top = 0F;
            this.textBox9.Width = 1.223228F;
            // 
            // TyuukiSubReportKoteiShisan
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 6.350788F;
            this.Sections.Add(this.reportHeader1);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.reportFooter1);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.txtKubunName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.科目_ラベル)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.ReportHeader reportHeader1;
        private DataDynamics.ActiveReports.ReportFooter reportFooter1;
        private DataDynamics.ActiveReports.Label label1;
        private DataDynamics.ActiveReports.Label 科目_ラベル;
        private DataDynamics.ActiveReports.Label label2;
        private DataDynamics.ActiveReports.Label label3;
        private DataDynamics.ActiveReports.Label label4;
        private DataDynamics.ActiveReports.Label label5;
        private DataDynamics.ActiveReports.Label label6;
        private DataDynamics.ActiveReports.TextBox txtKubunName;
        private DataDynamics.ActiveReports.TextBox textBox1;
        private DataDynamics.ActiveReports.TextBox textBox2;
        private DataDynamics.ActiveReports.TextBox textBox3;
        private DataDynamics.ActiveReports.TextBox textBox4;
        private DataDynamics.ActiveReports.TextBox textBox5;
        private DataDynamics.ActiveReports.TextBox textBox6;
        private DataDynamics.ActiveReports.TextBox textBox7;
        private DataDynamics.ActiveReports.TextBox textBox8;
        private DataDynamics.ActiveReports.TextBox textBox9;


    }
}
