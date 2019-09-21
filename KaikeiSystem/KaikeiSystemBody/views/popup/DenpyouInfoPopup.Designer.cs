namespace KaikeiSystemBody.views.popup
{
    partial class DenpyouInfoPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDenpyouBangou = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKarikataKamoku = new System.Windows.Forms.Label();
            this.lblKarikataHojo = new System.Windows.Forms.Label();
            this.lblKashikataHojo = new System.Windows.Forms.Label();
            this.lblKashikataKamoku = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTekiyouId = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkDenpyouKakunin = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbKashikataHojo = new KaikeiSystemBody.views.controls.MTComboBox();
            this.cmbKashikataKamoku = new KaikeiSystemBody.views.controls.MTComboBox();
            this.cmbKarikataHojo = new KaikeiSystemBody.views.controls.MTComboBox();
            this.cmbKarikataKamoku = new KaikeiSystemBody.views.controls.MTComboBox();
            this.cmbTorihikiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.cmbKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.txtKingaku = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.txtKihyoubiGengou = new System.Windows.Forms.TextBox();
            this.txtKihyoubiYear = new System.Windows.Forms.TextBox();
            this.txtKihyoubiMonth = new System.Windows.Forms.TextBox();
            this.txtKihyoubiDay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "伝票番号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "会計区分";
            // 
            // txtDenpyouBangou
            // 
            this.txtDenpyouBangou.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtDenpyouBangou.Location = new System.Drawing.Point(156, 44);
            this.txtDenpyouBangou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDenpyouBangou.Name = "txtDenpyouBangou";
            this.txtDenpyouBangou.Size = new System.Drawing.Size(198, 33);
            this.txtDenpyouBangou.TabIndex = 0;
            this.txtDenpyouBangou.TabStop = false;
            this.txtDenpyouBangou.Tag = "denpyou_bangou_cache";
            this.txtDenpyouBangou.TextChanged += new System.EventHandler(this.control_Changed);
            this.txtDenpyouBangou.Leave += new System.EventHandler(this.control_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(22, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "取引区分";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(22, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "起票日";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(22, 378);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "科目";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(174, 326);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "借　方";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(22, 429);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "補助科目";
            // 
            // lblKarikataKamoku
            // 
            this.lblKarikataKamoku.BackColor = System.Drawing.Color.White;
            this.lblKarikataKamoku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKarikataKamoku.Location = new System.Drawing.Point(292, 373);
            this.lblKarikataKamoku.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKarikataKamoku.Name = "lblKarikataKamoku";
            this.lblKarikataKamoku.Size = new System.Drawing.Size(358, 35);
            this.lblKarikataKamoku.TabIndex = 15;
            this.lblKarikataKamoku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKarikataHojo
            // 
            this.lblKarikataHojo.BackColor = System.Drawing.Color.White;
            this.lblKarikataHojo.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKarikataHojo.Location = new System.Drawing.Point(292, 424);
            this.lblKarikataHojo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKarikataHojo.Name = "lblKarikataHojo";
            this.lblKarikataHojo.Size = new System.Drawing.Size(358, 35);
            this.lblKarikataHojo.TabIndex = 16;
            this.lblKarikataHojo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKashikataHojo
            // 
            this.lblKashikataHojo.BackColor = System.Drawing.Color.White;
            this.lblKashikataHojo.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKashikataHojo.Location = new System.Drawing.Point(968, 424);
            this.lblKashikataHojo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKashikataHojo.Name = "lblKashikataHojo";
            this.lblKashikataHojo.Size = new System.Drawing.Size(358, 35);
            this.lblKashikataHojo.TabIndex = 23;
            this.lblKashikataHojo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKashikataKamoku
            // 
            this.lblKashikataKamoku.BackColor = System.Drawing.Color.White;
            this.lblKashikataKamoku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKashikataKamoku.Location = new System.Drawing.Point(968, 373);
            this.lblKashikataKamoku.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKashikataKamoku.Name = "lblKashikataKamoku";
            this.lblKashikataKamoku.Size = new System.Drawing.Size(358, 35);
            this.lblKashikataKamoku.TabIndex = 22;
            this.lblKashikataKamoku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(699, 429);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 26);
            this.label11.TabIndex = 21;
            this.label11.Text = "補助科目";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(851, 326);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 26);
            this.label12.TabIndex = 19;
            this.label12.Text = "貸　方";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(699, 378);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 26);
            this.label13.TabIndex = 17;
            this.label13.Text = "科目";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(968, 511);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "金額";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(22, 564);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 26);
            this.label10.TabIndex = 26;
            this.label10.Text = "摘要ID";
            // 
            // txtTekiyouId
            // 
            this.txtTekiyouId.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTekiyouId.Location = new System.Drawing.Point(156, 558);
            this.txtTekiyouId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTekiyouId.Name = "txtTekiyouId";
            this.txtTekiyouId.Size = new System.Drawing.Size(114, 33);
            this.txtTekiyouId.TabIndex = 13;
            this.txtTekiyouId.Tag = "tekiyou_id";
            this.txtTekiyouId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTekiyouId.TextChanged += new System.EventHandler(this.control_Changed);
            this.txtTekiyouId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.txtTekiyouId.Leave += new System.EventHandler(this.control_Leave);
            this.txtTekiyouId.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtComment.Location = new System.Drawing.Point(156, 607);
            this.txtComment.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(1166, 33);
            this.txtComment.TabIndex = 14;
            this.txtComment.Tag = "comment";
            this.txtComment.TextChanged += new System.EventHandler(this.control_Changed);
            this.txtComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.txtComment.Leave += new System.EventHandler(this.control_Leave);
            this.txtComment.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(22, 612);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 26);
            this.label14.TabIndex = 29;
            this.label14.Text = "コメント";
            // 
            // checkDenpyouKakunin
            // 
            this.checkDenpyouKakunin.AutoSize = true;
            this.checkDenpyouKakunin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkDenpyouKakunin.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkDenpyouKakunin.Location = new System.Drawing.Point(22, 662);
            this.checkDenpyouKakunin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkDenpyouKakunin.Name = "checkDenpyouKakunin";
            this.checkDenpyouKakunin.Size = new System.Drawing.Size(142, 30);
            this.checkDenpyouKakunin.TabIndex = 15;
            this.checkDenpyouKakunin.Tag = "denpyou_kakunin";
            this.checkDenpyouKakunin.Text = "伝票確認";
            this.checkDenpyouKakunin.UseVisualStyleBackColor = true;
            this.checkDenpyouKakunin.TextChanged += new System.EventHandler(this.control_Changed);
            this.checkDenpyouKakunin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.checkDenpyouKakunin.Leave += new System.EventHandler(this.control_Leave);
            this.checkDenpyouKakunin.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(999, 21);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 49);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "削除(&D)";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1177, 21);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(167, 49);
            this.btnClose.TabIndex = 17;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "閉じる(&X)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbKashikataHojo
            // 
            this.cmbKashikataHojo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKashikataHojo.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKashikataHojo.FormattingEnabled = true;
            this.cmbKashikataHojo.IntegralHeight = false;
            this.cmbKashikataHojo.Location = new System.Drawing.Point(832, 424);
            this.cmbKashikataHojo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKashikataHojo.Name = "cmbKashikataHojo";
            this.cmbKashikataHojo.Size = new System.Drawing.Size(114, 34);
            this.cmbKashikataHojo.TabIndex = 11;
            this.cmbKashikataHojo.Tag = "kashikata_hojo_seiri";
            this.cmbKashikataHojo.SelectedIndexChanged += new System.EventHandler(this.cmbbox_Changed);
            this.cmbKashikataHojo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.cmbKashikataHojo.Leave += new System.EventHandler(this.control_Leave);
            this.cmbKashikataHojo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // cmbKashikataKamoku
            // 
            this.cmbKashikataKamoku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKashikataKamoku.DropDownHeight = 300;
            this.cmbKashikataKamoku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKashikataKamoku.FormattingEnabled = true;
            this.cmbKashikataKamoku.IntegralHeight = false;
            this.cmbKashikataKamoku.Location = new System.Drawing.Point(832, 373);
            this.cmbKashikataKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKashikataKamoku.Name = "cmbKashikataKamoku";
            this.cmbKashikataKamoku.Size = new System.Drawing.Size(114, 34);
            this.cmbKashikataKamoku.TabIndex = 10;
            this.cmbKashikataKamoku.Tag = "kashikata_kamoku_code";
            this.cmbKashikataKamoku.SelectedIndexChanged += new System.EventHandler(this.cmbbox_Changed);
            this.cmbKashikataKamoku.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.cmbKashikataKamoku.Leave += new System.EventHandler(this.control_Leave);
            this.cmbKashikataKamoku.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // cmbKarikataHojo
            // 
            this.cmbKarikataHojo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKarikataHojo.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKarikataHojo.FormattingEnabled = true;
            this.cmbKarikataHojo.IntegralHeight = false;
            this.cmbKarikataHojo.Location = new System.Drawing.Point(156, 424);
            this.cmbKarikataHojo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKarikataHojo.Name = "cmbKarikataHojo";
            this.cmbKarikataHojo.Size = new System.Drawing.Size(114, 34);
            this.cmbKarikataHojo.TabIndex = 9;
            this.cmbKarikataHojo.Tag = "karikata_hojo_seiri";
            this.cmbKarikataHojo.SelectedIndexChanged += new System.EventHandler(this.cmbbox_Changed);
            this.cmbKarikataHojo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.cmbKarikataHojo.Leave += new System.EventHandler(this.control_Leave);
            this.cmbKarikataHojo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // cmbKarikataKamoku
            // 
            this.cmbKarikataKamoku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKarikataKamoku.DropDownHeight = 300;
            this.cmbKarikataKamoku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKarikataKamoku.FormattingEnabled = true;
            this.cmbKarikataKamoku.IntegralHeight = false;
            this.cmbKarikataKamoku.Location = new System.Drawing.Point(156, 373);
            this.cmbKarikataKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKarikataKamoku.Name = "cmbKarikataKamoku";
            this.cmbKarikataKamoku.Size = new System.Drawing.Size(114, 34);
            this.cmbKarikataKamoku.TabIndex = 8;
            this.cmbKarikataKamoku.Tag = "karikata_kamoku_code";
            this.cmbKarikataKamoku.SelectedIndexChanged += new System.EventHandler(this.cmbbox_Changed);
            this.cmbKarikataKamoku.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.cmbKarikataKamoku.Leave += new System.EventHandler(this.control_Leave);
            this.cmbKarikataKamoku.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // cmbTorihikiKubun
            // 
            this.cmbTorihikiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTorihikiKubun.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbTorihikiKubun.FormattingEnabled = true;
            this.cmbTorihikiKubun.Location = new System.Drawing.Point(156, 145);
            this.cmbTorihikiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbTorihikiKubun.Name = "cmbTorihikiKubun";
            this.cmbTorihikiKubun.Size = new System.Drawing.Size(253, 34);
            this.cmbTorihikiKubun.TabIndex = 3;
            this.cmbTorihikiKubun.Tag = "torihiki_kubun";
            this.cmbTorihikiKubun.TextChanged += new System.EventHandler(this.cmbbox_Changed);
            this.cmbTorihikiKubun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.cmbTorihikiKubun.Leave += new System.EventHandler(this.control_Leave);
            this.cmbTorihikiKubun.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // cmbKaikeiKubun
            // 
            this.cmbKaikeiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKaikeiKubun.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKaikeiKubun.FormattingEnabled = true;
            this.cmbKaikeiKubun.Location = new System.Drawing.Point(156, 94);
            this.cmbKaikeiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKaikeiKubun.Name = "cmbKaikeiKubun";
            this.cmbKaikeiKubun.Size = new System.Drawing.Size(490, 34);
            this.cmbKaikeiKubun.TabIndex = 2;
            this.cmbKaikeiKubun.Tag = "kaikei_kubun";
            this.cmbKaikeiKubun.TextChanged += new System.EventHandler(this.cmbbox_Changed);
            this.cmbKaikeiKubun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.cmbKaikeiKubun.Leave += new System.EventHandler(this.control_Leave);
            this.cmbKaikeiKubun.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // txtKingaku
            // 
            this.txtKingaku.Amount = ((long)(0));
            this.txtKingaku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKingaku.Location = new System.Drawing.Point(1085, 506);
            this.txtKingaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKingaku.Name = "txtKingaku";
            this.txtKingaku.Size = new System.Drawing.Size(237, 33);
            this.txtKingaku.TabIndex = 12;
            this.txtKingaku.Tag = "karikata_kingaku";
            this.txtKingaku.Text = "\\0";
            this.txtKingaku.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKingaku.TextChanged += new System.EventHandler(this.control_Changed);
            this.txtKingaku.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.txtKingaku.Leave += new System.EventHandler(this.control_Leave);
            this.txtKingaku.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // txtKihyoubiGengou
            // 
            this.txtKihyoubiGengou.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKihyoubiGengou.Location = new System.Drawing.Point(156, 200);
            this.txtKihyoubiGengou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKihyoubiGengou.Name = "txtKihyoubiGengou";
            this.txtKihyoubiGengou.Size = new System.Drawing.Size(66, 33);
            this.txtKihyoubiGengou.TabIndex = 4;
            this.txtKihyoubiGengou.Tag = "kihyoubi_gengou";
            this.txtKihyoubiGengou.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKihyoubiGengou.TextChanged += new System.EventHandler(this.control_Changed);
            this.txtKihyoubiGengou.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.txtKihyoubiGengou.Leave += new System.EventHandler(this.control_Leave);
            this.txtKihyoubiGengou.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // txtKihyoubiYear
            // 
            this.txtKihyoubiYear.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKihyoubiYear.Location = new System.Drawing.Point(233, 200);
            this.txtKihyoubiYear.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKihyoubiYear.Name = "txtKihyoubiYear";
            this.txtKihyoubiYear.Size = new System.Drawing.Size(66, 33);
            this.txtKihyoubiYear.TabIndex = 5;
            this.txtKihyoubiYear.Tag = "kihyoubi_year";
            this.txtKihyoubiYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKihyoubiYear.TextChanged += new System.EventHandler(this.control_Changed);
            this.txtKihyoubiYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.txtKihyoubiYear.Leave += new System.EventHandler(this.control_Leave);
            this.txtKihyoubiYear.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // txtKihyoubiMonth
            // 
            this.txtKihyoubiMonth.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKihyoubiMonth.Location = new System.Drawing.Point(314, 200);
            this.txtKihyoubiMonth.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKihyoubiMonth.Name = "txtKihyoubiMonth";
            this.txtKihyoubiMonth.Size = new System.Drawing.Size(66, 33);
            this.txtKihyoubiMonth.TabIndex = 6;
            this.txtKihyoubiMonth.Tag = "kihyoubi_month";
            this.txtKihyoubiMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKihyoubiMonth.TextChanged += new System.EventHandler(this.control_Changed);
            this.txtKihyoubiMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.txtKihyoubiMonth.Leave += new System.EventHandler(this.control_Leave);
            this.txtKihyoubiMonth.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // txtKihyoubiDay
            // 
            this.txtKihyoubiDay.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKihyoubiDay.Location = new System.Drawing.Point(394, 200);
            this.txtKihyoubiDay.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKihyoubiDay.Name = "txtKihyoubiDay";
            this.txtKihyoubiDay.Size = new System.Drawing.Size(66, 33);
            this.txtKihyoubiDay.TabIndex = 7;
            this.txtKihyoubiDay.Tag = "kihyoubi_day";
            this.txtKihyoubiDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKihyoubiDay.TextChanged += new System.EventHandler(this.control_Changed);
            this.txtKihyoubiDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.txtKihyoubiDay.Leave += new System.EventHandler(this.control_Leave);
            this.txtKihyoubiDay.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // DenpyouInfoPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1404, 716);
            this.Controls.Add(this.txtKihyoubiDay);
            this.Controls.Add(this.txtKihyoubiMonth);
            this.Controls.Add(this.txtKihyoubiYear);
            this.Controls.Add(this.txtKihyoubiGengou);
            this.Controls.Add(this.txtKingaku);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.checkDenpyouKakunin);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtTekiyouId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblKashikataHojo);
            this.Controls.Add(this.lblKashikataKamoku);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbKashikataHojo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbKashikataKamoku);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblKarikataHojo);
            this.Controls.Add(this.lblKarikataKamoku);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbKarikataHojo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbKarikataKamoku);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTorihikiKubun);
            this.Controls.Add(this.cmbKaikeiKubun);
            this.Controls.Add(this.txtDenpyouBangou);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "DenpyouInfoPopup";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "詳細";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDenpyouBangou;
        private controls.MTComboBox cmbKaikeiKubun;
        private controls.MTComboBox cmbTorihikiKubun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private controls.MTComboBox cmbKarikataKamoku;
        private System.Windows.Forms.Label label7;
        private controls.MTComboBox cmbKarikataHojo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKarikataKamoku;
        private System.Windows.Forms.Label lblKarikataHojo;
        private System.Windows.Forms.Label lblKashikataHojo;
        private System.Windows.Forms.Label lblKashikataKamoku;
        private System.Windows.Forms.Label label11;
        private controls.MTComboBox cmbKashikataHojo;
        private System.Windows.Forms.Label label12;
        private controls.MTComboBox cmbKashikataKamoku;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTekiyouId;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkDenpyouKakunin;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private controls.AmountTextBox txtKingaku;
        private System.Windows.Forms.TextBox txtKihyoubiGengou;
        private System.Windows.Forms.TextBox txtKihyoubiYear;
        private System.Windows.Forms.TextBox txtKihyoubiMonth;
        private System.Windows.Forms.TextBox txtKihyoubiDay;
    }
}