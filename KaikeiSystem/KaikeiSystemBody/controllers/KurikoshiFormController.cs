using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class KurikoshiFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.KurikoshiForm form;
        private misc.FocusController focusController;
        private misc.DelayTimerController delayTimerController;
        private grid.DBPanelGridController<views.grid.ZenkiKurikoshiKamokuKubunRow> daikubunGridController;
        private grid.DBPanelGridController<views.grid.ZenkiKurikoshiKamokuKubunRow> chukubunGridController;
        private grid.DBPanelGridController<views.grid.ZenkiKurikoshiKamokuKubunRow> syoukubunGridController;
        private grid.DBPanelGridController<views.grid.ZenkiKurikoshiKamokuKubunRow> hojoGridController;

        private models.db.vtables.BufferedZenkiKurikoshiKamokuKubun daikubunTable;
        private models.db.vtables.BufferedZenkiKurikoshiKamokuKubun chukubunTable;
        private models.db.vtables.BufferedZenkiKurikoshiKamokuKubun syoukubunTable;
        private models.db.vtables.BufferedZenkiKurikoshiKamokuKubun hojokamokuTable;

        // 表示中のデータの年度と会計区分ID
        private int displayYear;
        private int displayKaikeiKubunId;

        public KurikoshiFormController() {
            form = new KaikeiSystemBody.views.KurikoshiForm();
            form.SearchButtonClicked += UpdateViews;
            form.AddButtonClicked += AddButtonClicked;
            form.DeleteButtonClicked += DeleteButtonClicked;
            form.CloseButtonClicked += () => MainController.PopActivity();

            daikubunGridController = new grid.DBPanelGridController<views.grid.ZenkiKurikoshiKamokuKubunRow>(form.DaikubunGrid, false);
            chukubunGridController = new grid.DBPanelGridController<views.grid.ZenkiKurikoshiKamokuKubunRow>(form.ChukubunGrid, false);
            syoukubunGridController = new grid.DBPanelGridController<views.grid.ZenkiKurikoshiKamokuKubunRow>(form.SyoukubunGrid, false);
            hojoGridController = new grid.DBPanelGridController<views.grid.ZenkiKurikoshiKamokuKubunRow>(form.HojokamokuGrid, false);

            daikubunGridController.RowUpdated += (row) => DaikubunRowUpdated();
            chukubunGridController.RowUpdated += (row) => ChukubunRowUpdated();
            syoukubunGridController.RowUpdated += (row) => SyoukubunRowUpdated();
            hojoGridController.RowUpdated += (row) => HojokamokuRowUpdated();

            daikubunGridController.Row_GotFocusAction += delegate(views.grid.ZenkiKurikoshiKamokuKubunRow row) {
                delayTimerController.SetDelayedProc(delegate() {
                    DaikubunRowSelectionChanged();
                });
            };
            chukubunGridController.Row_GotFocusAction += delegate(views.grid.ZenkiKurikoshiKamokuKubunRow row) {
                delayTimerController.SetDelayedProc(delegate() {
                    ChukubunRowSelectionChanged();
                });
            };
            syoukubunGridController.Row_GotFocusAction += delegate(views.grid.ZenkiKurikoshiKamokuKubunRow row) {
                delayTimerController.SetDelayedProc(delegate() {
                    SyoukubunRowSelectionChanged();
                });
            };
            hojoGridController.Row_GotFocusAction += delegate(views.grid.ZenkiKurikoshiKamokuKubunRow row) {
                delayTimerController.SetDelayedProc(delegate() {
                    HojokamokuRowSelectionChanged();
                });
            };

            form.ZenkimatsuShiharaiShikinZandakaChanged += delegate() {
                delayTimerController.SetDelayedProc(delegate() {
                    var result = MessageBox.Show(
                        KaikeiSystemBody.Properties.Resources.MsgConfirmZenkimatsuShiharaiShikinZandakaChange,
                        form.Text,
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.OK) {
                        SetZenkimatsuShiharaiShikinZandaka(form.ZenkimatsuShiharaiShikinZandaka);
                        UpdateZenkimatsuShiharaiShikinZandakaTextBox();
                    }
                    else {
                        UpdateZenkimatsuShiharaiShikinZandakaTextBox();
                    }
                });
            };

            form.JikiKurikoshiChanged += delegate() {
                SetJikiKurikoshi(form.JikiKurikoshi);
                UpdateJikiKurikoshiTextBox();
            };

            focusController = new misc.FocusController(form);
            delayTimerController = new misc.DelayTimerController(form);
        }


        public override Form Form {
            get {
                return form;
            }
        }


        override protected void OnActivated(object option) {
            form.SetDatabase(Context.KaikeiDatabase);
            form.Year = Context.Setting.GetDateTime("nenndo_kisanbi").Value.Year;

            daikubunTable = new models.db.vtables.BufferedZenkiKurikoshiKamokuKubun(Context.KaikeiDatabase);
            chukubunTable = new models.db.vtables.BufferedZenkiKurikoshiKamokuKubun(Context.KaikeiDatabase);
            syoukubunTable = new models.db.vtables.BufferedZenkiKurikoshiKamokuKubun(Context.KaikeiDatabase);
            hojokamokuTable = new models.db.vtables.BufferedZenkiKurikoshiKamokuKubun(Context.KaikeiDatabase);

            daikubunGridController.SetTable(daikubunTable);
            chukubunGridController.SetTable(chukubunTable);
            syoukubunGridController.SetTable(syoukubunTable);
            hojoGridController.SetTable(hojokamokuTable);

            UpdateViews();
        }

        override protected void OnDeactivated() {
        }


        private void DaikubunRowUpdated() {
            //form.DaikubunSumAmount = daikubunTable.SumZenkiKurikoshiGaku();
        }


        private void ChukubunRowUpdated() {
            long sum = chukubunTable.SumZenkiKurikoshiGaku();
            //form.ChukubunSumAmount = sum;

            var row = form.DaikubunGrid.SelectedRowControl.RowData;
            if (row != null) {
                row.Table.SetColumnValue(row, "zenki_kurikoshi_gaku", sum);
                row.Table.Update(row);
                daikubunGridController.Refresh();
            }

            DaikubunRowUpdated();
        }


        private void SyoukubunRowUpdated() {
            long sum = syoukubunTable.SumZenkiKurikoshiGaku();
            //form.SyoukubunSumAmount = sum;

            var row = form.ChukubunGrid.SelectedRowControl.RowData;
            if (row != null) {
                row.Table.SetColumnValue(row, "zenki_kurikoshi_gaku", sum);
                row.Table.Update(row);
                chukubunGridController.Refresh();
            }
            
            ChukubunRowUpdated();
        }

        
        private void HojokamokuRowUpdated() {
            long sum = hojokamokuTable.SumZenkiKurikoshiGaku();
            //form.HojoKamokuSumAmount = sum;

            var row = form.SyoukubunGrid.SelectedRowControl.RowData;
            if (row != null) {
                row.Table.SetColumnValue(row, "zenki_kurikoshi_gaku", sum);
                row.Table.Update(row);
                syoukubunGridController.Refresh();
            }

            SyoukubunRowUpdated();
        }


        private void DaikubunRowSelectionChanged() {
            models.db.Row selected = form.DaikubunGrid.SelectedRowControl.RowData;

            if (form.DaikubunGrid.SelectedRowIsVisible && selected != null) {
                chukubunTable.KamokuKubunParentId = (int)selected.GetLong("kamoku_kubun_id", -1);
                chukubunTable.KamokuKubunDepth = 1;
                chukubunTable.KaikeiKubunId = displayKaikeiKubunId;
                chukubunTable.Year = displayYear;
                chukubunTable.SyncRowList();
            }
            else {
                chukubunTable.ClearRows();
            }
            chukubunGridController.SetQuery("", dontMoveFocus: true);
            ChukubunRowSelectionChanged();

            //form.ChukubunSumAmount = chukubunTable.SumZenkiKurikoshiGaku();
        }


        private void ChukubunRowSelectionChanged() {
            models.db.Row selected = form.ChukubunGrid.SelectedRowControl.RowData;

            if (form.ChukubunGrid.SelectedRowIsVisible && selected != null) {
                syoukubunTable.KamokuKubunParentId = (int)selected.GetLong("kamoku_kubun_id", -1);
                syoukubunTable.KamokuKubunDepth = 1;
                syoukubunTable.KaikeiKubunId = displayKaikeiKubunId;
                syoukubunTable.Year = displayYear;
                syoukubunTable.SyncRowList();

            }
            else {
                syoukubunTable.ClearRows();
            }

            syoukubunGridController.SetQuery("", dontMoveFocus: true);
            SyoukubunRowSelectionChanged();

            //form.SyoukubunSumAmount = syoukubunTable.SumZenkiKurikoshiGaku();
        }


        private void SyoukubunRowSelectionChanged() {
            models.db.Row selected = form.SyoukubunGrid.SelectedRowControl.RowData;

            if (form.SyoukubunGrid.SelectedRowIsVisible && selected != null) {
                hojokamokuTable.KamokuKubunParentId = (int)selected.GetLong("kamoku_kubun_id", -1);
                hojokamokuTable.KamokuKubunDepth = 1;
                hojokamokuTable.KaikeiKubunId = displayKaikeiKubunId;
                hojokamokuTable.Year = displayYear;
                hojokamokuTable.SyncRowList();

            }
            else {
                hojokamokuTable.ClearRows();
            }

            hojoGridController.SetQuery("", dontMoveFocus: true);
            HojokamokuRowSelectionChanged();

            //form.HojoKamokuSumAmount = hojokamokuTable.SumZenkiKurikoshiGaku();
        }


        private void HojokamokuRowSelectionChanged() {
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

            return true;
        }


        private void UpdateViews() {
            if (!CheckParameterValidity()) {
                return;
            }
            displayYear = form.Year;
            displayKaikeiKubunId = form.KaikeiKubun;

            UpdateGrids();
            UpdateZenkimatsuShiharaiShikinZandakaTextBox();
            UpdateJikiKurikoshiTextBox();
        }

        private void SetZenkimatsuShiharaiShikinZandaka(long value) {
            if (!CheckParameterValidity()) {
                return;
            }
            // 前期末支払資金残高がテーブルになければ追加する。
            // (前期末支払資金残高の設定を後で追加したため、すでに使用しているDBでこの列が存在しない可能性があるため)
            Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.AddNewZenkimatsuShiharaiShikinZandaka(displayKaikeiKubunId, displayYear);

            string sql = string.Format("where kaikei_kubun_id = {0} and nenndo = {1} and kamoku_kubun_id = {2}",
                displayKaikeiKubunId,
                displayYear,
                (int)models.constants.MTKamokuKubun.ZenkimatsuShiharaiShikinZandaka);
            models.db.Row row = Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.GetFirstRow(sql);

            row.Set("zenki_kurikoshi_gaku", value);
            Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.Update(row);
        }

        private void UpdateZenkimatsuShiharaiShikinZandakaTextBox() {
            if (!CheckParameterValidity()) {
                return;
            }
            // 前期末支払資金残高がテーブルになければ追加する。
            // (前期末支払資金残高の設定を後で追加したため、すでに使用しているDBでこの列が存在しない可能性があるため)
            Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.AddNewZenkimatsuShiharaiShikinZandaka(displayKaikeiKubunId, displayYear);

            string sql = string.Format("where kaikei_kubun_id = {0} and nenndo = {1} and kamoku_kubun_id = {2}",
                displayKaikeiKubunId,
                displayYear,
                (int)models.constants.MTKamokuKubun.ZenkimatsuShiharaiShikinZandaka);
            models.db.Row row = Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.GetFirstRow(sql);
            long zandaka = row.GetLong("zenki_kurikoshi_gaku", -1);

            form.ZenkimatsuShiharaiShikinZandaka = zandaka;
        }

        private void SetJikiKurikoshi(long value) {
            if (!CheckParameterValidity()) {
                return;
            }

            { // 中区分
                string sql = string.Format("where kaikei_kubun_id = {0} and nenndo = {1} and kamoku_kubun_id = {2}",
                    displayKaikeiKubunId,
                    displayYear,
                    (int)models.constants.MTKamokuKubun.JikiKurikoshikatsudouZougenSagakuChukubun);
                models.db.Row row = Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.GetFirstRow(sql);
                if (row == null) {
                    return;
                }
                row.Set("zenki_kurikoshi_gaku", value);
                Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.Update(row);
            }

            { // 大区分
                string sql = string.Format("where kaikei_kubun_id = {0} and nenndo = {1} and kamoku_kubun_id = {2}",
                    displayKaikeiKubunId,
                    displayYear,
                    (int)models.constants.MTKamokuKubun.JikiKurikoshikatsudouZougenSagakuDaikubun);
                models.db.Row row = Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.GetFirstRow(sql);
                if (row == null) {
                    return;
                }

                row.Set("zenki_kurikoshi_gaku", value);
                Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.Update(row);
            }
        }

        private void UpdateJikiKurikoshiTextBox() {
            if (!CheckParameterValidity()) {
                return;
            }
            string sql = string.Format("where kaikei_kubun_id = {0} and nenndo = {1} and kamoku_kubun_id = {2}",
                displayKaikeiKubunId,
                displayYear,
                (int)models.constants.MTKamokuKubun.JikiKurikoshikatsudouZougenSagakuChukubun);
            models.db.Row row = Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.GetFirstRow(sql);
            if (row == null) {
                form.JikiKurikoshi = 0;
                return;
            }
            long zandaka = row.GetLong("zenki_kurikoshi_gaku", -1);

            form.JikiKurikoshi = zandaka;
        }


        private void UpdateGrids() {
            daikubunTable.KamokuKubunParentId = (int)models.constants.MTKamokuKubun.TaisyakuRoot;
            daikubunTable.KamokuKubunDepth = 2;
            daikubunTable.KaikeiKubunId = displayKaikeiKubunId;
            daikubunTable.Year = displayYear;
            daikubunTable.WithoutJikiKurikoshi = true;
            daikubunTable.SyncRowList();
            daikubunGridController.SetQuery("");

            //form.DaikubunSumAmount = daikubunTable.SumZenkiKurikoshiGaku();
            DaikubunRowSelectionChanged();
        }


        private void AddButtonClicked() {
            // パラメータチェック
            if (CheckParameterValidity() == false) {
                return;
            }
            displayYear = form.Year;
            displayKaikeiKubunId = form.KaikeiKubun;

            Context.KaikeiDatabase.ZenkiKurikoshiKamokuKubun.ConstructZenkiKurikoshi(displayKaikeiKubunId, displayYear);
            UpdateViews();

            helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgSucceeded);
        }


        private void DeleteButtonClicked() {
            // パラメータチェック
            if (CheckParameterValidity() == false) {
                return;
            }

            var res = MessageBox.Show(
                KaikeiSystemBody.Properties.Resources.MsgConfirmToDeleteRow,
                KaikeiSystemBody.Properties.Resources.CaptionConfirm,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (res == DialogResult.No) {
                return;
            }

            displayYear = form.Year;
            displayKaikeiKubunId = form.KaikeiKubun;


            string condition = " where nenndo = " + displayYear + " and kaikei_kubun_id = " + displayKaikeiKubunId;
            Context.KaikeiDatabase.ExecuteNonQuery(
                "delete from " + models.db.tables.ZenkiKurikoshiKamokuKubun.TABLE_NAME + condition
                );

            UpdateViews();

            helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgSucceeded);
        }
    }
}
