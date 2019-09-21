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
    partial class YosanKakuninPopup : Form
    {
        private models.db.KaikeiDatabase db;

        public event Action PopupClosed;
        public event Action CloseButtonClicked;
        public event Action SearchKamokuButtonClicked;
        public event Action SearchHojoButtonClicked;

        public YosanKakuninPopup()
        {
            InitializeComponent();

            this.FormClosed += (s, e) => PopupClosed();
        }


        public void SetDatabase(models.db.KaikeiDatabase aDB) {
            db = aDB;
            cmbKaikeiKubunForKamoku.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, true);
            cmbYosanKubunForKamoku.InitRowsWithMTYosanKubun(db.MTYosanKubun);

            cmbKaikeiKubunForHojo.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, true);
            cmbYosanKubunForHojo.InitRowsWithMTYosanKubun(db.MTYosanKubun);
        }


        public grid.YosanKamokuKakuninGrid KamokuGrid {
            get {
                return yosanKamokuGrid;
            }
        }

        public int KamokuSearchConditionKeiriKubun {
            get {
                return cmbKaikeiKubunForKamoku.SelectedKeyAsInt;
            }
        }

        public int KamokuSearchConditionYosanKubun {
            get {
                return cmbYosanKubunForKamoku.SelectedKeyAsInt;
            }
        }

        public int KamokuSearchConditionYear {
            get {
                string dateStr = txtYearForKamoku.Text + "/4/1";
                if(helper.Converter.IsDateStr(dateStr)){
                    return helper.Converter.DateStrToDateTime(dateStr).Year;
                }
                else{
                    return -1;
                }
            }
        }


        public grid.YosanHojoKakuninGrid HojoGrid {
            get {
                return yosanHojoGrid;
            }
        }

        public int HojoSearchConditionKeiriKubun {
            get {
                return cmbKaikeiKubunForHojo.SelectedKeyAsInt;
            }
        }

        public int HojoSearchConditionYosanKubun {
            get {
                return cmbYosanKubunForHojo.SelectedKeyAsInt;
            }
        }

        public int HojoSearchConditionYear {
            get {
                string dateStr = txtYearForHojo.Text + "/4/1";
                if (helper.Converter.IsDateStr(dateStr)) {
                    return helper.Converter.DateStrToDateTime(dateStr).Year;
                }
                else {
                    return -1;
                }
            }
        }


        private void btnSearchKamoku_Click(object sender, EventArgs e) {
            SearchKamokuButtonClicked();
        }

        private void button1_Click(object sender, EventArgs e) {
            CloseButtonClicked();
        }

        private void btnSearchHojo_Click(object sender, EventArgs e) {
            SearchHojoButtonClicked();
        }
    }
}
