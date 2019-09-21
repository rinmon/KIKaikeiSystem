namespace KaikeiSystemBody.views.grid
{
    partial class GridPager
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
            this.textRow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textRow
            // 
            this.textRow.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textRow.Location = new System.Drawing.Point(25, 1);
            this.textRow.Name = "textRow";
            this.textRow.Size = new System.Drawing.Size(100, 27);
            this.textRow.TabIndex = 0;
            // 
            // GridPager
            // 
            this.Controls.Add(this.textRow);
            this.Name = "GridPager";
            this.Size = new System.Drawing.Size(158, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textRow;


    }
}
