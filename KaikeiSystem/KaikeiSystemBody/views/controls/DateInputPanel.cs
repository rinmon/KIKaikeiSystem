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
    partial class DateInputPanel : UserControl
    {
        public event Action<object, DateTime?> DateChanged;
        new public event Action<object, EventArgs> TextChanged = delegate { };
        public event Action<string> SetStatusMessage;
        public event KeyEventHandler TextBoxKeyDown;
        public event PreviewKeyDownEventHandler TextBoxPreviewKeyDown;
        public event Action<object, EventArgs> TextBoxEnter = delegate { };
        public event Action<object, EventArgs> TextBoxLeave = delegate { };

        private DateTime? date;

        private ViewTypeEnum viewType = ViewTypeEnum.WarekiYearMonthDay;
        private int textBoxWidth = 28;
        private int marginGengou2Year = 6;
        private int marginYear2Month = 6;
        private int marginMonth2Day = 6;


        public DateInputPanel() {
            InitializeComponent();
            TextBox[] textBoxes = new TextBox[]{ txtGengou, txtYear, txtMonth, txtDay };

            foreach (var txtBox in textBoxes) {
                txtBox.Leave += TextBoxLeaved;
                txtBox.Enter += TextBoxEntered;
                txtBox.KeyDown += OnTextBoxKeyDown;
                txtBox.PreviewKeyDown += OnTextBoxPreviewKeyDown;

                txtBox.Leave += (s, e) => TextBoxLeave(s, e);
                txtBox.Enter += (s, e) => TextBoxEnter(s, e);
                txtBox.TextChanged += (s,e) => TextChanged(s, e);
            }

            this.FontChanged += delegate(object sender, EventArgs args) {
                txtGengou.Font = this.Font;
                txtYear.Font = this.Font;
                txtMonth.Font = this.Font;
                txtDay.Font = this.Font;
                UpdateLayout();
            };
        }


        protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
            base.ScaleControl(factor, specified);

            TextBoxWidth = (int)(TextBoxWidth * factor.Width);
            MarginGengou2Year = (int)(MarginGengou2Year * factor.Width);
            MarginYear2Month = (int)(MarginYear2Month * factor.Width);
            MarginMonth2Day = (int)(MarginMonth2Day * factor.Width);
        }


        [DefaultValue(ViewTypeEnum.WarekiYearMonthDay)]
        public DateInputPanel.ViewTypeEnum ViewType {
            get {
                return viewType;
            }
            set {
                viewType = value;
                UpdateLayout();
            }
        }

        [DefaultValue(28)]
        public int TextBoxWidth {
            get {
                return textBoxWidth;
            }
            set {
                textBoxWidth = value;
                UpdateLayout();
            }
        }

        [DefaultValue(6)]
        public int MarginGengou2Year {
            get {
                return marginGengou2Year;
            }
            set {
                marginGengou2Year = value;
                UpdateLayout();
            }
        }

        [DefaultValue(6)]
        public int MarginYear2Month {
            get {
                return marginYear2Month;
            }
            set {
                marginYear2Month = value;
                UpdateLayout();
            }
        }

        [DefaultValue(6)]
        public int MarginMonth2Day {
            get {
                return marginMonth2Day;
            }
            set {
                marginMonth2Day = value;
                UpdateLayout();
            }
        }

        [Browsable(false)]
        public TextBox TextBoxGengou {
            get { return txtGengou; }
        }

        [Browsable(false)]
        public TextBox TextBoxYear {
            get { return txtYear; }
        }

        [Browsable(false)]
        public TextBox TextBoxMonth {
            get { return txtMonth; }
        }

        [Browsable(false)]
        public TextBox TextBoxDay {
            get { return txtDay; }
        }

        [Browsable(false)]
        public string GengouStr {
            get {
                return TextBoxGengou.Text;
            }
            set {
                TextBoxGengou.Text = value;
            }
        }

        [Browsable(false)]
        public string YearStr {
            get {
                return TextBoxYear.Text;
            }
            set {
                TextBoxYear.Text = value;
            }
        }

        [Browsable(false)]
        public string MonthStr {
            get {
                return TextBoxMonth.Visible ? TextBoxMonth.Text : "4";
            }
            set {
                TextBoxMonth.Text = value;
            }
        }

        [Browsable(false)]
        public string DayStr {
            get {
                return TextBoxDay.Visible ? TextBoxDay.Text : "1";
            }
            set {
                TextBoxDay.Text = value;
            }
        }

        [Browsable(false)]
        public DateTime? Date {
            get {
                return date;
            }
            set {
                SetDate(value, false);
            }
        }

        [Browsable(false)]
        public string WarekiStr {
            get {
                if (date != null) {
                    return helper.Converter.DateTimeToWarekiStr(date.Value);
                }
                return null;
            }
        }

        [Browsable(false)]
        public bool ValidDate {
            get {
                return Date != null;
            }
        }

        private void UpdateLayout() {

            txtGengou.Width = textBoxWidth;
            txtYear.Width = textBoxWidth;
            txtMonth.Width = textBoxWidth;
            txtDay.Width = textBoxWidth;

            txtYear.Left = txtGengou.Right + marginGengou2Year;
            txtMonth.Left = txtYear.Right + marginYear2Month;
            txtDay.Left = txtMonth.Right + marginMonth2Day;

            if (viewType == ViewTypeEnum.WarekiYear) {
                txtMonth.Hide();
                txtDay.Hide();
            }
            else if (viewType == ViewTypeEnum.WarekiYearMonth) {
                txtMonth.Show();
                txtDay.Hide();
            }
            else if (viewType == ViewTypeEnum.WarekiYearMonthDay) {
                txtMonth.Show();
                txtDay.Show();
            }
        }


        private void SetDate(DateTime? value, bool clearWhenNull) {
            DateTime? oldDate = date;
            date = value;
            if (DateChanged != null && date != oldDate) {
                DateChanged(this, date);
            }

            if (date != null) {
                string wareki = helper.Converter.DateTimeToWarekiStr(date.Value);
                GengouStr = wareki.Substring(0, 1);
                string[] token = wareki.Split('/');
                YearStr = helper.Converter.ObjToInt(token[0].Substring(1), 0).ToString();
                MonthStr = helper.Converter.ObjToInt(token[1], 0).ToString();
                DayStr = helper.Converter.ObjToInt(token[2], 0).ToString();
            }
            else if (clearWhenNull) {
                GengouStr = "";
                YearStr = "";
                MonthStr = "";
                DayStr = "";
            }
        }


        private void TextBoxLeaved(object sender, EventArgs args) {
            this.SetDate(helper.Converter.ObjToDateTime(GengouStr, YearStr, MonthStr, DayStr), false);
            if (SetStatusMessage != null) {
                SetStatusMessage("");
            }
        }

        private void TextBoxEntered(object sender, EventArgs args){
            if (SetStatusMessage != null) {
                if(sender == TextBoxGengou){
                    SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusGengou);
                }
                else if (sender == TextBoxYear) {
                    SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusYear);
                }
                else if (sender == TextBoxMonth) {
                    SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusMonth);
                }
                else if (sender == TextBoxDay) {
                    SetStatusMessage(KaikeiSystemBody.Properties.Resources.StatusDay);
                }
            }
        }

        private void OnTextBoxKeyDown(object sender, KeyEventArgs args) {
            if (TextBoxKeyDown != null) {
                TextBoxKeyDown(sender, args);
            }
        }

        private void OnTextBoxPreviewKeyDown(object sender, PreviewKeyDownEventArgs args) {
            if (TextBoxPreviewKeyDown != null) {
                TextBoxPreviewKeyDown(sender, args);
            }
        }
    }
}
