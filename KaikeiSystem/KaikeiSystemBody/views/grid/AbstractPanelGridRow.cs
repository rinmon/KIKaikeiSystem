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
    partial class AbstractPanelGridRow : UserControl
    {
        private bool rowSelected;
        private bool rowEditing;
        private bool isNewRow;
        private Control selectedIndicator;
        private Control editingIndicator;
        private Control newRowIndicator;

        protected Pen penForBottomLine;
        protected Pen penForLeftLine;
        protected int leftLineX; 

        protected bool inSetRowDataFunction;
        protected bool modifingControlValue;

        public AbstractPanelGridRow() {
            RowSelected = false;
            RowEditing = false;
            isNewRow = false;
            selectedIndicator = null;
            editingIndicator = null;
            newRowIndicator = null;
            inSetRowDataFunction = false;
            modifingControlValue = false;

            leftLineX = 18;
            penForBottomLine = new Pen(Color.Gray, 1);
            penForLeftLine = penForBottomLine;

            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        // actions
        public delegate void Column_BeforeChangeValueDelegate(AbstractPanelGridRow sender, string column_name, object value);       // コントロールの値が変化したときに呼ばれるイベント
        public delegate void Column_UpdateValueDelegate(AbstractPanelGridRow sender, string column_name, object value);        // コントロールの値が有効であるかを確かめる
        public delegate void Column_LostFocusDelegate(AbstractPanelGridRow sender, string column_name);                                // コントロールからフォーカスが外れたときによばれるイベント
        public delegate void RemoveDeleagate(AbstractPanelGridRow sender);
        public event Column_BeforeChangeValueDelegate Column_BeforeChangeValueAction;
        public event Column_UpdateValueDelegate Column_UpdateValueAction;
        public event Column_LostFocusDelegate Column_LostFocusAction;
        public event RemoveDeleagate RemoveAction;

        public event Action<AbstractPanelGridRow> RowClicked;

        public event Action<string> SetStatusMessageAction;


        // 何行目かの情報、DBGridクラスで設定
        public int RowNo {
            get;
            set;
        }


        public bool RowSelected {
            get {
                return rowSelected;
            }
            set {
                rowSelected = value;
                ResetStateIndicatorVisibility();
            }
        }

        public bool RowEditing {
            get {
                return rowEditing;
            }
            protected set {
                rowEditing = value;
                ResetStateIndicatorVisibility();
            }
        }

        public bool IsNewRow {
            get {
                return isNewRow;
            }
            set {
                isNewRow = value;
                ResetStateIndicatorVisibility();
            }
        }

        protected Control EditingIndicator {
            get{
                return editingIndicator;
            }
            set {
                editingIndicator = value;
                ResetStateIndicatorVisibility();
            }
        }

        protected Control SelectedIndicator {
            get {
                return selectedIndicator;
            }
            set {
                selectedIndicator = value;
                ResetStateIndicatorVisibility();
            }
        }

        protected Control NewRowIndicator {
            get {
                return newRowIndicator;
            }
            set {
                newRowIndicator = value;
                ResetStateIndicatorVisibility();
            }
        }


        public Control LastFocusedControl {
            get;
            protected set;
        }


        private void ResetStateIndicatorVisibility() {
            if (editingIndicator == null || selectedIndicator == null || newRowIndicator == null) {
                return;
            }

            if (RowEditing) {
                editingIndicator.Show();
                selectedIndicator.Hide();
                newRowIndicator.Hide();
            }
            else if (RowSelected) {
                editingIndicator.Hide();
                selectedIndicator.Show();
                newRowIndicator.Hide();
            }
            else if (isNewRow) {
                editingIndicator.Hide();
                selectedIndicator.Hide();
                newRowIndicator.Show();
            }
            else {
                editingIndicator.Hide();
                selectedIndicator.Hide();
                newRowIndicator.Hide();
            }
        }

        virtual public void SetFocusToFirstControl() {
            if (Controls.Count > 0) {
                Controls[0].Select();
            }
        }


        public void SetFocusToControlByTag(string tag) {
            Control control = SearchControlByTag(tag);
            if (control != null) {
                control.Select();
            }
        }


        public Control SearchControlByTag(string tag) {
            foreach (var control in this.Controls) {
                if ((control as Control).Tag as string == tag) {
                    return control as Control;
                }
            }
            return null;
        }


        // Rowの削除を外部から実行する
        public void FireRemoveEvent() {
            CallRemoveAction();
        }

        // ColumnのUpdateイベントを発生させる
        public void FireColumnUpdateValueEvent(string columnName) {
            CallUpdateValueAction(columnName, GetControlValue(SearchControlByTag(columnName)));
        }


        protected void CallBeforeChangeValueAction(string columnName, object value) {
            if (Column_BeforeChangeValueAction != null) {
                Column_BeforeChangeValueAction(this, columnName, value);
            }
        }

        protected void CallUpdateValueAction(string columnName, object value) {
            if (Column_UpdateValueAction != null) {
                Column_UpdateValueAction(this, columnName, value);
            }
        }

        protected void CallLostFocusAction(string column_name) {
            if (Column_LostFocusAction != null) {
                Column_LostFocusAction(this, column_name);
            }
        }

        protected void CallRemoveAction() {
            if (RemoveAction != null) {
                RemoveAction(this);
            }
        }

        protected void CallRowClicked() {
            if (RowClicked != null) {
                RowClicked(this);
            }
        }

        protected void SetStatusMessage(string msg) {
            if (SetStatusMessageAction != null) {
                SetStatusMessageAction(msg);
            }
        }


        // コントロールに値を設定する
        virtual public void SetControlValue(string columnName, object value) {
            Control control = SearchControlByTag(columnName);
            if (control == null) {
                return;
            }

            if (control is controls.FormattedViewTextBox) {
                (control as controls.FormattedViewTextBox).Value = value.ToString();
            }
            else if (control is TextBox) {
                (control as TextBox).Text = value.ToString();
            }
            else if (control is ComboBox) {
                (control as ComboBox).Text = value.ToString();
            }
            else if (control is CheckBox) {
                (control as CheckBox).Checked = (bool)value;
            }
            else if (control is views.controls.DateInputPanel) {
                (control as views.controls.DateInputPanel).Date = value as DateTime?;
            }
            else if (control is DateTimePicker) {
                if (value != null) {
                    (control as DateTimePicker).Value = (value as DateTime?).Value;
                }
                else {
                    (control as DateTimePicker).Value = DateTime.Now;
                }
            }

            CallUpdateValueAction(control.Tag as string, GetControlValue(control));
        }


        //コントロールの値を取り出す
        virtual protected object GetControlValue(Control control) {
            object value = null;
            if (control is controls.FormattedViewTextBox) {
                value = (control as controls.FormattedViewTextBox).Value;
            }
            else if (control is TextBox) {
                value = (control as TextBox).Text;
            }
            else if (control is views.controls.MTComboBox) {
                value = (control as views.controls.MTComboBox).SelectedKey;
            }
            else if (control is CheckBox) {
                value = (control as CheckBox).Checked;
            }
            else if (control is views.controls.DateInputPanel) {
                value = (control as views.controls.DateInputPanel).Date;
            }
            else if (control is DateTimePicker) {
                value = (control as DateTimePicker).Value;
            }
            return value;
        }




        protected void SetDefaultHandlersToControls() {
            foreach (Control control in this.Controls) {
                if (control.Tag != null && control.Tag is string && (control.Tag as string).Length > 0) {
                    if (control is views.controls.DateInputPanel) {
                        views.controls.DateInputPanel dinput = control as views.controls.DateInputPanel;
                        dinput.Enter += DefaultHandlerControlEnter;
                        dinput.Leave += DefaultHandlerControlLeave;
                        dinput.DateChanged += DefaultHandlerDateInputChanged;
                    }
                    else if (control is DateTimePicker) {
                        DateTimePicker picker = control as DateTimePicker;
                        picker.Enter += DefaultHandlerControlEnter;
                        picker.ValueChanged += delegate(object s, EventArgs e) {
                            DefaultHandlerControlChanged(s, e);
                            DefaultHandlerControlLeave(s, e);
                        };
                    }
                    else if (control is controls.FormattedViewTextBox) {
                        controls.FormattedViewTextBox ft = control as controls.FormattedViewTextBox;
                        ft.Enter += DefaultHandlerControlEnter;
                        ft.ValueChanged += delegate(object s, EventArgs e) {
                            DefaultHandlerControlChanged(s, e);
                            DefaultHandlerControlLeave(s, e);
                        };
                    }
                    else {
                        control.Leave += DefaultHandlerControlLeave;
                        control.Enter += DefaultHandlerControlEnter;

                        if (control is CheckBox) {
                            (control as CheckBox).CheckedChanged += DefaultHandlerControlChanged;
                        }
                        else {
                            control.TextChanged += DefaultHandlerControlChanged;
                        }
                    }
                }
            }
        }


        protected void SetDefaultIndicator() {
            var picEditing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(picEditing)).BeginInit();
            picEditing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picEditing.Image = global::KaikeiSystemBody.Properties.Resources.draw_pencil;
            picEditing.Size = new System.Drawing.Size(16, 16);
            picEditing.Location = new System.Drawing.Point(0, (this.Height - picEditing.Height) / 2);
            this.Controls.Add(picEditing);
            editingIndicator = picEditing;

            var picSelected = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(picSelected)).BeginInit();
            picSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picSelected.Image = global::KaikeiSystemBody.Properties.Resources.arrow_right;
            picSelected.Size = new System.Drawing.Size(16, 16);
            picSelected.Location = new System.Drawing.Point(0, (this.Height - picSelected.Height) / 2);
            this.Controls.Add(picSelected);
            selectedIndicator = picSelected;

            var picNewRow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(picNewRow)).BeginInit();
            picNewRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picNewRow.Image = global::KaikeiSystemBody.Properties.Resources.create;
            picNewRow.Size = new System.Drawing.Size(16, 16);
            picNewRow.Location = new System.Drawing.Point(0, (this.Height - picNewRow.Height) / 2);
            this.Controls.Add(picNewRow);
            newRowIndicator = picNewRow;
        }


        // default event handler
        protected void DefaultHandlerControlChanged(object sender, EventArgs e) {
            if (inSetRowDataFunction == false) {
                RowEditing = true;
                modifingControlValue = true;
                CallBeforeChangeValueAction((sender as Control).Tag as string, GetControlValue(sender as Control));
            }
        }

        protected void DefaultHandlerDateInputChanged(object sender, DateTime? date) {
            if (inSetRowDataFunction == false) {
                RowEditing = true;
                modifingControlValue = true;
                CallBeforeChangeValueAction((sender as Control).Tag as string, GetControlValue(sender as Control));
            }
        }

        protected void DefaultHandlerControlEnter(object sender, EventArgs e) {
            LastFocusedControl = sender as Control;
            SetStatusMessage(helper.Helper.GetStatusMessage((sender as Control).Tag as string));
        }

        protected void DefaultHandlerControlLeave(object sender, EventArgs e) {
            if (inSetRowDataFunction == false && modifingControlValue) {
                CallUpdateValueAction((sender as Control).Tag as string, GetControlValue(sender as Control));
            }
            modifingControlValue = false;
            CallLostFocusAction((sender as Control).Tag as string);

            SetStatusMessage("");
        }

        protected void DefaultHandlerRemoveRowButtonClicked(object sender, EventArgs e) {
            CallRemoveAction();
        }


        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            if(penForLeftLine != null){
                e.Graphics.DrawLine(penForLeftLine, leftLineX, 0, leftLineX, this.Height);
            }
            if (penForBottomLine != null) {
                e.Graphics.DrawLine(penForBottomLine, 0, this.Height - 1, this.Width, this.Height - 1);
            }
        }
    }
}
