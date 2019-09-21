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
    partial class AbstractDBGridRow : AbstractPanelGridRow
    {
        public AbstractDBGridRow() {
            InitializeComponent();
        }


        public models.db.Row RowData {
            get;
            private set;
        }


        public void SetRowData(models.db.Row rowData, bool dirty) {
            RowData = rowData;
            this.RowEditing = dirty;

            inSetRowDataFunction = true;
            SetRowDataSub(rowData);
            inSetRowDataFunction = false;
        }


        virtual protected void SetRowDataSub(models.db.Row rowData) {
        }


        virtual public void SetMasterTables(models.db.AbstractDatabase db) {
        
        }

        virtual public void CopyMasterTableContoller(AbstractDBGridRow originalRow) {
        
        }


        // 個々のコントロールに対するRowDataの設定
        protected void SetRowDataToFormattedValueTextBox(controls.FormattedViewTextBox control, models.db.Row rowData) {
            control.Value = rowData.GetStr(control.Tag as string);
        }

        protected void SetRowDataToTextBox(TextBox control, models.db.Row rowData) {
            control.Text = rowData.GetStr(control.Tag as string);
        }

        protected void SetRowDataToLabel(Label control, models.db.Row rowData) {
            control.Text = rowData.GetStr(control.Tag as string);
        }

        protected void SetRowDataToLabelAsAmount(Label control, models.db.Row rowData) {
            int amount;
            if (int.TryParse(rowData.GetStr(control.Tag as string, ""), out amount) == true) {
                control.Text = helper.Converter.LongToAmount(amount);
            }
            else {
                control.Text = rowData.GetStr(control.Tag as string, "");
            }
        }

        protected void SetRowDataToTextBoxAsFloat(TextBox control, models.db.Row rowData, string format) {
            string strValue = rowData.GetStr(control.Tag as string);
            double? value = helper.Converter.ObjToDoubleObj(strValue);
            if(value == null){
                control.Text = strValue;
            }
            else{
                control.Text = value.Value.ToString(format);
            }
        }

        protected void SetRowDataToAmount(controls.AmountTextBox control, models.db.Row rowData) {
            control.AmountStr = rowData.GetStr(control.Tag as string);
        }

        protected void SetRowDataToDateTimePicker(controls.NullableDateTimePicker control, models.db.Row rowData) {
            (control as controls.NullableDateTimePicker).Value = rowData.GetDate(control.Tag as string);
        }

        protected void SetRowDataToDateInputPanel(views.controls.DateInputPanel control, models.db.Row rowData) {
            control.Date = rowData.GetDate(control.Tag as string);
        }

        protected void SetRowDataToMTCombo(controls.MultiColumnComboBox control, models.db.Row rowData) {
            control.SelectRowByKeyValue(rowData.GetLong(control.Tag as string, -1));
        }

        protected void SetRowDataToCheckBox(CheckBox control, models.db.Row rowData) {
            control.Checked = rowData.GetBool(control.Tag as string, false);
        }
    }
}
