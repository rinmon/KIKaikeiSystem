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
    public partial class MultiColumnComboBox : System.Windows.Forms.ComboBox
    {
        public class Row {
            private object[] cells;
            public int CaptionColumnNo {
                get;
                private set;
            }

            public Row(object[] initCells, int captionColumn){
                cells = new object[initCells.Length];
                System.Array.Copy(initCells, cells, initCells.Length);
                CaptionColumnNo = captionColumn;
            }

            public object Cells(int i) {
                return cells[i];
            }

            public override string ToString() {
                return cells[CaptionColumnNo].ToString();
            }
        }


        private struct ColumnInfo {
            public bool Hidden;
            public int Width;

            public ColumnInfo(bool hidden, int width) {
                Hidden = hidden;
                Width = width;
            }
        }


        [DefaultValue(false)]
        public bool AutoFontSize {
            get;
            set;
        }


        private const int LineLeftMargin = 2;
        private const int LineRightMargin = 2;

        private Font[] fontList;
        private Font defaultFont = null;
        private int defaultItemHeight;

        private ColumnInfo[] columnInfo;


        public MultiColumnComboBox() {
            InitializeComponent();
            this.DrawItem += MyDrawItem;
            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;

            this.Leave += delegate(object sender, EventArgs arg) {
                /*
                if (CaptionColumnNo == KeyColumnNo) {
                    this.SelectRowByKeyValue(this.Text);
                    if (this.SelectedIndex == -1) {
                        this.OnSelectedIndexChanged(null);
                    }
                }
                 */
                if (this.SelectedRow == null || this.SelectedRow.Cells(this.SelectedRow.CaptionColumnNo).ToString() != this.Text) {
                    this.SelectRowByCaptionValue(this.Text);
                    if (this.SelectedIndex == -1) {
                        this.OnSelectedIndexChanged(null);
                    }
                }
            };
        }


        public void CopyRows(MultiColumnComboBox src) {
            this.NumColumns = src.NumColumns;
            this.columnInfo = src.columnInfo;
            this.CaptionColumnNo = src.CaptionColumnNo;
            this.KeyColumnNo = src.KeyColumnNo;

            this.BeginUpdate();

            this.ClearRows();
            for (int i = 0; i < src.Items.Count; i++) {
                this.Items.Add(src.Rows(i));
            }
            this.DropDownWidth = src.DropDownWidth;

            this.EndUpdate();
        }


        public void InitColumns(int numColumns, int keyColumnNo, int captionColumnNo){
            NumColumns = numColumns;
            columnInfo = new ColumnInfo[numColumns];
            CaptionColumnNo = captionColumnNo;
            KeyColumnNo = keyColumnNo;
        }

        public void ClearRows() {
            this.Items.Clear();
        }

        public void AddRowWithCaption(int captionNo, params object[] cells) {
            this.Items.Add(new Row(cells, captionNo));

            Graphics g = this.CreateGraphics();
            for(int i = 0; i < cells.Length; i++){
                SizeF sf = g.MeasureString(cells[i].ToString(), this.Font);
                columnInfo[i].Width = Math.Max(columnInfo[i].Width, (int)sf.Width);
            }
            g.Dispose();
        }


        public void AddRow(params object[] cells) {
            AddRowWithCaption(CaptionColumnNo, cells);
        }


        public Row Rows(int i) {
            return this.Items[i] as Row;
        }


        public void SetColumnVisibility(int index, bool visible) {
            columnInfo[index].Hidden = !visible;
        }

        public void SetColumnWidth(int index, int width) {
            columnInfo[index].Width = width;
        }

        public void AdjustDropDownWidth() {
            int width = 0;
            for (int i = 0; i < NumColumns; i++) {
                if (columnInfo[i].Hidden == false) {
                    width += columnInfo[i].Width;
                }
            }
            width += (NumColumns - 1) * (LineLeftMargin + LineRightMargin);
            width += 32; // scrollbar + margin
            DropDownWidth = width;
        }


        private void SelectRowByColumnValue(int colIndex, object val) {
            int newIndex = -1;
            if (val != null) {
                for (int i = 0; i < this.Items.Count; i++) {
                    if (Rows(i).Cells(colIndex).ToString() == val.ToString()) {
                        newIndex = i;
                    }
                }
            }

            if (newIndex != this.SelectedIndex) {
                this.SelectedIndex = newIndex;
            }

            if (newIndex == -1) {
                this.Text = "";
            }
        }


        public void SelectRowByCaptionValue(object captionValue) {
            int newIndex = -1;
            if (captionValue != null) {
                for (int i = 0; i < this.Items.Count; i++) {
                    //if (Rows(i).Cells(colIndex).Equals(val)) {
                    if (Rows(i).ToString() == captionValue.ToString()) {
                        newIndex = i;
                    }
                }
            }

            if (newIndex != this.SelectedIndex) {
                this.SelectedIndex = newIndex;
            }

            if (newIndex == -1) {
                this.Text = "";
            }
        }


        public void SelectRowByKeyValue(object keyValue) {
            SelectRowByColumnValue(KeyColumnNo, keyValue);
        }

        public int NumColumns {
            get;
            private set;
        }

        public int CaptionColumnNo {
            get;
            private set;
        }

        public int KeyColumnNo {
            get;
            private set;
        }

        public int NumRows {
            get {
                return this.Items.Count;
            }
        }

        public Row SelectedRow {
            get {
                if (SelectedIndex != -1) {
                    return this.SelectedItem as Row;
                }
                return null;
            }
        }

        public object SelectedKey {
            get {
                if (SelectedIndex != -1) {
                    return this.SelectedRow.Cells(KeyColumnNo);
                }
                return null;
            }
        }

        public int SelectedKeyAsInt {
            get {
                if (SelectedIndex != -1) {
                    return (int)this.SelectedRow.Cells(KeyColumnNo);
                }
                return -1;
            }
        }

        public string SelectedKeyAsStr {
            get {
                if (SelectedIndex != -1) {
                    return this.SelectedRow.Cells(KeyColumnNo).ToString();
                }
                return null;
            }
        }


        private void MyDrawItem(object sender, DrawItemEventArgs e) {
            ComboBox cb = (ComboBox)sender;
            Row row = cb.Items[e.Index] as Row;

            Pen pen = new Pen(Color.Gray);
            Brush blush = new SolidBrush(e.ForeColor);

            e.DrawBackground();

            int left = e.Bounds.X;
            bool drawLine = false;
            for (int col = 0; col < NumColumns; col++) {
                if (columnInfo[col].Hidden) {
                    drawLine = false;
                    continue;
                }
                if (drawLine) {
                    left += LineLeftMargin;
                    e.Graphics.DrawLine(pen, left, e.Bounds.Top, left, e.Bounds.Bottom);
                    left += LineRightMargin;
                }

                var font = (this.defaultFont != null) ? this.defaultFont : e.Font;
                e.Graphics.DrawString(row.Cells(col).ToString(), font, blush, left, e.Bounds.Y);

                left += columnInfo[col].Width;
                drawLine = true;
            }

            //e.DrawFocusRectangle();
            if (Convert.ToBoolean(e.State & DrawItemState.Selected)){
                ControlPaint.DrawFocusRectangle(e.Graphics, e.Bounds);
            }
        }


        public void ChangeToTreeView() {
            System.Windows.Forms.DrawItemEventHandler drawFunc = delegate(object sender, DrawItemEventArgs e) {
                ComboBox cb = (ComboBox)sender;
                Row row = cb.Items[e.Index] as Row;

                Pen pen = new Pen(Color.Gray);
                Brush blush = new SolidBrush(e.ForeColor);

                int height = e.Bounds.Bottom - e.Bounds.Top;
                int x = row.CaptionColumnNo * height * 3 / 2;
                int y = e.Bounds.Y;
                const int RectSize = 6;

                e.DrawBackground();
                e.Graphics.DrawString(row.ToString(), e.Font, blush, x, y);
                e.Graphics.DrawRectangle(pen, new Rectangle(x - height / 2 - RectSize / 2, y + height / 2 - RectSize / 2, RectSize, RectSize));

                //e.DrawFocusRectangle();
                if (Convert.ToBoolean(e.State & DrawItemState.Selected)) {
                    ControlPaint.DrawFocusRectangle(e.Graphics, e.Bounds);
                }
            };

            // adjust drop down width
            int width = 0;
            int visibleColNum = 0;
            for (int i = 0; i < columnInfo.Count(); i++) {
                if (columnInfo[i].Hidden) {
                    continue;
                }
                visibleColNum++;
                width = Math.Max(width, columnInfo[i].Width + visibleColNum * 12);
            }
            this.DropDownWidth = width + 32;

            this.DrawItem -= MyDrawItem;
            this.DrawItem += drawFunc;
        }



        private void MultiColumnComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (AutoFontSize == false) {
                return;
            }
            
            Graphics g = this.CreateGraphics();

            for(int i = 0; i < fontList.Length; i++){
                SizeF sf = g.MeasureString(this.Text, fontList[i]);
                if((int)sf.Width <= this.Width || i == fontList.Length - 1){
                    this.Font = fontList[i];
                    this.SelectionLength = 0;
                    this.ItemHeight = defaultItemHeight;
                    break;
                }
            }
            g.Dispose();
        }

        private void MultiColumnComboBox_FontChanged(object sender, EventArgs e) {
            if (defaultFont == null) {
                int maxFontSize = (int)this.Font.SizeInPoints;
                int minFontSize = 6;
                fontList = new Font[maxFontSize - minFontSize + 1];
                for (int i = 0; i < fontList.Length; i++) {
                    fontList[i] = new Font(this.Font.OriginalFontName, maxFontSize - i);
                }

                defaultFont = this.Font;
                defaultItemHeight = this.ItemHeight;
            }
        }
    }
}
