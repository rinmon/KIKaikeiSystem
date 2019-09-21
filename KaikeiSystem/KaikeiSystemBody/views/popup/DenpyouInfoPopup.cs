using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.views.popup
{
    partial class DenpyouInfoPopup : Form
    {
        models.db.KaikeiDatabase db;

        public delegate void UpdateValueDelegate(string column_name, object value);

        public event UpdateValueDelegate UpdateValue;
        public event Action RemoveButtonClicked;

        bool inSetRowDataFunction;
        bool modifingControlValue;


        public DenpyouInfoPopup() {
            InitializeComponent();

            /*
            cmbKarikataKamoku.Tag = lblKarikataKamoku;
            cmbKashikataKamoku.Tag = lblKashikataKamoku;
            cmbKarikataHojo.Tag = lblKarikataHojo;
            cmbKashikataHojo.Tag = lblKashikataHojo;

            cmbKarikataKamoku.SelectedIndexChanged += KamokuComboChanged;
            cmbKashikataKamoku.SelectedIndexChanged += KamokuComboChanged;
            cmbKarikataHojo.SelectedIndexChanged += KamokuComboChanged;
            cmbKashikataHojo.SelectedIndexChanged += KamokuComboChanged;
             */

            btnDelete.Click += (s, e) => RemoveButtonClicked();
        }


        public void FocusKashikataHojoCmbBox() {
            cmbKashikataHojo.Select();
        }

        public void FocusKarikataHojoCmbBox() {
            cmbKarikataHojo.Select();
        }


        public void SetRowData(models.db.Row row) {
            inSetRowDataFunction = true;

            int torihikiKubunId = (int)row.GetLong("torihiki_kubun", -1);

            txtDenpyouBangou.Text = row.GetStr("denpyou_bangou_cache", "");
            txtKihyoubiGengou.Text = row.GetStr("kihyoubi_gengou");
            txtKihyoubiYear.Text = row.GetStr("kihyoubi_year");
            txtKihyoubiMonth.Text = row.GetStr("kihyoubi_month");
            txtKihyoubiDay.Text = row.GetStr("kihyoubi_day");
            cmbKarikataKamoku.SelectRowByKeyValue(row.GetStr("karikata_kamoku_code", ""));
            lblKarikataKamoku.Text = db.MTKanjouKamoku.GetKamokuStr((int)row.GetLong("karikata_kamoku_id", -1), torihikiKubunId);
            cmbKashikataKamoku.SelectRowByKeyValue(row.GetStr("kashikata_kamoku_code", ""));
            lblKashikataKamoku.Text = db.MTKanjouKamoku.GetKamokuStr((int)row.GetLong("kashikata_kamoku_id", -1), torihikiKubunId);
            txtKingaku.AmountStr = row.GetStr("karikata_kingaku", "");
            txtTekiyouId.Text = row.GetStr("tekiyou_id", "");
            txtComment.Text = row.GetStr("comment", "");
            checkDenpyouKakunin.Checked = row.GetBool("denpyou_kakunin", false);
            cmbKaikeiKubun.SelectRowByKeyValue(row.GetLong("kaikei_kubun", -1));
            cmbTorihikiKubun.SelectRowByKeyValue(row.GetLong("torihiki_kubun", -1));
            cmbKarikataHojo.SelectRowByKeyValue(row.GetLong("karikata_hojo_seiri", 0));
            lblKarikataHojo.Text = db.MTKanjouKamoku.GetKamokuStr((int)row.GetLong("karikata_hojo_id", -1), torihikiKubunId);
            cmbKashikataHojo.SelectRowByKeyValue(row.GetLong("kashikata_hojo_seiri", 0));
            lblKashikataHojo.Text = db.MTKanjouKamoku.GetKamokuStr((int)row.GetLong("kashikata_hojo_id", -1), torihikiKubunId);

            bool isBindedShikinDenpyou = db.KaikeiDenpyouMeisai.IsAutoInsertedShikinDenpyouRow(row);
            txtDenpyouBangou.ReadOnly = isBindedShikinDenpyou;
            txtKihyoubiGengou.ReadOnly = isBindedShikinDenpyou;
            txtKihyoubiYear.ReadOnly = isBindedShikinDenpyou;
            txtKihyoubiMonth.ReadOnly = isBindedShikinDenpyou;
            txtKihyoubiDay.ReadOnly = isBindedShikinDenpyou;
            cmbKarikataKamoku.Enabled = !isBindedShikinDenpyou;
            cmbKashikataKamoku.Enabled = !isBindedShikinDenpyou;
            txtKingaku.ReadOnly = isBindedShikinDenpyou;
            txtTekiyouId.ReadOnly = isBindedShikinDenpyou;
            txtComment.ReadOnly = isBindedShikinDenpyou;
            checkDenpyouKakunin.Enabled = !isBindedShikinDenpyou;
            cmbKaikeiKubun.Enabled = !isBindedShikinDenpyou;
            cmbTorihikiKubun.Enabled = !isBindedShikinDenpyou;
            cmbKarikataHojo.Enabled = !isBindedShikinDenpyou;
            cmbKashikataHojo.Enabled = !isBindedShikinDenpyou;
            btnDelete.Enabled = !isBindedShikinDenpyou;

            inSetRowDataFunction = false;
        }

        public void SetDatabase(models.db.KaikeiDatabase aDB) {
            db = aDB;

            cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, onlyLeafNode: true);
            cmbTorihikiKubun.InitRowsWithMTTorihikiKubun(db.MTTorihikiKubun);
            cmbKarikataKamoku.InitRowsWithMTKanjouKamokuWithKamokuCodeCaption(db.MTKanjouKamoku, -1);
            cmbKarikataHojo.BindToMTKanjouKamkouComboBoxWithKamokuCodeCaption(cmbKarikataKamoku, -1);
            cmbKashikataKamoku.InitRowsWithMTKanjouKamokuWithKamokuCodeCaption(db.MTKanjouKamoku, -1);
            cmbKashikataHojo.BindToMTKanjouKamkouComboBoxWithKamokuCodeCaption(cmbKashikataKamoku, -1);
        }



        // events
        private void control_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
            }
        }

        private void Control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            var target = sender as System.Windows.Forms.Control;

            if (e.KeyCode == Keys.Enter && !(sender is Button) && !e.Shift) {
                this.SelectNextControl(target, true, true, true, true);
                e.IsInputKey = true;
            }
        }

        private void KamokuComboChanged(object sender, EventArgs arg) {
            controls.MTComboBox cmb = sender as controls.MTComboBox;
            if (cmb.SelectedRow != null) {
                (cmb.Tag as Control).Text = cmb.SelectedRow.Cells(1) as string;
            }
            else {
                (cmb.Tag as Control).Text = "";
            }
        }

        private void control_Changed(object sender, EventArgs e) {
            if (inSetRowDataFunction == false) {
                modifingControlValue = true;
            }
        }

        private void control_Leave(object sender, EventArgs e) {
            if (inSetRowDataFunction == false && modifingControlValue) {
                UpdateValue((sender as Control).Tag as string, GetControlValue(sender as Control));
            }
            modifingControlValue = false;
        }

        private void cmbbox_Changed(object sender, EventArgs e) {
            if (inSetRowDataFunction == false) {
                UpdateValue((sender as Control).Tag as string, GetControlValue(sender as Control));
            }
        }

        //コントロールの値を取り出す
        private object GetControlValue(Control control) {
            object value = null;
            if (control is TextBox) {
                value = (control as TextBox).Text;
            }
            else if (control is views.controls.MTComboBox) {
                value = (control as views.controls.MTComboBox).SelectedKey;
            }
            else if (control is CheckBox) {
                value = (control as CheckBox).Checked;
            }
            else if(control is views.controls.DateInputPanel){
                value = (control as views.controls.DateInputPanel).Date;
            }
            return value;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
