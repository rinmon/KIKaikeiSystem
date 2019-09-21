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
    partial class KeySelectorTextBox : TextBox
    {
        public delegate string ComboKey2TextDelegate(string comboKey);
        public delegate string Text2ComboKeyDelegate(string text);
        public event ComboKey2TextDelegate ComboKey2Text;
        public event Text2ComboKeyDelegate Text2ComboKey;

        private MultiColumnComboBox bindedComboBox;

        public KeySelectorTextBox() {
            InitializeComponent();

            ComboKey2Text = null;
            Text2ComboKey = null;
        }


        public void BindMultiColumnComboBox(MultiColumnComboBox combo) {
            bindedComboBox = combo;

            combo.SelectedIndexChanged += delegate(object sender, EventArgs args) {
                if (bindedComboBox.SelectedIndex != -1) {
                    string val = bindedComboBox.SelectedKeyAsStr;
                    if (ComboKey2Text != null) {
                        val = ComboKey2Text(val);
                    }
                    this.Text = val;
                }
            };

            this.Leave += (s, e) => SyncComboBoxItem();
        }


        public void SyncComboBoxItem() {
            string val = this.Text;
            if (Text2ComboKey != null) {
                val = Text2ComboKey(val);
            }

            if (val != bindedComboBox.SelectedKeyAsStr) {
                bindedComboBox.SelectRowByKeyValue(val);
            }
        }
    }
}
