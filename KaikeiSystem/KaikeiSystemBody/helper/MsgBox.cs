using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.helper
{
    // メッセージボックスのラッパー関数群
    class MsgBox
    {
        public static void Show(string msg, string caption, MessageBoxButtons btn = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information) {
            System.Timers.Timer timer = new System.Timers.Timer();

            timer.AutoReset = false;
            timer.Interval = 10;
            timer.Elapsed += delegate(object source, System.Timers.ElapsedEventArgs e) {
                MessageBox.Show(msg, caption, btn, icon);
            };
            timer.Enabled = true;
        }

        public static void ShowMsg(string msg, string type) {
            if (type == "warn") {
                helper.MsgBox.Warn(msg);
            }
            else if (type == "err") {
                helper.MsgBox.Err(msg);
            }
            else if (type == "info") {
                helper.MsgBox.Info(msg);
            }
            else {
                helper.MsgBox.Info(msg);
            }
        }


        public static void Warn(string msg) {
            MessageBox.Show(msg, KaikeiSystemBody.Properties.Resources.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Info(string msg) {
            MessageBox.Show(msg, KaikeiSystemBody.Properties.Resources.CaptionConfirm, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Err(string msg) {
            MessageBox.Show(msg, KaikeiSystemBody.Properties.Resources.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
