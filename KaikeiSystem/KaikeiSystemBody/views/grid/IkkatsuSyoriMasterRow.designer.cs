namespace KaikeiSystemBody.views.grid
{
    partial class IkkatsuSyoriMasterRow
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
            this.amountKingaku = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkTouroku = new System.Windows.Forms.CheckBox();
            this.cmbTorihikiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.cmbKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.txtKashikataHojoSeiri = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblKashikataHojo = new System.Windows.Forms.Label();
            this.lblKarikataHojo = new System.Windows.Forms.Label();
            this.txtKarikataHojoSeiri = new System.Windows.Forms.TextBox();
            this.txtTekiyou = new System.Windows.Forms.TextBox();
            this.lblKashikataKamoku = new System.Windows.Forms.Label();
            this.txtKashikataKamokuCode = new System.Windows.Forms.TextBox();
            this.lblKarikataKamoku = new System.Windows.Forms.Label();
            this.txtKarikataKamokuCode = new System.Windows.Forms.TextBox();
            this.txtTsuikaKubun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // amountKingaku
            // 
            this.amountKingaku.Amount = ((long)(0));
            this.amountKingaku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountKingaku.Location = new System.Drawing.Point(1283, 10);
            this.amountKingaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountKingaku.Name = "amountKingaku";
            this.amountKingaku.Size = new System.Drawing.Size(162, 33);
            this.amountKingaku.TabIndex = 12;
            this.amountKingaku.Tag = "karikata_kingaku";
            this.amountKingaku.Text = "\\0";
            this.amountKingaku.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(1685, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 49);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "削除(&D)";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // chkTouroku
            // 
            this.chkTouroku.AutoSize = true;
            this.chkTouroku.Location = new System.Drawing.Point(1566, 19);
            this.chkTouroku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkTouroku.Name = "chkTouroku";
            this.chkTouroku.Size = new System.Drawing.Size(22, 21);
            this.chkTouroku.TabIndex = 15;
            this.chkTouroku.TabStop = false;
            this.chkTouroku.Tag = "touroku";
            this.chkTouroku.UseVisualStyleBackColor = true;
            // 
            // cmbTorihikiKubun
            // 
            this.cmbTorihikiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTorihikiKubun.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbTorihikiKubun.FormattingEnabled = true;
            this.cmbTorihikiKubun.Location = new System.Drawing.Point(369, 58);
            this.cmbTorihikiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbTorihikiKubun.Name = "cmbTorihikiKubun";
            this.cmbTorihikiKubun.Size = new System.Drawing.Size(162, 34);
            this.cmbTorihikiKubun.TabIndex = 3;
            this.cmbTorihikiKubun.TabStop = false;
            this.cmbTorihikiKubun.Tag = "torihiki_kubun";
            // 
            // cmbKaikeiKubun
            // 
            this.cmbKaikeiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKaikeiKubun.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKaikeiKubun.FormattingEnabled = true;
            this.cmbKaikeiKubun.Location = new System.Drawing.Point(167, 10);
            this.cmbKaikeiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKaikeiKubun.Name = "cmbKaikeiKubun";
            this.cmbKaikeiKubun.Size = new System.Drawing.Size(363, 34);
            this.cmbKaikeiKubun.TabIndex = 2;
            this.cmbKaikeiKubun.TabStop = false;
            this.cmbKaikeiKubun.Tag = "kaikei_kubun";
            // 
            // txtKashikataHojoSeiri
            // 
            this.txtKashikataHojoSeiri.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKashikataHojoSeiri.Location = new System.Drawing.Point(909, 58);
            this.txtKashikataHojoSeiri.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKashikataHojoSeiri.Name = "txtKashikataHojoSeiri";
            this.txtKashikataHojoSeiri.Size = new System.Drawing.Size(81, 33);
            this.txtKashikataHojoSeiri.TabIndex = 9;
            this.txtKashikataHojoSeiri.Tag = "kashikata_hojo_seiri";
            this.txtKashikataHojoSeiri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtComment.Location = new System.Drawing.Point(1454, 58);
            this.txtComment.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(363, 33);
            this.txtComment.TabIndex = 14;
            this.txtComment.Tag = "comment";
            // 
            // lblKashikataHojo
            // 
            this.lblKashikataHojo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKashikataHojo.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKashikataHojo.Location = new System.Drawing.Point(1001, 61);
            this.lblKashikataHojo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKashikataHojo.Name = "lblKashikataHojo";
            this.lblKashikataHojo.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblKashikataHojo.Size = new System.Drawing.Size(275, 35);
            this.lblKashikataHojo.TabIndex = 11;
            // 
            // lblKarikataHojo
            // 
            this.lblKarikataHojo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKarikataHojo.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKarikataHojo.Location = new System.Drawing.Point(631, 61);
            this.lblKarikataHojo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKarikataHojo.Name = "lblKarikataHojo";
            this.lblKarikataHojo.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblKarikataHojo.Size = new System.Drawing.Size(271, 35);
            this.lblKarikataHojo.TabIndex = 7;
            // 
            // txtKarikataHojoSeiri
            // 
            this.txtKarikataHojoSeiri.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKarikataHojoSeiri.Location = new System.Drawing.Point(539, 58);
            this.txtKarikataHojoSeiri.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKarikataHojoSeiri.Name = "txtKarikataHojoSeiri";
            this.txtKarikataHojoSeiri.Size = new System.Drawing.Size(81, 33);
            this.txtKarikataHojoSeiri.TabIndex = 5;
            this.txtKarikataHojoSeiri.Tag = "karikata_hojo_seiri";
            this.txtKarikataHojoSeiri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTekiyou
            // 
            this.txtTekiyou.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTekiyou.Location = new System.Drawing.Point(1454, 10);
            this.txtTekiyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTekiyou.Name = "txtTekiyou";
            this.txtTekiyou.Size = new System.Drawing.Size(76, 34);
            this.txtTekiyou.TabIndex = 13;
            this.txtTekiyou.Tag = "tekiyou_id";
            // 
            // lblKashikataKamoku
            // 
            this.lblKashikataKamoku.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKashikataKamoku.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKashikataKamoku.Location = new System.Drawing.Point(1001, 14);
            this.lblKashikataKamoku.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKashikataKamoku.Name = "lblKashikataKamoku";
            this.lblKashikataKamoku.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblKashikataKamoku.Size = new System.Drawing.Size(275, 35);
            this.lblKashikataKamoku.TabIndex = 10;
            // 
            // txtKashikataKamokuCode
            // 
            this.txtKashikataKamokuCode.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKashikataKamokuCode.Location = new System.Drawing.Point(909, 10);
            this.txtKashikataKamokuCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKashikataKamokuCode.Name = "txtKashikataKamokuCode";
            this.txtKashikataKamokuCode.Size = new System.Drawing.Size(81, 33);
            this.txtKashikataKamokuCode.TabIndex = 8;
            this.txtKashikataKamokuCode.Tag = "kashikata_kamoku_code";
            // 
            // lblKarikataKamoku
            // 
            this.lblKarikataKamoku.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKarikataKamoku.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKarikataKamoku.Location = new System.Drawing.Point(631, 14);
            this.lblKarikataKamoku.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKarikataKamoku.Name = "lblKarikataKamoku";
            this.lblKarikataKamoku.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblKarikataKamoku.Size = new System.Drawing.Size(271, 35);
            this.lblKarikataKamoku.TabIndex = 6;
            // 
            // txtKarikataKamokuCode
            // 
            this.txtKarikataKamokuCode.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKarikataKamokuCode.Location = new System.Drawing.Point(539, 10);
            this.txtKarikataKamokuCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKarikataKamokuCode.Name = "txtKarikataKamokuCode";
            this.txtKarikataKamokuCode.Size = new System.Drawing.Size(81, 33);
            this.txtKarikataKamokuCode.TabIndex = 4;
            this.txtKarikataKamokuCode.Tag = "karikata_kamoku_code";
            // 
            // txtTsuikaKubun
            // 
            this.txtTsuikaKubun.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTsuikaKubun.Location = new System.Drawing.Point(39, 10);
            this.txtTsuikaKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTsuikaKubun.Name = "txtTsuikaKubun";
            this.txtTsuikaKubun.Size = new System.Drawing.Size(114, 33);
            this.txtTsuikaKubun.TabIndex = 0;
            this.txtTsuikaKubun.TabStop = false;
            this.txtTsuikaKubun.Tag = "tsuika_kubun";
            // 
            // IkkatsuSyoriMasterRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.amountKingaku);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chkTouroku);
            this.Controls.Add(this.cmbTorihikiKubun);
            this.Controls.Add(this.cmbKaikeiKubun);
            this.Controls.Add(this.txtKashikataHojoSeiri);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblKashikataHojo);
            this.Controls.Add(this.lblKarikataHojo);
            this.Controls.Add(this.txtKarikataHojoSeiri);
            this.Controls.Add(this.txtTekiyou);
            this.Controls.Add(this.lblKashikataKamoku);
            this.Controls.Add(this.txtKashikataKamokuCode);
            this.Controls.Add(this.lblKarikataKamoku);
            this.Controls.Add(this.txtKarikataKamokuCode);
            this.Controls.Add(this.txtTsuikaKubun);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "IkkatsuSyoriMasterRow";
            this.Size = new System.Drawing.Size(1833, 108);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTsuikaKubun;
        private System.Windows.Forms.TextBox txtKarikataKamokuCode;
        private System.Windows.Forms.Label lblKarikataKamoku;
        private System.Windows.Forms.TextBox txtKashikataKamokuCode;
        private System.Windows.Forms.Label lblKashikataKamoku;
        private System.Windows.Forms.TextBox txtTekiyou;
        private System.Windows.Forms.TextBox txtKarikataHojoSeiri;
        private System.Windows.Forms.Label lblKarikataHojo;
        private System.Windows.Forms.TextBox txtKashikataHojoSeiri;
        private System.Windows.Forms.Label lblKashikataHojo;
        private System.Windows.Forms.TextBox txtComment;
        private controls.MTComboBox cmbKaikeiKubun;
        private controls.MTComboBox cmbTorihikiKubun;
        private System.Windows.Forms.CheckBox chkTouroku;
        private System.Windows.Forms.Button btnDelete;
        private controls.AmountTextBox amountKingaku;
    }
}
