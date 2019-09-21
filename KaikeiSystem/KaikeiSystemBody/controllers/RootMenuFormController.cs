using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class RootMenuFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.RootMenuForm form;
        private misc.FocusController focusController;

        private enum MargeType {
            KanjouKamoku,
            Denpyou,
        };


        public RootMenuFormController() {
            form = new KaikeiSystemBody.views.RootMenuForm();

            form.CloseButtonClicked += delegate() {
                this.MainController.PopActivity();
            };

            form.MargeDatabaseKanjouKamokuTableButtonClicked += delegate() {
                MargeDB(MargeType.KanjouKamoku);
            };
            form.MargeDatabaseDenpyouButtonClicked += delegate() {
                MargeDB(MargeType.Denpyou);
            };

            focusController = new misc.FocusController(form);
        }


        public override Form Form {
            get {
                return form;
            }
        }


        override protected void OnActivated(object option) {
        }

        override protected void OnDeactivated() {
            Context.KaikeiDatabase.MTKanjouKamoku.UpdateCache();
            Context.KaikeiDatabase.MTKamokuKubun.UpdateCache();
        }


        private void MargeDB(MargeType type) {
            models.db.KaikeiDatabase targetDB = new models.db.KaikeiDatabase(form.DBFilePath);

            misc.WaitCursorController.Begin();

            try {
                targetDB.Open();
                targetDB.InitTables(false);
            }
            catch(Exception) {
                helper.MsgBox.Err(Properties.Resources.MsgDBOpenError);
            }

            helper.DBBackup.MakeDBBackup(Context.KaikeiDatabase.DBFilePath, "marge");

            //try {
                Context.KaikeiDatabase.BeginTransaction();

                switch (type) {
                    case MargeType.KanjouKamoku:
                        models.db.KaikeiDatabaseHandler.MargeKanjouKamoku(Context.KaikeiDatabase, targetDB);
                        break;
                    case MargeType.Denpyou:
                        models.db.KaikeiDatabaseHandler.MargeDenpyou(Context.KaikeiDatabase, targetDB);
                        break;
                }


                Context.KaikeiDatabase.CommitTransaction();
                misc.WaitCursorController.EndWithSuccessMsg();
            /*}
            catch (Exception e) {
                Context.KaikeiDatabase.RollbackTransaction();
                misc.WaitCursorController.End();
                helper.MsgBox.Err("Error : " + e.Message);
            }*/
        }
    }
}
