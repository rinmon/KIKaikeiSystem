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
    /// NewActiveReport1 の概要の説明です。
    /// </summary>
    partial class SyuushiYosanReport : DataDynamics.ActiveReports.ActiveReport
    {
        private class YosanRowBackup{
            public long Honnen { get; set; }
            public long Zennen { get; set; }
            public long Sagaku { get; set; }

            public YosanRowBackup(long honnen, long zennen, long sagaku) {
                Honnen = honnen;
                Zennen = zennen;
                Sagaku = sagaku;
            }
        }


        private bool IsHoseiYosansyo { get; set; }
        private Dictionary<int, YosanRowBackup> kamokuKubunId2YosanRowBackup;
        public bool OmitZeroRow { get; set; }

        private models.db.KaikeiDatabase db;

        public SyuushiYosanReport() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.501f);
            this.PageSettings.Margins.Bottom = CmToInch(1.501f);
            this.PageSettings.Margins.Left = CmToInch(1.000f);
            this.PageSettings.Margins.Right = CmToInch(1.000f);

            kamokuKubunId2YosanRowBackup = new Dictionary<int, YosanRowBackup>();
        }


        public void SetHeader(int nenndo, string houjinMei, string shisetsuMei, DateTime? printDate, bool isHoseiYosansyo, int hoseiKaisuu) {
            DateTime date = new DateTime(nenndo, 4, 1);

            txtTitle.Text = string.Format(
                txtTitle.Text,
                helper.Converter.DateTimeToWarekiGengou(date),
                helper.Converter.DateTimeToWarekiYear(date),
                isHoseiYosansyo ? string.Format("第{0}回 補正", hoseiKaisuu) : "収支"
            );

            if (isHoseiYosansyo) {
                lblCol1Name.Text = "予算現額";
                lblCol2Name.Text = "今回補正額";
                lblCol3Name.Text = "補正後予算額";
            }

            IsHoseiYosansyo = isHoseiYosansyo;

            txtHoujinMei.Text = houjinMei;
            txtShisetsuMei.Text = shisetsuMei;

            if (printDate != null) {
                txtPrintDate.Text = helper.Converter.DateTimeToWarekiStrKanji(printDate.Value);
            }
        }


        public void SetFooter(long honnenYobihi, long zennenYobihi, long honnenZandaka, long zennenZandaka) {
            txtHonnenYobihi.Text = helper.Converter.LongToAmountWithoutYen(honnenYobihi);
            txtZennenYobihi.Text = helper.Converter.LongToAmountWithoutYen(zennenYobihi);

            long yobihisagaku = IsHoseiYosansyo ? honnenYobihi + zennenYobihi : honnenYobihi - zennenYobihi;
            txtYobihiSagaku.Text = helper.Converter.LongToAmountWithoutYen(yobihisagaku);

            txtHonnenZandaka.Text = helper.Converter.LongToAmountWithoutYen(honnenZandaka);
            txtZennenZandaka.Text = helper.Converter.LongToAmountWithoutYen(zennenZandaka);

            long zandakasagaku = IsHoseiYosansyo ? honnenZandaka + zennenZandaka : honnenZandaka - zennenZandaka;
            txtZandakaSagaku.Text = helper.Converter.LongToAmountWithoutYen(zandakasagaku);
        }


        public void SetDB(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }


        public void AddShikinSyuushiHeader(string str) {
            //shikinSyuushiHeader.data
            txtShikinSyuushi.Text = str;
        }

        private void detail_Format(object sender, EventArgs e) {
            long honnen = helper.Converter.AmountToLongObj(予算額.Text).Value;
            long zennen = helper.Converter.AmountToLongObj(前年予算.Text).Value;

            if (OmitZeroRow && honnen == 0 && zennen == 0) {
                this.LayoutAction = LayoutAction.NextRecord;
            }
            else {
                this.LayoutAction = LayoutAction.MoveLayout | LayoutAction.NextRecord | LayoutAction.PrintSection;
            }
        }

        private void shikinSyuushiFooter_Format(object sender, EventArgs e) {
            int kubunId = helper.Converter.ObjToInt(txtShikinSyuushiId.Text, -1);

            kamokuKubunId2YosanRowBackup[kubunId] = new YosanRowBackup(
                helper.Converter.AmountToLongObj(txtHonnenSyoukei.Text).Value,
                helper.Converter.AmountToLongObj(txtZennenSyoukei.Text).Value,
                helper.Converter.AmountToLongObj(txtSyoukeiSagaku.Text).Value
            );

            switch ((models.constants.MTKamokuKubun)kubunId) {
                case models.constants.MTKamokuKubun.JigyouSyuunyuu:
                    txtSyoukeiCaption.Text = "事業収入計(1)";
                    txtSyuushiCaption.Text = "";
                    txtHonnenSyuushi.Text = "";
                    txtZennenSyuushi.Text = "";
                    txtSyuushiSagaku.Text = "";
                    break;
                case models.constants.MTKamokuKubun.JigyouShisyutsu:
                    txtSyoukeiCaption.Text = "事業支出計(2)";
                    txtSyuushiCaption.Text = "事業活動資金収支差額(3)=(1)-(2)";
                    txtHonnenSyuushi.Text = helper.Converter.LongToAmountWithoutYen(kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.JigyouSyuunyuu].Honnen - kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.JigyouShisyutsu].Honnen);
                    txtZennenSyuushi.Text = helper.Converter.LongToAmountWithoutYen(kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.JigyouSyuunyuu].Zennen - kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.JigyouShisyutsu].Zennen);
                    txtSyuushiSagaku.Text = helper.Converter.LongToAmountWithoutYen(kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.JigyouSyuunyuu].Sagaku - kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.JigyouShisyutsu].Sagaku);
                    break;
                case models.constants.MTKamokuKubun.ShisetsuSyuunyuu:
                    txtSyoukeiCaption.Text = "施設設備等収入計(4)";
                    txtSyuushiCaption.Text = "";
                    txtHonnenSyuushi.Text = "";
                    txtZennenSyuushi.Text = "";
                    txtSyuushiSagaku.Text = "";
                    break;
                case models.constants.MTKamokuKubun.ShisetsuShisyutsu:
                    txtSyoukeiCaption.Text = "施設設備等支出計(5)";
                    txtSyuushiCaption.Text = "施設設備等資金収支差額(6)=(4)-(5)";
                    txtHonnenSyuushi.Text = helper.Converter.LongToAmountWithoutYen(kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.ShisetsuSyuunyuu].Honnen - kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.ShisetsuShisyutsu].Honnen);
                    txtZennenSyuushi.Text = helper.Converter.LongToAmountWithoutYen(kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.ShisetsuSyuunyuu].Zennen - kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.ShisetsuShisyutsu].Zennen);
                    txtSyuushiSagaku.Text = helper.Converter.LongToAmountWithoutYen(kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.ShisetsuSyuunyuu].Sagaku - kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.ShisetsuShisyutsu].Sagaku);
                    break;
                case models.constants.MTKamokuKubun.SonotaSyuunyuu:
                    txtSyoukeiCaption.Text = "その他収入計(7)";
                    txtSyuushiCaption.Text = "";
                    txtHonnenSyuushi.Text = "";
                    txtZennenSyuushi.Text = "";
                    txtSyuushiSagaku.Text = "";
                    break;
                case models.constants.MTKamokuKubun.SonotaShisyutsu:
                    txtSyoukeiCaption.Text = "その他支出計(8)";
                    txtSyuushiCaption.Text = "その他活動資金収支差額(9)=(7)-(8)";
                    txtHonnenSyuushi.Text = helper.Converter.LongToAmountWithoutYen(kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.SonotaSyuunyuu].Honnen - kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.SonotaShisyutsu].Honnen);
                    txtZennenSyuushi.Text = helper.Converter.LongToAmountWithoutYen(kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.SonotaSyuunyuu].Zennen - kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.SonotaShisyutsu].Zennen);
                    txtSyuushiSagaku.Text = helper.Converter.LongToAmountWithoutYen(kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.SonotaSyuunyuu].Sagaku - kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.SonotaShisyutsu].Sagaku);
                    break;
            }
        }

        private void shikinSyuushiHeader_Format(object sender, EventArgs e) {
            models.db.Row row = db.MTKamokuKubun.GetRowFromCache(helper.Converter.ObjToInt(txtShikinSyuushiId.Text, -1));

            if (row != null) {
                txtShikinSyuushi.Text = row.GetStr("name", "");
            }
        }

        private void daikubunHeader_Format(object sender, EventArgs e) {
            long honnen = helper.Converter.AmountToLongObj(txtDaikubunHonnen.Text).Value;
            long zennen = helper.Converter.AmountToLongObj(txtDaikubunZennen.Text).Value;

            if (OmitZeroRow && honnen == 0 && zennen == 0) {
                this.LayoutAction = LayoutAction.NextRecord;
            }
            else {
                this.LayoutAction = LayoutAction.MoveLayout | LayoutAction.NextRecord | LayoutAction.PrintSection;
            }

            models.db.Row row = db.MTKamokuKubun.GetRowFromCache(helper.Converter.ObjToInt(txtDaikubunId.Text, -1));

            if (row != null) {
                txtDaikubun.Text = "【" + row.GetStr("name", "") + "】";
            }
        }

        private void reportFooter1_Format(object sender, EventArgs e) {
            long honnenSum = 0;
            long zennenSum = 0;
            long sagakuSum = 0;

            foreach (var pair in kamokuKubunId2YosanRowBackup) {
                if (pair.Key == (int)models.constants.MTKamokuKubun.JigyouSyuunyuu ||
                        pair.Key == (int)models.constants.MTKamokuKubun.ShisetsuSyuunyuu ||
                        pair.Key == (int)models.constants.MTKamokuKubun.SonotaSyuunyuu) {
                    honnenSum += pair.Value.Honnen;
                    zennenSum += pair.Value.Zennen;
                    sagakuSum += pair.Value.Sagaku;
                }
                else {
                    honnenSum -= pair.Value.Honnen;
                    zennenSum -= pair.Value.Zennen;
                    sagakuSum -= pair.Value.Sagaku;
                }
            }

            // 予備費を合計する
            honnenSum -= helper.Converter.AmountToLongObj(txtHonnenYobihi.Text).Value;
            zennenSum -= helper.Converter.AmountToLongObj(txtZennenYobihi.Text).Value;
            sagakuSum -= helper.Converter.AmountToLongObj(txtYobihiSagaku.Text).Value;

            txt11Honnen.Text = helper.Converter.LongToAmountWithoutYen(honnenSum);
            txt11Zennen.Text = helper.Converter.LongToAmountWithoutYen(zennenSum);
            txt11Sagaku.Text = helper.Converter.LongToAmountWithoutYen(sagakuSum);

            // 残高を合計する
            honnenSum += helper.Converter.AmountToLongObj(txtHonnenZandaka.Text).Value;
            zennenSum += helper.Converter.AmountToLongObj(txtZennenZandaka.Text).Value;
            sagakuSum += helper.Converter.AmountToLongObj(txtZandakaSagaku.Text).Value;

            txt13Honnen.Text = helper.Converter.LongToAmountWithoutYen(honnenSum);
            txt13Zennen.Text = helper.Converter.LongToAmountWithoutYen(zennenSum);
            txt13Sagaku.Text = helper.Converter.LongToAmountWithoutYen(sagakuSum);
        }
    }
}
