using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.views
{
    partial class KurikoshiForm : Form
    {
        private models.db.KaikeiDatabase db;

        public event Action AddButtonClicked;
        public event Action SearchButtonClicked;
        public event Action DeleteButtonClicked;
        public event Action CloseButtonClicked;
        public event Action JikiKurikoshiChanged;
        public event Action ZenkimatsuShiharaiShikinZandakaChanged;


        public views.grid.PanelGrid<views.grid.ZenkiKurikoshiKamokuKubunRow> DaikubunGrid {
            get {
                return daikubunGrid;
            }
        }

        public views.grid.PanelGrid<views.grid.ZenkiKurikoshiKamokuKubunRow> ChukubunGrid {
            get {
                return chukubunGrid;
            }
        }

        public views.grid.PanelGrid<views.grid.ZenkiKurikoshiKamokuKubunRow> SyoukubunGrid {
            get {
                return syoukubunGrid;
            }
        }

        public views.grid.PanelGrid<views.grid.ZenkiKurikoshiKamokuKubunRow> HojokamokuGrid {
            get {
                return hojoGrid;
            }
        }

        private long zenkimatsuShiharaiShikinZandaka = 0;
        public long ZenkimatsuShiharaiShikinZandaka {
            get {
                return zenkimatsuShiharaiShikinZandaka;
            }
            set {
                zenkimatsuShiharaiShikinZandaka = value;
                amountZenkimatsuShiharaiShikinZandaka.Amount = zenkimatsuShiharaiShikinZandaka;
            }
        }

        private long jikiKurikoshi = 0;
        public long JikiKurikoshi {
            get {
                return jikiKurikoshi;
            }
            set {
                jikiKurikoshi = value;
                amountJikiKurikoshi.Amount = jikiKurikoshi;
            }
        }

        public int Year {
            get {
                if (dateInput.Date != null) {
                    return dateInput.Date.Value.Year;
                }
                else {
                    return -1;
                }
            }
            set {
                dateInput.Date = new DateTime(value, 4, 1);
            }
        }

        public int KaikeiKubun {
            get {
                if (cmbKaikeiKubun.SelectedIndex == -1) {
                    return -1;
                }
                else {
                    return (int)cmbKaikeiKubun.SelectedKey;
                }
            }
        }

        
        public KurikoshiForm() {
            InitializeComponent();

            btnAdd.Click += (s, e) => AddButtonClicked();
            btnSearch.Click += (s, e) => SearchButtonClicked();
            btnDelete.Click += (s, e) => DeleteButtonClicked();
            btnClose.Click += (s, e) => CloseButtonClicked();

            amountZenkimatsuShiharaiShikinZandaka.Leave += delegate(object sender, EventArgs e) {
                if (zenkimatsuShiharaiShikinZandaka != amountZenkimatsuShiharaiShikinZandaka.Amount) {
                    ZenkimatsuShiharaiShikinZandaka = amountZenkimatsuShiharaiShikinZandaka.Amount;
                    ZenkimatsuShiharaiShikinZandakaChanged();
                }
                else {
                    ZenkimatsuShiharaiShikinZandaka = amountZenkimatsuShiharaiShikinZandaka.Amount;
                }
            };

            amountJikiKurikoshi.Leave += delegate(object sender, EventArgs e) {
                if (jikiKurikoshi != amountJikiKurikoshi.Amount) {
                    JikiKurikoshi = amountJikiKurikoshi.Amount;
                    JikiKurikoshiChanged();
                }
                else {
                    JikiKurikoshi = amountJikiKurikoshi.Amount;
                }
            };
        }

        public void SetGengou(string gengou) {
            dateInput.GengouStr = gengou;
        }


        public void SetDatabase(models.db.KaikeiDatabase aDB) {
            if (db != aDB) {
                db = aDB;
                cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, true);
                cmbKaikeiKubun.SelectedIndex = 0;
            }
        }

        private void pnlKamokuYosanBase_Paint(object sender, PaintEventArgs e) {

        }
    }
}
