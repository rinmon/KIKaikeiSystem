using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.views.grid
{
    partial class PanelGrid<Type> : UserControl where Type : AbstractPanelGridRow, new() 
    {
        private List<Type> row_controls_;
        private Type selected_row_control_;
        private Type top_dummy_row_control_;
        private int data_count_;
        private int visible_row_top_;
        private int visible_row_count_;
        private int layout_suspending_call_ct_;

        // action
        public event Action<int, int> UpdateRowsAction;  // UpdateRowsAction(begin_row_no, end_row_no)  begin ～ end のrowの更新をコントローラに依頼


        public PanelGrid() {
            row_controls_ = new List<Type>();
            visible_row_count_ = 0;
            LastSelectedRowNo = 0;
            SelectedRowNo = -1;
            layout_suspending_call_ct_ = 0;

            InitializeComponent();
            this.MouseWheel += DBGrid_MouseWheel;

            InitRowControls();

            this.Load += delegate(object sender, System.EventArgs e) {
                if (this.TopLevelControl == null) {
                    return;
                }
            };
        }


        // properties

        public Type TopDummyRowControl {
            get {
                return top_dummy_row_control_;
            }
        }

        public IEnumerable<Type> AllRowControls() {
            foreach (var row in row_controls_) {
                yield return row;
            }
            yield return selected_row_control_;
        }

        public Type RowControl(int i) {
            if (SelectedRowNo - VisibleRowTop == i) {
                return SelectedRowControl;
            }
            else {
                if (row_controls_.Count > i)
                {
                    return row_controls_[i];
                }
            }
            return SelectedRowControl;
        }

        public Type SelectedRowControl {
            get { return selected_row_control_; }
        }

        public bool SelectedRowIsVisible {
            get {
                if (SelectedRowNo >= 0 && SelectedRowNo < RowCount) {
                    return true;
                }
                return false;
            }
        }


        public bool NewRowIsVisible {
            get;
            set;
        }

        // データの個数
        public int DataCount {
            get {
                return data_count_;
            }
            set {
                data_count_ = value;

                if (row_controls_.Count > 0) {
                    UpdateVisibleRowTop(VisibleRowTop, true);
                }
                AdjustScrollbarSize();
            }
        }

        // 行数
        public int RowCount {
            get {
                return NewRowIsVisible ? DataCount + 1 : DataCount;
            }
        }



        // 表示中の一番上の行番号
        public int VisibleRowTop {
            get {
                return visible_row_top_;
            }
            private set {
                UpdateVisibleRowTop(value);
            }
        }

        // 表示中の一番下の行番号
        public int VisibleRowBottom {
            get {
                return VisibleRowTop + VisibleRowCount - 1;
            }
        }

        public int VisibleRowCount {
            get {
                return visible_row_count_;
            }
        }

        // 選択行の番号
        public int SelectedRowNo {
            get;
            private set;
        }

        // 最後に選択していた行の番号
        public int LastSelectedRowNo {
            get;
            private set;
        }


        public void SuspendDrawRows() {
            layout_suspending_call_ct_++;

            panelMain.SuspendLayout();
            //this.SuspendLayout();
        }


        public void ResumeDrawRows() {
            //this.ResumeLayout(false);
            panelMain.ResumeLayout(false);

            layout_suspending_call_ct_--; 
        }


        private void InitRowControls() {
            int screen_height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            this.SuspendLayout();

            top_dummy_row_control_ = CreateRowControl(-1);
            top_dummy_row_control_.Show();
            this.panelMain.Controls.Add(top_dummy_row_control_);
            int row_no = 0;

            while (true) {
                var row = CreateRowControl(row_no);
                row_controls_.Add(row);
                this.panelMain.Controls.Add(row);
                row_no++;
                if (row.Top > screen_height) {
                    break;
                }
            }

            /*
            Control[] rowArray = new Control[row_controls_.Count];
            for(int i = 0; i < row_controls_.Count; i++){
                rowArray[i] = row_controls_[i];
            }

            this.panelMain.Controls.AddRange(rowArray);
             * */

            selected_row_control_ = CreateRowControl(row_no);
            selected_row_control_.Hide();
            this.panelMain.Controls.Add(selected_row_control_);

            this.ResumeLayout();

            DataCount = 0;
            UpdateVisibleRowCount();
        }


        public void SelectTopRow() {
            VisibleRowTop = 0;

            SelectRow(0);
            selected_row_control_.Select();
            selected_row_control_.SetFocusToFirstControl();
        }


        public void SelectBottomRow() {
            VisibleRowTop = this.RowCount - 1;

            SelectRow(this.RowCount - 1);
            selected_row_control_.Select();
            selected_row_control_.SetFocusToFirstControl();
        }


        // column_name == nullのときは最初のコントロールを選択
        public void SetFocus(int row_no, string column_name) {
            if (RowCount <= 0) {
                return;
            }

            if (!(0 <= row_no && row_no < RowCount)) {
                row_no = 0;
            }

            if (!(VisibleRowTop <= row_no && row_no <= VisibleRowBottom - 1)) {
                VisibleRowTop = row_no;
            }

            Type rowControl;

            if (row_no == SelectedRowNo) {
                //SelectedRowControl.SetFocusToToFirstControl();
                rowControl = SelectedRowControl;
            }
            else {
                //row_controls_[row_no - VisibleRowTop].SetFocusToToFirstControl();
                rowControl = row_controls_[row_no - VisibleRowTop];
            }

            if(column_name == null){
                rowControl.SetFocusToFirstControl();
            }
            else{
                rowControl.SetFocusToControlByTag(column_name);
            }
        }


        private Type CreateRowControl(int row_no) {
            Type row = new Type();

            row.BackColor = this.BackColor;
            row.Location = new System.Drawing.Point(0, row_no * row.Height);
            row.Name = "Row" + row_no.ToString();
            row.Enter += this.Row_Enter;
            row.Leave += this.Row_Leave;
            row.Column_BeforeChangeValueAction += Row_BeforeChangeValue;
            row.Width = this.Width;
            row.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            foreach(var control in row.Controls){
                (control as System.Windows.Forms.Control).KeyDown += Row_KeyDown;
                (control as System.Windows.Forms.Control).PreviewKeyDown += Row_PreviewKeyDown;
            }

            row.RowNo = row_no;

            return row;
        }


        private void UpdateRows(int begin, int end) {
            if (layout_suspending_call_ct_ == 0) {
                if (UpdateRowsAction != null) {
                    UpdateRowsAction(begin, end);
                }

                this.Update();
            }
        }


        private void UpdateVisibleRowTop(int top, bool force_update = false) {
            int old_top = visible_row_top_;
            int old_bottom = VisibleRowBottom;

            if (visible_row_top_ == top && !force_update) {
                //return;
            }

            visible_row_top_ = top;

            if (old_top != top) {
                if (old_top <= SelectedRowNo && SelectedRowNo <= old_bottom) {
                    row_controls_[SelectedRowNo - old_top].Show();
                    row_controls_[SelectedRowNo - old_top].TabStop = true;
                }
            }

            UpdateRows(VisibleRowTop, VisibleRowBottom + 1);    // 画面外にフォーカスが移動する場合を考え＋１行Updateする

            if (old_top != top) {
                if (VisibleRowTop <= SelectedRowNo && SelectedRowNo <= VisibleRowTop + row_controls_.Count - 1) {
                    var row = row_controls_[SelectedRowNo - VisibleRowTop];
                    selected_row_control_.Top = row.Top;
                    selected_row_control_.TabIndex = row.TabIndex;
                    selected_row_control_.RowNo = row.RowNo;
                    row.Hide();
                    row.RowSelected = false;
                    row.TabStop = false;
                }
                else {
                    selected_row_control_.Top = -(selected_row_control_.Height + 1);
                }
            }

            if (vScrollBar.Value != visible_row_top_) {
                if (vScrollBar.Minimum <= visible_row_top_ && visible_row_top_ <= vScrollBar.Maximum) {
                    vScrollBar.Value = visible_row_top_;
                }
            }
        }


        private void UpdateVisibleRowCount() {
            if(row_controls_.Count == 0){
                return;
            }

            int old_value = visible_row_count_;
            visible_row_count_ = this.panelMain.Height / row_controls_[0].Height + 1;


            if (visible_row_count_ > old_value) {
                UpdateRows(VisibleRowTop + old_value, VisibleRowTop + visible_row_count_ - 1 + 1);  // 画面外にフォーカスが行くことを考え、＋1行Updateする
            }
        }


        private void AdjustScrollbarSize() {
            vScrollBar.Minimum = 0;
            vScrollBar.Maximum = (RowCount - 1) + vScrollBar.LargeChange - 1;
            vScrollBar.Maximum = (RowCount - 1) + vScrollBar.LargeChange - 1; // Maximumを変えるとLargeChangeが変わるので再度Maximumを変更。（大体2回で収束する？）
        }


        // 行を選択状態にする
        //  フォーカスを移動するわけではない。フォーカスが移動した後に、内部状態を変更するためによぶ。
        private void SelectRow(int selected_row_no) {
            if (selected_row_no == -1) {
                if (VisibleRowTop <= SelectedRowNo && SelectedRowNo <= VisibleRowTop + row_controls_.Count - 1) {
                    var row = row_controls_[SelectedRowNo - VisibleRowTop];
                    row_controls_[SelectedRowNo - VisibleRowTop] = selected_row_control_;
                    selected_row_control_.RowSelected = false;
                    selected_row_control_ = row;
                }
                SelectedRowNo = selected_row_no;
            }
            else {
                Type row;
                if (VisibleRowTop <= SelectedRowNo && SelectedRowNo <= VisibleRowTop + row_controls_.Count - 1) {
                    selected_row_control_.RowSelected = false;
                    row = row_controls_[SelectedRowNo - VisibleRowTop];
                    row_controls_[SelectedRowNo - VisibleRowTop] = selected_row_control_;
                    selected_row_control_ = row;
                }
                
                SelectedRowNo = selected_row_no;

                row = row_controls_[SelectedRowNo - VisibleRowTop];
                selected_row_control_.Hide();
                selected_row_control_.RowSelected = false;
                selected_row_control_.TabStop = false;
                selected_row_control_.TabIndex = row.TabIndex;
                selected_row_control_.Top = row.Top;
                selected_row_control_.RowNo = row.RowNo;

                row_controls_[SelectedRowNo - VisibleRowTop] = selected_row_control_;
                selected_row_control_ = row;
                selected_row_control_.RowSelected = true;
            }
        }


/*        private void DebugPrintGrid() {
            return;
            foreach (var row in row_controls_) {
                System.Diagnostics.Debug.WriteLine(
                    "row_name:" + row.Name + "\n" +
                    "  visible:" + row.Visible.ToString() + "\n" +
                    "  TabStop:" + row.TabStop.ToString() + "\n" +
                    "  TabIndex:" + row.TabIndex.ToString() + "\n" +
                    "  Top:" + row.Top.ToString()
                    );
            }

            System.Diagnostics.Debug.WriteLine(
                "Focused row_name:" + selected_row_control_.Name + "\n" +
                "  visible:" + selected_row_control_.Visible.ToString() + "\n" +
                "  TabStop:" + selected_row_control_.TabStop.ToString() + "\n" +
                "  TabIndex:" + selected_row_control_.TabIndex.ToString() + "\n" +
                "  Top:" + selected_row_control_.Top.ToString()
                );
            System.Diagnostics.Debug.WriteLine(
                SelectedRowNo.ToString() + "\n============================================================\n"
                );
        }
        */

        // events
        private void Row_Enter(object sender, EventArgs e) {
            Type row = sender as Type;

            if (row.RowNo == -1) {
                // 画面外のダミーにフォーカスが移動したとき
                // 一行上の行を表示してフォーカスを移す

                if (VisibleRowTop > 0) {
                    VisibleRowTop--;
                }
                row_controls_[0].Focus();
                selected_row_control_.SelectNextControl(selected_row_control_.ActiveControl, false, true, false, true);
            }
            else {
                SelectRow(VisibleRowTop + row.RowNo);
            }

            LastSelectedRowNo = SelectedRowNo;
        }

        private void Row_Leave(object sender, EventArgs e) {
            //AbstractDBGridRow row = sender as KaikeiDenpyouRow;
            //SelectRow(-1);
        }

        private void Row_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab) {
                e.SuppressKeyPress = true;  // キー本来の動作をキャンセル
            }
        }

        private void Row_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            var target = sender as System.Windows.Forms.Control;

            if ((e.KeyCode == Keys.Tab || (e.KeyCode == Keys.Enter && !(sender is Button))) && e.Shift == false) {
                var old_focused_row_no = SelectedRowNo;
                this.SelectNextControl(target, true, true, true, false);

                if (SelectedRowNo > old_focused_row_no) {
                    if (SelectedRowNo >= RowCount) {
                        row_controls_[RowCount - VisibleRowTop - 1].Focus();
                    }
                    else if (SelectedRowNo - VisibleRowTop >= VisibleRowCount - 1) {
                        VisibleRowTop++;
                    }
                }
                e.IsInputKey = true;  // 特殊キーでKeyDownイベントを呼ぶ
            }
        }


        private void Row_BeforeChangeValue(AbstractPanelGridRow sender, string key, object value) {
            if (SelectedRowNo == -1) {
                return;
            }

            if (SelectedRowNo < VisibleRowTop || SelectedRowNo >= this.Height / row_controls_[0].Height + VisibleRowTop) {
                VisibleRowTop = SelectedRowNo;
            }
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e) {
            if (VisibleRowTop != e.NewValue) {
                VisibleRowTop = e.NewValue;
            }
            //System.Diagnostics.Debug.WriteLine(string.Format("DataCount:{0}, scroll:{1}, top:{2}, scroll_max:{3}, lchange;{4}", DataCount, e.NewValue, VisibleRowTop, vScrollBar.Maximum, vScrollBar.LargeChange));

        }

        public void DBGrid_MouseWheel(object sender, MouseEventArgs e) {
            if (e.Delta != 0) {
                int value = vScrollBar.Value - e.Delta / System.Math.Abs(e.Delta);
                int newTop = System.Math.Min(System.Math.Max(value, vScrollBar.Minimum), RowCount - 1);
                if(newTop < 0){
                    newTop = 0;
                }
                VisibleRowTop = newTop;
            }
        }

        private void panelMain_Resize(object sender, EventArgs e) {
            UpdateVisibleRowCount();
        }
    }
}
