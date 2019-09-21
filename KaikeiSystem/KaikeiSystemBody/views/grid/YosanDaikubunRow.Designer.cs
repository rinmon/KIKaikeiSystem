namespace KaikeiSystemBody.views.grid
{
    partial class YosanDaikubunRow
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
            this.txtKamokuKubun = new System.Windows.Forms.TextBox();
            this.txtKaikeiKubun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtKamokuKubun
            // 
            this.txtKamokuKubun.BackColor = System.Drawing.SystemColors.Window;
            this.txtKamokuKubun.Location = new System.Drawing.Point(42, 4);
            this.txtKamokuKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKamokuKubun.Name = "txtKamokuKubun";
            this.txtKamokuKubun.ReadOnly = true;
            this.txtKamokuKubun.Size = new System.Drawing.Size(437, 28);
            this.txtKamokuKubun.TabIndex = 3;
            // 
            // txtKaikeiKubun
            // 
            this.txtKaikeiKubun.BackColor = System.Drawing.SystemColors.Window;
            this.txtKaikeiKubun.Location = new System.Drawing.Point(493, 4);
            this.txtKaikeiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKaikeiKubun.Name = "txtKaikeiKubun";
            this.txtKaikeiKubun.ReadOnly = true;
            this.txtKaikeiKubun.Size = new System.Drawing.Size(176, 28);
            this.txtKaikeiKubun.TabIndex = 4;
            // 
            // YosanDaikubunRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.txtKaikeiKubun);
            this.Controls.Add(this.txtKamokuKubun);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "YosanDaikubunRow";
            this.Size = new System.Drawing.Size(678, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKamokuKubun;
        private System.Windows.Forms.TextBox txtKaikeiKubun;

    }
}
