namespace KaikeiSystemBody.views.grid
{
    partial class BSCTorikuzushiRow
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
            this.txtNaiyou = new System.Windows.Forms.TextBox();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.cmbKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.SuspendLayout();
            // 
            // txtNaiyou
            // 
            this.txtNaiyou.Location = new System.Drawing.Point(398, 9);
            this.txtNaiyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNaiyou.Name = "txtNaiyou";
            this.txtNaiyou.Size = new System.Drawing.Size(1115, 28);
            this.txtNaiyou.TabIndex = 1;
            this.txtNaiyou.Tag = "naiyou";
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRemoveRow.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveRow.Location = new System.Drawing.Point(1527, 7);
            this.btnRemoveRow.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(61, 38);
            this.btnRemoveRow.TabIndex = 2;
            this.btnRemoveRow.Text = "削";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            // 
            // cmbKaikeiKubun
            // 
            this.cmbKaikeiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKaikeiKubun.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKaikeiKubun.FormattingEnabled = true;
            this.cmbKaikeiKubun.Location = new System.Drawing.Point(46, 9);
            this.cmbKaikeiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKaikeiKubun.Name = "cmbKaikeiKubun";
            this.cmbKaikeiKubun.Size = new System.Drawing.Size(338, 29);
            this.cmbKaikeiKubun.TabIndex = 0;
            this.cmbKaikeiKubun.Tag = "kaikei_kubun";
            // 
            // BSCTorikuzushiRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.txtNaiyou);
            this.Controls.Add(this.btnRemoveRow);
            this.Controls.Add(this.cmbKaikeiKubun);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "BSCTorikuzushiRow";
            this.Size = new System.Drawing.Size(1833, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.MTComboBox cmbKaikeiKubun;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.TextBox txtNaiyou;
    }
}
