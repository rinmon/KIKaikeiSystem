namespace KaikeiSystemBody.views.popup
{
    partial class YosanYobihiPopup
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
            this.row = new KaikeiSystemBody.views.grid.YosanYobihiRow();
            this.SuspendLayout();
            // 
            // row
            // 
            this.row.IsNewRow = false;
            this.row.Location = new System.Drawing.Point(4, 2);
            this.row.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.row.Name = "row";
            this.row.RowNo = 0;
            this.row.RowSelected = false;
            this.row.Size = new System.Drawing.Size(917, 105);
            this.row.TabIndex = 0;
            // 
            // YosanYobihiPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(952, 110);
            this.Controls.Add(this.row);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "YosanYobihiPopup";
            this.ShowInTaskbar = false;
            this.Text = "予算：予備費";
            this.ResumeLayout(false);

        }

        #endregion

        private grid.YosanYobihiRow row;

    }
}