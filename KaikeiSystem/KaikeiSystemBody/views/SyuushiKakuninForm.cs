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
    partial class SyuushiKakuninForm : Form
    {
        public event Action<DateTime?> TargetDateChanged;
        public event Action ShowAllButtonClicked;
        public event Action ShowAddDenpyouViewButtonClicked;
        public event Action ShowEditDenpyouViewButtonClicked;
        public event Action ReturnToMenuButtonClicked;

        public SyuushiKakuninForm() {
            InitializeComponent();

            cmbTargetDate.TextChanged += (s, e) => TargetDateChanged(cmbTargetDate.SelectedKey as DateTime?);
            btnShowAll.Click += (s, e) => ShowAllButtonClicked();
            btnAddDenpyou.Click += (s,e) => ShowAddDenpyouViewButtonClicked();
            btnEditDenpyou.Click += (s, e) => ShowEditDenpyouViewButtonClicked();
            btnReturnToMenu.Click += (s, e) => ReturnToMenuButtonClicked();

            cmbTargetDate.InitColumns(2, 1, 0);
            cmbTargetDate.SetColumnVisibility(1, false);
        }


        public grid.PanelGrid<grid.SyuushiKakuninRow> Grid {
            get { return grid; }
        }

        public string SumAmountText {
            get { return txtSumAmount.Text; }
            set { txtSumAmount.Text = value; }
        }

        public void ClearTargetDateComboBox() {
            cmbTargetDate.Items.Clear();
        }

        public DateTime? TargetDate {
            get {
                return cmbTargetDate.SelectedKey as DateTime?;
            }
            set {
                if (value == null) {
                    if (cmbTargetDate.SelectedKey != null) {
                        cmbTargetDate.SelectedIndex = -1;
                    }
                }
                else if ((cmbTargetDate.SelectedKey as DateTime?).Value != value.Value) {
                    cmbTargetDate.SelectRowByKeyValue(value);
                }
            }
        }


        public void AddTargetDateComboBoxItem(DateTime date) {
            string str = date.ToString("gyy年MM月", helper.Converter.JpCultureInfo);
            cmbTargetDate.AddRow(str, date);
        }

        private void SyuushiKakuninForm_Load(object sender, EventArgs e)
        {
            if (this.Size.Width < this.grid.Size.Width) {
                this.Size = new Size(this.grid.Size.Width + SystemInformation.VerticalScrollBarWidth, this.Size.Height);
            }
        }
    }
}
