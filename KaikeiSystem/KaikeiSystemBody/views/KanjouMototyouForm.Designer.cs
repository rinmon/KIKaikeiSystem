namespace KaikeiSystemBody.views
{
    partial class KanjouMototyouForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddDenpyou = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnShowDenpyouView = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioKamokuOrderAlphabet = new System.Windows.Forms.RadioButton();
            this.radioKamokuOrderCode = new System.Windows.Forms.RadioButton();
            this.panelKamokuOrder = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowHojoMototyou = new System.Windows.Forms.Button();
            this.panelKaikeiKubun = new System.Windows.Forms.Panel();
            this.selectorKaikeiKubun = new KaikeiSystemBody.views.controls.KeySelectorTextBox();
            this.cmbKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.checkDenpyouSeiri = new System.Windows.Forms.CheckBox();
            this.panelHojoKamoku = new System.Windows.Forms.Panel();
            this.selectorHojoKamoku = new KaikeiSystemBody.views.controls.KeySelectorTextBox();
            this.cmbHojoKamoku = new KaikeiSystemBody.views.controls.MTComboBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.ColumnDetailButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDenpyouBangou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKihyoubi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAiteKamoku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKarikataKingaku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKashikataKingaku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSashihikiKingaku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHojoKamokuTouroku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusbarMsgText = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelGridFooter = new System.Windows.Forms.Panel();
            this.lblKarikataSum = new System.Windows.Forms.Label();
            this.lblKashikataSum = new System.Windows.Forms.Label();
            this.lblSashihikiSum = new System.Windows.Forms.Label();
            this.lblTargetKamoku = new System.Windows.Forms.Label();
            this.lblTaragetKamokuKarikashiKubun = new System.Windows.Forms.Label();
            this.lblZengetsuKurikoshi = new System.Windows.Forms.Label();
            this.dateEnd = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.dateStart = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.cmbKanjouKamoku = new KaikeiSystemBody.views.controls.MTComboBox();
            this.selectorKamokuCode = new KaikeiSystemBody.views.controls.KeySelectorTextBox();
            this.btnDummy = new System.Windows.Forms.Button();
            this.panelKamokuOrder.SuspendLayout();
            this.panelKaikeiKubun.SuspendLayout();
            this.panelHojoKamoku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.panelGridFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "対象期間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(274, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "～";
            // 
            // btnAddDenpyou
            // 
            this.btnAddDenpyou.Location = new System.Drawing.Point(625, 6);
            this.btnAddDenpyou.Name = "btnAddDenpyou";
            this.btnAddDenpyou.Size = new System.Drawing.Size(83, 28);
            this.btnAddDenpyou.TabIndex = 10;
            this.btnAddDenpyou.TabStop = false;
            this.btnAddDenpyou.Text = "新規登録(&E)";
            this.btnAddDenpyou.UseVisualStyleBackColor = true;
            this.btnAddDenpyou.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnAddDenpyou.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(714, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(63, 28);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "印刷(&P)";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnPrint.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnShowDenpyouView
            // 
            this.btnShowDenpyouView.Location = new System.Drawing.Point(783, 6);
            this.btnShowDenpyouView.Name = "btnShowDenpyouView";
            this.btnShowDenpyouView.Size = new System.Drawing.Size(105, 28);
            this.btnShowDenpyouView.TabIndex = 12;
            this.btnShowDenpyouView.TabStop = false;
            this.btnShowDenpyouView.Text = "会計伝票一覧(&L)";
            this.btnShowDenpyouView.UseVisualStyleBackColor = true;
            this.btnShowDenpyouView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnShowDenpyouView.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(894, 6);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(89, 28);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.TabStop = false;
            this.btnReturn.Text = "メニューへ(&M)";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnReturn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(34, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "対象科目";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "対象補助科目";
            // 
            // radioKamokuOrderAlphabet
            // 
            this.radioKamokuOrderAlphabet.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioKamokuOrderAlphabet.AutoSize = true;
            this.radioKamokuOrderAlphabet.Location = new System.Drawing.Point(3, 3);
            this.radioKamokuOrderAlphabet.Name = "radioKamokuOrderAlphabet";
            this.radioKamokuOrderAlphabet.Padding = new System.Windows.Forms.Padding(2);
            this.radioKamokuOrderAlphabet.Size = new System.Drawing.Size(55, 26);
            this.radioKamokuOrderAlphabet.TabIndex = 19;
            this.radioKamokuOrderAlphabet.Text = "50音順";
            this.radioKamokuOrderAlphabet.UseVisualStyleBackColor = true;
            this.radioKamokuOrderAlphabet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.radioKamokuOrderAlphabet.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // radioKamokuOrderCode
            // 
            this.radioKamokuOrderCode.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioKamokuOrderCode.AutoSize = true;
            this.radioKamokuOrderCode.Location = new System.Drawing.Point(58, 3);
            this.radioKamokuOrderCode.Name = "radioKamokuOrderCode";
            this.radioKamokuOrderCode.Padding = new System.Windows.Forms.Padding(2);
            this.radioKamokuOrderCode.Size = new System.Drawing.Size(58, 26);
            this.radioKamokuOrderCode.TabIndex = 20;
            this.radioKamokuOrderCode.Text = "コード順";
            this.radioKamokuOrderCode.UseVisualStyleBackColor = true;
            this.radioKamokuOrderCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.radioKamokuOrderCode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // panelKamokuOrder
            // 
            this.panelKamokuOrder.Controls.Add(this.radioKamokuOrderAlphabet);
            this.panelKamokuOrder.Controls.Add(this.radioKamokuOrderCode);
            this.panelKamokuOrder.Location = new System.Drawing.Point(374, 54);
            this.panelKamokuOrder.Name = "panelKamokuOrder";
            this.panelKamokuOrder.Size = new System.Drawing.Size(128, 34);
            this.panelKamokuOrder.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "会計区分";
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearch.Location = new System.Drawing.Point(374, 121);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 28);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "検索(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Enter += new System.EventHandler(this.btnSearch_Enter);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnSearch.Leave += new System.EventHandler(this.control_Leave);
            this.btnSearch.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnShowHojoMototyou
            // 
            this.btnShowHojoMototyou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnShowHojoMototyou.Location = new System.Drawing.Point(463, 121);
            this.btnShowHojoMototyou.Name = "btnShowHojoMototyou";
            this.btnShowHojoMototyou.Size = new System.Drawing.Size(109, 28);
            this.btnShowHojoMototyou.TabIndex = 7;
            this.btnShowHojoMototyou.Text = "補助元帳表示(&V)";
            this.btnShowHojoMototyou.UseVisualStyleBackColor = true;
            this.btnShowHojoMototyou.Enter += new System.EventHandler(this.btnShowHojoMototyou_Enter);
            this.btnShowHojoMototyou.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnShowHojoMototyou.Leave += new System.EventHandler(this.control_Leave);
            this.btnShowHojoMototyou.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // panelKaikeiKubun
            // 
            this.panelKaikeiKubun.Controls.Add(this.label5);
            this.panelKaikeiKubun.Controls.Add(this.selectorKaikeiKubun);
            this.panelKaikeiKubun.Controls.Add(this.cmbKaikeiKubun);
            this.panelKaikeiKubun.Location = new System.Drawing.Point(31, 122);
            this.panelKaikeiKubun.Name = "panelKaikeiKubun";
            this.panelKaikeiKubun.Size = new System.Drawing.Size(337, 29);
            this.panelKaikeiKubun.TabIndex = 5;
            // 
            // selectorKaikeiKubun
            // 
            this.selectorKaikeiKubun.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.selectorKaikeiKubun.Location = new System.Drawing.Point(76, 3);
            this.selectorKaikeiKubun.Name = "selectorKaikeiKubun";
            this.selectorKaikeiKubun.Size = new System.Drawing.Size(58, 22);
            this.selectorKaikeiKubun.TabIndex = 0;
            this.selectorKaikeiKubun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.selectorKaikeiKubun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.selectorKaikeiKubun.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // cmbKaikeiKubun
            // 
            this.cmbKaikeiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKaikeiKubun.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKaikeiKubun.FormattingEnabled = true;
            this.cmbKaikeiKubun.Location = new System.Drawing.Point(140, 2);
            this.cmbKaikeiKubun.Name = "cmbKaikeiKubun";
            this.cmbKaikeiKubun.Size = new System.Drawing.Size(195, 23);
            this.cmbKaikeiKubun.TabIndex = 1;
            this.cmbKaikeiKubun.Enter += new System.EventHandler(this.cmbKaikeiKubun_Enter);
            this.cmbKaikeiKubun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.cmbKaikeiKubun.Leave += new System.EventHandler(this.control_Leave);
            this.cmbKaikeiKubun.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // checkDenpyouSeiri
            // 
            this.checkDenpyouSeiri.AutoSize = true;
            this.checkDenpyouSeiri.Location = new System.Drawing.Point(381, 96);
            this.checkDenpyouSeiri.Name = "checkDenpyouSeiri";
            this.checkDenpyouSeiri.Size = new System.Drawing.Size(179, 16);
            this.checkDenpyouSeiri.TabIndex = 43;
            this.checkDenpyouSeiri.TabStop = false;
            this.checkDenpyouSeiri.Text = "計算前に伝票番号の整理を行う";
            this.checkDenpyouSeiri.UseVisualStyleBackColor = true;
            // 
            // panelHojoKamoku
            // 
            this.panelHojoKamoku.Controls.Add(this.label4);
            this.panelHojoKamoku.Controls.Add(this.selectorHojoKamoku);
            this.panelHojoKamoku.Controls.Add(this.cmbHojoKamoku);
            this.panelHojoKamoku.Location = new System.Drawing.Point(6, 88);
            this.panelHojoKamoku.Name = "panelHojoKamoku";
            this.panelHojoKamoku.Size = new System.Drawing.Size(369, 31);
            this.panelHojoKamoku.TabIndex = 4;
            // 
            // selectorHojoKamoku
            // 
            this.selectorHojoKamoku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.selectorHojoKamoku.Location = new System.Drawing.Point(100, 3);
            this.selectorHojoKamoku.Name = "selectorHojoKamoku";
            this.selectorHojoKamoku.Size = new System.Drawing.Size(58, 22);
            this.selectorHojoKamoku.TabIndex = 0;
            this.selectorHojoKamoku.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.selectorHojoKamoku.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.selectorHojoKamoku.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // cmbHojoKamoku
            // 
            this.cmbHojoKamoku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHojoKamoku.DropDownHeight = 300;
            this.cmbHojoKamoku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbHojoKamoku.FormattingEnabled = true;
            this.cmbHojoKamoku.IntegralHeight = false;
            this.cmbHojoKamoku.Location = new System.Drawing.Point(166, 3);
            this.cmbHojoKamoku.Name = "cmbHojoKamoku";
            this.cmbHojoKamoku.Size = new System.Drawing.Size(195, 23);
            this.cmbHojoKamoku.TabIndex = 1;
            this.cmbHojoKamoku.Enter += new System.EventHandler(this.cmbHojoKamoku_Enter);
            this.cmbHojoKamoku.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.cmbHojoKamoku.Leave += new System.EventHandler(this.control_Leave);
            this.cmbHojoKamoku.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDetailButton,
            this.ColumnDenpyouBangou,
            this.ColumnKihyoubi,
            this.ColumnAiteKamoku,
            this.ColumnComment,
            this.ColumnKarikataKingaku,
            this.ColumnKashikataKingaku,
            this.ColumnSashihikiKingaku,
            this.ColumnHojoKamokuTouroku});
            this.grid.Location = new System.Drawing.Point(0, 157);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 21;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(1012, 248);
            this.grid.TabIndex = 46;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // ColumnDetailButton
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ColumnDetailButton.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnDetailButton.Frozen = true;
            this.ColumnDetailButton.HeaderText = "";
            this.ColumnDetailButton.Name = "ColumnDetailButton";
            this.ColumnDetailButton.ReadOnly = true;
            this.ColumnDetailButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDetailButton.Text = "詳細(D)";
            this.ColumnDetailButton.UseColumnTextForButtonValue = true;
            this.ColumnDetailButton.Width = 60;
            // 
            // ColumnDenpyouBangou
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ColumnDenpyouBangou.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnDenpyouBangou.Frozen = true;
            this.ColumnDenpyouBangou.HeaderText = "番号";
            this.ColumnDenpyouBangou.Name = "ColumnDenpyouBangou";
            this.ColumnDenpyouBangou.ReadOnly = true;
            this.ColumnDenpyouBangou.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDenpyouBangou.Width = 52;
            // 
            // ColumnKihyoubi
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ColumnKihyoubi.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnKihyoubi.Frozen = true;
            this.ColumnKihyoubi.HeaderText = "起票日";
            this.ColumnKihyoubi.Name = "ColumnKihyoubi";
            this.ColumnKihyoubi.ReadOnly = true;
            this.ColumnKihyoubi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnKihyoubi.Width = 110;
            // 
            // ColumnAiteKamoku
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ColumnAiteKamoku.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnAiteKamoku.Frozen = true;
            this.ColumnAiteKamoku.HeaderText = "相手科目";
            this.ColumnAiteKamoku.Name = "ColumnAiteKamoku";
            this.ColumnAiteKamoku.ReadOnly = true;
            this.ColumnAiteKamoku.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnAiteKamoku.Width = 207;
            // 
            // ColumnComment
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ColumnComment.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnComment.Frozen = true;
            this.ColumnComment.HeaderText = "コメント";
            this.ColumnComment.Name = "ColumnComment";
            this.ColumnComment.ReadOnly = true;
            this.ColumnComment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnComment.Width = 224;
            // 
            // ColumnKarikataKingaku
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ColumnKarikataKingaku.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnKarikataKingaku.Frozen = true;
            this.ColumnKarikataKingaku.HeaderText = "借方金額";
            this.ColumnKarikataKingaku.Name = "ColumnKarikataKingaku";
            this.ColumnKarikataKingaku.ReadOnly = true;
            this.ColumnKarikataKingaku.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnKarikataKingaku.Width = 102;
            // 
            // ColumnKashikataKingaku
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ColumnKashikataKingaku.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnKashikataKingaku.Frozen = true;
            this.ColumnKashikataKingaku.HeaderText = "貸方金額";
            this.ColumnKashikataKingaku.Name = "ColumnKashikataKingaku";
            this.ColumnKashikataKingaku.ReadOnly = true;
            this.ColumnKashikataKingaku.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnKashikataKingaku.Width = 102;
            // 
            // ColumnSashihikiKingaku
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ColumnSashihikiKingaku.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnSashihikiKingaku.Frozen = true;
            this.ColumnSashihikiKingaku.HeaderText = "差引金額";
            this.ColumnSashihikiKingaku.Name = "ColumnSashihikiKingaku";
            this.ColumnSashihikiKingaku.ReadOnly = true;
            this.ColumnSashihikiKingaku.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnSashihikiKingaku.Width = 102;
            // 
            // ColumnHojoKamokuTouroku
            // 
            this.ColumnHojoKamokuTouroku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red;
            this.ColumnHojoKamokuTouroku.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColumnHojoKamokuTouroku.HeaderText = "";
            this.ColumnHojoKamokuTouroku.Name = "ColumnHojoKamokuTouroku";
            this.ColumnHojoKamokuTouroku.ReadOnly = true;
            this.ColumnHojoKamokuTouroku.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.statusbarMsgText});
            this.statusStrip.Location = new System.Drawing.Point(0, 434);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1012, 22);
            this.statusStrip.TabIndex = 47;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statusbarMsgText
            // 
            this.statusbarMsgText.Name = "statusbarMsgText";
            this.statusbarMsgText.Size = new System.Drawing.Size(0, 17);
            // 
            // panelGridFooter
            // 
            this.panelGridFooter.BackColor = System.Drawing.Color.White;
            this.panelGridFooter.Controls.Add(this.lblKarikataSum);
            this.panelGridFooter.Controls.Add(this.lblKashikataSum);
            this.panelGridFooter.Controls.Add(this.lblSashihikiSum);
            this.panelGridFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGridFooter.Location = new System.Drawing.Point(0, 406);
            this.panelGridFooter.Name = "panelGridFooter";
            this.panelGridFooter.Size = new System.Drawing.Size(1012, 28);
            this.panelGridFooter.TabIndex = 48;
            // 
            // lblKarikataSum
            // 
            this.lblKarikataSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKarikataSum.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKarikataSum.Location = new System.Drawing.Point(677, -1);
            this.lblKarikataSum.Name = "lblKarikataSum";
            this.lblKarikataSum.Size = new System.Drawing.Size(103, 30);
            this.lblKarikataSum.TabIndex = 0;
            this.lblKarikataSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKashikataSum
            // 
            this.lblKashikataSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKashikataSum.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKashikataSum.Location = new System.Drawing.Point(779, -1);
            this.lblKashikataSum.Name = "lblKashikataSum";
            this.lblKashikataSum.Size = new System.Drawing.Size(103, 30);
            this.lblKashikataSum.TabIndex = 1;
            this.lblKashikataSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSashihikiSum
            // 
            this.lblSashihikiSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSashihikiSum.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSashihikiSum.Location = new System.Drawing.Point(881, -1);
            this.lblSashihikiSum.Name = "lblSashihikiSum";
            this.lblSashihikiSum.Size = new System.Drawing.Size(103, 30);
            this.lblSashihikiSum.TabIndex = 2;
            this.lblSashihikiSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTargetKamoku
            // 
            this.lblTargetKamoku.BackColor = System.Drawing.SystemColors.Control;
            this.lblTargetKamoku.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTargetKamoku.ForeColor = System.Drawing.Color.Blue;
            this.lblTargetKamoku.Location = new System.Drawing.Point(625, 129);
            this.lblTargetKamoku.Name = "lblTargetKamoku";
            this.lblTargetKamoku.Size = new System.Drawing.Size(213, 18);
            this.lblTargetKamoku.TabIndex = 49;
            this.lblTargetKamoku.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTaragetKamokuKarikashiKubun
            // 
            this.lblTaragetKamokuKarikashiKubun.BackColor = System.Drawing.Color.White;
            this.lblTaragetKamokuKarikashiKubun.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTaragetKamokuKarikashiKubun.Location = new System.Drawing.Point(844, 128);
            this.lblTaragetKamokuKarikashiKubun.Name = "lblTaragetKamokuKarikashiKubun";
            this.lblTaragetKamokuKarikashiKubun.Size = new System.Drawing.Size(34, 15);
            this.lblTaragetKamokuKarikashiKubun.TabIndex = 50;
            // 
            // lblZengetsuKurikoshi
            // 
            this.lblZengetsuKurikoshi.BackColor = System.Drawing.Color.White;
            this.lblZengetsuKurikoshi.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblZengetsuKurikoshi.Location = new System.Drawing.Point(884, 128);
            this.lblZengetsuKurikoshi.Name = "lblZengetsuKurikoshi";
            this.lblZengetsuKurikoshi.Size = new System.Drawing.Size(102, 15);
            this.lblZengetsuKurikoshi.TabIndex = 51;
            this.lblZengetsuKurikoshi.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.dateEnd.Location = new System.Drawing.Point(299, 16);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(0);
            this.dateEnd.MarginGengou2Year = 3;
            this.dateEnd.MarginMonth2Day = 3;
            this.dateEnd.MarginYear2Month = 3;
            this.dateEnd.MonthStr = "";
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(165, 26);
            this.dateEnd.TabIndex = 1;
            this.dateEnd.TextBoxWidth = 38;
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
            this.dateStart.Location = new System.Drawing.Point(107, 16);
            this.dateStart.Margin = new System.Windows.Forms.Padding(0);
            this.dateStart.MarginGengou2Year = 3;
            this.dateStart.MarginMonth2Day = 3;
            this.dateStart.MarginYear2Month = 3;
            this.dateStart.MonthStr = "";
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(165, 26);
            this.dateStart.TabIndex = 0;
            this.dateStart.TextBoxWidth = 38;
            this.dateStart.YearStr = "";
            this.dateStart.TextBoxKeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.dateStart.TextBoxPreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // cmbKanjouKamoku
            // 
            this.cmbKanjouKamoku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKanjouKamoku.DropDownHeight = 300;
            this.cmbKanjouKamoku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKanjouKamoku.FormattingEnabled = true;
            this.cmbKanjouKamoku.IntegralHeight = false;
            this.cmbKanjouKamoku.Location = new System.Drawing.Point(171, 59);
            this.cmbKanjouKamoku.Name = "cmbKanjouKamoku";
            this.cmbKanjouKamoku.Size = new System.Drawing.Size(195, 23);
            this.cmbKanjouKamoku.TabIndex = 3;
            this.cmbKanjouKamoku.Enter += new System.EventHandler(this.cmbKamoku_Enter);
            this.cmbKanjouKamoku.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.cmbKanjouKamoku.Leave += new System.EventHandler(this.control_Leave);
            this.cmbKanjouKamoku.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // selectorKamokuCode
            // 
            this.selectorKamokuCode.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.selectorKamokuCode.Location = new System.Drawing.Point(107, 59);
            this.selectorKamokuCode.Name = "selectorKamokuCode";
            this.selectorKamokuCode.Size = new System.Drawing.Size(58, 22);
            this.selectorKamokuCode.TabIndex = 2;
            this.selectorKamokuCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.selectorKamokuCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.selectorKamokuCode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnDummy
            // 
            this.btnDummy.Location = new System.Drawing.Point(-300, 125);
            this.btnDummy.Name = "btnDummy";
            this.btnDummy.Size = new System.Drawing.Size(75, 23);
            this.btnDummy.TabIndex = 52;
            this.btnDummy.TabStop = false;
            this.btnDummy.Text = "Dummy(&D)";
            this.btnDummy.UseVisualStyleBackColor = true;
            this.btnDummy.Click += new System.EventHandler(this.btnDummy_Click);
            // 
            // KanjouMototyouForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 456);
            this.Controls.Add(this.btnDummy);
            this.Controls.Add(this.lblZengetsuKurikoshi);
            this.Controls.Add(this.lblTaragetKamokuKarikashiKubun);
            this.Controls.Add(this.lblTargetKamoku);
            this.Controls.Add(this.panelGridFooter);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panelHojoKamoku);
            this.Controls.Add(this.panelKaikeiKubun);
            this.Controls.Add(this.btnShowHojoMototyou);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.panelKamokuOrder);
            this.Controls.Add(this.cmbKanjouKamoku);
            this.Controls.Add(this.selectorKamokuCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnShowDenpyouView);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAddDenpyou);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkDenpyouSeiri);
            this.Name = "KanjouMototyouForm";
            this.Text = "KanjouMototyouForm";
            this.panelKamokuOrder.ResumeLayout(false);
            this.panelKamokuOrder.PerformLayout();
            this.panelKaikeiKubun.ResumeLayout(false);
            this.panelKaikeiKubun.PerformLayout();
            this.panelHojoKamoku.ResumeLayout(false);
            this.panelHojoKamoku.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelGridFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddDenpyou;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnShowDenpyouView;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private controls.KeySelectorTextBox selectorKamokuCode;
        private controls.MTComboBox cmbKanjouKamoku;
        private System.Windows.Forms.RadioButton radioKamokuOrderAlphabet;
        private System.Windows.Forms.RadioButton radioKamokuOrderCode;
        private System.Windows.Forms.Panel panelKamokuOrder;
        private controls.MTComboBox cmbHojoKamoku;
        private controls.KeySelectorTextBox selectorHojoKamoku;
        private System.Windows.Forms.Label label5;
        private controls.MTComboBox cmbKaikeiKubun;
        private controls.KeySelectorTextBox selectorKaikeiKubun;
        private controls.DateInputPanel dateStart;
        private controls.DateInputPanel dateEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowHojoMototyou;
        private System.Windows.Forms.Panel panelKaikeiKubun;
        private System.Windows.Forms.CheckBox checkDenpyouSeiri;
        private System.Windows.Forms.Panel panelHojoKamoku;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Panel panelGridFooter;
        private System.Windows.Forms.Label lblTargetKamoku;
        private System.Windows.Forms.Label lblTaragetKamokuKarikashiKubun;
        private System.Windows.Forms.Label lblZengetsuKurikoshi;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDetailButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDenpyouBangou;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKihyoubi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAiteKamoku;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKarikataKingaku;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKashikataKingaku;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSashihikiKingaku;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHojoKamokuTouroku;
        private System.Windows.Forms.Label lblSashihikiSum;
        private System.Windows.Forms.Label lblKashikataSum;
        private System.Windows.Forms.Label lblKarikataSum;
        private System.Windows.Forms.Button btnDummy;
        private System.Windows.Forms.ToolStripStatusLabel statusbarMsgText;
    }
}