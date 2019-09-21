using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class PrintMainFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.PrintMainForm form;
        private misc.FocusController focusController;

        
        public PrintMainFormController() {
            form = new KaikeiSystemBody.views.PrintMainForm();

            form.CloseButtonClicked += delegate() {
                this.MainController.PopActivity();
            };

            form.PrintYosanButtonClicked += delegate() {
                this.MainController.SwitchActivity(
                    controllers.MainController.ActivityType.PrintYosan,
                    controllers.MainController.ActivitySwitchMethod.PushModal,
                    this.Context,
                    null
                );
            };

            form.PrintMototyouButtonClicked += delegate() {
                var popupController = new popup.KanjouMototyouPrintPopupController();
                popupController.ShowPopupModal(form, Context);
            };

            form.PrintButtonClicked += PrintButtonClicked;

            focusController = new misc.FocusController(form);
        }


        public override Form Form {
            get {
                return form;
            }
        }


        override protected void OnActivated(object option) {
            form.SetGengou(Context.Setting.GetStr("before_gengou", ""));
            form.SetDatabase(Context.KaikeiDatabase);
        }

        override protected void OnDeactivated() {

        }


        private void PrintButtonClicked() {
            // パラメータチェック
            var masterBits = views.PrintMainForm.PrintTarget.MTKanjouKamoku | views.PrintMainForm.PrintTarget.MTTekiyou;
            if ((form.SelectedPrintTarget | masterBits) == masterBits) {
                // マスターのみ印刷時はパラメータチェックしない
            }
            else if (form.StartDate == null || form.EndDate == null) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidDate);
                return;
            }

            DataDynamics.ActiveReports.ActiveReport report = new DataDynamics.ActiveReports.ActiveReport();

            if ((form.SelectedPrintTarget & views.PrintMainForm.PrintTarget.ShiwakeDenpyou) != 0) {
                PrintShiwakeDenpyou(report, views.PrintMainForm.PrintTarget.ShiwakeDenpyou);
            }
            if ((form.SelectedPrintTarget & views.PrintMainForm.PrintTarget.ShiwakeNikki) != 0) {
                PrintShiwakeDenpyou(report, views.PrintMainForm.PrintTarget.ShiwakeNikki);
            }

            // マスタ
            if ((form.SelectedPrintTarget & views.PrintMainForm.PrintTarget.MTKanjouKamoku) != 0) {
                AddMasterKanjouKamoku(report);
            }
            if ((form.SelectedPrintTarget & views.PrintMainForm.PrintTarget.MTTekiyou) != 0) {
                AddMasterTekiyou(report);
            }

            // 決算書類
            if ((form.SelectedPrintTarget & views.PrintMainForm.PrintTarget.KessanHyoushi) != 0) {
                AddKessanHoukokusyoHyoushi(report);
            }
            //資金収支計算書
            if ((form.SelectedPrintTarget & views.PrintMainForm.PrintTarget.KessanShikinKeisan) != 0) {
                AddKessanShikinKeisanReport(report);
            }
            //資金収支内訳表
            if ((form.SelectedPrintTarget & views.PrintMainForm.PrintTarget.KessanShikinUchiwake) != 0) {
                AddKessanShikinUchiwakeRepoert(report);
            }
            //事業活動計算書
            if ((form.SelectedPrintTarget & views.PrintMainForm.PrintTarget.KessanJigyouKeisan) != 0) {
                AddKessanJigyouKatsudouReport(report);
            }
            //事業活動内訳表
            if ((form.SelectedPrintTarget & views.PrintMainForm.PrintTarget.KessanJigyouUchiwake) != 0) {
                AddKessanJigyouUchiwakeReport(report);
            }
            if ((form.SelectedPrintTarget & views.PrintMainForm.PrintTarget.KessanGoukeiZandakaChukubunOnly) != 0) {
                AddKessanGoukeiZandakaReport(report, chukubunOnly: true);
            }
            if ((form.SelectedPrintTarget & views.PrintMainForm.PrintTarget.KessanGoukeiZandakaWithHojokamoku) != 0) {
                AddKessanGoukeiZandakaReport(report, chukubunOnly: false);
            }
            //貸借対象表
            if ((form.SelectedPrintTarget & views.PrintMainForm.PrintTarget.KessanBalanceSheet) != 0) {
                AddKessanBalanceSheetReport(report);
            }
            if ((form.SelectedPrintTarget & views.PrintMainForm.PrintTarget.KoteiShisanMeisai) != 0) {
                AddKoteiShisanMeisaiReport(report);
            }
            if ((form.SelectedPrintTarget & views.PrintMainForm.PrintTarget.HikiatekinMeisai) != 0) {
                AddHikiatekinMeisaiReport(report);
            }
            if ((form.SelectedPrintTarget & views.PrintMainForm.PrintTarget.Tyuuki) != 0) {
                AddTyuukiReport(report);
            }


            if (report.Document.Pages.Count > 0) {
                var reportPopup = new views.popup.ReportPreviewPopup();
                reportPopup.Document = report.Document;
                reportPopup.ShowDialog();
            }
        }


        private void AddMasterKanjouKamoku(DataDynamics.ActiveReports.ActiveReport parentReport) {
            models.query.KanjouKamokuList kamokuList = new models.query.KanjouKamokuList(Context.KaikeiDatabase);
            kamokuList.CreateList(
                form.SelectedKanjouKamokuPrintType == views.PrintMainForm.KanjouKamokuPrintType.UsableOnly,
                withHojoKamkou: true
            );

            var report = new views.reports.KanjouKamokuReport();
            report.DataSource = kamokuList.Rows;
            report.Rows = kamokuList.Rows;
            report.Run();
            parentReport.Document.Pages.AddRange(report.Document.Pages.GetRange(0, report.Document.Pages.Count));
        }

        private void AddMasterTekiyou(DataDynamics.ActiveReports.ActiveReport parentReport) {
            models.query.TekiyouList tekiyouList = new models.query.TekiyouList(Context.KaikeiDatabase);
            tekiyouList.CreateList();

            var report = new views.reports.TekiyouReport();
            report.DataSource = tekiyouList.Rows;
            report.Run();
            parentReport.Document.Pages.AddRange(report.Document.Pages.GetRange(0, report.Document.Pages.Count));
        }


        private void AddKessanHoukokusyoHyoushi(DataDynamics.ActiveReports.ActiveReport parentReport) {
            int rootKaikeiKubunId = Context.KaikeiDatabase.MTKaikeiKubun.RootNodeId;
            models.db.Row rootRow = Context.KaikeiDatabase.MTKaikeiKubun.GetRowFromCache(rootKaikeiKubunId);
            string houjinMei = rootRow.GetStr("name");
            string yuubinBangou = rootRow.GetStr("yuubin_bangou");
            string juusyo = Context.KaikeiDatabase.MTKaikeiKubun.GetJuusyoStr(rootRow);

            var report = new views.reports.KessanHoukokusyoHyoushi();
            report.SetHeader(form.StartDate.Value, form.EndDate.Value, houjinMei, yuubinBangou, juusyo);
            report.Run();
            parentReport.Document.Pages.AddRange(report.Document.Pages.GetRange(0, report.Document.Pages.Count));
        }


        private void AddKessanGoukeiZandakaReport(DataDynamics.ActiveReports.ActiveReport parentReport, bool chukubunOnly) {
            models.query.GoukeiZandakaShisanhyou sisanhyou = new models.query.GoukeiZandakaShisanhyou(Context.KaikeiDatabase);
            sisanhyou.Calc(form.KaikeiKubun, form.StartDate.Value, chukubunOnly_: chukubunOnly);

            var report = new views.reports.GoukeiZandakaShisanhyou();
            report.SetDB(Context.KaikeiDatabase);

            string kaikeiKubunName = Context.KaikeiDatabase.MTKaikeiKubun.GetFirst("name", "where id=" + form.KaikeiKubun) as string;
            report.SetHeader(kaikeiKubunName, form.StartDate.Value);

            report.DataSource = sisanhyou.RowList;
            report.Run();
            parentReport.Document.Pages.AddRange(report.Document.Pages.GetRange(0, report.Document.Pages.Count));
        }

        private void AddKessanShikinKeisanReport(DataDynamics.ActiveReports.ActiveReport parentReport) {
            models.query.ShikinSyuushi shikin = new models.query.ShikinSyuushi(Context.KaikeiDatabase);
            shikin.Calc(form.StartDate.Value, form.EndDate.Value, form.KaikeiKubun, -1, hideInnerKaikeiKubunKamoku:true, targetKamokuKubunHierarchy:form.KamokuKubunHierarchy, omitZeroRow:form.OmitZeroRow);

            var report = new views.reports.ShikinSyuushiKeisansyo();
            report.SetDB(Context.KaikeiDatabase);

            int rootKaikeiKubunId = Context.KaikeiDatabase.MTKaikeiKubun.RootNodeId;
            models.db.Row rootRow = Context.KaikeiDatabase.MTKaikeiKubun.GetRowFromCache(rootKaikeiKubunId);
            string houjinMei = rootRow.GetStr("name");
            string kaikeiKubunName = Context.KaikeiDatabase.MTKaikeiKubun.GetFirst("name", "where id=" + form.KaikeiKubun) as string;
            string title = "拠点区分資金収支計算書";
            string youshiki = "第一号第四様式";
            if (form.KaikeiKubun == 1) {
                title = "法人単位資金収支計算書";
                youshiki = "第一号第一様式";
            }
            else if (form.KaikeiKubun == 2) {
                title = "事業区分資金収支計算書";
                youshiki = "";
            }
            report.SetHeader(form.StartDate.Value, form.EndDate.Value, houjinMei, kaikeiKubunName, title, youshiki);
            report.SetFooter(
                shikin.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.Yobihi],
                shikin.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.ToukiShikin],
                shikin.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.ZenkiZandaka],
                shikin.SummaryRows[(int)models.query.ShikinSyuushi.SummaryItem.ToukiZandaka]);
            var source = shikin.GetRowsForShikinSyuushiKeisansyoReport();
            report.DataSource = source;
            report.Run();
            parentReport.Document.Pages.AddRange(report.Document.Pages.GetRange(0, report.Document.Pages.Count));
        }

        private void AddKessanShikinUchiwakeRepoert(DataDynamics.ActiveReports.ActiveReport parentReport) {
            models.query.ShikinSyuushiUchiwake uchiwake = new models.query.ShikinSyuushiUchiwake(Context.KaikeiDatabase);
            uchiwake.Calc(form.StartDate.Value, form.EndDate.Value, form.KaikeiKubun, -1, hideInnerKaikeiKubunKamoku:true, omitZeroRow:form.OmitZeroRow);

            if (uchiwake.NumCols <= 5 - uchiwake.NumStaticCols) {
                var report = new views.reports.ShikinSyuushiKessanUchiwakeCol5();
                AddKessanShikinUchiwakeReportSub(report, report.Engine, uchiwake, 0, uchiwake.NumCols - 1);
                parentReport.Document.Pages.AddRange(report.Document.Pages.GetRange(0, report.Document.Pages.Count));
            }
            else if (uchiwake.NumCols <= 10 - uchiwake.NumStaticCols) {
                var report = new views.reports.ShikinSyuushiKessanUchiwakeCol10();
                AddKessanShikinUchiwakeReportSub(report, report.Engine, uchiwake, 0, uchiwake.NumCols - 1);
                parentReport.Document.Pages.AddRange(report.Document.Pages.GetRange(0, report.Document.Pages.Count));
            }
            else {
                int startCol = 0;

                while (startCol <= uchiwake.NumCols - 1) {
                    int endCol = Math.Min(startCol + 7 - uchiwake.NumStaticCols - 1, uchiwake.NumCols - 1);
                    var report = new views.reports.ShikinSyuushiKessanUchiwakeCol7();
                    AddKessanShikinUchiwakeReportSub(report, report.Engine, uchiwake, startCol, endCol);
                    parentReport.Document.Pages.AddRange(report.Document.Pages.GetRange(0, report.Document.Pages.Count));

                    startCol = endCol + 1;
                }
            }
        }

        private void AddKessanShikinUchiwakeReportSub(DataDynamics.ActiveReports.ActiveReport report, views.reports.ShikinSyuushiKessanUchiwakeEngine engine, models.query.ShikinSyuushiUchiwake uchiwake, int startCol, int endCol) {
            engine.SetDB(Context.KaikeiDatabase);

            int rootKaikeiKubunId = Context.KaikeiDatabase.MTKaikeiKubun.RootNodeId;
            models.db.Row rootRow = Context.KaikeiDatabase.MTKaikeiKubun.GetRowFromCache(rootKaikeiKubunId);
            string houjinMei = rootRow.GetStr("name");
            string title = "【拠点区分資金収支明細書】";
            string youshiki = "別紙３（⑩）";
            if (form.KaikeiKubun == 1)
            {
                title = "【資金収支内訳表】";
                youshiki = "第一号第二様式";
            }
            else if (form.KaikeiKubun == 2) 
            {
                title = "【事業区分資金収支内訳表】";
                youshiki = "第一号第三様式";
            }
            engine.SetHeader(form.StartDate.Value, form.EndDate.Value, houjinMei, uchiwake.GetColCaptions(startCol, endCol), title, youshiki);
            engine.SetFooter(
                uchiwake.GetSummaryRow(models.query.ShikinSyuushi.SummaryItem.ToukiShikin, startCol, endCol),
                uchiwake.GetSummaryRow(models.query.ShikinSyuushi.SummaryItem.ZenkiZandaka, startCol, endCol),
                uchiwake.GetSummaryRow(models.query.ShikinSyuushi.SummaryItem.ToukiZandaka, startCol, endCol));

            var source = uchiwake.GetRows(startCol, endCol);
            report.DataSource = source;
            report.Run();
        }

        private void AddKessanJigyouKatsudouReport(DataDynamics.ActiveReports.ActiveReport parentReport) {
            models.query.JigyouKatsudou jigyou = new models.query.JigyouKatsudou(Context.KaikeiDatabase);
            jigyou.Calc(form.StartDate.Value, form.EndDate.Value, form.KaikeiKubun, hideInnerKaikeiKubunKamoku:true, targetKamokuKubunHierarchy:form.KamokuKubunHierarchy, omitZeroRow:form.OmitZeroRow);

            var report = new views.reports.JigyouKatsudouSyuushiKeisansyo();
            report.SetDB(Context.KaikeiDatabase);

            int rootKaikeiKubunId = Context.KaikeiDatabase.MTKaikeiKubun.RootNodeId;
            models.db.Row rootRow = Context.KaikeiDatabase.MTKaikeiKubun.GetRowFromCache(rootKaikeiKubunId);
            string houjinMei = rootRow.GetStr("name");
            string kaikeiKubunName = Context.KaikeiDatabase.MTKaikeiKubun.GetFirst("name", "where id=" + form.KaikeiKubun) as string;

            string title = "拠点区分事業活動計算書";
            string youshiki = "第二号第四様式";
            if (form.KaikeiKubun == 1) {
                title = "法人単位事業活動計算書";
                youshiki = "第二号第一様式";
            }
            else if (form.KaikeiKubun == 2) {
                title = "事業区分事業活動計算書";
                youshiki = "";
            }

            report.SetHeader(form.StartDate.Value, form.EndDate.Value, houjinMei, kaikeiKubunName, title, youshiki);
            report.SetFooter(
                jigyou.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.ToukiKatsudouZougenSagaku],
                jigyou.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.ZenkiKurikoshiZougenSagaku],
                jigyou.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.ToukimatsuKurikoshiKatsudouZougenSagaku],
                jigyou.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.KihonkinTorikuzushiGaku],
                jigyou.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.SonotaTsumitateTorikuzushiGaku],
                jigyou.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.SonotaTsumitateGaku],
                jigyou.SummaryRows[(int)models.query.JigyouKatsudou.SummaryItem.JikiKurikoshiKatsudouZougenSagaku]);
            var source = jigyou.GetRowsForJigyouKatsudouKeisansyoReport();
            report.DataSource = source;
            report.Run();
            parentReport.Document.Pages.AddRange(report.Document.Pages.GetRange(0, report.Document.Pages.Count));
        }


        private void AddKessanJigyouUchiwakeReport(DataDynamics.ActiveReports.ActiveReport parentReport) {
            models.query.JigyouKatsudouUchiwake uchiwake = new models.query.JigyouKatsudouUchiwake(Context.KaikeiDatabase);
            uchiwake.Calc(form.StartDate.Value, form.EndDate.Value, form.KaikeiKubun, hideInnerKaikeiKubunKamoku:true, omitZeroRow:form.OmitZeroRow);

            if (uchiwake.NumCols <= 5 - uchiwake.NumStaticCols) {
                var report = new views.reports.JigyouSyuushiUchiwake5();
                AddKessanJigyouUchiwakeReportSub(report, report.Engine, uchiwake, 0, uchiwake.NumCols - 1);
                parentReport.Document.Pages.AddRange(report.Document.Pages.GetRange(0, report.Document.Pages.Count));
            }
            else {
                int startCol = 0;

                while (startCol <= uchiwake.NumCols - 1) {
                    int endCol = Math.Min(startCol + 7 - uchiwake.NumStaticCols - 1, uchiwake.NumCols - 1);
                    var report = new views.reports.JigyouSyuushiUchiwake7();
                    AddKessanJigyouUchiwakeReportSub(report, report.Engine, uchiwake, startCol, endCol);
                    parentReport.Document.Pages.AddRange(report.Document.Pages.GetRange(0, report.Document.Pages.Count));

                    startCol = endCol + 1;
                }
            }
        }

        private void AddKessanJigyouUchiwakeReportSub(DataDynamics.ActiveReports.ActiveReport report, views.reports.JigyouSyuushiUchiwakeEngine engine, models.query.JigyouKatsudouUchiwake uchiwake, int startCol, int endCol) {
            engine.SetDB(Context.KaikeiDatabase);

            int rootKaikeiKubunId = Context.KaikeiDatabase.MTKaikeiKubun.RootNodeId;
            models.db.Row rootRow = Context.KaikeiDatabase.MTKaikeiKubun.GetRowFromCache(rootKaikeiKubunId);
            string houjinMei = rootRow.GetStr("name");
            string title = "拠点区分事業活動明細書";
            string youshiki = "別紙３（⑪）";
            if (form.KaikeiKubun == 1)
            {
                title = "事業活動内訳表";
                youshiki = "第二号第二様式";
            }
            else if (form.KaikeiKubun == 2)
            {
                title = "事業区分事業活動内訳表";
                youshiki = "第二号第三様式";
            }
            engine.SetHeader(form.StartDate.Value, form.EndDate.Value, houjinMei, uchiwake.GetColCaptions(startCol, endCol), title, youshiki);
            engine.SetFooter(
                uchiwake.GetSummaryRow(models.query.JigyouKatsudou.SummaryItem.ToukiKatsudouZougenSagaku, startCol, endCol),
                uchiwake.GetSummaryRow(models.query.JigyouKatsudou.SummaryItem.ZenkiKurikoshiZougenSagaku, startCol, endCol),
                uchiwake.GetSummaryRow(models.query.JigyouKatsudou.SummaryItem.ToukimatsuKurikoshiKatsudouZougenSagaku, startCol, endCol),
                uchiwake.GetSummaryRow(models.query.JigyouKatsudou.SummaryItem.KihonkinTorikuzushiGaku, startCol, endCol),
                uchiwake.GetSummaryRow(models.query.JigyouKatsudou.SummaryItem.SonotaTsumitateTorikuzushiGaku, startCol, endCol),
                uchiwake.GetSummaryRow(models.query.JigyouKatsudou.SummaryItem.SonotaTsumitateGaku, startCol, endCol),
                uchiwake.GetSummaryRow(models.query.JigyouKatsudou.SummaryItem.JikiKurikoshiKatsudouZougenSagaku, startCol, endCol)
                );

            var source = uchiwake.GetRows(startCol, endCol);
            report.DataSource = source;
            report.Run();
        }


        private void AddKessanBalanceSheetReport(DataDynamics.ActiveReports.ActiveReport parentReport) {
            models.query.BalanceSheet balance = new models.query.BalanceSheet(Context.KaikeiDatabase);
            balance.Calc(form.StartDate.Value, form.EndDate.Value, form.KaikeiKubun, hideInnerKaikeiKubunKamoku:true);

            models.query.BalanceSheetTyuuki tyuuki = new models.query.BalanceSheetTyuuki(Context.KaikeiDatabase);
            tyuuki.Calc(helper.Converter.GetNenndo(form.StartDate.Value), form.KaikeiKubun);

            var report = new views.reports.BalanceSheet();
            report.SetDB(Context.KaikeiDatabase);

            string houjinMei = Context.KaikeiDatabase.MTKaikeiKubun.RootName;
            string kaikeiKubunName = Context.KaikeiDatabase.MTKaikeiKubun.GetFirst("name", "where id=" + form.KaikeiKubun) as string;

            string title = "拠点区分貸借対照表";
            string youshiki = "第三号第四様式";
            if (form.KaikeiKubun == 1) {
                title = "法人単位貸借対照表";
                youshiki = "第三号第一様式";
            }
            else if (form.KaikeiKubun == 2) {
                title = "事業区分貸借対照表";
                youshiki = "";
            }

            report.SetHeader(
                houjinMei,
                kaikeiKubunName,
                form.EndDate.Value, title, youshiki);
            report.SetSummaryRow(
                balance.GetSummaryItem(models.query.BalanceSheet.SummaryItem.ShisanSummary),
                balance.GetSummaryItem(models.query.BalanceSheet.SummaryItem.HusaiSummary),
                balance.GetSummaryItem(models.query.BalanceSheet.SummaryItem.JunshisanSummary),
                balance.GetSummaryItem(models.query.BalanceSheet.SummaryItem.HusaiPlusJunshisanSummary),
                balance.GetSummaryItem(models.query.BalanceSheet.SummaryItem.JikiKurikoshiSagaku),
                balance.GetSummaryItem(models.query.BalanceSheet.SummaryItem.ToukiSagaku));
            report.SetDataSource(
                balance.GetChildrenList((int)models.constants.MTKamokuKubun.Shisan),
                balance.GetChildrenList((int)models.constants.MTKamokuKubun.Husai),
                balance.GetChildrenList((int)models.constants.MTKamokuKubun.Junshisan),
                tyuuki.Tyuuki1Rows,
                tyuuki.Tyuuki3Rows,
                tyuuki.Tyuuki4Rows,
                tyuuki.Tyuuki5Rows);
            report.SetTyuukiData(
                tyuuki.GenkaSyoukyakuRuikeiGaku,
                tyuuki.TyousyuuHunouKin,
                tyuuki.Tyuuki2,
                tyuuki.Tyuuki6);

            report.Run();
            parentReport.Document.Pages.AddRange(report.Document.Pages.GetRange(0, report.Document.Pages.Count));
        }


        private void AddKoteiShisanMeisaiReport(DataDynamics.ActiveReports.ActiveReport parentReport) {
            DateTime startDate = helper.Helper.GetNenndoKisanbi(form.StartDate.Value);
            DateTime endDate = helper.Helper.GetNenndoKimatsubi(form.EndDate.Value);
            models.query.KoteiShisanMeisai meisai = new models.query.KoteiShisanMeisai(Context.KaikeiDatabase);
            meisai.Calc(startDate, endDate, form.KaikeiKubun);

            var report = new views.reports.KoteiShisanMeisaisyo();
            report.SetDB(Context.KaikeiDatabase);

            int rootKaikeiKubunId = Context.KaikeiDatabase.MTKaikeiKubun.RootNodeId;
            models.db.Row rootRow = Context.KaikeiDatabase.MTKaikeiKubun.GetRowFromCache(rootKaikeiKubunId);
            string houjinMei = rootRow.GetStr("name");
            string kaikeiKubunName = "";
            if (form.KaikeiKubun != rootKaikeiKubunId) {
                kaikeiKubunName = Context.KaikeiDatabase.MTKaikeiKubun.GetFirst("name", "where id=" + form.KaikeiKubun) as string;
            }
            report.SetHeader(startDate, endDate, houjinMei, kaikeiKubunName);
            report.SetFooter(meisai.SonotaRow, meisai.KihonSonotaRow, meisai.SyouraiRow, meisai.SashihikiRow);
            report.DataSource = meisai.GetMeisaiList();
            report.Run();
            parentReport.Document.Pages.AddRange(report.Document.Pages.GetRange(0, report.Document.Pages.Count));
        }


        private void AddHikiatekinMeisaiReport(DataDynamics.ActiveReports.ActiveReport parentReport) {
            DateTime startDate = helper.Helper.GetNenndoKisanbi(form.StartDate.Value);
            DateTime endDate = helper.Helper.GetNenndoKimatsubi(form.EndDate.Value);
            models.query.HikiatekinMeisai meisai = new models.query.HikiatekinMeisai(Context.KaikeiDatabase);
            meisai.Calc(startDate, endDate, form.KaikeiKubun);

            var report = new views.reports.HikiatekinMeisaiReport();
            report.SetDB(Context.KaikeiDatabase);

            int rootKaikeiKubunId = Context.KaikeiDatabase.MTKaikeiKubun.RootNodeId;
            models.db.Row rootRow = Context.KaikeiDatabase.MTKaikeiKubun.GetRowFromCache(rootKaikeiKubunId);
            string houjinMei = rootRow.GetStr("name");
            string kaikeiKubunName = "";
            if (form.KaikeiKubun != rootKaikeiKubunId) {
                kaikeiKubunName = Context.KaikeiDatabase.MTKaikeiKubun.GetFirst("name", "where id=" + form.KaikeiKubun) as string;
            }
            report.SetHeader(startDate, endDate, houjinMei, kaikeiKubunName);
            report.SetFooter(meisai.SumRow);
            report.DataSource = meisai.GetMeisaiList();
            report.Run();
            parentReport.Document.Pages.AddRange(report.Document.Pages.GetRange(0, report.Document.Pages.Count));
        }


        private void AddTyuukiReport(DataDynamics.ActiveReports.ActiveReport parentReport) {
            DateTime startDate = helper.Helper.GetNenndoKisanbi(form.StartDate.Value);
            models.query.Tyuuki meisai = new models.query.Tyuuki(Context.KaikeiDatabase);

            if (meisai.Calc(startDate, form.KaikeiKubun, form.GetHideTyuukiRows()) == false) {
                helper.MsgBox.Err(Properties.Resources.MsgNotExist);
                return;
            }

            var report = new views.reports.TyuukiReport();
            report.SetDB(Context.KaikeiDatabase);
            report.IsHoujinKyoten = (form.KaikeiKubun == Context.KaikeiDatabase.MTKaikeiKubun.RootNodeId);
            report.Tyuuki = meisai;

            report.DataSource = meisai.GetRows();
            report.Run();
            parentReport.Document.Pages.AddRange(report.Document.Pages.GetRange(0, report.Document.Pages.Count));
        }


        private void PrintShiwakeDenpyou(DataDynamics.ActiveReports.ActiveReport parentReport, views.PrintMainForm.PrintTarget format) {
            bool margeDenpyouGroup;

            models.query.ShiwakeDenpyou shiwake = new models.query.ShiwakeDenpyou(Context.KaikeiDatabase);

            Context.KaikeiDatabase.KaikeiDenpyouMeisai.UpdateEditingRows();

            DataDynamics.ActiveReports.ActiveReport report;

            if (format == views.PrintMainForm.PrintTarget.ShiwakeDenpyou) {
                report = new views.reports.ShiwakeDenpyouA4();
                margeDenpyouGroup = true;
            }
            else if (format == views.PrintMainForm.PrintTarget.ShiwakeNikki) {
                var nikki = new views.reports.ShiwakeNikkityou();
                nikki.SetHeader(form.StartDate.Value, form.EndDate.Value);
                report = nikki;
                margeDenpyouGroup = false;
            }
            else {
                return;
            }

            if (form.SelectedDenpyouPrintMethod == views.PrintMainForm.DenpyouPrintMethod.DenpyouBangou) {
                if (form.DenpyouBangouDate == null || form.DenpyouBangouStart == null || form.DenpyouBangouEnd == null) {
                    helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidDenpyouBangou);
                    return;
                }
                shiwake.SetQuery(form.DenpyouBangouDate.Value, form.DenpyouBangouStart.Value, form.DenpyouBangouEnd.Value, form.OnlyCheckedDenpyouPrint, margeDenpyouGroup, form.KaikeiKubun);
            }
            else{
                if (form.StartDate == null || form.EndDate == null) {
                    helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidDate);
                    return;
                }

                string dateCol = "";
            
                if(form.SelectedDenpyouPrintMethod == views.PrintMainForm.DenpyouPrintMethod.Kihyoubi){
                    dateCol = "kihyoubi";
                }
                else if(form.SelectedDenpyouPrintMethod == views.PrintMainForm.DenpyouPrintMethod.Koushinbi){
                    dateCol = "updated_at";
                }
                else if(form.SelectedDenpyouPrintMethod == views.PrintMainForm.DenpyouPrintMethod.Tourokubi){
                    dateCol = "created_at";
                }
                shiwake.SetQuery(form.StartDate.Value, form.EndDate.Value, dateCol, form.OnlyCheckedDenpyouPrint, margeDenpyouGroup, form.KaikeiKubun);
            }

            string kaikeiKubunName = Context.KaikeiDatabase.MTKaikeiKubun.GetFirst("name", "where id=" + form.KaikeiKubun) as string;

            report.DataSource = shiwake.RowList;
            report.Run();

            parentReport.Document.Pages.AddRange(report.Document.Pages.GetRange(0, report.Document.Pages.Count));
        }
    }
}
