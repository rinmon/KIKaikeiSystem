namespace KaikeiSystemBody.views
{
    partial class PrintMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMaster = new System.Windows.Forms.Panel();
            this.chkTekiyou = new System.Windows.Forms.CheckBox();
            this.chkKamoku = new System.Windows.Forms.CheckBox();
            this.groupKamokuType = new System.Windows.Forms.GroupBox();
            this.radioUsableKamoku = new System.Windows.Forms.RadioButton();
            this.radioAllKamoku = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDenpyou = new System.Windows.Forms.Panel();
            this.chkDenpyouForEachKamoku = new System.Windows.Forms.CheckBox();
            this.panelDenpyouBangouSelector = new System.Windows.Forms.Panel();
            this.txtEndBangou = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStartBangou = new System.Windows.Forms.TextBox();
            this.chkOnlyCheckedDenpyouPrint = new System.Windows.Forms.CheckBox();
            this.chkNikki = new System.Windows.Forms.CheckBox();
            this.chkDenpyou = new System.Windows.Forms.CheckBox();
            this.groupDenpyouPrintMethod = new System.Windows.Forms.GroupBox();
            this.radioDenpyouBangou = new System.Windows.Forms.RadioButton();
            this.radioKoushinbi = new System.Windows.Forms.RadioButton();
            this.radioTourokubi = new System.Windows.Forms.RadioButton();
            this.radioKihyoubi = new System.Windows.Forms.RadioButton();
            this.lblPrintMethodCaption = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelKessan = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkOmitZeroRow = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKamokuHierarchy = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkHideTyuuki10 = new System.Windows.Forms.CheckBox();
            this.chkHideTyuuki9 = new System.Windows.Forms.CheckBox();
            this.chkHideTyuuki3 = new System.Windows.Forms.CheckBox();
            this.chkHideTyuuki1 = new System.Windows.Forms.CheckBox();
            this.chkTyuuki = new System.Windows.Forms.CheckBox();
            this.chkHikiatekinMeisai = new System.Windows.Forms.CheckBox();
            this.chkKoteiShisanMeisai = new System.Windows.Forms.CheckBox();
            this.chkGoukeiZandakaHojokamoku = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkTaisyakuTaisyou = new System.Windows.Forms.CheckBox();
            this.chkGoukeiZandakaChukubunOnly = new System.Windows.Forms.CheckBox();
            this.chkJigyouUchiwake = new System.Windows.Forms.CheckBox();
            this.chkJigyouKeisan = new System.Windows.Forms.CheckBox();
            this.chkShikinKeisanHosei = new System.Windows.Forms.CheckBox();
            this.chkShikinUchiwake = new System.Windows.Forms.CheckBox();
            this.chkShikinKeisan = new System.Windows.Forms.CheckBox();
            this.chkKessanHyoushi = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrintYosan = new System.Windows.Forms.Button();
            this.btnPrintKoteiShisan = new System.Windows.Forms.Button();
            this.btnPrintShisanhyou = new System.Windows.Forms.Button();
            this.btnPrintMototyou = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkCloseFormWhenExecPrint = new System.Windows.Forms.CheckBox();
            this.mtKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.dateDenpyouBangou = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.dateEnd = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.dateStart = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.panelMaster.SuspendLayout();
            this.groupKamokuType.SuspendLayout();
            this.panelDenpyou.SuspendLayout();
            this.panelDenpyouBangouSelector.SuspendLayout();
            this.groupDenpyouPrintMethod.SuspendLayout();
            this.panelKessan.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "対象期間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(484, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "～";
            // 
            // panelMaster
            // 
            this.panelMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMaster.Controls.Add(this.chkTekiyou);
            this.panelMaster.Controls.Add(this.chkKamoku);
            this.panelMaster.Controls.Add(this.groupKamokuType);
            this.panelMaster.Location = new System.Drawing.Point(22, 135);
            this.panelMaster.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(418, 268);
            this.panelMaster.TabIndex = 3;
            // 
            // chkTekiyou
            // 
            this.chkTekiyou.AutoSize = true;
            this.chkTekiyou.Location = new System.Drawing.Point(229, 56);
            this.chkTekiyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkTekiyou.Name = "chkTekiyou";
            this.chkTekiyou.Size = new System.Drawing.Size(78, 25);
            this.chkTekiyou.TabIndex = 1;
            this.chkTekiyou.Text = "摘要";
            this.chkTekiyou.UseVisualStyleBackColor = true;
            // 
            // chkKamoku
            // 
            this.chkKamoku.AutoSize = true;
            this.chkKamoku.Location = new System.Drawing.Point(46, 56);
            this.chkKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkKamoku.Name = "chkKamoku";
            this.chkKamoku.Size = new System.Drawing.Size(120, 25);
            this.chkKamoku.TabIndex = 0;
            this.chkKamoku.Text = "勘定科目";
            this.chkKamoku.UseVisualStyleBackColor = true;
            this.chkKamoku.CheckedChanged += new System.EventHandler(this.chkKamoku_CheckedChanged);
            // 
            // groupKamokuType
            // 
            this.groupKamokuType.Controls.Add(this.radioUsableKamoku);
            this.groupKamokuType.Controls.Add(this.radioAllKamoku);
            this.groupKamokuType.Location = new System.Drawing.Point(46, 112);
            this.groupKamokuType.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupKamokuType.Name = "groupKamokuType";
            this.groupKamokuType.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupKamokuType.Size = new System.Drawing.Size(242, 122);
            this.groupKamokuType.TabIndex = 2;
            this.groupKamokuType.TabStop = false;
            // 
            // radioUsableKamoku
            // 
            this.radioUsableKamoku.AutoSize = true;
            this.radioUsableKamoku.Location = new System.Drawing.Point(22, 70);
            this.radioUsableKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioUsableKamoku.Name = "radioUsableKamoku";
            this.radioUsableKamoku.Size = new System.Drawing.Size(189, 25);
            this.radioUsableKamoku.TabIndex = 1;
            this.radioUsableKamoku.TabStop = true;
            this.radioUsableKamoku.Text = "使用する科目のみ";
            this.radioUsableKamoku.UseVisualStyleBackColor = true;
            // 
            // radioAllKamoku
            // 
            this.radioAllKamoku.AutoSize = true;
            this.radioAllKamoku.Location = new System.Drawing.Point(22, 32);
            this.radioAllKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioAllKamoku.Name = "radioAllKamoku";
            this.radioAllKamoku.Size = new System.Drawing.Size(145, 25);
            this.radioAllKamoku.TabIndex = 0;
            this.radioAllKamoku.TabStop = true;
            this.radioAllKamoku.Text = "すべての科目";
            this.radioAllKamoku.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(50, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "マスタ類";
            // 
            // panelDenpyou
            // 
            this.panelDenpyou.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDenpyou.Controls.Add(this.chkDenpyouForEachKamoku);
            this.panelDenpyou.Controls.Add(this.panelDenpyouBangouSelector);
            this.panelDenpyou.Controls.Add(this.chkOnlyCheckedDenpyouPrint);
            this.panelDenpyou.Controls.Add(this.chkNikki);
            this.panelDenpyou.Controls.Add(this.chkDenpyou);
            this.panelDenpyou.Controls.Add(this.groupDenpyouPrintMethod);
            this.panelDenpyou.Controls.Add(this.lblPrintMethodCaption);
            this.panelDenpyou.Location = new System.Drawing.Point(462, 135);
            this.panelDenpyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelDenpyou.Name = "panelDenpyou";
            this.panelDenpyou.Size = new System.Drawing.Size(1031, 268);
            this.panelDenpyou.TabIndex = 4;
            // 
            // chkDenpyouForEachKamoku
            // 
            this.chkDenpyouForEachKamoku.AutoSize = true;
            this.chkDenpyouForEachKamoku.Location = new System.Drawing.Point(46, 133);
            this.chkDenpyouForEachKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkDenpyouForEachKamoku.Name = "chkDenpyouForEachKamoku";
            this.chkDenpyouForEachKamoku.Size = new System.Drawing.Size(213, 25);
            this.chkDenpyouForEachKamoku.TabIndex = 24;
            this.chkDenpyouForEachKamoku.Text = "仕訳伝票（科目ごと）";
            this.chkDenpyouForEachKamoku.UseVisualStyleBackColor = true;
            this.chkDenpyouForEachKamoku.Visible = false;
            // 
            // panelDenpyouBangouSelector
            // 
            this.panelDenpyouBangouSelector.Controls.Add(this.dateDenpyouBangou);
            this.panelDenpyouBangouSelector.Controls.Add(this.txtEndBangou);
            this.panelDenpyouBangouSelector.Controls.Add(this.label7);
            this.panelDenpyouBangouSelector.Controls.Add(this.label8);
            this.panelDenpyouBangouSelector.Controls.Add(this.txtStartBangou);
            this.panelDenpyouBangouSelector.Location = new System.Drawing.Point(499, 144);
            this.panelDenpyouBangouSelector.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelDenpyouBangouSelector.Name = "panelDenpyouBangouSelector";
            this.panelDenpyouBangouSelector.Size = new System.Drawing.Size(506, 100);
            this.panelDenpyouBangouSelector.TabIndex = 23;
            // 
            // txtEndBangou
            // 
            this.txtEndBangou.Location = new System.Drawing.Point(402, 54);
            this.txtEndBangou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEndBangou.Name = "txtEndBangou";
            this.txtEndBangou.Size = new System.Drawing.Size(92, 28);
            this.txtEndBangou.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.label7.Location = new System.Drawing.Point(293, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "開始番号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.label8.Location = new System.Drawing.Point(293, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "終了番号";
            // 
            // txtStartBangou
            // 
            this.txtStartBangou.Location = new System.Drawing.Point(402, 10);
            this.txtStartBangou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtStartBangou.Name = "txtStartBangou";
            this.txtStartBangou.Size = new System.Drawing.Size(92, 28);
            this.txtStartBangou.TabIndex = 5;
            // 
            // chkOnlyCheckedDenpyouPrint
            // 
            this.chkOnlyCheckedDenpyouPrint.AutoSize = true;
            this.chkOnlyCheckedDenpyouPrint.Location = new System.Drawing.Point(499, 56);
            this.chkOnlyCheckedDenpyouPrint.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkOnlyCheckedDenpyouPrint.Name = "chkOnlyCheckedDenpyouPrint";
            this.chkOnlyCheckedDenpyouPrint.Size = new System.Drawing.Size(243, 25);
            this.chkOnlyCheckedDenpyouPrint.TabIndex = 17;
            this.chkOnlyCheckedDenpyouPrint.Text = "チェックした伝票のみ印刷";
            this.chkOnlyCheckedDenpyouPrint.UseVisualStyleBackColor = true;
            // 
            // chkNikki
            // 
            this.chkNikki.AutoSize = true;
            this.chkNikki.Location = new System.Drawing.Point(46, 94);
            this.chkNikki.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkNikki.Name = "chkNikki";
            this.chkNikki.Size = new System.Drawing.Size(141, 25);
            this.chkNikki.TabIndex = 1;
            this.chkNikki.Text = "仕訳日記帳";
            this.chkNikki.UseVisualStyleBackColor = true;
            // 
            // chkDenpyou
            // 
            this.chkDenpyou.AutoSize = true;
            this.chkDenpyou.Location = new System.Drawing.Point(46, 56);
            this.chkDenpyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkDenpyou.Name = "chkDenpyou";
            this.chkDenpyou.Size = new System.Drawing.Size(120, 25);
            this.chkDenpyou.TabIndex = 0;
            this.chkDenpyou.Text = "仕訳伝票";
            this.chkDenpyou.UseVisualStyleBackColor = true;
            this.chkDenpyou.CheckedChanged += new System.EventHandler(this.chkDenpyou_CheckedChanged);
            // 
            // groupDenpyouPrintMethod
            // 
            this.groupDenpyouPrintMethod.Controls.Add(this.radioDenpyouBangou);
            this.groupDenpyouPrintMethod.Controls.Add(this.radioKoushinbi);
            this.groupDenpyouPrintMethod.Controls.Add(this.radioTourokubi);
            this.groupDenpyouPrintMethod.Controls.Add(this.radioKihyoubi);
            this.groupDenpyouPrintMethod.Location = new System.Drawing.Point(295, 56);
            this.groupDenpyouPrintMethod.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupDenpyouPrintMethod.Name = "groupDenpyouPrintMethod";
            this.groupDenpyouPrintMethod.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupDenpyouPrintMethod.Size = new System.Drawing.Size(182, 203);
            this.groupDenpyouPrintMethod.TabIndex = 3;
            this.groupDenpyouPrintMethod.TabStop = false;
            // 
            // radioDenpyouBangou
            // 
            this.radioDenpyouBangou.AutoSize = true;
            this.radioDenpyouBangou.Location = new System.Drawing.Point(29, 147);
            this.radioDenpyouBangou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioDenpyouBangou.Name = "radioDenpyouBangou";
            this.radioDenpyouBangou.Size = new System.Drawing.Size(119, 25);
            this.radioDenpyouBangou.TabIndex = 3;
            this.radioDenpyouBangou.TabStop = true;
            this.radioDenpyouBangou.Text = "伝票番号";
            this.radioDenpyouBangou.UseVisualStyleBackColor = true;
            this.radioDenpyouBangou.CheckedChanged += new System.EventHandler(this.radioDenpyouBangou_CheckedChanged);
            // 
            // radioKoushinbi
            // 
            this.radioKoushinbi.AutoSize = true;
            this.radioKoushinbi.Location = new System.Drawing.Point(29, 108);
            this.radioKoushinbi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioKoushinbi.Name = "radioKoushinbi";
            this.radioKoushinbi.Size = new System.Drawing.Size(98, 25);
            this.radioKoushinbi.TabIndex = 2;
            this.radioKoushinbi.TabStop = true;
            this.radioKoushinbi.Text = "更新日";
            this.radioKoushinbi.UseVisualStyleBackColor = true;
            // 
            // radioTourokubi
            // 
            this.radioTourokubi.AutoSize = true;
            this.radioTourokubi.Location = new System.Drawing.Point(29, 70);
            this.radioTourokubi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioTourokubi.Name = "radioTourokubi";
            this.radioTourokubi.Size = new System.Drawing.Size(98, 25);
            this.radioTourokubi.TabIndex = 1;
            this.radioTourokubi.TabStop = true;
            this.radioTourokubi.Text = "登録日";
            this.radioTourokubi.UseVisualStyleBackColor = true;
            // 
            // radioKihyoubi
            // 
            this.radioKihyoubi.AutoSize = true;
            this.radioKihyoubi.Location = new System.Drawing.Point(29, 32);
            this.radioKihyoubi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioKihyoubi.Name = "radioKihyoubi";
            this.radioKihyoubi.Size = new System.Drawing.Size(98, 25);
            this.radioKihyoubi.TabIndex = 0;
            this.radioKihyoubi.TabStop = true;
            this.radioKihyoubi.Text = "起票日";
            this.radioKihyoubi.UseVisualStyleBackColor = true;
            // 
            // lblPrintMethodCaption
            // 
            this.lblPrintMethodCaption.AutoSize = true;
            this.lblPrintMethodCaption.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.lblPrintMethodCaption.Location = new System.Drawing.Point(308, 30);
            this.lblPrintMethodCaption.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrintMethodCaption.Name = "lblPrintMethodCaption";
            this.lblPrintMethodCaption.Size = new System.Drawing.Size(94, 21);
            this.lblPrintMethodCaption.TabIndex = 13;
            this.lblPrintMethodCaption.Text = "印刷方法";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(486, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "伝票・日記帳";
            // 
            // panelKessan
            // 
            this.panelKessan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelKessan.Controls.Add(this.groupBox2);
            this.panelKessan.Controls.Add(this.groupBox1);
            this.panelKessan.Controls.Add(this.chkTyuuki);
            this.panelKessan.Controls.Add(this.chkHikiatekinMeisai);
            this.panelKessan.Controls.Add(this.chkKoteiShisanMeisai);
            this.panelKessan.Controls.Add(this.chkGoukeiZandakaHojokamoku);
            this.panelKessan.Controls.Add(this.label12);
            this.panelKessan.Controls.Add(this.chkTaisyakuTaisyou);
            this.panelKessan.Controls.Add(this.chkGoukeiZandakaChukubunOnly);
            this.panelKessan.Controls.Add(this.chkJigyouUchiwake);
            this.panelKessan.Controls.Add(this.chkJigyouKeisan);
            this.panelKessan.Controls.Add(this.chkShikinKeisanHosei);
            this.panelKessan.Controls.Add(this.chkShikinUchiwake);
            this.panelKessan.Controls.Add(this.chkShikinKeisan);
            this.panelKessan.Controls.Add(this.chkKessanHyoushi);
            this.panelKessan.Location = new System.Drawing.Point(22, 452);
            this.panelKessan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelKessan.Name = "panelKessan";
            this.panelKessan.Size = new System.Drawing.Size(1471, 361);
            this.panelKessan.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkOmitZeroRow);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbKamokuHierarchy);
            this.groupBox2.Location = new System.Drawing.Point(831, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Size = new System.Drawing.Size(270, 187);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出力オプション";
            // 
            // chkOmitZeroRow
            // 
            this.chkOmitZeroRow.AutoSize = true;
            this.chkOmitZeroRow.Location = new System.Drawing.Point(15, 136);
            this.chkOmitZeroRow.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkOmitZeroRow.Name = "chkOmitZeroRow";
            this.chkOmitZeroRow.Size = new System.Drawing.Size(217, 25);
            this.chkOmitZeroRow.TabIndex = 36;
            this.chkOmitZeroRow.Text = "０円の行を表示しない";
            this.chkOmitZeroRow.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(11, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "印刷対象の科目階層";
            // 
            // cmbKamokuHierarchy
            // 
            this.cmbKamokuHierarchy.FormattingEnabled = true;
            this.cmbKamokuHierarchy.Location = new System.Drawing.Point(15, 70);
            this.cmbKamokuHierarchy.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKamokuHierarchy.Name = "cmbKamokuHierarchy";
            this.cmbKamokuHierarchy.Size = new System.Drawing.Size(219, 29);
            this.cmbKamokuHierarchy.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkHideTyuuki10);
            this.groupBox1.Controls.Add(this.chkHideTyuuki9);
            this.groupBox1.Controls.Add(this.chkHideTyuuki3);
            this.groupBox1.Controls.Add(this.chkHideTyuuki1);
            this.groupBox1.Location = new System.Drawing.Point(1100, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(354, 187);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "注記の非表示項目";
            // 
            // chkHideTyuuki10
            // 
            this.chkHideTyuuki10.AutoSize = true;
            this.chkHideTyuuki10.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkHideTyuuki10.Location = new System.Drawing.Point(28, 147);
            this.chkHideTyuuki10.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkHideTyuuki10.Name = "chkHideTyuuki10";
            this.chkHideTyuuki10.Size = new System.Drawing.Size(156, 24);
            this.chkHideTyuuki10.TabIndex = 33;
            this.chkHideTyuuki10.Text = "１０．債権額等";
            this.chkHideTyuuki10.UseVisualStyleBackColor = true;
            // 
            // chkHideTyuuki9
            // 
            this.chkHideTyuuki9.AutoSize = true;
            this.chkHideTyuuki9.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkHideTyuuki9.Location = new System.Drawing.Point(28, 108);
            this.chkHideTyuuki9.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkHideTyuuki9.Name = "chkHideTyuuki9";
            this.chkHideTyuuki9.Size = new System.Drawing.Size(258, 24);
            this.chkHideTyuuki9.TabIndex = 32;
            this.chkHideTyuuki9.Text = "９．固定資産の取得価額等";
            this.chkHideTyuuki9.UseVisualStyleBackColor = true;
            // 
            // chkHideTyuuki3
            // 
            this.chkHideTyuuki3.AutoSize = true;
            this.chkHideTyuuki3.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkHideTyuuki3.Location = new System.Drawing.Point(28, 70);
            this.chkHideTyuuki3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkHideTyuuki3.Name = "chkHideTyuuki3";
            this.chkHideTyuuki3.Size = new System.Drawing.Size(255, 24);
            this.chkHideTyuuki3.TabIndex = 31;
            this.chkHideTyuuki3.Text = "３．重要な会計方針の変更";
            this.chkHideTyuuki3.UseVisualStyleBackColor = true;
            // 
            // chkHideTyuuki1
            // 
            this.chkHideTyuuki1.AutoSize = true;
            this.chkHideTyuuki1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkHideTyuuki1.Location = new System.Drawing.Point(28, 32);
            this.chkHideTyuuki1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkHideTyuuki1.Name = "chkHideTyuuki1";
            this.chkHideTyuuki1.Size = new System.Drawing.Size(306, 24);
            this.chkHideTyuuki1.TabIndex = 30;
            this.chkHideTyuuki1.Text = "１．継続事業の全体に関する注記";
            this.chkHideTyuuki1.UseVisualStyleBackColor = true;
            // 
            // chkTyuuki
            // 
            this.chkTyuuki.AutoSize = true;
            this.chkTyuuki.Location = new System.Drawing.Point(391, 273);
            this.chkTyuuki.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkTyuuki.Name = "chkTyuuki";
            this.chkTyuuki.Size = new System.Drawing.Size(78, 25);
            this.chkTyuuki.TabIndex = 28;
            this.chkTyuuki.Text = "注記";
            this.chkTyuuki.UseVisualStyleBackColor = true;
            // 
            // chkHikiatekinMeisai
            // 
            this.chkHikiatekinMeisai.AutoSize = true;
            this.chkHikiatekinMeisai.Location = new System.Drawing.Point(391, 228);
            this.chkHikiatekinMeisai.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkHikiatekinMeisai.Name = "chkHikiatekinMeisai";
            this.chkHikiatekinMeisai.Size = new System.Drawing.Size(162, 25);
            this.chkHikiatekinMeisai.TabIndex = 27;
            this.chkHikiatekinMeisai.Text = "引当金明細書";
            this.chkHikiatekinMeisai.UseVisualStyleBackColor = true;
            // 
            // chkKoteiShisanMeisai
            // 
            this.chkKoteiShisanMeisai.AutoSize = true;
            this.chkKoteiShisanMeisai.Location = new System.Drawing.Point(391, 182);
            this.chkKoteiShisanMeisai.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkKoteiShisanMeisai.Name = "chkKoteiShisanMeisai";
            this.chkKoteiShisanMeisai.Size = new System.Drawing.Size(200, 25);
            this.chkKoteiShisanMeisai.TabIndex = 9;
            this.chkKoteiShisanMeisai.Text = "固定資産の明細書";
            this.chkKoteiShisanMeisai.UseVisualStyleBackColor = true;
            // 
            // chkGoukeiZandakaHojokamoku
            // 
            this.chkGoukeiZandakaHojokamoku.AutoSize = true;
            this.chkGoukeiZandakaHojokamoku.Location = new System.Drawing.Point(391, 91);
            this.chkGoukeiZandakaHojokamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkGoukeiZandakaHojokamoku.Name = "chkGoukeiZandakaHojokamoku";
            this.chkGoukeiZandakaHojokamoku.Size = new System.Drawing.Size(404, 25);
            this.chkGoukeiZandakaHojokamoku.TabIndex = 7;
            this.chkGoukeiZandakaHojokamoku.Text = "合計残高試算表（小区分、補助科目含む）";
            this.chkGoukeiZandakaHojokamoku.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(1100, 273);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(7);
            this.label12.Size = new System.Drawing.Size(339, 58);
            this.label12.TabIndex = 26;
            this.label12.Text = "※合計残高試算表（精算表）の\r\n　　印刷時は各月を指定してください。";
            // 
            // chkTaisyakuTaisyou
            // 
            this.chkTaisyakuTaisyou.AutoSize = true;
            this.chkTaisyakuTaisyou.Location = new System.Drawing.Point(391, 136);
            this.chkTaisyakuTaisyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkTaisyakuTaisyou.Name = "chkTaisyakuTaisyou";
            this.chkTaisyakuTaisyou.Size = new System.Drawing.Size(141, 25);
            this.chkTaisyakuTaisyou.TabIndex = 8;
            this.chkTaisyakuTaisyou.Text = "貸借対照表";
            this.chkTaisyakuTaisyou.UseVisualStyleBackColor = true;
            // 
            // chkGoukeiZandakaChukubunOnly
            // 
            this.chkGoukeiZandakaChukubunOnly.AutoSize = true;
            this.chkGoukeiZandakaChukubunOnly.Location = new System.Drawing.Point(391, 46);
            this.chkGoukeiZandakaChukubunOnly.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkGoukeiZandakaChukubunOnly.Name = "chkGoukeiZandakaChukubunOnly";
            this.chkGoukeiZandakaChukubunOnly.Size = new System.Drawing.Size(268, 25);
            this.chkGoukeiZandakaChukubunOnly.TabIndex = 6;
            this.chkGoukeiZandakaChukubunOnly.Text = "合計残高試算表（精算表）";
            this.chkGoukeiZandakaChukubunOnly.UseVisualStyleBackColor = true;
            // 
            // chkJigyouUchiwake
            // 
            this.chkJigyouUchiwake.AutoSize = true;
            this.chkJigyouUchiwake.Location = new System.Drawing.Point(46, 273);
            this.chkJigyouUchiwake.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkJigyouUchiwake.Name = "chkJigyouUchiwake";
            this.chkJigyouUchiwake.Size = new System.Drawing.Size(225, 25);
            this.chkJigyouUchiwake.TabIndex = 5;
            this.chkJigyouUchiwake.Text = "事業活動収支内訳表";
            this.chkJigyouUchiwake.UseVisualStyleBackColor = true;
            // 
            // chkJigyouKeisan
            // 
            this.chkJigyouKeisan.AutoSize = true;
            this.chkJigyouKeisan.Location = new System.Drawing.Point(46, 228);
            this.chkJigyouKeisan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkJigyouKeisan.Name = "chkJigyouKeisan";
            this.chkJigyouKeisan.Size = new System.Drawing.Size(225, 25);
            this.chkJigyouKeisan.TabIndex = 4;
            this.chkJigyouKeisan.Text = "事業活動収支計算書";
            this.chkJigyouKeisan.UseVisualStyleBackColor = true;
            // 
            // chkShikinKeisanHosei
            // 
            this.chkShikinKeisanHosei.AutoSize = true;
            this.chkShikinKeisanHosei.Location = new System.Drawing.Point(46, 182);
            this.chkShikinKeisanHosei.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkShikinKeisanHosei.Name = "chkShikinKeisanHosei";
            this.chkShikinKeisanHosei.Size = new System.Drawing.Size(312, 25);
            this.chkShikinKeisanHosei.TabIndex = 3;
            this.chkShikinKeisanHosei.Text = "資金収支計算書（補正3回まで）";
            this.chkShikinKeisanHosei.UseVisualStyleBackColor = true;
            // 
            // chkShikinUchiwake
            // 
            this.chkShikinUchiwake.AutoSize = true;
            this.chkShikinUchiwake.Location = new System.Drawing.Point(46, 136);
            this.chkShikinUchiwake.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkShikinUchiwake.Name = "chkShikinUchiwake";
            this.chkShikinUchiwake.Size = new System.Drawing.Size(225, 25);
            this.chkShikinUchiwake.TabIndex = 2;
            this.chkShikinUchiwake.Text = "資金収支決算内訳表";
            this.chkShikinUchiwake.UseVisualStyleBackColor = true;
            // 
            // chkShikinKeisan
            // 
            this.chkShikinKeisan.AutoSize = true;
            this.chkShikinKeisan.Location = new System.Drawing.Point(46, 91);
            this.chkShikinKeisan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkShikinKeisan.Name = "chkShikinKeisan";
            this.chkShikinKeisan.Size = new System.Drawing.Size(183, 25);
            this.chkShikinKeisan.TabIndex = 1;
            this.chkShikinKeisan.Text = "資金収支計算書";
            this.chkShikinKeisan.UseVisualStyleBackColor = true;
            // 
            // chkKessanHyoushi
            // 
            this.chkKessanHyoushi.AutoSize = true;
            this.chkKessanHyoushi.Location = new System.Drawing.Point(46, 46);
            this.chkKessanHyoushi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkKessanHyoushi.Name = "chkKessanHyoushi";
            this.chkKessanHyoushi.Size = new System.Drawing.Size(141, 25);
            this.chkKessanHyoushi.TabIndex = 0;
            this.chkKessanHyoushi.Text = "決算書表紙";
            this.chkKessanHyoushi.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(50, 436);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "計算書類";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label10.Location = new System.Drawing.Point(882, 44);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(241, 26);
            this.label10.TabIndex = 24;
            this.label10.Text = "印刷対象の会計区分";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnPrintYosan);
            this.panel1.Controls.Add(this.btnPrintKoteiShisan);
            this.panel1.Controls.Add(this.btnPrintShisanhyou);
            this.panel1.Controls.Add(this.btnPrintMototyou);
            this.panel1.Location = new System.Drawing.Point(22, 868);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 112);
            this.panel1.TabIndex = 9;
            // 
            // btnPrintYosan
            // 
            this.btnPrintYosan.Location = new System.Drawing.Point(706, 37);
            this.btnPrintYosan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPrintYosan.Name = "btnPrintYosan";
            this.btnPrintYosan.Size = new System.Drawing.Size(202, 49);
            this.btnPrintYosan.TabIndex = 3;
            this.btnPrintYosan.Text = "予算の印刷(&E)";
            this.btnPrintYosan.UseVisualStyleBackColor = true;
            // 
            // btnPrintKoteiShisan
            // 
            this.btnPrintKoteiShisan.Enabled = false;
            this.btnPrintKoteiShisan.Location = new System.Drawing.Point(486, 37);
            this.btnPrintKoteiShisan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPrintKoteiShisan.Name = "btnPrintKoteiShisan";
            this.btnPrintKoteiShisan.Size = new System.Drawing.Size(202, 49);
            this.btnPrintKoteiShisan.TabIndex = 2;
            this.btnPrintKoteiShisan.Text = "固定資産の印刷(&F)";
            this.btnPrintKoteiShisan.UseVisualStyleBackColor = true;
            // 
            // btnPrintShisanhyou
            // 
            this.btnPrintShisanhyou.Enabled = false;
            this.btnPrintShisanhyou.Location = new System.Drawing.Point(266, 37);
            this.btnPrintShisanhyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPrintShisanhyou.Name = "btnPrintShisanhyou";
            this.btnPrintShisanhyou.Size = new System.Drawing.Size(202, 49);
            this.btnPrintShisanhyou.TabIndex = 1;
            this.btnPrintShisanhyou.Text = "試算表の印刷(&S)";
            this.btnPrintShisanhyou.UseVisualStyleBackColor = true;
            // 
            // btnPrintMototyou
            // 
            this.btnPrintMototyou.Location = new System.Drawing.Point(46, 37);
            this.btnPrintMototyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPrintMototyou.Name = "btnPrintMototyou";
            this.btnPrintMototyou.Size = new System.Drawing.Size(202, 49);
            this.btnPrintMototyou.TabIndex = 0;
            this.btnPrintMototyou.Text = "元帳の印刷(&M)";
            this.btnPrintMototyou.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(50, 852);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 28);
            this.label13.TabIndex = 31;
            this.label13.Text = "その他の印刷";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(997, 934);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(249, 49);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "印刷・ファイル出力(&P)";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1258, 934);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(202, 49);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "閉じる(&X)";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // chkCloseFormWhenExecPrint
            // 
            this.chkCloseFormWhenExecPrint.AutoSize = true;
            this.chkCloseFormWhenExecPrint.Location = new System.Drawing.Point(1045, 872);
            this.chkCloseFormWhenExecPrint.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkCloseFormWhenExecPrint.Name = "chkCloseFormWhenExecPrint";
            this.chkCloseFormWhenExecPrint.Size = new System.Drawing.Size(343, 25);
            this.chkCloseFormWhenExecPrint.TabIndex = 10;
            this.chkCloseFormWhenExecPrint.Text = "印刷ボタンクリック後この画面を閉じる";
            this.chkCloseFormWhenExecPrint.UseVisualStyleBackColor = true;
            // 
            // mtKaikeiKubun
            // 
            this.mtKaikeiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtKaikeiKubun.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.mtKaikeiKubun.FormattingEnabled = true;
            this.mtKaikeiKubun.Location = new System.Drawing.Point(1148, 38);
            this.mtKaikeiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mtKaikeiKubun.Name = "mtKaikeiKubun";
            this.mtKaikeiKubun.Size = new System.Drawing.Size(351, 34);
            this.mtKaikeiKubun.TabIndex = 32;
            // 
            // dateDenpyouBangou
            // 
            this.dateDenpyouBangou.AutoSize = true;
            this.dateDenpyouBangou.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateDenpyouBangou.BackColor = System.Drawing.Color.Transparent;
            this.dateDenpyouBangou.Date = null;
            this.dateDenpyouBangou.DayStr = "1";
            this.dateDenpyouBangou.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateDenpyouBangou.GengouStr = "";
            this.dateDenpyouBangou.Location = new System.Drawing.Point(20, 12);
            this.dateDenpyouBangou.Margin = new System.Windows.Forms.Padding(0);
            this.dateDenpyouBangou.MarginGengou2Year = 7;
            this.dateDenpyouBangou.MarginMonth2Day = 7;
            this.dateDenpyouBangou.MarginYear2Month = 7;
            this.dateDenpyouBangou.MonthStr = "";
            this.dateDenpyouBangou.Name = "dateDenpyouBangou";
            this.dateDenpyouBangou.Size = new System.Drawing.Size(224, 31);
            this.dateDenpyouBangou.TabIndex = 4;
            this.dateDenpyouBangou.TextBoxWidth = 69;
            this.dateDenpyouBangou.ViewType = KaikeiSystemBody.views.controls.DateInputPanel.ViewTypeEnum.WarekiYearMonth;
            this.dateDenpyouBangou.YearStr = "";
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
            this.dateEnd.Location = new System.Drawing.Point(530, 38);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(0);
            this.dateEnd.MarginGengou2Year = 11;
            this.dateEnd.MarginMonth2Day = 11;
            this.dateEnd.MarginYear2Month = 11;
            this.dateEnd.MonthStr = "";
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(313, 37);
            this.dateEnd.TabIndex = 2;
            this.dateEnd.TextBoxWidth = 69;
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
            this.dateStart.Location = new System.Drawing.Point(160, 38);
            this.dateStart.Margin = new System.Windows.Forms.Padding(0);
            this.dateStart.MarginGengou2Year = 11;
            this.dateStart.MarginMonth2Day = 11;
            this.dateStart.MarginYear2Month = 11;
            this.dateStart.MonthStr = "";
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(313, 37);
            this.dateStart.TabIndex = 1;
            this.dateStart.TextBoxWidth = 69;
            this.dateStart.YearStr = "";
            // 
            // PrintMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1527, 1026);
            this.Controls.Add(this.mtKaikeiKubun);
            this.Controls.Add(this.chkCloseFormWhenExecPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panelKessan);
            this.Controls.Add(this.panelDenpyou);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelMaster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "PrintMainForm";
            this.Text = "書式の選択";
            this.panelMaster.ResumeLayout(false);
            this.panelMaster.PerformLayout();
            this.groupKamokuType.ResumeLayout(false);
            this.groupKamokuType.PerformLayout();
            this.panelDenpyou.ResumeLayout(false);
            this.panelDenpyou.PerformLayout();
            this.panelDenpyouBangouSelector.ResumeLayout(false);
            this.panelDenpyouBangouSelector.PerformLayout();
            this.groupDenpyouPrintMethod.ResumeLayout(false);
            this.groupDenpyouPrintMethod.PerformLayout();
            this.panelKessan.ResumeLayout(false);
            this.panelKessan.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private controls.DateInputPanel dateStart;
        private controls.DateInputPanel dateEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMaster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupKamokuType;
        private System.Windows.Forms.RadioButton radioAllKamoku;
        private System.Windows.Forms.RadioButton radioUsableKamoku;
        private System.Windows.Forms.Panel panelDenpyou;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrintMethodCaption;
        private System.Windows.Forms.GroupBox groupDenpyouPrintMethod;
        private System.Windows.Forms.RadioButton radioTourokubi;
        private System.Windows.Forms.RadioButton radioKihyoubi;
        private System.Windows.Forms.RadioButton radioKoushinbi;
        private System.Windows.Forms.RadioButton radioDenpyouBangou;
        private System.Windows.Forms.CheckBox chkNikki;
        private System.Windows.Forms.CheckBox chkDenpyou;
        private System.Windows.Forms.CheckBox chkKamoku;
        private System.Windows.Forms.CheckBox chkTekiyou;
        private System.Windows.Forms.CheckBox chkOnlyCheckedDenpyouPrint;
        private System.Windows.Forms.TextBox txtStartBangou;
        private System.Windows.Forms.Label label7;
        private controls.DateInputPanel dateDenpyouBangou;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEndBangou;
        private System.Windows.Forms.Panel panelKessan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkKessanHyoushi;
        private System.Windows.Forms.CheckBox chkShikinKeisan;
        private System.Windows.Forms.CheckBox chkShikinUchiwake;
        private System.Windows.Forms.CheckBox chkShikinKeisanHosei;
        private System.Windows.Forms.CheckBox chkJigyouKeisan;
        private System.Windows.Forms.CheckBox chkJigyouUchiwake;
        private System.Windows.Forms.CheckBox chkGoukeiZandakaChukubunOnly;
        private System.Windows.Forms.CheckBox chkTaisyakuTaisyou;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnPrintMototyou;
        private System.Windows.Forms.Button btnPrintKoteiShisan;
        private System.Windows.Forms.Button btnPrintShisanhyou;
        private System.Windows.Forms.Button btnPrintYosan;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkCloseFormWhenExecPrint;
        private System.Windows.Forms.Panel panelDenpyouBangouSelector;
        private controls.MTComboBox mtKaikeiKubun;
        private System.Windows.Forms.CheckBox chkDenpyouForEachKamoku;
        private System.Windows.Forms.CheckBox chkGoukeiZandakaHojokamoku;
        private System.Windows.Forms.CheckBox chkKoteiShisanMeisai;
        private System.Windows.Forms.CheckBox chkHikiatekinMeisai;
        private System.Windows.Forms.CheckBox chkTyuuki;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkHideTyuuki10;
        private System.Windows.Forms.CheckBox chkHideTyuuki9;
        private System.Windows.Forms.CheckBox chkHideTyuuki3;
        private System.Windows.Forms.CheckBox chkHideTyuuki1;
        private System.Windows.Forms.ComboBox cmbKamokuHierarchy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkOmitZeroRow;
    }
}