using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace KaikeiSystemBody.views.reports
{
    /// <summary>
    /// BalanceSheetShisan の概要の説明です。
    /// </summary>
    partial class BalanceSheetSub2 : DataDynamics.ActiveReports.ActiveReport
    {
        private models.db.KaikeiDatabase db;

        public BalanceSheetSub2() {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();
        }

        public void SetDB(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }

        private void detail_Format(object sender, EventArgs e) {
            int id = helper.Converter.ObjToInt(txtKamokuId.Text, -1);
            txtKamoku.Text = "  " + db.MTKamokuKubun.GetRowById(id).GetStr("name");
        }

        private void groupHeader1_Format(object sender, EventArgs e) {
            int id = helper.Converter.ObjToInt(txtDaikubunId.Text, -1);
            txtDaikubunName.Text = "【" + db.MTKamokuKubun.GetRowById(id).GetStr("name") + "】";
        }
    }
}
