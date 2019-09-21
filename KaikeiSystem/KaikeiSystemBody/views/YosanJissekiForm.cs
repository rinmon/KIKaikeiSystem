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
    partial class YosanJissekiForm : Form
    {
        public event Action CalcButtonClicked;
        public event Action CloseButtonClicked;
        public event Action YosanButtonClicked;
        public event Action PrintButtonClicked;
        public event Action KaikeiKubunSelectionChanged;
        public event Action KamokuRowSelectionChanged;

        private Dictionary<int, int> rowIndex2KamokuId;
        private models.db.KaikeiDatabase db;


        public int Year{
            get {
                if (dateInput.Date == null) {
                    return -1;
                }
                else {
                    return dateInput.Date.Value.Year;
                }
            }
        }


        public string YearWarekiGengou {
            get {
                return dateInput.GengouStr;
            }
        }

        public int YearWareki {
            get {
                return helper.Converter.ObjToInt(dateInput.YearStr, -1);
            }
        }


        public int HoseiKaisuu {
            get {
                return helper.Converter.ObjToInt(txtHoseikaisuu.Text, -1);
            }
        }


        public int KaikeiKubun {
            get {
                object key = cmbKaikeiKubun.SelectedKey;
                if(key != null){
                    return (int)key;
                }
                return -1;
            }
        }


        public int SelectedChukubunId {
            get {
                if (gridChukubun.SelectedRows.Count > 0 &&
                        rowIndex2KamokuId.ContainsKey(gridChukubun.SelectedRows[0].Index)) {
                    return rowIndex2KamokuId[gridChukubun.SelectedRows[0].Index];
                }
                else {
                    return -1;
                }
            }
        }

        
        public YosanJissekiForm() {
            rowIndex2KamokuId = new Dictionary<int, int>();

            InitializeComponent();

            btnCalc.Click += (s, e) => CalcButtonClicked();
            btnClose.Click += (s, e) => CloseButtonClicked();
            btnYosan.Click += (s, e) => YosanButtonClicked();
            btnPrint.Click += (s, e) => PrintButtonClicked();
            cmbKaikeiKubun.SelectedIndexChanged += (s, e) => KaikeiKubunSelectionChanged();
            gridChukubun.SelectionChanged += (s, e) => KamokuRowSelectionChanged();
        }


        protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
            base.ScaleControl(factor, specified);

            helper.View.SetDataGridViewFixedColumnAndAutoScale(factor, gridChukubun);
            helper.View.SetDataGridViewFixedColumnAndAutoScale(factor, gridHojoKamoku);
            helper.View.SetDataGridViewFixedColumnAndAutoScale(factor, gridKubun);
        }


        public void SetGengou(string gengou) {
            dateInput.GengouStr = gengou;
        }

        
        public void SetDatabase(KaikeiSystemBody.models.db.KaikeiDatabase aDB) {
            if (db != aDB) {
                db = aDB;
                cmbKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, false);
                cmbKaikeiKubun.SelectedIndex = -1;
            }
        }


        public void ClearKubunGrid() {
            gridKubun.Rows.Clear();
        }

        public void ClearChukubunGrid() {
            gridChukubun.Rows.Clear();
            rowIndex2KamokuId.Clear();
        }

        public void ClearSyoukubunKamokuGrid() {
            gridHojoKamoku.Rows.Clear();
        }


        public void AddKubunGridRow(string kubunName, long yosan, long jisseki) {
            gridKubun.Rows.Add(new object[]{
                kubunName,
                helper.Converter.LongToAmountWithoutYen(yosan),
                helper.Converter.LongToAmountWithoutYen(jisseki),
                helper.Converter.LongToAmountWithoutYen(yosan - jisseki)
            });
        }

        public void AddChukubunGridRow(int kamokuId, string kamokuCode, string kamoku, long yosan, long jisseki) {
            gridChukubun.Rows.Add(new object[]{
                kamokuCode,
                kamoku,
                helper.Converter.LongToAmountWithoutYen(yosan),
                helper.Converter.LongToAmountWithoutYen(jisseki),
                helper.Converter.LongToAmountWithoutYen(yosan - jisseki),
                (yosan == 0 ? 0 : (jisseki * 100.0 / yosan)).ToString("F1")
            });

            rowIndex2KamokuId.Add(gridChukubun.RowCount - 1, kamokuId);
        }


        public void AddSyoukubunGridRow(string seiriBangou, string hojoKamoku, long yosan, long jisseki) {
            gridHojoKamoku.Rows.Add(new object[]{
                seiriBangou,
                hojoKamoku,
                helper.Converter.LongToAmountWithoutYen(yosan),
                helper.Converter.LongToAmountWithoutYen(jisseki),
                helper.Converter.LongToAmountWithoutYen(yosan - jisseki),
                (yosan == 0 ? 0 : (jisseki * 100.0 / yosan)).ToString("F1")
            });
        }
    }
}
