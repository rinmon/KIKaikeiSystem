using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers.popup
{
    class KanjouMototyouPrintPopupController
    {
        private views.popup.KanjouMototyouPrinntPopup popup;
        private misc.FocusController focusController;
        private models.Context context;


        public KanjouMototyouPrintPopupController() {
            popup = null;
            focusController = null;
        }


        public void ShowPopupModal(System.Windows.Forms.Form parent, models.Context aContext) {
            context = aContext;

            popup = new views.popup.KanjouMototyouPrinntPopup();
            popup.SetDatabase(context.KaikeiDatabase);
            popup.SetGengou(context.Setting.GetStr("before_gengou", ""));
            popup.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            popup.Location = new System.Drawing.Point(
                Math.Max(parent.Left + (parent.Width - popup.Width) / 2, 0),
                Math.Max(parent.Top + (parent.Height - popup.Height) / 2, 0));

            popup.CloseButtonClicked += delegate() {
                popup.Close();
            };
            popup.PrintButtonClicked += PrintButtonClicked;

            focusController = new misc.FocusController(popup);

            popup.ShowDialog();
            popup.Dispose();
            popup = null;
        }


        private bool CheckParameter() {
            if (popup.StartDate == null || popup.EndDate == null) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidDate);
                return false;
            }
            if (popup.KaikeiKubunAllChecked == false && popup.TargetKaikeiKubun == -1) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidKaikeiKubun);
                return false;
            }
            if (popup.TargetKamokuType == views.popup.KanjouMototyouPrinntPopup.TargetKamokuTypeEnum.Selected) {
                if (popup.TargetKamokuCode == null) {
                    helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidKamoku);
                    return false;
                }
                if (popup.PrintHojoMototyouChecked && popup.TargetHojoKamokuSeiri == null) {
                    helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidHojoKamoku);
                    return false;
                }
            }
            if (popup.TargetKamokuType == views.popup.KanjouMototyouPrinntPopup.TargetKamokuTypeEnum.Range) {
                if (popup.KamokuTopCode == null || popup.KamokuBottomCode == null) {
                    helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidKamoku);
                    return false;
                }
            }

            return true;
        }


        private int kamokuCode2KanjouKamokuId(string code) {
            models.db.Row kamokuRow = context.KaikeiDatabase.MTKanjouKamoku.GetRowFromCodeCache(-1, code);
            if (kamokuRow == null) {
                return -1;
            }
            return (int)kamokuRow.GetLong("id", -1);
        }


        private int hojoSeiri2KanjouKamokuId(string seiri, int parentKanjouKamokuId) {
            models.db.Row hojoRow = context.KaikeiDatabase.MTKanjouKamoku.GetRowFromCodeCacheByTopParent(parentKanjouKamokuId, seiri);
            if (hojoRow == null) {
                return -1;
            }

            return (int)hojoRow.GetLong("id", -1);
        }


        private void PrintButtonClicked() {
            if (!CheckParameter()) {
                return;
            }

            // 伝票番号を振りなおす
            if(popup.DenpyouSeiriChecked){
                context.KaikeiDatabase.KaikeiDenpyouMeisai.RenumberDenpyouBangouRange(popup.StartDate.Value, popup.EndDate.Value);
            }

            DataDynamics.ActiveReports.ActiveReport report = new DataDynamics.ActiveReports.ActiveReport();

            if (popup.TargetKamokuType == views.popup.KanjouMototyouPrinntPopup.TargetKamokuTypeEnum.Selected) {
                int kanjouKamokuId = kamokuCode2KanjouKamokuId(popup.TargetKamokuCode);
                if (popup.DontPrintKanjouMototyouChecked == false) {
                    AddMototyouReport(report, kanjouKamokuId, -1, isHojoKamoku: false);
                }

                if (popup.PrintHojoMototyouChecked) {
                    int hojoKamokuId = hojoSeiri2KanjouKamokuId(popup.TargetHojoKamokuSeiri, kanjouKamokuId);
                    AddMototyouReport(report, hojoKamokuId, kanjouKamokuId, isHojoKamoku: true);
                }
            }
            else {
                string sql = "where usable <> 0 and hierarchy=" + (int)models.constants.MTKanjouKamokuHierarchy.ChuuKubun;

                if(popup.TargetKamokuType == views.popup.KanjouMototyouPrinntPopup.TargetKamokuTypeEnum.Range){
                    sql += " and kamoku_code >= '" + popup.KamokuTopCode + "'" +
                            "and kamoku_code <= '" + popup.KamokuBottomCode + "'";
                }

                sql += " order by kamoku_code";

                foreach (var kanjouKamokuRow in context.KaikeiDatabase.MTKanjouKamoku.Select(sql)) {
                    AddMototyouReport(report, kanjouKamokuRow.GetId(), -1, isHojoKamoku: false);
                }
            }

            var reportPopup = new views.popup.ReportPreviewPopup();
            reportPopup.Document = report.Document;
            reportPopup.ShowDialog();
        }


        private void AddMototyouReport(DataDynamics.ActiveReports.ActiveReport parentReport, int kanjouKamokuId, int parentKamokuId, bool isHojoKamoku) {
            models.query.KanjouMototyou mototyou = new models.query.KanjouMototyou(context.KaikeiDatabase);
            mototyou.Calc(
                popup.StartDate.Value,
                popup.EndDate.Value,
                kanjouKamokuId,
                popup.TargetKaikeiKubun,
                renumberDenpyouBangou: false,
                isHojoKamoku: isHojoKamoku);

            int kaikeiKubun = popup.TargetKaikeiKubun;
            string houjinMei = context.KaikeiDatabase.MTKaikeiKubun.GetRowFromCache(context.KaikeiDatabase.MTKaikeiKubun.RootNodeId).GetStr("name") as string;
            string shisetsuMei = "";
            if(kaikeiKubun != -1 && kaikeiKubun != context.KaikeiDatabase.MTKaikeiKubun.RootNodeId) {
                shisetsuMei = context.KaikeiDatabase.MTKaikeiKubun.GetRowFromCache(kaikeiKubun).GetStr("name") as string;
            }
            models.db.Row kanjouKamokuRow = context.KaikeiDatabase.MTKanjouKamoku.GetFirstRow("where id=" + kanjouKamokuId);
            string kamokuMei = kanjouKamokuRow.GetStr("kamoku", "");

            DataDynamics.ActiveReports.ActiveReport report = null;
            if (popup.RenzokuKeishikiChecked) {
                report = new views.reports.KanjouMototyou2();
                if (isHojoKamoku == false) {
                    (report as views.reports.KanjouMototyou2).SetHeader(houjinMei, shisetsuMei, kamokuMei, "", isHojoMototyou: false);
                }
                else {
                    models.db.Row parentKanjouKamokuRow = context.KaikeiDatabase.MTKanjouKamoku.GetFirstRow("where id=" + parentKamokuId);
                    string parentKamokuMei = parentKanjouKamokuRow.GetStr("kamoku", "");
                    (report as views.reports.KanjouMototyou2).SetHeader(houjinMei, shisetsuMei, parentKamokuMei, kamokuMei, isHojoMototyou: true);
                }
            }
            else {
                report = new views.reports.KanjouMototyou();
                (report as views.reports.KanjouMototyou).SetHeader(houjinMei, shisetsuMei, kamokuMei);
            }

            bool printReport = false;

            if (mototyou.MototyouRows.Count > 0) {
                report.DataSource = mototyou.MototyouRows;
                printReport = true;
            }
            else if(mototyou.ZengetsuKurikoshiGaku != 0){
                // 伝票がない場合、前期繰越の額を印刷する。
                List<models.query.KanjouMototyou.MototyouRow> rows = new List<models.query.KanjouMototyou.MototyouRow>();
                int taisyakuKubunId = (int)kanjouKamokuRow.GetLong("taisyaku_kubun_id", -1);

                long karikataKingaku = 0;
                long kashikataKingaku = 0;

                switch((models.constants.MTTaisyakuKubun)taisyakuKubunId){
                    case models.constants.MTTaisyakuKubun.KariPlus:
                    case models.constants.MTTaisyakuKubun.KariMinus:
                        karikataKingaku = mototyou.ZengetsuKurikoshiGaku;
                        break;

                    case models.constants.MTTaisyakuKubun.KashiPlus:
                    case models.constants.MTTaisyakuKubun.KashiMinus:
                        kashikataKingaku = mototyou.ZengetsuKurikoshiGaku;
                        break;
                }

                var row = new models.query.KanjouMototyou.MototyouRow(
                    -1,
                    "",
                    -1,
                    DateTime.Now,
                    "",
                    "",
                    karikataKingaku,
                    kashikataKingaku,
                    mototyou.ZengetsuKurikoshiGaku,
                    null,
                    false,
                    mototyou.ZengetsuKurikoshiGaku
                );
                rows.Add(row);

                if (popup.RenzokuKeishikiChecked) {
                    (report as views.reports.KanjouMototyou2).ZenkiKurikoshiOnly = true;
                }
                else {
                    (report as views.reports.KanjouMototyou).ZenkiKurikoshiOnly = true;
                }
                report.DataSource = rows;

                printReport = true;
            }

            if (printReport) {
                report.Run();
                parentReport.Document.Pages.AddRange(report.Document.Pages.GetRange(0, report.Document.Pages.Count));
            }
        }
    }
}
