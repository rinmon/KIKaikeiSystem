using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers.misc
{
    class DelayTimerController
    {
        private Form ownerForm;
        private Timer timer;
        private event Action delayedProc;
        private bool active;

        public DelayTimerController(Form owner = null) {
            ownerForm = owner;

            timer = new Timer();//ownerForm.Container);
            timer.Enabled = false;
            timer.Tick += new System.EventHandler(timerTick);
            active = false;
        }

        public void SetDelayedProc(Action proc) {
            if (active == false) {
                active = true;
                delayedProc = proc;
                timer.Interval = 10;
                timer.Enabled = true;
            }
        }


        private void timerTick(object sender, EventArgs e) {
            timer.Interval = 1000000;
            timer.Enabled = false;
            if (delayedProc != null) {
                delayedProc();
            }
            delayedProc = null;
            active = false;
        }
    }
}
