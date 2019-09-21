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
    /// ShikinSyuushiKeisansyo の概要の説明です。
    /// </summary>
    partial class ShikinSyuushiKeisansyo : DataDynamics.ActiveReports.ActiveReport
    {
        private models.db.KaikeiDatabase db;

        public ShikinSyuushiKeisansyo() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.501f);
            this.PageSettings.Margins.Bottom = CmToInch(1.00f);
            this.PageSettings.Margins.Left = CmToInch(1.501f);
            this.PageSettings.Margins.Right = CmToInch(1.00f);
        }


        public void SetDB(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }

        
        public void SetHeader(DateTime startDate, DateTime endDate, string houjinMeisyou, string kaikeiKubunName, string title, string youshiki) {
            txtKisanbi.Text = helper.Converter.DateTimeToWarekiStrKanji(startDate);
            txtKimatsubi.Text = helper.Converter.DateTimeToWarekiStrKanji(endDate);
            txtHoujinMei.Text = houjinMeisyou;
            txtKaikeiKubun.Text = kaikeiKubunName;
            labelTitle.Text = title;
            labelYoushiki.Text = youshiki;
        }

        public void SetFooter(models.query.ShikinSyuushi.ShikinSyuushiRow yobihiRow,
                                models.query.ShikinSyuushi.ShikinSyuushiRow toukiRow,
                                models.query.ShikinSyuushi.ShikinSyuushiRow zenkiRow,
                                models.query.ShikinSyuushi.ShikinSyuushiRow toukiZandakaRow) {
            // 予備費
            txtYobihiYosan.Value = yobihiRow.Yosan;
            txtYobihiTaisyaku.Value = yobihiRow.Taisyaku;
            txtYobihiSai.Value = yobihiRow.Sai;

            // 当期資金収支
            txtToukiYosan.Value = toukiRow.Yosan;
            txtToukiTaisyaku.Value = toukiRow.Taisyaku;
            txtToukiSai.Value = toukiRow.Sai;

            // 前期
            txtZenkiYosan.Value = zenkiRow.Yosan;
            txtZenkiTaisyaku.Value = zenkiRow.Taisyaku;
            txtZenkiSai.Value = zenkiRow.Sai;

            // 当期残高
            txtToukiZandakaYosan.Value = toukiZandakaRow.Yosan;
            txtToukiZandakaTaisyaku.Value = toukiZandakaRow.Taisyaku;
            txtToukiZandakaSai.Value = toukiZandakaRow.Sai;
        }

        private void groupHeaderKubun_Format(object sender, EventArgs e) {
            txtKubunName.Text = db.MTKamokuKubun.GetRowById(helper.Converter.ObjToInt(txtKubunId.Text, -1)).GetStr("name");
        }

        private void detail_Format(object sender, EventArgs e) {
            if (txtDaikubunId.Text == "-1") {
                txtDaikubunName.Text = "";
                txtYosan.Text = "";
                txtTaisyaku.Text = "";
                txtSai.Text = "";
                return;
            }

            int id = helper.Converter.ObjToInt(txtDaikubunId.Text, -1);
            if ((bool)txtIsSummaryRow.Value == false) {
                txtDaikubunName.Alignment = TextAlignment.Left;
                string name = db.MTKamokuKubun.GetRowById(id).GetStr("name");
                if ((int)(long)txtKamokuKubunHierarchy.Value == (int)models.constants.MTKamokuKubunHierarchy.Daikubun) {
                    txtDaikubunName.Text = "【" + name + "】";
                }
                else {
                    int tab = ((int)(long)txtKamokuKubunHierarchy.Value - (int)models.constants.MTKamokuKubunHierarchy.Daikubun) * 3;
                    txtDaikubunName.Text = new string(' ', count:tab) + name;
                }
            }
            else {
                txtDaikubunName.Alignment = TextAlignment.Center;
                txtDaikubunName.Text = helper.Helper.GetShikinSyuushiKeisansyoSummaryCaption((models.query.ShikinSyuushi.SummaryItem)id);
            }
        }
    }
}
