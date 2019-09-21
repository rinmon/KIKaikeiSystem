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
    partial class YosanForm : Form
    {
        private models.db.KaikeiDatabase db;

        public event Action SearchButtonClicked;
        public event Action DataCheckButtonClicked;
        public event Action YosanListButtonClicked;
        public event Action NewButtonClicked;
        public event Action HikitsugiButtonClicked;
        public event Action DeleteButtonClicked;
        public event Action RedrawButtonClicked;
        public event Action ShowKamokuPopupButtonClicked;
        public event Action CloseButtonClicked;
        public event Action CompareButtonClicked;
        public event Action PrintButtonClicked;


        public YosanForm() {
            InitializeComponent();

            btnSearch.Click += (s, e) => SearchButtonClicked();
            btnDataCheck.Click += (s, e) => DataCheckButtonClicked();
            btnYosanList.Click += (s, e) => YosanListButtonClicked();
            btnNew.Click += (s, e) => NewButtonClicked();
            btnHikitsugi.Click += (s, e) => HikitsugiButtonClicked();
            btnDelete.Click += (s, e) => DeleteButtonClicked();
            btnRedraw.Click += (s, e) => RedrawButtonClicked();
            btnShowKamoku.Click += (s, e) => ShowKamokuPopupButtonClicked();
            btnClose.Click += (s, e) => CloseButtonClicked();
            btnCompare.Click += (s, e) => CompareButtonClicked();
            btnPrint.Click += (s, e) => PrintButtonClicked();


            cmbYosanKubun.SelectedIndexChanged += delegate(object sender, EventArgs e) {
                if (cmbYosanKubun.SelectedKeyAsInt == (int)models.constants.MTYosanKubun.TuujouYosan) {
                    HoseiKaisuu = 0;
                }
            };

            cmbKaikeiKubun.SelectedIndexChanged += delegate(object sender, EventArgs e) {
                if (cmbKaikeiKubun.SelectedIndex == -1) {
                    KaikeiKubun = -1;
                }
                else {
                    KaikeiKubun = (int)cmbKaikeiKubun.SelectedKey;
                }
            };
        }


        public int Year{
            get {
                if (dateInput.Date != null) {
                    return dateInput.Date.Value.Year;
                }
                else {
                    return -1;
                }
            }
            set {
                if (value > 0) {
                    dateInput.Date = new DateTime(value, 4, 1);
                }
                else {
                    dateInput.Date = null;
                }
            }
        }

        private int kaikeiKubun = -1;
        public int KaikeiKubun {
            get {
                return kaikeiKubun;
            }
            set {
                cmbKaikeiKubun.SelectRowByKeyValue(value);
                kaikeiKubun = value;
            }
        }

        public int YosanKubun {
            get {
                if (cmbYosanKubun.SelectedIndex == -1) {
                    return -1;
                }
                else {
                    return (int)cmbYosanKubun.SelectedKey;
                }
            }
            set {
                cmbYosanKubun.SelectRowByKeyValue(value);
            }
        }

        public int HoseiKaisuu {
            get {
                return helper.Converter.ObjToInt(txtHoseiKaisuu.Text, -1);
            }
            set {
                txtHoseiKaisuu.Text = value.ToString();
            }
        }

        public System.Drawing.Rectangle DaikubunYosanBaseBounds {
            get {
                return pnlDaikubunYosanBase.Bounds;
            }
        }

        public System.Drawing.Rectangle ChukubunYosanBaseBounds {
            get {
                return pnlChukubunYosanBase.Bounds;
            }
        }

        public System.Drawing.Rectangle SyoukubunYosanBaseBounds {
            get {
                return pnlSyoukubunYosanBase.Bounds;
            }
        }

        public System.Drawing.Rectangle HojoKamokuYosanBaseBounds {
            get {
                return pnlHojokamokuYosanBase.Bounds;
            }
        }

        public System.Drawing.Point YosanYobihiBaseLocation {
            get {
                System.Drawing.Point pt = new Point();
                pt.X = pnlHojokamokuYosanBase.Location.X;
                pt.Y = pnlHojokamokuYosanBase.Location.Y + pnlHojokamokuYosanBase.Size.Height;
                return pt;
            }
        }


        public void SetGengou(string gengou) {
            dateInput.GengouStr = gengou;
        }


        public void SetDatabase(models.db.KaikeiDatabase aDB) {
            if (db != aDB) {
                db = aDB;
                cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, true);
                cmbYosanKubun.InitRowsWithMTYosanKubun(db.MTYosanKubun);

                cmbKaikeiKubun.SelectedIndex = 0;
                cmbYosanKubun.SelectedIndex = 0;
            }
        }


        public void SetSelectedDaikubunInfo(string name, long yosan) {
            lblSelectedDaikubun.Text = name;
            lblSelectedDaikubunYosan.Text = helper.Converter.LongToAmount(yosan);
        }

        public void SetSelectedChukubunInfo(long yosan, long jisseki, long sagaku) {
            lblKamokuYosan.Text = helper.Converter.LongToAmount(yosan);
            lblKamokuJisseki.Text = helper.Converter.LongToAmount(jisseki);
            lblKamokuSagaku.Text = helper.Converter.LongToAmount(sagaku);
        }

        public void SetSelectedSyoukubunInfo(long yosan, long jisseki, long sagaku) {
            lblHojoYosan.Text = helper.Converter.LongToAmount(yosan);
            lblHojoJisseki.Text = helper.Converter.LongToAmount(jisseki);
            lblHojoSagaku.Text = helper.Converter.LongToAmount(sagaku);
        }

        public void SetSummaryInfo(long syuunyuu, long shisyutsu, long yobihi, long zandaka, long sagaku) {
            lblSyuunyuuGoukei.Text = helper.Converter.LongToAmount(syuunyuu);
            lblShisyutsuGoukei.Text = helper.Converter.LongToAmount(shisyutsu);
            lblYobihiGoukei.Text = helper.Converter.LongToAmount(yobihi);
            lblZandakaGoukei.Text = helper.Converter.LongToAmount(zandaka);
            lblSagaku.Text = helper.Converter.LongToAmount(sagaku);
        }


        public void SetHoseiKaisuuMsg(int year, int hoseiKaisuuMax, bool clearMsg = false) {
            if(clearMsg){
                lblHoseiKaisuuMsg.Text = "";
            }
            else{
                lblHoseiKaisuuMsg.Text = helper.Helper.GetHoseiKaisuuMsg(year, hoseiKaisuuMax);
            }
        }

        private void YosanForm_Load(object sender, EventArgs e) {
            this.Size = new Size(this.Size.Width, this.Size.Height + this.statusStrip.Size.Height);
        }
    }
}
