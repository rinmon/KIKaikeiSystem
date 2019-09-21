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
    /// JigyouKatsudouSyuushiKeisansyo の概要の説明です。
    /// </summary>
    partial class JigyouKatsudouSyuushiKeisansyo : DataDynamics.ActiveReports.ActiveReport
    {
        private models.db.KaikeiDatabase db;

        public JigyouKatsudouSyuushiKeisansyo() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.500f);
            this.PageSettings.Margins.Bottom = CmToInch(0.50f);
            this.PageSettings.Margins.Left = CmToInch(1.500f);
            this.PageSettings.Margins.Right = CmToInch(0.50f);

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

        public void SetFooter(models.query.JigyouKatsudou.JigyouSyuushiRow toukiRow,
                                models.query.JigyouKatsudou.JigyouSyuushiRow zenkiRow,
                                models.query.JigyouKatsudou.JigyouSyuushiRow toukimatsuRow,
                                models.query.JigyouKatsudou.JigyouSyuushiRow kihonkinRow,
                                models.query.JigyouKatsudou.JigyouSyuushiRow tsumitateTorikuzushiRow,
                                models.query.JigyouKatsudou.JigyouSyuushiRow tsumitateRow,
                                models.query.JigyouKatsudou.JigyouSyuushiRow jikiRow
            ){
            // 当期活動増減差額
            txtToukiCol0.Value = toukiRow.CurrentYearSum;
            txtToukiCol1.Value = toukiRow.LastYearSum;
            txtToukiCol2.Value = toukiRow.Sai;

            // 前期繰越活動増減差額
            txtZenkiCol0.Value = zenkiRow.CurrentYearSum;
            txtZenkiCol1.Value = zenkiRow.LastYearSum;
            txtZenkiCol2.Value = zenkiRow.Sai;

            // 当期末繰越活動増減差額
            txtToukimatsuCol0.Value = toukimatsuRow.CurrentYearSum;
            txtToukimatsuCol1.Value = toukimatsuRow.LastYearSum;
            txtToukimatsuCol2.Value = toukimatsuRow.Sai;

            // その他の積立金取り崩し額
            txtTsumitateTorikuzushiCol0.Value = tsumitateTorikuzushiRow.CurrentYearSum;
            txtTsumitateTorikuzushiCol1.Value = tsumitateTorikuzushiRow.LastYearSum;
            txtTsumitateTorikuzushiCol2.Value = tsumitateTorikuzushiRow.Sai;

            // その他の積立金積立額
            txtTsumitateCol0.Value = tsumitateRow.CurrentYearSum;
            txtTsumitateCol1.Value = tsumitateRow.LastYearSum;
            txtTsumitateCol2.Value = tsumitateRow.Sai;

            // 次期繰越活動増減差額
            txtJikiCol0.Value = jikiRow.CurrentYearSum;
            txtJikiCol1.Value = jikiRow.LastYearSum;
            txtJikiCol2.Value = jikiRow.Sai;
        }

        private void groupHeaderKubun_Format(object sender, EventArgs e) {
            txtKubunName.Text = db.MTKamokuKubun.GetRowById(helper.Converter.ObjToInt(txtKubunId.Text, -1)).GetStr("name");
        }

        private void detail_Format(object sender, EventArgs e) {
            if (txtDaikubunId.Text == "-1") {
                txtDaikubunName.Text = "";
                txtCurrentYearSum.Text = "";
                txtLastYearSum.Text = "";
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
                    txtDaikubunName.Text = new string(' ', count: tab) + name;
                }
            }
            else {
                txtDaikubunName.Alignment = TextAlignment.Center;
                txtDaikubunName.Text = helper.Helper.GetJigyouKatsudouSummaryCaption((models.query.JigyouKatsudou.SummaryItem)id);
            }
        }
    }
}
