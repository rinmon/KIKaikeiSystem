namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// SyuushiYosanJissekiReport の概要の説明です。
    /// </summary>
    partial class SyuushiYosanJissekiReport
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SyuushiYosanJissekiReport));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.ラベル186 = new DataDynamics.ActiveReports.Label();
            this.ラベル98 = new DataDynamics.ActiveReports.Label();
            this.txtHoujinmei = new DataDynamics.ActiveReports.TextBox();
            this.ラベル184 = new DataDynamics.ActiveReports.Label();
            this.txtKisanbi = new DataDynamics.ActiveReports.TextBox();
            this.ラベル185 = new DataDynamics.ActiveReports.Label();
            this.txtKimatsubi = new DataDynamics.ActiveReports.TextBox();
            this.ラベル1 = new DataDynamics.ActiveReports.Label();
            this.txtKaikeiKubun1 = new DataDynamics.ActiveReports.TextBox();
            this.ボックス187 = new DataDynamics.ActiveReports.Shape();
            this.ラベル182 = new DataDynamics.ActiveReports.Label();
            this.テキスト131 = new DataDynamics.ActiveReports.Label();
            this.ラベル183 = new DataDynamics.ActiveReports.Label();
            this.ラベル103 = new DataDynamics.ActiveReports.Label();
            this.ラベル5 = new DataDynamics.ActiveReports.Label();
            this.ラベル0 = new DataDynamics.ActiveReports.Label();
            this.ラベル101 = new DataDynamics.ActiveReports.Label();
            this.ラベル64 = new DataDynamics.ActiveReports.Label();
            this.txtKaikeiKubun0 = new DataDynamics.ActiveReports.Label();
            this.テキスト130 = new DataDynamics.ActiveReports.Label();
            this.ラベル181 = new DataDynamics.ActiveReports.Label();
            this.テキスト129 = new DataDynamics.ActiveReports.Label();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.txtDetailName = new DataDynamics.ActiveReports.TextBox();
            this.txtSagakuSummary = new DataDynamics.ActiveReports.TextBox();
            this.txtSagaku1 = new DataDynamics.ActiveReports.TextBox();
            this.txtYosanSummary = new DataDynamics.ActiveReports.TextBox();
            this.ボックス198 = new DataDynamics.ActiveReports.Shape();
            this.txtYosan1 = new DataDynamics.ActiveReports.TextBox();
            this.txtJissekiSummary = new DataDynamics.ActiveReports.TextBox();
            this.txtJisseki1 = new DataDynamics.ActiveReports.TextBox();
            this.txtJisseki0 = new DataDynamics.ActiveReports.TextBox();
            this.txtYosan0 = new DataDynamics.ActiveReports.TextBox();
            this.txtSagaku0 = new DataDynamics.ActiveReports.TextBox();
            this.txtKubunIdInDetail = new DataDynamics.ActiveReports.TextBox();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.reportInfoPageCount = new DataDynamics.ActiveReports.ReportInfo();
            this.reportHeader1 = new DataDynamics.ActiveReports.ReportHeader();
            this.reportFooter1 = new DataDynamics.ActiveReports.ReportFooter();
            this.ラベル194 = new DataDynamics.ActiveReports.Label();
            this.txtKaikeiKubunSum0 = new DataDynamics.ActiveReports.Label();
            this.txtShisyutsuSagaku0 = new DataDynamics.ActiveReports.TextBox();
            this.txtSyuunyuuYosan0 = new DataDynamics.ActiveReports.TextBox();
            this.txtShisyutsuJisseki0 = new DataDynamics.ActiveReports.TextBox();
            this.txtSyuunyuuJissekiSummary = new DataDynamics.ActiveReports.TextBox();
            this.ラベル195 = new DataDynamics.ActiveReports.Label();
            this.ボックス178 = new DataDynamics.ActiveReports.Shape();
            this.ラベル192 = new DataDynamics.ActiveReports.Label();
            this.txtShisyutsuSagakuSummary = new DataDynamics.ActiveReports.TextBox();
            this.ラベル51 = new DataDynamics.ActiveReports.Label();
            this.txtShisyutsuJissekiSummary = new DataDynamics.ActiveReports.TextBox();
            this.ラベル37 = new DataDynamics.ActiveReports.Label();
            this.ラベル188 = new DataDynamics.ActiveReports.Label();
            this.ボックス180 = new DataDynamics.ActiveReports.Shape();
            this.ラベル196 = new DataDynamics.ActiveReports.Label();
            this.txtSyuunyuuJisseki0 = new DataDynamics.ActiveReports.TextBox();
            this.txtSyuunyuuSagaku1 = new DataDynamics.ActiveReports.TextBox();
            this.txtSyuunyuuYosan1 = new DataDynamics.ActiveReports.TextBox();
            this.ラベル197 = new DataDynamics.ActiveReports.Label();
            this.ラベル191 = new DataDynamics.ActiveReports.Label();
            this.txtKaikeiKubunSum1 = new DataDynamics.ActiveReports.TextBox();
            this.txtSyuunyuuSagaku0 = new DataDynamics.ActiveReports.TextBox();
            this.ラベル177 = new DataDynamics.ActiveReports.Label();
            this.txtSyuunyuuYosanSummary = new DataDynamics.ActiveReports.TextBox();
            this.txtShisyutsuSagaku1 = new DataDynamics.ActiveReports.TextBox();
            this.txtShisyutsuYosanSummary = new DataDynamics.ActiveReports.TextBox();
            this.txtSyuunyuuJisseki1 = new DataDynamics.ActiveReports.TextBox();
            this.txtShisyutsuYosan0 = new DataDynamics.ActiveReports.TextBox();
            this.txtShisyutsuYosan1 = new DataDynamics.ActiveReports.TextBox();
            this.ラベル179 = new DataDynamics.ActiveReports.Label();
            this.txtSyuunyuuSagakuSummary = new DataDynamics.ActiveReports.TextBox();
            this.ラベル189 = new DataDynamics.ActiveReports.Label();
            this.ラベル193 = new DataDynamics.ActiveReports.Label();
            this.txtShisyutsuJisseki1 = new DataDynamics.ActiveReports.TextBox();
            this.ラベル190 = new DataDynamics.ActiveReports.Label();
            this.shikinSyuushiHeader = new DataDynamics.ActiveReports.GroupHeader();
            this.txtShikinSyuushi = new DataDynamics.ActiveReports.TextBox();
            this.txtShikinSyuushiId = new DataDynamics.ActiveReports.TextBox();
            this.shikinSyuushiFooter = new DataDynamics.ActiveReports.GroupFooter();
            this.daikubunHeader = new DataDynamics.ActiveReports.GroupHeader();
            this.txtDaikubun = new DataDynamics.ActiveReports.TextBox();
            this.txtDaikubunId = new DataDynamics.ActiveReports.TextBox();
            this.txtDaikubunSummaryYosan = new DataDynamics.ActiveReports.TextBox();
            this.txtDaikubunSummaryJisseki = new DataDynamics.ActiveReports.TextBox();
            this.daikubunFooter = new DataDynamics.ActiveReports.GroupFooter();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル186)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル98)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoujinmei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル184)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKisanbi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル185)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKimatsubi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubun1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル182)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.テキスト131)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル183)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル103)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubun0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.テキスト130)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル181)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.テキスト129)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetailName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSagakuSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSagaku1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYosanSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYosan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJissekiSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJisseki1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJisseki0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYosan0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSagaku0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKubunIdInDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfoPageCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル194)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubunSum0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuSagaku0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuYosan0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuJisseki0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuJissekiSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル195)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル192)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuSagakuSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuJissekiSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル188)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル196)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuJisseki0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuSagaku1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuYosan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル197)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル191)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubunSum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuSagaku0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル177)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuYosanSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuSagaku1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuYosanSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuJisseki1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuYosan0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuYosan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル179)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuSagakuSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル189)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル193)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuJisseki1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル190)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShikinSyuushi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShikinSyuushiId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubunId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubunSummaryYosan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubunSummaryJisseki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.ラベル186,
            this.ラベル98,
            this.txtHoujinmei,
            this.ラベル184,
            this.txtKisanbi,
            this.ラベル185,
            this.txtKimatsubi,
            this.ラベル1,
            this.txtKaikeiKubun1,
            this.ボックス187,
            this.ラベル182,
            this.テキスト131,
            this.ラベル183,
            this.ラベル103,
            this.ラベル5,
            this.ラベル0,
            this.ラベル101,
            this.ラベル64,
            this.txtKaikeiKubun0,
            this.テキスト130,
            this.ラベル181,
            this.テキスト129});
            this.pageHeader.Height = 0.96875F;
            this.pageHeader.Name = "pageHeader";
            // 
            // ラベル186
            // 
            this.ラベル186.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル186.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル186.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル186.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル186.Height = 0.1666667F;
            this.ラベル186.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル186.Left = 7.077778F;
            this.ラベル186.Name = "ラベル186";
            this.ラベル186.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.ラベル186.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル186.Text = "差額";
            this.ラベル186.Top = 0.8020833F;
            this.ラベル186.Width = 0.7090278F;
            // 
            // ラベル98
            // 
            this.ラベル98.Height = 0.1458333F;
            this.ラベル98.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル98.Left = 7.010417F;
            this.ラベル98.Name = "ラベル98";
            this.ラベル98.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; text-align: center; ddo-char" +
    "-set: 128";
            this.ラベル98.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル98.Text = "（単位：円）";
            this.ラベル98.Top = 0.40625F;
            this.ラベル98.Width = 0.5520833F;
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
            this.txtHoujinmei.OutputFormat = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtHoujinmei.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; tex" +
    "t-align: left; ddo-char-set: 128";
            this.txtHoujinmei.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtHoujinmei.Text = null;
            this.txtHoujinmei.Top = 0.34375F;
            this.txtHoujinmei.Width = 2.025F;
            // 
            // ラベル184
            // 
            this.ラベル184.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル184.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル184.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル184.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル184.Height = 0.1666667F;
            this.ラベル184.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル184.Left = 5.659722F;
            this.ラベル184.Name = "ラベル184";
            this.ラベル184.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.ラベル184.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル184.Text = "予算";
            this.ラベル184.Top = 0.8020833F;
            this.ラベル184.Width = 0.7090278F;
            // 
            // txtKisanbi
            // 
            this.txtKisanbi.CanGrow = false;
            this.txtKisanbi.Height = 0.15625F;
            this.txtKisanbi.Left = 3.125F;
            this.txtKisanbi.Name = "txtKisanbi";
            this.txtKisanbi.OutputFormat = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtKisanbi.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 9pt; tex" +
    "t-align: center; ddo-char-set: 128";
            this.txtKisanbi.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtKisanbi.Text = null;
            this.txtKisanbi.Top = 0.34375F;
            this.txtKisanbi.Width = 1.264583F;
            // 
            // ラベル185
            // 
            this.ラベル185.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル185.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル185.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル185.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル185.Height = 0.1666667F;
            this.ラベル185.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル185.Left = 6.36875F;
            this.ラベル185.Name = "ラベル185";
            this.ラベル185.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.ラベル185.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル185.Text = "実績";
            this.ラベル185.Top = 0.8020833F;
            this.ラベル185.Width = 0.7090278F;
            // 
            // txtKimatsubi
            // 
            this.txtKimatsubi.CanGrow = false;
            this.txtKimatsubi.Height = 0.15625F;
            this.txtKimatsubi.Left = 4.691667F;
            this.txtKimatsubi.Name = "txtKimatsubi";
            this.txtKimatsubi.OutputFormat = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtKimatsubi.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 9pt; tex" +
    "t-align: center; ddo-char-set: 128";
            this.txtKimatsubi.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtKimatsubi.Text = null;
            this.txtKimatsubi.Top = 0.34375F;
            this.txtKimatsubi.Width = 1.264583F;
            // 
            // ラベル1
            // 
            this.ラベル1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル1.Height = 0.15625F;
            this.ラベル1.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル1.Left = 1.405556F;
            this.ラベル1.Name = "ラベル1";
            this.ラベル1.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; text-align: center; ddo-char" +
    "-set: 128";
            this.ラベル1.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル1.Text = "合計";
            this.ラベル1.Top = 0.6458333F;
            this.ラベル1.Width = 2.128472F;
            // 
            // txtKaikeiKubun1
            // 
            this.txtKaikeiKubun1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun1.CanGrow = false;
            this.txtKaikeiKubun1.Height = 0.15625F;
            this.txtKaikeiKubun1.Left = 5.6625F;
            this.txtKaikeiKubun1.Name = "txtKaikeiKubun1";
            this.txtKaikeiKubun1.OutputFormat = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtKaikeiKubun1.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; text-align: center; ddo-char" +
    "-set: 128";
            this.txtKaikeiKubun1.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtKaikeiKubun1.Text = null;
            this.txtKaikeiKubun1.Top = 0.6458333F;
            this.txtKaikeiKubun1.Width = 2.128472F;
            // 
            // ボックス187
            // 
            this.ボックス187.Height = 0.3243056F;
            this.ボックス187.Left = 0F;
            this.ボックス187.LineWeight = 0.5F;
            this.ボックス187.Name = "ボックス187";
            this.ボックス187.RoundingRadius = 9.999999F;
            this.ボックス187.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ボックス187.Top = 0.6444445F;
            this.ボックス187.Width = 1.405556F;
            // 
            // ラベル182
            // 
            this.ラベル182.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル182.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル182.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル182.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル182.Height = 0.1666667F;
            this.ラベル182.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル182.Left = 4.241667F;
            this.ラベル182.Name = "ラベル182";
            this.ラベル182.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.ラベル182.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル182.Text = "実績";
            this.ラベル182.Top = 0.8020833F;
            this.ラベル182.Width = 0.7090278F;
            // 
            // テキスト131
            // 
            this.テキスト131.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト131.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト131.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト131.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト131.Height = 0.1666667F;
            this.テキスト131.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.テキスト131.Left = 2.823611F;
            this.テキスト131.Name = "テキスト131";
            this.テキスト131.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.テキスト131.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.テキスト131.Text = "差額";
            this.テキスト131.Top = 0.8020833F;
            this.テキスト131.Width = 0.7090278F;
            // 
            // ラベル183
            // 
            this.ラベル183.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル183.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル183.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル183.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル183.Height = 0.1666667F;
            this.ラベル183.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル183.Left = 4.950695F;
            this.ラベル183.Name = "ラベル183";
            this.ラベル183.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.ラベル183.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル183.Text = "差額";
            this.ラベル183.Top = 0.8020833F;
            this.ラベル183.Width = 0.7090278F;
            // 
            // ラベル103
            // 
            this.ラベル103.Height = 0.15625F;
            this.ラベル103.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル103.Left = 4.389583F;
            this.ラベル103.Name = "ラベル103";
            this.ラベル103.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 9pt; text-align: left; ddo-char-s" +
    "et: 128";
            this.ラベル103.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル103.Text = "（至）";
            this.ラベル103.Top = 0.34375F;
            this.ラベル103.Width = 0.3020833F;
            // 
            // ラベル5
            // 
            this.ラベル5.Height = 0.25F;
            this.ラベル5.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル5.Left = 2.697917F;
            this.ラベル5.Name = "ラベル5";
            this.ラベル5.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 14pt; font-weight: bold; text-align" +
    ": center; ddo-char-set: 128";
            this.ラベル5.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル5.Text = "資金収支予算実績対比表";
            this.ラベル5.Top = 0F;
            this.ラベル5.Width = 2.614583F;
            // 
            // ラベル0
            // 
            this.ラベル0.Height = 0.15625F;
            this.ラベル0.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル0.Left = 0.3645833F;
            this.ラベル0.Name = "ラベル0";
            this.ラベル0.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; text-align: center; ddo-char" +
    "-set: 128";
            this.ラベル0.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル0.Text = "勘定科目";
            this.ラベル0.Top = 0.7291667F;
            this.ラベル0.Width = 0.5520833F;
            // 
            // ラベル101
            // 
            this.ラベル101.Height = 0.15625F;
            this.ラベル101.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル101.Left = 2.822917F;
            this.ラベル101.Name = "ラベル101";
            this.ラベル101.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 9pt; text-align: left; ddo-char-s" +
    "et: 128";
            this.ラベル101.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル101.Text = "（自）";
            this.ラベル101.Top = 0.34375F;
            this.ラベル101.Width = 0.3020833F;
            // 
            // ラベル64
            // 
            this.ラベル64.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル64.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル64.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル64.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル64.Height = 0.1458333F;
            this.ラベル64.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル64.Left = 0F;
            this.ラベル64.Name = "ラベル64";
            this.ラベル64.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; text-align: center; ddo-char" +
    "-set: 128";
            this.ラベル64.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル64.Text = "法人名";
            this.ラベル64.Top = 0.34375F;
            this.ラベル64.Width = 0.6041667F;
            // 
            // txtKaikeiKubun0
            // 
            this.txtKaikeiKubun0.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun0.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun0.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun0.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubun0.Height = 0.15625F;
            this.txtKaikeiKubun0.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtKaikeiKubun0.Left = 3.534028F;
            this.txtKaikeiKubun0.Name = "txtKaikeiKubun0";
            this.txtKaikeiKubun0.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; text-align: center; ddo-char" +
    "-set: 128";
            this.txtKaikeiKubun0.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtKaikeiKubun0.Text = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtKaikeiKubun0.Top = 0.6458333F;
            this.txtKaikeiKubun0.Width = 2.128472F;
            // 
            // テキスト130
            // 
            this.テキスト130.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト130.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト130.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト130.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト130.Height = 0.1666667F;
            this.テキスト130.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.テキスト130.Left = 2.114583F;
            this.テキスト130.Name = "テキスト130";
            this.テキスト130.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.テキスト130.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.テキスト130.Text = "実績";
            this.テキスト130.Top = 0.8020833F;
            this.テキスト130.Width = 0.7090278F;
            // 
            // ラベル181
            // 
            this.ラベル181.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル181.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル181.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル181.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル181.Height = 0.1666667F;
            this.ラベル181.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル181.Left = 3.532639F;
            this.ラベル181.Name = "ラベル181";
            this.ラベル181.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.ラベル181.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル181.Text = "予算";
            this.ラベル181.Top = 0.8020833F;
            this.ラベル181.Width = 0.7090278F;
            // 
            // テキスト129
            // 
            this.テキスト129.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト129.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト129.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト129.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.テキスト129.Height = 0.1666667F;
            this.テキスト129.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.テキスト129.Left = 1.405556F;
            this.テキスト129.Name = "テキスト129";
            this.テキスト129.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.テキスト129.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.テキスト129.Text = "予算";
            this.テキスト129.Top = 0.8020833F;
            this.テキスト129.Width = 0.7090278F;
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtDetailName,
            this.txtSagakuSummary,
            this.txtSagaku1,
            this.txtYosanSummary,
            this.ボックス198,
            this.txtYosan1,
            this.txtJissekiSummary,
            this.txtJisseki1,
            this.txtJisseki0,
            this.txtYosan0,
            this.txtSagaku0,
            this.txtKubunIdInDetail});
            this.detail.Height = 0.1458333F;
            this.detail.Name = "detail";
            this.detail.Format += new System.EventHandler(this.detail_Format);
            // 
            // txtDetailName
            // 
            this.txtDetailName.CanGrow = false;
            this.txtDetailName.DataField = "DetailName";
            this.txtDetailName.Height = 0.1458333F;
            this.txtDetailName.Left = 0.1458333F;
            this.txtDetailName.Name = "txtDetailName";
            this.txtDetailName.OutputFormat = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtDetailName.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: left; ddo-char-set" +
    ": 128";
            this.txtDetailName.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtDetailName.Text = "科目";
            this.txtDetailName.Top = 0F;
            this.txtDetailName.Width = 1.228472F;
            // 
            // txtSagakuSummary
            // 
            this.txtSagakuSummary.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSagakuSummary.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSagakuSummary.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSagakuSummary.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSagakuSummary.CanGrow = false;
            this.txtSagakuSummary.DataField = "SagakuSummary";
            this.txtSagakuSummary.Height = 0.1458333F;
            this.txtSagakuSummary.Left = 2.823611F;
            this.txtSagakuSummary.Name = "txtSagakuSummary";
            this.txtSagakuSummary.OutputFormat = resources.GetString("txtSagakuSummary.OutputFormat");
            this.txtSagakuSummary.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: right; ddo-char-se" +
    "t: 128";
            this.txtSagakuSummary.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtSagakuSummary.Text = null;
            this.txtSagakuSummary.Top = 0F;
            this.txtSagakuSummary.Width = 0.7090278F;
            // 
            // txtSagaku1
            // 
            this.txtSagaku1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSagaku1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSagaku1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSagaku1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSagaku1.CanGrow = false;
            this.txtSagaku1.DataField = "Sagaku1";
            this.txtSagaku1.Height = 0.1458333F;
            this.txtSagaku1.Left = 7.077778F;
            this.txtSagaku1.Name = "txtSagaku1";
            this.txtSagaku1.OutputFormat = resources.GetString("txtSagaku1.OutputFormat");
            this.txtSagaku1.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: right; ddo-char-se" +
    "t: 128";
            this.txtSagaku1.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtSagaku1.Text = null;
            this.txtSagaku1.Top = 0F;
            this.txtSagaku1.Width = 0.7090278F;
            // 
            // txtYosanSummary
            // 
            this.txtYosanSummary.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtYosanSummary.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtYosanSummary.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtYosanSummary.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtYosanSummary.CanGrow = false;
            this.txtYosanSummary.DataField = "YosanSummary";
            this.txtYosanSummary.Height = 0.1458333F;
            this.txtYosanSummary.Left = 1.405556F;
            this.txtYosanSummary.Name = "txtYosanSummary";
            this.txtYosanSummary.OutputFormat = resources.GetString("txtYosanSummary.OutputFormat");
            this.txtYosanSummary.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: right; ddo-char-se" +
    "t: 128";
            this.txtYosanSummary.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtYosanSummary.Text = null;
            this.txtYosanSummary.Top = 0F;
            this.txtYosanSummary.Width = 0.7090278F;
            // 
            // ボックス198
            // 
            this.ボックス198.Height = 0.1458333F;
            this.ボックス198.Left = 0F;
            this.ボックス198.LineWeight = 0.5F;
            this.ボックス198.Name = "ボックス198";
            this.ボックス198.RoundingRadius = 9.999999F;
            this.ボックス198.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ボックス198.Top = 0F;
            this.ボックス198.Width = 1.405556F;
            // 
            // txtYosan1
            // 
            this.txtYosan1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtYosan1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtYosan1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtYosan1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtYosan1.CanGrow = false;
            this.txtYosan1.DataField = "Yosan1";
            this.txtYosan1.Height = 0.1458333F;
            this.txtYosan1.Left = 5.659722F;
            this.txtYosan1.Name = "txtYosan1";
            this.txtYosan1.OutputFormat = resources.GetString("txtYosan1.OutputFormat");
            this.txtYosan1.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: right; ddo-char-se" +
    "t: 128";
            this.txtYosan1.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtYosan1.Text = null;
            this.txtYosan1.Top = 0F;
            this.txtYosan1.Width = 0.7090278F;
            // 
            // txtJissekiSummary
            // 
            this.txtJissekiSummary.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJissekiSummary.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJissekiSummary.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJissekiSummary.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJissekiSummary.CanGrow = false;
            this.txtJissekiSummary.DataField = "JissekiSummary";
            this.txtJissekiSummary.Height = 0.1458333F;
            this.txtJissekiSummary.Left = 2.114583F;
            this.txtJissekiSummary.Name = "txtJissekiSummary";
            this.txtJissekiSummary.OutputFormat = resources.GetString("txtJissekiSummary.OutputFormat");
            this.txtJissekiSummary.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: right; ddo-char-se" +
    "t: 128";
            this.txtJissekiSummary.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtJissekiSummary.Text = null;
            this.txtJissekiSummary.Top = 0F;
            this.txtJissekiSummary.Width = 0.7090278F;
            // 
            // txtJisseki1
            // 
            this.txtJisseki1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJisseki1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJisseki1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJisseki1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJisseki1.CanGrow = false;
            this.txtJisseki1.DataField = "Jisseki1";
            this.txtJisseki1.Height = 0.1458333F;
            this.txtJisseki1.Left = 6.36875F;
            this.txtJisseki1.Name = "txtJisseki1";
            this.txtJisseki1.OutputFormat = resources.GetString("txtJisseki1.OutputFormat");
            this.txtJisseki1.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: right; ddo-char-se" +
    "t: 128";
            this.txtJisseki1.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtJisseki1.Text = null;
            this.txtJisseki1.Top = 0F;
            this.txtJisseki1.Width = 0.7090278F;
            // 
            // txtJisseki0
            // 
            this.txtJisseki0.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJisseki0.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJisseki0.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJisseki0.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtJisseki0.CanGrow = false;
            this.txtJisseki0.DataField = "Jisseki0";
            this.txtJisseki0.Height = 0.1458333F;
            this.txtJisseki0.Left = 4.241667F;
            this.txtJisseki0.Name = "txtJisseki0";
            this.txtJisseki0.OutputFormat = resources.GetString("txtJisseki0.OutputFormat");
            this.txtJisseki0.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: right; ddo-char-se" +
    "t: 128";
            this.txtJisseki0.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtJisseki0.Text = null;
            this.txtJisseki0.Top = 0F;
            this.txtJisseki0.Width = 0.7090278F;
            // 
            // txtYosan0
            // 
            this.txtYosan0.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtYosan0.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtYosan0.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtYosan0.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtYosan0.CanGrow = false;
            this.txtYosan0.DataField = "Yosan0";
            this.txtYosan0.Height = 0.1458333F;
            this.txtYosan0.Left = 3.532639F;
            this.txtYosan0.Name = "txtYosan0";
            this.txtYosan0.OutputFormat = resources.GetString("txtYosan0.OutputFormat");
            this.txtYosan0.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: right; ddo-char-se" +
    "t: 128";
            this.txtYosan0.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtYosan0.Text = null;
            this.txtYosan0.Top = 0F;
            this.txtYosan0.Width = 0.7090278F;
            // 
            // txtSagaku0
            // 
            this.txtSagaku0.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSagaku0.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSagaku0.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSagaku0.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSagaku0.CanGrow = false;
            this.txtSagaku0.DataField = "Sagaku0";
            this.txtSagaku0.Height = 0.1458333F;
            this.txtSagaku0.Left = 4.950695F;
            this.txtSagaku0.Name = "txtSagaku0";
            this.txtSagaku0.OutputFormat = resources.GetString("txtSagaku0.OutputFormat");
            this.txtSagaku0.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: right; ddo-char-se" +
    "t: 128";
            this.txtSagaku0.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtSagaku0.Text = null;
            this.txtSagaku0.Top = 0F;
            this.txtSagaku0.Width = 0.7090278F;
            // 
            // txtKubunIdInDetail
            // 
            this.txtKubunIdInDetail.CanGrow = false;
            this.txtKubunIdInDetail.DataField = "KubunId";
            this.txtKubunIdInDetail.Height = 0.1458333F;
            this.txtKubunIdInDetail.Left = 0.1456693F;
            this.txtKubunIdInDetail.Name = "txtKubunIdInDetail";
            this.txtKubunIdInDetail.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 9pt; text-align: left; ddo-char-s" +
    "et: 128";
            this.txtKubunIdInDetail.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtKubunIdInDetail.Text = "区分ID";
            this.txtKubunIdInDetail.Top = 0F;
            this.txtKubunIdInDetail.Visible = false;
            this.txtKubunIdInDetail.Width = 1.18125F;
            // 
            // pageFooter
            // 
            this.pageFooter.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.reportInfoPageCount});
            this.pageFooter.Height = 0.25F;
            this.pageFooter.Name = "pageFooter";
            // 
            // reportInfoPageCount
            // 
            this.reportInfoPageCount.FormatString = "{PageNumber}/{PageCount} ページ";
            this.reportInfoPageCount.Height = 0.1456693F;
            this.reportInfoPageCount.Left = 3.520866F;
            this.reportInfoPageCount.Name = "reportInfoPageCount";
            this.reportInfoPageCount.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; tex" +
    "t-align: center; ddo-char-set: 128";
            this.reportInfoPageCount.Top = 0F;
            this.reportInfoPageCount.Width = 1.181102F;
            // 
            // reportHeader1
            // 
            this.reportHeader1.Height = 0F;
            this.reportHeader1.Name = "reportHeader1";
            // 
            // reportFooter1
            // 
            this.reportFooter1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.ラベル194,
            this.txtKaikeiKubunSum0,
            this.txtShisyutsuSagaku0,
            this.txtSyuunyuuYosan0,
            this.txtShisyutsuJisseki0,
            this.txtSyuunyuuJissekiSummary,
            this.ラベル195,
            this.ボックス178,
            this.ラベル192,
            this.txtShisyutsuSagakuSummary,
            this.ラベル51,
            this.txtShisyutsuJissekiSummary,
            this.ラベル37,
            this.ラベル188,
            this.ボックス180,
            this.ラベル196,
            this.txtSyuunyuuJisseki0,
            this.txtSyuunyuuSagaku1,
            this.txtSyuunyuuYosan1,
            this.ラベル197,
            this.ラベル191,
            this.txtKaikeiKubunSum1,
            this.txtSyuunyuuSagaku0,
            this.ラベル177,
            this.txtSyuunyuuYosanSummary,
            this.txtShisyutsuSagaku1,
            this.txtShisyutsuYosanSummary,
            this.txtSyuunyuuJisseki1,
            this.txtShisyutsuYosan0,
            this.txtShisyutsuYosan1,
            this.ラベル179,
            this.txtSyuunyuuSagakuSummary,
            this.ラベル189,
            this.ラベル193,
            this.txtShisyutsuJisseki1,
            this.ラベル190});
            this.reportFooter1.Height = 0.7171751F;
            this.reportFooter1.Name = "reportFooter1";
            this.reportFooter1.Format += new System.EventHandler(this.reportFooter1_Format);
            // 
            // ラベル194
            // 
            this.ラベル194.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル194.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル194.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル194.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル194.Height = 0.15625F;
            this.ラベル194.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル194.Left = 5.659843F;
            this.ラベル194.Name = "ラベル194";
            this.ラベル194.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.ラベル194.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル194.Text = "予算";
            this.ラベル194.Top = 0.2484252F;
            this.ラベル194.Width = 0.7090278F;
            // 
            // txtKaikeiKubunSum0
            // 
            this.txtKaikeiKubunSum0.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubunSum0.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubunSum0.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubunSum0.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubunSum0.Height = 0.15625F;
            this.txtKaikeiKubunSum0.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtKaikeiKubunSum0.Left = 3.534148F;
            this.txtKaikeiKubunSum0.Name = "txtKaikeiKubunSum0";
            this.txtKaikeiKubunSum0.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; tex" +
    "t-align: center; ddo-char-set: 128";
            this.txtKaikeiKubunSum0.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtKaikeiKubunSum0.Text = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtKaikeiKubunSum0.Top = 0.09217522F;
            this.txtKaikeiKubunSum0.Width = 2.118056F;
            // 
            // txtShisyutsuSagaku0
            // 
            this.txtShisyutsuSagaku0.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuSagaku0.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuSagaku0.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuSagaku0.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuSagaku0.CanGrow = false;
            this.txtShisyutsuSagaku0.Height = 0.15625F;
            this.txtShisyutsuSagaku0.Left = 4.950815F;
            this.txtShisyutsuSagaku0.Name = "txtShisyutsuSagaku0";
            this.txtShisyutsuSagaku0.OutputFormat = resources.GetString("txtShisyutsuSagaku0.OutputFormat");
            this.txtShisyutsuSagaku0.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtShisyutsuSagaku0.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtShisyutsuSagaku0.Text = null;
            this.txtShisyutsuSagaku0.Top = 0.5609251F;
            this.txtShisyutsuSagaku0.Width = 0.7090278F;
            // 
            // txtSyuunyuuYosan0
            // 
            this.txtSyuunyuuYosan0.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuYosan0.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuYosan0.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuYosan0.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuYosan0.CanGrow = false;
            this.txtSyuunyuuYosan0.Height = 0.15625F;
            this.txtSyuunyuuYosan0.Left = 3.532759F;
            this.txtSyuunyuuYosan0.Name = "txtSyuunyuuYosan0";
            this.txtSyuunyuuYosan0.OutputFormat = resources.GetString("txtSyuunyuuYosan0.OutputFormat");
            this.txtSyuunyuuYosan0.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtSyuunyuuYosan0.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtSyuunyuuYosan0.Text = null;
            this.txtSyuunyuuYosan0.Top = 0.4046751F;
            this.txtSyuunyuuYosan0.Width = 0.7090278F;
            // 
            // txtShisyutsuJisseki0
            // 
            this.txtShisyutsuJisseki0.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuJisseki0.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuJisseki0.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuJisseki0.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuJisseki0.CanGrow = false;
            this.txtShisyutsuJisseki0.Height = 0.15625F;
            this.txtShisyutsuJisseki0.Left = 4.241787F;
            this.txtShisyutsuJisseki0.Name = "txtShisyutsuJisseki0";
            this.txtShisyutsuJisseki0.OutputFormat = resources.GetString("txtShisyutsuJisseki0.OutputFormat");
            this.txtShisyutsuJisseki0.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtShisyutsuJisseki0.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtShisyutsuJisseki0.Text = null;
            this.txtShisyutsuJisseki0.Top = 0.5609251F;
            this.txtShisyutsuJisseki0.Width = 0.7090278F;
            // 
            // txtSyuunyuuJissekiSummary
            // 
            this.txtSyuunyuuJissekiSummary.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuJissekiSummary.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuJissekiSummary.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuJissekiSummary.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuJissekiSummary.CanGrow = false;
            this.txtSyuunyuuJissekiSummary.Height = 0.15625F;
            this.txtSyuunyuuJissekiSummary.Left = 2.114704F;
            this.txtSyuunyuuJissekiSummary.Name = "txtSyuunyuuJissekiSummary";
            this.txtSyuunyuuJissekiSummary.OutputFormat = resources.GetString("txtSyuunyuuJissekiSummary.OutputFormat");
            this.txtSyuunyuuJissekiSummary.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtSyuunyuuJissekiSummary.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtSyuunyuuJissekiSummary.Text = null;
            this.txtSyuunyuuJissekiSummary.Top = 0.4046751F;
            this.txtSyuunyuuJissekiSummary.Width = 0.7090278F;
            // 
            // ラベル195
            // 
            this.ラベル195.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル195.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル195.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル195.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル195.Height = 0.15625F;
            this.ラベル195.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル195.Left = 6.368871F;
            this.ラベル195.Name = "ラベル195";
            this.ラベル195.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.ラベル195.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル195.Text = "実績";
            this.ラベル195.Top = 0.2484252F;
            this.ラベル195.Width = 0.7090278F;
            // 
            // ボックス178
            // 
            this.ボックス178.Height = 0.15625F;
            this.ボックス178.Left = 0.0001206398F;
            this.ボックス178.LineWeight = 0.5F;
            this.ボックス178.Name = "ボックス178";
            this.ボックス178.RoundingRadius = 9.999999F;
            this.ボックス178.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ボックス178.Top = 0.4046751F;
            this.ボックス178.Width = 1.405556F;
            // 
            // ラベル192
            // 
            this.ラベル192.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル192.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル192.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル192.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル192.Height = 0.15625F;
            this.ラベル192.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル192.Left = 4.241787F;
            this.ラベル192.Name = "ラベル192";
            this.ラベル192.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.ラベル192.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル192.Text = "実績";
            this.ラベル192.Top = 0.2484252F;
            this.ラベル192.Width = 0.7090278F;
            // 
            // txtShisyutsuSagakuSummary
            // 
            this.txtShisyutsuSagakuSummary.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuSagakuSummary.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuSagakuSummary.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuSagakuSummary.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuSagakuSummary.CanGrow = false;
            this.txtShisyutsuSagakuSummary.Height = 0.15625F;
            this.txtShisyutsuSagakuSummary.Left = 2.823732F;
            this.txtShisyutsuSagakuSummary.Name = "txtShisyutsuSagakuSummary";
            this.txtShisyutsuSagakuSummary.OutputFormat = resources.GetString("txtShisyutsuSagakuSummary.OutputFormat");
            this.txtShisyutsuSagakuSummary.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtShisyutsuSagakuSummary.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtShisyutsuSagakuSummary.Text = null;
            this.txtShisyutsuSagakuSummary.Top = 0.5609251F;
            this.txtShisyutsuSagakuSummary.Width = 0.7090278F;
            // 
            // ラベル51
            // 
            this.ラベル51.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル51.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル51.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル51.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル51.Height = 0.15625F;
            this.ラベル51.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル51.Left = 0.0001206398F;
            this.ラベル51.Name = "ラベル51";
            this.ラベル51.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; tex" +
    "t-align: center; ddo-char-set: 128";
            this.ラベル51.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル51.Text = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル51.Top = 0.09217522F;
            this.ラベル51.Width = 1.405556F;
            // 
            // txtShisyutsuJissekiSummary
            // 
            this.txtShisyutsuJissekiSummary.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuJissekiSummary.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuJissekiSummary.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuJissekiSummary.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuJissekiSummary.CanGrow = false;
            this.txtShisyutsuJissekiSummary.Height = 0.15625F;
            this.txtShisyutsuJissekiSummary.Left = 2.114704F;
            this.txtShisyutsuJissekiSummary.Name = "txtShisyutsuJissekiSummary";
            this.txtShisyutsuJissekiSummary.OutputFormat = resources.GetString("txtShisyutsuJissekiSummary.OutputFormat");
            this.txtShisyutsuJissekiSummary.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtShisyutsuJissekiSummary.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtShisyutsuJissekiSummary.Text = null;
            this.txtShisyutsuJissekiSummary.Top = 0.5609251F;
            this.txtShisyutsuJissekiSummary.Width = 0.7090278F;
            // 
            // ラベル37
            // 
            this.ラベル37.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル37.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル37.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル37.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル37.Height = 0.15625F;
            this.ラベル37.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル37.Left = 1.405676F;
            this.ラベル37.Name = "ラベル37";
            this.ラベル37.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; tex" +
    "t-align: center; ddo-char-set: 128";
            this.ラベル37.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル37.Text = "合計";
            this.ラベル37.Top = 0.09217522F;
            this.ラベル37.Width = 2.128472F;
            // 
            // ラベル188
            // 
            this.ラベル188.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル188.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル188.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル188.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル188.Height = 0.15625F;
            this.ラベル188.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル188.Left = 1.405676F;
            this.ラベル188.Name = "ラベル188";
            this.ラベル188.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.ラベル188.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル188.Text = "予算";
            this.ラベル188.Top = 0.2484252F;
            this.ラベル188.Width = 0.7090278F;
            // 
            // ボックス180
            // 
            this.ボックス180.Height = 0.15625F;
            this.ボックス180.Left = 0.0001206398F;
            this.ボックス180.LineWeight = 0.5F;
            this.ボックス180.Name = "ボックス180";
            this.ボックス180.RoundingRadius = 9.999999F;
            this.ボックス180.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ボックス180.Top = 0.5609251F;
            this.ボックス180.Width = 1.405556F;
            // 
            // ラベル196
            // 
            this.ラベル196.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル196.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル196.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル196.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル196.Height = 0.15625F;
            this.ラベル196.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル196.Left = 7.077899F;
            this.ラベル196.Name = "ラベル196";
            this.ラベル196.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.ラベル196.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル196.Text = "差額";
            this.ラベル196.Top = 0.2484252F;
            this.ラベル196.Width = 0.7090278F;
            // 
            // txtSyuunyuuJisseki0
            // 
            this.txtSyuunyuuJisseki0.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuJisseki0.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuJisseki0.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuJisseki0.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuJisseki0.CanGrow = false;
            this.txtSyuunyuuJisseki0.Height = 0.15625F;
            this.txtSyuunyuuJisseki0.Left = 4.241787F;
            this.txtSyuunyuuJisseki0.Name = "txtSyuunyuuJisseki0";
            this.txtSyuunyuuJisseki0.OutputFormat = resources.GetString("txtSyuunyuuJisseki0.OutputFormat");
            this.txtSyuunyuuJisseki0.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtSyuunyuuJisseki0.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtSyuunyuuJisseki0.Text = null;
            this.txtSyuunyuuJisseki0.Top = 0.4046751F;
            this.txtSyuunyuuJisseki0.Width = 0.7090278F;
            // 
            // txtSyuunyuuSagaku1
            // 
            this.txtSyuunyuuSagaku1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuSagaku1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuSagaku1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuSagaku1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuSagaku1.CanGrow = false;
            this.txtSyuunyuuSagaku1.Height = 0.15625F;
            this.txtSyuunyuuSagaku1.Left = 7.077899F;
            this.txtSyuunyuuSagaku1.Name = "txtSyuunyuuSagaku1";
            this.txtSyuunyuuSagaku1.OutputFormat = resources.GetString("txtSyuunyuuSagaku1.OutputFormat");
            this.txtSyuunyuuSagaku1.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtSyuunyuuSagaku1.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtSyuunyuuSagaku1.Text = null;
            this.txtSyuunyuuSagaku1.Top = 0.4046751F;
            this.txtSyuunyuuSagaku1.Width = 0.7090278F;
            // 
            // txtSyuunyuuYosan1
            // 
            this.txtSyuunyuuYosan1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuYosan1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuYosan1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuYosan1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuYosan1.CanGrow = false;
            this.txtSyuunyuuYosan1.Height = 0.15625F;
            this.txtSyuunyuuYosan1.Left = 5.659843F;
            this.txtSyuunyuuYosan1.Name = "txtSyuunyuuYosan1";
            this.txtSyuunyuuYosan1.OutputFormat = resources.GetString("txtSyuunyuuYosan1.OutputFormat");
            this.txtSyuunyuuYosan1.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtSyuunyuuYosan1.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtSyuunyuuYosan1.Text = null;
            this.txtSyuunyuuYosan1.Top = 0.4046751F;
            this.txtSyuunyuuYosan1.Width = 0.7090278F;
            // 
            // ラベル197
            // 
            this.ラベル197.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル197.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル197.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル197.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル197.Height = 0.15625F;
            this.ラベル197.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル197.Left = 0.0001206398F;
            this.ラベル197.Name = "ラベル197";
            this.ラベル197.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; tex" +
    "t-align: center; ddo-char-set: 128";
            this.ラベル197.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル197.Text = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル197.Top = 0.2484252F;
            this.ラベル197.Width = 1.405556F;
            // 
            // ラベル191
            // 
            this.ラベル191.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル191.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル191.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル191.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル191.Height = 0.15625F;
            this.ラベル191.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル191.Left = 3.532759F;
            this.ラベル191.Name = "ラベル191";
            this.ラベル191.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.ラベル191.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル191.Text = "予算";
            this.ラベル191.Top = 0.2484252F;
            this.ラベル191.Width = 0.7090278F;
            // 
            // txtKaikeiKubunSum1
            // 
            this.txtKaikeiKubunSum1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubunSum1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubunSum1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubunSum1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtKaikeiKubunSum1.CanGrow = false;
            this.txtKaikeiKubunSum1.Height = 0.15625F;
            this.txtKaikeiKubunSum1.Left = 5.652204F;
            this.txtKaikeiKubunSum1.Name = "txtKaikeiKubunSum1";
            this.txtKaikeiKubunSum1.OutputFormat = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtKaikeiKubunSum1.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐゴシック; font-size: 8pt; tex" +
    "t-align: center; ddo-char-set: 128";
            this.txtKaikeiKubunSum1.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtKaikeiKubunSum1.Text = null;
            this.txtKaikeiKubunSum1.Top = 0.09217522F;
            this.txtKaikeiKubunSum1.Width = 2.128472F;
            // 
            // txtSyuunyuuSagaku0
            // 
            this.txtSyuunyuuSagaku0.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuSagaku0.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuSagaku0.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuSagaku0.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuSagaku0.CanGrow = false;
            this.txtSyuunyuuSagaku0.Height = 0.15625F;
            this.txtSyuunyuuSagaku0.Left = 4.950815F;
            this.txtSyuunyuuSagaku0.Name = "txtSyuunyuuSagaku0";
            this.txtSyuunyuuSagaku0.OutputFormat = resources.GetString("txtSyuunyuuSagaku0.OutputFormat");
            this.txtSyuunyuuSagaku0.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtSyuunyuuSagaku0.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtSyuunyuuSagaku0.Text = null;
            this.txtSyuunyuuSagaku0.Top = 0.4046751F;
            this.txtSyuunyuuSagaku0.Width = 0.7090278F;
            // 
            // ラベル177
            // 
            this.ラベル177.Height = 0.15625F;
            this.ラベル177.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル177.Left = 0.5938706F;
            this.ラベル177.Name = "ラベル177";
            this.ラベル177.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: left; ddo-char-set" +
    ": 128";
            this.ラベル177.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル177.Text = "収　入";
            this.ラベル177.Top = 0.4046751F;
            this.ラベル177.Width = 0.3854167F;
            // 
            // txtSyuunyuuYosanSummary
            // 
            this.txtSyuunyuuYosanSummary.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuYosanSummary.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuYosanSummary.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuYosanSummary.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuYosanSummary.CanGrow = false;
            this.txtSyuunyuuYosanSummary.Height = 0.15625F;
            this.txtSyuunyuuYosanSummary.Left = 1.405676F;
            this.txtSyuunyuuYosanSummary.Name = "txtSyuunyuuYosanSummary";
            this.txtSyuunyuuYosanSummary.OutputFormat = resources.GetString("txtSyuunyuuYosanSummary.OutputFormat");
            this.txtSyuunyuuYosanSummary.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtSyuunyuuYosanSummary.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtSyuunyuuYosanSummary.Text = null;
            this.txtSyuunyuuYosanSummary.Top = 0.4046751F;
            this.txtSyuunyuuYosanSummary.Width = 0.7090278F;
            // 
            // txtShisyutsuSagaku1
            // 
            this.txtShisyutsuSagaku1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuSagaku1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuSagaku1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuSagaku1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuSagaku1.CanGrow = false;
            this.txtShisyutsuSagaku1.Height = 0.15625F;
            this.txtShisyutsuSagaku1.Left = 7.077899F;
            this.txtShisyutsuSagaku1.Name = "txtShisyutsuSagaku1";
            this.txtShisyutsuSagaku1.OutputFormat = resources.GetString("txtShisyutsuSagaku1.OutputFormat");
            this.txtShisyutsuSagaku1.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtShisyutsuSagaku1.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtShisyutsuSagaku1.Text = null;
            this.txtShisyutsuSagaku1.Top = 0.5609251F;
            this.txtShisyutsuSagaku1.Width = 0.7090278F;
            // 
            // txtShisyutsuYosanSummary
            // 
            this.txtShisyutsuYosanSummary.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuYosanSummary.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuYosanSummary.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuYosanSummary.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuYosanSummary.CanGrow = false;
            this.txtShisyutsuYosanSummary.Height = 0.15625F;
            this.txtShisyutsuYosanSummary.Left = 1.405676F;
            this.txtShisyutsuYosanSummary.Name = "txtShisyutsuYosanSummary";
            this.txtShisyutsuYosanSummary.OutputFormat = resources.GetString("txtShisyutsuYosanSummary.OutputFormat");
            this.txtShisyutsuYosanSummary.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtShisyutsuYosanSummary.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtShisyutsuYosanSummary.Text = null;
            this.txtShisyutsuYosanSummary.Top = 0.5609251F;
            this.txtShisyutsuYosanSummary.Width = 0.7090278F;
            // 
            // txtSyuunyuuJisseki1
            // 
            this.txtSyuunyuuJisseki1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuJisseki1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuJisseki1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuJisseki1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuJisseki1.CanGrow = false;
            this.txtSyuunyuuJisseki1.Height = 0.15625F;
            this.txtSyuunyuuJisseki1.Left = 6.368871F;
            this.txtSyuunyuuJisseki1.Name = "txtSyuunyuuJisseki1";
            this.txtSyuunyuuJisseki1.OutputFormat = resources.GetString("txtSyuunyuuJisseki1.OutputFormat");
            this.txtSyuunyuuJisseki1.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtSyuunyuuJisseki1.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtSyuunyuuJisseki1.Text = null;
            this.txtSyuunyuuJisseki1.Top = 0.4046751F;
            this.txtSyuunyuuJisseki1.Width = 0.7090278F;
            // 
            // txtShisyutsuYosan0
            // 
            this.txtShisyutsuYosan0.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuYosan0.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuYosan0.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuYosan0.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuYosan0.CanGrow = false;
            this.txtShisyutsuYosan0.Height = 0.15625F;
            this.txtShisyutsuYosan0.Left = 3.532759F;
            this.txtShisyutsuYosan0.Name = "txtShisyutsuYosan0";
            this.txtShisyutsuYosan0.OutputFormat = resources.GetString("txtShisyutsuYosan0.OutputFormat");
            this.txtShisyutsuYosan0.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtShisyutsuYosan0.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtShisyutsuYosan0.Text = null;
            this.txtShisyutsuYosan0.Top = 0.5609251F;
            this.txtShisyutsuYosan0.Width = 0.7090278F;
            // 
            // txtShisyutsuYosan1
            // 
            this.txtShisyutsuYosan1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuYosan1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuYosan1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuYosan1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuYosan1.CanGrow = false;
            this.txtShisyutsuYosan1.Height = 0.15625F;
            this.txtShisyutsuYosan1.Left = 5.659843F;
            this.txtShisyutsuYosan1.Name = "txtShisyutsuYosan1";
            this.txtShisyutsuYosan1.OutputFormat = resources.GetString("txtShisyutsuYosan1.OutputFormat");
            this.txtShisyutsuYosan1.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtShisyutsuYosan1.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtShisyutsuYosan1.Text = null;
            this.txtShisyutsuYosan1.Top = 0.5609251F;
            this.txtShisyutsuYosan1.Width = 0.7090278F;
            // 
            // ラベル179
            // 
            this.ラベル179.Height = 0.15625F;
            this.ラベル179.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル179.Left = 0.5938706F;
            this.ラベル179.Name = "ラベル179";
            this.ラベル179.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: left; ddo-char-set" +
    ": 128";
            this.ラベル179.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル179.Text = "支　出";
            this.ラベル179.Top = 0.5609251F;
            this.ラベル179.Width = 0.3854167F;
            // 
            // txtSyuunyuuSagakuSummary
            // 
            this.txtSyuunyuuSagakuSummary.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuSagakuSummary.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuSagakuSummary.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuSagakuSummary.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtSyuunyuuSagakuSummary.CanGrow = false;
            this.txtSyuunyuuSagakuSummary.Height = 0.15625F;
            this.txtSyuunyuuSagakuSummary.Left = 2.823732F;
            this.txtSyuunyuuSagakuSummary.Name = "txtSyuunyuuSagakuSummary";
            this.txtSyuunyuuSagakuSummary.OutputFormat = resources.GetString("txtSyuunyuuSagakuSummary.OutputFormat");
            this.txtSyuunyuuSagakuSummary.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtSyuunyuuSagakuSummary.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtSyuunyuuSagakuSummary.Text = null;
            this.txtSyuunyuuSagakuSummary.Top = 0.4046751F;
            this.txtSyuunyuuSagakuSummary.Width = 0.7090278F;
            // 
            // ラベル189
            // 
            this.ラベル189.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル189.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル189.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル189.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル189.Height = 0.15625F;
            this.ラベル189.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル189.Left = 2.114704F;
            this.ラベル189.Name = "ラベル189";
            this.ラベル189.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.ラベル189.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル189.Text = "実績";
            this.ラベル189.Top = 0.2484252F;
            this.ラベル189.Width = 0.7090278F;
            // 
            // ラベル193
            // 
            this.ラベル193.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル193.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル193.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル193.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル193.Height = 0.15625F;
            this.ラベル193.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル193.Left = 4.950815F;
            this.ラベル193.Name = "ラベル193";
            this.ラベル193.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.ラベル193.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル193.Text = "差額";
            this.ラベル193.Top = 0.2484252F;
            this.ラベル193.Width = 0.7090278F;
            // 
            // txtShisyutsuJisseki1
            // 
            this.txtShisyutsuJisseki1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuJisseki1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuJisseki1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuJisseki1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShisyutsuJisseki1.CanGrow = false;
            this.txtShisyutsuJisseki1.Height = 0.15625F;
            this.txtShisyutsuJisseki1.Left = 6.368871F;
            this.txtShisyutsuJisseki1.Name = "txtShisyutsuJisseki1";
            this.txtShisyutsuJisseki1.OutputFormat = resources.GetString("txtShisyutsuJisseki1.OutputFormat");
            this.txtShisyutsuJisseki1.Style = "background-color: White; color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-" +
    "align: right; ddo-char-set: 128";
            this.txtShisyutsuJisseki1.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtShisyutsuJisseki1.Text = null;
            this.txtShisyutsuJisseki1.Top = 0.5609251F;
            this.txtShisyutsuJisseki1.Width = 0.7090278F;
            // 
            // ラベル190
            // 
            this.ラベル190.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル190.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル190.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル190.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.ラベル190.Height = 0.15625F;
            this.ラベル190.HyperLink = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル190.Left = 2.823732F;
            this.ラベル190.Name = "ラベル190";
            this.ラベル190.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 8pt; text-align: center; ddo-char-s" +
    "et: 128";
            this.ラベル190.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.ラベル190.Text = "差額";
            this.ラベル190.Top = 0.2484252F;
            this.ラベル190.Width = 0.7090278F;
            // 
            // shikinSyuushiHeader
            // 
            this.shikinSyuushiHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtShikinSyuushi,
            this.txtShikinSyuushiId});
            this.shikinSyuushiHeader.DataField = "KubunId";
            this.shikinSyuushiHeader.Height = 0.15625F;
            this.shikinSyuushiHeader.Name = "shikinSyuushiHeader";
            this.shikinSyuushiHeader.Format += new System.EventHandler(this.shikinSyuushiHeader_Format);
            // 
            // txtShikinSyuushi
            // 
            this.txtShikinSyuushi.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShikinSyuushi.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShikinSyuushi.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShikinSyuushi.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtShikinSyuushi.CanGrow = false;
            this.txtShikinSyuushi.DataField = "資金収支計算書分類項目";
            this.txtShikinSyuushi.Height = 0.15625F;
            this.txtShikinSyuushi.Left = 0F;
            this.txtShikinSyuushi.Name = "txtShikinSyuushi";
            this.txtShikinSyuushi.OutputFormat = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtShikinSyuushi.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 9pt; text-align: left; ddo-char-s" +
    "et: 128";
            this.txtShikinSyuushi.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtShikinSyuushi.Text = "資金収支計算書分類項目";
            this.txtShikinSyuushi.Top = 0F;
            this.txtShikinSyuushi.Width = 7.785417F;
            // 
            // txtShikinSyuushiId
            // 
            this.txtShikinSyuushiId.CanGrow = false;
            this.txtShikinSyuushiId.DataField = "KubunId";
            this.txtShikinSyuushiId.Height = 0.1458333F;
            this.txtShikinSyuushiId.Left = 1.864567F;
            this.txtShikinSyuushiId.Name = "txtShikinSyuushiId";
            this.txtShikinSyuushiId.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 9pt; text-align: left; ddo-char-s" +
    "et: 128";
            this.txtShikinSyuushiId.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtShikinSyuushiId.Text = "区分ID";
            this.txtShikinSyuushiId.Top = 0.01023622F;
            this.txtShikinSyuushiId.Visible = false;
            this.txtShikinSyuushiId.Width = 1.18125F;
            // 
            // shikinSyuushiFooter
            // 
            this.shikinSyuushiFooter.Height = 0F;
            this.shikinSyuushiFooter.Name = "shikinSyuushiFooter";
            // 
            // daikubunHeader
            // 
            this.daikubunHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtDaikubun,
            this.txtDaikubunId,
            this.txtDaikubunSummaryYosan,
            this.txtDaikubunSummaryJisseki});
            this.daikubunHeader.DataField = "DaikubunId";
            this.daikubunHeader.Height = 0.15625F;
            this.daikubunHeader.Name = "daikubunHeader";
            this.daikubunHeader.Format += new System.EventHandler(this.daikubunHeader_Format);
            // 
            // txtDaikubun
            // 
            this.txtDaikubun.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDaikubun.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDaikubun.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDaikubun.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtDaikubun.CanGrow = false;
            this.txtDaikubun.DataField = "大区分";
            this.txtDaikubun.Height = 0.15625F;
            this.txtDaikubun.Left = 0F;
            this.txtDaikubun.Name = "txtDaikubun";
            this.txtDaikubun.OutputFormat = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtDaikubun.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 9pt; text-align: left; ddo-char-s" +
    "et: 128";
            this.txtDaikubun.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtDaikubun.Text = "大区分";
            this.txtDaikubun.Top = 0F;
            this.txtDaikubun.Width = 7.78125F;
            // 
            // txtDaikubunId
            // 
            this.txtDaikubunId.CanGrow = false;
            this.txtDaikubunId.DataField = "DaikubunId";
            this.txtDaikubunId.Height = 0.1458333F;
            this.txtDaikubunId.Left = 1.864567F;
            this.txtDaikubunId.Name = "txtDaikubunId";
            this.txtDaikubunId.Style = "color: Black; font-family: ＭＳ Ｐゴシック; font-size: 9pt; text-align: left; ddo-char-s" +
    "et: 128";
            this.txtDaikubunId.Tag = global::KaikeiSystemBody.Properties.Resources.CaptionHierarchy;
            this.txtDaikubunId.Text = "大区分ID";
            this.txtDaikubunId.Top = 0F;
            this.txtDaikubunId.Visible = false;
            this.txtDaikubunId.Width = 1.18125F;
            // 
            // txtDaikubunSummaryYosan
            // 
            this.txtDaikubunSummaryYosan.DataField = "YosanSummary";
            this.txtDaikubunSummaryYosan.Height = 0.1559056F;
            this.txtDaikubunSummaryYosan.Left = 3.241733F;
            this.txtDaikubunSummaryYosan.Name = "txtDaikubunSummaryYosan";
            this.txtDaikubunSummaryYosan.OutputFormat = resources.GetString("txtDaikubunSummaryYosan.OutputFormat");
            this.txtDaikubunSummaryYosan.SummaryGroup = "daikubunHeader";
            this.txtDaikubunSummaryYosan.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal;
            this.txtDaikubunSummaryYosan.Text = "textBox1";
            this.txtDaikubunSummaryYosan.Top = 0F;
            this.txtDaikubunSummaryYosan.Visible = false;
            this.txtDaikubunSummaryYosan.Width = 1F;
            // 
            // txtDaikubunSummaryJisseki
            // 
            this.txtDaikubunSummaryJisseki.DataField = "JissekiSummary";
            this.txtDaikubunSummaryJisseki.Height = 0.1559056F;
            this.txtDaikubunSummaryJisseki.Left = 4.481496F;
            this.txtDaikubunSummaryJisseki.Name = "txtDaikubunSummaryJisseki";
            this.txtDaikubunSummaryJisseki.OutputFormat = resources.GetString("txtDaikubunSummaryJisseki.OutputFormat");
            this.txtDaikubunSummaryJisseki.SummaryGroup = "daikubunHeader";
            this.txtDaikubunSummaryJisseki.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal;
            this.txtDaikubunSummaryJisseki.Text = "textBox1";
            this.txtDaikubunSummaryJisseki.Top = 0F;
            this.txtDaikubunSummaryJisseki.Visible = false;
            this.txtDaikubunSummaryJisseki.Width = 1F;
            // 
            // daikubunFooter
            // 
            this.daikubunFooter.Height = 0F;
            this.daikubunFooter.Name = "daikubunFooter";
            // 
            // SyuushiYosanJissekiReport
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 7.790945F;
            this.Sections.Add(this.reportHeader1);
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.shikinSyuushiHeader);
            this.Sections.Add(this.daikubunHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.daikubunFooter);
            this.Sections.Add(this.shikinSyuushiFooter);
            this.Sections.Add(this.pageFooter);
            this.Sections.Add(this.reportFooter1);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.ラベル186)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル98)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoujinmei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル184)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKisanbi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル185)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKimatsubi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubun1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル182)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.テキスト131)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル183)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル103)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubun0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.テキスト130)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル181)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.テキスト129)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetailName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSagakuSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSagaku1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYosanSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYosan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJissekiSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJisseki1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJisseki0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYosan0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSagaku0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKubunIdInDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfoPageCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル194)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubunSum0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuSagaku0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuYosan0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuJisseki0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuJissekiSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル195)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル192)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuSagakuSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuJissekiSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル188)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル196)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuJisseki0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuSagaku1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuYosan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル197)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル191)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaikeiKubunSum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuSagaku0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル177)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuYosanSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuSagaku1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuYosanSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuJisseki1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuYosan0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuYosan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル179)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyuunyuuSagakuSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル189)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル193)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShisyutsuJisseki1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ラベル190)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShikinSyuushi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShikinSyuushiId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubunId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubunSummaryYosan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaikubunSummaryJisseki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.Label ラベル186;
        private DataDynamics.ActiveReports.Label ラベル98;
        private DataDynamics.ActiveReports.TextBox txtHoujinmei;
        private DataDynamics.ActiveReports.Label ラベル184;
        private DataDynamics.ActiveReports.TextBox txtKisanbi;
        private DataDynamics.ActiveReports.Label ラベル185;
        private DataDynamics.ActiveReports.TextBox txtKimatsubi;
        private DataDynamics.ActiveReports.Label ラベル1;
        private DataDynamics.ActiveReports.TextBox txtKaikeiKubun1;
        private DataDynamics.ActiveReports.Shape ボックス187;
        private DataDynamics.ActiveReports.Label ラベル182;
        private DataDynamics.ActiveReports.Label テキスト131;
        private DataDynamics.ActiveReports.Label ラベル183;
        private DataDynamics.ActiveReports.Label ラベル103;
        private DataDynamics.ActiveReports.Label ラベル5;
        private DataDynamics.ActiveReports.Label ラベル0;
        private DataDynamics.ActiveReports.Label ラベル101;
        private DataDynamics.ActiveReports.Label ラベル64;
        private DataDynamics.ActiveReports.Label txtKaikeiKubun0;
        private DataDynamics.ActiveReports.Label テキスト130;
        private DataDynamics.ActiveReports.Label ラベル181;
        private DataDynamics.ActiveReports.Label テキスト129;
        private DataDynamics.ActiveReports.ReportHeader reportHeader1;
        private DataDynamics.ActiveReports.ReportFooter reportFooter1;
        private DataDynamics.ActiveReports.GroupHeader shikinSyuushiHeader;
        private DataDynamics.ActiveReports.GroupFooter shikinSyuushiFooter;
        private DataDynamics.ActiveReports.GroupHeader daikubunHeader;
        private DataDynamics.ActiveReports.GroupFooter daikubunFooter;
        private DataDynamics.ActiveReports.TextBox txtShikinSyuushi;
        private DataDynamics.ActiveReports.TextBox txtDaikubun;
        private DataDynamics.ActiveReports.TextBox txtDetailName;
        private DataDynamics.ActiveReports.TextBox txtSagakuSummary;
        private DataDynamics.ActiveReports.TextBox txtSagaku1;
        private DataDynamics.ActiveReports.TextBox txtYosanSummary;
        private DataDynamics.ActiveReports.Shape ボックス198;
        private DataDynamics.ActiveReports.TextBox txtYosan1;
        private DataDynamics.ActiveReports.TextBox txtJissekiSummary;
        private DataDynamics.ActiveReports.TextBox txtJisseki1;
        private DataDynamics.ActiveReports.TextBox txtJisseki0;
        private DataDynamics.ActiveReports.TextBox txtYosan0;
        private DataDynamics.ActiveReports.TextBox txtSagaku0;
        private DataDynamics.ActiveReports.ReportInfo reportInfoPageCount;
        private DataDynamics.ActiveReports.Label ラベル194;
        private DataDynamics.ActiveReports.Label txtKaikeiKubunSum0;
        private DataDynamics.ActiveReports.TextBox txtShisyutsuSagaku0;
        private DataDynamics.ActiveReports.TextBox txtSyuunyuuYosan0;
        private DataDynamics.ActiveReports.TextBox txtShisyutsuJisseki0;
        private DataDynamics.ActiveReports.TextBox txtSyuunyuuJissekiSummary;
        private DataDynamics.ActiveReports.Label ラベル195;
        private DataDynamics.ActiveReports.Shape ボックス178;
        private DataDynamics.ActiveReports.Label ラベル192;
        private DataDynamics.ActiveReports.TextBox txtShisyutsuSagakuSummary;
        private DataDynamics.ActiveReports.Label ラベル51;
        private DataDynamics.ActiveReports.TextBox txtShisyutsuJissekiSummary;
        private DataDynamics.ActiveReports.Label ラベル37;
        private DataDynamics.ActiveReports.Label ラベル188;
        private DataDynamics.ActiveReports.Shape ボックス180;
        private DataDynamics.ActiveReports.Label ラベル196;
        private DataDynamics.ActiveReports.TextBox txtSyuunyuuJisseki0;
        private DataDynamics.ActiveReports.TextBox txtSyuunyuuSagaku1;
        private DataDynamics.ActiveReports.TextBox txtSyuunyuuYosan1;
        private DataDynamics.ActiveReports.Label ラベル197;
        private DataDynamics.ActiveReports.Label ラベル191;
        private DataDynamics.ActiveReports.TextBox txtKaikeiKubunSum1;
        private DataDynamics.ActiveReports.TextBox txtSyuunyuuSagaku0;
        private DataDynamics.ActiveReports.Label ラベル177;
        private DataDynamics.ActiveReports.TextBox txtSyuunyuuYosanSummary;
        private DataDynamics.ActiveReports.TextBox txtShisyutsuSagaku1;
        private DataDynamics.ActiveReports.TextBox txtShisyutsuYosanSummary;
        private DataDynamics.ActiveReports.TextBox txtSyuunyuuJisseki1;
        private DataDynamics.ActiveReports.TextBox txtShisyutsuYosan0;
        private DataDynamics.ActiveReports.TextBox txtShisyutsuYosan1;
        private DataDynamics.ActiveReports.Label ラベル179;
        private DataDynamics.ActiveReports.TextBox txtSyuunyuuSagakuSummary;
        private DataDynamics.ActiveReports.Label ラベル189;
        private DataDynamics.ActiveReports.Label ラベル193;
        private DataDynamics.ActiveReports.TextBox txtShisyutsuJisseki1;
        private DataDynamics.ActiveReports.Label ラベル190;
        private DataDynamics.ActiveReports.TextBox txtShikinSyuushiId;
        private DataDynamics.ActiveReports.TextBox txtDaikubunId;
        private DataDynamics.ActiveReports.TextBox txtKubunIdInDetail;
        private DataDynamics.ActiveReports.TextBox txtDaikubunSummaryYosan;
        private DataDynamics.ActiveReports.TextBox txtDaikubunSummaryJisseki;
    }
}
