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
    /// SyuushiYosanUchiwakeReport の概要の説明です。
    /// </summary>
    partial class SyuushiYosanUchiwakeReport : DataDynamics.ActiveReports.ActiveReport
    {

        private models.db.KaikeiDatabase db;

        private List<DataDynamics.ActiveReports.TextBox> syoukeiTextBoxList;
        private List<DataDynamics.ActiveReports.TextBox> syuushiTextBoxList;
        private List<DataDynamics.ActiveReports.TextBox> yobihiTextBoxList;
        private List<DataDynamics.ActiveReports.TextBox> zandakaTextBoxList;
        private List<DataDynamics.ActiveReports.TextBox> textBox11List;
        private List<DataDynamics.ActiveReports.TextBox> textBox13List;
        private Dictionary<int, List<long>> kamokuKubunId2YosanRowBackup;


        public SyuushiYosanUchiwakeReport() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();

            // ページ設定
            this.PageSettings.Margins.Top = CmToInch(1.501f);
            this.PageSettings.Margins.Bottom = CmToInch(1.000f);
            this.PageSettings.Margins.Left = CmToInch(1.000f);
            this.PageSettings.Margins.Right = CmToInch(0.501f);

            kamokuKubunId2YosanRowBackup = new Dictionary<int, List<long>>();

            syoukeiTextBoxList = new List<TextBox>();
            syuushiTextBoxList = new List<TextBox>();
            yobihiTextBoxList = new List<TextBox>();
            zandakaTextBoxList = new List<TextBox>();
            textBox11List = new List<TextBox>();
            textBox13List = new List<TextBox>();

            syoukeiTextBoxList.Add(txtSyoukeiSummary);
            syoukeiTextBoxList.Add(txtSyoukei0);
            syoukeiTextBoxList.Add(txtSyoukei1);
            syoukeiTextBoxList.Add(txtSyoukei2);
            syoukeiTextBoxList.Add(txtSyoukei3);
            syoukeiTextBoxList.Add(txtSyoukei4);
            syoukeiTextBoxList.Add(txtSyoukei5);
            syoukeiTextBoxList.Add(txtSyoukei6);

            syuushiTextBoxList.Add(txtSyuushiSummary);
            syuushiTextBoxList.Add(txtSyuushi0);
            syuushiTextBoxList.Add(txtSyuushi1);
            syuushiTextBoxList.Add(txtSyuushi2);
            syuushiTextBoxList.Add(txtSyuushi3);
            syuushiTextBoxList.Add(txtSyuushi4);
            syuushiTextBoxList.Add(txtSyuushi5);
            syuushiTextBoxList.Add(txtSyuushi6);

            yobihiTextBoxList.Add(txtYobihiSummary);
            yobihiTextBoxList.Add(txtYobihi0);
            yobihiTextBoxList.Add(txtYobihi1);
            yobihiTextBoxList.Add(txtYobihi2);
            yobihiTextBoxList.Add(txtYobihi3);
            yobihiTextBoxList.Add(txtYobihi4);
            yobihiTextBoxList.Add(txtYobihi5);
            yobihiTextBoxList.Add(txtYobihi6);

            zandakaTextBoxList.Add(txtZandakaSummary);
            zandakaTextBoxList.Add(txtZandaka0);
            zandakaTextBoxList.Add(txtZandaka1);
            zandakaTextBoxList.Add(txtZandaka2);
            zandakaTextBoxList.Add(txtZandaka3);
            zandakaTextBoxList.Add(txtZandaka4);
            zandakaTextBoxList.Add(txtZandaka5);
            zandakaTextBoxList.Add(txtZandaka6);

            textBox11List.Add(txt11_Summary);
            textBox11List.Add(txt11_0);
            textBox11List.Add(txt11_1);
            textBox11List.Add(txt11_2);
            textBox11List.Add(txt11_3);
            textBox11List.Add(txt11_4);
            textBox11List.Add(txt11_5);
            textBox11List.Add(txt11_6);

            textBox13List.Add(txt13_Summary);
            textBox13List.Add(txt13_0);
            textBox13List.Add(txt13_1);
            textBox13List.Add(txt13_2);
            textBox13List.Add(txt13_3);
            textBox13List.Add(txt13_4);
            textBox13List.Add(txt13_5);
            textBox13List.Add(txt13_6);

            for (int i = 0; i < textBox13List.Count; i++) {
                yobihiTextBoxList[i].Text = "0";
                zandakaTextBoxList[i].Text = "0";
                textBox11List[i].Text = "0";
                textBox13List[i].Text = "0";
            }
        }


        public void SetHeader(string houjinMei, DateTime kisanbi, DateTime kimatsubi) {
            txtHoujinmei.Text = houjinMei;

            txtKisanbi.Text = helper.Converter.DateTimeToWarekiStrKanji(kisanbi);
            txtKimatsubi.Text = helper.Converter.DateTimeToWarekiStrKanji(kimatsubi);
        }

        
        public void SetKaikeiKubunCaption(int i, string name) {
            switch (i) {
                case 0: txtKaikeiKubun0.Text = name; break;
                case 1: txtKaikeiKubun1.Text = name; break;
                case 2: txtKaikeiKubun2.Text = name; break;
                case 3: txtKaikeiKubun3.Text = name; break;
                case 4: txtKaikeiKubun4.Text = name; break;
                case 5: txtKaikeiKubun5.Text = name; break;
                case 6: txtKaikeiKubun6.Text = name; break;
            }
        }

        public void SetDB(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }


        private void daikubunGroupHeader_Format(object sender, EventArgs e) {
            models.db.Row row = db.MTKamokuKubun.GetRowFromCache(helper.Converter.ObjToInt(txtDaikubunId.Text, -1));

            if (row != null) {
                txtDaikubun.Text = "【" + row.GetStr("name", "") + "】";
            }
        }

        private void shikinSyuushiGroupHeader_Format(object sender, EventArgs e) {
            models.db.Row row = db.MTKamokuKubun.GetRowFromCache(helper.Converter.ObjToInt(txtShikinSyuushiId.Text, -1));

            if (row != null) {
                txtShikinSyuushi.Text = row.GetStr("name", "");
            }
        }

        private void shikinSyuushiGroupFooter_Format(object sender, EventArgs e) {
            int kubunId = helper.Converter.ObjToInt(txtShikinSyuushiId.Text, -1);

            kamokuKubunId2YosanRowBackup[kubunId] = new List<long>();
            foreach(var textBox in syoukeiTextBoxList){
                kamokuKubunId2YosanRowBackup[kubunId].Add(helper.Converter.AmountToLongObj(textBox.Text).Value);
            }

            switch ((models.constants.MTKamokuKubun)kubunId) {
                case models.constants.MTKamokuKubun.JigyouSyuunyuu:
                    txtSyoukeiCaption.Text = "事業収入計(1)";
                    txtSyuushiCaption.Text = "";
                    foreach (var textBox in syuushiTextBoxList) {
                        textBox.Text = "";
                    }
                    break;
                case models.constants.MTKamokuKubun.JigyouShisyutsu:
                    txtSyoukeiCaption.Text = "事業支出計(2)";
                    txtSyuushiCaption.Text = "事業活動資金収支差額(3)=(1)-(2)";
                    for (int i = 0; i < syuushiTextBoxList.Count; i++) {
                        syuushiTextBoxList[i].Text =
                            helper.Converter.LongToAmountWithoutYen(
                                kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.JigyouSyuunyuu][i]
                                - kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.JigyouShisyutsu][i]
                            );
                    }
                    break;
                case models.constants.MTKamokuKubun.ShisetsuSyuunyuu:
                    txtSyoukeiCaption.Text = "施設設備等収入計(4)";
                    txtSyuushiCaption.Text = "";
                    foreach (var textBox in syuushiTextBoxList) {
                        textBox.Text = "";
                    }
                    break;
                case models.constants.MTKamokuKubun.ShisetsuShisyutsu:
                    txtSyoukeiCaption.Text = "施設設備等支出計(5)";
                    txtSyuushiCaption.Text = "施設設備等資金収支差額(6)=(4)-(5)";
                    for (int i = 0; i < syuushiTextBoxList.Count; i++) {
                        syuushiTextBoxList[i].Text =
                            helper.Converter.LongToAmountWithoutYen(
                                kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.ShisetsuSyuunyuu][i]
                                - kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.ShisetsuShisyutsu][i]
                            );
                    }
                    break;
                case models.constants.MTKamokuKubun.SonotaSyuunyuu:
                    txtSyoukeiCaption.Text = "その他収入計(7)";
                    txtSyuushiCaption.Text = "";
                    foreach (var textBox in syuushiTextBoxList) {
                        textBox.Text = "";
                    }
                    break;
                case models.constants.MTKamokuKubun.SonotaShisyutsu:
                    txtSyoukeiCaption.Text = "その他支出計(8)";
                    txtSyuushiCaption.Text = "その他活動資金収支差額(9)=(7)-(8)";
                    for (int i = 0; i < syuushiTextBoxList.Count; i++) {
                        syuushiTextBoxList[i].Text =
                            helper.Converter.LongToAmountWithoutYen(
                                kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.SonotaSyuunyuu][i]
                                - kamokuKubunId2YosanRowBackup[(int)models.constants.MTKamokuKubun.SonotaShisyutsu][i]
                            );
                    }
                    break;
            }
        }


        public void SetYobihi(int col, long val){
            yobihiTextBoxList[col].Text = helper.Converter.LongToAmountWithoutYen(val);
        }

        public void SetZandaka(int col, long val) {
            zandakaTextBoxList[col].Text = helper.Converter.LongToAmountWithoutYen(val);
        }

        private void reportFooter1_Format(object sender, EventArgs e) {
            for (int col = 0; col < textBox11List.Count; col++) {
                long sum = 0;
                foreach (var pair in kamokuKubunId2YosanRowBackup) {
                    if (pair.Key == (int)models.constants.MTKamokuKubun.JigyouSyuunyuu ||
                            pair.Key == (int)models.constants.MTKamokuKubun.ShisetsuSyuunyuu ||
                            pair.Key == (int)models.constants.MTKamokuKubun.SonotaSyuunyuu) {
                        sum += pair.Value[col];
                    }
                    else {
                        sum -= pair.Value[col];
                    }
                }
                sum -= helper.Converter.AmountToLongObj(yobihiTextBoxList[col].Text).Value;
                textBox11List[col].Text = helper.Converter.LongToAmountWithoutYen(sum);

                sum += helper.Converter.AmountToLongObj(zandakaTextBoxList[col].Text).Value;
                textBox13List[col].Text = helper.Converter.LongToAmountWithoutYen(sum);
            }
        }
    }
}
