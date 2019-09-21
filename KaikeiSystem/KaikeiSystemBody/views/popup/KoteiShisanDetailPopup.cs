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
    partial class KoteiShisanDetailPopup : Form
    {
        private models.db.KaikeiDatabase db;

        public event Action PopupClosed;
        public event Action FirstButtonClickekd;
        public event Action EndButtonClicked;
        public event Action PrevButtonClicked;
        public event Action NextButtonClicked;
        public event Action NewButtonClicked;
        public event Action DeleteButtonClicked;
        public event Action IkkatsuSyoukyakuButtonClicked;
        public event Action CloseButtonClicked;
        public event Action SyoukyakuButtonClicked;
        public event Action DeleteMeisaiButtonClicked;
        public event views.grid.AbstractPanelGridRow.Column_UpdateValueDelegate ColumnValueChanged;


        public grid.SyoukyakuMeisaiGrid SyoukyakuMeisaiGrid {
            get { return syoukyakuMeisaiGrid1; }
        }

        public KoteiShisanDetailPopup() {
            InitializeComponent();

            this.FormClosed += (s, e) => PopupClosed();
            btnFirst.Click += (s, e) => FirstButtonClickekd();
            btnEnd.Click += (s, e) => EndButtonClicked();
            btnPrev.Click += (s, e) => PrevButtonClicked();
            btnNext.Click += (s, e) => NextButtonClicked();
            btnNew.Click += (s, e) => NewButtonClicked();
            btnDelete.Click += (s, e) => DeleteButtonClicked();
            btnIkkatsuSyoukyaku.Click += (s, e) => IkkatsuSyoukyakuButtonClicked();
            btnSyoukyakuJikkou.Click += (s, e) => SyoukyakuButtonClicked();
            btnDeleteMeisai.Click += (s, e) => DeleteMeisaiButtonClicked();
            rowDetailMain.Column_UpdateValueAction += (sender, column, value) => ColumnValueChanged(sender, column, value);
            rowDetailSub.Column_UpdateValueAction += (sender, column, value) => ColumnValueChanged(sender, column, value);
            btnClose.Click += (s, e) => CloseButtonClicked();
        }


        public void SetRowData(models.db.Row row) {
            rowDetailMain.SetRowData(row, false);
            rowDetailSub.SetRowData(row, false);
        }

        public void SetDatabase(models.db.KaikeiDatabase aDB) {
            db = aDB;

            rowDetailMain.SetMasterTables(db);
            rowDetailSub.SetMasterTables(db);
        }
    }
}
