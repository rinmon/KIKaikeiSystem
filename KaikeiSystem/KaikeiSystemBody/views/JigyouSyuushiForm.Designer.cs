namespace KaikeiSystemBody.views
{
    partial class JigyouSyuushiForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.daikubunGrid = new System.Windows.Forms.DataGridView();
            this.ColumnKoumoku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKubun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCurrent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDummy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kamokuGrid = new System.Windows.Forms.DataGridView();
            this.ColumnKamoku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKingaku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDummy2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupKaikeiKubun = new System.Windows.Forms.GroupBox();
            this.cmbKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.radioKaikeiKubunSelect = new System.Windows.Forms.RadioButton();
            this.radioKaikeiKubunAll = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnShowShikinSyuushi = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.summaryGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEnd = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.dateStart = new KaikeiSystemBody.views.controls.DateInputPanel();
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
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "集計期間を入力して「計算」ボタンをクリックしてください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(14, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "起算日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "期末日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(237, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "会計区分";
            // 
            // daikubunGrid
            // 
            this.daikubunGrid.AllowUserToAddRows = false;
            this.daikubunGrid.AllowUserToDeleteRows = false;
            this.daikubunGrid.AllowUserToResizeColumns = false;
            this.daikubunGrid.AllowUserToResizeRows = false;
            this.daikubunGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnKoumoku,
            this.ColumnKubun,
            this.ColumnCurrent,
            this.ColumnPrev,
            this.ColumnSai,
            this.ColumnDummy});
            this.daikubunGrid.Location = new System.Drawing.Point(12, 90);
            this.daikubunGrid.MultiSelect = false;
            this.daikubunGrid.Name = "daikubunGrid";
            this.daikubunGrid.ReadOnly = true;
            this.daikubunGrid.RowHeadersWidth = 24;
            this.daikubunGrid.RowTemplate.Height = 21;
            this.daikubunGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.daikubunGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.daikubunGrid.Size = new System.Drawing.Size(636, 385);
            this.daikubunGrid.TabIndex = 6;
            this.daikubunGrid.TabStop = false;
            this.daikubunGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.daikubunGrid_CellContentClick);
            this.daikubunGrid.SelectionChanged += new System.EventHandler(this.daikubunGrid_SelectionChanged);
            // 
            // ColumnKoumoku
            // 
            this.ColumnKoumoku.FillWeight = 2F;
            this.ColumnKoumoku.HeaderText = "事業活動収支計算書項目";
            this.ColumnKoumoku.Name = "ColumnKoumoku";
            this.ColumnKoumoku.ReadOnly = true;
            this.ColumnKoumoku.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnKoumoku.Width = 308;
            // 
            // ColumnKubun
            // 
            this.ColumnKubun.FillWeight = 1.5F;
            this.ColumnKubun.HeaderText = "大区分";
            this.ColumnKubun.Name = "ColumnKubun";
            this.ColumnKubun.ReadOnly = true;
            this.ColumnKubun.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnKubun.Width = 428;
            // 
            // ColumnCurrent
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnCurrent.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnCurrent.FillWeight = 1F;
            this.ColumnCurrent.HeaderText = "本年";
            this.ColumnCurrent.Name = "ColumnCurrent";
            this.ColumnCurrent.ReadOnly = true;
            this.ColumnCurrent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCurrent.Width = 124;
            // 
            // ColumnPrev
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnPrev.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnPrev.FillWeight = 1F;
            this.ColumnPrev.HeaderText = "前年";
            this.ColumnPrev.Name = "ColumnPrev";
            this.ColumnPrev.ReadOnly = true;
            this.ColumnPrev.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPrev.Width = 124;
            // 
            // ColumnSai
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnSai.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnSai.FillWeight = 10F;
            this.ColumnSai.HeaderText = "差異";
            this.ColumnSai.Name = "ColumnSai";
            this.ColumnSai.ReadOnly = true;
            this.ColumnSai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnSai.Width = 124;
            // 
            // ColumnDummy
            // 
            this.ColumnDummy.FillWeight = 0.1F;
            this.ColumnDummy.HeaderText = "";
            this.ColumnDummy.Name = "ColumnDummy";
            this.ColumnDummy.ReadOnly = true;
            this.ColumnDummy.Width = 37;
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
            this.kamokuGrid.Location = new System.Drawing.Point(656, 90);
            this.kamokuGrid.MultiSelect = false;
            this.kamokuGrid.Name = "kamokuGrid";
            this.kamokuGrid.ReadOnly = true;
            this.kamokuGrid.RowHeadersWidth = 24;
            this.kamokuGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.kamokuGrid.RowTemplate.Height = 21;
            this.kamokuGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.kamokuGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kamokuGrid.Size = new System.Drawing.Size(348, 385);
            this.kamokuGrid.TabIndex = 7;
            this.kamokuGrid.TabStop = false;
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
            this.ColumnKingaku.Width = 139;
            // 
            // ColumnDummy2
            // 
            this.ColumnDummy2.HeaderText = "";
            this.ColumnDummy2.Name = "ColumnDummy2";
            this.ColumnDummy2.ReadOnly = true;
            this.ColumnDummy2.Width = 37;
            // 
            // groupKaikeiKubun
            // 
            this.groupKaikeiKubun.Controls.Add(this.cmbKaikeiKubun);
            this.groupKaikeiKubun.Controls.Add(this.radioKaikeiKubunSelect);
            this.groupKaikeiKubun.Controls.Add(this.radioKaikeiKubunAll);
            this.groupKaikeiKubun.Location = new System.Drawing.Point(306, 32);
            this.groupKaikeiKubun.Name = "groupKaikeiKubun";
            this.groupKaikeiKubun.Size = new System.Drawing.Size(500, 44);
            this.groupKaikeiKubun.TabIndex = 2;
            this.groupKaikeiKubun.TabStop = false;
            // 
            // cmbKaikeiKubun
            // 
            this.cmbKaikeiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKaikeiKubun.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKaikeiKubun.FormattingEnabled = true;
            this.cmbKaikeiKubun.Location = new System.Drawing.Point(310, 13);
            this.cmbKaikeiKubun.Name = "cmbKaikeiKubun";
            this.cmbKaikeiKubun.Size = new System.Drawing.Size(184, 22);
            this.cmbKaikeiKubun.TabIndex = 2;
            // 
            // radioKaikeiKubunSelect
            // 
            this.radioKaikeiKubunSelect.AutoSize = true;
            this.radioKaikeiKubunSelect.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioKaikeiKubunSelect.Location = new System.Drawing.Point(161, 15);
            this.radioKaikeiKubunSelect.Name = "radioKaikeiKubunSelect";
            this.radioKaikeiKubunSelect.Size = new System.Drawing.Size(143, 18);
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
            this.radioKaikeiKubunAll.Location = new System.Drawing.Point(17, 15);
            this.radioKaikeiKubunAll.Name = "radioKaikeiKubunAll";
            this.radioKaikeiKubunAll.Size = new System.Drawing.Size(129, 18);
            this.radioKaikeiKubunAll.TabIndex = 0;
            this.radioKaikeiKubunAll.TabStop = true;
            this.radioKaikeiKubunAll.Text = "すべて（法人全体）";
            this.radioKaikeiKubunAll.UseVisualStyleBackColor = true;
            this.radioKaikeiKubunAll.CheckedChanged += new System.EventHandler(this.radioKaikeiKubun_CheckedChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(822, 43);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(88, 28);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "計算(&C)";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(916, 43);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(88, 28);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.TabStop = false;
            this.btnReturn.Text = "メニューへ(&M)";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnShowShikinSyuushi
            // 
            this.btnShowShikinSyuushi.Location = new System.Drawing.Point(875, 9);
            this.btnShowShikinSyuushi.Name = "btnShowShikinSyuushi";
            this.btnShowShikinSyuushi.Size = new System.Drawing.Size(129, 28);
            this.btnShowShikinSyuushi.TabIndex = 11;
            this.btnShowShikinSyuushi.TabStop = false;
            this.btnShowShikinSyuushi.Text = "資金収支計算書(&S)";
            this.btnShowShikinSyuushi.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 485);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(796, 22);
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
            this.summaryGrid.Location = new System.Drawing.Point(12, 491);
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
            this.summaryGrid.Size = new System.Drawing.Size(487, 137);
            this.summaryGrid.TabIndex = 15;
            this.summaryGrid.TabStop = false;
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
            this.dataGridViewTextBoxColumn2.HeaderText = "本年";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 144;
            // 
            // Column1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column1.HeaderText = "前年";
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
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 37;
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
            this.dateEnd.Location = new System.Drawing.Point(67, 60);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(0);
            this.dateEnd.MonthStr = "";
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(146, 26);
            this.dateEnd.TabIndex = 1;
            this.dateEnd.TextBoxWidth = 31;
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
            this.dateStart.Location = new System.Drawing.Point(67, 33);
            this.dateStart.Margin = new System.Windows.Forms.Padding(0);
            this.dateStart.MonthStr = "";
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(146, 26);
            this.dateStart.TabIndex = 0;
            this.dateStart.TextBoxWidth = 31;
            this.dateStart.YearStr = "";
            // 
            // JigyouSyuushiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(796, 507);
            this.Controls.Add(this.summaryGrid);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnShowShikinSyuushi);
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
            this.Name = "JigyouSyuushiForm";
            this.Text = "事業収支計算書";
            this.Load += new System.EventHandler(this.jigyouSyuushiForm_load);
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
        private System.Windows.Forms.Button btnShowShikinSyuushi;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.DataGridView summaryGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKoumoku;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKubun;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCurrent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrev;
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