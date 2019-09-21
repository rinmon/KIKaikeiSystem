namespace KaikeiSystemBody.views
{
    partial class ShikinSyuushiForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.daikubunGrid = new System.Windows.Forms.DataGridView();
            this.kamokuGrid = new System.Windows.Forms.DataGridView();
            this.groupKaikeiKubun = new System.Windows.Forms.GroupBox();
            this.radioKaikeiKubunSelect = new System.Windows.Forms.RadioButton();
            this.radioKaikeiKubunAll = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnShowJigyouSyuushi = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.summaryGrid = new System.Windows.Forms.DataGridView();
            this.ColumnKoumoku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKubun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnYosan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTaisyaku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDummy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.dateEnd = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.dateStart = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.ColumnKamoku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKingaku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDummy2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.daikubunGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamokuGrid)).BeginInit();
            this.groupKaikeiKubun.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summaryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "集計期間を入力して「計算」ボタンをクリックしてください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "起算日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(26, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "期末日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(435, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "会計区分";
            // 
            // daikubunGrid
            // 
            this.daikubunGrid.AllowUserToAddRows = false;
            this.daikubunGrid.AllowUserToDeleteRows = false;
            this.daikubunGrid.AllowUserToResizeColumns = false;
            this.daikubunGrid.AllowUserToResizeRows = false;
            this.daikubunGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daikubunGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnKoumoku,
            this.ColumnKubun,
            this.ColumnYosan,
            this.ColumnTaisyaku,
            this.ColumnSai,
            this.ColumnDummy});
            this.daikubunGrid.Location = new System.Drawing.Point(22, 158);
            this.daikubunGrid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.daikubunGrid.MultiSelect = false;
            this.daikubunGrid.Name = "daikubunGrid";
            this.daikubunGrid.ReadOnly = true;
            this.daikubunGrid.RowHeadersWidth = 24;
            this.daikubunGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.daikubunGrid.RowTemplate.Height = 21;
            this.daikubunGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.daikubunGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.daikubunGrid.Size = new System.Drawing.Size(1166, 674);
            this.daikubunGrid.TabIndex = 6;
            this.daikubunGrid.TabStop = false;
            this.daikubunGrid.SelectionChanged += new System.EventHandler(this.daikubunGrid_SelectionChanged);
            // 
            // kamokuGrid
            // 
            this.kamokuGrid.AllowUserToAddRows = false;
            this.kamokuGrid.AllowUserToDeleteRows = false;
            this.kamokuGrid.AllowUserToResizeColumns = false;
            this.kamokuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kamokuGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnKamoku,
            this.ColumnKingaku,
            this.ColumnDummy2});
            this.kamokuGrid.Location = new System.Drawing.Point(1203, 158);
            this.kamokuGrid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.kamokuGrid.MultiSelect = false;
            this.kamokuGrid.Name = "kamokuGrid";
            this.kamokuGrid.ReadOnly = true;
            this.kamokuGrid.RowHeadersWidth = 24;
            this.kamokuGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.kamokuGrid.RowTemplate.Height = 21;
            this.kamokuGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.kamokuGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kamokuGrid.Size = new System.Drawing.Size(638, 674);
            this.kamokuGrid.TabIndex = 7;
            this.kamokuGrid.TabStop = false;
            // 
            // groupKaikeiKubun
            // 
            this.groupKaikeiKubun.Controls.Add(this.cmbKaikeiKubun);
            this.groupKaikeiKubun.Controls.Add(this.radioKaikeiKubunSelect);
            this.groupKaikeiKubun.Controls.Add(this.radioKaikeiKubunAll);
            this.groupKaikeiKubun.Location = new System.Drawing.Point(561, 56);
            this.groupKaikeiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupKaikeiKubun.Name = "groupKaikeiKubun";
            this.groupKaikeiKubun.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupKaikeiKubun.Size = new System.Drawing.Size(917, 77);
            this.groupKaikeiKubun.TabIndex = 2;
            this.groupKaikeiKubun.TabStop = false;
            // 
            // radioKaikeiKubunSelect
            // 
            this.radioKaikeiKubunSelect.AutoSize = true;
            this.radioKaikeiKubunSelect.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioKaikeiKubunSelect.Location = new System.Drawing.Point(295, 26);
            this.radioKaikeiKubunSelect.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioKaikeiKubunSelect.Name = "radioKaikeiKubunSelect";
            this.radioKaikeiKubunSelect.Size = new System.Drawing.Size(235, 28);
            this.radioKaikeiKubunSelect.TabIndex = 1;
            this.radioKaikeiKubunSelect.TabStop = true;
            this.radioKaikeiKubunSelect.Text = "会計区分を指定する";
            this.radioKaikeiKubunSelect.UseVisualStyleBackColor = true;
            this.radioKaikeiKubunSelect.CheckedChanged += new System.EventHandler(this.radioKaikeiKubun_CheckedChanged);
            // 
            // radioKaikeiKubunAll
            // 
            this.radioKaikeiKubunAll.AutoSize = true;
            this.radioKaikeiKubunAll.Checked = true;
            this.radioKaikeiKubunAll.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioKaikeiKubunAll.Location = new System.Drawing.Point(31, 26);
            this.radioKaikeiKubunAll.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioKaikeiKubunAll.Name = "radioKaikeiKubunAll";
            this.radioKaikeiKubunAll.Size = new System.Drawing.Size(214, 28);
            this.radioKaikeiKubunAll.TabIndex = 0;
            this.radioKaikeiKubunAll.TabStop = true;
            this.radioKaikeiKubunAll.Text = "すべて（法人全体）";
            this.radioKaikeiKubunAll.UseVisualStyleBackColor = true;
            this.radioKaikeiKubunAll.CheckedChanged += new System.EventHandler(this.radioKaikeiKubun_CheckedChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(1507, 75);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(161, 49);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "計算(&C)";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1679, 75);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(161, 49);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.TabStop = false;
            this.btnReturn.Text = "メニューへ(&M)";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnShowJigyouSyuushi
            // 
            this.btnShowJigyouSyuushi.Location = new System.Drawing.Point(1604, 16);
            this.btnShowJigyouSyuushi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnShowJigyouSyuushi.Name = "btnShowJigyouSyuushi";
            this.btnShowJigyouSyuushi.Size = new System.Drawing.Size(237, 49);
            this.btnShowJigyouSyuushi.TabIndex = 11;
            this.btnShowJigyouSyuushi.TabStop = false;
            this.btnShowJigyouSyuushi.Text = "事業収支計算書(&J)";
            this.btnShowJigyouSyuushi.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 1144);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 26, 0);
            this.statusStrip.Size = new System.Drawing.Size(1866, 22);
            this.statusStrip.TabIndex = 13;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // summaryGrid
            // 
            this.summaryGrid.AllowUserToAddRows = false;
            this.summaryGrid.AllowUserToDeleteRows = false;
            this.summaryGrid.AllowUserToResizeColumns = false;
            this.summaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summaryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.Column2,
            this.dataGridViewTextBoxColumn3});
            this.summaryGrid.Location = new System.Drawing.Point(22, 858);
            this.summaryGrid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.summaryGrid.MultiSelect = false;
            this.summaryGrid.Name = "summaryGrid";
            this.summaryGrid.ReadOnly = true;
            this.summaryGrid.RowHeadersWidth = 24;
            this.summaryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.summaryGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.summaryGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.summaryGrid.RowTemplate.Height = 21;
            this.summaryGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.summaryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.summaryGrid.Size = new System.Drawing.Size(893, 240);
            this.summaryGrid.TabIndex = 14;
            this.summaryGrid.TabStop = false;
            // 
            // ColumnKoumoku
            // 
            this.ColumnKoumoku.Frozen = true;
            this.ColumnKoumoku.HeaderText = "資金収支項目";
            this.ColumnKoumoku.Name = "ColumnKoumoku";
            this.ColumnKoumoku.ReadOnly = true;
            this.ColumnKoumoku.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnKoumoku.Width = 288;
            // 
            // ColumnKubun
            // 
            this.ColumnKubun.Frozen = true;
            this.ColumnKubun.HeaderText = "大区分";
            this.ColumnKubun.Name = "ColumnKubun";
            this.ColumnKubun.ReadOnly = true;
            this.ColumnKubun.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnKubun.Width = 400;
            // 
            // ColumnYosan
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnYosan.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnYosan.Frozen = true;
            this.ColumnYosan.HeaderText = "予算";
            this.ColumnYosan.Name = "ColumnYosan";
            this.ColumnYosan.ReadOnly = true;
            this.ColumnYosan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnYosan.Width = 142;
            // 
            // ColumnTaisyaku
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnTaisyaku.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnTaisyaku.Frozen = true;
            this.ColumnTaisyaku.HeaderText = "貸借";
            this.ColumnTaisyaku.Name = "ColumnTaisyaku";
            this.ColumnTaisyaku.ReadOnly = true;
            this.ColumnTaisyaku.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnTaisyaku.Width = 142;
            // 
            // ColumnSai
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnSai.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnSai.Frozen = true;
            this.ColumnSai.HeaderText = "差異";
            this.ColumnSai.Name = "ColumnSai";
            this.ColumnSai.ReadOnly = true;
            this.ColumnSai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnSai.Width = 142;
            // 
            // ColumnDummy
            // 
            this.ColumnDummy.HeaderText = "";
            this.ColumnDummy.Name = "ColumnDummy";
            this.ColumnDummy.ReadOnly = true;
            this.ColumnDummy.Width = 36;
            // 
            // cmbKaikeiKubun
            // 
            this.cmbKaikeiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKaikeiKubun.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKaikeiKubun.FormattingEnabled = true;
            this.cmbKaikeiKubun.Location = new System.Drawing.Point(568, 23);
            this.cmbKaikeiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKaikeiKubun.Name = "cmbKaikeiKubun";
            this.cmbKaikeiKubun.Size = new System.Drawing.Size(334, 32);
            this.cmbKaikeiKubun.TabIndex = 2;
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
            this.dateEnd.Location = new System.Drawing.Point(123, 105);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(0);
            this.dateEnd.MarginGengou2Year = 11;
            this.dateEnd.MarginMonth2Day = 11;
            this.dateEnd.MarginYear2Month = 11;
            this.dateEnd.MonthStr = "";
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(269, 37);
            this.dateEnd.TabIndex = 1;
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
            this.dateStart.Location = new System.Drawing.Point(123, 58);
            this.dateStart.Margin = new System.Windows.Forms.Padding(0);
            this.dateStart.MarginGengou2Year = 11;
            this.dateStart.MarginMonth2Day = 11;
            this.dateStart.MarginYear2Month = 11;
            this.dateStart.MonthStr = "";
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(269, 37);
            this.dateStart.TabIndex = 0;
            this.dateStart.TextBoxWidth = 58;
            this.dateStart.YearStr = "";
            // 
            // ColumnKamoku
            // 
            this.ColumnKamoku.HeaderText = "科目";
            this.ColumnKamoku.Name = "ColumnKamoku";
            this.ColumnKamoku.ReadOnly = true;
            this.ColumnKamoku.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnKamoku.Width = 443;
            // 
            // ColumnKingaku
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnKingaku.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnKingaku.HeaderText = "金額";
            this.ColumnKingaku.Name = "ColumnKingaku";
            this.ColumnKingaku.ReadOnly = true;
            this.ColumnKingaku.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnKingaku.Width = 139;
            // 
            // ColumnDummy2
            // 
            this.ColumnDummy2.HeaderText = "";
            this.ColumnDummy2.Name = "ColumnDummy2";
            this.ColumnDummy2.ReadOnly = true;
            this.ColumnDummy2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDummy2.Width = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "項目";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 408;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn2.HeaderText = "予算";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 144;
            // 
            // Column1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column1.HeaderText = "貸借";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 144;
            // 
            // Column2
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column2.HeaderText = "差異";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Width = 144;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 37;
            // 
            // ShikinSyuushiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1866, 1166);
            this.Controls.Add(this.summaryGrid);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnShowJigyouSyuushi);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupKaikeiKubun);
            this.Controls.Add(this.kamokuGrid);
            this.Controls.Add(this.daikubunGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ShikinSyuushiForm";
            this.Text = "資金収支計算書";
            ((System.ComponentModel.ISupportInitialize)(this.daikubunGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamokuGrid)).EndInit();
            this.groupKaikeiKubun.ResumeLayout(false);
            this.groupKaikeiKubun.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summaryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private controls.DateInputPanel dateStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private controls.DateInputPanel dateEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView daikubunGrid;
        private System.Windows.Forms.DataGridView kamokuGrid;
        private System.Windows.Forms.GroupBox groupKaikeiKubun;
        private System.Windows.Forms.RadioButton radioKaikeiKubunAll;
        private System.Windows.Forms.RadioButton radioKaikeiKubunSelect;
        private controls.MTComboBox cmbKaikeiKubun;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnShowJigyouSyuushi;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.DataGridView summaryGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKoumoku;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKubun;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnYosan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTaisyaku;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDummy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKamoku;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKingaku;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDummy2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}