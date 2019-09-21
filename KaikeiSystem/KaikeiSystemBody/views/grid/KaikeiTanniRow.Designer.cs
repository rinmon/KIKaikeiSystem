namespace KaikeiSystemBody.views.grid
{
    partial class KaikeiTanniRow
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtKaikeiTanni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtId.Location = new System.Drawing.Point(46, 9);
            this.txtId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(114, 31);
            this.txtId.TabIndex = 0;
            this.txtId.Tag = "id";
            // 
            // txtKaikeiTanni
            // 
            this.txtKaikeiTanni.BackColor = System.Drawing.SystemColors.Window;
            this.txtKaikeiTanni.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKaikeiTanni.Location = new System.Drawing.Point(174, 9);
            this.txtKaikeiTanni.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKaikeiTanni.Name = "txtKaikeiTanni";
            this.txtKaikeiTanni.Size = new System.Drawing.Size(279, 31);
            this.txtKaikeiTanni.TabIndex = 1;
            this.txtKaikeiTanni.Tag = "kaikei_tanni";
            // 
            // KaikeiTanniRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.txtKaikeiTanni);
            this.Controls.Add(this.txtId);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "KaikeiTanniRow";
            this.Size = new System.Drawing.Size(1705, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtKaikeiTanni;
    }
}
