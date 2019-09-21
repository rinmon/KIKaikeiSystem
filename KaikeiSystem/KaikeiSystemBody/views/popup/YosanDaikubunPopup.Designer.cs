namespace KaikeiSystemBody.views.popup
{
    partial class YosanDaikubunPopup
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
            this.panelLine = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grid = new KaikeiSystemBody.views.grid.YosanDaikubunGrid();
            this.SuspendLayout();
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.Black;
            this.panelLine.Location = new System.Drawing.Point(0, 40);
            this.panelLine.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(733, 2);
            this.panelLine.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "大区分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "会計区分";
            // 
            // grid
            // 
            this.grid.DataCount = 0;
            this.grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid.Location = new System.Drawing.Point(0, 40);
            this.grid.Margin = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.grid.Name = "grid";
            this.grid.NewRowIsVisible = false;
            this.grid.Size = new System.Drawing.Size(704, 455);
            this.grid.TabIndex = 0;
            // 
            // YosanDaikubunPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(704, 495);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.grid);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "YosanDaikubunPopup";
            this.ShowInTaskbar = false;
            this.Text = "予算：大区分";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private grid.YosanDaikubunGrid grid;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}