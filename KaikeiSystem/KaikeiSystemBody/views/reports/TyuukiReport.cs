using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// TyuukiReport の概要の説明です。
    /// </summary>
    partial class TyuukiReport : DataDynamics.ActiveReports.ActiveReport
    {
        private models.db.KaikeiDatabase db;

        public models.query.Tyuuki Tyuuki { get; set; }

        public bool IsHoujinKyoten {
            get;
            set;
        }

        public TyuukiReport() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.34f);
            this.PageSettings.Margins.Bottom = CmToInch(0.50f);
            this.PageSettings.Margins.Left = CmToInch(2.77f);
            this.PageSettings.Margins.Right = CmToInch(0.500f);
        }

        public void SetDB(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }

        private void SetSubreportAsTextReport(string contents) {
            var subReport = new TyuukiSubReportText();
            subReport.Contents = contents;
            this.subReport1.Report = subReport;
        }

        private void SetSubreportAsGaitouNashi() {
            SetSubreportAsTextReport("該当なし");
        }

        private void SetSubreportAsKoteiShisanList() {
            if (Tyuuki.GetTKoteiShisanRows().Count > 0) {
                var subReport = new TyuukiSubReportKoteiShisan();
                subReport.DataSource = Tyuuki.GetTKoteiShisanRows();
                this.subReport1.Report = subReport;
            }
            else {
                SetSubreportAsGaitouNashi();
            }
        }

        private void SetSubreportAsTanpoList() {
            if (Tyuuki.GetTanpoRows().Count > 0) {
                var subReport = new TyuukiSubReportTanpo();
                subReport.DataSource = Tyuuki.GetTanpoRows();
                this.subReport1.Report = subReport;
            }
            else {
                SetSubreportAsGaitouNashi();
            }
        }

        private void SetSubreportAsShisanList() {
            if (Tyuuki.GetShisanRows().Count > 0) {
                var subReport = new TyuukiSubReportShisan();
                subReport.DataSource = Tyuuki.GetShisanRows();
                this.subReport1.Report = subReport;
            }
            else {
                SetSubreportAsGaitouNashi();
            }
        }

        private void SetSubreportAsSaikenList() {
            if (Tyuuki.GetSaikenRows().Count > 0) {
                var subReport = new TyuukiSubReportSaiken();
                subReport.DataSource = Tyuuki.GetSaikenRows();
                this.subReport1.Report = subReport;
            }
            else {
                SetSubreportAsGaitouNashi();
            }
        }

        private void SetSubreportAsMankiSaikenList() {
            if (Tyuuki.GetMankiSaikenRows().Count > 0) {
                var subReport = new TyuukiSubReportMankiSaiken();
                subReport.DataSource = Tyuuki.GetMankiSaikenRows();
                this.subReport1.Report = subReport;
            }
            else {
                SetSubreportAsGaitouNashi();
            }
        }

        private void detail_Format(object sender, EventArgs e) {
            int rowType = helper.Converter.ObjToInt(txtRowType.Text, -1);
            int rowId = helper.Converter.ObjToInt(txtRowId.Text, 0);
            string lbl;
            string contents = txtContents.Text;

            lbl = helper.Converter.HankakuNumToZenkakuNum(rowId.ToString()) + "．";

            if (rowType == (int)models.query.Tyuuki.RowType.KihonzaisanZougen) {
                SetSubreportAsKoteiShisanList();
            }
            else if (rowType == (int)models.query.Tyuuki.RowType.Tanpo) {
                SetSubreportAsTanpoList();
            }
            else if (rowType == (int)models.query.Tyuuki.RowType.Koteishisan) {
                SetSubreportAsShisanList();
            }
            else if (rowType == (int)models.query.Tyuuki.RowType.Saiken) {
                SetSubreportAsSaikenList();
            }
            else if (rowType == (int)models.query.Tyuuki.RowType.MankiSyouken) {
                SetSubreportAsMankiSaikenList();
            }
            else {
                SetSubreportAsTextReport(contents);
            }
            
            switch (rowType) {
                case (int)models.query.Tyuuki.RowType.KeizokuJigyouZentaiTyuuki:
                    lbl += "継続事業の全体に関する注記";
                    break;
                case (int)models.query.Tyuuki.RowType.JuuyouKaikeihoushin:
                    lbl += "重要な会計方針";
                    break;
                case (int)models.query.Tyuuki.RowType.JuuyouKaikeihoushinHenkou:
                    lbl += "重要な会計方針の変更";
                    break;
                case (int)models.query.Tyuuki.RowType.HoujinTaisyokuKyuuhuSeido:
                    if (IsHoujinKyoten) {
                        lbl += "法人で";
                    }
                    lbl += "採用する退職給付制度";
                    break;
                case (int)models.query.Tyuuki.RowType.HoujinSakuseiZaimushyohyou:
                    if (IsHoujinKyoten) {
                        lbl += "法人が作成する財務諸表と拠点区分、サービス区分";
                    }
                    else {
                        lbl += "拠点が作成する財務諸表とサービス区分";
                    }
                    break;
                case (int)models.query.Tyuuki.RowType.KihonzaisanZougen:
                    lbl += "基本財産の増減の内容及び金額";
                    break;
                case (int)models.query.Tyuuki.RowType.Torikuzushi:
                    lbl += "会計基準第３章第４（４）及び（６）の規定による基本金又は国庫補助金等特別積立金の取崩";
                    break;
                case (int)models.query.Tyuuki.RowType.Tanpo:
                    lbl += "担保に供している資産";
                    break;
                case (int)models.query.Tyuuki.RowType.Koteishisan:
                    lbl += "固定資産の取得価額、減価償却累計額及び当期末残高";
                    break;
                case (int)models.query.Tyuuki.RowType.Saiken:
                    lbl += "債権額、徴収不能引当金の当期末残高、債権の当期末残高";
                    break;
                case (int)models.query.Tyuuki.RowType.MankiSyouken:
                    lbl += "満期保有目的の債権の内訳及びに帳簿価額、時価及び評価損益";
                    break;
                case (int)models.query.Tyuuki.RowType.TorihikiNaiyou:
                    lbl += "関連当事者との取引内容";
                    break;
                case (int)models.query.Tyuuki.RowType.JuuyouGuhatsuSaimu:
                    lbl += "重要な偶発債務";
                    break;
                case (int)models.query.Tyuuki.RowType.JuuyouKouhatsuJisyou:
                    lbl += "重要な後発事象";
                    break;
                case (int)models.query.Tyuuki.RowType.Sonota:
                    lbl += "その他社会福祉法人の資金収支及び純資産増減の状況並びに資産、負債及び純資産の状態を明らかにするために必要な事項";
                    break;
            }

            txtCaption.Text = lbl;
        }
    }
}
