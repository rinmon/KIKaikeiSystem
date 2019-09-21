namespace KaikeiSystemBody.views.popup
{
    partial class YosanHojoKamokuPopup
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.amountSum = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.grid = new KaikeiSystemBody.views.grid.YosanHojoKamokuGrid();
            this.SuspendLayout();
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.Black;
            this.panelLine.Location = new System.Drawing.Point(0, 23);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(535, 1);
            this.panelLine.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "補助科目";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "経理区分";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "予算額";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 1);
            this.panel1.TabIndex = 2;
            // 
            // amountSum
            // 
            this.amountSum.Amount = ((long)(0));
            this.amountSum.BackColor = System.Drawing.SystemColors.Window;
            this.amountSum.Location = new System.Drawing.Point(410, 108);
            this.amountSum.Name = "amountSum";
            this.amountSum.ReadOnly = true;
            this.amountSum.Size = new System.Drawing.Size(88, 19);
            this.amountSum.TabIndex = 7;
            this.amountSum.Text = "\\0";
            this.amountSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grid
            // 
            this.grid.DataCount = 0;
            this.grid.Location = new System.Drawing.Point(0, 24);
            this.grid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grid.Name = "grid";
            this.grid.NewRowIsVisible = false;
            this.grid.Size = new System.Drawing.Size(520, 80);
            this.grid.TabIndex = 8;
            // 
            // YosanHojoKamokuPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 130);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.amountSum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLine);
            this.Name = "YosanHojoKamokuPopup";
            this.ShowInTaskbar = false;
            this.Text = "予算：補助科目";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private controls.AmountTextBox amountSum;
        private grid.YosanHojoKamokuGrid grid;
    }
}