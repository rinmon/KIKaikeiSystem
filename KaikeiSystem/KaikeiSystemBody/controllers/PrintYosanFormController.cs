using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class PrintYosanFormController : AbstractActivity
    {

        private class KubunSummaryRow {
            public long HonnenSummary { get; set; }
            public long ZennenSummary { get; set; }

            public KubunSummaryRow() {
                HonnenSummary = 0;
                ZennenSummary = 0;
            }
        }

        private KaikeiSystemBody.views.PrintYosanForm form;
        private misc.FocusController focusController;


        public PrintYosanFormController() {
            form = new KaikeiSystemBody.views.PrintYosanForm();

            form.CloseButtonClicked += delegate() {
                this.MainController.PopActivity();
            };

            form.CurrentYearChanged += delegate() {
                form.ClearHoseiKaisuuMsg();

                if (form.CurrentYear != -1) {
                    int current = Context.KaikeiDatabase.YosanKamokuKubun.GetMax("hosei_kaisuu", "where nenndo = " + form.CurrentYear);
                    form.SetCurrentYearHoseiKaisuuMsg(form.CurrentYear, current);

                }
                if (form.LastYear != -1) {
                    int last = Context.KaikeiDatabase.YosanKamokuKubun.GetMax("hosei_kaisuu", "where nenndo = " + form.LastYear);
                    form.SetLastYearHoseiKaisuuMsg(form.LastYear, last);
                }
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
            form.ClearHoseiKaisuuMsg();
        }

        override protected void OnDeactivated() {

        }


        private void PrintButtonClicked() {
            int currentYear = form.CurrentYear;
            int lastYear = form.LastYear;
            int hoseiKaisuu = form.HoseiKaisuu;
            int kaikeiKubun = form.KaikeiKubun;
            DateTime? printDate = form.DateToAdd;
            views.PrintYosanForm.PrintFormat format = form.SelectedPrintFormat;

            if(form.AllKaikeiKubunIsChecked){
                kaikeiKubun = -1;
            }

            if (currentYear == -1 || lastYear == -1){
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidDate);
                return;
            }
            if(hoseiKaisuu == -1){
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidHoseiKaisuuInput);
                return;
            }
            if (form.AllKaikeiKubunIsChecked == false && kaikeiKubun == -1) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidKaikeiKubun);
                return;
            }
            if (form.AddDateIsChecked && printDate == null) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidDate);
                return;
            }
            if (format == 0) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgPrintTargetIsNotSelected);
                return;
            }

            switch (format) {
                case views.PrintYosanForm.PrintFormat.SyuushiYosan:
                    PrintSyuushiYosan(currentYear, lastYear, hoseiKaisuu, kaikeiKubun, printDate);
                    break;
                case views.PrintYosanForm.PrintFormat.HoseiYosan:
                    PrintHoseiYosan(currentYear, lastYear, hoseiKaisuu, kaikeiKubun, printDate);
                    break;
                case views.PrintYosanForm.PrintFormat.YosanUchiwake:
                    PrintYosanUchiwake(currentYear, lastYear, hoseiKaisuu, kaikeiKubun, printDate);
                    break;
                case views.PrintYosanForm.PrintFormat.YosanJissekiTaihi:
                    PrintYosanJissekiTaihi(Context.KaikeiDatabase, kaikeiKubun, currentYear, lastYear, hoseiKaisuu, printDate);
                    break;
            }
        }


        private void PrintSyuushiYosan(int currentYear, int lastYear, int hoseiKaisuu, int kaikeiKubun, DateTime? printDate) {
            string shisetsuMei = "";
            string houjinMei = "";
            if(kaikeiKubun != -1 && kaikeiKubun != Context.KaikeiDatabase.MTKaikeiKubun.RootNodeId) {
                shisetsuMei = Context.KaikeiDatabase.MTKaikeiKubun.GetRowFromCache(kaikeiKubun).GetStr("name") as string;
            }

            houjinMei = Context.KaikeiDatabase.MTKaikeiKubun.GetRowFromCache(Context.KaikeiDatabase.MTKaikeiKubun.RootNodeId).GetStr("name") as string;

            var yosanTable = new models.query.YosanTable(Context.KaikeiDatabase, currentYear, lastYear, 0, hoseiKaisuu);
            yosanTable.Calc(withSyoukubun: true, withHojokamoku: false);
            var yobihiRow = yosanTable.GetYobihiRow(kaikeiKubun);
            var zandakaRow = yosanTable.GetZenkimatsuZandakaRow(kaikeiKubun);

            var popup = new views.popup.ReportPreviewPopup();
            var report = new views.reports.SyuushiYosanReport();
            report.OmitZeroRow = form.OmitZeroRow;
            report.SetDB(Context.KaikeiDatabase);
            report.SetHeader(currentYear, houjinMei, shisetsuMei, printDate, false, 0);
            report.SetFooter(yobihiRow.YosanHonnenDisplay, yobihiRow.YosanZennenDisplay, zandakaRow.YosanHonnenDisplay, zandakaRow.YosanZennenDisplay);
            report.DataSource = yosanTable.GetYosanList(kaikeiKubun);

            report.Run();
            popup.Document = report.Document;
            popup.ShowDialog();
        }

        
        private void PrintHoseiYosan(int currentYear, int lastYear, int hoseiKaisuu, int kaikeiKubun, DateTime? printDate) {
            string shisetsuMei = "";
            string houjinMei = "";
            if (kaikeiKubun != -1 && kaikeiKubun != Context.KaikeiDatabase.MTKaikeiKubun.RootNodeId) {
                shisetsuMei = Context.KaikeiDatabase.MTKaikeiKubun.GetRowFromCache(kaikeiKubun).GetStr("name") as string;
            }

            houjinMei = Context.KaikeiDatabase.MTKaikeiKubun.GetRowFromCache(Context.KaikeiDatabase.MTKaikeiKubun.RootNodeId).GetStr("name") as string;

            var hoseiYosanTable = new models.query.HoseiYosan(Context.KaikeiDatabase, currentYear, lastYear, hoseiKaisuu);
            hoseiYosanTable.Calc(withSyoukubun: true, withHojokamoku: false);
            var yobihiRow = hoseiYosanTable.GetYobihiRow(kaikeiKubun);
            var zandakaRow = hoseiYosanTable.GetZenkimatsuZandakaRow(kaikeiKubun);

            var popup = new views.popup.ReportPreviewPopup();
            var report = new views.reports.SyuushiYosanReport();
            report.OmitZeroRow = form.OmitZeroRow;
            report.SetDB(Context.KaikeiDatabase);
            report.SetHeader(currentYear, houjinMei, shisetsuMei, printDate, true, hoseiKaisuu);
            report.SetFooter(yobihiRow.YosanHonnenDisplay, yobihiRow.YosanZennenDisplay, zandakaRow.YosanHonnenDisplay, zandakaRow.YosanZennenDisplay);
            report.DataSource = hoseiYosanTable.GetHoseiYosanList(kaikeiKubun);

            report.Run();
            popup.Document = report.Document;
            popup.ShowDialog();
        }




        private void PrintYosanUchiwake(int currentYear, int lastYear, int hoseiKaisuu, int kaikeiKubun, DateTime? printDate) {
            string houjinMei = "";

            houjinMei = Context.KaikeiDatabase.MTKaikeiKubun.GetRowFromCache(Context.KaikeiDatabase.MTKaikeiKubun.RootNodeId).GetStr("name") as string;

            var yosanUchiwake = new models.query.YosanUchiwake();
            yosanUchiwake.Calc(Context.KaikeiDatabase, currentYear, lastYear, hoseiKaisuu, kaikeiKubun, withJisseki: false, withSyoukubun: true, withHojoKamoku: false);

            var report = new views.reports.SyuushiYosanUchiwakeReport();
            report.SetDB(Context.KaikeiDatabase);
            report.SetHeader(houjinMei, new DateTime(currentYear, 4, 1), new DateTime(currentYear + 1, 3, 31));
            for (int i = 0; i < yosanUchiwake.ChildKaikeiKubunNameList.Count; i++) {
                report.SetKaikeiKubunCaption(i, yosanUchiwake.ChildKaikeiKubunNameList[i]);
            }

            for (int colCt = 0; colCt < yosanUchiwake.KaikeiKubunList.Count; colCt++) {
                report.SetYobihi(colCt, yosanUchiwake.YosanTable.GetYobihiRow(yosanUchiwake.KaikeiKubunList[colCt]).YosanHonnenDisplay);
                report.SetZandaka(colCt, yosanUchiwake.YosanTable.GetZenkimatsuZandakaRow(yosanUchiwake.KaikeiKubunList[colCt]).YosanHonnenDisplay);
            }

            var popup = new views.popup.ReportPreviewPopup();

            report.DataSource = yosanUchiwake.YosanUchiwakeRowList;
            report.Run();

            popup.Document = report.Document;
            popup.ShowDialog();
        }


        private void PrintYosanJissekiTaihi(models.db.KaikeiDatabase db, int kaikeiKubunId, int currentYear, int lastYear, int hoseiKaisuu, DateTime? printDate) {
            int kaikeiKubunIdTmp = kaikeiKubunId;
            if (kaikeiKubunIdTmp == -1) {
                kaikeiKubunIdTmp = db.MTKaikeiKubun.RootNodeId;
            }
            if (db.MTKaikeiKubun.RowCount("where parent_id = " + kaikeiKubunIdTmp) <= 2) {
                PrintYosanJissekiTaihi3Column(db, currentYear, lastYear, hoseiKaisuu, kaikeiKubunId, printDate);
            }
            else {
                PrintYosanJissekiTaihi7Columns(db, currentYear, lastYear, hoseiKaisuu, kaikeiKubunId, printDate);
            }
        }

        private void PrintYosanJissekiTaihi7Columns(models.db.KaikeiDatabase db, int currentYear, int lastYear, int hoseiKaisuu, int kaikeiKubun, DateTime? printDate) {
            string houjinMei = "";

            houjinMei = db.MTKaikeiKubun.GetRowFromCache(db.MTKaikeiKubun.RootNodeId).GetStr("name") as string;

            var yosanUchiwake = new models.query.YosanUchiwake();
            yosanUchiwake.Calc(db, currentYear, lastYear, hoseiKaisuu, kaikeiKubun, withJisseki: true, withSyoukubun:false, withHojoKamoku:false);

            var report = new views.reports.SyuushiYosanJissekiReport2();
            report.OmitZeroRow = form.OmitZeroRow;
            report.SetDB(db);
            report.SetHeader(houjinMei, new DateTime(currentYear, 4, 1), new DateTime(currentYear + 1, 3, 31));
            for (int i = 0; i < yosanUchiwake.ChildKaikeiKubunNameList.Count; i++) {
                report.SetKaikeiKubunCaption(i, yosanUchiwake.ChildKaikeiKubunNameList[i]);
            }

            var popup = new views.popup.ReportPreviewPopup();

            report.DataSource = yosanUchiwake.YosanUchiwakeRowList;
            report.Run();

            popup.Document = report.Document;
            popup.ShowDialog();
        }


        private void PrintYosanJissekiTaihi3Column(models.db.KaikeiDatabase db, int currentYear, int lastYear, int hoseiKaisuu, int kaikeiKubun, DateTime? printDate) {
            string houjinMei = "";

            houjinMei = db.MTKaikeiKubun.GetRowFromCache(db.MTKaikeiKubun.RootNodeId).GetStr("name") as string;

            var yosanUchiwake = new models.query.YosanUchiwake();
            yosanUchiwake.Calc(db, currentYear, lastYear, hoseiKaisuu, kaikeiKubun, withJisseki: true, withSyoukubun: false, withHojoKamoku: false);

            var report = new views.reports.SyuushiYosanJissekiReport();
            report.OmitZeroRow = form.OmitZeroRow;
            report.SetDB(db);
            report.SetHeader(houjinMei, new DateTime(currentYear, 4, 1), new DateTime(currentYear + 1, 3, 31));
            for (int i = 0; i < yosanUchiwake.ChildKaikeiKubunNameList.Count; i++) {
                report.SetKaikeiKubunCaption(i, yosanUchiwake.ChildKaikeiKubunNameList[i]);
            }

            var popup = new views.popup.ReportPreviewPopup();

            report.DataSource = yosanUchiwake.YosanUchiwakeRowList;
            report.Run();

            popup.Document = report.Document;
            popup.ShowDialog();
        }
    }
}
