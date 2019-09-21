namespace KaikeiSystemBody.views.grid
{
    partial class BSCKaikeiHoushinRow
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
            this.txtKoumoku = new System.Windows.Forms.TextBox();
            this.txtSeiriBangou = new System.Windows.Forms.TextBox();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNaiyou
            // 
            this.txtNaiyou.Location = new System.Drawing.Point(477, 9);
            this.txtNaiyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNaiyou.Name = "txtNaiyou";
            this.txtNaiyou.Size = new System.Drawing.Size(1036, 28);
            this.txtNaiyou.TabIndex = 2;
            this.txtNaiyou.Tag = "naiyou";
            // 
            // txtKoumoku
            // 
            this.txtKoumoku.Location = new System.Drawing.Point(154, 9);
            this.txtKoumoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKoumoku.Name = "txtKoumoku";
            this.txtKoumoku.Size = new System.Drawing.Size(308, 28);
            this.txtKoumoku.TabIndex = 1;
            this.txtKoumoku.Tag = "koumoku_mei";
            // 
            // txtSeiriBangou
            // 
            this.txtSeiriBangou.Location = new System.Drawing.Point(44, 9);
            this.txtSeiriBangou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSeiriBangou.Name = "txtSeiriBangou";
            this.txtSeiriBangou.Size = new System.Drawing.Size(96, 28);
            this.txtSeiriBangou.TabIndex = 0;
            this.txtSeiriBangou.Tag = "seiri_bangou";
            this.txtSeiriBangou.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRemoveRow.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveRow.Location = new System.Drawing.Point(1527, 7);
            this.btnRemoveRow.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(61, 38);
            this.btnRemoveRow.TabIndex = 3;
            this.btnRemoveRow.Text = "削";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            // 
            // BSCKaikeiHoushinRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.txtNaiyou);
            this.Controls.Add(this.txtKoumoku);
            this.Controls.Add(this.txtSeiriBangou);
            this.Controls.Add(this.btnRemoveRow);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "BSCKaikeiHoushinRow";
            this.Size = new System.Drawing.Size(1833, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.TextBox txtSeiriBangou;
        private System.Windows.Forms.TextBox txtKoumoku;
        private System.Windows.Forms.TextBox txtNaiyou;
    }
}
