namespace KaikeiSystemBody.views.grid
{
    partial class KaikeiDenpyouRow
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
            this.components = new System.ComponentModel.Container();
            this.cmbTorihikiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.cmbKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.lblUpdateDate = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtKashikataHojoSeiri = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtKarikataHojoSeiri = new System.Windows.Forms.TextBox();
            this.chkDenpyouKakunin = new System.Windows.Forms.CheckBox();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.chkKessanSyuuryou = new System.Windows.Forms.CheckBox();
            this.txtTekiyou = new System.Windows.Forms.TextBox();
            this.txtKingaku = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.txtKashikataKamokuCode = new System.Windows.Forms.TextBox();
            this.txtKarikataKamokuCode = new System.Windows.Forms.TextBox();
            this.txtKihyoubiDay = new System.Windows.Forms.TextBox();
            this.txtKihyoubiMonth = new System.Windows.Forms.TextBox();
            this.txtKihyoubiYear = new System.Windows.Forms.TextBox();
            this.txtKihyoubiGengou = new System.Windows.Forms.TextBox();
            this.txtDenpyouBangou = new System.Windows.Forms.TextBox();
            this.lblKarikataKamoku = new KaikeiSystemBody.views.controls.AutoSizeLabel(this.components);
            this.lblKarikataHojo = new KaikeiSystemBody.views.controls.AutoSizeLabel(this.components);
            this.lblKashikataKamoku = new KaikeiSystemBody.views.controls.AutoSizeLabel(this.components);
            this.lblKashikataHojo = new KaikeiSystemBody.views.controls.AutoSizeLabel(this.components);
            this.SuspendLayout();
            // 
            // cmbTorihikiKubun
            // 
            this.cmbTorihikiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTorihikiKubun.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbTorihikiKubun.FormattingEnabled = true;
            this.cmbTorihikiKubun.Location = new System.Drawing.Point(433, 46);
            this.cmbTorihikiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbTorihikiKubun.Name = "cmbTorihikiKubun";
            this.cmbTorihikiKubun.Size = new System.Drawing.Size(98, 34);
            this.cmbTorihikiKubun.TabIndex = 16;
            this.cmbTorihikiKubun.TabStop = false;
            this.cmbTorihikiKubun.Tag = "torihiki_kubun";
            // 
            // cmbKaikeiKubun
            // 
            this.cmbKaikeiKubun.AutoFontSize = true;
            this.cmbKaikeiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKaikeiKubun.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKaikeiKubun.FormattingEnabled = true;
            this.cmbKaikeiKubun.Location = new System.Drawing.Point(90, 46);
            this.cmbKaikeiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKaikeiKubun.Name = "cmbKaikeiKubun";
            this.cmbKaikeiKubun.Size = new System.Drawing.Size(329, 34);
            this.cmbKaikeiKubun.TabIndex = 15;
            this.cmbKaikeiKubun.TabStop = false;
            this.cmbKaikeiKubun.Tag = "kaikei_kubun";
            // 
            // lblUpdateDate
            // 
            this.lblUpdateDate.BackColor = System.Drawing.Color.Silver;
            this.lblUpdateDate.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblUpdateDate.Location = new System.Drawing.Point(1553, 5);
            this.lblUpdateDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUpdateDate.Name = "lblUpdateDate";
            this.lblUpdateDate.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblUpdateDate.Size = new System.Drawing.Size(145, 35);
            this.lblUpdateDate.TabIndex = 28;
            this.lblUpdateDate.Tag = "";
            this.lblUpdateDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUpdateDate.Visible = false;
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.BackColor = System.Drawing.Color.Silver;
            this.lblCreateDate.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCreateDate.Location = new System.Drawing.Point(1553, 5);
            this.lblCreateDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblCreateDate.Size = new System.Drawing.Size(145, 35);
            this.lblCreateDate.TabIndex = 27;
            this.lblCreateDate.Tag = "";
            this.lblCreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCreateDate.Visible = false;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.SystemColors.Control;
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblId.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblId.Location = new System.Drawing.Point(1304, 49);
            this.lblId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblId.Name = "lblId";
            this.lblId.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblId.Size = new System.Drawing.Size(165, 34);
            this.lblId.TabIndex = 26;
            this.lblId.Tag = "";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblId.Visible = false;
            // 
            // txtKashikataHojoSeiri
            // 
            this.txtKashikataHojoSeiri.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKashikataHojoSeiri.Location = new System.Drawing.Point(917, 47);
            this.txtKashikataHojoSeiri.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKashikataHojoSeiri.Name = "txtKashikataHojoSeiri";
            this.txtKashikataHojoSeiri.Size = new System.Drawing.Size(92, 33);
            this.txtKashikataHojoSeiri.TabIndex = 7;
            this.txtKashikataHojoSeiri.Tag = "kashikata_hojo_seiri";
            this.txtKashikataHojoSeiri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtComment.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtComment.Location = new System.Drawing.Point(1480, 46);
            this.txtComment.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(356, 33);
            this.txtComment.TabIndex = 10;
            this.txtComment.Tag = "comment";
            // 
            // txtKarikataHojoSeiri
            // 
            this.txtKarikataHojoSeiri.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKarikataHojoSeiri.Location = new System.Drawing.Point(541, 46);
            this.txtKarikataHojoSeiri.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKarikataHojoSeiri.Name = "txtKarikataHojoSeiri";
            this.txtKarikataHojoSeiri.Size = new System.Drawing.Size(87, 33);
            this.txtKarikataHojoSeiri.TabIndex = 5;
            this.txtKarikataHojoSeiri.Tag = "karikata_hojo_seiri";
            this.txtKarikataHojoSeiri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkDenpyouKakunin
            // 
            this.chkDenpyouKakunin.AutoSize = true;
            this.chkDenpyouKakunin.Location = new System.Drawing.Point(48, 54);
            this.chkDenpyouKakunin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkDenpyouKakunin.Name = "chkDenpyouKakunin";
            this.chkDenpyouKakunin.Size = new System.Drawing.Size(22, 21);
            this.chkDenpyouKakunin.TabIndex = 14;
            this.chkDenpyouKakunin.TabStop = false;
            this.chkDenpyouKakunin.Tag = "denpyou_kakunin";
            this.chkDenpyouKakunin.UseVisualStyleBackColor = true;
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveRow.Location = new System.Drawing.Point(1701, 2);
            this.btnRemoveRow.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(138, 40);
            this.btnRemoveRow.TabIndex = 12;
            this.btnRemoveRow.TabStop = false;
            this.btnRemoveRow.Text = "行削除(&D)";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            // 
            // chkKessanSyuuryou
            // 
            this.chkKessanSyuuryou.AutoSize = true;
            this.chkKessanSyuuryou.Location = new System.Drawing.Point(1558, 9);
            this.chkKessanSyuuryou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkKessanSyuuryou.Name = "chkKessanSyuuryou";
            this.chkKessanSyuuryou.Size = new System.Drawing.Size(120, 25);
            this.chkKessanSyuuryou.TabIndex = 11;
            this.chkKessanSyuuryou.Tag = "kessan_syuuryou";
            this.chkKessanSyuuryou.Text = "決算終了";
            this.chkKessanSyuuryou.UseVisualStyleBackColor = true;
            // 
            // txtTekiyou
            // 
            this.txtTekiyou.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTekiyou.Location = new System.Drawing.Point(1480, 4);
            this.txtTekiyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTekiyou.Name = "txtTekiyou";
            this.txtTekiyou.Size = new System.Drawing.Size(66, 34);
            this.txtTekiyou.TabIndex = 9;
            this.txtTekiyou.Tag = "tekiyou_id";
            // 
            // txtKingaku
            // 
            this.txtKingaku.Amount = ((long)(0));
            this.txtKingaku.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKingaku.Location = new System.Drawing.Point(1304, 4);
            this.txtKingaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKingaku.Name = "txtKingaku";
            this.txtKingaku.Size = new System.Drawing.Size(164, 34);
            this.txtKingaku.TabIndex = 8;
            this.txtKingaku.Tag = "karikata_kingaku";
            this.txtKingaku.Text = "\\0";
            this.txtKingaku.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKashikataKamokuCode
            // 
            this.txtKashikataKamokuCode.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKashikataKamokuCode.Location = new System.Drawing.Point(917, 4);
            this.txtKashikataKamokuCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKashikataKamokuCode.Name = "txtKashikataKamokuCode";
            this.txtKashikataKamokuCode.Size = new System.Drawing.Size(92, 33);
            this.txtKashikataKamokuCode.TabIndex = 6;
            this.txtKashikataKamokuCode.Tag = "kashikata_kamoku_code";
            // 
            // txtKarikataKamokuCode
            // 
            this.txtKarikataKamokuCode.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKarikataKamokuCode.Location = new System.Drawing.Point(541, 4);
            this.txtKarikataKamokuCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKarikataKamokuCode.Name = "txtKarikataKamokuCode";
            this.txtKarikataKamokuCode.Size = new System.Drawing.Size(87, 33);
            this.txtKarikataKamokuCode.TabIndex = 4;
            this.txtKarikataKamokuCode.Tag = "karikata_kamoku_code";
            // 
            // txtKihyoubiDay
            // 
            this.txtKihyoubiDay.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKihyoubiDay.Location = new System.Drawing.Point(469, 4);
            this.txtKihyoubiDay.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKihyoubiDay.Name = "txtKihyoubiDay";
            this.txtKihyoubiDay.Size = new System.Drawing.Size(61, 33);
            this.txtKihyoubiDay.TabIndex = 3;
            this.txtKihyoubiDay.Tag = "kihyoubi_day";
            this.txtKihyoubiDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKihyoubiMonth
            // 
            this.txtKihyoubiMonth.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKihyoubiMonth.Location = new System.Drawing.Point(400, 4);
            this.txtKihyoubiMonth.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKihyoubiMonth.Name = "txtKihyoubiMonth";
            this.txtKihyoubiMonth.Size = new System.Drawing.Size(61, 33);
            this.txtKihyoubiMonth.TabIndex = 2;
            this.txtKihyoubiMonth.Tag = "kihyoubi_month";
            this.txtKihyoubiMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKihyoubiYear
            // 
            this.txtKihyoubiYear.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKihyoubiYear.Location = new System.Drawing.Point(330, 4);
            this.txtKihyoubiYear.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKihyoubiYear.Name = "txtKihyoubiYear";
            this.txtKihyoubiYear.Size = new System.Drawing.Size(61, 33);
            this.txtKihyoubiYear.TabIndex = 1;
            this.txtKihyoubiYear.Tag = "kihyoubi_year";
            this.txtKihyoubiYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKihyoubiGengou
            // 
            this.txtKihyoubiGengou.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKihyoubiGengou.Location = new System.Drawing.Point(260, 4);
            this.txtKihyoubiGengou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKihyoubiGengou.Name = "txtKihyoubiGengou";
            this.txtKihyoubiGengou.Size = new System.Drawing.Size(61, 33);
            this.txtKihyoubiGengou.TabIndex = 0;
            this.txtKihyoubiGengou.Tag = "kihyoubi_gengou";
            this.txtKihyoubiGengou.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDenpyouBangou
            // 
            this.txtDenpyouBangou.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtDenpyouBangou.Location = new System.Drawing.Point(37, 4);
            this.txtDenpyouBangou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDenpyouBangou.Name = "txtDenpyouBangou";
            this.txtDenpyouBangou.Size = new System.Drawing.Size(209, 33);
            this.txtDenpyouBangou.TabIndex = 18;
            this.txtDenpyouBangou.TabStop = false;
            this.txtDenpyouBangou.Tag = "denpyou_bangou_cache";
            // 
            // lblKarikataKamoku
            // 
            this.lblKarikataKamoku.AutoFontSize = true;
            this.lblKarikataKamoku.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKarikataKamoku.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.lblKarikataKamoku.Location = new System.Drawing.Point(636, 5);
            this.lblKarikataKamoku.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKarikataKamoku.MinFontSize = 8;
            this.lblKarikataKamoku.Name = "lblKarikataKamoku";
            this.lblKarikataKamoku.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblKarikataKamoku.Size = new System.Drawing.Size(275, 35);
            this.lblKarikataKamoku.TabIndex = 21;
            // 
            // lblKarikataHojo
            // 
            this.lblKarikataHojo.AutoFontSize = true;
            this.lblKarikataHojo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKarikataHojo.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.lblKarikataHojo.Location = new System.Drawing.Point(636, 47);
            this.lblKarikataHojo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKarikataHojo.MinFontSize = 8;
            this.lblKarikataHojo.Name = "lblKarikataHojo";
            this.lblKarikataHojo.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblKarikataHojo.Size = new System.Drawing.Size(275, 35);
            this.lblKarikataHojo.TabIndex = 20;
            // 
            // lblKashikataKamoku
            // 
            this.lblKashikataKamoku.AutoFontSize = true;
            this.lblKashikataKamoku.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKashikataKamoku.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.lblKashikataKamoku.Location = new System.Drawing.Point(1018, 5);
            this.lblKashikataKamoku.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKashikataKamoku.MinFontSize = 8;
            this.lblKashikataKamoku.Name = "lblKashikataKamoku";
            this.lblKashikataKamoku.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblKashikataKamoku.Size = new System.Drawing.Size(275, 35);
            this.lblKashikataKamoku.TabIndex = 23;
            // 
            // lblKashikataHojo
            // 
            this.lblKashikataHojo.AutoFontSize = true;
            this.lblKashikataHojo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKashikataHojo.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.lblKashikataHojo.Location = new System.Drawing.Point(1018, 47);
            this.lblKashikataHojo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKashikataHojo.MinFontSize = 8;
            this.lblKashikataHojo.Name = "lblKashikataHojo";
            this.lblKashikataHojo.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblKashikataHojo.Size = new System.Drawing.Size(275, 35);
            this.lblKashikataHojo.TabIndex = 22;
            // 
            // KaikeiDenpyouRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.lblKashikataHojo);
            this.Controls.Add(this.lblKashikataKamoku);
            this.Controls.Add(this.lblKarikataHojo);
            this.Controls.Add(this.lblKarikataKamoku);
            this.Controls.Add(this.cmbTorihikiKubun);
            this.Controls.Add(this.cmbKaikeiKubun);
            this.Controls.Add(this.lblUpdateDate);
            this.Controls.Add(this.lblCreateDate);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtKashikataHojoSeiri);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtKarikataHojoSeiri);
            this.Controls.Add(this.chkDenpyouKakunin);
            this.Controls.Add(this.btnRemoveRow);
            this.Controls.Add(this.chkKessanSyuuryou);
            this.Controls.Add(this.txtTekiyou);
            this.Controls.Add(this.txtKingaku);
            this.Controls.Add(this.txtKashikataKamokuCode);
            this.Controls.Add(this.txtKarikataKamokuCode);
            this.Controls.Add(this.txtKihyoubiDay);
            this.Controls.Add(this.txtKihyoubiMonth);
            this.Controls.Add(this.txtKihyoubiYear);
            this.Controls.Add(this.txtKihyoubiGengou);
            this.Controls.Add(this.txtDenpyouBangou);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "KaikeiDenpyouRow";
            this.Size = new System.Drawing.Size(1852, 94);
            this.Click += new System.EventHandler(this.KaikeiDenpyouRow_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDenpyouBangou;
        private System.Windows.Forms.TextBox txtKihyoubiGengou;
        private System.Windows.Forms.TextBox txtKihyoubiYear;
        private System.Windows.Forms.TextBox txtKihyoubiMonth;
        private System.Windows.Forms.TextBox txtKihyoubiDay;
        private System.Windows.Forms.TextBox txtKarikataKamokuCode;
        private System.Windows.Forms.TextBox txtKashikataKamokuCode;
        private views.controls.AmountTextBox txtKingaku;
        private System.Windows.Forms.TextBox txtTekiyou;
        private System.Windows.Forms.CheckBox chkKessanSyuuryou;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.CheckBox chkDenpyouKakunin;
        private System.Windows.Forms.TextBox txtKarikataHojoSeiri;
        private System.Windows.Forms.TextBox txtKashikataHojoSeiri;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.Label lblUpdateDate;
        private controls.MTComboBox cmbKaikeiKubun;
        private controls.MTComboBox cmbTorihikiKubun;
        private controls.AutoSizeLabel lblKarikataKamoku;
        private controls.AutoSizeLabel lblKarikataHojo;
        private controls.AutoSizeLabel lblKashikataKamoku;
        private controls.AutoSizeLabel lblKashikataHojo;
    }
}
