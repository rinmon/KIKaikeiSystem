namespace KaikeiSystemBody.views.popup
{
    partial class YosanKamokuDaikubunPopup
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yosanGrid = new KaikeiSystemBody.views.grid.YosanKamokuDaikubunGrid();
            this.SuspendLayout();
            // 
            // panelLine
            // 
            this.panelLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLine.BackColor = System.Drawing.Color.Black;
            this.panelLine.Location = new System.Drawing.Point(0, 23);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(535, 1);
            this.panelLine.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "科目";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "経理区分";
            // 
            // yosanGrid
            // 
            this.yosanGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yosanGrid.DataCount = 0;
            this.yosanGrid.Location = new System.Drawing.Point(0, 24);
            this.yosanGrid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.yosanGrid.Name = "yosanGrid";
            this.yosanGrid.NewRowIsVisible = false;
            this.yosanGrid.Size = new System.Drawing.Size(492, 179);
            this.yosanGrid.TabIndex = 7;
            // 
            // YosanKamokuDaikubunPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 203);
            this.Controls.Add(this.yosanGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelLine);
            this.Name = "YosanKamokuDaikubunPopup";
            this.ShowInTaskbar = false;
            this.Text = "予算：大区分";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private grid.YosanKamokuDaikubunGrid yosanGrid;
    }
}