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
    public partial class FormattedViewTextBox : TextBox
    {
        private bool inEditing;
        private string value_;

        public delegate string FormatTextDelegate(string value);
        public delegate void ValueChangedDelegate(object sender, EventArgs e);
        public event FormatTextDelegate FormatText;
        public event ValueChangedDelegate ValueChanged;

        public string Value {
            get {
                if (inEditing == false) {
                    return value_;
                }
                else {
                    return this.Text;
                }
            }
            set {
                value_ = value;
                if (inEditing == true || FormatText == null) {
                    this.Text = value_;
                }
                else {
                    this.Text = FormatText(value_);
                }
            }
        }


        public FormattedViewTextBox() {
            InitializeComponent();

            inEditing = false;
            

            this.Enter += delegate(object sender, EventArgs e) {
                inEditing = true;
                this.Text = value_;
            };

            this.Leave += delegate(object sender, EventArgs e) {
                inEditing = false;
                if (value_ != this.Text) {
                    value_ = this.Text;
                    ValueChanged(this, null);
                }
                this.Text = FormatText(value_);
            };
        }
    }
}
