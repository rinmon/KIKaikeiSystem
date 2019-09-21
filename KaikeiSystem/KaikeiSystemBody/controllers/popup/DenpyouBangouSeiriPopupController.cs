using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.controllers.popup
{
    class DenpyouBangouSeiriPopupController
    {
        private views.popup.DenpyouBangouSeiriPopup popup;

        public event Action ReturnToSubfunctionPopup;
        public event Action DenpyouBangouUpdated;

        public DenpyouBangouSeiriPopupController() {
            popup = null;
        }

        public models.Context Context {
            get;
            set;
        }

        public void ShowPopup(System.Windows.Forms.Form parent) {
            if (popup != null) {
                return;
            }

            popup = new views.popup.DenpyouBangouSeiriPopup();
            popup.TargetDateInput.GengouStr = Context.Setting.GetStr("before_gengou", "");

            popup.CloseButtonClicked += CloseButtonClicked;
            popup.ReturnToSubfunctionPopupButtonClicked += ReturnToSubfunctionPopupButtonClicked;
            popup.OrderByKaikeiKubunAndKihyoubiAndNoButtonClicked += (s, e) => DoSort(true);
            popup.OrderByKihyoubiAndNoButtonClicked += (s, e) => DoSort(false);
            popup.FormClosed += (s, e) => popup = null;

            popup.InitEvents();

            popup.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            popup.Location = new System.Drawing.Point(parent.Left + (parent.Width - popup.Width) / 2,
                parent.Top + (parent.Height - popup.Height) / 2); 
            
            popup.Show(parent);
        }


        public void ClosePopup() {
            if (popup != null) {
                popup.Close();
            }
        }


        private void DoSort(bool withKaikeiKubun){
            DateTime? date = popup.TargetDateInput.Date;

            if (date == null) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidDate);
                return;
            }
            else {
                Context.KaikeiDatabase.KaikeiDenpyouMeisai.RenumberDenpyouBangou(date.Value, withKaikeiKubun);

                if (DenpyouBangouUpdated != null) {
                    DenpyouBangouUpdated();
                }
                helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgSucceeded);
            }
        }


        // events
        private void ReturnToSubfunctionPopupButtonClicked(object sender, EventArgs e){
            popup.Close();
            popup = null;
            if (ReturnToSubfunctionPopup != null) {
                ReturnToSubfunctionPopup();
            }
        }


        private void CloseButtonClicked(object sender, EventArgs e) {
            popup.Close();
            popup = null;
        }
    }
}
