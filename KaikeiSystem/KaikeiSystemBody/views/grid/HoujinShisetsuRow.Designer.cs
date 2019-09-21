namespace KaikeiSystemBody.views.grid
{
    partial class HoujinShisetsuRow
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
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.panelLine = new System.Windows.Forms.Panel();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtShisetsuMeisyou = new System.Windows.Forms.TextBox();
            this.txtRyakusyou = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtFAX = new System.Windows.Forms.TextBox();
            this.txtDaihyousyaShimei = new System.Windows.Forms.TextBox();
            this.txtYuubinBangou = new System.Windows.Forms.TextBox();
            this.txtTodouhuken = new System.Windows.Forms.TextBox();
            this.txtShiKuGun = new System.Windows.Forms.TextBox();
            this.txtChouSonIki = new System.Windows.Forms.TextBox();
            this.txtBanchiTatemonomei = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.amountGenkaSyoukyaku = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.cmbParentKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.SuspendLayout();
            // 
            // panelLine1
            // 
            this.panelLine1.BackColor = System.Drawing.Color.Black;
            this.panelLine1.Enabled = false;
            this.panelLine1.Location = new System.Drawing.Point(33, 0);
            this.panelLine1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(2, 105);
            this.panelLine1.TabIndex = 0;
            // 
            // panelLine
            // 
            this.panelLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLine.BackColor = System.Drawing.Color.Black;
            this.panelLine.Enabled = false;
            this.panelLine.Location = new System.Drawing.Point(0, 93);
            this.panelLine.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(1410, 2);
            this.panelLine.TabIndex = 24;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(33, -2);
            this.txtCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(119, 28);
            this.txtCode.TabIndex = 0;
            this.txtCode.Tag = "kubun_code";
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtShisetsuMeisyou
            // 
            this.txtShisetsuMeisyou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShisetsuMeisyou.Location = new System.Drawing.Point(152, -2);
            this.txtShisetsuMeisyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtShisetsuMeisyou.Name = "txtShisetsuMeisyou";
            this.txtShisetsuMeisyou.Size = new System.Drawing.Size(336, 28);
            this.txtShisetsuMeisyou.TabIndex = 1;
            this.txtShisetsuMeisyou.Tag = "name";
            // 
            // txtRyakusyou
            // 
            this.txtRyakusyou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRyakusyou.Location = new System.Drawing.Point(488, -2);
            this.txtRyakusyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRyakusyou.Name = "txtRyakusyou";
            this.txtRyakusyou.Size = new System.Drawing.Size(229, 28);
            this.txtRyakusyou.TabIndex = 2;
            this.txtRyakusyou.Tag = "ryakusyou";
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Location = new System.Drawing.Point(717, -2);
            this.txtTel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(178, 28);
            this.txtTel.TabIndex = 3;
            this.txtTel.Tag = "denwa_bangou";
            // 
            // txtFAX
            // 
            this.txtFAX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFAX.Location = new System.Drawing.Point(895, -2);
            this.txtFAX.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFAX.Name = "txtFAX";
            this.txtFAX.Size = new System.Drawing.Size(178, 28);
            this.txtFAX.TabIndex = 4;
            this.txtFAX.Tag = "fax_bangou";
            // 
            // txtDaihyousyaShimei
            // 
            this.txtDaihyousyaShimei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDaihyousyaShimei.Location = new System.Drawing.Point(1073, -2);
            this.txtDaihyousyaShimei.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDaihyousyaShimei.Name = "txtDaihyousyaShimei";
            this.txtDaihyousyaShimei.Size = new System.Drawing.Size(231, 28);
            this.txtDaihyousyaShimei.TabIndex = 5;
            this.txtDaihyousyaShimei.Tag = "daihyousya_shimei";
            // 
            // txtYuubinBangou
            // 
            this.txtYuubinBangou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYuubinBangou.Location = new System.Drawing.Point(33, 30);
            this.txtYuubinBangou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtYuubinBangou.Name = "txtYuubinBangou";
            this.txtYuubinBangou.Size = new System.Drawing.Size(132, 28);
            this.txtYuubinBangou.TabIndex = 6;
            this.txtYuubinBangou.Tag = "yuubin_bangou";
            // 
            // txtTodouhuken
            // 
            this.txtTodouhuken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTodouhuken.Location = new System.Drawing.Point(165, 30);
            this.txtTodouhuken.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTodouhuken.Name = "txtTodouhuken";
            this.txtTodouhuken.Size = new System.Drawing.Size(156, 28);
            this.txtTodouhuken.TabIndex = 7;
            this.txtTodouhuken.Tag = "todouhuken";
            // 
            // txtShiKuGun
            // 
            this.txtShiKuGun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShiKuGun.Location = new System.Drawing.Point(321, 30);
            this.txtShiKuGun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtShiKuGun.Name = "txtShiKuGun";
            this.txtShiKuGun.Size = new System.Drawing.Size(217, 28);
            this.txtShiKuGun.TabIndex = 8;
            this.txtShiKuGun.Tag = "si_ku_gun";
            // 
            // txtChouSonIki
            // 
            this.txtChouSonIki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChouSonIki.Location = new System.Drawing.Point(537, 30);
            this.txtChouSonIki.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtChouSonIki.Name = "txtChouSonIki";
            this.txtChouSonIki.Size = new System.Drawing.Size(308, 28);
            this.txtChouSonIki.TabIndex = 9;
            this.txtChouSonIki.Tag = "tyou_son_iki";
            // 
            // txtBanchiTatemonomei
            // 
            this.txtBanchiTatemonomei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBanchiTatemonomei.Location = new System.Drawing.Point(845, 30);
            this.txtBanchiTatemonomei.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBanchiTatemonomei.Name = "txtBanchiTatemonomei";
            this.txtBanchiTatemonomei.Size = new System.Drawing.Size(459, 28);
            this.txtBanchiTatemonomei.TabIndex = 10;
            this.txtBanchiTatemonomei.Tag = "tatemono_mei";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(1316, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 56);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // amountGenkaSyoukyaku
            // 
            this.amountGenkaSyoukyaku.Amount = ((long)(0));
            this.amountGenkaSyoukyaku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountGenkaSyoukyaku.Location = new System.Drawing.Point(33, 61);
            this.amountGenkaSyoukyaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountGenkaSyoukyaku.Name = "amountGenkaSyoukyaku";
            this.amountGenkaSyoukyaku.Size = new System.Drawing.Size(207, 28);
            this.amountGenkaSyoukyaku.TabIndex = 11;
            this.amountGenkaSyoukyaku.Tag = "genka_syoukyaku_ruikei_gaku";
            this.amountGenkaSyoukyaku.Text = "\\0";
            this.amountGenkaSyoukyaku.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbParentKaikeiKubun
            // 
            this.cmbParentKaikeiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbParentKaikeiKubun.FormattingEnabled = true;
            this.cmbParentKaikeiKubun.Location = new System.Drawing.Point(240, 61);
            this.cmbParentKaikeiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbParentKaikeiKubun.Name = "cmbParentKaikeiKubun";
            this.cmbParentKaikeiKubun.Size = new System.Drawing.Size(475, 29);
            this.cmbParentKaikeiKubun.TabIndex = 12;
            this.cmbParentKaikeiKubun.Tag = "parent_id";
            // 
            // HoujinShisetsuRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.amountGenkaSyoukyaku);
            this.Controls.Add(this.txtBanchiTatemonomei);
            this.Controls.Add(this.txtChouSonIki);
            this.Controls.Add(this.txtShiKuGun);
            this.Controls.Add(this.txtTodouhuken);
            this.Controls.Add(this.txtYuubinBangou);
            this.Controls.Add(this.txtDaihyousyaShimei);
            this.Controls.Add(this.txtFAX);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtRyakusyou);
            this.Controls.Add(this.txtShisetsuMeisyou);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.panelLine1);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.cmbParentKaikeiKubun);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "HoujinShisetsuRow";
            this.Size = new System.Drawing.Size(1410, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtShisetsuMeisyou;
        private System.Windows.Forms.TextBox txtRyakusyou;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtFAX;
        private System.Windows.Forms.TextBox txtDaihyousyaShimei;
        private controls.MTComboBox cmbParentKaikeiKubun;
        private System.Windows.Forms.TextBox txtYuubinBangou;
        private System.Windows.Forms.TextBox txtTodouhuken;
        private System.Windows.Forms.TextBox txtShiKuGun;
        private System.Windows.Forms.TextBox txtChouSonIki;
        private System.Windows.Forms.TextBox txtBanchiTatemonomei;
        private controls.AmountTextBox amountGenkaSyoukyaku;
        private System.Windows.Forms.Button btnDelete;
    }
}
