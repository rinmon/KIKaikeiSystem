namespace KaikeiSystemBody.views.controls
{
    partial class MultiColumnComboBox
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
            this.SuspendLayout();
            // 
            // MultiColumnComboBox
            // 
            this.SelectedIndexChanged += new System.EventHandler(this.MultiColumnComboBox_SelectedIndexChanged);
            this.FontChanged += new System.EventHandler(this.MultiColumnComboBox_FontChanged);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
