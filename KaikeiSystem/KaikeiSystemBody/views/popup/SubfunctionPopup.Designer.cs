namespace KaikeiSystemBody.views.popup
{
    partial class SubfunctionPopup
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
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNoFilter = new System.Windows.Forms.Button();
            this.btnCheckedFilter = new System.Windows.Forms.Button();
            this.btnNotCheckedFilter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupOtherFilters = new System.Windows.Forms.GroupBox();
            this.selectorKamokuCode = new KaikeiSystemBody.views.controls.KeySelectorTextBox();
            this.cmbTorihikiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.cmbKamoku = new KaikeiSystemBody.views.controls.MTComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchWordForComment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKingaku = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTorihikiKubunFilter = new System.Windows.Forms.Button();
            this.btnIdFilter = new System.Windows.Forms.Button();
            this.btnCommentFilter = new System.Windows.Forms.Button();
            this.btnKingakuFilter = new System.Windows.Forms.Button();
            this.btnKamokuFilter = new System.Windows.Forms.Button();
            this.groupDate = new System.Windows.Forms.GroupBox();
            this.dateEnd = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.dateStart = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.chkDateFilterIsEnabled = new System.Windows.Forms.CheckBox();
            this.radioUpdatedAt = new System.Windows.Forms.RadioButton();
            this.radioCreatedAt = new System.Windows.Forms.RadioButton();
            this.radioKihyoubi = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDateFilter = new System.Windows.Forms.Button();
            this.groupKeiriKubun = new System.Windows.Forms.GroupBox();
            this.cmbKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.chkKaikeiKubunFilterIsEnabled = new System.Windows.Forms.CheckBox();
            this.btnKaikeiKubunFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupEditData = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnIkkatsuSyori = new System.Windows.Forms.Button();
            this.btnDenpyouBangouSeiri = new System.Windows.Forms.Button();
            this.groupMove = new System.Windows.Forms.GroupBox();
            this.btnMoveToEnd = new System.Windows.Forms.Button();
            this.btnMoveToTop = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupChangeView = new System.Windows.Forms.GroupBox();
            this.btnShowSouKanjouMototyouView = new System.Windows.Forms.Button();
            this.btnShowSyuushiView = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupOtherFilters.SuspendLayout();
            this.groupDate.SuspendLayout();
            this.groupKeiriKubun.SuspendLayout();
            this.groupEditData.SuspendLayout();
            this.groupMove.SuspendLayout();
            this.groupChangeView.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.groupBox1);
            this.groupFilter.Controls.Add(this.label5);
            this.groupFilter.Controls.Add(this.groupOtherFilters);
            this.groupFilter.Controls.Add(this.groupDate);
            this.groupFilter.Controls.Add(this.groupKeiriKubun);
            this.groupFilter.Location = new System.Drawing.Point(22, 21);
            this.groupFilter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupFilter.Size = new System.Drawing.Size(887, 996);
            this.groupFilter.TabIndex = 0;
            this.groupFilter.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNoFilter);
            this.groupBox1.Controls.Add(this.btnCheckedFilter);
            this.groupBox1.Controls.Add(this.btnNotCheckedFilter);
            this.groupBox1.Location = new System.Drawing.Point(11, 782);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(865, 203);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnNoFilter
            // 
            this.btnNoFilter.Location = new System.Drawing.Point(17, 147);
            this.btnNoFilter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNoFilter.Name = "btnNoFilter";
            this.btnNoFilter.Size = new System.Drawing.Size(216, 47);
            this.btnNoFilter.TabIndex = 2;
            this.btnNoFilter.Text = "全件表示(&V)";
            this.btnNoFilter.UseVisualStyleBackColor = true;
            this.btnNoFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnNoFilter.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnCheckedFilter
            // 
            this.btnCheckedFilter.Location = new System.Drawing.Point(17, 32);
            this.btnCheckedFilter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCheckedFilter.Name = "btnCheckedFilter";
            this.btnCheckedFilter.Size = new System.Drawing.Size(216, 47);
            this.btnCheckedFilter.TabIndex = 0;
            this.btnCheckedFilter.Text = "チェック済(&O)";
            this.btnCheckedFilter.UseVisualStyleBackColor = true;
            this.btnCheckedFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnCheckedFilter.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnNotCheckedFilter
            // 
            this.btnNotCheckedFilter.Location = new System.Drawing.Point(17, 89);
            this.btnNotCheckedFilter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNotCheckedFilter.Name = "btnNotCheckedFilter";
            this.btnNotCheckedFilter.Size = new System.Drawing.Size(216, 47);
            this.btnNotCheckedFilter.TabIndex = 1;
            this.btnNotCheckedFilter.Text = "未チェック(&I)";
            this.btnNotCheckedFilter.UseVisualStyleBackColor = true;
            this.btnNotCheckedFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnNotCheckedFilter.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(28, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(2);
            this.label5.Size = new System.Drawing.Size(121, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "　抽　出　";
            // 
            // groupOtherFilters
            // 
            this.groupOtherFilters.Controls.Add(this.selectorKamokuCode);
            this.groupOtherFilters.Controls.Add(this.cmbTorihikiKubun);
            this.groupOtherFilters.Controls.Add(this.cmbKamoku);
            this.groupOtherFilters.Controls.Add(this.label10);
            this.groupOtherFilters.Controls.Add(this.txtID);
            this.groupOtherFilters.Controls.Add(this.label9);
            this.groupOtherFilters.Controls.Add(this.txtSearchWordForComment);
            this.groupOtherFilters.Controls.Add(this.label8);
            this.groupOtherFilters.Controls.Add(this.txtKingaku);
            this.groupOtherFilters.Controls.Add(this.label7);
            this.groupOtherFilters.Controls.Add(this.label6);
            this.groupOtherFilters.Controls.Add(this.btnTorihikiKubunFilter);
            this.groupOtherFilters.Controls.Add(this.btnIdFilter);
            this.groupOtherFilters.Controls.Add(this.btnCommentFilter);
            this.groupOtherFilters.Controls.Add(this.btnKingakuFilter);
            this.groupOtherFilters.Controls.Add(this.btnKamokuFilter);
            this.groupOtherFilters.Location = new System.Drawing.Point(11, 462);
            this.groupOtherFilters.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupOtherFilters.Name = "groupOtherFilters";
            this.groupOtherFilters.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupOtherFilters.Size = new System.Drawing.Size(865, 322);
            this.groupOtherFilters.TabIndex = 2;
            this.groupOtherFilters.TabStop = false;
            // 
            // selectorKamokuCode
            // 
            this.selectorKamokuCode.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.selectorKamokuCode.Location = new System.Drawing.Point(440, 35);
            this.selectorKamokuCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.selectorKamokuCode.Name = "selectorKamokuCode";
            this.selectorKamokuCode.Size = new System.Drawing.Size(96, 33);
            this.selectorKamokuCode.TabIndex = 0;
            this.selectorKamokuCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.selectorKamokuCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.selectorKamokuCode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // cmbTorihikiKubun
            // 
            this.cmbTorihikiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTorihikiKubun.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbTorihikiKubun.FormattingEnabled = true;
            this.cmbTorihikiKubun.Location = new System.Drawing.Point(440, 264);
            this.cmbTorihikiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbTorihikiKubun.Name = "cmbTorihikiKubun";
            this.cmbTorihikiKubun.Size = new System.Drawing.Size(220, 34);
            this.cmbTorihikiKubun.TabIndex = 9;
            this.cmbTorihikiKubun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.cmbTorihikiKubun.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // cmbKamoku
            // 
            this.cmbKamoku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKamoku.DropDownHeight = 300;
            this.cmbKamoku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKamoku.FormattingEnabled = true;
            this.cmbKamoku.IntegralHeight = false;
            this.cmbKamoku.Location = new System.Drawing.Point(550, 33);
            this.cmbKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKamoku.Name = "cmbKamoku";
            this.cmbKamoku.Size = new System.Drawing.Size(292, 34);
            this.cmbKamoku.TabIndex = 1;
            this.cmbKamoku.SelectedIndexChanged += new System.EventHandler(this.cmbKamoku_SelectedIndexChanged);
            this.cmbKamoku.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.cmbKamoku.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(279, 270);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 26);
            this.label10.TabIndex = 29;
            this.label10.Text = "取引区分";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtID.Location = new System.Drawing.Point(440, 206);
            this.txtID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(411, 33);
            this.txtID.TabIndex = 7;
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.txtID.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(279, 212);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 26);
            this.label9.TabIndex = 27;
            this.label9.Text = "ID番号";
            // 
            // txtSearchWordForComment
            // 
            this.txtSearchWordForComment.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSearchWordForComment.Location = new System.Drawing.Point(440, 149);
            this.txtSearchWordForComment.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSearchWordForComment.Name = "txtSearchWordForComment";
            this.txtSearchWordForComment.Size = new System.Drawing.Size(411, 33);
            this.txtSearchWordForComment.TabIndex = 5;
            this.txtSearchWordForComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.txtSearchWordForComment.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(279, 154);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 26);
            this.label8.TabIndex = 25;
            this.label8.Text = "検索文字列";
            // 
            // txtKingaku
            // 
            this.txtKingaku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKingaku.Location = new System.Drawing.Point(440, 91);
            this.txtKingaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKingaku.Name = "txtKingaku";
            this.txtKingaku.Size = new System.Drawing.Size(220, 33);
            this.txtKingaku.TabIndex = 3;
            this.txtKingaku.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.txtKingaku.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(279, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 26);
            this.label7.TabIndex = 23;
            this.label7.Text = "金額";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(277, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "対象科目";
            // 
            // btnTorihikiKubunFilter
            // 
            this.btnTorihikiKubunFilter.Location = new System.Drawing.Point(17, 262);
            this.btnTorihikiKubunFilter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTorihikiKubunFilter.Name = "btnTorihikiKubunFilter";
            this.btnTorihikiKubunFilter.Size = new System.Drawing.Size(216, 47);
            this.btnTorihikiKubunFilter.TabIndex = 10;
            this.btnTorihikiKubunFilter.Text = "※取引区分抽出(&P)";
            this.btnTorihikiKubunFilter.UseVisualStyleBackColor = true;
            this.btnTorihikiKubunFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnTorihikiKubunFilter.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnIdFilter
            // 
            this.btnIdFilter.Location = new System.Drawing.Point(17, 205);
            this.btnIdFilter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnIdFilter.Name = "btnIdFilter";
            this.btnIdFilter.Size = new System.Drawing.Size(216, 47);
            this.btnIdFilter.TabIndex = 8;
            this.btnIdFilter.Text = "ID抽出(&N)";
            this.btnIdFilter.UseVisualStyleBackColor = true;
            this.btnIdFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnIdFilter.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnCommentFilter
            // 
            this.btnCommentFilter.Location = new System.Drawing.Point(17, 147);
            this.btnCommentFilter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCommentFilter.Name = "btnCommentFilter";
            this.btnCommentFilter.Size = new System.Drawing.Size(216, 47);
            this.btnCommentFilter.TabIndex = 6;
            this.btnCommentFilter.Text = "摘要抽出(&R)";
            this.btnCommentFilter.UseVisualStyleBackColor = true;
            this.btnCommentFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnCommentFilter.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnKingakuFilter
            // 
            this.btnKingakuFilter.Location = new System.Drawing.Point(17, 89);
            this.btnKingakuFilter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnKingakuFilter.Name = "btnKingakuFilter";
            this.btnKingakuFilter.Size = new System.Drawing.Size(216, 47);
            this.btnKingakuFilter.TabIndex = 4;
            this.btnKingakuFilter.Text = "金額抽出(&P)";
            this.btnKingakuFilter.UseVisualStyleBackColor = true;
            this.btnKingakuFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnKingakuFilter.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnKamokuFilter
            // 
            this.btnKamokuFilter.Location = new System.Drawing.Point(17, 32);
            this.btnKamokuFilter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnKamokuFilter.Name = "btnKamokuFilter";
            this.btnKamokuFilter.Size = new System.Drawing.Size(216, 47);
            this.btnKamokuFilter.TabIndex = 2;
            this.btnKamokuFilter.Text = "※科目抽出(&K)";
            this.btnKamokuFilter.UseVisualStyleBackColor = true;
            this.btnKamokuFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnKamokuFilter.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // groupDate
            // 
            this.groupDate.Controls.Add(this.dateEnd);
            this.groupDate.Controls.Add(this.dateStart);
            this.groupDate.Controls.Add(this.chkDateFilterIsEnabled);
            this.groupDate.Controls.Add(this.radioUpdatedAt);
            this.groupDate.Controls.Add(this.radioCreatedAt);
            this.groupDate.Controls.Add(this.radioKihyoubi);
            this.groupDate.Controls.Add(this.label4);
            this.groupDate.Controls.Add(this.label3);
            this.groupDate.Controls.Add(this.label2);
            this.groupDate.Controls.Add(this.btnDateFilter);
            this.groupDate.Location = new System.Drawing.Point(11, 184);
            this.groupDate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupDate.Name = "groupDate";
            this.groupDate.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupDate.Size = new System.Drawing.Size(865, 275);
            this.groupDate.TabIndex = 1;
            this.groupDate.TabStop = false;
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
            this.dateEnd.Location = new System.Drawing.Point(513, 91);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(0);
            this.dateEnd.MarginGengou2Year = 11;
            this.dateEnd.MarginMonth2Day = 11;
            this.dateEnd.MarginYear2Month = 11;
            this.dateEnd.MonthStr = "";
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(241, 37);
            this.dateEnd.TabIndex = 1;
            this.dateEnd.TextBoxWidth = 51;
            this.dateEnd.YearStr = "";
            this.dateEnd.TextBoxKeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.dateEnd.TextBoxPreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
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
            this.dateStart.Location = new System.Drawing.Point(513, 33);
            this.dateStart.Margin = new System.Windows.Forms.Padding(0);
            this.dateStart.MarginGengou2Year = 11;
            this.dateStart.MarginMonth2Day = 11;
            this.dateStart.MarginYear2Month = 11;
            this.dateStart.MonthStr = "";
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(241, 37);
            this.dateStart.TabIndex = 0;
            this.dateStart.TextBoxWidth = 51;
            this.dateStart.YearStr = "";
            this.dateStart.TextBoxKeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.dateStart.TextBoxPreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // chkDateFilterIsEnabled
            // 
            this.chkDateFilterIsEnabled.AutoSize = true;
            this.chkDateFilterIsEnabled.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkDateFilterIsEnabled.Location = new System.Drawing.Point(17, 231);
            this.chkDateFilterIsEnabled.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkDateFilterIsEnabled.Name = "chkDateFilterIsEnabled";
            this.chkDateFilterIsEnabled.Size = new System.Drawing.Size(686, 30);
            this.chkDateFilterIsEnabled.TabIndex = 12;
            this.chkDateFilterIsEnabled.Text = "以下の抽出を行う際に対象期間の指定を有効にする（※有効）";
            this.chkDateFilterIsEnabled.UseVisualStyleBackColor = true;
            this.chkDateFilterIsEnabled.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.chkDateFilterIsEnabled.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // radioUpdatedAt
            // 
            this.radioUpdatedAt.AutoSize = true;
            this.radioUpdatedAt.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioUpdatedAt.Location = new System.Drawing.Point(726, 163);
            this.radioUpdatedAt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioUpdatedAt.Name = "radioUpdatedAt";
            this.radioUpdatedAt.Size = new System.Drawing.Size(115, 30);
            this.radioUpdatedAt.TabIndex = 4;
            this.radioUpdatedAt.TabStop = true;
            this.radioUpdatedAt.Text = "更新日";
            this.radioUpdatedAt.UseVisualStyleBackColor = true;
            this.radioUpdatedAt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.radioUpdatedAt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // radioCreatedAt
            // 
            this.radioCreatedAt.AutoSize = true;
            this.radioCreatedAt.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioCreatedAt.Location = new System.Drawing.Point(587, 163);
            this.radioCreatedAt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioCreatedAt.Name = "radioCreatedAt";
            this.radioCreatedAt.Size = new System.Drawing.Size(115, 30);
            this.radioCreatedAt.TabIndex = 3;
            this.radioCreatedAt.TabStop = true;
            this.radioCreatedAt.Text = "登録日";
            this.radioCreatedAt.UseVisualStyleBackColor = true;
            this.radioCreatedAt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.radioCreatedAt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // radioKihyoubi
            // 
            this.radioKihyoubi.AutoSize = true;
            this.radioKihyoubi.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioKihyoubi.Location = new System.Drawing.Point(447, 163);
            this.radioKihyoubi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioKihyoubi.Name = "radioKihyoubi";
            this.radioKihyoubi.Size = new System.Drawing.Size(115, 30);
            this.radioKihyoubi.TabIndex = 2;
            this.radioKihyoubi.TabStop = true;
            this.radioKihyoubi.Text = "起票日";
            this.radioKihyoubi.UseVisualStyleBackColor = true;
            this.radioKihyoubi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.radioKihyoubi.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(218, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "対象となる日付";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(396, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "終了日";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(277, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "対象期間 開始日";
            // 
            // btnDateFilter
            // 
            this.btnDateFilter.Location = new System.Drawing.Point(11, 32);
            this.btnDateFilter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDateFilter.Name = "btnDateFilter";
            this.btnDateFilter.Size = new System.Drawing.Size(222, 47);
            this.btnDateFilter.TabIndex = 5;
            this.btnDateFilter.Text = "日付抽出(&D)";
            this.btnDateFilter.UseVisualStyleBackColor = true;
            this.btnDateFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnDateFilter.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // groupKeiriKubun
            // 
            this.groupKeiriKubun.Controls.Add(this.cmbKaikeiKubun);
            this.groupKeiriKubun.Controls.Add(this.chkKaikeiKubunFilterIsEnabled);
            this.groupKeiriKubun.Controls.Add(this.btnKaikeiKubunFilter);
            this.groupKeiriKubun.Controls.Add(this.label1);
            this.groupKeiriKubun.Location = new System.Drawing.Point(11, 14);
            this.groupKeiriKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupKeiriKubun.Name = "groupKeiriKubun";
            this.groupKeiriKubun.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupKeiriKubun.Size = new System.Drawing.Size(865, 166);
            this.groupKeiriKubun.TabIndex = 0;
            this.groupKeiriKubun.TabStop = false;
            // 
            // cmbKaikeiKubun
            // 
            this.cmbKaikeiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKaikeiKubun.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKaikeiKubun.FormattingEnabled = true;
            this.cmbKaikeiKubun.Location = new System.Drawing.Point(411, 33);
            this.cmbKaikeiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKaikeiKubun.Name = "cmbKaikeiKubun";
            this.cmbKaikeiKubun.Size = new System.Drawing.Size(407, 34);
            this.cmbKaikeiKubun.TabIndex = 1;
            this.cmbKaikeiKubun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.cmbKaikeiKubun.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // chkKaikeiKubunFilterIsEnabled
            // 
            this.chkKaikeiKubunFilterIsEnabled.AutoSize = true;
            this.chkKaikeiKubunFilterIsEnabled.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkKaikeiKubunFilterIsEnabled.Location = new System.Drawing.Point(17, 116);
            this.chkKaikeiKubunFilterIsEnabled.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkKaikeiKubunFilterIsEnabled.Name = "chkKaikeiKubunFilterIsEnabled";
            this.chkKaikeiKubunFilterIsEnabled.Size = new System.Drawing.Size(582, 30);
            this.chkKaikeiKubunFilterIsEnabled.TabIndex = 2;
            this.chkKaikeiKubunFilterIsEnabled.Text = "以下の抽出を行う際に経理区分の指定を有効にする";
            this.chkKaikeiKubunFilterIsEnabled.UseVisualStyleBackColor = true;
            this.chkKaikeiKubunFilterIsEnabled.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.chkKaikeiKubunFilterIsEnabled.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnKaikeiKubunFilter
            // 
            this.btnKaikeiKubunFilter.Location = new System.Drawing.Point(11, 32);
            this.btnKaikeiKubunFilter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnKaikeiKubunFilter.Name = "btnKaikeiKubunFilter";
            this.btnKaikeiKubunFilter.Size = new System.Drawing.Size(222, 47);
            this.btnKaikeiKubunFilter.TabIndex = 0;
            this.btnKaikeiKubunFilter.Text = "会計区分抽出(&C)";
            this.btnKaikeiKubunFilter.UseVisualStyleBackColor = true;
            this.btnKaikeiKubunFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnKaikeiKubunFilter.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(277, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "会計区分";
            // 
            // groupEditData
            // 
            this.groupEditData.Controls.Add(this.label11);
            this.groupEditData.Controls.Add(this.btnUncheckAll);
            this.groupEditData.Controls.Add(this.btnIkkatsuSyori);
            this.groupEditData.Controls.Add(this.btnDenpyouBangouSeiri);
            this.groupEditData.Location = new System.Drawing.Point(920, 21);
            this.groupEditData.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupEditData.Name = "groupEditData";
            this.groupEditData.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupEditData.Size = new System.Drawing.Size(297, 234);
            this.groupEditData.TabIndex = 1;
            this.groupEditData.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(81, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(2);
            this.label11.Size = new System.Drawing.Size(130, 32);
            this.label11.TabIndex = 8;
            this.label11.Text = "データ編集";
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Location = new System.Drawing.Point(37, 161);
            this.btnUncheckAll.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(222, 47);
            this.btnUncheckAll.TabIndex = 2;
            this.btnUncheckAll.Text = "チェック解除(&F)";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnUncheckAll.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnIkkatsuSyori
            // 
            this.btnIkkatsuSyori.Location = new System.Drawing.Point(37, 103);
            this.btnIkkatsuSyori.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnIkkatsuSyori.Name = "btnIkkatsuSyori";
            this.btnIkkatsuSyori.Size = new System.Drawing.Size(222, 47);
            this.btnIkkatsuSyori.TabIndex = 1;
            this.btnIkkatsuSyori.Text = "一括登録(&A)";
            this.btnIkkatsuSyori.UseVisualStyleBackColor = true;
            this.btnIkkatsuSyori.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnIkkatsuSyori.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnDenpyouBangouSeiri
            // 
            this.btnDenpyouBangouSeiri.Location = new System.Drawing.Point(37, 46);
            this.btnDenpyouBangouSeiri.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDenpyouBangouSeiri.Name = "btnDenpyouBangouSeiri";
            this.btnDenpyouBangouSeiri.Size = new System.Drawing.Size(222, 47);
            this.btnDenpyouBangouSeiri.TabIndex = 0;
            this.btnDenpyouBangouSeiri.Text = "伝票番号の整理(&S)";
            this.btnDenpyouBangouSeiri.UseVisualStyleBackColor = true;
            this.btnDenpyouBangouSeiri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnDenpyouBangouSeiri.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // groupMove
            // 
            this.groupMove.Controls.Add(this.btnMoveToEnd);
            this.groupMove.Controls.Add(this.btnMoveToTop);
            this.groupMove.Controls.Add(this.label12);
            this.groupMove.Location = new System.Drawing.Point(920, 266);
            this.groupMove.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupMove.Name = "groupMove";
            this.groupMove.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupMove.Size = new System.Drawing.Size(297, 186);
            this.groupMove.TabIndex = 2;
            this.groupMove.TabStop = false;
            // 
            // btnMoveToEnd
            // 
            this.btnMoveToEnd.Location = new System.Drawing.Point(37, 112);
            this.btnMoveToEnd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMoveToEnd.Name = "btnMoveToEnd";
            this.btnMoveToEnd.Size = new System.Drawing.Size(222, 47);
            this.btnMoveToEnd.TabIndex = 1;
            this.btnMoveToEnd.Text = "最後のデータへ(&E)";
            this.btnMoveToEnd.UseVisualStyleBackColor = true;
            this.btnMoveToEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnMoveToEnd.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnMoveToTop
            // 
            this.btnMoveToTop.Location = new System.Drawing.Point(37, 54);
            this.btnMoveToTop.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMoveToTop.Name = "btnMoveToTop";
            this.btnMoveToTop.Size = new System.Drawing.Size(222, 47);
            this.btnMoveToTop.TabIndex = 0;
            this.btnMoveToTop.Text = "先頭のデータへ(&T)";
            this.btnMoveToTop.UseVisualStyleBackColor = true;
            this.btnMoveToTop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnMoveToTop.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(97, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(2);
            this.label12.Size = new System.Drawing.Size(87, 32);
            this.label12.TabIndex = 9;
            this.label12.Text = "移　動";
            // 
            // groupChangeView
            // 
            this.groupChangeView.Controls.Add(this.btnShowSouKanjouMototyouView);
            this.groupChangeView.Controls.Add(this.btnShowSyuushiView);
            this.groupChangeView.Controls.Add(this.label13);
            this.groupChangeView.Location = new System.Drawing.Point(920, 511);
            this.groupChangeView.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupChangeView.Name = "groupChangeView";
            this.groupChangeView.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupChangeView.Size = new System.Drawing.Size(297, 187);
            this.groupChangeView.TabIndex = 3;
            this.groupChangeView.TabStop = false;
            // 
            // btnShowSouKanjouMototyouView
            // 
            this.btnShowSouKanjouMototyouView.Location = new System.Drawing.Point(37, 116);
            this.btnShowSouKanjouMototyouView.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnShowSouKanjouMototyouView.Name = "btnShowSouKanjouMototyouView";
            this.btnShowSouKanjouMototyouView.Size = new System.Drawing.Size(222, 47);
            this.btnShowSouKanjouMototyouView.TabIndex = 1;
            this.btnShowSouKanjouMototyouView.Text = "総勘定元帳(&L)";
            this.btnShowSouKanjouMototyouView.UseVisualStyleBackColor = true;
            this.btnShowSouKanjouMototyouView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnShowSouKanjouMototyouView.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnShowSyuushiView
            // 
            this.btnShowSyuushiView.Location = new System.Drawing.Point(37, 54);
            this.btnShowSyuushiView.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnShowSyuushiView.Name = "btnShowSyuushiView";
            this.btnShowSyuushiView.Size = new System.Drawing.Size(222, 47);
            this.btnShowSyuushiView.TabIndex = 0;
            this.btnShowSyuushiView.Text = "収支表示(&V)";
            this.btnShowSyuushiView.UseVisualStyleBackColor = true;
            this.btnShowSyuushiView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnShowSyuushiView.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(81, 4);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(2);
            this.label13.Size = new System.Drawing.Size(122, 32);
            this.label13.TabIndex = 11;
            this.label13.Text = "表示切替";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(957, 950);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(222, 47);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "閉じる(&X)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnClose.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // SubfunctionPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1263, 1027);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupChangeView);
            this.Controls.Add(this.groupMove);
            this.Controls.Add(this.groupEditData);
            this.Controls.Add(this.groupFilter);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SubfunctionPopup";
            this.ShowInTaskbar = false;
            this.Text = "補助機能";
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupOtherFilters.ResumeLayout(false);
            this.groupOtherFilters.PerformLayout();
            this.groupDate.ResumeLayout(false);
            this.groupDate.PerformLayout();
            this.groupKeiriKubun.ResumeLayout(false);
            this.groupKeiriKubun.PerformLayout();
            this.groupEditData.ResumeLayout(false);
            this.groupEditData.PerformLayout();
            this.groupMove.ResumeLayout(false);
            this.groupMove.PerformLayout();
            this.groupChangeView.ResumeLayout(false);
            this.groupChangeView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.Button btnKaikeiKubunFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkKaikeiKubunFilterIsEnabled;
        private System.Windows.Forms.GroupBox groupKeiriKubun;
        private System.Windows.Forms.GroupBox groupDate;
        private System.Windows.Forms.Button btnDateFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioKihyoubi;
        private System.Windows.Forms.RadioButton radioCreatedAt;
        private System.Windows.Forms.RadioButton radioUpdatedAt;
        private System.Windows.Forms.CheckBox chkDateFilterIsEnabled;
        private System.Windows.Forms.GroupBox groupOtherFilters;
        private System.Windows.Forms.Button btnKamokuFilter;
        private System.Windows.Forms.Button btnKingakuFilter;
        private System.Windows.Forms.Button btnCommentFilter;
        private System.Windows.Forms.Button btnIdFilter;
        private System.Windows.Forms.Button btnTorihikiKubunFilter;
        private System.Windows.Forms.Button btnCheckedFilter;
        private System.Windows.Forms.Button btnNotCheckedFilter;
        private System.Windows.Forms.Button btnNoFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKingaku;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchWordForComment;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupEditData;
        private System.Windows.Forms.GroupBox groupMove;
        private System.Windows.Forms.GroupBox groupChangeView;
        private System.Windows.Forms.Button btnDenpyouBangouSeiri;
        private System.Windows.Forms.Button btnIkkatsuSyori;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnMoveToTop;
        private System.Windows.Forms.Button btnMoveToEnd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnShowSyuushiView;
        private System.Windows.Forms.Button btnShowSouKanjouMototyouView;
        private System.Windows.Forms.Button btnClose;
        private controls.MTComboBox cmbKaikeiKubun;
        private controls.MTComboBox cmbKamoku;
        private controls.MTComboBox cmbTorihikiKubun;
        private controls.KeySelectorTextBox selectorKamokuCode;
        private controls.DateInputPanel dateStart;
        private controls.DateInputPanel dateEnd;
    }
}