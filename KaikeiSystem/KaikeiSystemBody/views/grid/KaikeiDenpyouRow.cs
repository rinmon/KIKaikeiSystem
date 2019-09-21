using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.views.grid
{
    partial class KaikeiDenpyouRow : AbstractDBGridRow
    {
        private models.db.KaikeiDatabase db;


        public KaikeiDenpyouRow() {
            InitializeComponent();

            db = null;

            btnRemoveRow.Click += base.DefaultHandlerRemoveRowButtonClicked;
            SetDefaultHandlersToControls();
            SetDefaultIndicator();
        }

        public bool IdIsVisible {
            get {
                return lblId.Visible;
            }
            set {
                lblId.Visible = value;
            }
        }

        public bool CreateDateIsVisible {
            get {
                return lblCreateDate.Visible;
            }
            set {
                lblCreateDate.Visible = value;
                if (lblCreateDate.Visible || lblUpdateDate.Visible) {
                    chkKessanSyuuryou.Visible = false;
                }
            }
        }

        public bool UpdateDateIsVisible {
            get {
                return lblUpdateDate.Visible;
            }
            set {
                lblUpdateDate.Visible = value;
                if (lblCreateDate.Visible || lblUpdateDate.Visible) {
                    chkKessanSyuuryou.Visible = false;
                }
            }
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row row_data) {
            int torihikiKubunId = (int)row_data.GetLong("torihiki_kubun", -1);

            lblId.Text = row_data.GetStr("id", "(新規)");
            {
                DateTime? createdAt = row_data.GetDate("created_at");
                lblCreateDate.Text = createdAt != null ? helper.Converter.DateTimeToWarekiStr(createdAt.Value) : "";
            }
            {
                DateTime? updatedAt = row_data.GetDate("updated_at");
                lblUpdateDate.Text = updatedAt != null ? helper.Converter.DateTimeToWarekiStr(updatedAt.Value) : "";
            }
            txtDenpyouBangou.Text = row_data.GetStr("denpyou_bangou_cache", "");
            txtKihyoubiGengou.Text = row_data.GetStr("kihyoubi_gengou", "");
            txtKihyoubiYear.Text = row_data.GetStr("kihyoubi_year", "");
            txtKihyoubiMonth.Text = row_data.GetStr("kihyoubi_month", "");
            txtKihyoubiDay.Text = row_data.GetStr("kihyoubi_day", "");
            txtKarikataKamokuCode.Text = row_data.GetStr("karikata_kamoku_code", "");
            lblKarikataKamoku.Text = db.MTKanjouKamoku.GetKamokuStr((int)row_data.GetLong("karikata_kamoku_id", -1), torihikiKubunId);
            txtKashikataKamokuCode.Text = row_data.GetStr("kashikata_kamoku_code", "");
            lblKashikataKamoku.Text = db.MTKanjouKamoku.GetKamokuStr((int)row_data.GetLong("kashikata_kamoku_id", -1), torihikiKubunId);
            txtKingaku.AmountStr = row_data.GetStr("karikata_kingaku", "");
            txtTekiyou.Text = row_data.GetStr("tekiyou_id", "");
            txtComment.Text = row_data.GetStr("comment", "");
            chkKessanSyuuryou.Checked = row_data.GetBool("kessan_syuuryou", false);
            chkDenpyouKakunin.Checked = row_data.GetBool("denpyou_kakunin", false);
            cmbKaikeiKubun.SelectRowByKeyValue(row_data.GetLong("kaikei_kubun", -1));
            cmbTorihikiKubun.SelectRowByKeyValue(torihikiKubunId);
            txtKarikataHojoSeiri.Text = row_data.GetStr("karikata_hojo_seiri", "");
            lblKarikataHojo.Text = db.MTKanjouKamoku.GetKamokuStr((int)row_data.GetLong("karikata_hojo_id", -1), torihikiKubunId);
            txtKashikataHojoSeiri.Text = row_data.GetStr("kashikata_hojo_seiri", "");
            lblKashikataHojo.Text = db.MTKanjouKamoku.GetKamokuStr((int)row_data.GetLong("kashikata_hojo_id", -1), torihikiKubunId);

            bool isBindedShikinDenpyou = db.KaikeiDenpyouMeisai.IsAutoInsertedShikinDenpyouRow(row_data);
            txtKihyoubiGengou.ReadOnly = isBindedShikinDenpyou;
            txtKihyoubiYear.ReadOnly = isBindedShikinDenpyou;
            txtKihyoubiMonth.ReadOnly = isBindedShikinDenpyou;
            txtKihyoubiDay.ReadOnly = isBindedShikinDenpyou;
            cmbKaikeiKubun.Enabled = !isBindedShikinDenpyou;
            cmbTorihikiKubun.Enabled = !isBindedShikinDenpyou;
            txtKarikataKamokuCode.ReadOnly = isBindedShikinDenpyou;
            txtKarikataHojoSeiri.ReadOnly = isBindedShikinDenpyou;
            txtKashikataKamokuCode.ReadOnly = isBindedShikinDenpyou;
            txtKashikataHojoSeiri.ReadOnly = isBindedShikinDenpyou;
            txtKingaku.ReadOnly = isBindedShikinDenpyou;
            txtTekiyou.ReadOnly = isBindedShikinDenpyou;
            txtComment.ReadOnly = isBindedShikinDenpyou;
            btnRemoveRow.Enabled = !isBindedShikinDenpyou;
            chkKessanSyuuryou.Enabled = !isBindedShikinDenpyou;
 
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase db_) {
            db = db_ as models.db.KaikeiDatabase;

            cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, true);
            cmbTorihikiKubun.InitRowsWithMTTorihikiKubun(db.MTTorihikiKubun);
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            db = (originalRow as KaikeiDenpyouRow).db;

            cmbKaikeiKubun.CopyRows((originalRow as KaikeiDenpyouRow).cmbKaikeiKubun);
            cmbTorihikiKubun.CopyRows((originalRow as KaikeiDenpyouRow).cmbTorihikiKubun);
        }


        public override void SetFocusToFirstControl() {
            txtKarikataKamokuCode.Select();
        }

        public void ChangeKessanSyuuryouCheckBoxVisibility(bool visible) {
            if (visible && !lblCreateDate.Visible && !lblUpdateDate.Visible) {
                chkKessanSyuuryou.Show();
            }
            else {
                chkKessanSyuuryou.Hide();
            }
        }

        // events

        private void KaikeiDenpyouRow_Click(object sender, EventArgs e) {
              CallRowClicked();
        }
    }
}
