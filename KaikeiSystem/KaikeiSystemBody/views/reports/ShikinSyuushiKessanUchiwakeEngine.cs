using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;


namespace KaikeiSystemBody.views.reports
{
    class ShikinSyuushiKessanUchiwakeEngine
    {
        private int NumCols;

        private models.db.KaikeiDatabase db;
        private DataDynamics.ActiveReports.TextBox[] txtColCaptions;
        private DataDynamics.ActiveReports.TextBox[] txtDetailCols;
        private DataDynamics.ActiveReports.TextBox[] txtSyuunyuuCols;
        private DataDynamics.ActiveReports.TextBox[] txtShisyutsuCols;
        //private DataDynamics.ActiveReports.TextBox[] txtYobihiCols;
        private DataDynamics.ActiveReports.TextBox[] txtToukiCols;
        private DataDynamics.ActiveReports.TextBox[] txtZenkiCols;
        private DataDynamics.ActiveReports.TextBox[] txtToukiZandakaCols;
        private DataDynamics.ActiveReports.TextBox txtKisanbi;
        private DataDynamics.ActiveReports.TextBox txtKimatsubi;
        private DataDynamics.ActiveReports.TextBox txtHoujinMei;
        private DataDynamics.ActiveReports.TextBox txtKubunName;
        private DataDynamics.ActiveReports.TextBox txtDaikubunName;
        private DataDynamics.ActiveReports.TextBox txtKamokuCode;
        private DataDynamics.ActiveReports.TextBox txtKamoku;
        private DataDynamics.ActiveReports.TextBox txtKamokuId;
        private DataDynamics.ActiveReports.TextBox txtDaikubunId;
        private DataDynamics.ActiveReports.TextBox txtKubunId;
        private DataDynamics.ActiveReports.Label txtShisyutsuKeiCaption;
        private DataDynamics.ActiveReports.Label txtSyuunyuuKeiCaption;
        private DataDynamics.ActiveReports.Label labelTitle;
        private DataDynamics.ActiveReports.Label labelYoushiki;

        private long[] beforeSyuunyuuCols;


        public ShikinSyuushiKessanUchiwakeEngine(int numCols){
            NumCols = numCols;
        }


        public void InitComponents(ControlCollection pageHeaderControls,
                                        ControlCollection detailControls,
                                        ControlCollection kubunFooterControls,
                                        ControlCollection reportFooterControls,
                                        DataDynamics.ActiveReports.TextBox txtKisanbi_,
                                        DataDynamics.ActiveReports.TextBox txtKimatsubi_,
                                        DataDynamics.ActiveReports.TextBox txtHoujinMei_,
                                        DataDynamics.ActiveReports.TextBox txtKubunName_,
                                        DataDynamics.ActiveReports.TextBox txtDaikubunName_,
                                        DataDynamics.ActiveReports.TextBox txtKamokuCode_,
                                        DataDynamics.ActiveReports.TextBox txtKamoku_,
                                        DataDynamics.ActiveReports.TextBox txtKamokuId_,
                                        DataDynamics.ActiveReports.TextBox txtDaikubunId_,
                                        DataDynamics.ActiveReports.TextBox txtKubunId_,
                                        DataDynamics.ActiveReports.Label txtShisyutsuKeiCaption_,
                                        DataDynamics.ActiveReports.Label txtSyuunyuuKeiCaption_,
                                        DataDynamics.ActiveReports.Label labelTitle_,
                                        DataDynamics.ActiveReports.Label labelYoushiki_)
        {
            // コンポーネント配列の作成
            txtColCaptions = helper.View.CreateTextboxArray(pageHeaderControls, "txtColCaption", NumCols);
            txtDetailCols = helper.View.CreateTextboxArray(detailControls, "txtCol", NumCols);
            txtSyuunyuuCols = helper.View.CreateTextboxArray(kubunFooterControls, "txtSyuunyuuKeiCol", NumCols);
            txtShisyutsuCols = helper.View.CreateTextboxArray(kubunFooterControls, "txtShisyutsuKeiCol", NumCols);
            //txtYobihiCols = helper.View.CreateTextboxArray(reportFooterControls, "txtYobihiCol", NumCols);
            txtToukiCols = helper.View.CreateTextboxArray(reportFooterControls, "txtToukiCol", NumCols);
            txtZenkiCols = helper.View.CreateTextboxArray(reportFooterControls, "txtZenkiCol", NumCols);
            txtToukiZandakaCols = helper.View.CreateTextboxArray(reportFooterControls, "txtToukiZandakaCol", NumCols);

            txtKisanbi = txtKisanbi_;
            txtKimatsubi = txtKimatsubi_;
            txtHoujinMei = txtHoujinMei_;
            txtKubunName = txtKubunName_;
            txtDaikubunName = txtDaikubunName_;
            txtKamokuCode = txtKamokuCode_;
            txtKamoku = txtKamoku_;
            txtKamokuId = txtKamokuId_;
            txtDaikubunId = txtDaikubunId_;
            txtKubunId = txtKubunId_;
            txtShisyutsuKeiCaption = txtShisyutsuKeiCaption_;
            txtSyuunyuuKeiCaption = txtSyuunyuuKeiCaption_;
            labelTitle = labelTitle_;
            labelYoushiki = labelYoushiki_;

            beforeSyuunyuuCols = new long[NumCols];
        }



        public void SetDB(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }

        public void SetHeader(DateTime startDate, DateTime endDate, string houjinMeisyou, List<string> ColCaptions, string title, string youshiki)
        {
            txtKisanbi.Text = helper.Converter.DateTimeToWarekiStrKanji(startDate);
            txtKimatsubi.Text = helper.Converter.DateTimeToWarekiStrKanji(endDate);
            txtHoujinMei.Text = houjinMeisyou;
            labelYoushiki.Text = youshiki;
            labelTitle.Text = title;
            for (int i = 3; i < ColCaptions.Count; i++) {
                txtColCaptions[i].Text = ColCaptions[i];
            }
        }

        public void SetFooter(models.query.ShikinSyuushiUchiwake.ShikinSyuushiUchiwakeRow toukiRow,
                            models.query.ShikinSyuushiUchiwake.ShikinSyuushiUchiwakeRow zenkiRow,
                            models.query.ShikinSyuushiUchiwake.ShikinSyuushiUchiwakeRow toukiZandakaRow) {
            for (int i = 0; i < NumCols; i++) {
                //txtYobihiCols[i].Value = yobihiRow.Col(i);
                txtToukiCols[i].Value = toukiRow.Col(i);
                txtZenkiCols[i].Value = zenkiRow.Col(i);
                txtToukiZandakaCols[i].Value = toukiZandakaRow.Col(i);
            }
        }


        public void groupHeaderKubun_Format(object sender, EventArgs e) {
            models.db.Row row = db.MTKamokuKubun.GetRowById(helper.Converter.ObjToInt(txtKubunId.Text, -1));
            if (row != null) {
                txtKubunName.Text = row.GetStr("name");
            }
            else {
                txtKubunName.Text = "";
            }
        }

        public void groupHeaderDaikubun_Format(object sender, EventArgs e) {
            KaikeiSystemBody.models.db.Row r = db.MTKamokuKubun.GetRowById(helper.Converter.ObjToInt(txtDaikubunId.Text, -1));
            if (r == null) {
                txtDaikubunName.Text = "【】";
                return;
            }
            txtDaikubunName.Text = "【" + r.GetStr("name") + "】";
        }

        public void detail_Format(object sender, EventArgs e) {
            int kamokuKubunId = helper.Converter.ObjToInt(txtKamokuId.Text, -1);
            models.db.Row kamokuKubunRow = db.MTKamokuKubun.GetRowById(kamokuKubunId);
            if (kamokuKubunRow == null) {
                return;
            }
            int kanjouKamokuId = (int)kamokuKubunRow.GetLong("kanjou_kamoku_id", -1);
            models.db.Row kanjouKamokuRow = db.MTKanjouKamoku.GetRowById(kanjouKamokuId);

            txtKamokuCode.Text = kanjouKamokuRow.GetStr("kamoku_code");
            txtKamoku.Text = kanjouKamokuRow.GetStr("kamoku");
        }

        public void groupFooterKubun_Format(object sender, EventArgs e) {
            int kubunId = helper.Converter.ObjToInt(txtKubunId.Text, -1);

            if ((models.constants.MTKamokuKubun)kubunId == models.constants.MTKamokuKubun.JigyouShisyutsu ||
                (models.constants.MTKamokuKubun)kubunId == models.constants.MTKamokuKubun.ShisetsuShisyutsu ||
                (models.constants.MTKamokuKubun)kubunId == models.constants.MTKamokuKubun.SonotaShisyutsu) {
                for (int i = 0; i < NumCols; i++) {
                    txtShisyutsuCols[i].Value = beforeSyuunyuuCols[i] - (long)(double)txtSyuunyuuCols[i].Value;
                }
            }
            else {
                txtShisyutsuKeiCaption.Text = "";
                for (int i = 0; i < NumCols; i++) {
                    txtShisyutsuCols[i].Text = "";
                }
            }

            switch ((models.constants.MTKamokuKubun)kubunId) {
                case models.constants.MTKamokuKubun.JigyouSyuunyuu:
                    txtSyuunyuuKeiCaption.Text = helper.Helper.GetShikinSyuushiKeisansyoSummaryCaption(models.query.ShikinSyuushi.SummaryItem.JigyouSyuunyuu);
                    break;
                case models.constants.MTKamokuKubun.JigyouShisyutsu:
                    txtSyuunyuuKeiCaption.Text = helper.Helper.GetShikinSyuushiKeisansyoSummaryCaption(models.query.ShikinSyuushi.SummaryItem.JigyouShisyutsu);
                    txtShisyutsuKeiCaption.Text = helper.Helper.GetShikinSyuushiKeisansyoSummaryCaption(models.query.ShikinSyuushi.SummaryItem.JigyouSyuushi);
                    break;
                case models.constants.MTKamokuKubun.ShisetsuSyuunyuu:
                    txtSyuunyuuKeiCaption.Text = helper.Helper.GetShikinSyuushiKeisansyoSummaryCaption(models.query.ShikinSyuushi.SummaryItem.ShisetsuSyuunyuu);
                    break;
                case models.constants.MTKamokuKubun.ShisetsuShisyutsu:
                    txtSyuunyuuKeiCaption.Text = helper.Helper.GetShikinSyuushiKeisansyoSummaryCaption(models.query.ShikinSyuushi.SummaryItem.ShisetsuShisyutsu);
                    txtShisyutsuKeiCaption.Text = helper.Helper.GetShikinSyuushiKeisansyoSummaryCaption(models.query.ShikinSyuushi.SummaryItem.ShisetsuSyuushi);
                    break;
                case models.constants.MTKamokuKubun.SonotaSyuunyuu:
                    txtSyuunyuuKeiCaption.Text = helper.Helper.GetShikinSyuushiKeisansyoSummaryCaption(models.query.ShikinSyuushi.SummaryItem.SonotaSyuunyuu);
                    break;
                case models.constants.MTKamokuKubun.SonotaShisyutsu:
                    txtSyuunyuuKeiCaption.Text = helper.Helper.GetShikinSyuushiKeisansyoSummaryCaption(models.query.ShikinSyuushi.SummaryItem.SonotaShisyutsu);
                    txtShisyutsuKeiCaption.Text = helper.Helper.GetShikinSyuushiKeisansyoSummaryCaption(models.query.ShikinSyuushi.SummaryItem.SonotaSyuushi);
                    break;
            }

            for (int i = 0; i < NumCols; i++) {
                beforeSyuunyuuCols[i] = (long)(double)txtSyuunyuuCols[i].Value;// helper.Converter.ObjToLong(txtSyuunyuuCols[i].Text, 0);
            }
        }
    }
}
