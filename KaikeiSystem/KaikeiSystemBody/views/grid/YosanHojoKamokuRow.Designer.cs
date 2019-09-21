namespace KaikeiSystemBody.views.grid
{
    partial class YosanHojoKamokuRow
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
            this.cmbHojoKamoku = new KaikeiSystemBody.views.controls.MTComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.amountYosan = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.SuspendLayout();
            // 
            // cmbKeiriKubun
            // 
            this.cmbKeiriKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKeiriKubun.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKeiriKubun.FormattingEnabled = true;
            this.cmbKeiriKubun.Location = new System.Drawing.Point(519, 2);
            this.cmbKeiriKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKeiriKubun.Name = "cmbKeiriKubun";
            this.cmbKeiriKubun.Size = new System.Drawing.Size(217, 29);
            this.cmbKeiriKubun.TabIndex = 2;
            this.cmbKeiriKubun.Tag = "keiri_kubun";
            // 
            // cmbHojoKamoku
            // 
            this.cmbHojoKamoku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHojoKamoku.FormattingEnabled = true;
            this.cmbHojoKamoku.Location = new System.Drawing.Point(97, 2);
            this.cmbHojoKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbHojoKamoku.Name = "cmbHojoKamoku";
            this.cmbHojoKamoku.Size = new System.Drawing.Size(407, 29);
            this.cmbHojoKamoku.TabIndex = 1;
            this.cmbHojoKamoku.Tag = "hojo_id";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::KaikeiSystemBody.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(46, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 38);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.TabStop = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // amountYosan
            // 
            this.amountYosan.Amount = ((long)(0));
            this.amountYosan.Location = new System.Drawing.Point(750, 2);
            this.amountYosan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountYosan.Name = "amountYosan";
            this.amountYosan.Size = new System.Drawing.Size(158, 28);
            this.amountYosan.TabIndex = 3;
            this.amountYosan.Tag = "yosan";
            this.amountYosan.Text = "\\0";
            this.amountYosan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // YosanHojoKamokuRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.amountYosan);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbHojoKamoku);
            this.Controls.Add(this.cmbKeiriKubun);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "YosanHojoKamokuRow";
            this.Size = new System.Drawing.Size(920, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.MTComboBox cmbKeiriKubun;
        private controls.MTComboBox cmbHojoKamoku;
        private System.Windows.Forms.Button btnDelete;
        private controls.AmountTextBox amountYosan;
    }
}
