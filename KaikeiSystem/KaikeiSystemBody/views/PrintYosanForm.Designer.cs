namespace KaikeiSystemBody.views
{
    partial class PrintYosanForm
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoseiKaisuu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrentYearHoseiKaisuuMsg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkYosanJissekiTaihi = new System.Windows.Forms.CheckBox();
            this.chkYosanUchiwake = new System.Windows.Forms.CheckBox();
            this.chkHoseiYosan = new System.Windows.Forms.CheckBox();
            this.chkSyuusiYosan = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.radioSelectedKeiriKubun = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelPrintDate = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datePrint = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.chkAddDate = new System.Windows.Forms.CheckBox();
            this.lblLastYearHoseiKaisuuMsg = new System.Windows.Forms.Label();
            this.dateLastYear = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.dateCurrentYear = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.chkOmitZeroRow = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelPrintDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "今年度";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(546, 523);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(202, 49);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "印刷(&P)";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(761, 523);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(202, 49);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "閉じる(&X)";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "前年度";
            // 
            // txtHoseiKaisuu
            // 
            this.txtHoseiKaisuu.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.txtHoseiKaisuu.Location = new System.Drawing.Point(149, 122);
            this.txtHoseiKaisuu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtHoseiKaisuu.Name = "txtHoseiKaisuu";
            this.txtHoseiKaisuu.Size = new System.Drawing.Size(83, 33);
            this.txtHoseiKaisuu.TabIndex = 2;
            this.txtHoseiKaisuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(94, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "第";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(246, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "回補正予算まで";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(143, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "（「0」の時は通常予算のみ）";
            // 
            // lblCurrentYearHoseiKaisuuMsg
            // 
            this.lblCurrentYearHoseiKaisuuMsg.AutoSize = true;
            this.lblCurrentYearHoseiKaisuuMsg.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.lblCurrentYearHoseiKaisuuMsg.ForeColor = System.Drawing.Color.Blue;
            this.lblCurrentYearHoseiKaisuuMsg.Location = new System.Drawing.Point(39, 220);
            this.lblCurrentYearHoseiKaisuuMsg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCurrentYearHoseiKaisuuMsg.Name = "lblCurrentYearHoseiKaisuuMsg";
            this.lblCurrentYearHoseiKaisuuMsg.Size = new System.Drawing.Size(382, 21);
            this.lblCurrentYearHoseiKaisuuMsg.TabIndex = 18;
            this.lblCurrentYearHoseiKaisuuMsg.Text = "H23年度は6回の補正予算がくまれています。";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkYosanJissekiTaihi);
            this.groupBox1.Controls.Add(this.chkYosanUchiwake);
            this.groupBox1.Controls.Add(this.chkHoseiYosan);
            this.groupBox1.Controls.Add(this.chkSyuusiYosan);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.groupBox1.Location = new System.Drawing.Point(61, 318);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(330, 254);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "印刷する書式";
            // 
            // chkYosanJissekiTaihi
            // 
            this.chkYosanJissekiTaihi.AutoSize = true;
            this.chkYosanJissekiTaihi.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.chkYosanJissekiTaihi.Location = new System.Drawing.Point(55, 182);
            this.chkYosanJissekiTaihi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkYosanJissekiTaihi.Name = "chkYosanJissekiTaihi";
            this.chkYosanJissekiTaihi.Size = new System.Drawing.Size(220, 30);
            this.chkYosanJissekiTaihi.TabIndex = 3;
            this.chkYosanJissekiTaihi.Text = "予算実績対比表";
            this.chkYosanJissekiTaihi.UseVisualStyleBackColor = true;
            // 
            // chkYosanUchiwake
            // 
            this.chkYosanUchiwake.AutoSize = true;
            this.chkYosanUchiwake.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.chkYosanUchiwake.Location = new System.Drawing.Point(55, 138);
            this.chkYosanUchiwake.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkYosanUchiwake.Name = "chkYosanUchiwake";
            this.chkYosanUchiwake.Size = new System.Drawing.Size(168, 30);
            this.chkYosanUchiwake.TabIndex = 2;
            this.chkYosanUchiwake.Text = "予算内訳書";
            this.chkYosanUchiwake.UseVisualStyleBackColor = true;
            // 
            // chkHoseiYosan
            // 
            this.chkHoseiYosan.AutoSize = true;
            this.chkHoseiYosan.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.chkHoseiYosan.Location = new System.Drawing.Point(55, 94);
            this.chkHoseiYosan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkHoseiYosan.Name = "chkHoseiYosan";
            this.chkHoseiYosan.Size = new System.Drawing.Size(168, 30);
            this.chkHoseiYosan.TabIndex = 1;
            this.chkHoseiYosan.Text = "補正予算書";
            this.chkHoseiYosan.UseVisualStyleBackColor = true;
            // 
            // chkSyuusiYosan
            // 
            this.chkSyuusiYosan.AutoSize = true;
            this.chkSyuusiYosan.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.chkSyuusiYosan.Location = new System.Drawing.Point(55, 51);
            this.chkSyuusiYosan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkSyuusiYosan.Name = "chkSyuusiYosan";
            this.chkSyuusiYosan.Size = new System.Drawing.Size(168, 30);
            this.chkSyuusiYosan.TabIndex = 0;
            this.chkSyuusiYosan.Text = "収支予算書";
            this.chkSyuusiYosan.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtKaikeiKubun);
            this.groupBox2.Controls.Add(this.radioSelectedKeiriKubun);
            this.groupBox2.Controls.Add(this.radioAll);
            this.groupBox2.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.groupBox2.Location = new System.Drawing.Point(521, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Size = new System.Drawing.Size(442, 196);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "印刷対象";
            // 
            // mtKaikeiKubun
            // 
            this.mtKaikeiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtKaikeiKubun.FormattingEnabled = true;
            this.mtKaikeiKubun.Location = new System.Drawing.Point(31, 117);
            this.mtKaikeiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mtKaikeiKubun.Name = "mtKaikeiKubun";
            this.mtKaikeiKubun.Size = new System.Drawing.Size(330, 34);
            this.mtKaikeiKubun.TabIndex = 2;
            // 
            // radioSelectedKeiriKubun
            // 
            this.radioSelectedKeiriKubun.AutoSize = true;
            this.radioSelectedKeiriKubun.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.radioSelectedKeiriKubun.Location = new System.Drawing.Point(158, 60);
            this.radioSelectedKeiriKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioSelectedKeiriKubun.Name = "radioSelectedKeiriKubun";
            this.radioSelectedKeiriKubun.Size = new System.Drawing.Size(192, 25);
            this.radioSelectedKeiriKubun.TabIndex = 1;
            this.radioSelectedKeiriKubun.TabStop = true;
            this.radioSelectedKeiriKubun.Text = "指定した会計区分";
            this.radioSelectedKeiriKubun.UseVisualStyleBackColor = true;
            this.radioSelectedKeiriKubun.CheckedChanged += new System.EventHandler(this.radioSelectedKeiriKubun_CheckedChanged);
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.radioAll.Location = new System.Drawing.Point(31, 60);
            this.radioAll.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(86, 25);
            this.radioAll.TabIndex = 0;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "すべて";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panelPrintDate);
            this.groupBox3.Controls.Add(this.chkAddDate);
            this.groupBox3.Location = new System.Drawing.Point(521, 262);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Size = new System.Drawing.Size(442, 164);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // panelPrintDate
            // 
            this.panelPrintDate.Controls.Add(this.label8);
            this.panelPrintDate.Controls.Add(this.label7);
            this.panelPrintDate.Controls.Add(this.label6);
            this.panelPrintDate.Controls.Add(this.datePrint);
            this.panelPrintDate.Location = new System.Drawing.Point(11, 91);
            this.panelPrintDate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelPrintDate.Name = "panelPrintDate";
            this.panelPrintDate.Size = new System.Drawing.Size(420, 63);
            this.panelPrintDate.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(372, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 26);
            this.label8.TabIndex = 26;
            this.label8.Text = "日";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(264, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 26);
            this.label7.TabIndex = 25;
            this.label7.Text = "月";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(158, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 26);
            this.label6.TabIndex = 24;
            this.label6.Text = "年";
            // 
            // datePrint
            // 
            this.datePrint.AutoSize = true;
            this.datePrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.datePrint.BackColor = System.Drawing.Color.Transparent;
            this.datePrint.Date = null;
            this.datePrint.DayStr = "";
            this.datePrint.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.datePrint.GengouStr = "";
            this.datePrint.Location = new System.Drawing.Point(20, 7);
            this.datePrint.Margin = new System.Windows.Forms.Padding(0);
            this.datePrint.MarginGengou2Year = 11;
            this.datePrint.MarginMonth2Day = 44;
            this.datePrint.MarginYear2Month = 44;
            this.datePrint.MonthStr = "";
            this.datePrint.Name = "datePrint";
            this.datePrint.Size = new System.Drawing.Size(351, 37);
            this.datePrint.TabIndex = 24;
            this.datePrint.TextBoxWidth = 62;
            this.datePrint.YearStr = "";
            // 
            // chkAddDate
            // 
            this.chkAddDate.AutoSize = true;
            this.chkAddDate.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.chkAddDate.Location = new System.Drawing.Point(31, 32);
            this.chkAddDate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkAddDate.Name = "chkAddDate";
            this.chkAddDate.Size = new System.Drawing.Size(302, 30);
            this.chkAddDate.TabIndex = 0;
            this.chkAddDate.Text = "予算書に日付を印刷する";
            this.chkAddDate.UseVisualStyleBackColor = true;
            this.chkAddDate.CheckedChanged += new System.EventHandler(this.chkPrintDate_CheckedChanged);
            // 
            // lblLastYearHoseiKaisuuMsg
            // 
            this.lblLastYearHoseiKaisuuMsg.AutoSize = true;
            this.lblLastYearHoseiKaisuuMsg.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.lblLastYearHoseiKaisuuMsg.ForeColor = System.Drawing.Color.Blue;
            this.lblLastYearHoseiKaisuuMsg.Location = new System.Drawing.Point(40, 256);
            this.lblLastYearHoseiKaisuuMsg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastYearHoseiKaisuuMsg.Name = "lblLastYearHoseiKaisuuMsg";
            this.lblLastYearHoseiKaisuuMsg.Size = new System.Drawing.Size(382, 21);
            this.lblLastYearHoseiKaisuuMsg.TabIndex = 19;
            this.lblLastYearHoseiKaisuuMsg.Text = "H23年度は6回の補正予算がくまれています。";
            // 
            // dateLastYear
            // 
            this.dateLastYear.AutoSize = true;
            this.dateLastYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateLastYear.BackColor = System.Drawing.Color.Transparent;
            this.dateLastYear.Date = null;
            this.dateLastYear.DayStr = "1";
            this.dateLastYear.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateLastYear.GengouStr = "";
            this.dateLastYear.Location = new System.Drawing.Point(149, 70);
            this.dateLastYear.Margin = new System.Windows.Forms.Padding(0);
            this.dateLastYear.MarginGengou2Year = 11;
            this.dateLastYear.MarginMonth2Day = 11;
            this.dateLastYear.MarginYear2Month = 11;
            this.dateLastYear.MonthStr = "4";
            this.dateLastYear.Name = "dateLastYear";
            this.dateLastYear.Size = new System.Drawing.Size(153, 37);
            this.dateLastYear.TabIndex = 1;
            this.dateLastYear.TextBoxWidth = 69;
            this.dateLastYear.ViewType = KaikeiSystemBody.views.controls.DateInputPanel.ViewTypeEnum.WarekiYear;
            this.dateLastYear.YearStr = "";
            // 
            // dateCurrentYear
            // 
            this.dateCurrentYear.AutoSize = true;
            this.dateCurrentYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateCurrentYear.BackColor = System.Drawing.Color.Transparent;
            this.dateCurrentYear.Date = null;
            this.dateCurrentYear.DayStr = "1";
            this.dateCurrentYear.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateCurrentYear.GengouStr = "";
            this.dateCurrentYear.Location = new System.Drawing.Point(149, 24);
            this.dateCurrentYear.Margin = new System.Windows.Forms.Padding(0);
            this.dateCurrentYear.MarginGengou2Year = 11;
            this.dateCurrentYear.MarginMonth2Day = 11;
            this.dateCurrentYear.MarginYear2Month = 11;
            this.dateCurrentYear.MonthStr = "4";
            this.dateCurrentYear.Name = "dateCurrentYear";
            this.dateCurrentYear.Size = new System.Drawing.Size(153, 37);
            this.dateCurrentYear.TabIndex = 0;
            this.dateCurrentYear.TextBoxWidth = 69;
            this.dateCurrentYear.ViewType = KaikeiSystemBody.views.controls.DateInputPanel.ViewTypeEnum.WarekiYear;
            this.dateCurrentYear.YearStr = "";
            // 
            // chkOmitZeroRow
            // 
            this.chkOmitZeroRow.AutoSize = true;
            this.chkOmitZeroRow.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkOmitZeroRow.Location = new System.Drawing.Point(552, 457);
            this.chkOmitZeroRow.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkOmitZeroRow.Name = "chkOmitZeroRow";
            this.chkOmitZeroRow.Size = new System.Drawing.Size(267, 31);
            this.chkOmitZeroRow.TabIndex = 20;
            this.chkOmitZeroRow.Text = "0円の行を表示しない";
            this.chkOmitZeroRow.UseVisualStyleBackColor = true;
            // 
            // PrintYosanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1016, 616);
            this.Controls.Add(this.chkOmitZeroRow);
            this.Controls.Add(this.lblLastYearHoseiKaisuuMsg);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCurrentYearHoseiKaisuuMsg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoseiKaisuu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dateLastYear);
            this.Controls.Add(this.dateCurrentYear);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "PrintYosanForm";
            this.Text = "予算印刷";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelPrintDate.ResumeLayout(false);
            this.panelPrintDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private controls.DateInputPanel dateCurrentYear;
        private controls.DateInputPanel dateLastYear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoseiKaisuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrentYearHoseiKaisuuMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSyuusiYosan;
        private System.Windows.Forms.CheckBox chkHoseiYosan;
        private System.Windows.Forms.CheckBox chkYosanUchiwake;
        private System.Windows.Forms.CheckBox chkYosanJissekiTaihi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radioSelectedKeiriKubun;
        private controls.MTComboBox mtKaikeiKubun;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkAddDate;
        private controls.DateInputPanel datePrint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelPrintDate;
        private System.Windows.Forms.Label lblLastYearHoseiKaisuuMsg;
        private System.Windows.Forms.CheckBox chkOmitZeroRow;
    }
}