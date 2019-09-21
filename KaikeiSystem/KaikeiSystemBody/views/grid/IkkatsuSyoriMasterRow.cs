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
    partial class IkkatsuSyoriMasterRow : AbstractDBGridRow
    {
        private models.db.KaikeiDatabase db;

        public IkkatsuSyoriMasterRow() {
            InitializeComponent();

            db = null;

            btnDelete.Click += base.DefaultHandlerRemoveRowButtonClicked;
            SetDefaultHandlersToControls();
            SetDefaultIndicator();
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            int torihikiKubunId = (int)rowData.GetLong("torihiki_kubun", -1);

            base.SetRowDataToTextBox(txtTsuikaKubun, rowData);
            base.SetRowDataToMTCombo(cmbKaikeiKubun, rowData);
            base.SetRowDataToMTCombo(cmbTorihikiKubun, rowData);
            base.SetRowDataToTextBox(txtKashikataKamokuCode, rowData);
            base.SetRowDataToTextBox(txtKashikataHojoSeiri, rowData);
            base.SetRowDataToTextBox(txtKarikataKamokuCode, rowData);
            base.SetRowDataToTextBox(txtKarikataHojoSeiri, rowData);
            base.SetRowDataToAmount(amountKingaku, rowData);
            base.SetRowDataToTextBox(txtTekiyou, rowData);
            base.SetRowDataToTextBox(txtComment, rowData);
            base.SetRowDataToCheckBox(chkTouroku, rowData);

            lblKarikataKamoku.Text = db.MTKanjouKamoku.GetKamokuStr((int)rowData.GetLong("karikata_kamoku_id", -1), torihikiKubunId);
            lblKashikataKamoku.Text = db.MTKanjouKamoku.GetKamokuStr((int)rowData.GetLong("kashikata_kamoku_id", -1), torihikiKubunId);
            lblKarikataHojo.Text = db.MTKanjouKamoku.GetKamokuStr((int)rowData.GetLong("karikata_hojo_id", -1), torihikiKubunId);
            lblKashikataHojo.Text = db.MTKanjouKamoku.GetKamokuStr((int)rowData.GetLong("kashikata_hojo_id", -1), torihikiKubunId);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
            db = aDB as models.db.KaikeiDatabase;

            cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, true);
            cmbTorihikiKubun.InitRowsWithMTTorihikiKubun(db.MTTorihikiKubun);
        }

        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            db = (originalRow as IkkatsuSyoriMasterRow).db;

            cmbKaikeiKubun.CopyRows((originalRow as IkkatsuSyoriMasterRow).cmbKaikeiKubun);
            cmbTorihikiKubun.CopyRows((originalRow as IkkatsuSyoriMasterRow).cmbTorihikiKubun);
        }

        public override void SetFocusToFirstControl() {
            txtTsuikaKubun.Select();
        }
    }
}
