namespace KaikeiSystemBody.views.popup
{
    partial class ReportPreviewPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.viewer = new DataDynamics.ActiveReports.Viewer.Viewer();
            this.saveFileDialogForExcelExport = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // viewer
            // 
            this.viewer.BackColor = System.Drawing.SystemColors.Control;
            this.viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewer.Document = new DataDynamics.ActiveReports.Document.Document("ARNet Document");
            this.viewer.Location = new System.Drawing.Point(0, 0);
            this.viewer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.viewer.Name = "viewer";
            this.viewer.ReportViewer.CurrentPage = 0;
            this.viewer.ReportViewer.MultiplePageCols = 3;
            this.viewer.ReportViewer.MultiplePageRows = 2;
            this.viewer.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal;
            this.viewer.Size = new System.Drawing.Size(1635, 1010);
            this.viewer.TabIndex = 0;
            this.viewer.TableOfContents.Text = "見出し一覧";
            this.viewer.TableOfContents.Width = 367;
            this.viewer.TabTitleLength = 35;
            this.viewer.Toolbar.Font = new System.Drawing.Font("メイリオ", 9F);
            this.viewer.ToolClick += new DataDynamics.ActiveReports.Toolbar.ToolClickEventHandler(this.viewer_ToolClick);
            // 
            // saveFileDialogForExcelExport
            // 
            this.saveFileDialogForExcelExport.Filter = "Microsoft Excel ファイル(*.xls)|*.xls";
            this.saveFileDialogForExcelExport.Title = "ファイル名を付けて保存";
            // 
            // ReportPreviewPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1635, 1010);
            this.Controls.Add(this.viewer);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ReportPreviewPopup";
            this.Text = "プレビュー";
            this.ResumeLayout(false);

        }

        #endregion

        private DataDynamics.ActiveReports.Viewer.Viewer viewer;
        private System.Windows.Forms.SaveFileDialog saveFileDialogForExcelExport;
    }
}