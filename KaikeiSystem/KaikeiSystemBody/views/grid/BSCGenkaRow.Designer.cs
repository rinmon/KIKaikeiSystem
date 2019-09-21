namespace KaikeiSystemBody.views.grid
{
    partial class BSCGenkaRow
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
            this.cmbKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.amountGenkaSyoukyakuRuikei = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.amountTyousyuuHunouKin = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // amountGenkaSyoukyakuRuikei
            // 
            this.amountGenkaSyoukyakuRuikei.Amount = ((long)(0));
            this.amountGenkaSyoukyakuRuikei.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountGenkaSyoukyakuRuikei.Location = new System.Drawing.Point(398, 9);
            this.amountGenkaSyoukyakuRuikei.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountGenkaSyoukyakuRuikei.Name = "amountGenkaSyoukyakuRuikei";
            this.amountGenkaSyoukyakuRuikei.Size = new System.Drawing.Size(222, 28);
            this.amountGenkaSyoukyakuRuikei.TabIndex = 1;
            this.amountGenkaSyoukyakuRuikei.Tag = "genka_baikyaku_ruikei";
            this.amountGenkaSyoukyakuRuikei.Text = "\\0";
            this.amountGenkaSyoukyakuRuikei.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amountTyousyuuHunouKin
            // 
            this.amountTyousyuuHunouKin.Amount = ((long)(0));
            this.amountTyousyuuHunouKin.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountTyousyuuHunouKin.Location = new System.Drawing.Point(634, 9);
            this.amountTyousyuuHunouKin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountTyousyuuHunouKin.Name = "amountTyousyuuHunouKin";
            this.amountTyousyuuHunouKin.Size = new System.Drawing.Size(222, 28);
            this.amountTyousyuuHunouKin.TabIndex = 2;
            this.amountTyousyuuHunouKin.Tag = "tyousyuu_hunou_kin";
            this.amountTyousyuuHunouKin.Text = "\\0";
            this.amountTyousyuuHunouKin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRemoveRow.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveRow.Location = new System.Drawing.Point(871, 7);
            this.btnRemoveRow.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(61, 38);
            this.btnRemoveRow.TabIndex = 3;
            this.btnRemoveRow.Text = "削";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            // 
            // BSCGenkaRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.btnRemoveRow);
            this.Controls.Add(this.amountTyousyuuHunouKin);
            this.Controls.Add(this.amountGenkaSyoukyakuRuikei);
            this.Controls.Add(this.cmbKaikeiKubun);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "BSCGenkaRow";
            this.Size = new System.Drawing.Size(1833, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.MTComboBox cmbKaikeiKubun;
        private controls.AmountTextBox amountGenkaSyoukyakuRuikei;
        private controls.AmountTextBox amountTyousyuuHunouKin;
        private System.Windows.Forms.Button btnRemoveRow;
    }
}
