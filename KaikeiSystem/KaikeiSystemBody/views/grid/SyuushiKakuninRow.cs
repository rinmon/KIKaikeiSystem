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
    partial class SyuushiKakuninRow : AbstractDBGridRow
    {
        private models.db.KaikeiDatabase db;

        public SyuushiKakuninRow() {
            InitializeComponent();

            db = null;

            SetDefaultHandlersToControls();
            SetDefaultIndicator();
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row row_data) {
            int torihikiKubunId = (int)row_data.GetLong("torihiki_kubun", -1);

            txtId.Text = row_data.GetStr("id", "");
            cmbKaikeiKubun.SelectRowByKeyValue(row_data.GetLong("kaikei_kubun", -1));
            txtKihyoubiGengou.Text = row_data.GetStr("kihyoubi_gengou", "");
            txtKihyoubiYear.Text = row_data.GetStr("kihyoubi_year", "");
            txtKihyoubiMonth.Text = row_data.GetStr("kihyoubi_month", "");
            txtKihyoubiDay.Text = row_data.GetStr("kihyoubi_day", "");
            txtKarikataKamokuCode.Text = row_data.GetStr("karikata_kamoku_code", "");
            lblKarikataKamoku.Text = db.MTKanjouKamoku.GetKamokuStr((int)row_data.GetLong("karikata_kamoku_id", -1), torihikiKubunId);
            txtKashikataKamokuCode.Text = row_data.GetStr("kashikata_kamoku_code", "");
            lblKashikataKamoku.Text = db.MTKanjouKamoku.GetKamokuStr((int)row_data.GetLong("kashikata_kamoku_id", -1), torihikiKubunId);
            {
                int amount;
                if (int.TryParse(row_data.GetStr("karikata_kingaku", ""), out amount) == true) {
                    txtKingaku.Text = helper.Converter.LongToAmount(amount);
                }
                else {
                    txtKingaku.Text = row_data.GetStr("karikata_kingaku", "");
                }
            }
            txtTekiyou.Text = row_data.GetStr("tekiyou_id", "");
            txtComment.Text = row_data.GetStr("comment", "");
            cmbTorihikiKubun.SelectRowByKeyValue(torihikiKubunId);
            txtKarikataHojoSeiri.Text = row_data.GetStr("karikata_hojo_seiri", "");
            lblKarikataHojo.Text = db.MTKanjouKamoku.GetKamokuStr((int)row_data.GetLong("karikata_hojo_id", -1), torihikiKubunId);
            txtKashikataHojoSeiri.Text = row_data.GetStr("kashikata_hojo_seiri", "");
            lblKashikataHojo.Text = db.MTKanjouKamoku.GetKamokuStr((int)row_data.GetLong("kashikata_hojo_id", -1), torihikiKubunId);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
            db = aDB as models.db.KaikeiDatabase;

            cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, true);
            cmbTorihikiKubun.InitRowsWithMTTorihikiKubun(db.MTTorihikiKubun);
        }

        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            db = (originalRow as SyuushiKakuninRow).db;
            cmbKaikeiKubun.CopyRows((originalRow as SyuushiKakuninRow).cmbKaikeiKubun);
            cmbTorihikiKubun.CopyRows((originalRow as SyuushiKakuninRow).cmbTorihikiKubun);
        }

        public override void SetFocusToFirstControl() {
            txtKarikataKamokuCode.Select();
        }
    }
}
