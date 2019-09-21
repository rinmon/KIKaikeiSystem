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
    /// KoteiShisanMeisaisyo の概要の説明です。
    /// </summary>
    partial class KoteiShisanMeisaisyo : DataDynamics.ActiveReports.ActiveReport
    {
        private models.db.KaikeiDatabase db;

        public KoteiShisanMeisaisyo() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // 横向き
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.PageSettings.Orientation = PageOrientation.Landscape;

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.0f);
            this.PageSettings.Margins.Bottom = CmToInch(1.0f);
            this.PageSettings.Margins.Left = CmToInch(3.3f);
            this.PageSettings.Margins.Right = CmToInch(0.01f);

            this.PageSettings.Gutter = 0.001f;

        }


        public void SetDB(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }

        public void SetHeader(DateTime startDate, DateTime endDate, string houjinName, string kaikeiKubunName) {
            lblDate.Text = lblDate.Text.Replace("%s", helper.Converter.DateTimeToWarekiStrKanji(startDate))
                                        .Replace("%e", helper.Converter.DateTimeToWarekiStrKanji(endDate));
            lblHoujinMei.Text = houjinName;
            lblKaikeiKubun.Text = kaikeiKubunName;
        }


        public void SetFooter(models.query.KoteiShisanMeisai.MeisaiRow sonotaRow, models.query.KoteiShisanMeisai.MeisaiRow kihonSonotaRow,
                models.query.KoteiShisanMeisai.MeisaiRow syouraiRow, models.query.KoteiShisanMeisai.MeisaiRow sashihikiRow) {
            txtSonota0.Value = sonotaRow.Col0;
            txtSonota1.Value = sonotaRow.Col1;
            txtSonota2.Value = sonotaRow.Col2;
            txtSonota3.Value = sonotaRow.Col3;
            txtSonota4.Value = sonotaRow.Col4;
            txtSonota5.Value = sonotaRow.Col5;
            txtSonota6.Value = sonotaRow.Col6;
            txtSonota0Kokko.Value = sonotaRow.Col0Kokko;
            txtSonota1Kokko.Value = sonotaRow.Col1Kokko;
            txtSonota2Kokko.Value = sonotaRow.Col2Kokko;
            txtSonota3Kokko.Value = sonotaRow.Col3Kokko;
            txtSonota4Kokko.Value = sonotaRow.Col4Kokko;
            txtSonota5Kokko.Value = sonotaRow.Col5Kokko;
            txtSonota6Kokko.Value = sonotaRow.Col6Kokko;

            txtKihonSonota0.Value = kihonSonotaRow.Col0;
            txtKihonSonota1.Value = kihonSonotaRow.Col1;
            txtKihonSonota2.Value = kihonSonotaRow.Col2;
            txtKihonSonota3.Value = kihonSonotaRow.Col3;
            txtKihonSonota4.Value = kihonSonotaRow.Col4;
            txtKihonSonota5.Value = kihonSonotaRow.Col5;
            txtKihonSonota6.Value = kihonSonotaRow.Col6;
            txtKihonSonota0Kokko.Value = kihonSonotaRow.Col0Kokko;
            txtKihonSonota1Kokko.Value = kihonSonotaRow.Col1Kokko;
            txtKihonSonota2Kokko.Value = kihonSonotaRow.Col2Kokko;
            txtKihonSonota3Kokko.Value = kihonSonotaRow.Col3Kokko;
            txtKihonSonota4Kokko.Value = kihonSonotaRow.Col4Kokko;
            txtKihonSonota5Kokko.Value = kihonSonotaRow.Col5Kokko;
            txtKihonSonota6Kokko.Value = kihonSonotaRow.Col6Kokko;

            txtSashihiki0.Value = sashihikiRow.Col0;
            txtSashihiki1.Value = sashihikiRow.Col1;
            txtSashihiki2.Value = sashihikiRow.Col2;
            txtSashihiki3.Value = sashihikiRow.Col3;
            txtSashihiki4.Value = sashihikiRow.Col4;
            txtSashihiki5.Value = sashihikiRow.Col5;
            txtSashihiki6.Value = sashihikiRow.Col6;
            txtSashihiki0Kokko.Value = sashihikiRow.Col0Kokko;
            txtSashihiki1Kokko.Value = sashihikiRow.Col1Kokko;
            txtSashihiki2Kokko.Value = sashihikiRow.Col2Kokko;
            txtSashihiki3Kokko.Value = sashihikiRow.Col3Kokko;
            txtSashihiki4Kokko.Value = sashihikiRow.Col4Kokko;
            txtSashihiki5Kokko.Value = sashihikiRow.Col5Kokko;
            txtSashihiki6Kokko.Value = sashihikiRow.Col6Kokko;
        }
        
        private void groupHeader1_Format(object sender, EventArgs e) {

        }
    }
}
