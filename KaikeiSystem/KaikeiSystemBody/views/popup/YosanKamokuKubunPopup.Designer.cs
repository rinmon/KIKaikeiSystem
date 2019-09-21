namespace KaikeiSystemBody.views.popup
{
    partial class YosanKamokuKubunPopup
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.amountSum = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.yosanGrid = new KaikeiSystemBody.views.grid.YosanKamokuKubunGrid();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "科目ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "科目";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "会計区分";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "予算額";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 1);
            this.panel1.TabIndex = 2;
            // 
            // amountSum
            // 
            this.amountSum.Amount = ((long)(0));
            this.amountSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.amountSum.BackColor = System.Drawing.SystemColors.Window;
            this.amountSum.Location = new System.Drawing.Point(379, 181);
            this.amountSum.Name = "amountSum";
            this.amountSum.ReadOnly = true;
            this.amountSum.Size = new System.Drawing.Size(82, 19);
            this.amountSum.TabIndex = 7;
            this.amountSum.Text = "\\0";
            this.amountSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yosanGrid
            // 
            this.yosanGrid.DataCount = 0;
            this.yosanGrid.Location = new System.Drawing.Point(0, 24);
            this.yosanGrid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.yosanGrid.Name = "yosanGrid";
            this.yosanGrid.NewRowIsVisible = false;
            this.yosanGrid.Size = new System.Drawing.Size(491, 153);
            this.yosanGrid.TabIndex = 8;
            // 
            // YosanKamokuKubunPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 203);
            this.Controls.Add(this.yosanGrid);
            this.Controls.Add(this.amountSum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLine);
            this.Name = "YosanKamokuKubunPopup";
            this.ShowInTaskbar = false;
            this.Text = "予算：科目";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private controls.AmountTextBox amountSum;
        private grid.YosanKamokuKubunGrid yosanGrid;
    }
}