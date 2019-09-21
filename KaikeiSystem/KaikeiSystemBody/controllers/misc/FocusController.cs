using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers.misc
{
    class FocusController
    {
        private Control rootControl;

        public FocusController(Control root) {
            rootControl = root;

            AddEnterFocusMethodToControl(root);
        }

        private void AddEnterFocusMethodToControl(Control control) {
            foreach (Control child in control.Controls) {
                if (child is views.controls.DateInputPanel) {
                    views.controls.DateInputPanel pnl = child as views.controls.DateInputPanel;
                    pnl.TextBoxKeyDown += control_KeyDown;
                    pnl.TextBoxPreviewKeyDown += Control_PreviewKeyDown;
                }
                else if (child is RadioButton || child is CheckBox || child is Button || child is ComboBox || child is DateTimePicker) {
                    child.KeyDown += control_KeyDown;
                    child.PreviewKeyDown += Control_PreviewKeyDown;
                }
                else if (child is TextBox && (child as TextBox).Multiline == false) {
                    child.KeyDown += control_KeyDown;
                    child.PreviewKeyDown += Control_PreviewKeyDown;
                }
                AddEnterFocusMethodToControl(child);
            }
        }

        private void control_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
            }
        }

        private void Control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            var target = sender as System.Windows.Forms.Control;

            if (e.KeyCode == Keys.Enter && !(sender is Button) && !e.Shift) {
                rootControl.SelectNextControl(target, true, true, true, true);
                e.IsInputKey = true;
            }
        }
    }
}
