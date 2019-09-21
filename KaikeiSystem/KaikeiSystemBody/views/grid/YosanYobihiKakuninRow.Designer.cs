namespace KaikeiSystemBody.views.grid
{
    partial class YosanYobihiKakuninRow
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
            this.amountZenkiZandaka = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.amountYosan = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblKeiriKubun = new System.Windows.Forms.Label();
            this.lblYosanKubun = new System.Windows.Forms.Label();
            this.lblHoseiKaisuu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amountZenkiZandaka
            // 
            this.amountZenkiZandaka.Amount = ((long)(0));
            this.amountZenkiZandaka.Location = new System.Drawing.Point(897, 4);
            this.amountZenkiZandaka.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountZenkiZandaka.Name = "amountZenkiZandaka";
            this.amountZenkiZandaka.Size = new System.Drawing.Size(180, 28);
            this.amountZenkiZandaka.TabIndex = 29;
            this.amountZenkiZandaka.Tag = "zenkimatsu_shiharai_shikin_zandaka";
            this.amountZenkiZandaka.Text = "\\0";
            this.amountZenkiZandaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amountYosan
            // 
            this.amountYosan.Amount = ((long)(0));
            this.amountYosan.Location = new System.Drawing.Point(702, 4);
            this.amountYosan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountYosan.Name = "amountYosan";
            this.amountYosan.Size = new System.Drawing.Size(180, 28);
            this.amountYosan.TabIndex = 2;
            this.amountYosan.Tag = "yobihi";
            this.amountYosan.Text = "\\0";
            this.amountYosan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::KaikeiSystemBody.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(39, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 38);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.TabStop = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblYear
            // 
            this.lblYear.BackColor = System.Drawing.SystemColors.Window;
            this.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYear.Location = new System.Drawing.Point(90, 4);
            this.lblYear.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(112, 32);
            this.lblYear.TabIndex = 30;
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKeiriKubun
            // 
            this.lblKeiriKubun.BackColor = System.Drawing.SystemColors.Window;
            this.lblKeiriKubun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKeiriKubun.Location = new System.Drawing.Point(215, 4);
            this.lblKeiriKubun.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKeiriKubun.Name = "lblKeiriKubun";
            this.lblKeiriKubun.Size = new System.Drawing.Size(207, 32);
            this.lblKeiriKubun.TabIndex = 31;
            this.lblKeiriKubun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYosanKubun
            // 
            this.lblYosanKubun.BackColor = System.Drawing.SystemColors.Window;
            this.lblYosanKubun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYosanKubun.Location = new System.Drawing.Point(435, 4);
            this.lblYosanKubun.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYosanKubun.Name = "lblYosanKubun";
            this.lblYosanKubun.Size = new System.Drawing.Size(141, 32);
            this.lblYosanKubun.TabIndex = 32;
            this.lblYosanKubun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHoseiKaisuu
            // 
            this.lblHoseiKaisuu.BackColor = System.Drawing.SystemColors.Window;
            this.lblHoseiKaisuu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoseiKaisuu.Location = new System.Drawing.Point(589, 4);
            this.lblHoseiKaisuu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHoseiKaisuu.Name = "lblHoseiKaisuu";
            this.lblHoseiKaisuu.Size = new System.Drawing.Size(101, 32);
            this.lblHoseiKaisuu.TabIndex = 33;
            this.lblHoseiKaisuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // YosanYobihiKakuninRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.lblHoseiKaisuu);
            this.Controls.Add(this.lblYosanKubun);
            this.Controls.Add(this.lblKeiriKubun);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.amountZenkiZandaka);
            this.Controls.Add(this.amountYosan);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "YosanYobihiKakuninRow";
            this.Size = new System.Drawing.Size(1144, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private controls.AmountTextBox amountYosan;
        private controls.AmountTextBox amountZenkiZandaka;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblKeiriKubun;
        private System.Windows.Forms.Label lblYosanKubun;
        private System.Windows.Forms.Label lblHoseiKaisuu;
    }
}
