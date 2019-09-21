namespace KaikeiSystemBody.views.popup
{
    partial class YosanKakuninPopup
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKamoku = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.yosanKamokuGrid = new KaikeiSystemBody.views.grid.YosanKamokuKakuninGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchKamoku = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYearForKamoku = new System.Windows.Forms.TextBox();
            this.cmbYosanKubunForKamoku = new KaikeiSystemBody.views.controls.MTComboBox();
            this.cmbKaikeiKubunForKamoku = new KaikeiSystemBody.views.controls.MTComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabHojoKamoku = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.yosanHojoGrid = new KaikeiSystemBody.views.grid.YosanHojoKakuninGrid();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchHojo = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtYearForHojo = new System.Windows.Forms.TextBox();
            this.cmbYosanKubunForHojo = new KaikeiSystemBody.views.controls.MTComboBox();
            this.cmbKaikeiKubunForHojo = new KaikeiSystemBody.views.controls.MTComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabKamoku.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabHojoKamoku.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKamoku);
            this.tabControl1.Controls.Add(this.tabHojoKamoku);
            this.tabControl1.Location = new System.Drawing.Point(22, 21);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1659, 1101);
            this.tabControl1.TabIndex = 0;
            // 
            // tabKamoku
            // 
            this.tabKamoku.BackColor = System.Drawing.SystemColors.Control;
            this.tabKamoku.Controls.Add(this.label11);
            this.tabKamoku.Controls.Add(this.label10);
            this.tabKamoku.Controls.Add(this.label9);
            this.tabKamoku.Controls.Add(this.label8);
            this.tabKamoku.Controls.Add(this.label7);
            this.tabKamoku.Controls.Add(this.label6);
            this.tabKamoku.Controls.Add(this.yosanKamokuGrid);
            this.tabKamoku.Controls.Add(this.groupBox1);
            this.tabKamoku.Controls.Add(this.label1);
            this.tabKamoku.Location = new System.Drawing.Point(4, 31);
            this.tabKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabKamoku.Name = "tabKamoku";
            this.tabKamoku.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabKamoku.Size = new System.Drawing.Size(1651, 1066);
            this.tabKamoku.TabIndex = 0;
            this.tabKamoku.Text = "中区分";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1018, 252);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "予算額";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(649, 252);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "科目";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(535, 252);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "補正回数";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 252);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "予算区分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "年度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "会計区分";
            // 
            // yosanKamokuGrid
            // 
            this.yosanKamokuGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yosanKamokuGrid.DataCount = 0;
            this.yosanKamokuGrid.Location = new System.Drawing.Point(2, 278);
            this.yosanKamokuGrid.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.yosanKamokuGrid.Name = "yosanKamokuGrid";
            this.yosanKamokuGrid.NewRowIsVisible = false;
            this.yosanKamokuGrid.Size = new System.Drawing.Size(1289, 776);
            this.yosanKamokuGrid.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchKamoku);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtYearForKamoku);
            this.groupBox1.Controls.Add(this.cmbYosanKubunForKamoku);
            this.groupBox1.Controls.Add(this.cmbKaikeiKubunForKamoku);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(172, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(891, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnSearchKamoku
            // 
            this.btnSearchKamoku.Location = new System.Drawing.Point(403, 93);
            this.btnSearchKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSearchKamoku.Name = "btnSearchKamoku";
            this.btnSearchKamoku.Size = new System.Drawing.Size(138, 40);
            this.btnSearchKamoku.TabIndex = 9;
            this.btnSearchKamoku.Text = "検索";
            this.btnSearchKamoku.UseVisualStyleBackColor = true;
            this.btnSearchKamoku.Click += new System.EventHandler(this.btnSearchKamoku_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(405, 42);
            this.label5.TabIndex = 8;
            this.label5.Text = "※年度の指定は「元号＋年」で入力してください\r\n　例）H18";
            // 
            // txtYearForKamoku
            // 
            this.txtYearForKamoku.Location = new System.Drawing.Point(138, 107);
            this.txtYearForKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtYearForKamoku.Name = "txtYearForKamoku";
            this.txtYearForKamoku.Size = new System.Drawing.Size(99, 28);
            this.txtYearForKamoku.TabIndex = 7;
            // 
            // cmbYosanKubunForKamoku
            // 
            this.cmbYosanKubunForKamoku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbYosanKubunForKamoku.FormattingEnabled = true;
            this.cmbYosanKubunForKamoku.Location = new System.Drawing.Point(138, 65);
            this.cmbYosanKubunForKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbYosanKubunForKamoku.Name = "cmbYosanKubunForKamoku";
            this.cmbYosanKubunForKamoku.Size = new System.Drawing.Size(143, 29);
            this.cmbYosanKubunForKamoku.TabIndex = 6;
            // 
            // cmbKaikeiKubunForKamoku
            // 
            this.cmbKaikeiKubunForKamoku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKaikeiKubunForKamoku.FormattingEnabled = true;
            this.cmbKaikeiKubunForKamoku.Location = new System.Drawing.Point(138, 21);
            this.cmbKaikeiKubunForKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKaikeiKubunForKamoku.Name = "cmbKaikeiKubunForKamoku";
            this.cmbKaikeiKubunForKamoku.Size = new System.Drawing.Size(204, 29);
            this.cmbKaikeiKubunForKamoku.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "年度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "予算区分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "会計区分";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "検索対象";
            // 
            // tabHojoKamoku
            // 
            this.tabHojoKamoku.BackColor = System.Drawing.SystemColors.Control;
            this.tabHojoKamoku.Controls.Add(this.label23);
            this.tabHojoKamoku.Controls.Add(this.label22);
            this.tabHojoKamoku.Controls.Add(this.label21);
            this.tabHojoKamoku.Controls.Add(this.label20);
            this.tabHojoKamoku.Controls.Add(this.label19);
            this.tabHojoKamoku.Controls.Add(this.yosanHojoGrid);
            this.tabHojoKamoku.Controls.Add(this.label18);
            this.tabHojoKamoku.Controls.Add(this.label17);
            this.tabHojoKamoku.Controls.Add(this.groupBox2);
            this.tabHojoKamoku.Controls.Add(this.label12);
            this.tabHojoKamoku.Location = new System.Drawing.Point(4, 31);
            this.tabHojoKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabHojoKamoku.Name = "tabHojoKamoku";
            this.tabHojoKamoku.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabHojoKamoku.Size = new System.Drawing.Size(1651, 1066);
            this.tabHojoKamoku.TabIndex = 1;
            this.tabHojoKamoku.Text = "小区分";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1360, 252);
            this.label23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 21);
            this.label23.TabIndex = 11;
            this.label23.Text = "予算額";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1016, 252);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 21);
            this.label22.TabIndex = 10;
            this.label22.Text = "補助科目";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(649, 252);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 21);
            this.label21.TabIndex = 9;
            this.label21.Text = "科目";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(535, 252);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 21);
            this.label20.TabIndex = 8;
            this.label20.Text = "補正回数";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(383, 252);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 21);
            this.label19.TabIndex = 7;
            this.label19.Text = "予算区分";
            // 
            // yosanHojoGrid
            // 
            this.yosanHojoGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yosanHojoGrid.DataCount = 0;
            this.yosanHojoGrid.Location = new System.Drawing.Point(2, 278);
            this.yosanHojoGrid.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.yosanHojoGrid.Name = "yosanHojoGrid";
            this.yosanHojoGrid.NewRowIsVisible = false;
            this.yosanHojoGrid.Size = new System.Drawing.Size(1636, 776);
            this.yosanHojoGrid.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(277, 252);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 21);
            this.label18.TabIndex = 5;
            this.label18.Text = "年度";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(55, 252);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 21);
            this.label17.TabIndex = 4;
            this.label17.Text = "会計区分";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchHojo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtYearForHojo);
            this.groupBox2.Controls.Add(this.cmbYosanKubunForHojo);
            this.groupBox2.Controls.Add(this.cmbKaikeiKubunForHojo);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(172, 47);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Size = new System.Drawing.Size(891, 154);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnSearchHojo
            // 
            this.btnSearchHojo.Location = new System.Drawing.Point(403, 93);
            this.btnSearchHojo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSearchHojo.Name = "btnSearchHojo";
            this.btnSearchHojo.Size = new System.Drawing.Size(138, 40);
            this.btnSearchHojo.TabIndex = 9;
            this.btnSearchHojo.Text = "検索";
            this.btnSearchHojo.UseVisualStyleBackColor = true;
            this.btnSearchHojo.Click += new System.EventHandler(this.btnSearchHojo_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(383, 26);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(405, 42);
            this.label13.TabIndex = 8;
            this.label13.Text = "※年度の指定は「元号＋年」で入力してください\r\n　例）H18";
            // 
            // txtYearForHojo
            // 
            this.txtYearForHojo.Location = new System.Drawing.Point(138, 107);
            this.txtYearForHojo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtYearForHojo.Name = "txtYearForHojo";
            this.txtYearForHojo.Size = new System.Drawing.Size(99, 28);
            this.txtYearForHojo.TabIndex = 7;
            // 
            // cmbYosanKubunForHojo
            // 
            this.cmbYosanKubunForHojo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbYosanKubunForHojo.FormattingEnabled = true;
            this.cmbYosanKubunForHojo.Location = new System.Drawing.Point(138, 65);
            this.cmbYosanKubunForHojo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbYosanKubunForHojo.Name = "cmbYosanKubunForHojo";
            this.cmbYosanKubunForHojo.Size = new System.Drawing.Size(143, 29);
            this.cmbYosanKubunForHojo.TabIndex = 6;
            // 
            // cmbKaikeiKubunForHojo
            // 
            this.cmbKaikeiKubunForHojo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKaikeiKubunForHojo.FormattingEnabled = true;
            this.cmbKaikeiKubunForHojo.Location = new System.Drawing.Point(138, 21);
            this.cmbKaikeiKubunForHojo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKaikeiKubunForHojo.Name = "cmbKaikeiKubunForHojo";
            this.cmbKaikeiKubunForHojo.Size = new System.Drawing.Size(204, 29);
            this.cmbKaikeiKubunForHojo.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 112);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 21);
            this.label14.TabIndex = 4;
            this.label14.Text = "年度";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 70);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 21);
            this.label15.TabIndex = 3;
            this.label15.Text = "予算区分";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 26);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 21);
            this.label16.TabIndex = 2;
            this.label16.Text = "会計区分";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(145, 21);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "検索対象";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1518, 1132);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "閉じる";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YosanKakuninPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1703, 1195);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "YosanKakuninPopup";
            this.ShowInTaskbar = false;
            this.Text = "予算データチェック";
            this.tabControl1.ResumeLayout(false);
            this.tabKamoku.ResumeLayout(false);
            this.tabKamoku.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabHojoKamoku.ResumeLayout(false);
            this.tabHojoKamoku.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKamoku;
        private System.Windows.Forms.TabPage tabHojoKamoku;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private controls.MTComboBox cmbKaikeiKubunForKamoku;
        private controls.MTComboBox cmbYosanKubunForKamoku;
        private System.Windows.Forms.TextBox txtYearForKamoku;
        private System.Windows.Forms.Button btnSearchKamoku;
        private System.Windows.Forms.Label label5;
        private grid.YosanKamokuKakuninGrid yosanKamokuGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchHojo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtYearForHojo;
        private controls.MTComboBox cmbYosanKubunForHojo;
        private controls.MTComboBox cmbKaikeiKubunForHojo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private grid.YosanHojoKakuninGrid yosanHojoGrid;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;

    }
}