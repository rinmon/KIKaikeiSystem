namespace KaikeiSystemBody.views.grid
{
    partial class YosanKamokuRow
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
            this.cmbKeiriKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.cmbKamoku = new KaikeiSystemBody.views.controls.MTComboBox();
            this.txtKamokuCode = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.amountYosan = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.SuspendLayout();
            // 
            // cmbKeiriKubun
            // 
            this.cmbKeiriKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKeiriKubun.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKeiriKubun.FormattingEnabled = true;
            this.cmbKeiriKubun.Location = new System.Drawing.Point(572, 2);
            this.cmbKeiriKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKeiriKubun.Name = "cmbKeiriKubun";
            this.cmbKeiriKubun.Size = new System.Drawing.Size(173, 29);
            this.cmbKeiriKubun.TabIndex = 1;
            this.cmbKeiriKubun.Tag = "keiri_kubun";
            // 
            // cmbKamoku
            // 
            this.cmbKamoku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKamoku.FormattingEnabled = true;
            this.cmbKamoku.Location = new System.Drawing.Point(204, 2);
            this.cmbKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKamoku.Name = "cmbKamoku";
            this.cmbKamoku.Size = new System.Drawing.Size(360, 29);
            this.cmbKamoku.TabIndex = 0;
            this.cmbKamoku.Tag = "kamoku_id";
            // 
            // txtKamokuCode
            // 
            this.txtKamokuCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtKamokuCode.Location = new System.Drawing.Point(106, 2);
            this.txtKamokuCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKamokuCode.Name = "txtKamokuCode";
            this.txtKamokuCode.ReadOnly = true;
            this.txtKamokuCode.Size = new System.Drawing.Size(88, 28);
            this.txtKamokuCode.TabIndex = 3;
            this.txtKamokuCode.TabStop = false;
            this.txtKamokuCode.Tag = "kamoku_code";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::KaikeiSystemBody.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(46, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 38);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.TabStop = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // amountYosan
            // 
            this.amountYosan.Amount = ((long)(0));
            this.amountYosan.Location = new System.Drawing.Point(759, 2);
            this.amountYosan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountYosan.Name = "amountYosan";
            this.amountYosan.Size = new System.Drawing.Size(147, 28);
            this.amountYosan.TabIndex = 2;
            this.amountYosan.Tag = "yosan";
            this.amountYosan.Text = "\\0";
            this.amountYosan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // YosanKamokuRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.amountYosan);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtKamokuCode);
            this.Controls.Add(this.cmbKamoku);
            this.Controls.Add(this.cmbKeiriKubun);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "YosanKamokuRow";
            this.Size = new System.Drawing.Size(920, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.MTComboBox cmbKeiriKubun;
        private controls.MTComboBox cmbKamoku;
        private System.Windows.Forms.TextBox txtKamokuCode;
        private System.Windows.Forms.Button btnDelete;
        private controls.AmountTextBox amountYosan;
    }
}
