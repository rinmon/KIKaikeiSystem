using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers.popup
{
    class IkkatsuSyoriPopupController
    {
        private views.popup.IkkatsuTourokuPopup popup;
        private controllers.grid.DBPanelGridController<views.grid.IkkatsuSyoriRow> gridController;

        public event Action DenpyouInerted;



        public IkkatsuSyoriPopupController() {
        }

        public models.Context Context {
            get;
            set;
        }


        public void ShowPopupModal(Form parent) {
            popup = new views.popup.IkkatsuTourokuPopup();
            popup.SelectKubunButtonClicked += SelectKubunButtonClicked;
            popup.SelectAllButtonClicked += SelectAllButtonClicked;
            popup.UnselectAllButtonClicked += UnselectAllButtonClicked;
            popup.TourokuButtonClicked += TourokuButtonClicked;
            popup.CloseButtonClicked += () => popup.Close();
            popup.TargetGengou = Context.Setting.GetStr("before_gengou", "");
            InitTsuikaKubunComboBox();

            gridController = new grid.DBPanelGridController<views.grid.IkkatsuSyoriRow>(popup.Grid, false);
            gridController.ValidateColumnValue += Grid_ValidateColumnValue;
            gridController.SetTable(Context.KaikeiDatabase.MTIkkatsuSyori);
            gridController.SetQuery("");

            popup.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            popup.Location = new System.Drawing.Point(
                Math.Max(parent.Left + (parent.Width - popup.Width) / 2, 0),
                Math.Max(parent.Top + (parent.Height - popup.Height) / 2, 0));

            popup.ShowDialog();
        }


        private void InitTsuikaKubunComboBox(){
            var hash = new Dictionary<string, bool>();
            foreach (var row in Context.KaikeiDatabase.MTIkkatsuSyori.RowCache.Values) {
                string kubun = row.GetStr("tsuika_kubun", null);
                if(kubun != null && !hash.ContainsKey(kubun)){
                    popup.AddTsuikaKubun(kubun);
                    hash[kubun] = true;
                }
            }
        }


        // events
        private void SelectKubunButtonClicked() {
            Context.KaikeiDatabase.ExecuteNonQuery("update " + Context.KaikeiDatabase.MTIkkatsuSyori.TableName +
                " set touroku=1 where tsuika_kubun='" + popup.SelectedKubun + "'");
            Context.KaikeiDatabase.ExecuteNonQuery("update " + Context.KaikeiDatabase.MTIkkatsuSyori.TableName +
                " set touroku=0 where tsuika_kubun<>'" + popup.SelectedKubun + "'");
            gridController.Refresh();
        }


        private void SelectAllButtonClicked() {
            Context.KaikeiDatabase.ExecuteNonQuery("update " + Context.KaikeiDatabase.MTIkkatsuSyori.TableName + " set touroku=1");
            gridController.Refresh();
        }


        private void UnselectAllButtonClicked() {
            Context.KaikeiDatabase.ExecuteNonQuery("update " + Context.KaikeiDatabase.MTIkkatsuSyori.TableName + " set touroku=0");
            gridController.Refresh();
        }

        private void Grid_ValidateColumnValue(views.grid.IkkatsuSyoriRow row, string column, object value) {
            Context.KaikeiDatabase.MTIkkatsuSyori.Update(row.RowData);
        }

        private void TourokuButtonClicked() {
            DateTime? date = popup.TargetDate;
            if (date == null) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidDate);
                return;
            }

            int count = Context.KaikeiDatabase.MTIkkatsuSyori.RowCount("where touroku=1");

            if (count == 0) {
                helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgIkkatsuTourokuNoDataSelected);
                return;
            }

            if (MessageBox.Show(KaikeiSystemBody.Properties.Resources.MsgIkkatsuTourokuConfirm.Replace("%s", count.ToString()),
                            KaikeiSystemBody.Properties.Resources.CaptionWarning,
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) {
                return;
            }

            foreach (var row in Context.KaikeiDatabase.MTIkkatsuSyori.Select("where touroku=1")) {
                var denpyouRow = Context.KaikeiDatabase.KaikeiDenpyouMeisai.NewRow();
                string comment = row.GetStr("comment", "");
                if (popup.CommentPrefixIsEnabled) {
                    comment = popup.AddTextForComment + comment;
                }
                if (popup.CommentSuffixIsEnabled) {
                    comment = comment + popup.AddTextForComment;
                }

                Context.KaikeiDatabase.KaikeiDenpyouMeisai.SetKihyoubiAndDenpyouBangouCache(denpyouRow, date.Value);
                denpyouRow.Set("denpyou_bangou", denpyouRow.Get("denpyou_bangou_cache"));
                denpyouRow.Set("kaikei_kubun", row.Get("kaikei_kubun"));
                denpyouRow.Set("torihiki_kubun", row.Get("torihiki_kubun"));
                denpyouRow.Set("karikata_kamoku_id", row.Get("karikata_kamoku_id"));
                denpyouRow.Set("karikata_hojo_id", row.Get("karikata_hojo_id"));
                denpyouRow.Set("karikata_hojo_seiri", row.Get("karikata_hojo_seiri"));
                denpyouRow.Set("karikata_kingaku", row.Get("karikata_kingaku"));
                denpyouRow.Set("kashikata_kamoku_id", row.Get("kashikata_kamoku_id"));
                denpyouRow.Set("kashikata_hojo_id", row.Get("kashikata_hojo_id"));
                denpyouRow.Set("kashikata_hojo_seiri", row.Get("kashikata_hojo_seiri"));
                denpyouRow.Set("kashikata_kingaku", row.Get("kashikata_kingaku"));
                denpyouRow.Set("tekiyou_id", row.Get("tekiyou_id"));
                denpyouRow.Set("comment", comment);
                denpyouRow.Set("karikata_kamoku_code", row.Get("karikata_kamoku_code"));
                denpyouRow.Set("kashikata_kamoku_code", row.Get("kashikata_kamoku_code"));
                Context.KaikeiDatabase.KaikeiDenpyouMeisai.Insert(denpyouRow);
            }

            if (DenpyouInerted != null) {
                DenpyouInerted();
            }

            popup.Close();
        }
    }
}
