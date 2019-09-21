using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaikeiSystemBody.models;

namespace KaikeiSystemBody.controllers
{
    /// <summary>
    /// アプリケーションの状態を表す
    /// </summary>
    abstract class AbstractActivity
    {
        private Context context_;
        
        public enum State {
            Hide,
            Show,
            ShowModal
        }


        public abstract Form Form {
            get;
        }

        public Context Context{
            get { return this.context_; }
        }

        public MainController MainController {
            get;
            set;
        }

        public State FormState {
            get;
            private set;
        }

        public void HideForm(){
            OnDeactivated();
            Form.Hide();
            FormState = State.Hide;
        }

        public void ShowForm(int x, int y, Context context, object option) {
            Form.StartPosition = FormStartPosition.Manual;
            Form.Left = x;
            Form.Top = y;
            context_ = context;

            OnActivated(option);

            FormState = State.Show;
            Form.TopMost = true;
            Form.Show();
            Form.Activate();
            Form.TopMost = false;
        }

        public void ShowFormModal(int centerX, int centerY, Context context, object option) {
            Form.StartPosition = FormStartPosition.Manual;
            Form.Left = Math.Max(centerX - Form.Width / 2, 0);
            Form.Top = Math.Max(centerY - Form.Height / 2, 0);
            context_ = context;

            OnActivated(option);
            FormState = State.ShowModal;
            Form.ShowDialog();
        }

        virtual protected void OnActivated(object option){
        }

        virtual protected void OnDeactivated() {
        }
    }
}
