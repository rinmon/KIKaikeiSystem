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
    /// YosanJissekiReport の概要の説明です。
    /// </summary>
    partial class YosanJissekiReport : DataDynamics.ActiveReports.ActiveReport
    {
        private models.db.KaikeiDatabase db;

        public YosanJissekiReport() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.501f);
            this.PageSettings.Margins.Bottom = CmToInch(1.500f);
            this.PageSettings.Margins.Left = CmToInch(3.0f);
            this.PageSettings.Margins.Right = CmToInch(2.49f);
        }


        public void SetDB(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }


        public void SetHeader(string gengou, int year, int hoseiKaisuu, string houjinMeisyou, string kaikeiKubunName) {
            txtGengou.Text = gengou;
            txtYear.Text = year.ToString();
            txtHoseiKaisuu.Text = hoseiKaisuu.ToString();
            txtHoujinMeisyou.Text = houjinMeisyou;
            txtKaikeiKubun.Text = kaikeiKubunName;
        }


        public void SetReportFooter(long syuunyuuYosan, long syuunyuuJisseki,
                                    long shisyutsuYosan, long shisyutsuJisseki,
                                    long syuushiYosan, long syuushiJisseki) {
            txtSyuunyuuYosan.Value = syuunyuuYosan;
            txtSyuunyuuJisseki.Value = syuunyuuJisseki;
            txtSyuunyuuSagaku.Value = syuunyuuYosan - syuunyuuJisseki;
            txtSyuunyuuHiritsu.Value = syuunyuuYosan == 0 ? 0 : ((double)syuunyuuJisseki) / ((double)syuunyuuYosan) * 100;

            txtShisyutsuYosan.Value = shisyutsuYosan;
            txtShisyutsuJisseki.Value = shisyutsuJisseki;
            txtShisyutsuSagaku.Value = shisyutsuYosan - shisyutsuJisseki;
            txtShisyutsuHiritsu.Value = shisyutsuYosan == 0 ? 0 : ((double)shisyutsuJisseki) / ((double)shisyutsuYosan) * 100;

            txtSyuushiYosan.Value = syuushiYosan;
            txtSyuushiJisseki.Value = syuushiJisseki;
            txtSyuushiSagaku.Value = syuushiYosan - syuushiJisseki;
            txtSyuushiHiritsu.Value = syuushiYosan == 0 ? 0 : ((double)syuushiJisseki) / ((double)syuushiYosan) * 100;
        }

        private void SetGroupHeader(DataDynamics.ActiveReports.TextBox txtId,
                                    DataDynamics.ActiveReports.TextBox txtName,
                                    DataDynamics.ActiveReports.TextBox txtYosan,
                                    DataDynamics.ActiveReports.TextBox txtJisseki,
                                    DataDynamics.ActiveReports.TextBox txtSagaku,
                                    DataDynamics.ActiveReports.TextBox txtHiritsu,
                                    string namePrefix,
                                    string nameSuffix) {
            int kamokuKubunId = helper.Converter.ObjToInt(txtId.Text, -1);
            long yosan = helper.Converter.AmountToLongObj(txtYosan.Text).Value;
            long jisseki = helper.Converter.AmountToLongObj(txtJisseki.Text).Value;

            if (yosan == 0) {
                txtHiritsu.Text = "0.0";
            }
            else {
                txtHiritsu.Text = string.Format("{0:0.0}", ((double)jisseki) / ((double)yosan) * 100);
            }

            models.db.Row kamokuKubunRow = db.MTKamokuKubun.GetRowById(kamokuKubunId);
            txtName.Text = namePrefix + kamokuKubunRow.GetStr("name") + nameSuffix;
        }

        
        private void groupHeaderKubun_Format(object sender, EventArgs e) {
            SetGroupHeader(txtKubunId, txtKubunName, txtKubunYosan, txtKubunJisseki, txtKubunSagaku, txtKubunHiritsu, "", "");
        }

        private void groupHeaderDaikubun_Format(object sender, EventArgs e) {
            SetGroupHeader(txtDaikubunId, txtDaikubunName, txtDaikubunYosan, txtDaikubunJisseki, txtDaikubunSagaku, txtDaikubunHiritsu, "【", "】");
        }
    }
}
