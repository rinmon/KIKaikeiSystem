namespace Archiver
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.listInfo = new System.Windows.Forms.ListBox();
            this.btnMakeFullArchive = new System.Windows.Forms.Button();
            this.btnMakeUpdateArchive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listInfo
            // 
            this.listInfo.FormattingEnabled = true;
            this.listInfo.ItemHeight = 12;
            this.listInfo.Location = new System.Drawing.Point(12, 12);
            this.listInfo.Name = "listInfo";
            this.listInfo.Size = new System.Drawing.Size(471, 268);
            this.listInfo.TabIndex = 0;
            // 
            // btnMakeFullArchive
            // 
            this.btnMakeFullArchive.Location = new System.Drawing.Point(215, 300);
            this.btnMakeFullArchive.Name = "btnMakeFullArchive";
            this.btnMakeFullArchive.Size = new System.Drawing.Size(131, 23);
            this.btnMakeFullArchive.TabIndex = 1;
            this.btnMakeFullArchive.Text = "配布用アーカイブ作成";
            this.btnMakeFullArchive.UseVisualStyleBackColor = true;
            this.btnMakeFullArchive.Click += new System.EventHandler(this.btnMakeFullArchive_Click);
            // 
            // btnMakeUpdateArchive
            // 
            this.btnMakeUpdateArchive.Location = new System.Drawing.Point(352, 300);
            this.btnMakeUpdateArchive.Name = "btnMakeUpdateArchive";
            this.btnMakeUpdateArchive.Size = new System.Drawing.Size(131, 23);
            this.btnMakeUpdateArchive.TabIndex = 1;
            this.btnMakeUpdateArchive.Text = "更新用アーカイブ作成";
            this.btnMakeUpdateArchive.UseVisualStyleBackColor = true;
            this.btnMakeUpdateArchive.Click += new System.EventHandler(this.btnMakeUpdateArchive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 335);
            this.Controls.Add(this.btnMakeUpdateArchive);
            this.Controls.Add(this.btnMakeFullArchive);
            this.Controls.Add(this.listInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Archiver";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listInfo;
        private System.Windows.Forms.Button btnMakeFullArchive;
        private System.Windows.Forms.Button btnMakeUpdateArchive;
    }
}

