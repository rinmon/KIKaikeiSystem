namespace KaikeiSystemBody.views.grid
{
    partial class KanjouKamokuDetailRow
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
            this.txtShikinKamokuKubun = new System.Windows.Forms.TextBox();
            this.txtTaisyakuKamokuKubun = new System.Windows.Forms.TextBox();
            this.txtJigyouKamokuKubun = new System.Windows.Forms.TextBox();
            this.txtKamoku = new System.Windows.Forms.TextBox();
            this.txtKamokuCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTaisyaku = new KaikeiSystemBody.views.controls.MTComboBox();
            this.chkUsable = new System.Windows.Forms.CheckBox();
            this.chkPrintTarget = new System.Windows.Forms.CheckBox();
            this.txtKamokuYomi = new KaikeiSystemBody.views.controls.YomiTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNotEditable = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtParentJigyou = new System.Windows.Forms.TextBox();
            this.txtParentTaisyaku = new System.Windows.Forms.TextBox();
            this.txtParentShikin = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtShikinKamokuKubun
            // 
            this.txtShikinKamokuKubun.BackColor = System.Drawing.SystemColors.Window;
            this.txtShikinKamokuKubun.Location = new System.Drawing.Point(763, 170);
            this.txtShikinKamokuKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtShikinKamokuKubun.Name = "txtShikinKamokuKubun";
            this.txtShikinKamokuKubun.Size = new System.Drawing.Size(360, 28);
            this.txtShikinKamokuKubun.TabIndex = 8;
            this.txtShikinKamokuKubun.Tag = "shikin_kamoku_kubun";
            // 
            // txtTaisyakuKamokuKubun
            // 
            this.txtTaisyakuKamokuKubun.BackColor = System.Drawing.SystemColors.Window;
            this.txtTaisyakuKamokuKubun.Location = new System.Drawing.Point(389, 170);
            this.txtTaisyakuKamokuKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTaisyakuKamokuKubun.Name = "txtTaisyakuKamokuKubun";
            this.txtTaisyakuKamokuKubun.Size = new System.Drawing.Size(360, 28);
            this.txtTaisyakuKamokuKubun.TabIndex = 7;
            this.txtTaisyakuKamokuKubun.Tag = "taisyaku_kamoku_kubun";
            // 
            // txtJigyouKamokuKubun
            // 
            this.txtJigyouKamokuKubun.BackColor = System.Drawing.SystemColors.Window;
            this.txtJigyouKamokuKubun.Location = new System.Drawing.Point(15, 170);
            this.txtJigyouKamokuKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtJigyouKamokuKubun.Name = "txtJigyouKamokuKubun";
            this.txtJigyouKamokuKubun.Size = new System.Drawing.Size(360, 28);
            this.txtJigyouKamokuKubun.TabIndex = 6;
            this.txtJigyouKamokuKubun.Tag = "jigyou_kamoku_kubun";
            // 
            // txtKamoku
            // 
            this.txtKamoku.BackColor = System.Drawing.SystemColors.Window;
            this.txtKamoku.Location = new System.Drawing.Point(15, 105);
            this.txtKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKamoku.Name = "txtKamoku";
            this.txtKamoku.Size = new System.Drawing.Size(360, 28);
            this.txtKamoku.TabIndex = 4;
            this.txtKamoku.Tag = "kamoku";
            // 
            // txtKamokuCode
            // 
            this.txtKamokuCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtKamokuCode.Location = new System.Drawing.Point(15, 40);
            this.txtKamokuCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKamokuCode.Name = "txtKamokuCode";
            this.txtKamokuCode.Size = new System.Drawing.Size(134, 28);
            this.txtKamokuCode.TabIndex = 0;
            this.txtKamokuCode.Tag = "kamoku_code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "科目名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "コード";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "事業活動区分名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "貸借区分名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(759, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "資金収支区分名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "貸借区分";
            // 
            // cmbTaisyaku
            // 
            this.cmbTaisyaku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaisyaku.FormattingEnabled = true;
            this.cmbTaisyaku.Location = new System.Drawing.Point(163, 40);
            this.cmbTaisyaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbTaisyaku.Name = "cmbTaisyaku";
            this.cmbTaisyaku.Size = new System.Drawing.Size(132, 29);
            this.cmbTaisyaku.TabIndex = 1;
            this.cmbTaisyaku.Tag = "taisyaku_kubun_id";
            // 
            // chkUsable
            // 
            this.chkUsable.AutoSize = true;
            this.chkUsable.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkUsable.Location = new System.Drawing.Point(310, 14);
            this.chkUsable.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkUsable.Name = "chkUsable";
            this.chkUsable.Size = new System.Drawing.Size(77, 46);
            this.chkUsable.TabIndex = 2;
            this.chkUsable.Tag = "usable";
            this.chkUsable.Text = "使用可";
            this.chkUsable.UseVisualStyleBackColor = true;
            // 
            // chkPrintTarget
            // 
            this.chkPrintTarget.AutoSize = true;
            this.chkPrintTarget.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkPrintTarget.Location = new System.Drawing.Point(403, 14);
            this.chkPrintTarget.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkPrintTarget.Name = "chkPrintTarget";
            this.chkPrintTarget.Size = new System.Drawing.Size(182, 46);
            this.chkPrintTarget.TabIndex = 3;
            this.chkPrintTarget.Tag = "denpyou_print_target";
            this.chkPrintTarget.Text = "仕訳伝票印刷対象";
            this.chkPrintTarget.UseVisualStyleBackColor = true;
            // 
            // txtKamokuYomi
            // 
            this.txtKamokuYomi.Location = new System.Drawing.Point(389, 105);
            this.txtKamokuYomi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKamokuYomi.Name = "txtKamokuYomi";
            this.txtKamokuYomi.Size = new System.Drawing.Size(360, 28);
            this.txtKamokuYomi.TabIndex = 5;
            this.txtKamokuYomi.Tag = "kamoku_yomi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "科目名よみ";
            // 
            // lblNotEditable
            // 
            this.lblNotEditable.AutoSize = true;
            this.lblNotEditable.BackColor = System.Drawing.SystemColors.Window;
            this.lblNotEditable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNotEditable.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.lblNotEditable.ForeColor = System.Drawing.Color.Red;
            this.lblNotEditable.Location = new System.Drawing.Point(853, 28);
            this.lblNotEditable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNotEditable.Name = "lblNotEditable";
            this.lblNotEditable.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblNotEditable.Size = new System.Drawing.Size(108, 33);
            this.lblNotEditable.TabIndex = 23;
            this.lblNotEditable.Text = "変更不可";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 208);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "大区分(事業活動)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(389, 208);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 21);
            this.label10.TabIndex = 26;
            this.label10.Text = "大区分(貸借区分)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(759, 208);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "大区分(資金収支区分)";
            // 
            // txtParentJigyou
            // 
            this.txtParentJigyou.BackColor = System.Drawing.SystemColors.Window;
            this.txtParentJigyou.Enabled = false;
            this.txtParentJigyou.Location = new System.Drawing.Point(15, 234);
            this.txtParentJigyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtParentJigyou.Name = "txtParentJigyou";
            this.txtParentJigyou.Size = new System.Drawing.Size(360, 28);
            this.txtParentJigyou.TabIndex = 9;
            this.txtParentJigyou.Tag = "parent_jigyou_kamoku_kubun";
            // 
            // txtParentTaisyaku
            // 
            this.txtParentTaisyaku.BackColor = System.Drawing.SystemColors.Window;
            this.txtParentTaisyaku.Enabled = false;
            this.txtParentTaisyaku.Location = new System.Drawing.Point(389, 234);
            this.txtParentTaisyaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtParentTaisyaku.Name = "txtParentTaisyaku";
            this.txtParentTaisyaku.Size = new System.Drawing.Size(360, 28);
            this.txtParentTaisyaku.TabIndex = 10;
            this.txtParentTaisyaku.Tag = "parent_taisyaku_kamoku_kubun";
            // 
            // txtParentShikin
            // 
            this.txtParentShikin.BackColor = System.Drawing.SystemColors.Window;
            this.txtParentShikin.Enabled = false;
            this.txtParentShikin.Location = new System.Drawing.Point(763, 234);
            this.txtParentShikin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtParentShikin.Name = "txtParentShikin";
            this.txtParentShikin.Size = new System.Drawing.Size(360, 28);
            this.txtParentShikin.TabIndex = 11;
            this.txtParentShikin.Tag = "parent_shikin_kamoku_kubun";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(975, 21);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 46);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // KanjouKamokuDetailRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtParentShikin);
            this.Controls.Add(this.txtParentTaisyaku);
            this.Controls.Add(this.txtParentJigyou);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNotEditable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKamokuYomi);
            this.Controls.Add(this.chkPrintTarget);
            this.Controls.Add(this.chkUsable);
            this.Controls.Add(this.cmbTaisyaku);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShikinKamokuKubun);
            this.Controls.Add(this.txtTaisyakuKamokuKubun);
            this.Controls.Add(this.txtJigyouKamokuKubun);
            this.Controls.Add(this.txtKamoku);
            this.Controls.Add(this.txtKamokuCode);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "KanjouKamokuDetailRow";
            this.Size = new System.Drawing.Size(1142, 290);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShikinKamokuKubun;
        private System.Windows.Forms.TextBox txtTaisyakuKamokuKubun;
        private System.Windows.Forms.TextBox txtJigyouKamokuKubun;
        private System.Windows.Forms.TextBox txtKamoku;
        private System.Windows.Forms.TextBox txtKamokuCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private controls.MTComboBox cmbTaisyaku;
        private System.Windows.Forms.CheckBox chkUsable;
        private System.Windows.Forms.CheckBox chkPrintTarget;
        private controls.YomiTextBox txtKamokuYomi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNotEditable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtParentJigyou;
        private System.Windows.Forms.TextBox txtParentTaisyaku;
        private System.Windows.Forms.TextBox txtParentShikin;
        private System.Windows.Forms.Button btnDelete;



    }
}
