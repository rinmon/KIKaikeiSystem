namespace KaikeiSystemBody.views.grid
{
    partial class ZenkiKurikoshiKamokuKubunRow
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
            this.amountKurikoshi = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.txtKamokuKubun = new System.Windows.Forms.TextBox();
            this.txtTaisyakuKubun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // amountKurikoshi
            // 
            this.amountKurikoshi.Amount = ((long)(0));
            this.amountKurikoshi.Location = new System.Drawing.Point(649, 2);
            this.amountKurikoshi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountKurikoshi.Name = "amountKurikoshi";
            this.amountKurikoshi.Size = new System.Drawing.Size(202, 28);
            this.amountKurikoshi.TabIndex = 3;
            this.amountKurikoshi.Tag = "zenki_kurikoshi_gaku";
            this.amountKurikoshi.Text = "\\0";
            this.amountKurikoshi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKamokuKubun
            // 
            this.txtKamokuKubun.BackColor = System.Drawing.SystemColors.Window;
            this.txtKamokuKubun.Location = new System.Drawing.Point(42, 2);
            this.txtKamokuKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKamokuKubun.Name = "txtKamokuKubun";
            this.txtKamokuKubun.ReadOnly = true;
            this.txtKamokuKubun.Size = new System.Drawing.Size(523, 28);
            this.txtKamokuKubun.TabIndex = 1;
            // 
            // txtTaisyakuKubun
            // 
            this.txtTaisyakuKubun.BackColor = System.Drawing.SystemColors.Window;
            this.txtTaisyakuKubun.Location = new System.Drawing.Point(579, 2);
            this.txtTaisyakuKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTaisyakuKubun.Name = "txtTaisyakuKubun";
            this.txtTaisyakuKubun.ReadOnly = true;
            this.txtTaisyakuKubun.Size = new System.Drawing.Size(55, 28);
            this.txtTaisyakuKubun.TabIndex = 2;
            // 
            // ZenkiKurikoshiKamokuKubunRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.txtTaisyakuKubun);
            this.Controls.Add(this.txtKamokuKubun);
            this.Controls.Add(this.amountKurikoshi);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ZenkiKurikoshiKamokuKubunRow";
            this.Size = new System.Drawing.Size(860, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.AmountTextBox amountKurikoshi;
        private System.Windows.Forms.TextBox txtKamokuKubun;
        private System.Windows.Forms.TextBox txtTaisyakuKubun;
    }
}
