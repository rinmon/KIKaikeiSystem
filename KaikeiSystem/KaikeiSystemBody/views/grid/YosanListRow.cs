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
    partial class YosanListRow : AbstractDBGridRow
    {
        private models.db.KaikeiDatabase db;

        public event Action<object> ShowButtonClicked;

        public YosanListRow() {
            InitializeComponent();

            btnShow.Click += (s, e) => ShowButtonClicked(this);
            SetDefaultIndicator();

            db = null;
        }


        // Rowデータの設定
        override protected void SetRowDataSub(models.db.Row rowData) {
            int year = (int)rowData.GetLong("nenndo", 0);
            DateTime date = new DateTime(year, 4, 1);
            lblYear.Text = helper.Converter.DateTimeToWarekiGengouKanji(date) + helper.Converter.DateTimeToWarekiYear(date).ToString() + "年";
            lblKeiriKubun.Text = rowData.GetMasterStr("kaikei_kubun", "name", "", db.MTKaikeiKubun);
            lblYosanKubun.Text = rowData.GetMasterStr("yosan_kubun", "yosan_kubun", "", db.MTYosanKubun);
            lblHoseiKaisuu.Text = rowData.GetLong("hosei_kaisuu", -1).ToString();
        }


        // マスタ情報の設定
        override public void SetMasterTables(models.db.AbstractDatabase aDB) {
            db = aDB as models.db.KaikeiDatabase;
        }


        override public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
            db = (originalRow as YosanListRow).db;
        }


        public override void SetFocusToFirstControl() {
        }
    }
}
