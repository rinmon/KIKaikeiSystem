using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaikeiSystemBody.views.popup;

namespace KaikeiSystemBody.controllers.popup
{
    class SubfunctionPopupController
    {
        private views.popup.SubfunctionPopup popup;


        public SubfunctionPopupController() {
            ShowRowIdSelected = false;
            ShowRowCreateDateSelected = false;
            ShowRowUpdateDateSelected = false;        
        }

        public models.Context Context {
            get;
            set;
        }


        public string FilterSql {
            get;
            private set;
        }


        public bool MoveToTopSelected {
            get;
            private set;
        }

        public bool MoveToEndSelected {
            get;
            private set;
        }

        public bool ShowDenpyouBangouSeiriPopupSelected{
            get;
            private set;
        }

        public bool ShowIkkatsuSyoriPopupSelected {
            get;
            private set;
        }

        public bool ShowRowIdSelected {
            get;
            private set;
        }

        public bool ShowRowCreateDateSelected {
            get;
            private set;
        }

        public bool ShowRowUpdateDateSelected {
            get;
            private set;
        }

        public void ShowPopupModal(Form parent) {
            FilterSql = null;
            MoveToEndSelected = false;
            MoveToTopSelected = false;
            ShowDenpyouBangouSeiriPopupSelected = false;
            ShowIkkatsuSyoriPopupSelected = false;

            popup = new views.popup.SubfunctionPopup();
            popup.SetMasterTables(Context.KaikeiDatabase);

            popup.KaikeiKubunFilterButtonClicked += KaikeiKubunFilterButtonClicked;
            popup.DateFilterButtonClicked += DateFilterButtonClicked;
            popup.KamokuFilterButtonClicked += KamkouFilterButtonClicked;
            popup.KingakuFilterButtonClicked += KingakuFilterButtonClicked;
            popup.CommentFilterButtonClicked += CommentFilterButtonClicked;
            popup.IdFilterButtonClicked += IdFilterButtonClicked;
            popup.TorihikiKubunFilterButtonClicked += TorihikiKubunFilterButtonClicked;
            popup.CheckedFilterButtonClicked += CheckedFilterButtonClicked;
            popup.NotCheckedFilterButtonClicked += NotCheckedFilterButtonClicked;
            popup.NoFilterButtonClicked += NoFilterButtonClicked;
            popup.MoveToEndButtonClicked += MoveToEndButtonClicked;
            popup.MoveToTopButtonClicked += MoveToTopButtonClicked;
            popup.UncheckAllButtonClicked += UncheckAllButtonClicked;
            popup.DenpyouBangouSeiriButtonClicked += DenpyouBangouSeiriButtonClicked;
            popup.IkkatsuSyoriButtonClicked += IkkatsuSyoriButtonClicked;
            popup.CloseButtonClicked += CloseButtonClicked;

            popup.InitGengou(Context.Setting.GetStr("before_gengou", ""));
            popup.InitEvents();

            popup.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            popup.Location = new System.Drawing.Point(
                Math.Max(parent.Left + (parent.Width - popup.Width)/2, 0),
                Math.Max(parent.Top + (parent.Height - popup.Height)/2, 0)); 
            
            popup.ShowDialog();
        }


        private void ClosePopup() {
            popup.Close();
            popup.Dispose();
            popup = null;
        }


        private string GetKeiriKubunFilterStr(bool force) {
            if (popup.KaikeiKubunFilterIsEnabled || force) {
                return "kaikei_kubun=" + popup.KaikeiKubun.ToString();
            }
            return "1=1";
        }

        private string GetDateFilterStr(bool force) {
            if (popup.DateFilterIsEnabled || force) {
                DateTime? startDate = popup.StartDate;
                DateTime? endDate = popup.EndDate;


                if (startDate == null){
                    DateTime? nenndoKisanbi = Context.Setting.GetDateTime("nenndo_kisanbi");
                    if(nenndoKisanbi != null){
                        startDate = nenndoKisanbi;
                        endDate = new DateTime(nenndoKisanbi.Value.Year + 1, 3, 31);
                    }
                }
                if(endDate == null){
                    DateTime? nenndoKisanbi = Context.Setting.GetDateTime("nenndo_kisanbi");
                    if(nenndoKisanbi != null){
                        endDate = new DateTime(nenndoKisanbi.Value.Year + 1, 3, 31);
                    }
                }
                if(startDate != null && endDate != null){
                    int start = helper.Converter.DateTimeToInt(startDate.Value);
                    int end = helper.Converter.DateTimeToInt(endDate.Value);
                    string dateCol;

                    if (popup.DateFilterType == SubfunctionPopup.DateFilterTypeEnum.Kihyoubi) {
                        dateCol = "kihyoubi";
                    }
                    else if (popup.DateFilterType == SubfunctionPopup.DateFilterTypeEnum.CreatedAt) {
                        dateCol = "created_at";
                    }
                    else {
                        dateCol = "updated_at";
                    }
                    return string.Format("{0} <= {2} and {2} <= {1}", start, end, dateCol);
                }
            }
            return "1=1";
        }

        
        // events
        private void KaikeiKubunFilterButtonClicked(object sender, EventArgs arg) {
            if (popup.KaikeiKubun == -1) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgKaikeiKubunNotSelected);
            }
            else {
                FilterSql = GetKeiriKubunFilterStr(true);
                ClosePopup();
            }
        }

        private void DateFilterButtonClicked(object sender, EventArgs arg) {
            DateTime? startDate = popup.StartDate;
            DateTime? endDate = popup.EndDate;

            if (startDate == null || endDate == null) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidDate);
            }
            else{
                FilterSql = GetDateFilterStr(true) + " and " + GetKeiriKubunFilterStr(false);

                if (popup.DateFilterType == SubfunctionPopup.DateFilterTypeEnum.Kihyoubi) {
                    ShowRowCreateDateSelected = false;
                    ShowRowUpdateDateSelected = false;
                }
                else if (popup.DateFilterType == SubfunctionPopup.DateFilterTypeEnum.CreatedAt) {
                    ShowRowCreateDateSelected = true;
                    ShowRowUpdateDateSelected = false;
                }
                else if (popup.DateFilterType == SubfunctionPopup.DateFilterTypeEnum.UpdateAt) {
                    ShowRowCreateDateSelected = false;
                    ShowRowUpdateDateSelected = true;
                }

                ShowRowIdSelected = true;

                ClosePopup();
            }
        }

        private void KamkouFilterButtonClicked(object sender, EventArgs arg) {
            string sql = GetDateFilterStr(false) + " and " + GetKeiriKubunFilterStr(false) + " and ";
            sql += string.Format("(karikata_kamoku_code='{0}' or kashikata_kamoku_code='{0}')", popup.KamokuCode);

            FilterSql = sql;
            ClosePopup();
        }

        private void KingakuFilterButtonClicked(object sender, EventArgs arg) {
            long? kingaku = helper.Converter.AmountToLongObj(popup.KingakuStr);

            if (kingaku == null) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidInput.Replace("%s", popup.KingakuStr));
            }
            else {
                FilterSql = GetKeiriKubunFilterStr(false) + " and karikata_kingaku=" + kingaku.Value.ToString();
                ClosePopup();
            }
        }

        private void CommentFilterButtonClicked(object sender, EventArgs arg) {
            FilterSql = GetKeiriKubunFilterStr(false) + " and comment like '%" + popup.SearchWordForComment + "%'";
            ClosePopup();
        }

        private void IdFilterButtonClicked(object sender, EventArgs arg) {
            int? id = helper.Converter.ObjToIntObj(popup.IdStr);

            if (id == null) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidInput.Replace("%s", popup.IdStr));
            }
            else {
                FilterSql = GetKeiriKubunFilterStr(false) + " and id =" + id.ToString();
                ShowRowIdSelected = true;
                ClosePopup();
            }
        }

        private void TorihikiKubunFilterButtonClicked(object sender, EventArgs arg) {
            int torihikiKubun = popup.TorihikiKubun;

            if (torihikiKubun == -1) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgTorihikiKubunNotSelected);
            }
            else {
                FilterSql = GetDateFilterStr(false) + " and " + GetKeiriKubunFilterStr(false) + " and torihiki_kubun=" + torihikiKubun.ToString();
                ClosePopup();
            }
        }

        private void CheckedFilterButtonClicked(object sender, EventArgs arg) {
            FilterSql = GetKeiriKubunFilterStr(false) + " and denpyou_kakunin<>0";
            ClosePopup();
        }

        private void NotCheckedFilterButtonClicked(object sender, EventArgs arg) {
            FilterSql = GetKeiriKubunFilterStr(false) + " and denpyou_kakunin=0";
            ClosePopup();
        }

        private void NoFilterButtonClicked(object sender, EventArgs arg) {
            FilterSql = "1=1";
            ClosePopup();
        }
        
        private void MoveToTopButtonClicked(object sender, EventArgs arg) {
            //FilterSql = "1=1";
            MoveToTopSelected = true;
            ClosePopup();
        }

        private void MoveToEndButtonClicked(object sender, EventArgs arg) {
            //FilterSql = "1=1";
            MoveToEndSelected = true;
            ClosePopup();
        }

        private void DenpyouBangouSeiriButtonClicked(object sender, EventArgs arg){
            ShowDenpyouBangouSeiriPopupSelected = true;
            ClosePopup();
        }

        private void IkkatsuSyoriButtonClicked(object sender, EventArgs arg){
            ShowIkkatsuSyoriPopupSelected = true;
            ClosePopup();
        }

        private void UncheckAllButtonClicked(object sender, EventArgs arg) {
            if (MessageBox.Show(KaikeiSystemBody.Properties.Resources.MsgConfirmUncheckAll, KaikeiSystemBody.Properties.Resources.CaptionWarning,
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                Context.KaikeiDatabase.ExecuteNonQuery("update " + Context.KaikeiDatabase.KaikeiDenpyouMeisai.TableName + " set denpyou_kakunin = 0");
                FilterSql = "1=1";
                ClosePopup();
            }
        }

        private void CloseButtonClicked(object sender, EventArgs arg) {
            ClosePopup();
        }
    }
}
