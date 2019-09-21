using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers.popup
{
    class DenpyouInfoPopupController
    {
        private views.popup.DenpyouInfoPopup popup;
        private controllers.misc.DelayTimerController delayTimerController;
        private models.db.Row bindedRow;
        private models.Context context;
        private bool rowDirty;


        public enum Result
        {
            Inserted,
            Updated,
            Deleted,
            None,
        }

        public DenpyouInfoPopupController() {
            popup = null;
            delayTimerController = new misc.DelayTimerController(null);
        }

        public Result ShowPopupModal(System.Windows.Forms.Form parent, models.db.Row row, models.Context aContext) {
            bindedRow = row;
            context = aContext;
            rowDirty = false;
            Result result = Result.None;

            popup = new views.popup.DenpyouInfoPopup();
            popup.SetDatabase(context.KaikeiDatabase);
            popup.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            popup.SetRowData(row);
            popup.Location = new System.Drawing.Point(
                Math.Max(parent.Left + (parent.Width - popup.Width) / 2, 0),
                Math.Max(parent.Top + (parent.Height - popup.Height) / 2, 0));

            popup.UpdateValue += UpdateValue;
            popup.FormClosing += delegate(object sender, FormClosingEventArgs args) {
                if (rowDirty) {
                    if (bindedRow.GetLong("id", -1) == -1) {
                        bindedRow.Table.Insert(bindedRow);
                        result = Result.Inserted;
                        bindedRow = bindedRow.Table.LastInsertedRow();
                    }
                    else {
                        bindedRow.Table.Update(bindedRow);
                        result = Result.Updated;
                    }
                    (bindedRow.Table as models.db.tables.KaikeiDenpyouMeisai).UpdateMeisaiGroup(bindedRow, "");
                }
            };
            popup.RemoveButtonClicked += delegate() {
                if (bindedRow.GetLong("id", -1) == -1) {
                    helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgFailedToRemoveRow);
                }
                else {
                    bindedRow.Table.Delete(bindedRow);
                    (bindedRow.Table as models.db.tables.KaikeiDenpyouMeisai).DeleteMeisaiGroup(bindedRow);
                    result = Result.Deleted;
                    popup.Close();
                }
            };

            popup.ShowDialog();
            popup.Dispose();

            return result;
        }


        private void UpdateValue(string column, object value) {
            var db = context.KaikeiDatabase;

            if (bindedRow.Table.SetColumnValue(bindedRow, column, value)) {
                switch (column) {
                    case "kaikei_kubun":
                        ValidateKarikataHojoSeiri(db, bindedRow);
                        ValidateKashikataHojoSeiri(db, bindedRow);
                        break;
                    case "karikata_hojo_seiri": ValidateKarikataHojoSeiri(db, bindedRow); break;
                    case "kashikata_hojo_seiri": ValidateKashikataHojoSeiri(db, bindedRow); break;
                    case "kihyoubi_gengou": ValidateKihyoubi(db, bindedRow); break;
                    case "kihyoubi_year": ValidateKihyoubi(db, bindedRow); break;
                    case "kihyoubi_month": ValidateKihyoubi(db, bindedRow); break;
                    case "kihyoubi_day": ValidateKihyoubi(db, bindedRow); break;
                    case "karikata_kamoku_code": ValidateKamokuCode(db, bindedRow, models.constants.Taisyaku.Karikata); break;
                    case "kashikata_kamoku_code": ValidateKamokuCode(db, bindedRow, models.constants.Taisyaku.Kashikata); break;
                }
            }
            else {
                //ShowMsgAndChangeFocus(KaikeiSystemBody.Properties.Resources.MsgInvalidInput.Replace("%s", value.ToString()), "err", column);
            }
            popup.SetRowData(bindedRow);    // 表示の更新
            rowDirty = true;
        }


        // validate

        private void ValidateKihyoubi(models.db.KaikeiDatabase db, models.db.Row row) {
            if (!models.Validator.CheckKihyoubiFormatIsValid(db, row)) {
                ShowMsgDelay(KaikeiSystemBody.Properties.Resources.MsgInvalidDate, "warn");
            }
            else if (!models.Validator.CheckKihyoubiIsInNendoKisanbi(db, row)) {
                ShowMsgDelay(KaikeiSystemBody.Properties.Resources.MsgKihyoubiOutOfRange, "warn");
            }
        }

        private void ValidateKamokuCode(models.db.KaikeiDatabase db, models.db.Row row, models.constants.Taisyaku taisyaku) {
            if (models.Validator.IsHurikaeTaisyouKamokuCode(db, row, taisyaku)) {
                ShowMsgDelay(KaikeiSystemBody.Properties.Resources.MsgHurikaeTaisyouKamoku, "warn");
            }
        }

        private void ValidateKarikataHojoSeiri(models.db.KaikeiDatabase db, models.db.Row row) {
            if (!models.Validator.CheckHojoSeiriIsFitInKaikeiKubun(db, row, models.constants.Taisyaku.Karikata)) {
                delayTimerController.SetDelayedProc(delegate() {
                    helper.MsgBox.ShowMsg(KaikeiSystemBody.Properties.Resources.MsgInvaidHojoSeiri, "warn");
                    popup.FocusKarikataHojoCmbBox();
                });
            }
        }


        private void ValidateKashikataHojoSeiri(models.db.KaikeiDatabase db, models.db.Row row) {
            if (!models.Validator.CheckHojoSeiriIsFitInKaikeiKubun(db, row, models.constants.Taisyaku.Kashikata)) {
                delayTimerController.SetDelayedProc(delegate() {
                    helper.MsgBox.ShowMsg(KaikeiSystemBody.Properties.Resources.MsgInvaidHojoSeiri, "warn");
                    popup.FocusKashikataHojoCmbBox();
                });
            }
        }

        private void ShowMsgDelay(string msg, string msg_type) {
            delayTimerController.SetDelayedProc(delegate() {
                helper.MsgBox.ShowMsg(msg, msg_type);
            });
        }
    }
}
