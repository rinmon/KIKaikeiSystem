namespace KaikeiSystemBody.views.popup
{
    partial class KanjouMototyouPrinntPopup
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioKamokuRange = new System.Windows.Forms.RadioButton();
            this.radioKamokuSelected = new System.Windows.Forms.RadioButton();
            this.radioKamokuAll = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panelKamokuOrder = new System.Windows.Forms.Panel();
            this.radioKamokuOrderAlphabet = new System.Windows.Forms.RadioButton();
            this.radioKamokuOrderCode = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkPrintHojoMototyou = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDontPrintKanjouMototyou = new System.Windows.Forms.CheckBox();
            this.chkRenzoku = new System.Windows.Forms.CheckBox();
            this.chkDenpyouSeiri = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioKaikeiKubunSelect = new System.Windows.Forms.RadioButton();
            this.radioKaikeiKubunAll = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbHojoKamoku = new KaikeiSystemBody.views.controls.MTComboBox();
            this.cmbKamokuBottom = new KaikeiSystemBody.views.controls.MTComboBox();
            this.txtKamokuSelectorBottom = new KaikeiSystemBody.views.controls.KeySelectorTextBox();
            this.cmbKamokuTop = new KaikeiSystemBody.views.controls.MTComboBox();
            this.txtKamokuSelectorTop = new KaikeiSystemBody.views.controls.KeySelectorTextBox();
            this.txtKamokuSelector = new KaikeiSystemBody.views.controls.KeySelectorTextBox();
            this.cmbKamoku = new KaikeiSystemBody.views.controls.MTComboBox();
            this.cmbKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.dateEnd = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.dateStart = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.groupBox1.SuspendLayout();
            this.panelKamokuOrder.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "対象期間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(473, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "～";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label3.Location = new System.Drawing.Point(51, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 52);
            this.label3.TabIndex = 5;
            this.label3.Text = "印刷対象-1\r\n会計区分の指定";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(40, 268);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 2);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label4.Location = new System.Drawing.Point(51, 301);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 52);
            this.label4.TabIndex = 7;
            this.label4.Text = "印刷対象-2\r\n科目の指定";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioKamokuRange);
            this.groupBox1.Controls.Add(this.radioKamokuSelected);
            this.groupBox1.Controls.Add(this.radioKamokuAll);
            this.groupBox1.Location = new System.Drawing.Point(264, 280);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(605, 88);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // radioKamokuRange
            // 
            this.radioKamokuRange.AutoSize = true;
            this.radioKamokuRange.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioKamokuRange.Location = new System.Drawing.Point(413, 32);
            this.radioKamokuRange.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioKamokuRange.Name = "radioKamokuRange";
            this.radioKamokuRange.Size = new System.Drawing.Size(145, 31);
            this.radioKamokuRange.TabIndex = 9;
            this.radioKamokuRange.TabStop = true;
            this.radioKamokuRange.Text = "指定範囲";
            this.radioKamokuRange.UseVisualStyleBackColor = true;
            this.radioKamokuRange.CheckedChanged += new System.EventHandler(this.radioTargetKamoku_CheckedChanged);
            // 
            // radioKamokuSelected
            // 
            this.radioKamokuSelected.AutoSize = true;
            this.radioKamokuSelected.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioKamokuSelected.Location = new System.Drawing.Point(149, 32);
            this.radioKamokuSelected.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioKamokuSelected.Name = "radioKamokuSelected";
            this.radioKamokuSelected.Size = new System.Drawing.Size(240, 31);
            this.radioKamokuSelected.TabIndex = 1;
            this.radioKamokuSelected.TabStop = true;
            this.radioKamokuSelected.Text = "選択した勘定科目";
            this.radioKamokuSelected.UseVisualStyleBackColor = true;
            this.radioKamokuSelected.CheckedChanged += new System.EventHandler(this.radioTargetKamoku_CheckedChanged);
            // 
            // radioKamokuAll
            // 
            this.radioKamokuAll.AutoSize = true;
            this.radioKamokuAll.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioKamokuAll.Location = new System.Drawing.Point(24, 32);
            this.radioKamokuAll.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioKamokuAll.Name = "radioKamokuAll";
            this.radioKamokuAll.Size = new System.Drawing.Size(103, 31);
            this.radioKamokuAll.TabIndex = 0;
            this.radioKamokuAll.TabStop = true;
            this.radioKamokuAll.Text = "すべて";
            this.radioKamokuAll.UseVisualStyleBackColor = true;
            this.radioKamokuAll.CheckedChanged += new System.EventHandler(this.radioTargetKamoku_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label5.Location = new System.Drawing.Point(51, 397);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "対象科目";
            // 
            // panelKamokuOrder
            // 
            this.panelKamokuOrder.Controls.Add(this.radioKamokuOrderAlphabet);
            this.panelKamokuOrder.Controls.Add(this.radioKamokuOrderCode);
            this.panelKamokuOrder.Location = new System.Drawing.Point(748, 382);
            this.panelKamokuOrder.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelKamokuOrder.Name = "panelKamokuOrder";
            this.panelKamokuOrder.Size = new System.Drawing.Size(235, 60);
            this.panelKamokuOrder.TabIndex = 22;
            // 
            // radioKamokuOrderAlphabet
            // 
            this.radioKamokuOrderAlphabet.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioKamokuOrderAlphabet.AutoSize = true;
            this.radioKamokuOrderAlphabet.Location = new System.Drawing.Point(6, 5);
            this.radioKamokuOrderAlphabet.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioKamokuOrderAlphabet.Name = "radioKamokuOrderAlphabet";
            this.radioKamokuOrderAlphabet.Padding = new System.Windows.Forms.Padding(4);
            this.radioKamokuOrderAlphabet.Size = new System.Drawing.Size(92, 39);
            this.radioKamokuOrderAlphabet.TabIndex = 19;
            this.radioKamokuOrderAlphabet.Text = "50音順";
            this.radioKamokuOrderAlphabet.UseVisualStyleBackColor = true;
            // 
            // radioKamokuOrderCode
            // 
            this.radioKamokuOrderCode.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioKamokuOrderCode.AutoSize = true;
            this.radioKamokuOrderCode.Location = new System.Drawing.Point(106, 5);
            this.radioKamokuOrderCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioKamokuOrderCode.Name = "radioKamokuOrderCode";
            this.radioKamokuOrderCode.Padding = new System.Windows.Forms.Padding(4);
            this.radioKamokuOrderCode.Size = new System.Drawing.Size(96, 39);
            this.radioKamokuOrderCode.TabIndex = 20;
            this.radioKamokuOrderCode.Text = "コード順";
            this.radioKamokuOrderCode.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(40, 556);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 2);
            this.panel2.TabIndex = 7;
            // 
            // chkPrintHojoMototyou
            // 
            this.chkPrintHojoMototyou.AutoSize = true;
            this.chkPrintHojoMototyou.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkPrintHojoMototyou.Location = new System.Drawing.Point(180, 586);
            this.chkPrintHojoMototyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkPrintHojoMototyou.Name = "chkPrintHojoMototyou";
            this.chkPrintHojoMototyou.Size = new System.Drawing.Size(222, 31);
            this.chkPrintHojoMototyou.TabIndex = 27;
            this.chkPrintHojoMototyou.Text = "補助元帳の印刷";
            this.chkPrintHojoMototyou.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label6.Location = new System.Drawing.Point(51, 644);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 26);
            this.label6.TabIndex = 28;
            this.label6.Text = "対象補助科目";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDontPrintKanjouMototyou);
            this.groupBox2.Controls.Add(this.chkRenzoku);
            this.groupBox2.Controls.Add(this.chkDenpyouSeiri);
            this.groupBox2.Location = new System.Drawing.Point(154, 746);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Size = new System.Drawing.Size(682, 175);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // chkDontPrintKanjouMototyou
            // 
            this.chkDontPrintKanjouMototyou.AutoSize = true;
            this.chkDontPrintKanjouMototyou.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkDontPrintKanjouMototyou.Location = new System.Drawing.Point(29, 119);
            this.chkDontPrintKanjouMototyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkDontPrintKanjouMototyou.Name = "chkDontPrintKanjouMototyou";
            this.chkDontPrintKanjouMototyou.Size = new System.Drawing.Size(288, 31);
            this.chkDontPrintKanjouMototyou.TabIndex = 2;
            this.chkDontPrintKanjouMototyou.Text = "勘定元帳は印刷しない";
            this.chkDontPrintKanjouMototyou.UseVisualStyleBackColor = true;
            // 
            // chkRenzoku
            // 
            this.chkRenzoku.AutoSize = true;
            this.chkRenzoku.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkRenzoku.Location = new System.Drawing.Point(29, 75);
            this.chkRenzoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkRenzoku.Name = "chkRenzoku";
            this.chkRenzoku.Size = new System.Drawing.Size(222, 31);
            this.chkRenzoku.TabIndex = 1;
            this.chkRenzoku.Text = "連続形式で印刷";
            this.chkRenzoku.UseVisualStyleBackColor = true;
            // 
            // chkDenpyouSeiri
            // 
            this.chkDenpyouSeiri.AutoSize = true;
            this.chkDenpyouSeiri.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkDenpyouSeiri.Location = new System.Drawing.Point(29, 32);
            this.chkDenpyouSeiri.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkDenpyouSeiri.Name = "chkDenpyouSeiri";
            this.chkDenpyouSeiri.Size = new System.Drawing.Size(398, 31);
            this.chkDenpyouSeiri.TabIndex = 0;
            this.chkDenpyouSeiri.Text = "印刷前に伝票番号の整理を実行";
            this.chkDenpyouSeiri.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPrint.Location = new System.Drawing.Point(689, 959);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(143, 49);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.Text = "印刷(&P)";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(843, 959);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 49);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "閉じる(&X)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(40, 712);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(917, 2);
            this.panel3.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioKaikeiKubunSelect);
            this.groupBox3.Controls.Add(this.radioKaikeiKubunAll);
            this.groupBox3.Location = new System.Drawing.Point(264, 105);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Size = new System.Drawing.Size(402, 84);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            // 
            // radioKaikeiKubunSelect
            // 
            this.radioKaikeiKubunSelect.AutoSize = true;
            this.radioKaikeiKubunSelect.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioKaikeiKubunSelect.Location = new System.Drawing.Point(149, 32);
            this.radioKaikeiKubunSelect.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioKaikeiKubunSelect.Name = "radioKaikeiKubunSelect";
            this.radioKaikeiKubunSelect.Size = new System.Drawing.Size(219, 31);
            this.radioKaikeiKubunSelect.TabIndex = 1;
            this.radioKaikeiKubunSelect.TabStop = true;
            this.radioKaikeiKubunSelect.Text = "会計区分を指定";
            this.radioKaikeiKubunSelect.UseVisualStyleBackColor = true;
            this.radioKaikeiKubunSelect.CheckedChanged += new System.EventHandler(this.radioKaikeiKubunAll_CheckedChanged);
            // 
            // radioKaikeiKubunAll
            // 
            this.radioKaikeiKubunAll.AutoSize = true;
            this.radioKaikeiKubunAll.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioKaikeiKubunAll.Location = new System.Drawing.Point(24, 32);
            this.radioKaikeiKubunAll.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioKaikeiKubunAll.Name = "radioKaikeiKubunAll";
            this.radioKaikeiKubunAll.Size = new System.Drawing.Size(103, 31);
            this.radioKaikeiKubunAll.TabIndex = 0;
            this.radioKaikeiKubunAll.TabStop = true;
            this.radioKaikeiKubunAll.Text = "すべて";
            this.radioKaikeiKubunAll.UseVisualStyleBackColor = true;
            this.radioKaikeiKubunAll.CheckedChanged += new System.EventHandler(this.radioKaikeiKubunAll_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label7.Location = new System.Drawing.Point(51, 200);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 26);
            this.label7.TabIndex = 34;
            this.label7.Text = "会計区分";
            // 
            // cmbHojoKamoku
            // 
            this.cmbHojoKamoku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHojoKamoku.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbHojoKamoku.FormattingEnabled = true;
            this.cmbHojoKamoku.Location = new System.Drawing.Point(262, 639);
            this.cmbHojoKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbHojoKamoku.Name = "cmbHojoKamoku";
            this.cmbHojoKamoku.Size = new System.Drawing.Size(472, 35);
            this.cmbHojoKamoku.TabIndex = 29;
            // 
            // cmbKamokuBottom
            // 
            this.cmbKamokuBottom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKamokuBottom.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKamokuBottom.FormattingEnabled = true;
            this.cmbKamokuBottom.Location = new System.Drawing.Point(413, 486);
            this.cmbKamokuBottom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKamokuBottom.Name = "cmbKamokuBottom";
            this.cmbKamokuBottom.Size = new System.Drawing.Size(321, 35);
            this.cmbKamokuBottom.TabIndex = 26;
            // 
            // txtKamokuSelectorBottom
            // 
            this.txtKamokuSelectorBottom.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKamokuSelectorBottom.Location = new System.Drawing.Point(264, 486);
            this.txtKamokuSelectorBottom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKamokuSelectorBottom.Name = "txtKamokuSelectorBottom";
            this.txtKamokuSelectorBottom.Size = new System.Drawing.Size(134, 34);
            this.txtKamokuSelectorBottom.TabIndex = 25;
            // 
            // cmbKamokuTop
            // 
            this.cmbKamokuTop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKamokuTop.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKamokuTop.FormattingEnabled = true;
            this.cmbKamokuTop.Location = new System.Drawing.Point(413, 436);
            this.cmbKamokuTop.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKamokuTop.Name = "cmbKamokuTop";
            this.cmbKamokuTop.Size = new System.Drawing.Size(321, 35);
            this.cmbKamokuTop.TabIndex = 24;
            // 
            // txtKamokuSelectorTop
            // 
            this.txtKamokuSelectorTop.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKamokuSelectorTop.Location = new System.Drawing.Point(264, 438);
            this.txtKamokuSelectorTop.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKamokuSelectorTop.Name = "txtKamokuSelectorTop";
            this.txtKamokuSelectorTop.Size = new System.Drawing.Size(134, 34);
            this.txtKamokuSelectorTop.TabIndex = 23;
            // 
            // txtKamokuSelector
            // 
            this.txtKamokuSelector.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKamokuSelector.Location = new System.Drawing.Point(264, 388);
            this.txtKamokuSelector.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKamokuSelector.Name = "txtKamokuSelector";
            this.txtKamokuSelector.Size = new System.Drawing.Size(134, 34);
            this.txtKamokuSelector.TabIndex = 11;
            // 
            // cmbKamoku
            // 
            this.cmbKamoku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKamoku.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKamoku.FormattingEnabled = true;
            this.cmbKamoku.Location = new System.Drawing.Point(413, 388);
            this.cmbKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKamoku.Name = "cmbKamoku";
            this.cmbKamoku.Size = new System.Drawing.Size(321, 35);
            this.cmbKamoku.TabIndex = 10;
            // 
            // cmbKaikeiKubun
            // 
            this.cmbKaikeiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKaikeiKubun.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKaikeiKubun.FormattingEnabled = true;
            this.cmbKaikeiKubun.Location = new System.Drawing.Point(262, 200);
            this.cmbKaikeiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKaikeiKubun.Name = "cmbKaikeiKubun";
            this.cmbKaikeiKubun.Size = new System.Drawing.Size(466, 35);
            this.cmbKaikeiKubun.TabIndex = 4;
            // 
            // dateEnd
            // 
            this.dateEnd.AutoSize = true;
            this.dateEnd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateEnd.BackColor = System.Drawing.Color.Transparent;
            this.dateEnd.Date = null;
            this.dateEnd.DayStr = "";
            this.dateEnd.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateEnd.GengouStr = "";
            this.dateEnd.Location = new System.Drawing.Point(523, 26);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(0);
            this.dateEnd.MarginGengou2Year = 11;
            this.dateEnd.MarginMonth2Day = 11;
            this.dateEnd.MarginYear2Month = 11;
            this.dateEnd.MonthStr = "";
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(269, 37);
            this.dateEnd.TabIndex = 2;
            this.dateEnd.TextBoxWidth = 58;
            this.dateEnd.YearStr = "";
            // 
            // dateStart
            // 
            this.dateStart.AutoSize = true;
            this.dateStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateStart.BackColor = System.Drawing.Color.Transparent;
            this.dateStart.Date = null;
            this.dateStart.DayStr = "";
            this.dateStart.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateStart.GengouStr = "";
            this.dateStart.Location = new System.Drawing.Point(193, 26);
            this.dateStart.Margin = new System.Windows.Forms.Padding(0);
            this.dateStart.MarginGengou2Year = 11;
            this.dateStart.MarginMonth2Day = 11;
            this.dateStart.MarginYear2Month = 11;
            this.dateStart.MonthStr = "";
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(269, 37);
            this.dateStart.TabIndex = 1;
            this.dateStart.TextBoxWidth = 58;
            this.dateStart.YearStr = "";
            // 
            // KanjouMototyouPrinntPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 1029);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbHojoKamoku);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkPrintHojoMototyou);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbKamokuBottom);
            this.Controls.Add(this.txtKamokuSelectorBottom);
            this.Controls.Add(this.cmbKamokuTop);
            this.Controls.Add(this.txtKamokuSelectorTop);
            this.Controls.Add(this.panelKamokuOrder);
            this.Controls.Add(this.txtKamokuSelector);
            this.Controls.Add(this.cmbKamoku);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKaikeiKubun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "KanjouMototyouPrinntPopup";
            this.ShowInTaskbar = false;
            this.Text = "勘定元帳印刷";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelKamokuOrder.ResumeLayout(false);
            this.panelKamokuOrder.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private controls.DateInputPanel dateStart;
        private controls.DateInputPanel dateEnd;
        private System.Windows.Forms.Label label2;
        private controls.MTComboBox cmbKaikeiKubun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioKamokuRange;
        private System.Windows.Forms.RadioButton radioKamokuSelected;
        private System.Windows.Forms.RadioButton radioKamokuAll;
        private System.Windows.Forms.Label label5;
        private controls.MTComboBox cmbKamoku;
        private controls.KeySelectorTextBox txtKamokuSelector;
        private System.Windows.Forms.Panel panelKamokuOrder;
        private System.Windows.Forms.RadioButton radioKamokuOrderAlphabet;
        private System.Windows.Forms.RadioButton radioKamokuOrderCode;
        private controls.KeySelectorTextBox txtKamokuSelectorTop;
        private controls.MTComboBox cmbKamokuTop;
        private controls.KeySelectorTextBox txtKamokuSelectorBottom;
        private controls.MTComboBox cmbKamokuBottom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkPrintHojoMototyou;
        private System.Windows.Forms.Label label6;
        private controls.MTComboBox cmbHojoKamoku;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkDenpyouSeiri;
        private System.Windows.Forms.CheckBox chkRenzoku;
        private System.Windows.Forms.CheckBox chkDontPrintKanjouMototyou;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioKaikeiKubunSelect;
        private System.Windows.Forms.RadioButton radioKaikeiKubunAll;
        private System.Windows.Forms.Label label7;

    }
}