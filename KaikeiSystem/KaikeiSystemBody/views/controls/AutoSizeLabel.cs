using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace KaikeiSystemBody.views.controls
{
    public partial class AutoSizeLabel : Label
    {
        private Font[] fontList;
        private Font defaultFont = null;

        [DefaultValue(false)]
        public bool AutoFontSize {
            get;
            set;
        }

        [DefaultValue(6)]
        public int MinFontSize {
            get;
            set;
        }

        
        public AutoSizeLabel() {
            InitializeComponent();
        }

        public AutoSizeLabel(IContainer container) {
            container.Add(this);

            InitializeComponent();
        }

        private void AutoSizeLabel_FontChanged(object sender, EventArgs e) {
            if (defaultFont == null) {
                int maxFontSize = (int)this.Font.SizeInPoints;
                int minFontSize = 6;
                fontList = new Font[maxFontSize - minFontSize + 1];
                for (int i = 0; i < fontList.Length; i++) {
                    fontList[i] = new Font(this.Font.OriginalFontName, maxFontSize - i);
                }

                defaultFont = this.Font;
            }
        }

        private void AutoSizeLabel_TextChanged(object sender, EventArgs e) {
            if (AutoFontSize == false) {
                return;
            }

            Graphics g = this.CreateGraphics();

            for (int i = 0; i < fontList.Length; i++) {
                SizeF sf = g.MeasureString(this.Text, fontList[i]);
                if ((int)sf.Width <= this.Width || i == fontList.Length - 1 || fontList[i].SizeInPoints <= MinFontSize) {
                    this.Font = fontList[i];
                    break;
                }
            }
            g.Dispose();

        }
    }
}
