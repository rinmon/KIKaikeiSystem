using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class KurikoshiSyoriFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.KurikoshiSyoriForm form;
        private misc.FocusController focusController;


        public KurikoshiSyoriFormController() {
            form = new KaikeiSystemBody.views.KurikoshiSyoriForm();

            form.CloseButtonClicked += delegate() {
                this.MainController.PopActivity();
            };

            form.RecalcButtonClicked += delegate() {
            
            };

            form.ExecuteButtonClicked += Execute;

            focusController = new misc.FocusController(form);
        }


        public override Form Form {
            get {
                return form;
            }
        }


        override protected void OnActivated(object option) {
            form.SetCurrentYear(Context.Setting.GetDateTime("nenndo_kisanbi").Value);
        }

        override protected void OnDeactivated() {
        }


        private void Execute() {
            if (form.NextYear == null) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidYear);
                return;
            }

            int nextYear = form.NextYear.Value.Year;
            DateTime lastNenndoKisanbi = helper.Helper.GetNenndoKisanbi(nextYear - 1);
            DateTime lastNenndoKimatsubi = helper.Helper.GetNenndoKimatsubi(lastNenndoKisanbi);

            misc.WaitCursorController.Begin();

            // DBバックアップ作成
            {
                helper.DBBackup.MakeDBBackup(
                    Context.KaikeiDatabase.DBFilePath,
                    "kurikoshi_" +
                    helper.Converter.DateTimeToWarekiGengou(lastNenndoKisanbi) +
                    helper.Converter.DateTimeToWarekiYear(lastNenndoKisanbi));
            }

            // 繰越処理
            foreach (var kaikeiKubunRow in Context.KaikeiDatabase.MTKaikeiKubun.Select("")) {
                int kaikeiKubunId = kaikeiKubunRow.GetId();
                if (Context.KaikeiDatabase.MTKaikeiKubun.SelectChildren(kaikeiKubunId).Count() > 0) {
                    continue;
                }

                Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.ConstructZenkiKurikoshi(kaikeiKubunId, nextYear);

                models.query.BalanceSheet balance = new models.query.BalanceSheet(Context.KaikeiDatabase);
                balance.Calc(lastNenndoKisanbi, lastNenndoKimatsubi, kaikeiKubunId, hideInnerKaikeiKubunKamoku: false);

                models.query.ShikinSyuushi shikinSyuushi = new models.query.ShikinSyuushi(Context.KaikeiDatabase);
                shikinSyuushi.Calc(lastNenndoKisanbi, lastNenndoKimatsubi, kaikeiKubunId, 0, hideInnerKaikeiKubunKamoku: true, targetKamokuKubunHierarchy:models.constants.MTKamokuKubunHierarchy.ChuuKubun, omitZeroRow: false);

                models.query.KamokuKubunSummary summary = new models.query.KamokuKubunSummary(Context.KaikeiDatabase);
                summary.Calc(lastNenndoKisanbi, lastNenndoKimatsubi, kaikeiKubunId, addKurikoshi: true, addPairedShikinDenpyou: false);

                string sql = string.Format("where kaikei_kubun_id={0} and nenndo={1}", kaikeiKubunId, nextYear);
                foreach (var kurikoshiRow in Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.Select(sql)) {
                    kurikoshiRow.Set("zenki_kurikoshi_gaku", 0);
                    Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.Update(kurikoshiRow);

                    long taisyaku = 0;
                    int kamokuKubunId = (int)kurikoshiRow.GetLong("kamoku_kubun_id", -1);

                    if (kamokuKubunId == (int)models.constants.MTKamokuKubun.JikiKurikoshikatsudouZougenSagakuChukubun) {
                        taisyaku = balance.GetSummaryItem(models.query.BalanceSheet.SummaryItem.JikiKurikoshiSagaku).CurrentSumAmount;
                    }
                    else if (kamokuKubunId == (int)models.constants.MTKamokuKubun.ZenkimatsuShiharaiShikinZandaka) {
                        taisyaku = shikinSyuushi.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.ToukiZandaka].Taisyaku;
                    }
                    else {
                        var row = summary.SummaryItem(kamokuKubunId);
                        if (row != null) {
                            taisyaku = row.GetTaisyaku(Context.KaikeiDatabase);
                        }
                    }

                    if (taisyaku == 0) {
                        continue;
                    }
                    kurikoshiRow.Set("zenki_kurikoshi_gaku", taisyaku);
                    Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.Update(kurikoshiRow);

                    var kamokuKubunRow = Context.KaikeiDatabase.MTKamokuKubun.GetRowById(kamokuKubunId);
                    if ((int)kamokuKubunRow.GetLong("hierarchy", -1) == (int)models.constants.MTKamokuKubunHierarchy.ChuuKubun) {
                        var daikubunRow = Context.KaikeiDatabase.MTKamokuKubun.GetRowById((int)kamokuKubunRow.GetLong("parent_id", -1));
                        if (daikubunRow != null) {
                            string sql2 = string.Format("{0} and kamoku_kubun_id={1}", sql, daikubunRow.GetId());
                            var daikubunKurikoshiRow = Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.GetFirstRow(sql2);
                            daikubunKurikoshiRow.Set("zenki_kurikoshi_gaku", taisyaku + daikubunKurikoshiRow.GetLong("zenki_kurikoshi_gaku", 0));
                            Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.Update(daikubunKurikoshiRow);
                        }
                    }
                }
            }

            //過去のデータの削除
            {
                string sql = string.Format(
                    "delete from {0} where kihyoubi < {1} ",
                    Context.KaikeiDatabase.KaikeiDenpyouMeisai.TableName,
                    helper.Converter.DateTimeToInt(lastNenndoKisanbi));
                Context.KaikeiDatabase.ExecuteNonQuery(sql);

                sql = string.Format(
                    "delete from {0} where nenndo < {1}",
                    Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.TableName,
                    lastNenndoKisanbi.Year - 1);
                Context.KaikeiDatabase.ExecuteNonQuery(sql);
            }

            //起算日を変更
            {
                DateTime nextKisanbi = helper.Helper.GetNenndoKisanbi(nextYear);
                Context.Setting.SetDateTime("nenndo_kisanbi", nextKisanbi);
                Context.Setting.SetStr("before_gengou", helper.Converter.DateTimeToWarekiGengou(nextKisanbi));
                Context.Setting.SetStr("before_year", helper.Converter.DateTimeToWarekiYear(nextKisanbi).ToString());
                Context.Setting.SetStr("before_month", nextKisanbi.Month.ToString());
                Context.Setting.SetStr("before_day", nextKisanbi.Day.ToString());
            }
            misc.WaitCursorController.EndWithSuccessMsg();
        }
    }
}
