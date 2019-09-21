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
    /// SyuushiYosanJissekiReport の概要の説明です。
    /// </summary>
    partial class SyuushiYosanJissekiReport2 : DataDynamics.ActiveReports.ActiveReport
    {
        private models.db.KaikeiDatabase db;

        private List<TextBox> yosanTextBoxList;
        private List<TextBox> jissekiTextBoxList;
        private List<TextBox> sagakuTextBoxList;

        private List<TextBox> syuunyuuYosanTextBoxList;
        private List<TextBox> syuunyuuJissekiTextBoxList;
        private List<TextBox> syuunyuuSagakuTextBoxList;

        private List<TextBox> shisyutsuYosanTextBoxList;
        private List<TextBox> shisyutsuJissekiTextBoxList;
        private List<TextBox> shisyutsuSagakuTextBoxList;

        public bool OmitZeroRow { get; set; }

        public SyuushiYosanJissekiReport2() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.501f);
            this.PageSettings.Margins.Bottom = CmToInch(1.501f);
            this.PageSettings.Margins.Left = CmToInch(0.801f);
            this.PageSettings.Margins.Right = CmToInch(0.801f);

            yosanTextBoxList = new List<TextBox>();
            jissekiTextBoxList = new List<TextBox>();
            sagakuTextBoxList = new List<TextBox>();
            syuunyuuYosanTextBoxList = new List<TextBox>();
            syuunyuuJissekiTextBoxList = new List<TextBox>();
            syuunyuuSagakuTextBoxList = new List<TextBox>();
            shisyutsuYosanTextBoxList = new List<TextBox>();
            shisyutsuJissekiTextBoxList = new List<TextBox>();
            shisyutsuSagakuTextBoxList = new List<TextBox>();

            yosanTextBoxList.Add(txtYosanSummary);
            yosanTextBoxList.Add(txtYosan0);
            yosanTextBoxList.Add(txtYosan1);
            yosanTextBoxList.Add(txtYosan2);
            yosanTextBoxList.Add(txtYosan3);
            yosanTextBoxList.Add(txtYosan4);
            yosanTextBoxList.Add(txtYosan5);
            yosanTextBoxList.Add(txtYosan6);

            jissekiTextBoxList.Add(txtJissekiSummary);
            jissekiTextBoxList.Add(txtJisseki0);
            jissekiTextBoxList.Add(txtJisseki1);
            jissekiTextBoxList.Add(txtJisseki2);
            jissekiTextBoxList.Add(txtJisseki3);
            jissekiTextBoxList.Add(txtJisseki4);
            jissekiTextBoxList.Add(txtJisseki5);
            jissekiTextBoxList.Add(txtJisseki6);

            sagakuTextBoxList.Add(txtSagakuSummary);
            sagakuTextBoxList.Add(txtSagaku0);
            sagakuTextBoxList.Add(txtSagaku1);
            sagakuTextBoxList.Add(txtSagaku2);
            sagakuTextBoxList.Add(txtSagaku3);
            sagakuTextBoxList.Add(txtSagaku4);
            sagakuTextBoxList.Add(txtSagaku5);
            sagakuTextBoxList.Add(txtSagaku6);

            syuunyuuYosanTextBoxList.Add(txtSyuunyuuYosanSummary);
            syuunyuuYosanTextBoxList.Add(txtSyuunyuuYosan0);
            syuunyuuYosanTextBoxList.Add(txtSyuunyuuYosan1);
            syuunyuuYosanTextBoxList.Add(txtSyuunyuuYosan2);
            syuunyuuYosanTextBoxList.Add(txtSyuunyuuYosan3);
            syuunyuuYosanTextBoxList.Add(txtSyuunyuuYosan4);
            syuunyuuYosanTextBoxList.Add(txtSyuunyuuYosan5);
            syuunyuuYosanTextBoxList.Add(txtSyuunyuuYosan6);

            syuunyuuJissekiTextBoxList.Add(txtSyuunyuuJissekiSummary);
            syuunyuuJissekiTextBoxList.Add(txtSyuunyuuJisseki0);
            syuunyuuJissekiTextBoxList.Add(txtSyuunyuuJisseki1);
            syuunyuuJissekiTextBoxList.Add(txtSyuunyuuJisseki2);
            syuunyuuJissekiTextBoxList.Add(txtSyuunyuuJisseki3);
            syuunyuuJissekiTextBoxList.Add(txtSyuunyuuJisseki4);
            syuunyuuJissekiTextBoxList.Add(txtSyuunyuuJisseki5);
            syuunyuuJissekiTextBoxList.Add(txtSyuunyuuJisseki6);

            syuunyuuSagakuTextBoxList.Add(txtSyuunyuuSagakuSummary);
            syuunyuuSagakuTextBoxList.Add(txtSyuunyuuSagaku0);
            syuunyuuSagakuTextBoxList.Add(txtSyuunyuuSagaku1);
            syuunyuuSagakuTextBoxList.Add(txtSyuunyuuSagaku2);
            syuunyuuSagakuTextBoxList.Add(txtSyuunyuuSagaku3);
            syuunyuuSagakuTextBoxList.Add(txtSyuunyuuSagaku4);
            syuunyuuSagakuTextBoxList.Add(txtSyuunyuuSagaku5);
            syuunyuuSagakuTextBoxList.Add(txtSyuunyuuSagaku6);

            shisyutsuYosanTextBoxList.Add(txtShisyutsuYosanSummary);
            shisyutsuYosanTextBoxList.Add(txtShisyutsuYosan0);
            shisyutsuYosanTextBoxList.Add(txtShisyutsuYosan1);
            shisyutsuYosanTextBoxList.Add(txtShisyutsuYosan2);
            shisyutsuYosanTextBoxList.Add(txtShisyutsuYosan3);
            shisyutsuYosanTextBoxList.Add(txtShisyutsuYosan4);
            shisyutsuYosanTextBoxList.Add(txtShisyutsuYosan5);
            shisyutsuYosanTextBoxList.Add(txtShisyutsuYosan6);

            shisyutsuJissekiTextBoxList.Add(txtShisyutsuJissekiSummary);
            shisyutsuJissekiTextBoxList.Add(txtShisyutsuJisseki0);
            shisyutsuJissekiTextBoxList.Add(txtShisyutsuJisseki1);
            shisyutsuJissekiTextBoxList.Add(txtShisyutsuJisseki2);
            shisyutsuJissekiTextBoxList.Add(txtShisyutsuJisseki3);
            shisyutsuJissekiTextBoxList.Add(txtShisyutsuJisseki4);
            shisyutsuJissekiTextBoxList.Add(txtShisyutsuJisseki5);
            shisyutsuJissekiTextBoxList.Add(txtShisyutsuJisseki6);

            shisyutsuSagakuTextBoxList.Add(txtShisyutsuSagakuSummary);
            shisyutsuSagakuTextBoxList.Add(txtShisyutsuSagaku0);
            shisyutsuSagakuTextBoxList.Add(txtShisyutsuSagaku1);
            shisyutsuSagakuTextBoxList.Add(txtShisyutsuSagaku2);
            shisyutsuSagakuTextBoxList.Add(txtShisyutsuSagaku3);
            shisyutsuSagakuTextBoxList.Add(txtShisyutsuSagaku4);
            shisyutsuSagakuTextBoxList.Add(txtShisyutsuSagaku5);
            shisyutsuSagakuTextBoxList.Add(txtShisyutsuSagaku6);

            for (int col = 0; col < syuunyuuYosanTextBoxList.Count; col++) {
                syuunyuuYosanTextBoxList[col].Tag = 0L;
                syuunyuuJissekiTextBoxList[col].Tag = 0L;
                syuunyuuSagakuTextBoxList[col].Tag = 0L;
                shisyutsuYosanTextBoxList[col].Tag = 0L;
                shisyutsuJissekiTextBoxList[col].Tag = 0L;
                shisyutsuSagakuTextBoxList[col].Tag = 0L;
            }
        }

        public void SetHeader(string houjinMei, DateTime kisanbi, DateTime kimatsubi) {
            txtHoujinmei.Text = houjinMei;

            txtKisanbi.Text = helper.Converter.DateTimeToWarekiStrKanji(kisanbi);
            txtKimatsubi.Text = helper.Converter.DateTimeToWarekiStrKanji(kimatsubi);
        }


        public void SetKaikeiKubunCaption(int i, string name) {
            switch (i) {
                case 0: txtKaikeiKubun0.Text = name; txtKaikeiKubunSum0.Text = name; break;
                case 1: txtKaikeiKubun1.Text = name; txtKaikeiKubunSum1.Text = name; break;
                case 2: txtKaikeiKubun2.Text = name; txtKaikeiKubunSum2.Text = name; break;
                case 3: txtKaikeiKubun3.Text = name; txtKaikeiKubunSum3.Text = name; break;
                case 4: txtKaikeiKubun4.Text = name; txtKaikeiKubunSum4.Text = name; break;
                case 5: txtKaikeiKubun5.Text = name; txtKaikeiKubunSum5.Text = name; break;
                case 6: txtKaikeiKubun6.Text = name; txtKaikeiKubunSum6.Text = name; break;
            }
        }


        public void SetDB(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }

        private void shikinSyuushiHeader_Format(object sender, EventArgs e) {
            models.db.Row row = db.MTKamokuKubun.GetRowFromCache(helper.Converter.ObjToInt(txtShikinSyuushiId.Text, -1));

            if (row != null) {
                txtShikinSyuushi.Text = row.GetStr("name", "");
            }
        }

        private void daikubunHeader_Format(object sender, EventArgs e) {
            long yosan = helper.Converter.AmountToLongObj(txtDaikubunSummaryYosan.Text).Value;
            long jisseki = helper.Converter.AmountToLongObj(txtDaikubunSummaryJisseki.Text).Value;

            if (OmitZeroRow && yosan == 0 && jisseki == 0) {
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

        private void detail_Format(object sender, EventArgs e) {
            long yosan = helper.Converter.AmountToLongObj(txtYosanSummary.Text).Value;
            long jisseki = helper.Converter.AmountToLongObj(txtJissekiSummary.Text).Value;

            if (OmitZeroRow && yosan == 0 && jisseki == 0) {
                this.LayoutAction = LayoutAction.NextRecord;
            }
            else {
                this.LayoutAction = LayoutAction.MoveLayout | LayoutAction.NextRecord | LayoutAction.PrintSection;
            }

            int kubunId = helper.Converter.ObjToInt(txtKubunIdInDetail.Text, -1);
            bool syuunyuu;

            if (kubunId == (int)models.constants.MTKamokuKubun.JigyouSyuunyuu ||
                    kubunId == (int)models.constants.MTKamokuKubun.ShisetsuSyuunyuu ||
                    kubunId == (int)models.constants.MTKamokuKubun.SonotaSyuunyuu) {
                syuunyuu = true;
            }
            else {
                syuunyuu = false;
            }

            for (int col = 0; col < yosanTextBoxList.Count; col++) {
                if (syuunyuu) {
                    syuunyuuYosanTextBoxList[col].Tag = (long)syuunyuuYosanTextBoxList[col].Tag
                        + helper.Converter.AmountToLongObj(yosanTextBoxList[col].Text).Value;
                    syuunyuuJissekiTextBoxList[col].Tag = (long)syuunyuuJissekiTextBoxList[col].Tag
                        + helper.Converter.AmountToLongObj(jissekiTextBoxList[col].Text).Value;
                    syuunyuuSagakuTextBoxList[col].Tag = (long)syuunyuuSagakuTextBoxList[col].Tag
                        + helper.Converter.AmountToLongObj(sagakuTextBoxList[col].Text).Value;
                }
                else {
                    shisyutsuYosanTextBoxList[col].Tag = (long)shisyutsuYosanTextBoxList[col].Tag
                        + helper.Converter.AmountToLongObj(yosanTextBoxList[col].Text).Value;
                    shisyutsuJissekiTextBoxList[col].Tag = (long)shisyutsuJissekiTextBoxList[col].Tag
                        + helper.Converter.AmountToLongObj(jissekiTextBoxList[col].Text).Value;
                    shisyutsuSagakuTextBoxList[col].Tag = (long)shisyutsuSagakuTextBoxList[col].Tag
                        + helper.Converter.AmountToLongObj(sagakuTextBoxList[col].Text).Value;
                }
            }
        }

        private void reportFooter1_Format(object sender, EventArgs e) {
            for (int col = 0; col < syuunyuuYosanTextBoxList.Count; col++) {
                syuunyuuYosanTextBoxList[col].Text = helper.Converter.LongToAmountWithoutYen((long)syuunyuuYosanTextBoxList[col].Tag);
                syuunyuuJissekiTextBoxList[col].Text = helper.Converter.LongToAmountWithoutYen((long)syuunyuuJissekiTextBoxList[col].Tag);
                syuunyuuSagakuTextBoxList[col].Text = helper.Converter.LongToAmountWithoutYen((long)syuunyuuSagakuTextBoxList[col].Tag);
                shisyutsuYosanTextBoxList[col].Text = helper.Converter.LongToAmountWithoutYen((long)shisyutsuYosanTextBoxList[col].Tag);
                shisyutsuJissekiTextBoxList[col].Text = helper.Converter.LongToAmountWithoutYen((long)shisyutsuJissekiTextBoxList[col].Tag);
                shisyutsuSagakuTextBoxList[col].Text = helper.Converter.LongToAmountWithoutYen((long)shisyutsuSagakuTextBoxList[col].Tag);
            }
        }
    }
}
