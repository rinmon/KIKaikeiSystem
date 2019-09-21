using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaikeiSystemBody.helper
{
    class View
    {
        public static void SetDataGridViewFixedColumnAndAutoScale(System.Drawing.SizeF factor, System.Windows.Forms.DataGridView grid) {
            grid.RowHeadersWidth = (int)(grid.RowHeadersWidth * factor.Width);
            grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            foreach (System.Windows.Forms.DataGridViewColumn col in grid.Columns) {
                col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
                col.Width = (int)(col.Width * factor.Width);
            }
        }


        public static DataDynamics.ActiveReports.TextBox[] CreateTextboxArray(DataDynamics.ActiveReports.ControlCollection controls, string prefix, int num) {
            var result = new DataDynamics.ActiveReports.TextBox[num];

            for (int i = 0; i < num; i++) {
                result[i] = controls[prefix + i] as DataDynamics.ActiveReports.TextBox;
            }

            return result;
        }
    }
}
