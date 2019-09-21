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
    partial class ZenkiKurikoshiKamokuKubunRow : AbstractDBGridRow
    {
        private models.db.KaikeiDatabase db;

        public ZenkiKurikoshiKamokuKubunRow() {
            InitializeComponent();

            SetDefaultHandlersToControls();
            SetDefaultIndicator();

            db = null;
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            models.db.Row kanjouKamokuRow = db.MTKanjouKamoku.GetRowFromKamokuKubun(rowData.GetLong("kamoku_kubun_id", -1));
            if (kanjouKamokuRow != null) {
                txtTaisyakuKubun.Text = kanjouKamokuRow.GetMasterStr("taisyaku_kubun_id", "caption", "", db.MTTaisyakuKubun);
            }
            else{
                txtTaisyakuKubun.Text = "";
                models.db.Row childKamokuKubunRow = db.MTKamokuKubun.GetFirstRow("where parent_id=" + rowData.GetLong("kamoku_kubun_id", -1));
                if (childKamokuKubunRow != null) {
                    models.db.Row childKanjouKamokuRow = db.MTKanjouKamoku.GetRowFromKamokuKubun(childKamokuKubunRow.GetId());
                    if (childKanjouKamokuRow != null) {
                        txtTaisyakuKubun.Text = childKanjouKamokuRow.GetMasterStr("taisyaku_kubun_id", "caption", "", db.MTTaisyakuKubun);
                    }
                }
            }

            txtKamokuKubun.Text = rowData.GetMasterStr("kamoku_kubun_id", "name", "", db.MTKamokuKubun);
            amountKurikoshi.AmountStr = rowData.GetStr("zenki_kurikoshi_gaku");
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
            db = aDB as models.db.KaikeiDatabase;
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            db = (originalRow as ZenkiKurikoshiKamokuKubunRow).db;
        }


        public override void SetFocusToFirstControl() {
            txtKamokuKubun.Select();
        }
    }
}
