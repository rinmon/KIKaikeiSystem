using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.views.controls
{
    public partial class AmountTextBox : TextBox
    {
        public AmountTextBox() {
            InitializeComponent();

            this.TextAlign = HorizontalAlignment.Right;
            this.Enter += delegate(object sender, EventArgs arg) {
                (sender as TextBox).SelectAll();
            }; 
        }


        public bool IsValidAmount() {
            return helper.Converter.AmountToLongObj(this.Text) != null;
        }


        public long Amount {
            get {
                if (IsValidAmount()) {
                    return helper.Converter.AmountToLongObj(this.Text).Value;
                }
                else {
                    return 0;
                }
            }
            set {
                this.Text = helper.Converter.LongToAmount(value);
                this.SelectionStart = this.Text.Length + 1;
            }
        }


        public string AmountStr {
            set {
                int amount;
                if (int.TryParse(value, out amount) == true) {
                    this.Text = helper.Converter.LongToAmount(amount);
                }
                else {
                    this.Text = value;
                }
                this.SelectionStart = this.Text.Length + 1;
            }
        }
    }
}
