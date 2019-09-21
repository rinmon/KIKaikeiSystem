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
    /// HikiatekinMeisaiReport の概要の説明です。
    /// </summary>
    partial class HikiatekinMeisaiReport : DataDynamics.ActiveReports.ActiveReport
    {
        private models.db.KaikeiDatabase db;

        public HikiatekinMeisaiReport() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.028f);
            this.PageSettings.Margins.Bottom = CmToInch(0.100f);
            this.PageSettings.Margins.Left = CmToInch(2.02f);
            this.PageSettings.Margins.Right = CmToInch(0.100f);
        }


        public void SetDB(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }


        public void SetHeader(DateTime startDate, DateTime endDate, string houjinMeisyou, string kaikeiKubunName) {
            lblDate.Text = lblDate.Text.Replace("%s", helper.Converter.DateTimeToWarekiStrKanji(startDate))
                                        .Replace("%e", helper.Converter.DateTimeToWarekiStrKanji(endDate));
            lblHoujinMei.Text = houjinMeisyou;
            lblKubunMei.Text = kaikeiKubunName;
        }

        private void detail_Format(object sender, EventArgs e) {
            long toukiZouka1 = (long)txtToukiZouka1.Value;
            long toukiZouka2 = (long)txtToukiZouka2.Value;
            if (toukiZouka2 == 0) {
                txtToukiZouka.Text = helper.Converter.LongToAmountWithoutYen(toukiZouka1);
            }
            else {
                txtToukiZouka.Text = helper.Converter.LongToAmountWithoutYen(toukiZouka1) + "\n("
                                    + helper.Converter.LongToAmountWithoutYen(toukiZouka2) + ")";
            }

            long sonota1 = (long)txtSonota1.Value;
            long sonota2 = (long)txtSonota2.Value;
            if (sonota2 == 0) {
                txtSonota.Text = helper.Converter.LongToAmountWithoutYen(sonota1);
            }
            else {
                txtSonota.Text = helper.Converter.LongToAmountWithoutYen(sonota1) + "\n("
                                    + helper.Converter.LongToAmountWithoutYen(sonota2) + ")";
            }
        }

        public void SetFooter(models.query.HikiatekinMeisai.MeisaiRow footerRow) {
            txtKisyuZandakaSum.Value = footerRow.KisyuZandaka;
            txtToukiZoukaSum.Text = helper.Converter.LongToAmountWithoutYen(footerRow.ToukiZouka1);
            txtMokutekiShiyouSum.Text = helper.Converter.LongToAmountWithoutYen(footerRow.MokutekiShiyou);
            txtSonotaSum.Text = helper.Converter.LongToAmountWithoutYen(footerRow.Sonota1);
            txtKimatsuZandakaSum.Text = helper.Converter.LongToAmountWithoutYen(footerRow.KimatsuZandaka);
        }
    }
}
