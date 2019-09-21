using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class YosanFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.YosanForm form;
        private misc.FocusController focusController;
        private popup.YosanKamokuKubunPopupController<views.grid.YosanKamokuDaikubunRow> daikubunPopupController;
        private popup.YosanKamokuKubunPopupController<views.grid.YosanKamokuKubunRow> chukubunPopupController;
        private popup.YosanKamokuKubunPopupController<views.grid.YosanKamokuKubunRow> syoukubunPopupController;
        private popup.YosanKamokuKubunPopupController<views.grid.YosanKamokuKubunRow> hojoPopupController;
        private popup.YosanYobihiPopupController yobihiPopupController;
        private popup.YosanYobihiKakuninPopupController yobihiKakuninPopupController;
        private popup.YosanKakuninPopupController yosanKakuninPopupController;
        private popup.YosanListPopupController yosanListPopupController;

        private popup.KamokuPopupController kamokuListPopupController;
        private popup.HojoKamokuPopupController hojoKamokuListPopupController;

        private models.query.KamokuKubunSummary kamokuKubunSummary;


        public YosanFormController() {
            form = new KaikeiSystemBody.views.YosanForm();
            form.SearchButtonClicked += SearchButtonClicked;
            form.DataCheckButtonClicked += DataCheckButtonClicked;
            form.YosanListButtonClicked += YosanListButtonClicked;
            form.NewButtonClicked += NewButtonClicked;
            form.HikitsugiButtonClicked += HikitsugiButtonClicked;
            form.DeleteButtonClicked += DeleteButtonClicked;
            form.RedrawButtonClicked += SearchButtonClicked;
            form.CloseButtonClicked += () => MainController.PopActivity();
            form.ShowKamokuPopupButtonClicked += delegate() {
                kamokuListPopupController.ShowPopup(form);
            };
            form.CompareButtonClicked += delegate() {
                this.MainController.SwitchActivity(
                    controllers.MainController.ActivityType.YosanJisseki,
                    controllers.MainController.ActivitySwitchMethod.Change,
                    this.Context,
                    null
                );
            };

            form.PrintButtonClicked += delegate() {
                this.MainController.SwitchActivity(
                    controllers.MainController.ActivityType.PrintYosan,
                    controllers.MainController.ActivitySwitchMethod.PushModal,
                    this.Context,
                    null
                );
            };

            daikubunPopupController = new popup.YosanKamokuKubunPopupController<views.grid.YosanKamokuDaikubunRow>();
            chukubunPopupController = new popup.YosanKamokuKubunPopupController<views.grid.YosanKamokuKubunRow>();
            syoukubunPopupController = new popup.YosanKamokuKubunPopupController<views.grid.YosanKamokuKubunRow>();
            hojoPopupController = new popup.YosanKamokuKubunPopupController<views.grid.YosanKamokuKubunRow>();
            yobihiPopupController = new popup.YosanYobihiPopupController();
            yobihiKakuninPopupController = new popup.YosanYobihiKakuninPopupController();
            yosanKakuninPopupController = new popup.YosanKakuninPopupController();
            yosanListPopupController = new popup.YosanListPopupController();

            kamokuListPopupController = new popup.KamokuPopupController();
            hojoKamokuListPopupController = new popup.HojoKamokuPopupController();
            kamokuListPopupController.HojoKamokuController = hojoKamokuListPopupController;
            
            focusController = new misc.FocusController(form);

            daikubunPopupController.RowSelectionChanged += DaikubunRowSelectionChanged;
            chukubunPopupController.RowSelectionChanged += ChukubunRowSelectionChanged;
            syoukubunPopupController.RowSelectionChanged += SyoukubunRowSelectionChanged;
            hojoPopupController.RowSelectionChanged += HojokamokuRowSelectionChanged;
            chukubunPopupController.SumAmountIsChanged += ChukubunSumAmountChanged;
            syoukubunPopupController.SumAmountIsChanged += SyoukubunSumAmountChanged;
            hojoPopupController.SumAmountIsChanged += HojoSumAmountChanged;

            yobihiPopupController.CheckDataButtonClicked += delegate(object sender, EventArgs e){
                yobihiKakuninPopupController.ShowPopup(form);
                yobihiKakuninPopupController.SetQueryCondition(form.Year, form.KaikeiKubun, form.YosanKubun, form.HoseiKaisuu);
            };

            yosanListPopupController.ShowButtonClicked += delegate(int nenndo, int kaikeiKubun, int yosanKubun, int hoseiKaisuu) {
                form.Year = nenndo;
                form.KaikeiKubun = kaikeiKubun;
                form.YosanKubun = yosanKubun;
                form.HoseiKaisuu = hoseiKaisuu;
                SearchButtonClicked();
            };
        }


        public override Form Form {
            get {
                return form;
            }
        }


        override protected void OnActivated(object option) {
            form.SetDatabase(Context.KaikeiDatabase);
            form.SetGengou(Context.Setting.GetStr("before_gengou", ""));
            form.HoseiKaisuu = 0;
            daikubunPopupController.Context = Context;
            chukubunPopupController.Context = Context;
            syoukubunPopupController.Context = Context;
            hojoPopupController.Context = Context;
            yobihiPopupController.Context = Context;
            yobihiKakuninPopupController.Context = Context;
            yosanKakuninPopupController.Context = Context;
            yosanListPopupController.Context = Context;
            kamokuListPopupController.Context = Context;
            hojoKamokuListPopupController.Context = Context;

            kamokuKubunSummary = new models.query.KamokuKubunSummary(Context.KaikeiDatabase);
        }

        override protected void OnDeactivated() {
            daikubunPopupController.ClosePopup();
            chukubunPopupController.ClosePopup();
            syoukubunPopupController.ClosePopup();
            hojoPopupController.ClosePopup();
            yobihiPopupController.ClosePopup();
            yobihiKakuninPopupController.ClosePopup();
            yosanKakuninPopupController.ClosePopup();
            yosanListPopupController.ClosePopup();
            kamokuListPopupController.ClosePopup();
            hojoKamokuListPopupController.ClosePopup();
        }


        private void UpdateDaikubunInfo() {
            var row = Context.KaikeiDatabase.MTKamokuKubun.GetRowFromCache(daikubunPopupController.SelectedKamokuKubunId);
            if (row != null) {
                form.SetSelectedDaikubunInfo(
                    row.GetStr("name"),
                    GetSumYosanOfKamokuKubun(form.KaikeiKubun, form.Year, daikubunPopupController.SelectedKamokuKubunId)//chukubunPopupController.SumYosan
                );
            }
            else {
                form.SetSelectedDaikubunInfo("", 0);
            }
        }


        private void UpdateChukubunInfo() {
            int kamokuKubunId = chukubunPopupController.SelectedKamokuKubunId;

            long yosan = GetYosanOfKamokuKubun(form.KaikeiKubun, form.Year, kamokuKubunId);//chukubunPopupController.SelectedYosan;
            long jisseki = kamokuKubunSummary.SummaryItem(kamokuKubunId).GetTaisyaku(Context.KaikeiDatabase);

            form.SetSelectedChukubunInfo(
                yosan,
                jisseki,
                yosan - jisseki
            );
        }


        private void UpdateSyoukubunInfo() {
            int kamokuKubunId = syoukubunPopupController.SelectedKamokuKubunId;

            long yosan = GetYosanOfKamokuKubun(form.KaikeiKubun, form.Year, kamokuKubunId);//syoukubunPopupController.SelectedYosan;
            long jisseki = kamokuKubunSummary.SummaryItem(kamokuKubunId).GetTaisyaku(Context.KaikeiDatabase);
            form.SetSelectedSyoukubunInfo(
                yosan,
                jisseki,
                yosan - jisseki
            );
        }


        private void DaikubunRowSelectionChanged() {
            chukubunPopupController.SetQueryCondition(daikubunPopupController.SelectedYosanId);
            syoukubunPopupController.SetQueryCondition(chukubunPopupController.SelectedYosanId);
            hojoPopupController.SetQueryCondition(syoukubunPopupController.SelectedYosanId);
            UpdateDaikubunInfo();
        }


        private void ChukubunRowSelectionChanged() {
            syoukubunPopupController.SetQueryCondition(chukubunPopupController.SelectedYosanId);
            hojoPopupController.SetQueryCondition(syoukubunPopupController.SelectedYosanId);
            UpdateChukubunInfo();
        }


        private void SyoukubunRowSelectionChanged() {
            hojoPopupController.SetQueryCondition(syoukubunPopupController.SelectedYosanId);
            UpdateSyoukubunInfo();
        }


        private void HojokamokuRowSelectionChanged() {
        }

        private void ChukubunSumAmountChanged() {
            UpdateDaikubunInfo();
            CalcSummaryInfo();
        }


        private void SyoukubunSumAmountChanged() {
            var row = chukubunPopupController.SelectedRow;
            if (row != null && syoukubunPopupController.DataCount > 0) {
                long yosan = syoukubunPopupController.SumYosan;
                row.Table.SetColumnValue(row, "yosan", yosan);
                row.Table.Update(row);
                chukubunPopupController.UpdateGrid();
            }
            chukubunPopupController.ChangeSumAmount();

            UpdateChukubunInfo();
            UpdateDaikubunInfo();
            CalcSummaryInfo();
        }

        private void HojoSumAmountChanged() {
            var row = syoukubunPopupController.SelectedRow;
            if (row != null && hojoPopupController.DataCount > 0) {
                long yosan = hojoPopupController.SumYosan;
                row.Table.SetColumnValue(row, "yosan", yosan);
                row.Table.Update(row);
                syoukubunPopupController.UpdateGrid();
            }
            syoukubunPopupController.ChangeSumAmount();

            UpdateSyoukubunInfo();
            UpdateChukubunInfo();
            UpdateDaikubunInfo();
            CalcSummaryInfo();
        }


        private void CalcSummaryInfo() {
            string range = string.Format(
                "where nenndo={0} and kaikei_kubun = {1} and hosei_kaisuu <= {2} ",
                form.Year,
                form.KaikeiKubun,
                form.HoseiKaisuu);

            long syuunyuu = 0;
            long shisyutsu = 0;

            foreach(var row in Context.KaikeiDatabase.YosanKamokuKubun.Select(range)){
                int kamokuKubunId = (int)(int)row.GetLong("kamoku_kubun_id", -1);
                models.db.Row kamokuRow = Context.KaikeiDatabase.MTKamokuKubun.GetRowFromCache(kamokuKubunId);
                if (kamokuRow == null || (int)kamokuRow.GetLong("hierarchy", -1) != (int)models.constants.MTKamokuKubunHierarchy.ChuuKubun) {
                    continue;
                }
                models.db.Row kanjouRow = Context.KaikeiDatabase.MTKanjouKamoku.GetRowFromCache((int)kamokuRow.GetLong("kanjou_kamoku_id", -1));
                if (kanjouRow == null || kanjouRow.GetBool("usable", false) == false) {
                    continue;
                }
                if (Context.KaikeiDatabase.MTKamokuKubun.IsSyuunyuuKamoku(kamokuKubunId)) {
                    syuunyuu += row.GetLong("yosan", 0);
                }
                else {
                    shisyutsu += row.GetLong("yosan", 0);
                }
            }
            long yobihi = Context.KaikeiDatabase.YosanYobihi.SelectSum("yobihi", range);
            long zandaka = Context.KaikeiDatabase.YosanYobihi.SelectSum("zenkimatsu_shiharai_shikin_zandaka", range);

            long sagaku = syuunyuu - shisyutsu - yobihi - zandaka;

            form.SetSummaryInfo(syuunyuu, shisyutsu, yobihi, zandaka, sagaku);
        }


        //パラメータの値が有効かチェック
        private bool CheckParameterValidity() {
            // 年度
            if (form.Year == -1) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidYear);
                return false;
            }

            // 会計区分
            if (form.KaikeiKubun == -1) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidKaikeiKubun);
                return false;
            }

            //予算区分
            if (form.YosanKubun == -1) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidYosanKubun);
                return false;
            }

            // 補正回数
            if (form.YosanKubun == (int)models.constants.MTYosanKubun.HoseiYosan && form.HoseiKaisuu <= 0) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidHoseiKaisuu);
                return false;
            }

            return true;
        }


        private int GetYosanRootId(int kaikeiKubun, int yosanKubun, int nenndo, int hoseiKaisuu) {
            string sql = string.Format(
                "where parent_id = {0} and kaikei_kubun = {1} and yosan_kubun = {2} and nenndo = {3} and hosei_kaisuu = {4}",
                -1, // root
                kaikeiKubun,
                yosanKubun,
                nenndo,
                hoseiKaisuu);

            var rows = Context.KaikeiDatabase.YosanKamokuKubun.Select(sql, 0, 1);

            if (rows.Count() > 0) {
                return (int)rows.First().GetLong("id", -1);
            }
            return -1;
        }

        private void SearchButtonClicked() {
            if (!CheckParameterValidity()) {
                return;
            }

            kamokuKubunSummary.Calc(
                helper.Helper.GetNenndoKisanbi(form.Year),
                helper.Helper.GetNenndoKimatsubi(form.Year),
                form.KaikeiKubun,
                addKurikoshi: false,
                addPairedShikinDenpyou: true
            );


            ConstructYosanKamoku(errWhenNotExist:true);

            ShowYosanKubunPopups();
        }

        private long GetYosanOfKamokuKubun(int kaikeiKubun, int year, int kamokuKubun) {
            string sql = string.Format(
                "where kaikei_kubun = {0} and nenndo = {1} and kamoku_kubun_id = {2}",
                kaikeiKubun,
                year,
                kamokuKubun);
            long sum = 0;

            foreach (var row in Context.KaikeiDatabase.YosanKamokuKubun.Select(sql)) {
                int kamokuKubunId = (int)(int)row.GetLong("kamoku_kubun_id", -1);
                models.db.Row kamokuRow = Context.KaikeiDatabase.MTKamokuKubun.GetRowFromCache(kamokuKubunId);
                models.db.Row kanjouRow = Context.KaikeiDatabase.MTKanjouKamoku.GetRowFromCache((int)kamokuRow.GetLong("kanjou_kamoku_id", -1));
                if (kanjouRow == null || kanjouRow.GetBool("usable", false) == false) {
                    continue;
                }
                sum += row.GetLong("yosan", 0);
            }

            return sum;
        }

        private long GetSumYosanOfKamokuKubun(int kaikeiKubun, int year, int parentKamokuKubun) {
            long sum = 0;

            foreach (var row in Context.KaikeiDatabase.MTKamokuKubun.SelectChildren(parentId: parentKamokuKubun)) {
                models.db.Row kanjouRow = Context.KaikeiDatabase.MTKanjouKamoku.GetRowFromCache((int)row.GetLong("kanjou_kamoku_id", -1));
                if (kanjouRow == null || kanjouRow.GetBool("usable", false) == false) {
                    continue;
                }
                sum += GetYosanOfKamokuKubun(kaikeiKubun, year, (int)row.GetLong("id", -1));
            }

            return sum;
        }

        private void ShowYosanKubunPopups() {
            int rootId = GetYosanRootId(form.KaikeiKubun, form.YosanKubun, form.Year, form.HoseiKaisuu);
            if (rootId == -1) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgYosanDataIsNotExist);
                return;
            }

            int hoseiKaisuuMax = Context.KaikeiDatabase.YosanKamokuKubun.GetMax("hosei_kaisuu", "where nenndo = " + form.Year);
            form.SetHoseiKaisuuMsg(form.Year, hoseiKaisuuMax);

            yosanKakuninPopupController.ClosePopup();
            yosanListPopupController.ClosePopup();

            System.Drawing.Rectangle daikubunBounds = form.DaikubunYosanBaseBounds;
            daikubunBounds.Location = form.PointToScreen(daikubunBounds.Location);
            daikubunPopupController.ShowPopup(form, daikubunBounds, "予算：大区分", daikubun: true, showUsableOnly: true, embedded: true);

            System.Drawing.Rectangle chukubunBounds = form.ChukubunYosanBaseBounds;
            chukubunBounds.Location = form.PointToScreen(chukubunBounds.Location);
            chukubunPopupController.ShowPopup(form, chukubunBounds, "予算：中区分", daikubun: false, showUsableOnly: true, embedded: true);

            System.Drawing.Rectangle syoukubunBounds = form.SyoukubunYosanBaseBounds;
            syoukubunBounds.Location = form.PointToScreen(syoukubunBounds.Location);
            syoukubunPopupController.ShowPopup(form, syoukubunBounds, "予算：小区分", daikubun: false, showUsableOnly: false, embedded: true);

            System.Drawing.Rectangle hojoBounds = form.HojoKamokuYosanBaseBounds;
            hojoBounds.Location = form.PointToScreen(hojoBounds.Location);
            hojoPopupController.ShowPopup(form, hojoBounds, "予算：補助科目", daikubun: false, showUsableOnly: false, embedded: true);

            System.Drawing.Point yobihiLocation = form.PointToScreen(form.YosanYobihiBaseLocation);
            yobihiPopupController.ShowPopup(form, yobihiLocation);

            daikubunPopupController.SetQueryCondition(rootId);
            //kamokuPopupController.SetQueryCondition(form.Year, form.KaikeiKubun, form.YosanKubun, form.HoseiKaisuu, daikubunPopupController.SelectedKamokuKubunId);
            //hojoPopupController.SetQueryCondition(form.Year, form.KaikeiKubun, form.YosanKubun, form.HoseiKaisuu, kamokuPopupController.SelectedKamokuId);
            yobihiPopupController.SetQueryCondition(form.Year, form.KaikeiKubun, form.YosanKubun, form.HoseiKaisuu);

            //shikinSyuushiTable.Calc(new DateTime(form.Year, 4, 1), new DateTime(form.Year + 1, 3, 31), form.KaikeiKubun, form.HoseiKaisuu);

            CalcSummaryInfo();
        }

        private void DataCheckButtonClicked() {
            daikubunPopupController.ClosePopup();
            chukubunPopupController.ClosePopup();
            syoukubunPopupController.ClosePopup();
            hojoPopupController.ClosePopup();
            yobihiPopupController.ClosePopup();
            yobihiKakuninPopupController.ClosePopup();

            yosanKakuninPopupController.ShowPopup(form);
            yosanKakuninPopupController.SetQueryConditionForHojo(true, 0, 0, 0);
            yosanKakuninPopupController.SetQueryConditionForKamoku(true, 0, 0, 0);
        }

        private void YosanListButtonClicked() {
            daikubunPopupController.ClosePopup();
            chukubunPopupController.ClosePopup();
            syoukubunPopupController.ClosePopup();
            hojoPopupController.ClosePopup();
            yobihiPopupController.ClosePopup();
            yobihiKakuninPopupController.ClosePopup();

            yosanListPopupController.ShowPopup(form);
        }


        private int AddNewYosanRow(int yosanKubun, int kaikeiKubun, int nenndo, int kamokuKubunId, int hoseiKaisuu, int parentId) {
            string sql = string.Format(
                "where parent_id={0} and nenndo={1} and kaikei_kubun={2} and yosan_kubun={3} and hosei_kaisuu={4} and kamoku_kubun_id={5}",
                parentId, nenndo, kaikeiKubun, yosanKubun, hoseiKaisuu, kamokuKubunId
                );
            var row = Context.KaikeiDatabase.YosanKamokuKubun.GetFirstRow(sql);

            if (row == null) {
                var newRow = Context.KaikeiDatabase.YosanKamokuKubun.NewRow();
                newRow.Set("yosan_kubun", yosanKubun);
                newRow.Set("kaikei_kubun", kaikeiKubun);
                newRow.Set("kamoku_kubun_id", kamokuKubunId);
                newRow.Set("nenndo", nenndo);
                newRow.Set("hosei_kaisuu", hoseiKaisuu);
                newRow.Set("yosan", 0);
                newRow.Set("parent_id", parentId);
                Context.KaikeiDatabase.YosanKamokuKubun.Insert(newRow);
                return (int)Context.KaikeiDatabase.YosanKamokuKubun.LastInsertedRow().GetLong("id", -1);
            }
            else {
                return (int)row.GetLong("id", -1);
            }
        }


        private void ConstructYosanKamoku(bool errWhenNotExist) {
            int nenndo = form.Year;
            int kaikeiKubun = form.KaikeiKubun;
            int yosanKubun = form.YosanKubun;
            int hoseiKaisuu = yosanKubun == (int)models.constants.MTYosanKubun.TuujouYosan ? 0 : form.HoseiKaisuu;

            string condition = string.Format(
                "where nenndo = {0} and kaikei_kubun = {1} and yosan_kubun = {2} and hosei_kaisuu = {3} ",
                nenndo,
                kaikeiKubun,
                yosanKubun,
                hoseiKaisuu
            );

            int rootId = (int)models.constants.MTKamokuKubun.ShikinRoot;

            if (Context.KaikeiDatabase.YosanKamokuKubun.RowCount(condition + " and kamoku_kubun_id = " + rootId) == 0 && 
                    errWhenNotExist) {
                //helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgNotExist);
            }
            else{
                Context.KaikeiDatabase.BeginTransaction();

                //add root
                int rootYosanId = AddNewYosanRow(yosanKubun, kaikeiKubun, nenndo, rootId, hoseiKaisuu, -1);

                // 予算科目
                foreach (var kubunRow in Context.KaikeiDatabase.MTKamokuKubun.Select("where parent_id = " + rootId + " order by display_order")) {
                    int kubunId = (int)kubunRow.GetLong("id", -1);
                    foreach (var daikubunRow in Context.KaikeiDatabase.MTKamokuKubun.Select("where parent_id = " + kubunId + " order by display_order")) {
                        int daikubunId = (int)daikubunRow.GetLong("id", -1);
                        int daikubunYosanId = AddNewYosanRow(yosanKubun, kaikeiKubun, nenndo, daikubunId, hoseiKaisuu, rootYosanId);
                        foreach (var chukubunRow in Context.KaikeiDatabase.MTKamokuKubun.Select("where parent_id = " + daikubunId + " order by display_order")) {
                            int chukubunId = (int)chukubunRow.GetLong("id", -1);
                            int chukubunYosanId = AddNewYosanRow(yosanKubun, kaikeiKubun, nenndo, chukubunId, hoseiKaisuu, daikubunYosanId);
                            foreach (var syoukubunRow in Context.KaikeiDatabase.MTKamokuKubun.Select("where parent_id = " + chukubunId + " order by display_order")) {
                                int syoukubunId = (int)syoukubunRow.GetLong("id", -1);
                                int syoukubunYosanId = AddNewYosanRow(yosanKubun, kaikeiKubun, nenndo, syoukubunId, hoseiKaisuu, chukubunYosanId);
                                foreach (var hojoRow in Context.KaikeiDatabase.MTKamokuKubun.Select("where parent_id = " + syoukubunId + " order by display_order")) {
                                    int hojoId = (int)hojoRow.GetLong("id", -1);
                                    AddNewYosanRow(yosanKubun, kaikeiKubun, nenndo, hojoId, hoseiKaisuu, syoukubunYosanId);
                                }
                            }
                        }
                    }
                }

                Context.KaikeiDatabase.CommitTransaction();
            }
        }


        private void NewButtonClicked() {
            daikubunPopupController.ClosePopup();
            chukubunPopupController.ClosePopup();
            syoukubunPopupController.ClosePopup();
            hojoPopupController.ClosePopup();
            yobihiPopupController.ClosePopup();
            yobihiKakuninPopupController.ClosePopup();
            yosanListPopupController.ClosePopup();
            yosanKakuninPopupController.ClosePopup();

            // パラメータチェック
            if (CheckParameterValidity() == false) {
                return;
            }

            int nenndo = form.Year;
            int kaikeiKubun = form.KaikeiKubun;
            int yosanKubun = form.YosanKubun;
            int hoseiKaisuu = yosanKubun == (int)models.constants.MTYosanKubun.TuujouYosan ? 0 : form.HoseiKaisuu;

            form.HoseiKaisuu = hoseiKaisuu;

            ConstructYosanKamoku(errWhenNotExist:false);

            Context.KaikeiDatabase.BeginTransaction();

            string condition = string.Format(
                "where nenndo = {0} and kaikei_kubun = {1} and yosan_kubun = {2} and hosei_kaisuu = {3} ",
                nenndo,
                kaikeiKubun,
                yosanKubun,
                hoseiKaisuu
            );

            // 予算予備費
            if (Context.KaikeiDatabase.YosanYobihi.RowCount(condition) == 0) {
                var newRow = Context.KaikeiDatabase.YosanYobihi.NewRow();
                newRow.Set("yosan_kubun", yosanKubun);
                newRow.Set("kaikei_kubun", kaikeiKubun);
                newRow.Set("nenndo", nenndo);
                newRow.Set("hosei_kaisuu", hoseiKaisuu);
                newRow.Set("yobihi", 0);
                newRow.Set("zenkimatsu_shiharai_shikin_zandaka", 0);
                newRow.Set("create_date", DateTime.Now);
                Context.KaikeiDatabase.YosanYobihi.Insert(newRow);
            }
            
            Context.KaikeiDatabase.CommitTransaction();

            ShowYosanKubunPopups();

            helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgSucceeded);
        }


        private void HikitsugiButtonClicked() {
            int nenndo = form.Year;

            // 年度チェック
            if (nenndo == -1) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidYear);
                return;
            }

            var res = MessageBox.Show(
                KaikeiSystemBody.Properties.Resources.MsgConfirmCopyYosan,
                KaikeiSystemBody.Properties.Resources.CaptionConfirm,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (res == DialogResult.Cancel) {
                return;
            }

            string srcCondition = string.Format(
                "where nenndo = {0} and yosan_kubun = {1}",
                nenndo - 1,
                (int)models.constants.MTYosanKubun.TuujouYosan);


            Context.KaikeiDatabase.BeginTransaction();

            //予算科目
            if (Context.KaikeiDatabase.YosanKamokuKubun.RowCount("where nenndo = " + nenndo) > 0) {
                helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgYosanKamokuAlreadyExist);
            }
            else{
                Dictionary<int, int> idHash = new Dictionary<int, int>();
                foreach (var row in Context.KaikeiDatabase.YosanKamokuKubun.Select(srcCondition + " order by id")) { // 挿入された順番で取り出す (親から順に取り出す必要がある)
                    var newRow = Context.KaikeiDatabase.YosanDaikubun.NewRow();
                    newRow.Set("yosan_kubun", (int)models.constants.MTYosanKubun.TuujouYosan);
                    newRow.Set("kaikei_kubun", row.GetLong("kaikei_kubun", 0));
                    newRow.Set("kamoku_kubun_id", row.GetLong("kamoku_kubun_id", 0));
                    newRow.Set("nenndo", nenndo);
                    newRow.Set("hosei_kaisuu", 0);
                    newRow.Set("yosan", row.GetLong("yosan", 0));

                    int originalParentId = (int)row.GetLong("parent_id", -1);
                    int parentId;
                    if (originalParentId != -1) {
                        parentId = idHash[originalParentId];
                    }
                    else {
                        parentId = -1;
                    }
                    newRow.Set("parent_id", parentId);

                    Context.KaikeiDatabase.YosanKamokuKubun.Insert(newRow);

                    idHash[(int)row.GetLong("id", -1)] = (int)Context.KaikeiDatabase.YosanKamokuKubun.LastInsertedRow().GetLong("id", -1);
                }
            }

            //予算予備費
            if (Context.KaikeiDatabase.YosanYobihi.RowCount("where nenndo = " + nenndo) > 0) {
                helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgYosanYobihiAlreadyExist);
            }
            else {
                foreach (var row in Context.KaikeiDatabase.YosanYobihi.Select(srcCondition)) {
                    var newRow = Context.KaikeiDatabase.YosanYobihi.NewRow();
                    newRow.Set("yosan_kubun", (int)models.constants.MTYosanKubun.TuujouYosan);
                    newRow.Set("kaikei_kubun", row.GetLong("kaikei_kubun", 0));
                    newRow.Set("nenndo", nenndo);
                    newRow.Set("hosei_kaisuu", 0);
                    newRow.Set("yobihi", row.GetLong("yobihi", 0));
                    newRow.Set("zenkimatsu_shiharai_shikin_zandaka", row.GetLong("zenkimatsu_shiharai_shikin_zandaka", 0));
                    Context.KaikeiDatabase.YosanYobihi.Insert(newRow);
                }
            }

            Context.KaikeiDatabase.CommitTransaction();

            helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgCompleteCopyYosan);
        }


        private void DeleteButtonClicked() {
            daikubunPopupController.ClosePopup();
            chukubunPopupController.ClosePopup();
            syoukubunPopupController.ClosePopup();
            hojoPopupController.ClosePopup();
            yobihiPopupController.ClosePopup();
            yobihiKakuninPopupController.ClosePopup();
            yosanListPopupController.ClosePopup();
            yosanKakuninPopupController.ClosePopup();

            // パラメータチェック
            if (CheckParameterValidity() == false) {
                return;
            }

            var res = MessageBox.Show(
                KaikeiSystemBody.Properties.Resources.MsgConfirmDeleteYosan,
                KaikeiSystemBody.Properties.Resources.CaptionConfirm,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (res == DialogResult.No) {
                return;
            }

            int nenndo = form.Year;
            int kaikeiKubun = form.KaikeiKubun;
            int yosanKubun = form.YosanKubun;
            int hoseiKaisuu = yosanKubun == (int)models.constants.MTYosanKubun.TuujouYosan ? 0 : form.HoseiKaisuu;

            form.HoseiKaisuu = hoseiKaisuu;

            string condition = string.Format(
                " where nenndo = {0} and kaikei_kubun = {1} and yosan_kubun = {2} and hosei_kaisuu = {3}",
                nenndo,
                kaikeiKubun,
                yosanKubun,
                hoseiKaisuu
            );

            Context.KaikeiDatabase.ExecuteNonQuery(
                "delete from " + models.db.tables.YosanKamokuKubun.TABLE_NAME + condition
                );
            Context.KaikeiDatabase.ExecuteNonQuery(
                "delete from " + models.db.tables.YosanYobihi.TABLE_NAME + condition
                );

            helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgSucceeded);
        }
    }
}
