namespace KaikeiSystemBody.views.controls
{
    partial class SelectKanjouKamokuDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbJigyou = new KaikeiSystemBody.views.controls.MTComboBox();
            this.cmbTaisyaku = new KaikeiSystemBody.views.controls.MTComboBox();
            this.cmbShikin = new KaikeiSystemBody.views.controls.MTComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "大区分を選択してください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "事業";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "貸借";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "資金";
            // 
            // cmbJigyou
            // 
            this.cmbJigyou.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbJigyou.FormattingEnabled = true;
            this.cmbJigyou.Location = new System.Drawing.Point(26, 94);
            this.cmbJigyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbJigyou.Name = "cmbJigyou";
            this.cmbJigyou.Size = new System.Drawing.Size(219, 29);
            this.cmbJigyou.TabIndex = 12;
            // 
            // cmbTaisyaku
            // 
            this.cmbTaisyaku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaisyaku.FormattingEnabled = true;
            this.cmbTaisyaku.Location = new System.Drawing.Point(259, 94);
            this.cmbTaisyaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbTaisyaku.Name = "cmbTaisyaku";
            this.cmbTaisyaku.Size = new System.Drawing.Size(219, 29);
            this.cmbTaisyaku.TabIndex = 13;
            // 
            // cmbShikin
            // 
            this.cmbShikin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbShikin.FormattingEnabled = true;
            this.cmbShikin.Location = new System.Drawing.Point(491, 94);
            this.cmbShikin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbShikin.Name = "cmbShikin";
            this.cmbShikin.Size = new System.Drawing.Size(219, 29);
            this.cmbShikin.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(427, 147);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 40);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(576, 147);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(138, 40);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // SelectKanjouKamokuDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(750, 208);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbShikin);
            this.Controls.Add(this.cmbTaisyaku);
            this.Controls.Add(this.cmbJigyou);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SelectKanjouKamokuDialog";
            this.ShowInTaskbar = false;
            this.Text = "勘定科目の追加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private controls.MTComboBox cmbJigyou;
        private controls.MTComboBox cmbTaisyaku;
        private controls.MTComboBox cmbShikin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}