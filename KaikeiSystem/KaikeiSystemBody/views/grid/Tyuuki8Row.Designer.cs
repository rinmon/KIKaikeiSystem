namespace KaikeiSystemBody.views.grid
{
    partial class Tyuuki8Row
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
            this.txtAmount = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.cmbKamokuKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.cmbTanpoKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Amount = ((long)(0));
            this.txtAmount.Location = new System.Drawing.Point(873, 9);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(235, 28);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.Tag = "amount";
            this.txtAmount.Text = "\\0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbKamokuKubun
            // 
            this.cmbKamokuKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKamokuKubun.DropDownHeight = 200;
            this.cmbKamokuKubun.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKamokuKubun.FormattingEnabled = true;
            this.cmbKamokuKubun.IntegralHeight = false;
            this.cmbKamokuKubun.Location = new System.Drawing.Point(524, 9);
            this.cmbKamokuKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKamokuKubun.Name = "cmbKamokuKubun";
            this.cmbKamokuKubun.Size = new System.Drawing.Size(334, 29);
            this.cmbKamokuKubun.TabIndex = 1;
            this.cmbKamokuKubun.Tag = "kamoku_kubun_id";
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRemoveRow.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveRow.Location = new System.Drawing.Point(1122, 9);
            this.btnRemoveRow.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(61, 38);
            this.btnRemoveRow.TabIndex = 3;
            this.btnRemoveRow.Text = "削";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            // 
            // cmbTanpoKubun
            // 
            this.cmbTanpoKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTanpoKubun.DropDownHeight = 200;
            this.cmbTanpoKubun.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbTanpoKubun.FormattingEnabled = true;
            this.cmbTanpoKubun.IntegralHeight = false;
            this.cmbTanpoKubun.Location = new System.Drawing.Point(46, 9);
            this.cmbTanpoKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbTanpoKubun.Name = "cmbTanpoKubun";
            this.cmbTanpoKubun.Size = new System.Drawing.Size(464, 29);
            this.cmbTanpoKubun.TabIndex = 0;
            this.cmbTanpoKubun.Tag = "tanpo_kubun_id";
            // 
            // Tyuuki8Row
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.cmbTanpoKubun);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cmbKamokuKubun);
            this.Controls.Add(this.btnRemoveRow);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Tyuuki8Row";
            this.Size = new System.Drawing.Size(1206, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveRow;
        private controls.MTComboBox cmbKamokuKubun;
        private controls.AmountTextBox txtAmount;
        private controls.MTComboBox cmbTanpoKubun;
    }
}
