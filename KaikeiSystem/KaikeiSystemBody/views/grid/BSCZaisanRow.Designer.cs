namespace KaikeiSystemBody.views.grid
{
    partial class BSCZaisanRow
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
            this.txtTekiyou = new System.Windows.Forms.TextBox();
            this.lblKamoku = new System.Windows.Forms.Label();
            this.cmbKamoku = new KaikeiSystemBody.views.controls.MTComboBox();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.cmbKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Amount = ((long)(0));
            this.txtAmount.Location = new System.Drawing.Point(1386, 10);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(140, 28);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.Tag = "amount";
            this.txtAmount.Text = "\\0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTekiyou
            // 
            this.txtTekiyou.Location = new System.Drawing.Point(983, 10);
            this.txtTekiyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTekiyou.Name = "txtTekiyou";
            this.txtTekiyou.Size = new System.Drawing.Size(389, 28);
            this.txtTekiyou.TabIndex = 3;
            this.txtTekiyou.Tag = "tekiyou";
            // 
            // lblKamoku
            // 
            this.lblKamoku.BackColor = System.Drawing.Color.White;
            this.lblKamoku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKamoku.Location = new System.Drawing.Point(543, 10);
            this.lblKamoku.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKamoku.Name = "lblKamoku";
            this.lblKamoku.Size = new System.Drawing.Size(427, 30);
            this.lblKamoku.TabIndex = 2;
            this.lblKamoku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbKamoku
            // 
            this.cmbKamoku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKamoku.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKamoku.FormattingEnabled = true;
            this.cmbKamoku.Location = new System.Drawing.Point(398, 9);
            this.cmbKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKamoku.Name = "cmbKamoku";
            this.cmbKamoku.Size = new System.Drawing.Size(131, 29);
            this.cmbKamoku.TabIndex = 1;
            this.cmbKamoku.Tag = "kamoku_id";
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRemoveRow.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveRow.Location = new System.Drawing.Point(1540, 7);
            this.btnRemoveRow.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(61, 38);
            this.btnRemoveRow.TabIndex = 5;
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
            // BSCZaisanRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtTekiyou);
            this.Controls.Add(this.lblKamoku);
            this.Controls.Add(this.cmbKamoku);
            this.Controls.Add(this.btnRemoveRow);
            this.Controls.Add(this.cmbKaikeiKubun);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "BSCZaisanRow";
            this.Size = new System.Drawing.Size(1833, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.MTComboBox cmbKaikeiKubun;
        private System.Windows.Forms.Button btnRemoveRow;
        private controls.MTComboBox cmbKamoku;
        private System.Windows.Forms.Label lblKamoku;
        private System.Windows.Forms.TextBox txtTekiyou;
        private controls.AmountTextBox txtAmount;
    }
}
