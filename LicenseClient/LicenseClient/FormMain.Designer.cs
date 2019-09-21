namespace LicenseClient
{
    partial class FormMain
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
            this.listBoxMessage = new System.Windows.Forms.ListBox();
            this.btnUpdateLicense = new System.Windows.Forms.Button();
            this.btnUpdateProgram = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMessage
            // 
            this.listBoxMessage.FormattingEnabled = true;
            this.listBoxMessage.ItemHeight = 12;
            this.listBoxMessage.Location = new System.Drawing.Point(12, 12);
            this.listBoxMessage.Name = "listBoxMessage";
            this.listBoxMessage.ScrollAlwaysVisible = true;
            this.listBoxMessage.Size = new System.Drawing.Size(383, 172);
            this.listBoxMessage.TabIndex = 0;
            // 
            // btnUpdateLicense
            // 
            this.btnUpdateLicense.Location = new System.Drawing.Point(12, 190);
            this.btnUpdateLicense.Name = "btnUpdateLicense";
            this.btnUpdateLicense.Size = new System.Drawing.Size(95, 28);
            this.btnUpdateLicense.TabIndex = 1;
            this.btnUpdateLicense.Text = "ライセンス更新";
            this.btnUpdateLicense.UseVisualStyleBackColor = true;
            this.btnUpdateLicense.Click += new System.EventHandler(this.btnUpdateLicense_Click);
            // 
            // btnUpdateProgram
            // 
            this.btnUpdateProgram.Location = new System.Drawing.Point(113, 190);
            this.btnUpdateProgram.Name = "btnUpdateProgram";
            this.btnUpdateProgram.Size = new System.Drawing.Size(95, 28);
            this.btnUpdateProgram.TabIndex = 2;
            this.btnUpdateProgram.Text = "プログラム更新";
            this.btnUpdateProgram.UseVisualStyleBackColor = true;
            this.btnUpdateProgram.Click += new System.EventHandler(this.btnUpdateProgram_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(300, 190);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 226);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdateProgram);
            this.Controls.Add(this.btnUpdateLicense);
            this.Controls.Add(this.listBoxMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "LicenseManager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMessage;
        private System.Windows.Forms.Button btnUpdateLicense;
        private System.Windows.Forms.Button btnUpdateProgram;
        private System.Windows.Forms.Button btnClose;
    }
}

