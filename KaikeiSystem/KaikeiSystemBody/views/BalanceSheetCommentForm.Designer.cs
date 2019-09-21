namespace KaikeiSystemBody.views
{
    partial class BalanceSheetCommentForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateInput = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLine = new System.Windows.Forms.Panel();
            this.gridGenka = new KaikeiSystemBody.views.grid.BSCGenkaGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridKaikeiHoushin = new KaikeiSystemBody.views.grid.BSCKaikeiHoushinGrid();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtJuuyouKaikeiHoushinHenkou = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelLineZaisan = new System.Windows.Forms.Panel();
            this.gridZaisan = new KaikeiSystemBody.views.grid.BSCZaisanGrid();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gridTorikuzushi = new KaikeiSystemBody.views.grid.BSCTorikuzushiGrid();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gridTanpo = new KaikeiSystemBody.views.grid.BSCTanpoGrid();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.txtJuuyouKouhatsuJisyou = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.labelCurrentGengou = new System.Windows.Forms.Label();
            this.labelCurrentYear = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExec);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(1514, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(354, 19);
            this.btnExec.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(183, 49);
            this.btnExec.TabIndex = 4;
            this.btnExec.Text = "登録・検索";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(266, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "年";
            // 
            // dateInput
            // 
            this.dateInput.AutoSize = true;
            this.dateInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateInput.BackColor = System.Drawing.Color.Transparent;
            this.dateInput.Date = null;
            this.dateInput.DayStr = "1";
            this.dateInput.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateInput.GengouStr = "";
            this.dateInput.Location = new System.Drawing.Point(103, 23);
            this.dateInput.Margin = new System.Windows.Forms.Padding(0);
            this.dateInput.MarginGengou2Year = 11;
            this.dateInput.MarginMonth2Day = 11;
            this.dateInput.MarginYear2Month = 11;
            this.dateInput.MonthStr = "4";
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(153, 37);
            this.dateInput.TabIndex = 1;
            this.dateInput.TextBoxWidth = 69;
            this.dateInput.ViewType = KaikeiSystemBody.views.controls.DateInputPanel.ViewTypeEnum.WarekiYear;
            this.dateInput.YearStr = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "元号";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(22, 175);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1740, 735);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Size = new System.Drawing.Size(1732, 700);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "減価償却累計額・徴収不能金";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panelLine);
            this.panel1.Controls.Add(this.gridGenka);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(33, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 624);
            this.panel1.TabIndex = 4;
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.Black;
            this.panelLine.Location = new System.Drawing.Point(-4, 35);
            this.panelLine.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(1100, 2);
            this.panelLine.TabIndex = 4;
            // 
            // gridGenka
            // 
            this.gridGenka.DataCount = 0;
            this.gridGenka.Location = new System.Drawing.Point(0, 35);
            this.gridGenka.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.gridGenka.Name = "gridGenka";
            this.gridGenka.NewRowIsVisible = false;
            this.gridGenka.Size = new System.Drawing.Size(1100, 586);
            this.gridGenka.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "徴収不能金の額";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "会計区分";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "減価償却累計額";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage2.Size = new System.Drawing.Size(1732, 700);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "1.重要な会計方針";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.gridKaikeiHoushin);
            this.panel2.Location = new System.Drawing.Point(33, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1650, 624);
            this.panel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(289, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "重要な会計方針で表示する内容";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "重要な会計方針で表示する項目";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "整理番号";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1650, 2);
            this.panel3.TabIndex = 1;
            // 
            // gridKaikeiHoushin
            // 
            this.gridKaikeiHoushin.DataCount = 0;
            this.gridKaikeiHoushin.Location = new System.Drawing.Point(0, 35);
            this.gridKaikeiHoushin.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.gridKaikeiHoushin.Name = "gridKaikeiHoushin";
            this.gridKaikeiHoushin.NewRowIsVisible = false;
            this.gridKaikeiHoushin.Size = new System.Drawing.Size(1645, 584);
            this.gridKaikeiHoushin.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.txtJuuyouKaikeiHoushinHenkou);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1732, 700);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "2.重要な会計方針の変更";
            // 
            // txtJuuyouKaikeiHoushinHenkou
            // 
            this.txtJuuyouKaikeiHoushinHenkou.Location = new System.Drawing.Point(33, 32);
            this.txtJuuyouKaikeiHoushinHenkou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtJuuyouKaikeiHoushinHenkou.Multiline = true;
            this.txtJuuyouKaikeiHoushinHenkou.Name = "txtJuuyouKaikeiHoushinHenkou";
            this.txtJuuyouKaikeiHoushinHenkou.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJuuyouKaikeiHoushinHenkou.Size = new System.Drawing.Size(1084, 624);
            this.txtJuuyouKaikeiHoushinHenkou.TabIndex = 1;
            this.txtJuuyouKaikeiHoushinHenkou.Leave += new System.EventHandler(this.txtJuuyouKaikeiHoushinHenkou_Leave);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1732, 700);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "3.基本財産の増加";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.panelLineZaisan);
            this.panel4.Controls.Add(this.gridZaisan);
            this.panel4.Location = new System.Drawing.Point(33, 32);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1650, 624);
            this.panel4.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1388, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 21);
            this.label12.TabIndex = 5;
            this.label12.Text = "金額";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(988, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 21);
            this.label11.TabIndex = 4;
            this.label11.Text = "摘要";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "科目";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "会計区分";
            // 
            // panelLineZaisan
            // 
            this.panelLineZaisan.BackColor = System.Drawing.Color.Black;
            this.panelLineZaisan.Location = new System.Drawing.Point(0, 35);
            this.panelLineZaisan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelLineZaisan.Name = "panelLineZaisan";
            this.panelLineZaisan.Size = new System.Drawing.Size(1833, 2);
            this.panelLineZaisan.TabIndex = 1;
            // 
            // gridZaisan
            // 
            this.gridZaisan.DataCount = 0;
            this.gridZaisan.Location = new System.Drawing.Point(0, 35);
            this.gridZaisan.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.gridZaisan.Name = "gridZaisan";
            this.gridZaisan.NewRowIsVisible = false;
            this.gridZaisan.Size = new System.Drawing.Size(1650, 584);
            this.gridZaisan.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.panel5);
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1732, 700);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "4.基本金・積立金の取崩";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.gridTorikuzushi);
            this.panel5.Location = new System.Drawing.Point(33, 32);
            this.panel5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1650, 624);
            this.panel5.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(405, 7);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 21);
            this.label14.TabIndex = 3;
            this.label14.Text = "取崩しの内容";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "会計区分";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(0, 35);
            this.panel6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1650, 2);
            this.panel6.TabIndex = 1;
            // 
            // gridTorikuzushi
            // 
            this.gridTorikuzushi.DataCount = 0;
            this.gridTorikuzushi.Location = new System.Drawing.Point(0, 35);
            this.gridTorikuzushi.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.gridTorikuzushi.Name = "gridTorikuzushi";
            this.gridTorikuzushi.NewRowIsVisible = false;
            this.gridTorikuzushi.Size = new System.Drawing.Size(1645, 584);
            this.gridTorikuzushi.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.panel7);
            this.tabPage6.Location = new System.Drawing.Point(4, 31);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1732, 700);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "5.担保資産";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.gridTanpo);
            this.panel7.Location = new System.Drawing.Point(33, 32);
            this.panel7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1650, 624);
            this.panel7.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1382, 7);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 21);
            this.label18.TabIndex = 5;
            this.label18.Text = "金額";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(827, 7);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 21);
            this.label17.TabIndex = 4;
            this.label17.Text = "科目";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(403, 7);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 21);
            this.label16.TabIndex = 3;
            this.label16.Text = "担保区分";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 7);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "会計区分";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(0, 35);
            this.panel8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1833, 2);
            this.panel8.TabIndex = 1;
            // 
            // gridTanpo
            // 
            this.gridTanpo.DataCount = 0;
            this.gridTanpo.Location = new System.Drawing.Point(0, 35);
            this.gridTanpo.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.gridTanpo.Name = "gridTanpo";
            this.gridTanpo.NewRowIsVisible = false;
            this.gridTanpo.Size = new System.Drawing.Size(1645, 584);
            this.gridTanpo.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage7.Controls.Add(this.txtJuuyouKouhatsuJisyou);
            this.tabPage7.Location = new System.Drawing.Point(4, 31);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1732, 700);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "6.重要な後発事象";
            // 
            // txtJuuyouKouhatsuJisyou
            // 
            this.txtJuuyouKouhatsuJisyou.Location = new System.Drawing.Point(33, 32);
            this.txtJuuyouKouhatsuJisyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtJuuyouKouhatsuJisyou.Multiline = true;
            this.txtJuuyouKouhatsuJisyou.Name = "txtJuuyouKouhatsuJisyou";
            this.txtJuuyouKouhatsuJisyou.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJuuyouKouhatsuJisyou.Size = new System.Drawing.Size(1084, 624);
            this.txtJuuyouKouhatsuJisyou.TabIndex = 0;
            this.txtJuuyouKouhatsuJisyou.Leave += new System.EventHandler(this.txtJuuyouKouhatsuJisyou_Leave);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1579, 920);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(183, 49);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label19.Location = new System.Drawing.Point(53, 124);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 26);
            this.label19.TabIndex = 5;
            this.label19.Text = "元号";
            // 
            // labelCurrentGengou
            // 
            this.labelCurrentGengou.BackColor = System.Drawing.Color.White;
            this.labelCurrentGengou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCurrentGengou.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCurrentGengou.Location = new System.Drawing.Point(125, 121);
            this.labelCurrentGengou.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCurrentGengou.Name = "labelCurrentGengou";
            this.labelCurrentGengou.Size = new System.Drawing.Size(66, 34);
            this.labelCurrentGengou.TabIndex = 6;
            this.labelCurrentGengou.Text = "H";
            this.labelCurrentGengou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrentYear
            // 
            this.labelCurrentYear.BackColor = System.Drawing.Color.White;
            this.labelCurrentYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCurrentYear.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCurrentYear.Location = new System.Drawing.Point(204, 121);
            this.labelCurrentYear.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCurrentYear.Name = "labelCurrentYear";
            this.labelCurrentYear.Size = new System.Drawing.Size(66, 34);
            this.labelCurrentYear.TabIndex = 7;
            this.labelCurrentYear.Text = "23";
            this.labelCurrentYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label20.Location = new System.Drawing.Point(288, 124);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(399, 26);
            this.label20.TabIndex = 8;
            this.label20.Text = "年の貸借対照表の脚注・注記を表示";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(752, 117);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(570, 42);
            this.label21.TabIndex = 9;
            this.label21.Text = "　※ 1,2,6については各会計区分共通となります。";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BalanceSheetCommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1784, 998);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.labelCurrentYear);
            this.Controls.Add(this.labelCurrentGengou);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "BalanceSheetCommentForm";
            this.Text = "貸借対照表　脚注・注記";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private controls.DateInputPanel dateInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private grid.BSCGenkaGrid gridGenka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtJuuyouKaikeiHoushinHenkou;
        private System.Windows.Forms.Panel panel2;
        private grid.BSCKaikeiHoushinGrid gridKaikeiHoushin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private grid.BSCZaisanGrid gridZaisan;
        private System.Windows.Forms.Panel panelLineZaisan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private grid.BSCTorikuzushiGrid gridTorikuzushi;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel7;
        private grid.BSCTanpoGrid gridTanpo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtJuuyouKouhatsuJisyou;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelCurrentGengou;
        private System.Windows.Forms.Label labelCurrentYear;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}