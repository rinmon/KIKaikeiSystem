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
    partial class YosanDaikubunRow : AbstractDBGridRow
    {
        models.db.KaikeiDatabase db;

        public YosanDaikubunRow() {
            InitializeComponent();

            SetDefaultHandlersToControls();
            SetDefaultIndicator();

            db = null;
        }

        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            txtKaikeiKubun.Text = rowData.GetMasterStr("kaikei_kubun", "name", "", db.MTKaikeiKubun);
            txtKamokuKubun.Text = rowData.GetMasterStr("kamoku_kubun_id", "name", "", db.MTKaikeiKubun);
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
            db = aDB as models.db.KaikeiDatabase;
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            db = (originalRow as YosanDaikubunRow).db;
        }


        public override void SetFocusToFirstControl() {
            txtKaikeiKubun.Select();
        }
            

        override protected object GetControlValue(Control control) {
            object value = base.GetControlValue(control);

            if (control.Tag as string == "daikubun_id") {
                models.db.Row daikubunRow = db.MTDaikubun.GetRowFromCodeCache(value as string);
                if (daikubunRow != null) {
                    return daikubunRow.GetLong("id", 0);
                }
            }

            return value;
        }
    }
}
