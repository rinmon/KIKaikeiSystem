namespace KaikeiSystemBody.views.grid
{
    partial class KanjouKamokuRow
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
            this.txtKamokuCode = new System.Windows.Forms.TextBox();
            this.txtKamoku = new KaikeiSystemBody.views.controls.YomiTextBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.txtParent = new KaikeiSystemBody.views.controls.YomiTextBox();
            this.txtTaisyakuKubun = new KaikeiSystemBody.views.controls.YomiTextBox();
            this.chkUsable = new System.Windows.Forms.CheckBox();
            this.txtShikinKamokuKubun = new KaikeiSystemBody.views.controls.YomiTextBox();
            this.txtJigyouKamokuKubun = new KaikeiSystemBody.views.controls.YomiTextBox();
            this.txtTaisyakuKamokuKubun = new KaikeiSystemBody.views.controls.YomiTextBox();
            this.chkPrintTarget = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtKamokuCode
            // 
            this.txtKamokuCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtKamokuCode.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKamokuCode.Location = new System.Drawing.Point(95, 3);
            this.txtKamokuCode.Name = "txtKamokuCode";
            this.txtKamokuCode.ReadOnly = true;
            this.txtKamokuCode.Size = new System.Drawing.Size(62, 21);
            this.txtKamokuCode.TabIndex = 1;
            this.txtKamokuCode.TabStop = false;
            this.txtKamokuCode.Tag = "kamoku_code";
            // 
            // txtKamoku
            // 
            this.txtKamoku.BackColor = System.Drawing.SystemColors.Window;
            this.txtKamoku.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKamoku.Location = new System.Drawing.Point(163, 3);
            this.txtKamoku.Name = "txtKamoku";
            this.txtKamoku.ReadOnly = true;
            this.txtKamoku.Size = new System.Drawing.Size(170, 21);
            this.txtKamoku.TabIndex = 2;
            this.txtKamoku.Tag = "kamoku";
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(21, 2);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(68, 23);
            this.btnDetail.TabIndex = 0;
            this.btnDetail.Text = "詳細（D）";
            this.btnDetail.UseVisualStyleBackColor = true;
            // 
            // txtParent
            // 
            this.txtParent.BackColor = System.Drawing.SystemColors.Window;
            this.txtParent.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtParent.Location = new System.Drawing.Point(339, 3);
            this.txtParent.Name = "txtParent";
            this.txtParent.ReadOnly = true;
            this.txtParent.Size = new System.Drawing.Size(155, 21);
            this.txtParent.TabIndex = 3;
            this.txtParent.Tag = "";
            // 
            // txtTaisyakuKubun
            // 
            this.txtTaisyakuKubun.BackColor = System.Drawing.SystemColors.Window;
            this.txtTaisyakuKubun.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTaisyakuKubun.Location = new System.Drawing.Point(500, 3);
            this.txtTaisyakuKubun.Name = "txtTaisyakuKubun";
            this.txtTaisyakuKubun.ReadOnly = true;
            this.txtTaisyakuKubun.Size = new System.Drawing.Size(50, 21);
            this.txtTaisyakuKubun.TabIndex = 4;
            this.txtTaisyakuKubun.Tag = "taisyaku_kubun_id";
            // 
            // chkUsable
            // 
            this.chkUsable.AutoSize = true;
            this.chkUsable.Location = new System.Drawing.Point(567, 6);
            this.chkUsable.Name = "chkUsable";
            this.chkUsable.Size = new System.Drawing.Size(15, 14);
            this.chkUsable.TabIndex = 5;
            this.chkUsable.Tag = "usable";
            this.chkUsable.UseVisualStyleBackColor = true;
            // 
            // txtShikinKamokuKubun
            // 
            this.txtShikinKamokuKubun.BackColor = System.Drawing.SystemColors.Window;
            this.txtShikinKamokuKubun.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtShikinKamokuKubun.Location = new System.Drawing.Point(891, 2);
            this.txtShikinKamokuKubun.Name = "txtShikinKamokuKubun";
            this.txtShikinKamokuKubun.ReadOnly = true;
            this.txtShikinKamokuKubun.Size = new System.Drawing.Size(113, 21);
            this.txtShikinKamokuKubun.TabIndex = 7;
            this.txtShikinKamokuKubun.Tag = "";
            // 
            // txtJigyouKamokuKubun
            // 
            this.txtJigyouKamokuKubun.BackColor = System.Drawing.SystemColors.Window;
            this.txtJigyouKamokuKubun.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtJigyouKamokuKubun.Location = new System.Drawing.Point(653, 3);
            this.txtJigyouKamokuKubun.Name = "txtJigyouKamokuKubun";
            this.txtJigyouKamokuKubun.ReadOnly = true;
            this.txtJigyouKamokuKubun.Size = new System.Drawing.Size(113, 21);
            this.txtJigyouKamokuKubun.TabIndex = 8;
            this.txtJigyouKamokuKubun.Tag = "";
            // 
            // txtTaisyakuKamokuKubun
            // 
            this.txtTaisyakuKamokuKubun.BackColor = System.Drawing.SystemColors.Window;
            this.txtTaisyakuKamokuKubun.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTaisyakuKamokuKubun.Location = new System.Drawing.Point(772, 2);
            this.txtTaisyakuKamokuKubun.Name = "txtTaisyakuKamokuKubun";
            this.txtTaisyakuKamokuKubun.ReadOnly = true;
            this.txtTaisyakuKamokuKubun.Size = new System.Drawing.Size(113, 21);
            this.txtTaisyakuKamokuKubun.TabIndex = 9;
            this.txtTaisyakuKamokuKubun.Tag = "";
            // 
            // chkPrintTarget
            // 
            this.chkPrintTarget.AutoSize = true;
            this.chkPrintTarget.Enabled = false;
            this.chkPrintTarget.Location = new System.Drawing.Point(619, 6);
            this.chkPrintTarget.Name = "chkPrintTarget";
            this.chkPrintTarget.Size = new System.Drawing.Size(15, 14);
            this.chkPrintTarget.TabIndex = 6;
            this.chkPrintTarget.Tag = "denpyou_print_target";
            this.chkPrintTarget.UseVisualStyleBackColor = true;
            // 
            // KanjouKamokuRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkPrintTarget);
            this.Controls.Add(this.txtTaisyakuKamokuKubun);
            this.Controls.Add(this.txtJigyouKamokuKubun);
            this.Controls.Add(this.txtShikinKamokuKubun);
            this.Controls.Add(this.chkUsable);
            this.Controls.Add(this.txtTaisyakuKubun);
            this.Controls.Add(this.txtParent);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.txtKamoku);
            this.Controls.Add(this.txtKamokuCode);
            this.Name = "KanjouKamokuRow";
            this.Size = new System.Drawing.Size(1018, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKamokuCode;
        private controls.YomiTextBox txtKamoku;
        private System.Windows.Forms.Button btnDetail;
        private controls.YomiTextBox txtParent;
        private controls.YomiTextBox txtTaisyakuKubun;
        private System.Windows.Forms.CheckBox chkUsable;
        private controls.YomiTextBox txtShikinKamokuKubun;
        private controls.YomiTextBox txtJigyouKamokuKubun;
        private controls.YomiTextBox txtTaisyakuKamokuKubun;
        private System.Windows.Forms.CheckBox chkPrintTarget;
    }
}
