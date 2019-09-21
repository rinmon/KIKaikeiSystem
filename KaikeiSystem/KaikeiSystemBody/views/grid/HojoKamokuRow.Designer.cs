namespace KaikeiSystemBody.views.grid
{
    partial class HojoKamokuRow
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
            this.txtKamoku = new System.Windows.Forms.TextBox();
            this.txtJigyouKamokuKubun = new System.Windows.Forms.TextBox();
            this.txtTaisyakuKamokuKubun = new System.Windows.Forms.TextBox();
            this.txtShikinKamokuKubun = new System.Windows.Forms.TextBox();
            this.btnAddHojoKamoku = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkPrintTarget = new System.Windows.Forms.CheckBox();
            this.pictChild = new System.Windows.Forms.PictureBox();
            this.cmbKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictChild)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKamokuCode
            // 
            this.txtKamokuCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtKamokuCode.Location = new System.Drawing.Point(425, 5);
            this.txtKamokuCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKamokuCode.Name = "txtKamokuCode";
            this.txtKamokuCode.Size = new System.Drawing.Size(134, 28);
            this.txtKamokuCode.TabIndex = 1;
            this.txtKamokuCode.Tag = "kamoku_code";
            // 
            // txtKamoku
            // 
            this.txtKamoku.BackColor = System.Drawing.SystemColors.Window;
            this.txtKamoku.Location = new System.Drawing.Point(51, 5);
            this.txtKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKamoku.Name = "txtKamoku";
            this.txtKamoku.Size = new System.Drawing.Size(360, 28);
            this.txtKamoku.TabIndex = 0;
            this.txtKamoku.Tag = "kamoku";
            // 
            // txtJigyouKamokuKubun
            // 
            this.txtJigyouKamokuKubun.BackColor = System.Drawing.SystemColors.Window;
            this.txtJigyouKamokuKubun.Location = new System.Drawing.Point(51, 49);
            this.txtJigyouKamokuKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtJigyouKamokuKubun.Name = "txtJigyouKamokuKubun";
            this.txtJigyouKamokuKubun.Size = new System.Drawing.Size(360, 28);
            this.txtJigyouKamokuKubun.TabIndex = 2;
            this.txtJigyouKamokuKubun.Tag = "jigyou_kamoku_kubun";
            // 
            // txtTaisyakuKamokuKubun
            // 
            this.txtTaisyakuKamokuKubun.BackColor = System.Drawing.SystemColors.Window;
            this.txtTaisyakuKamokuKubun.Location = new System.Drawing.Point(425, 49);
            this.txtTaisyakuKamokuKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTaisyakuKamokuKubun.Name = "txtTaisyakuKamokuKubun";
            this.txtTaisyakuKamokuKubun.Size = new System.Drawing.Size(360, 28);
            this.txtTaisyakuKamokuKubun.TabIndex = 3;
            this.txtTaisyakuKamokuKubun.Tag = "taisyaku_kamoku_kubun";
            // 
            // txtShikinKamokuKubun
            // 
            this.txtShikinKamokuKubun.BackColor = System.Drawing.SystemColors.Window;
            this.txtShikinKamokuKubun.Location = new System.Drawing.Point(799, 49);
            this.txtShikinKamokuKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtShikinKamokuKubun.Name = "txtShikinKamokuKubun";
            this.txtShikinKamokuKubun.Size = new System.Drawing.Size(360, 28);
            this.txtShikinKamokuKubun.TabIndex = 4;
            this.txtShikinKamokuKubun.Tag = "shikin_kamoku_kubun";
            // 
            // btnAddHojoKamoku
            // 
            this.btnAddHojoKamoku.Location = new System.Drawing.Point(1173, 0);
            this.btnAddHojoKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAddHojoKamoku.Name = "btnAddHojoKamoku";
            this.btnAddHojoKamoku.Size = new System.Drawing.Size(196, 42);
            this.btnAddHojoKamoku.TabIndex = 5;
            this.btnAddHojoKamoku.Text = "補助科目追加";
            this.btnAddHojoKamoku.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(1173, 44);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(196, 42);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // chkPrintTarget
            // 
            this.chkPrintTarget.AutoSize = true;
            this.chkPrintTarget.Location = new System.Drawing.Point(574, 9);
            this.chkPrintTarget.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkPrintTarget.Name = "chkPrintTarget";
            this.chkPrintTarget.Size = new System.Drawing.Size(204, 25);
            this.chkPrintTarget.TabIndex = 9;
            this.chkPrintTarget.Tag = "denpyou_print_target";
            this.chkPrintTarget.Text = "仕訳伝票印刷対象";
            this.chkPrintTarget.UseVisualStyleBackColor = true;
            // 
            // pictChild
            // 
            this.pictChild.Image = global::KaikeiSystemBody.Properties.Resources.down_right;
            this.pictChild.Location = new System.Drawing.Point(53, 9);
            this.pictChild.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictChild.Name = "pictChild";
            this.pictChild.Size = new System.Drawing.Size(16, 16);
            this.pictChild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictChild.TabIndex = 11;
            this.pictChild.TabStop = false;
            // 
            // cmbKaikeiKubun
            // 
            this.cmbKaikeiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKaikeiKubun.FormattingEnabled = true;
            this.cmbKaikeiKubun.Location = new System.Drawing.Point(799, 5);
            this.cmbKaikeiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKaikeiKubun.Name = "cmbKaikeiKubun";
            this.cmbKaikeiKubun.Size = new System.Drawing.Size(360, 29);
            this.cmbKaikeiKubun.TabIndex = 12;
            this.cmbKaikeiKubun.Tag = "kaikei_kubun_id";
            // 
            // HojoKamokuRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.cmbKaikeiKubun);
            this.Controls.Add(this.pictChild);
            this.Controls.Add(this.chkPrintTarget);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddHojoKamoku);
            this.Controls.Add(this.txtShikinKamokuKubun);
            this.Controls.Add(this.txtTaisyakuKamokuKubun);
            this.Controls.Add(this.txtJigyouKamokuKubun);
            this.Controls.Add(this.txtKamoku);
            this.Controls.Add(this.txtKamokuCode);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "HojoKamokuRow";
            this.Size = new System.Drawing.Size(1381, 91);
            ((System.ComponentModel.ISupportInitialize)(this.pictChild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKamokuCode;
        private System.Windows.Forms.TextBox txtKamoku;
        private System.Windows.Forms.TextBox txtJigyouKamokuKubun;
        private System.Windows.Forms.TextBox txtTaisyakuKamokuKubun;
        private System.Windows.Forms.TextBox txtShikinKamokuKubun;
        private System.Windows.Forms.Button btnAddHojoKamoku;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkPrintTarget;
        private System.Windows.Forms.PictureBox pictChild;
        private controls.MTComboBox cmbKaikeiKubun;
    }
}
