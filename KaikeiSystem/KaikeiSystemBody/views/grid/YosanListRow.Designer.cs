namespace KaikeiSystemBody.views.grid
{
    partial class YosanListRow
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
            this.lblKeiriKubun = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYosanKubun = new System.Windows.Forms.Label();
            this.lblHoseiKaisuu = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKeiriKubun
            // 
            this.lblKeiriKubun.BackColor = System.Drawing.SystemColors.Window;
            this.lblKeiriKubun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKeiriKubun.Location = new System.Drawing.Point(271, 12);
            this.lblKeiriKubun.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKeiriKubun.Name = "lblKeiriKubun";
            this.lblKeiriKubun.Size = new System.Drawing.Size(336, 32);
            this.lblKeiriKubun.TabIndex = 31;
            this.lblKeiriKubun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYear
            // 
            this.lblYear.BackColor = System.Drawing.SystemColors.Window;
            this.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYear.Location = new System.Drawing.Point(48, 12);
            this.lblYear.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(211, 32);
            this.lblYear.TabIndex = 30;
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYosanKubun
            // 
            this.lblYosanKubun.BackColor = System.Drawing.SystemColors.Window;
            this.lblYosanKubun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYosanKubun.Location = new System.Drawing.Point(620, 12);
            this.lblYosanKubun.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYosanKubun.Name = "lblYosanKubun";
            this.lblYosanKubun.Size = new System.Drawing.Size(204, 32);
            this.lblYosanKubun.TabIndex = 32;
            this.lblYosanKubun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHoseiKaisuu
            // 
            this.lblHoseiKaisuu.BackColor = System.Drawing.SystemColors.Window;
            this.lblHoseiKaisuu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoseiKaisuu.Location = new System.Drawing.Point(836, 12);
            this.lblHoseiKaisuu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHoseiKaisuu.Name = "lblHoseiKaisuu";
            this.lblHoseiKaisuu.Size = new System.Drawing.Size(163, 32);
            this.lblHoseiKaisuu.TabIndex = 33;
            this.lblHoseiKaisuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(1012, 5);
            this.btnShow.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(117, 46);
            this.btnShow.TabIndex = 34;
            this.btnShow.Text = "表示";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // YosanListRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblHoseiKaisuu);
            this.Controls.Add(this.lblYosanKubun);
            this.Controls.Add(this.lblKeiriKubun);
            this.Controls.Add(this.lblYear);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "YosanListRow";
            this.Size = new System.Drawing.Size(1192, 60);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblKeiriKubun;
        private System.Windows.Forms.Label lblYosanKubun;
        private System.Windows.Forms.Label lblHoseiKaisuu;
        private System.Windows.Forms.Button btnShow;
    }
}
