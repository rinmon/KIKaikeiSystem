using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataDynamics.ActiveReports.Document;

namespace KaikeiSystemBody.views.popup
{
    public partial class ReportPreviewPopup : Form
    {
        public ReportPreviewPopup() {
            InitializeComponent();

            DataDynamics.ActiveReports.Toolbar.Button xlsBtn = new DataDynamics.ActiveReports.Toolbar.Button();
            xlsBtn.Enabled = true;
            xlsBtn.Id = 777;
            xlsBtn.Caption = Properties.Resources.CaptionExcelExport;
            xlsBtn.Visible = true;
            viewer.Toolbar.Tools.Insert(
                3, xlsBtn
            );
            viewer.Toolbar.Tools.Insert(
                3, new DataDynamics.ActiveReports.Toolbar.Separator()
            );
        }


        public Document Document {
            get {
                return viewer.Document;
            }
            set {
                viewer.Document = value;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e) {
        }

        private void viewer_ToolClick(object sender, DataDynamics.ActiveReports.Toolbar.ToolClickEventArgs e) {
            if (e.Tool.Id == 777) {
                saveFileDialogForExcelExport.FileName = "";
                if (saveFileDialogForExcelExport.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    var xlsExport = new DataDynamics.ActiveReports.Export.Xls.XlsExport();
                    xlsExport.Export(viewer.Document, saveFileDialogForExcelExport.FileName);
                    helper.MsgBox.Info(Properties.Resources.MsgSucceeded);
                }
            }
        }
    }
}
