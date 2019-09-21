namespace KaikeiSystemBody.views.grid
{
    partial class Tyuuki11Row
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
            this.amountHyoukaSoneki = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.amountJika = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.amountTyouboKagaku = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.SuspendLayout();
            // 
            // amountHyoukaSoneki
            // 
            this.amountHyoukaSoneki.Amount = ((long)(0));
            this.amountHyoukaSoneki.Location = new System.Drawing.Point(897, 9);
            this.amountHyoukaSoneki.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountHyoukaSoneki.Name = "amountHyoukaSoneki";
            this.amountHyoukaSoneki.Size = new System.Drawing.Size(211, 28);
            this.amountHyoukaSoneki.TabIndex = 2;
            this.amountHyoukaSoneki.Tag = "hyouka_soneki";
            this.amountHyoukaSoneki.Text = "\\0";
            this.amountHyoukaSoneki.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // txtCaption
            // 
            this.txtCaption.BackColor = System.Drawing.SystemColors.Window;
            this.txtCaption.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtCaption.Location = new System.Drawing.Point(50, 7);
            this.txtCaption.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(382, 31);
            this.txtCaption.TabIndex = 4;
            this.txtCaption.Tag = "caption";
            // 
            // amountJika
            // 
            this.amountJika.Amount = ((long)(0));
            this.amountJika.Location = new System.Drawing.Point(671, 9);
            this.amountJika.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountJika.Name = "amountJika";
            this.amountJika.Size = new System.Drawing.Size(211, 28);
            this.amountJika.TabIndex = 5;
            this.amountJika.Tag = "jika";
            this.amountJika.Text = "\\0";
            this.amountJika.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amountTyouboKagaku
            // 
            this.amountTyouboKagaku.Amount = ((long)(0));
            this.amountTyouboKagaku.Location = new System.Drawing.Point(446, 9);
            this.amountTyouboKagaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountTyouboKagaku.Name = "amountTyouboKagaku";
            this.amountTyouboKagaku.Size = new System.Drawing.Size(211, 28);
            this.amountTyouboKagaku.TabIndex = 6;
            this.amountTyouboKagaku.Tag = "tyoubo_kagaku";
            this.amountTyouboKagaku.Text = "\\0";
            this.amountTyouboKagaku.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Tyuuki11Row
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.amountTyouboKagaku);
            this.Controls.Add(this.amountJika);
            this.Controls.Add(this.txtCaption);
            this.Controls.Add(this.amountHyoukaSoneki);
            this.Controls.Add(this.btnRemoveRow);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Tyuuki11Row";
            this.Size = new System.Drawing.Size(1206, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveRow;
        private controls.AmountTextBox amountHyoukaSoneki;
        private System.Windows.Forms.TextBox txtCaption;
        private controls.AmountTextBox amountJika;
        private controls.AmountTextBox amountTyouboKagaku;
    }
}
