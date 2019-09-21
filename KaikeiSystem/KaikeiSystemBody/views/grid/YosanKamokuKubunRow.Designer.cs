namespace KaikeiSystemBody.views.grid
{
    partial class YosanKamokuKubunRow
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.amountYosan = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.txtKamokuKubun = new System.Windows.Forms.TextBox();
            this.txtKaikeiKubun = new System.Windows.Forms.TextBox();
            this.txtKamokuCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // amountYosan
            // 
            this.amountYosan.Amount = ((long)(0));
            this.amountYosan.Location = new System.Drawing.Point(695, 2);
            this.amountYosan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountYosan.Name = "amountYosan";
            this.amountYosan.Size = new System.Drawing.Size(147, 28);
            this.amountYosan.TabIndex = 3;
            this.amountYosan.Tag = "yosan";
            this.amountYosan.Text = "\\0";
            this.amountYosan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKamokuKubun
            // 
            this.txtKamokuKubun.BackColor = System.Drawing.SystemColors.Window;
            this.txtKamokuKubun.Location = new System.Drawing.Point(145, 2);
            this.txtKamokuKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKamokuKubun.Name = "txtKamokuKubun";
            this.txtKamokuKubun.ReadOnly = true;
            this.txtKamokuKubun.Size = new System.Drawing.Size(360, 28);
            this.txtKamokuKubun.TabIndex = 1;
            // 
            // txtKaikeiKubun
            // 
            this.txtKaikeiKubun.BackColor = System.Drawing.SystemColors.Window;
            this.txtKaikeiKubun.Location = new System.Drawing.Point(519, 2);
            this.txtKaikeiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKaikeiKubun.Name = "txtKaikeiKubun";
            this.txtKaikeiKubun.ReadOnly = true;
            this.txtKaikeiKubun.Size = new System.Drawing.Size(162, 28);
            this.txtKaikeiKubun.TabIndex = 2;
            // 
            // txtKamokuCode
            // 
            this.txtKamokuCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtKamokuCode.Location = new System.Drawing.Point(42, 2);
            this.txtKamokuCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKamokuCode.Name = "txtKamokuCode";
            this.txtKamokuCode.ReadOnly = true;
            this.txtKamokuCode.Size = new System.Drawing.Size(88, 28);
            this.txtKamokuCode.TabIndex = 0;
            this.txtKamokuCode.TabStop = false;
            this.txtKamokuCode.Tag = "";
            // 
            // YosanKamokuKubunRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.txtKaikeiKubun);
            this.Controls.Add(this.txtKamokuKubun);
            this.Controls.Add(this.amountYosan);
            this.Controls.Add(this.txtKamokuCode);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "YosanKamokuKubunRow";
            this.Size = new System.Drawing.Size(860, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.AmountTextBox amountYosan;
        private System.Windows.Forms.TextBox txtKamokuKubun;
        private System.Windows.Forms.TextBox txtKaikeiKubun;
        private System.Windows.Forms.TextBox txtKamokuCode;
    }
}
