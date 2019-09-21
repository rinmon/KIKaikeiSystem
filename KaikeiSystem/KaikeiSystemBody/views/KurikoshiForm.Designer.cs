namespace KaikeiSystemBody.views
{
    partial class KurikoshiForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.pnlDaikubunYosanBase = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLineDaikubun = new System.Windows.Forms.Panel();
            this.daikubunGrid = new KaikeiSystemBody.views.grid.ZenkiKurikoshiKamokuKubunGrid();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlKamokuYosanBase = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chukubunGrid = new KaikeiSystemBody.views.grid.ZenkiKurikoshiKamokuKubunGrid();
            this.label14 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.pnlHojoKamokuYosanBase = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.syoukubunGrid = new KaikeiSystemBody.views.grid.ZenkiKurikoshiKamokuKubunGrid();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.hojoGrid = new KaikeiSystemBody.views.grid.ZenkiKurikoshiKamokuKubunGrid();
            this.label16 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.dateInput = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.amountZenkimatsuShiharaiShikinZandaka = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.amountJikiKurikoshi = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.pnlDaikubunYosanBase.SuspendLayout();
            this.pnlKamokuYosanBase.SuspendLayout();
            this.pnlHojoKamokuYosanBase.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "年度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(50, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "会計区分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(39, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label7.Size = new System.Drawing.Size(222, 36);
            this.label7.TabIndex = 17;
            this.label7.Text = "大区分別前期繰越";
            // 
            // pnlDaikubunYosanBase
            // 
            this.pnlDaikubunYosanBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDaikubunYosanBase.Controls.Add(this.label5);
            this.pnlDaikubunYosanBase.Controls.Add(this.label4);
            this.pnlDaikubunYosanBase.Controls.Add(this.label3);
            this.pnlDaikubunYosanBase.Controls.Add(this.panelLineDaikubun);
            this.pnlDaikubunYosanBase.Controls.Add(this.daikubunGrid);
            this.pnlDaikubunYosanBase.Location = new System.Drawing.Point(15, 182);
            this.pnlDaikubunYosanBase.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlDaikubunYosanBase.Name = "pnlDaikubunYosanBase";
            this.pnlDaikubunYosanBase.Size = new System.Drawing.Size(899, 340);
            this.pnlDaikubunYosanBase.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(671, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 60;
            this.label5.Text = "前期繰越額";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(563, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 59;
            this.label4.Text = "貸借区分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(50, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 57;
            this.label3.Text = "大区分";
            // 
            // panelLineDaikubun
            // 
            this.panelLineDaikubun.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelLineDaikubun.Location = new System.Drawing.Point(0, 44);
            this.panelLineDaikubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelLineDaikubun.Name = "panelLineDaikubun";
            this.panelLineDaikubun.Size = new System.Drawing.Size(898, 2);
            this.panelLineDaikubun.TabIndex = 57;
            // 
            // daikubunGrid
            // 
            this.daikubunGrid.DataCount = 0;
            this.daikubunGrid.Location = new System.Drawing.Point(0, 46);
            this.daikubunGrid.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.daikubunGrid.Name = "daikubunGrid";
            this.daikubunGrid.NewRowIsVisible = false;
            this.daikubunGrid.Size = new System.Drawing.Size(897, 294);
            this.daikubunGrid.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1687, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 46);
            this.btnClose.TabIndex = 38;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "メニューへ(&M)";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pnlKamokuYosanBase
            // 
            this.pnlKamokuYosanBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlKamokuYosanBase.Controls.Add(this.label9);
            this.pnlKamokuYosanBase.Controls.Add(this.label8);
            this.pnlKamokuYosanBase.Controls.Add(this.label6);
            this.pnlKamokuYosanBase.Controls.Add(this.panel2);
            this.pnlKamokuYosanBase.Controls.Add(this.chukubunGrid);
            this.pnlKamokuYosanBase.Location = new System.Drawing.Point(15, 593);
            this.pnlKamokuYosanBase.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlKamokuYosanBase.Name = "pnlKamokuYosanBase";
            this.pnlKamokuYosanBase.Size = new System.Drawing.Size(897, 417);
            this.pnlKamokuYosanBase.TabIndex = 22;
            this.pnlKamokuYosanBase.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKamokuYosanBase_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(667, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 21);
            this.label9.TabIndex = 64;
            this.label9.Text = "前期繰越額";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(559, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 63;
            this.label8.Text = "貸借区分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(51, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 62;
            this.label6.Text = "中区分";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 2);
            this.panel2.TabIndex = 58;
            // 
            // chukubunGrid
            // 
            this.chukubunGrid.DataCount = 0;
            this.chukubunGrid.Location = new System.Drawing.Point(0, 46);
            this.chukubunGrid.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.chukubunGrid.Name = "chukubunGrid";
            this.chukubunGrid.NewRowIsVisible = false;
            this.chukubunGrid.Size = new System.Drawing.Size(895, 371);
            this.chukubunGrid.TabIndex = 62;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(37, 551);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label14.Size = new System.Drawing.Size(222, 36);
            this.label14.TabIndex = 39;
            this.label14.Text = "中区分別前期繰越";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label23.Location = new System.Drawing.Point(948, 140);
            this.label23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label23.Name = "label23";
            this.label23.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label23.Size = new System.Drawing.Size(222, 36);
            this.label23.TabIndex = 46;
            this.label23.Text = "小区分別前期繰越";
            // 
            // pnlHojoKamokuYosanBase
            // 
            this.pnlHojoKamokuYosanBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHojoKamokuYosanBase.Controls.Add(this.label10);
            this.pnlHojoKamokuYosanBase.Controls.Add(this.syoukubunGrid);
            this.pnlHojoKamokuYosanBase.Controls.Add(this.label11);
            this.pnlHojoKamokuYosanBase.Controls.Add(this.panel4);
            this.pnlHojoKamokuYosanBase.Controls.Add(this.label12);
            this.pnlHojoKamokuYosanBase.Location = new System.Drawing.Point(941, 182);
            this.pnlHojoKamokuYosanBase.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlHojoKamokuYosanBase.Name = "pnlHojoKamokuYosanBase";
            this.pnlHojoKamokuYosanBase.Size = new System.Drawing.Size(891, 340);
            this.pnlHojoKamokuYosanBase.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(664, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 21);
            this.label10.TabIndex = 69;
            this.label10.Text = "前期繰越額";
            // 
            // syoukubunGrid
            // 
            this.syoukubunGrid.DataCount = 0;
            this.syoukubunGrid.Location = new System.Drawing.Point(-4, 46);
            this.syoukubunGrid.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.syoukubunGrid.Name = "syoukubunGrid";
            this.syoukubunGrid.NewRowIsVisible = false;
            this.syoukubunGrid.Size = new System.Drawing.Size(893, 294);
            this.syoukubunGrid.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(556, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 21);
            this.label11.TabIndex = 68;
            this.label11.Text = "貸借区分";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(-4, 44);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(917, 2);
            this.panel4.TabIndex = 65;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(48, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 21);
            this.label12.TabIndex = 67;
            this.label12.Text = "小区分";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(568, 66);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 46);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "検索(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(568, 21);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 46);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "追加(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(730, 21);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 46);
            this.btnDelete.TabIndex = 59;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "削除(&D)";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(941, 551);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label13.Size = new System.Drawing.Size(248, 36);
            this.label13.TabIndex = 60;
            this.label13.Text = "補助科目別前期繰越";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.hojoGrid);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Location = new System.Drawing.Point(941, 593);
            this.panel6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(886, 300);
            this.panel6.TabIndex = 71;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(664, 18);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 21);
            this.label15.TabIndex = 69;
            this.label15.Text = "前期繰越額";
            // 
            // hojoGrid
            // 
            this.hojoGrid.DataCount = 0;
            this.hojoGrid.Location = new System.Drawing.Point(-4, 46);
            this.hojoGrid.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.hojoGrid.Name = "hojoGrid";
            this.hojoGrid.NewRowIsVisible = false;
            this.hojoGrid.Size = new System.Drawing.Size(887, 254);
            this.hojoGrid.TabIndex = 66;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(556, 18);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 21);
            this.label16.TabIndex = 68;
            this.label16.Text = "貸借区分";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel8.Location = new System.Drawing.Point(-4, 44);
            this.panel8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(917, 2);
            this.panel8.TabIndex = 65;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(48, 18);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 21);
            this.label17.TabIndex = 67;
            this.label17.Text = "科目";
            // 
            // cmbKaikeiKubun
            // 
            this.cmbKaikeiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKaikeiKubun.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKaikeiKubun.FormattingEnabled = true;
            this.cmbKaikeiKubun.Location = new System.Drawing.Point(183, 74);
            this.cmbKaikeiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKaikeiKubun.Name = "cmbKaikeiKubun";
            this.cmbKaikeiKubun.Size = new System.Drawing.Size(316, 34);
            this.cmbKaikeiKubun.TabIndex = 1;
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
            this.dateInput.Location = new System.Drawing.Point(183, 23);
            this.dateInput.Margin = new System.Windows.Forms.Padding(0);
            this.dateInput.MarginGengou2Year = 11;
            this.dateInput.MarginMonth2Day = 11;
            this.dateInput.MarginYear2Month = 11;
            this.dateInput.MonthStr = "4";
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(175, 37);
            this.dateInput.TabIndex = 0;
            this.dateInput.TextBoxWidth = 80;
            this.dateInput.ViewType = KaikeiSystemBody.views.controls.DateInputPanel.ViewTypeEnum.WarekiYear;
            this.dateInput.YearStr = "";
            // 
            // amountZenkimatsuShiharaiShikinZandaka
            // 
            this.amountZenkimatsuShiharaiShikinZandaka.Amount = ((long)(0));
            this.amountZenkimatsuShiharaiShikinZandaka.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.amountZenkimatsuShiharaiShikinZandaka.Location = new System.Drawing.Point(647, 54);
            this.amountZenkimatsuShiharaiShikinZandaka.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountZenkimatsuShiharaiShikinZandaka.Name = "amountZenkimatsuShiharaiShikinZandaka";
            this.amountZenkimatsuShiharaiShikinZandaka.Size = new System.Drawing.Size(202, 28);
            this.amountZenkimatsuShiharaiShikinZandaka.TabIndex = 73;
            this.amountZenkimatsuShiharaiShikinZandaka.Text = "\\0";
            this.amountZenkimatsuShiharaiShikinZandaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label19.Location = new System.Drawing.Point(6, 51);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label19.Size = new System.Drawing.Size(248, 36);
            this.label19.TabIndex = 74;
            this.label19.Text = "前期末支払資金残高";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.label18);
            this.panel9.Controls.Add(this.amountJikiKurikoshi);
            this.panel9.Controls.Add(this.label19);
            this.panel9.Controls.Add(this.amountZenkimatsuShiharaiShikinZandaka);
            this.panel9.Location = new System.Drawing.Point(941, 906);
            this.panel9.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(888, 104);
            this.panel9.TabIndex = 75;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.Location = new System.Drawing.Point(4, 10);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label18.Size = new System.Drawing.Size(274, 36);
            this.label18.TabIndex = 76;
            this.label18.Text = "次期繰越活動増減差額";
            // 
            // amountJikiKurikoshi
            // 
            this.amountJikiKurikoshi.Amount = ((long)(0));
            this.amountJikiKurikoshi.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.amountJikiKurikoshi.Location = new System.Drawing.Point(647, 10);
            this.amountJikiKurikoshi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountJikiKurikoshi.Name = "amountJikiKurikoshi";
            this.amountJikiKurikoshi.Size = new System.Drawing.Size(202, 28);
            this.amountJikiKurikoshi.TabIndex = 75;
            this.amountJikiKurikoshi.Text = "\\0";
            this.amountJikiKurikoshi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // KurikoshiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1859, 1031);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pnlHojoKamokuYosanBase);
            this.Controls.Add(this.pnlKamokuYosanBase);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlDaikubunYosanBase);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKaikeiKubun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateInput);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "KurikoshiForm";
            this.Text = "前期繰越";
            this.pnlDaikubunYosanBase.ResumeLayout(false);
            this.pnlDaikubunYosanBase.PerformLayout();
            this.pnlKamokuYosanBase.ResumeLayout(false);
            this.pnlKamokuYosanBase.PerformLayout();
            this.pnlHojoKamokuYosanBase.ResumeLayout(false);
            this.pnlHojoKamokuYosanBase.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.DateInputPanel dateInput;
        private System.Windows.Forms.Label label1;
        private controls.MTComboBox cmbKaikeiKubun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlDaikubunYosanBase;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlKamokuYosanBase;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel pnlHojoKamokuYosanBase;
        private grid.ZenkiKurikoshiKamokuKubunGrid daikubunGrid;
        private System.Windows.Forms.Panel panelLineDaikubun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private grid.ZenkiKurikoshiKamokuKubunGrid chukubunGrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private grid.ZenkiKurikoshiKamokuKubunGrid syoukubunGrid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label15;
        private grid.ZenkiKurikoshiKamokuKubunGrid hojoGrid;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label17;
        private controls.AmountTextBox amountZenkimatsuShiharaiShikinZandaka;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label18;
        private controls.AmountTextBox amountJikiKurikoshi;
    }
}