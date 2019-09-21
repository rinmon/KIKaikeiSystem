using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;


namespace KaikeiSystemBody.views.reports
{
    class JigyouSyuushiUchiwakeEngine
    {
        private int NumCols;

        private models.db.KaikeiDatabase db;

        private DataDynamics.ActiveReports.TextBox[] txtColCaptions;
        private DataDynamics.ActiveReports.TextBox[] txtToukiCols;
        private DataDynamics.ActiveReports.TextBox[] txtZenkiCols;
        private DataDynamics.ActiveReports.TextBox[] txtToukimatsuCols;
        private DataDynamics.ActiveReports.TextBox[] txtKihonkinCols;
        private DataDynamics.ActiveReports.TextBox[] txtTorikuzushiCols;
        private DataDynamics.ActiveReports.TextBox[] txtTsumitateCols;
        private DataDynamics.ActiveReports.TextBox[] txtJikiCols;
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
        private DataDynamics.ActiveReports.Label txtSyuunyuuKeiCaption;
        private DataDynamics.ActiveReports.Label labelTitle;
        private DataDynamics.ActiveReports.Label labelYoushiki;


        public JigyouSyuushiUchiwakeEngine(int numCols) {
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
                                        DataDynamics.ActiveReports.Label txtSyuunyuuKeiCaption_,
                                        DataDynamics.ActiveReports.Label labelTitle_,
                                        DataDynamics.ActiveReports.Label labelYoushiki_)
        {
            // コンポーネント配列の作成
            txtColCaptions = helper.View.CreateTextboxArray(pageHeaderControls, "txtColCaption", NumCols);
            txtToukiCols = helper.View.CreateTextboxArray(reportFooterControls, "txtTouki", NumCols);
            txtZenkiCols = helper.View.CreateTextboxArray(reportFooterControls, "txtZenki", NumCols);
            txtToukimatsuCols = helper.View.CreateTextboxArray(reportFooterControls, "txtToukimatsu", NumCols);
            txtKihonkinCols = helper.View.CreateTextboxArray(reportFooterControls, "txtKihonkin", NumCols);
            txtTorikuzushiCols = helper.View.CreateTextboxArray(reportFooterControls, "txtTorikuzushi", NumCols);
            txtTsumitateCols = helper.View.CreateTextboxArray(reportFooterControls, "txtTsumitate", NumCols);
            txtJikiCols = helper.View.CreateTextboxArray(reportFooterControls, "txtJiki", NumCols);

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
            txtSyuunyuuKeiCaption = txtSyuunyuuKeiCaption_;
            labelTitle = labelTitle_;
            labelYoushiki = labelYoushiki_;
        }



        public void SetDB(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }

        public void SetHeader(DateTime startDate, DateTime endDate, string houjinMeisyou, List<string> ColCaptions, string title, string youshiki) {
            txtKisanbi.Text = helper.Converter.DateTimeToWarekiStrKanji(startDate);
            txtKimatsubi.Text = helper.Converter.DateTimeToWarekiStrKanji(endDate);
            txtHoujinMei.Text = houjinMeisyou;
            labelTitle.Text = title;
            labelYoushiki.Text = youshiki;

            for (int i = 3; i < ColCaptions.Count; i++) {
                txtColCaptions[i].Text = ColCaptions[i];
            }
        }

        public void SetFooter(models.query.JigyouKatsudouUchiwake.JigyouKatsudouUchiwakeRow toukiRow,
                            models.query.JigyouKatsudouUchiwake.JigyouKatsudouUchiwakeRow zenkiRow,
                            models.query.JigyouKatsudouUchiwake.JigyouKatsudouUchiwakeRow toukimatsuRow,
                            models.query.JigyouKatsudouUchiwake.JigyouKatsudouUchiwakeRow kihonkinRow,
                            models.query.JigyouKatsudouUchiwake.JigyouKatsudouUchiwakeRow torikuzushiRow,
                            models.query.JigyouKatsudouUchiwake.JigyouKatsudouUchiwakeRow tsumitateRow,
                            models.query.JigyouKatsudouUchiwake.JigyouKatsudouUchiwakeRow jikiRow
            ) {
            for (int i = 0; i < NumCols; i++) {
                txtToukiCols[i].Value = toukiRow.Col(i);
                txtZenkiCols[i].Value = zenkiRow.Col(i);
                txtToukimatsuCols[i].Value = toukimatsuRow.Col(i);
                txtKihonkinCols[i].Value = kihonkinRow.Col(i);
                txtTorikuzushiCols[i].Value = torikuzushiRow.Col(i);
                txtTsumitateCols[i].Value = tsumitateRow.Col(i);
                txtJikiCols[i].Value = jikiRow.Col(i);
            }
        }


        public void groupHeaderKubun_Format(object sender, EventArgs e) {
            if (db.MTKamokuKubun.GetRowById(helper.Converter.ObjToInt(txtKubunId.Text, -1)) == null) {
                return;
            }
            txtKubunName.Text = db.MTKamokuKubun.GetRowById(helper.Converter.ObjToInt(txtKubunId.Text, -1)).GetStr("name");
        }

        public void groupHeaderDaikubun_Format(object sender, EventArgs e) {
            if (db.MTKamokuKubun.GetRowById(helper.Converter.ObjToInt(txtKubunId.Text, -1)) == null)
            {
                return;
            }
            txtDaikubunName.Text = "【" + db.MTKamokuKubun.GetRowById(helper.Converter.ObjToInt(txtDaikubunId.Text, -1)).GetStr("name") + "】";
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

            switch ((models.constants.MTKamokuKubun)kubunId) {
                case models.constants.MTKamokuKubun.ServiceKatsudouZougenSyuueki:
                    txtSyuunyuuKeiCaption.Text = helper.Helper.GetJigyouKatsudouSummaryCaption(models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouSyuunyuu);
                    break;
                case models.constants.MTKamokuKubun.ServiceKatsudouZougenHiyou:
                    txtSyuunyuuKeiCaption.Text = helper.Helper.GetJigyouKatsudouSummaryCaption(models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouShisyutsu);
                    break;
                case models.constants.MTKamokuKubun.ServiceKatsudouGaiZougenSyuueki:
                    txtSyuunyuuKeiCaption.Text = helper.Helper.GetJigyouKatsudouSummaryCaption(models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouGaiSyuunyuu);
                    break;
                case models.constants.MTKamokuKubun.ServiceKatsudouGaiZougenHiyou:
                    txtSyuunyuuKeiCaption.Text = helper.Helper.GetJigyouKatsudouSummaryCaption(models.query.JigyouKatsudou.SummaryItem.ServiceKatsudouGaiShisyutsu);
                    break;
                case models.constants.MTKamokuKubun.TokubetsuZougenSyuueki:
                    txtSyuunyuuKeiCaption.Text = helper.Helper.GetJigyouKatsudouSummaryCaption(models.query.JigyouKatsudou.SummaryItem.TokubetsuSyuunyuu);
                    break;
                case models.constants.MTKamokuKubun.TokubetsuZougenHiyou:
                    txtSyuunyuuKeiCaption.Text = helper.Helper.GetJigyouKatsudouSummaryCaption(models.query.JigyouKatsudou.SummaryItem.TokubetsuShisyutsu);
                    break;
            }
        }
    }
}
