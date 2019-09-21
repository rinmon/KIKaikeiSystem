using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers.misc
{
    class StickyWindowController
    {
        private Form parentForm;
        private Form childForm;
        private int relativePosX, relativePosY;
        private bool updateRelativePos;


        public StickyWindowController(Form parentForm_, Form childForm_) {
            parentForm = parentForm_;
            childForm = childForm_;

            parentForm.Move += OnParentFormMove;
            childForm.Move += OnChildFormMove;

            updateRelativePos = true;
            OnChildFormMove(null, null);
        }


        private void OnParentFormMove(object sender, EventArgs e) {
            var location = new System.Drawing.Point(
                parentForm.Location.X + relativePosX,
                parentForm.Location.Y + relativePosY
            );
            updateRelativePos = false;
            childForm.Location = location;
            updateRelativePos = true;
        }

        private void OnChildFormMove(object sender, EventArgs e) {
            if (updateRelativePos == true) {
                relativePosX = childForm.Location.X - parentForm.Location.X;
                relativePosY = childForm.Location.Y - parentForm.Location.Y;
            }
        }
    }
}
