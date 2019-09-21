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
    /// GoukeiZandakaShisanhyou の概要の説明です。
    /// </summary>
    partial class GoukeiZandakaShisanhyou : DataDynamics.ActiveReports.ActiveReport
    {
        private models.db.KaikeiDatabase db;


        public GoukeiZandakaShisanhyou() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.501f);
            this.PageSettings.Margins.Bottom = CmToInch(1.00f);
            this.PageSettings.Margins.Left = CmToInch(1.0f);
            this.PageSettings.Margins.Right = CmToInch(0.529f);
        }

        public void SetDB(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }


        public void SetHeader(string kaikeiKubunName, DateTime date) {
            txtDate.Text = helper.Converter.DateTimeToWarekiStrKanji(date, withoutDay: true);
            txtKaikeiKubun.Text = kaikeiKubunName;
        }


        private void daikubunHeader_Format(object sender, EventArgs e) {
            models.db.Row row = db.MTKamokuKubun.GetRowFromCache(helper.Converter.ObjToInt(txtDaikubunId.Text, -1));

            if (row != null) {
                txtDaikubun.Text = "【" + row.GetStr("name", "") + "】";
            }
        }

        private void detail_Format(object sender, EventArgs e) {
            models.db.Row row = db.MTKanjouKamoku.GetRowFromCache(helper.Converter.ObjToInt(txtKamokuId.Text, -1));

            if (row != null) {
                txtKamoku.Text = new string(' ', count:(int)row.GetLong("hierarchy", 0) * 2) + row.GetStr("kamoku", "");
            }

            SetNullWhenZero(txtZengetsuKarikata);
            SetNullWhenZero(txtZengetsuKashikata);
            SetNullWhenZero(txtShikinTougetsuKarikata);
            SetNullWhenZero(txtShikinTougetsuKashikata);
            SetNullWhenZero(txtShikinZandakaKarikata);
            SetNullWhenZero(txtShikinZandakaKashikata);
            SetNullWhenZero(txtJigyouTougetsuKarikata);
            SetNullWhenZero(txtJigyouTougetsuKashikata);
            SetNullWhenZero(txtJigyouZandakaKarikata);
            SetNullWhenZero(txtJigyouZandakaKashikata);
        }

        private void SetNullWhenZero(DataDynamics.ActiveReports.TextBox textBox) {
            if (textBox.Text == "0") {
                textBox.Text = "";
            }
        }

        private void groupFooter_Format(object sender, EventArgs e) {
            int groupId = helper.Converter.ObjToInt(txtGroupId.Text, -1);

            switch (groupId) {
                case models.query.GoukeiZandakaShisanhyou.GroupIdShisan:
                    txtGroupName.Text = "資産合計";
                    txtFooter1_1.Text = txtGroupZengetsuKarikata.Text;
                    txtFooter1_2.Text = txtGroupZengetsuKashikata.Text;
                    txtFooter1_3.Text = txtGroupShikinTougetsuKarikata.Text;
                    txtFooter1_4.Text = txtGroupShikinTougetsuKashikata.Text;
                    txtFooter1_5.Text = txtGroupShikinZandakaKarikata.Text;
                    txtFooter1_6.Text = txtGroupShikinZandakaKashikata.Text;
                    txtFooter1_7.Text = txtGroupJigyouTougetsuKarikata.Text;
                    txtFooter1_8.Text = txtGroupJigyouTougetsuKashikata.Text;
                    txtFooter1_9.Text = txtGroupJigyouZandakaKarikata.Text;
                    txtFooter1_10.Text = txtGroupJigyouZandakaKashikata.Text;
                    break;
                case models.query.GoukeiZandakaShisanhyou.GroupIdHusaiJunsisan:
                    txtGroupName.Text = "負債・純資産合計";
                    txtFooter2_1.Text = txtGroupZengetsuKarikata.Text;
                    txtFooter2_2.Text = txtGroupZengetsuKashikata.Text;
                    txtFooter2_3.Text = txtGroupShikinTougetsuKarikata.Text;
                    txtFooter2_4.Text = txtGroupShikinTougetsuKashikata.Text;
                    txtFooter2_5.Text = txtGroupShikinZandakaKarikata.Text;
                    txtFooter2_6.Text = txtGroupShikinZandakaKashikata.Text;
                    txtFooter2_7.Text = txtGroupJigyouTougetsuKarikata.Text;
                    txtFooter2_8.Text = txtGroupJigyouTougetsuKashikata.Text;
                    txtFooter2_9.Text = txtGroupJigyouZandakaKarikata.Text;
                    txtFooter2_10.Text = txtGroupJigyouZandakaKashikata.Text;
                    break;
                case models.query.GoukeiZandakaShisanhyou.GroupIdSyuunyuu:
                    txtGroupName.Text = "収入合計";
                    txtFooter3_1.Text = txtGroupZengetsuKarikata.Text;
                    txtFooter3_2.Text = txtGroupZengetsuKashikata.Text;
                    txtFooter3_3.Text = txtGroupShikinTougetsuKarikata.Text;
                    txtFooter3_4.Text = txtGroupShikinTougetsuKashikata.Text;
                    txtFooter3_5.Text = txtGroupShikinZandakaKarikata.Text;
                    txtFooter3_6.Text = txtGroupShikinZandakaKashikata.Text;
                    txtFooter3_7.Text = txtGroupJigyouTougetsuKarikata.Text;
                    txtFooter3_8.Text = txtGroupJigyouTougetsuKashikata.Text;
                    txtFooter3_9.Text = txtGroupJigyouZandakaKarikata.Text;
                    txtFooter3_10.Text = txtGroupJigyouZandakaKashikata.Text;
                    break;
                case models.query.GoukeiZandakaShisanhyou.GroupIdShisyutsu:
                    txtGroupName.Text = "支出合計";
                    txtFooter4_1.Text = txtGroupZengetsuKarikata.Text;
                    txtFooter4_2.Text = txtGroupZengetsuKashikata.Text;
                    txtFooter4_3.Text = txtGroupShikinTougetsuKarikata.Text;
                    txtFooter4_4.Text = txtGroupShikinTougetsuKashikata.Text;
                    txtFooter4_5.Text = txtGroupShikinZandakaKarikata.Text;
                    txtFooter4_6.Text = txtGroupShikinZandakaKashikata.Text;
                    txtFooter4_7.Text = txtGroupJigyouTougetsuKarikata.Text;
                    txtFooter4_8.Text = txtGroupJigyouTougetsuKashikata.Text;
                    txtFooter4_9.Text = txtGroupJigyouZandakaKarikata.Text;
                    txtFooter4_10.Text = txtGroupJigyouZandakaKashikata.Text;
                    break;
            }
        }
    }
}
