namespace KaikeiSystemBody.views.grid
{
    partial class TorihikiKubunRow
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
            this.txtTorihikiKubun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtId.Location = new System.Drawing.Point(46, 9);
            this.txtId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(114, 31);
            this.txtId.TabIndex = 0;
            this.txtId.Tag = "id";
            // 
            // txtTorihikiKubun
            // 
            this.txtTorihikiKubun.BackColor = System.Drawing.SystemColors.Window;
            this.txtTorihikiKubun.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTorihikiKubun.Location = new System.Drawing.Point(174, 9);
            this.txtTorihikiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTorihikiKubun.Name = "txtTorihikiKubun";
            this.txtTorihikiKubun.Size = new System.Drawing.Size(279, 31);
            this.txtTorihikiKubun.TabIndex = 1;
            this.txtTorihikiKubun.Tag = "torihiki_kubun";
            // 
            // TorihikiKubunRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.txtTorihikiKubun);
            this.Controls.Add(this.txtId);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "TorihikiKubunRow";
            this.Size = new System.Drawing.Size(1705, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTorihikiKubun;
    }
}
