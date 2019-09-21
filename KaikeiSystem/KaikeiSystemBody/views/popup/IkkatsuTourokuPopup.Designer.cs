namespace KaikeiSystemBody.views.popup
{
    partial class IkkatsuTourokuPopup
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
            this.lblKihyoubiInfo = new System.Windows.Forms.Label();
            this.chkModifyComment = new System.Windows.Forms.CheckBox();
            this.txtAddTextForComment = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCommentSuffix = new System.Windows.Forms.RadioButton();
            this.radioCommentPrefix = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbShiteiKubun = new System.Windows.Forms.ComboBox();
            this.btnSelectKubun = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnUnselectAll = new System.Windows.Forms.Button();
            this.btnTouroku = new System.Windows.Forms.Button();
            this.btnShowMasterEditView = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.grid = new KaikeiSystemBody.views.grid.IkkatsuSyoriGrid();
            this.dateKihyoubi = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "起票日";
            // 
            // lblKihyoubiInfo
            // 
            this.lblKihyoubiInfo.AutoSize = true;
            this.lblKihyoubiInfo.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKihyoubiInfo.Location = new System.Drawing.Point(464, 33);
            this.lblKihyoubiInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKihyoubiInfo.Name = "lblKihyoubiInfo";
            this.lblKihyoubiInfo.Size = new System.Drawing.Size(0, 26);
            this.lblKihyoubiInfo.TabIndex = 5;
            // 
            // chkModifyComment
            // 
            this.chkModifyComment.AutoSize = true;
            this.chkModifyComment.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkModifyComment.Location = new System.Drawing.Point(28, 103);
            this.chkModifyComment.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkModifyComment.Name = "chkModifyComment";
            this.chkModifyComment.Size = new System.Drawing.Size(334, 30);
            this.chkModifyComment.TabIndex = 4;
            this.chkModifyComment.Text = "摘要へ以下の文字列を追加";
            this.chkModifyComment.UseVisualStyleBackColor = true;
            this.chkModifyComment.CheckedChanged += new System.EventHandler(this.chkModifyComment_CheckedChanged);
            this.chkModifyComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.chkModifyComment.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // txtAddTextForComment
            // 
            this.txtAddTextForComment.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtAddTextForComment.Location = new System.Drawing.Point(128, 147);
            this.txtAddTextForComment.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAddTextForComment.Name = "txtAddTextForComment";
            this.txtAddTextForComment.Size = new System.Drawing.Size(301, 33);
            this.txtAddTextForComment.TabIndex = 5;
            this.txtAddTextForComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.txtAddTextForComment.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCommentSuffix);
            this.groupBox1.Controls.Add(this.radioCommentPrefix);
            this.groupBox1.Location = new System.Drawing.Point(469, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(171, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // radioCommentSuffix
            // 
            this.radioCommentSuffix.AutoSize = true;
            this.radioCommentSuffix.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioCommentSuffix.Location = new System.Drawing.Point(28, 75);
            this.radioCommentSuffix.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioCommentSuffix.Name = "radioCommentSuffix";
            this.radioCommentSuffix.Size = new System.Drawing.Size(110, 30);
            this.radioCommentSuffix.TabIndex = 1;
            this.radioCommentSuffix.TabStop = true;
            this.radioCommentSuffix.Text = "後付け";
            this.radioCommentSuffix.UseVisualStyleBackColor = true;
            this.radioCommentSuffix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.radioCommentSuffix.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // radioCommentPrefix
            // 
            this.radioCommentPrefix.AutoSize = true;
            this.radioCommentPrefix.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioCommentPrefix.Location = new System.Drawing.Point(28, 32);
            this.radioCommentPrefix.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioCommentPrefix.Name = "radioCommentPrefix";
            this.radioCommentPrefix.Size = new System.Drawing.Size(110, 30);
            this.radioCommentPrefix.TabIndex = 0;
            this.radioCommentPrefix.TabStop = true;
            this.radioCommentPrefix.Text = "前付け";
            this.radioCommentPrefix.UseVisualStyleBackColor = true;
            this.radioCommentPrefix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.radioCommentPrefix.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(22, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "区分指定";
            // 
            // cmbShiteiKubun
            // 
            this.cmbShiteiKubun.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbShiteiKubun.FormattingEnabled = true;
            this.cmbShiteiKubun.Location = new System.Drawing.Point(156, 238);
            this.cmbShiteiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbShiteiKubun.Name = "cmbShiteiKubun";
            this.cmbShiteiKubun.Size = new System.Drawing.Size(274, 34);
            this.cmbShiteiKubun.TabIndex = 7;
            this.cmbShiteiKubun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.cmbShiteiKubun.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnSelectKubun
            // 
            this.btnSelectKubun.ForeColor = System.Drawing.Color.Blue;
            this.btnSelectKubun.Location = new System.Drawing.Point(469, 236);
            this.btnSelectKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSelectKubun.Name = "btnSelectKubun";
            this.btnSelectKubun.Size = new System.Drawing.Size(171, 46);
            this.btnSelectKubun.TabIndex = 8;
            this.btnSelectKubun.Text = "指定選択(&P)";
            this.btnSelectKubun.UseVisualStyleBackColor = true;
            this.btnSelectKubun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnSelectKubun.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.ForeColor = System.Drawing.Color.Blue;
            this.btnSelectAll.Location = new System.Drawing.Point(651, 236);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(171, 46);
            this.btnSelectAll.TabIndex = 9;
            this.btnSelectAll.Text = "すべて選択(&S)";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnSelectAll.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnUnselectAll
            // 
            this.btnUnselectAll.ForeColor = System.Drawing.Color.Blue;
            this.btnUnselectAll.Location = new System.Drawing.Point(832, 236);
            this.btnUnselectAll.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnUnselectAll.Name = "btnUnselectAll";
            this.btnUnselectAll.Size = new System.Drawing.Size(171, 46);
            this.btnUnselectAll.TabIndex = 10;
            this.btnUnselectAll.Text = "すべて解除(&C)";
            this.btnUnselectAll.UseVisualStyleBackColor = true;
            this.btnUnselectAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnUnselectAll.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnTouroku
            // 
            this.btnTouroku.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTouroku.Location = new System.Drawing.Point(1223, 26);
            this.btnTouroku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTouroku.Name = "btnTouroku";
            this.btnTouroku.Size = new System.Drawing.Size(171, 46);
            this.btnTouroku.TabIndex = 11;
            this.btnTouroku.Text = "一括登録(&P)";
            this.btnTouroku.UseVisualStyleBackColor = true;
            this.btnTouroku.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnTouroku.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnShowMasterEditView
            // 
            this.btnShowMasterEditView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowMasterEditView.Location = new System.Drawing.Point(1404, 26);
            this.btnShowMasterEditView.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnShowMasterEditView.Name = "btnShowMasterEditView";
            this.btnShowMasterEditView.Size = new System.Drawing.Size(171, 46);
            this.btnShowMasterEditView.TabIndex = 12;
            this.btnShowMasterEditView.Text = "マスタ編集(&M)";
            this.btnShowMasterEditView.UseVisualStyleBackColor = true;
            this.btnShowMasterEditView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnShowMasterEditView.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(1586, 26);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 46);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "閉じる(&X)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnClose.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(0, -2);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label3.Size = new System.Drawing.Size(129, 56);
            this.label3.TabIndex = 16;
            this.label3.Text = "区分";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1742, 56);
            this.panel1.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label19.Location = new System.Drawing.Point(1166, 26);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label19.Size = new System.Drawing.Size(173, 28);
            this.label19.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.Location = new System.Drawing.Point(1428, 0);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label18.Size = new System.Drawing.Size(312, 26);
            this.label18.TabIndex = 31;
            this.label18.Text = "登録";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(1338, 26);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label17.Size = new System.Drawing.Size(402, 28);
            this.label17.TabIndex = 30;
            this.label17.Text = "コメント";
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(1338, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label16.Size = new System.Drawing.Size(90, 26);
            this.label16.TabIndex = 29;
            this.label16.Text = "摘要ID";
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(1166, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label15.Size = new System.Drawing.Size(173, 26);
            this.label15.TabIndex = 28;
            this.label15.Text = "借方金額";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(889, 26);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label13.Size = new System.Drawing.Size(277, 28);
            this.label13.TabIndex = 27;
            this.label13.Text = "補助科目";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(889, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label14.Size = new System.Drawing.Size(277, 26);
            this.label14.TabIndex = 26;
            this.label14.Text = "科目";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(799, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label11.Size = new System.Drawing.Size(90, 28);
            this.label11.TabIndex = 25;
            this.label11.Text = "補助ID";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(799, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label12.Size = new System.Drawing.Size(90, 26);
            this.label12.TabIndex = 24;
            this.label12.Text = "科目ID";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(523, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label10.Size = new System.Drawing.Size(277, 28);
            this.label10.TabIndex = 23;
            this.label10.Text = "補助科目";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(523, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label9.Size = new System.Drawing.Size(277, 26);
            this.label9.TabIndex = 22;
            this.label9.Text = "科目";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(433, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label8.Size = new System.Drawing.Size(90, 28);
            this.label8.TabIndex = 21;
            this.label8.Text = "補助ID";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(433, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label7.Size = new System.Drawing.Size(90, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "科目ID";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(270, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label6.Size = new System.Drawing.Size(163, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "取引区分";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(128, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label5.Size = new System.Drawing.Size(141, 28);
            this.label5.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(128, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label4.Size = new System.Drawing.Size(306, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "会計区分";
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGrid.Controls.Add(this.grid);
            this.panelGrid.Controls.Add(this.panel1);
            this.panelGrid.Location = new System.Drawing.Point(4, 292);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1738, 778);
            this.panelGrid.TabIndex = 18;
            // 
            // grid
            // 
            this.grid.BackColor = System.Drawing.SystemColors.Control;
            this.grid.DataCount = 0;
            this.grid.Location = new System.Drawing.Point(-4, 54);
            this.grid.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.grid.Name = "grid";
            this.grid.NewRowIsVisible = false;
            this.grid.Size = new System.Drawing.Size(1742, 721);
            this.grid.TabIndex = 18;
            // 
            // dateKihyoubi
            // 
            this.dateKihyoubi.AutoSize = true;
            this.dateKihyoubi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateKihyoubi.BackColor = System.Drawing.Color.Transparent;
            this.dateKihyoubi.Date = null;
            this.dateKihyoubi.DayStr = "";
            this.dateKihyoubi.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateKihyoubi.GengouStr = "";
            this.dateKihyoubi.Location = new System.Drawing.Point(128, 26);
            this.dateKihyoubi.Margin = new System.Windows.Forms.Padding(0);
            this.dateKihyoubi.MarginGengou2Year = 11;
            this.dateKihyoubi.MarginMonth2Day = 11;
            this.dateKihyoubi.MarginYear2Month = 11;
            this.dateKihyoubi.MonthStr = "";
            this.dateKihyoubi.Name = "dateKihyoubi";
            this.dateKihyoubi.Size = new System.Drawing.Size(305, 37);
            this.dateKihyoubi.TabIndex = 19;
            this.dateKihyoubi.TextBoxWidth = 67;
            this.dateKihyoubi.YearStr = "";
            this.dateKihyoubi.TextBoxKeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.dateKihyoubi.TextBoxPreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // IkkatsuTourokuPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1749, 1076);
            this.Controls.Add(this.dateKihyoubi);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowMasterEditView);
            this.Controls.Add(this.btnTouroku);
            this.Controls.Add(this.btnUnselectAll);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnSelectKubun);
            this.Controls.Add(this.cmbShiteiKubun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkModifyComment);
            this.Controls.Add(this.lblKihyoubiInfo);
            this.Controls.Add(this.txtAddTextForComment);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "IkkatsuTourokuPopup";
            this.ShowInTaskbar = false;
            this.Text = "一括登録";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKihyoubiInfo;
        private System.Windows.Forms.CheckBox chkModifyComment;
        private System.Windows.Forms.TextBox txtAddTextForComment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCommentSuffix;
        private System.Windows.Forms.RadioButton radioCommentPrefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbShiteiKubun;
        private System.Windows.Forms.Button btnSelectKubun;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnUnselectAll;
        private System.Windows.Forms.Button btnTouroku;
        private System.Windows.Forms.Button btnShowMasterEditView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private grid.IkkatsuSyoriGrid grid;
        private System.Windows.Forms.Label label19;
        private controls.DateInputPanel dateKihyoubi;
        private System.Windows.Forms.Label label5;
    }
}