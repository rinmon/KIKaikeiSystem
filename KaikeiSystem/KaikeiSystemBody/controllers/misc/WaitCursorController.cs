using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers.misc
{
    class WaitCursorController
    {
        static private Cursor preCursor;
        
        
        static public void Begin() {
            preCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
        }

        static public void EndWithSuccessMsg() {
            Cursor.Current = preCursor;
            helper.MsgBox.Info(Properties.Resources.MsgSucceeded);
        }

        static public void End() {
            Cursor.Current = preCursor;
        }
    }
}
