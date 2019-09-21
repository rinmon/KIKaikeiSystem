using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class KaikeiDenpyouFormController : AbstractActivity
    {
        public enum QueryType {
            None,
            All,
            CurrentYear,
            InvalidRows,
            EditingRows
        }

        private KaikeiSystemBody.views.KaikeiDenpyouForm form_;
        private grid.DBPanelGridController<views.grid.KaikeiDenpyouRow> gridController;
        private popup.KamokuPopupController kamokuPopupControlelr;
        private popup.HojoKamokuPopupController hojoKamokuPopupController;
        private popup.TekiyouPopupController tekiyouPopupController;
        private popup.DenpyouBangouSeiriPopupController denpyouBangouSeiriPopupController;
        private popup.SubfunctionPopupController subfunctionPopupController;
        private popup.IkkatsuSyoriPopupController ikkatsuSyoriPopupController;

        private int insertCt;
        private QueryType queryType;
        private string sql_;
        private bool kessanSyuuryouChkIsVisible;


        public KaikeiDenpyouFormController(){
            form_ = new views.KaikeiDenpyouForm();
            form_.ReturnToMenuButtonClicked += () => MainController.PopActivity();
            form_.ShowAllDataButtonClicked += () => ChangeQuery(QueryType.All, null);
            form_.ShowCurrentYearButtonClicked += () => ChangeQuery(QueryType.CurrentYear, null);
            form_.ToggleInvalidDataButtonClicked += delegate() {
                if (queryType == QueryType.InvalidRows) {
                    ChangeQuery(QueryType.CurrentYear, null);
                }
                else {
                    ChangeQuery(QueryType.InvalidRows, null);
                }
            };
            form_.NewRowButtonClicked += () => form_.Grid.SelectBottomRow();
            form_.CopyCommentCalled += Row_CopyComment;
            form_.CopyKarikataCalled += Row_CopyKarikata;
            form_.CopyKashikataCalled += Row_CopyKashikata;
            form_.CopyRowCalled += Row_CopyRow;
            form_.SetStatusMessage += SetStatusMessage;
            form_.ShowKamokuPopupButtonClicked += ShowKamokuPopup;
            form_.ShowTekiyouPopupButtonClicked += ShowTekiyouPopup;
            form_.ShowSubfunctionPopupButtonClicked += ShowSubfunctionPopup;

            queryType = QueryType.None;
            sql_ = "";

            gridController = new grid.DBPanelGridController<views.grid.KaikeiDenpyouRow>(form_.Grid, true);

            gridController.InitInsertedRow += Grid_InitInsertedRow;
            gridController.ValidateColumnValue += Grid_ValidateColumnValue;
            gridController.Column_LostFocusAction += Column_LostFocus;
            gridController.ValidateRowValue += Grid_ValidateRowValue;
            gridController.SetStatusMessage += SetStatusMessage;
            gridController.RowClicked += RowClicked;
            gridController.RowUpdated += Grid_RowUpdated;
            gridController.RowDeleted += Grid_RowDeleted;

            kamokuPopupControlelr = new popup.KamokuPopupController();
            kamokuPopupControlelr.RowClicked += this.KamokuPopupGridRowClicked;
            hojoKamokuPopupController = new popup.HojoKamokuPopupController();
            hojoKamokuPopupController.RowClicked += this.HojoKamokuPopupGridRowClicked;
            kamokuPopupControlelr.HojoKamokuController = hojoKamokuPopupController;
            tekiyouPopupController = new popup.TekiyouPopupController();
            tekiyouPopupController.RowClicked += TekiyouPopupGridRowClicked;
            subfunctionPopupController = new popup.SubfunctionPopupController();
            denpyouBangouSeiriPopupController = new popup.DenpyouBangouSeiriPopupController();
            denpyouBangouSeiriPopupController.DenpyouBangouUpdated += () => this.gridController.Refresh();
            denpyouBangouSeiriPopupController.ReturnToSubfunctionPopup += () => this.ShowSubfunctionPopup();
            ikkatsuSyoriPopupController = new popup.IkkatsuSyoriPopupController();
            ikkatsuSyoriPopupController.DenpyouInerted += () => this.ChangeQuery(queryType, "1=1");

            kessanSyuuryouChkIsVisible = true;
            ChangeKessanSyuuryouChkVisibility();
        }


        private void ChangeQuery(QueryType query, string filter) {
            if (queryType == query && filter == null) {
                return;
            }
            queryType = query;
            if (query == QueryType.None) {
                return;
            }

            (gridController.DBTable as models.db.tables.KaikeiDenpyouMeisai).UpdateEditingRows();
            insertCt = 0;

            var sql = "where (1=1)";
            if (query == QueryType.All) {
            }
            else if (query == QueryType.CurrentYear || query == QueryType.InvalidRows) {
                var kisanbi = Context.Setting.GetStr("nenndo_kisanbi", "");
                if (kisanbi != "" && helper.Converter.IsDateStr(kisanbi)) {
                    int kisaibi_int = helper.Converter.DateTimeToInt(helper.Converter.DateStrToDateTime(kisanbi));
                    if (query == QueryType.CurrentYear) {
                        sql += "and (kihyoubi >= " + kisaibi_int.ToString() + " or editing <> 0)";
                    }
                    else {
                        sql += " and ((kihyoubi >= " + kisaibi_int.ToString() +
                            " and ( karikata_kamoku_id is null or kashikata_kamoku_id is null or karikata_kingaku is null))" +
                            " or editing <> 0)";
                    }
                }
            }
            else if(query == QueryType.EditingRows){
                sql += " and (editing <> 0)";
            }

            if (filter != null) {
                sql += " and (" + filter + ")";
            }


            sql += " order by denpyou_bangou";

            form_.ShowInvalidRowButtonChecked = false;
            form_.ShowAllDataButtonChecked = false;
            form_.ShowCurrentYearDataChecked = false;
            if (query == QueryType.CurrentYear) {
                form_.ShowCurrentYearDataChecked = true;
            }
            else if (query == QueryType.All) {
                form_.ShowAllDataButtonChecked = true;
            }
            else if (query == QueryType.InvalidRows) {
                form_.ShowInvalidRowButtonChecked = true;
            }

            gridController.SetQuery(sql);
            gridController.SetFocus(0, "kihyoubi_gengou");
            sql_ = sql;
        }


        protected override void OnActivated(object option) {
            base.OnActivated(option);

            form_.SetMasterTables(Context.KaikeiDatabase);
            form_.SetSettingValues(Context.Setting, Context.KaikeiDatabase);
            gridController.SetTable(Context.KaikeiDatabase.KaikeiDenpyouMeisai);
            kamokuPopupControlelr.Context = Context;
            hojoKamokuPopupController.Context = Context;
            tekiyouPopupController.Context = Context;
            subfunctionPopupController.Context = Context;
            denpyouBangouSeiriPopupController.Context = Context;
            ikkatsuSyoriPopupController.Context = Context;

            form_.IdLableVisible = false;
            form_.UpdateDateLableVisible = false;
            form_.CreateDateLableVisible = false;
            foreach (var rowControl in form_.Grid.AllRowControls()) {
                rowControl.IdIsVisible = false;
                rowControl.UpdateDateIsVisible = false;
                rowControl.CreateDateIsVisible = false;
            } 
            
            queryType = QueryType.None;
            if (option != null) {
                ChangeQuery((QueryType)option, null);
            }
            else {
                ChangeQuery(QueryType.CurrentYear, null);
            }
        }


        protected override void OnDeactivated() {
            base.OnDeactivated();

            if(helper.Converter.IsDateStr(form_.HeaderKihyoubiGengouText +
                                            form_.HeaderKihyoubiYearText + "/" +
                                            form_.HeaderKihyoubiMonthText + "/" +
                                            form_.HeaderKihyoubiDayText)){
                Context.Setting.SetStr("before_gengou", form_.HeaderKihyoubiGengouText);
                Context.Setting.SetStr("before_year", form_.HeaderKihyoubiYearText);
                Context.Setting.SetStr("before_month", form_.HeaderKihyoubiMonthText);
                Context.Setting.SetStr("before_day", form_.HeaderKihyoubiDayText);
            }
            Context.Setting.SetStr("before_torihiki_kubun", form_.HeaderTorihikiKubun.ToString());
            Context.Setting.SetStr("nyuuryoku_basyo", form_.HeaderKaikeiKubun.ToString());

            kamokuPopupControlelr.ClosePopup();
            hojoKamokuPopupController.ClosePopup();
            tekiyouPopupController.ClosePopup();
            denpyouBangouSeiriPopupController.ClosePopup();
        }


        public override Form Form {
            get { return form_; }
        }


        private void CopyRowFromUpperRow(string focus_control, params string[] copy_columns) {
            if (form_.Grid.LastSelectedRowNo <= 0) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgFailedToCopyUpperRow);
                return;
            }

            var current_row_no = form_.Grid.SelectedRowNo;

            if (current_row_no >= form_.Grid.DataCount) {
                gridController.InsertNewRowToLast(false);
            }

            form_.Grid.SetFocus(form_.Grid.LastSelectedRowNo, focus_control);
            //form_.Grid.SelectedRowControl.SetFocusToControlByTag(focus_control);

            var rows = Context.KaikeiDatabase.KaikeiDenpyouMeisai.Select(sql_ + " limit 1 offset " + (current_row_no - 1).ToString());
            if (rows.Count() == 1) {
                var selected_row_control = form_.Grid.SelectedRowControl;
                var src_row = rows.First();
                var dst_row = selected_row_control.RowData;

                foreach (var column in copy_columns) {
                    dst_row.Set(column, src_row.Get(column));
                }
                //Context.KaikeiDatabase.KaikeiDenpyouMeisai.Update(dst_row);
                selected_row_control.SetRowData(dst_row, true);
            }
        }


        // events

        private void KamokuPopupGridRowClicked(string key) {
            if (key == null) {
                return;
            }
            if (form_.Grid.SelectedRowControl == null) {
                return;
            }

            var control = form_.Grid.SelectedRowControl.LastFocusedControl;
            string control_tag = control.Tag as string;
            if (control_tag == "kashikata_kamoku_code" || control_tag == "karikata_kamoku_code") {
                form_.Grid.SelectedRowControl.SetControlValue(control_tag, key);
                form_.Grid.SelectedRowControl.SetFocusToControlByTag(control_tag);
            }
        }

        private void HojoKamokuPopupGridRowClicked(string key) {
            if (key == null) {
                return;
            }
            if (form_.Grid.SelectedRowControl == null) {
                return;
            }
            var control = form_.Grid.SelectedRowControl.LastFocusedControl;
            string control_tag = control.Tag as string;
            if (control_tag == "karikata_hojo_seiri" || control_tag == "kashikata_hojo_seiri") {
                form_.Grid.SelectedRowControl.SetControlValue(control_tag, key);
                form_.Grid.SelectedRowControl.SetFocusToControlByTag(control_tag);
            }
        }

        private void TekiyouPopupGridRowClicked(string key) {
            if (key == null) {
                return;
            }
            if (form_.Grid.SelectedRowControl == null) {
                return;
            }

            var control = form_.Grid.SelectedRowControl.LastFocusedControl;
            string control_tag = control.Tag as string;
            if (control_tag == "tekiyou_id") {
                form_.Grid.SelectedRowControl.SetControlValue(control_tag, key);
                form_.Grid.SelectedRowControl.SetFocusToControlByTag("comment");
            }
        }

        private void SetStatusMessage(string msg) {
            form_.StatusMessage = msg;
        }

        private void Row_CopyKarikata() {
            CopyRowFromUpperRow("karikata_hojo_seiri",
                "karikata_kamoku_id", "karikata_kamoku_code", "karikata_hojo_id", "karikata_hojo_seiri");
        }

        private void Row_CopyKashikata() {
            CopyRowFromUpperRow("kashikata_hojo_seiri",
                "kashikata_kamoku_id", "kashikata_kamoku_code", "kashikata_hojo_id", "kashikata_hojo_seiri");
        }

        private void Row_CopyComment() {
            CopyRowFromUpperRow("comment",
                "tekiyou_id", "comment");
        }

        private void Row_CopyRow() {
            CopyRowFromUpperRow("karikata_kingaku",
                "karikata_kamoku_id", "karikata_kamoku_code", "karikata_hojo_id", "karikata_hojo_seiri",
            "kashikata_kamoku_id", "kashikata_kamoku_code", "kashikata_hojo_id", "kashikata_hojo_seiri");
        }

        private void RowClicked(views.grid.KaikeiDenpyouRow sender) {
            kessanSyuuryouChkIsVisible = !kessanSyuuryouChkIsVisible;
            ChangeKessanSyuuryouChkVisibility();
            //sender.SetFocusToControlByTag("karikata_kingaku");
        }

        private void ChangeKessanSyuuryouChkVisibility() {
            foreach (var row in form_.Grid.AllRowControls()) {
                row.ChangeKessanSyuuryouCheckBoxVisibility(kessanSyuuryouChkIsVisible);
            }
        }

        private void ShowKamokuPopup() {
            kamokuPopupControlelr.ShowPopup(form_);
        }

        private void ShowTekiyouPopup() {
            tekiyouPopupController.ShowPopup(form_);
        }

        private void ShowSubfunctionPopup() {
            subfunctionPopupController.ShowPopupModal(form_);

            if (subfunctionPopupController.MoveToTopSelected) {
                form_.Grid.SetFocus(0, "kihyoubi_gengou");
            }
            else if (subfunctionPopupController.MoveToEndSelected) {
                form_.Grid.SetFocus(Math.Max(form_.Grid.DataCount - 1, 0), "kihyoubi_gengou");
            }

            form_.IdLableVisible = subfunctionPopupController.ShowRowIdSelected;
            form_.UpdateDateLableVisible = subfunctionPopupController.ShowRowUpdateDateSelected;
            form_.CreateDateLableVisible = subfunctionPopupController.ShowRowCreateDateSelected;
            foreach (var rowControl in form_.Grid.AllRowControls()) {
                rowControl.IdIsVisible = subfunctionPopupController.ShowRowIdSelected;
                rowControl.UpdateDateIsVisible = subfunctionPopupController.ShowRowUpdateDateSelected;
                rowControl.CreateDateIsVisible = subfunctionPopupController.ShowRowCreateDateSelected;
            }

            if (subfunctionPopupController.FilterSql != null) {
                ChangeQuery(this.queryType, "(" + subfunctionPopupController.FilterSql + ") or (editing <> 0)");
            }

            if (subfunctionPopupController.ShowDenpyouBangouSeiriPopupSelected) {
                denpyouBangouSeiriPopupController.ShowPopup(form_);
            }

            if (subfunctionPopupController.ShowIkkatsuSyoriPopupSelected) {
                ikkatsuSyoriPopupController.ShowPopupModal(form_);
            }
        }


        private string EditingDenpyouBangou() {
            return String.Format("{0}{1:00}{2:00}-{3:0000}", "Z", 99, 99, insertCt);
        }


        // 行の変更内容の有効性をチェック
        private bool Grid_ValidateRowValue(views.grid.AbstractDBGridRow rowControl) {
            models.db.Row row = rowControl.RowData;

            if (!row.GetBool("kessan_syuuryou", false)) {
                return true;
            }
            else {
                gridController.ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgKessanSyuuryou, "warn", null);
                return false;
            }
        }


        private void Grid_RowUpdated(views.grid.AbstractDBGridRow rowControl) {
            models.db.Row row = rowControl.RowData;

            models.db.tables.KaikeiDenpyouMeisai.UpdateMeisaiGroupResult result;
            result = Context.KaikeiDatabase.KaikeiDenpyouMeisai.UpdateMeisaiGroup(row, EditingDenpyouBangou());

            if (result != models.db.tables.KaikeiDenpyouMeisai.UpdateMeisaiGroupResult.None) {
                gridController.UpdateDataCount();
                gridController.Refresh();
            }
            if (result == models.db.tables.KaikeiDenpyouMeisai.UpdateMeisaiGroupResult.Inserted) {
                insertCt++;
            }
        }


        private void Grid_RowDeleted(models.db.Row deletedRow) {
            Context.KaikeiDatabase.KaikeiDenpyouMeisai.DeleteMeisaiGroup(deletedRow);
        }


        private void Grid_InitInsertedRow(models.db.Row row) {
            string gengou = form_.HeaderKihyoubiGengouText;
            string year = form_.HeaderKihyoubiYearText;
            string month = form_.HeaderKihyoubiMonthText;
            string day = form_.HeaderKihyoubiDayText;
            string wareki = gengou + year + "/" + month + "/" + day;

            if (!helper.Converter.IsWareki(wareki)) {
                row.Set("kihyoubi", null);
                row.Set("kihyoubi_gengou", null);
                row.Set("kihyoubi_year", null);
                row.Set("kihyoubi_month", null);
                row.Set("kihyoubi_day", null);
            }
            else {
                DateTime date = helper.Converter.DateStrToDateTime(wareki);
                (gridController.DBTable as models.db.tables.KaikeiDenpyouMeisai).SetKihyoubiAndDenpyouBangouCache(row, date);
            }
            // 新規追加行を最後尾に表示
            insertCt++;
            row.Set("denpyou_bangou", EditingDenpyouBangou());

            row.Set("torihiki_kubun", form_.HeaderTorihikiKubun);
            row.Set("kaikei_kubun", form_.HeaderKaikeiKubun);
            row.Set("editing", true);
            row.Set("karikata_hojo_seiri", 0);
            row.Set("karikata_hojo_id", 0);
            row.Set("kashikata_hojo_seiri", 0);
            row.Set("kashikata_hojo_id", 0);
        }


        private void Column_LostFocus(views.grid.AbstractDBGridRow row_control, string column){
            var row = row_control.RowData;
            if (column == "karikata_kingaku") {
                if (models.Validator.CheckHojoKamokuIsLacking(Context.KaikeiDatabase, row, models.constants.Taisyaku.Karikata)) {
                    gridController.ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgNoKarikataHojoSeiri, "warn", "karikata_hojo_seiri");
                }
                else if (models.Validator.CheckHojoKamokuIsLacking(Context.KaikeiDatabase, row, models.constants.Taisyaku.Kashikata)) {
                    gridController.ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgNoKashikataHojoSeiri, "warn", "kashikata_hojo_seiri");
                }

                // ライセンスチェックは起動時に行う
                /*if(!models.Validator.CheckKihyoubiIsInLisenceDate(Context.KaikeiDatabase, row)){
                    helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgLicenseError);
                    MainController.ExitApplication();
                }*/
            }
        }


        private void Grid_ValidateColumnValue(views.grid.AbstractDBGridRow row_control, string column, object value) {
            var row = row_control.RowData;
            var db = Context.KaikeiDatabase;

            switch (column) {
                case "kaikei_kubun":
                    ValidateKaikeiKubun(row_control, column);
                    ValidateKarikataHojoSeiri(db, row, kamokuCheck: false);
                    ValidateKashikataHojoSeiri(db, row, kamokuCheck: false);
                    break;
                case "karikata_hojo_seiri":     ValidateKarikataHojoSeiri(db, row); break;
                case "kashikata_hojo_seiri":    ValidateKashikataHojoSeiri(db, row); break;
                case "karikata_kingaku":        ValidateKarikataKingaku(db, row); break;
                case "karikata_kamoku_code":    ValidateKamokuCode(db, row, models.constants.Taisyaku.Karikata); break;
                case "kashikata_kamoku_code":   ValidateKamokuCode(db, row, models.constants.Taisyaku.Kashikata); break;
                case "kihyoubi_gengou":         ValidateKihyoubi(db, row); break;
                case "kihyoubi_year":           ValidateKihyoubi(db, row); break;
                case "kihyoubi_month":          ValidateKihyoubi(db, row); break;
                case "kihyoubi_day":            ValidateKihyoubi(db, row); break;
                case "tekiyou_id":              db.KaikeiDenpyouMeisai.UpdateCommentWithTekiyou(row); break;
            }
        }


        // Valite

        private void ValidateKaikeiKubun(views.grid.AbstractDBGridRow row_control, string column) {
            form_.HeaderKaikeiKubun = (int)row_control.RowData.GetLong("kaikei_kubun", -1);
        }


        private void ValidateKarikataHojoSeiri(models.db.KaikeiDatabase db, models.db.Row row, bool kamokuCheck=true) {
            if (kamokuCheck && !models.Validator.CheckHojoSeiriIsFitInKamokuCode(db, row, models.constants.Taisyaku.Karikata)) {
                gridController.ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgHojoSeiriNotFound, "warn", "karikata_hojo_seiri");
            }
            else if (!models.Validator.CheckHojoSeiriIsFitInKaikeiKubun(db, row, models.constants.Taisyaku.Karikata)) {
                gridController.ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgInvaidHojoSeiri, "warn", "karikata_hojo_seiri");
            }
        }


        private void ValidateKashikataHojoSeiri(models.db.KaikeiDatabase db, models.db.Row row, bool kamokuCheck=true) {
            if (kamokuCheck && !models.Validator.CheckHojoSeiriIsFitInKamokuCode(db, row, models.constants.Taisyaku.Kashikata)) {
                gridController.ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgHojoSeiriNotFound, "warn", "kashikata_hojo_seiri");
            }
            else if (!models.Validator.CheckHojoSeiriIsFitInKaikeiKubun(db, row, models.constants.Taisyaku.Kashikata)) {
                gridController.ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgInvaidHojoSeiri, "warn", "kashikata_hojo_seiri");
            }
        }


        private void ValidateKarikataKingaku(models.db.KaikeiDatabase db, models.db.Row row) {
            if (row.IsNull("karikata_kingaku")) {
                db.KaikeiDenpyouMeisai.SetColumnValue(row, "karikata_kingaku", 0);
            }
            if (!models.Validator.CheckKamokuCodeIsNotNull(db, row, models.constants.Taisyaku.Karikata)) {
                gridController.ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgNoKarikataKamokuCode, "warn", "karikata_kamoku_code");
            }
            else if (!models.Validator.CheckKamokuCodeFormatIsValid(db, row, models.constants.Taisyaku.Karikata)) {
                gridController.ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgInvalidKarikataKamokuCode, "warn", "karikata_kamoku_code");
            }
            else if (!models.Validator.CheckKamokuCodeIsNotNull(db, row, models.constants.Taisyaku.Kashikata)) {
                gridController.ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgNoKarikataKamokuCode, "warn", "kashikata_kamoku_code");
            }
            else if (!models.Validator.CheckKamokuCodeFormatIsValid(db, row, models.constants.Taisyaku.Kashikata)) {
                gridController.ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgInvalidKarikataKamokuCode, "warn", "kashikata_kamoku_code");
            }
        }


        private void ValidateKamokuCode(models.db.KaikeiDatabase db, models.db.Row row, models.constants.Taisyaku taisyaku) {
/*            if(models.Validator.IsHurikaeTaisyouKamokuCode(db, row, taisyaku)){
                gridController.ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgHurikaeTaisyouKamoku, "warn", null);
            }
*/
            if (!models.Validator.IsUseableKamokuCode(db, row, taisyaku)) {
                gridController.ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgShiyouKubun, "warn", null);
            }
        }


        private void ValidateKihyoubi(models.db.KaikeiDatabase db, models.db.Row row) {
            form_.HeaderKihyoubiGengouText = row.GetStr("kihyoubi_gengou", "");
            form_.HeaderKihyoubiYearText = row.GetStr("kihyoubi_year", "");
            form_.HeaderKihyoubiMonthText = row.GetStr("kihyoubi_month", "");
            form_.HeaderKihyoubiDayText = row.GetStr("kihyoubi_day", "");

            if (!models.Validator.CheckKihyoubiFormatIsValid(db, row)) {
                gridController.ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgInvalidDate, "warn", null);
            }
            else if (!models.Validator.CheckKihyoubiIsInNendoKisanbi(db, row)) {
                gridController.ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgKihyoubiOutOfRange, "warn", null);
            }
        }

    }
}
