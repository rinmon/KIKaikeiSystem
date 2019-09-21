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
    partial class IkkatsuSyoriRow : AbstractDBGridRow
    {
        public models.db.KaikeiDatabase db;

        public IkkatsuSyoriRow() {
            InitializeComponent();

            penForBottomLine = null;
            penForLeftLine = null;
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            int torihikiKubunId = (int)rowData.GetLong("torihiki_kubun", -1);
            this.BackColor = Color.White;

            base.SetRowDataToLabel(lblTsuikaKubun, rowData);
            lblKaikeiKubun.Text = rowData.GetMasterStr(lblKaikeiKubun.Tag as string, "name", "", db.MTKaikeiKubun);
            lblTorihikiKubun.Text = rowData.GetMasterStr(lblTorihikiKubun.Tag as string, "name", "", db.MTTorihikiKubun);

            base.SetRowDataToLabel(lblKashikataKamokuCode, rowData);
            base.SetRowDataToLabel(lblKashikataHojoSeiri, rowData);
            base.SetRowDataToLabel(lblKarikataKamokuCode, rowData);
            base.SetRowDataToLabel(lblKarikataHojoSeiri, rowData);
            base.SetRowDataToLabelAsAmount(lblKingaku, rowData);
            base.SetRowDataToLabel(lblTekiyouId, rowData);
            base.SetRowDataToLabel(lblComment, rowData);
            base.SetRowDataToCheckBox(chkTouroku, rowData);

            lblKarikataKamoku.Text = db.MTKanjouKamoku.GetKamokuStr((int)rowData.GetLong("karikata_kamoku_id", -1), torihikiKubunId);
            lblKashikataKamoku.Text = db.MTKanjouKamoku.GetKamokuStr((int)rowData.GetLong("kashikata_kamoku_id", -1), torihikiKubunId);
            lblKarikataHojo.Text = db.MTKanjouKamoku.GetKamokuStr((int)rowData.GetLong("karikata_hojo_id", -1), torihikiKubunId);
            lblKashikataHojo.Text = db.MTKanjouKamoku.GetKamokuStr((int)rowData.GetLong("kashikata_hojo_id", -1), torihikiKubunId);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
            db = aDB as models.db.KaikeiDatabase;
        }


        public override void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            db = (originalRow as IkkatsuSyoriRow).db;
        }


        public override void SetFocusToFirstControl() {

        }

        private void chkTouroku_CheckedChanged(object sender, EventArgs e) {
            CallUpdateValueAction("touroku", GetControlValue(sender as Control));
        }
    }
}
