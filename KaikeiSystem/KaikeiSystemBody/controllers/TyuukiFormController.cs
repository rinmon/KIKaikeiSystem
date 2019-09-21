using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class TyuukiFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.TyuukiForm form;
        private grid.DBPanelGridController<views.grid.Tyuuki8Row> tyuuki8GridController;
        private grid.DBPanelGridController<views.grid.Tyuuki10Row> tyuuki10GridController;
        private grid.DBPanelGridController<views.grid.Tyuuki11Row> tyuuki11GridController;
        private misc.FocusController focusController;
        private int tyuukiId;
        private models.db.Row tyuukiRow;

        public TyuukiFormController() {
            tyuukiRow = null;
            tyuukiId = -1;

            form = new KaikeiSystemBody.views.TyuukiForm();
            form.CloseButtonClicked += () => MainController.PopActivity();

            form.TyuukiTextChanged += delegate(string columnName, string value) {
                if (tyuukiRow != null) {
                    tyuukiRow.Table.SetColumnValue(tyuukiRow, columnName, value);
                    tyuukiRow.Table.Update(tyuukiRow);
                }
            };

            form.ExecButtonClicked += delegate() {
                if (form.InputDate != null) {
                    if (SearchData(form.InputDate.Value.Year, form.KaikeiKubun) == SetNenndoResult.Inserted) {
                        helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgInsertSuccess);
                    }
                    else{
                        helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgSearchSuccess);
                    }
                }
                else {
                    helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidDate);
                }
            };

            tyuuki8GridController = new grid.DBPanelGridController<views.grid.Tyuuki8Row>(form.Tyuuki8Grid, true);
            tyuuki8GridController.IsValidNewRow += delegate(models.db.Row row) {
                return row.GetLong("tyuuki_id", -1) != -1;
            };
            tyuuki8GridController.InitInsertedRow += delegate(models.db.Row row) {
                row.Table.SetColumnValue(row, "tyuuki_id", tyuukiId);
            };

            tyuuki10GridController = new grid.DBPanelGridController<views.grid.Tyuuki10Row>(form.Tyuuki10Grid, true);
            tyuuki10GridController.IsValidNewRow += delegate(models.db.Row row) {
                return row.GetLong("tyuuki_id", -1) != -1;
            };
            tyuuki10GridController.InitInsertedRow += delegate(models.db.Row row) {
                row.Table.SetColumnValue(row, "tyuuki_id", tyuukiId);
            };

            tyuuki11GridController = new grid.DBPanelGridController<views.grid.Tyuuki11Row>(form.Tyuuki11Grid, true);
            tyuuki11GridController.IsValidNewRow += delegate(models.db.Row row) {
                return row.GetLong("tyuuki_id", -1) != -1;
            };
            tyuuki11GridController.InitInsertedRow += delegate(models.db.Row row) {
                row.Table.SetColumnValue(row, "tyuuki_id", tyuukiId);
            };

            focusController = new misc.FocusController(form);
        }


        public override Form Form {
            get {
                return form;
            }
        }


        public void SetInitialData(int year, int kaikeiKubun) {
            models.db.Row tyuuki = Context.KaikeiDatabase.Tyuuki.NewRow();
            tyuuki.Table.SetColumnValue(tyuuki, "nenndo", year);
            tyuuki.Table.SetColumnValue(tyuuki, "kaikei_kubun_id", kaikeiKubun);
            tyuuki.Table.SetColumnValue(tyuuki, "tyuuki1", Properties.Resources.ConstantGaitounashi);
            tyuuki.Table.SetColumnValue(tyuuki, "tyuuki2", Properties.Resources.ConstantGaitounashi);
            tyuuki.Table.SetColumnValue(tyuuki, "tyuuki3", Properties.Resources.ConstantGaitounashi);
            tyuuki.Table.SetColumnValue(tyuuki, "tyuuki4", Properties.Resources.ConstantGaitounashi);
            tyuuki.Table.SetColumnValue(tyuuki, "tyuuki5", Properties.Resources.ConstantGaitounashi);
            tyuuki.Table.SetColumnValue(tyuuki, "tyuuki7", Properties.Resources.ConstantGaitounashi);
            tyuuki.Table.SetColumnValue(tyuuki, "tyuuki12", Properties.Resources.ConstantGaitounashi);
            tyuuki.Table.SetColumnValue(tyuuki, "tyuuki13", Properties.Resources.ConstantGaitounashi);
            tyuuki.Table.SetColumnValue(tyuuki, "tyuuki14", Properties.Resources.ConstantGaitounashi);
            tyuuki.Table.SetColumnValue(tyuuki, "tyuuki15", Properties.Resources.ConstantGaitounashi);

            tyuuki.Table.Insert(tyuuki);
        }


        private enum SetNenndoResult {
            Inserted,
            Searched,
            Failed,
        }

        private void SetNullData() {
            tyuukiRow = null;
            tyuukiId = -1;
            form.SetTyuukiRow(tyuukiRow);
            string gridSql = "where tyuuki_id=" + tyuukiId;
            tyuuki8GridController.SetQuery(gridSql);
            tyuuki10GridController.SetQuery(gridSql);
            tyuuki11GridController.SetQuery(gridSql);
        }

        private SetNenndoResult SearchData(int year, int kaikeiKubun) {
            bool inserted = false;
            tyuukiRow = null;
            tyuukiId = -1;
            form.SetTyuukiRow(tyuukiRow);

            if (Context.KaikeiDatabase.MTKaikeiKubun.GetRowById(kaikeiKubun) == null) {
                return SetNenndoResult.Failed;
            }

            string sql = "where nenndo=" + year + " and kaikei_kubun_id=" + kaikeiKubun;

            var rows = Context.KaikeiDatabase.Tyuuki.Select(sql);
            if (rows.Count() == 0) {
                SetInitialData(year, kaikeiKubun);
                rows = Context.KaikeiDatabase.Tyuuki.Select(sql);
                if (rows.Count() == 0) {
                    return SetNenndoResult.Failed;
                }
                inserted = true;
            }


            tyuukiRow = rows.First();
            tyuukiId = tyuukiRow.GetId();
            form.SetTyuukiRow(tyuukiRow);

            string gridSql = "where tyuuki_id=" + tyuukiId;
            tyuuki8GridController.SetQuery(gridSql);
            tyuuki10GridController.SetQuery(gridSql);
            tyuuki11GridController.SetQuery(gridSql);

            if (inserted) {
                return SetNenndoResult.Inserted;
            }
            else {
                return SetNenndoResult.Searched;
            }
        }


        override protected void OnActivated(object option) {
            form.SetDB(Context.KaikeiDatabase);
            tyuuki8GridController.SetTable(Context.KaikeiDatabase.Tyuuki8);
            tyuuki10GridController.SetTable(Context.KaikeiDatabase.Tyuuki10);
            tyuuki11GridController.SetTable(Context.KaikeiDatabase.Tyuuki11);
            SetNullData();
        }

        override protected void OnDeactivated() {
        }
    }
}
