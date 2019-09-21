namespace KaikeiSystemBody.views.popup
{
    partial class TekiyouPopup
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKamokuStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddTekiyou = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioSortTypeCode = new System.Windows.Forms.RadioButton();
            this.radioSortTypeAlphabet = new System.Windows.Forms.RadioButton();
            this.cmbFirstChar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.ColumnHeadersVisible = false;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colKamokuStr});
            this.grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid.Location = new System.Drawing.Point(0, 112);
            this.grid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 21;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(614, 317);
            this.grid.TabIndex = 6;
            this.grid.Click += new System.EventHandler(this.grid_Click);
            // 
            // colCode
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.colCode.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCode.HeaderText = "コード";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCode.Width = 60;
            // 
            // colKamokuStr
            // 
            this.colKamokuStr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.colKamokuStr.DefaultCellStyle = dataGridViewCellStyle2;
            this.colKamokuStr.HeaderText = "科目";
            this.colKamokuStr.Name = "colKamokuStr";
            this.colKamokuStr.ReadOnly = true;
            this.colKamokuStr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(455, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "閉じる(&X)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddTekiyou
            // 
            this.btnAddTekiyou.Location = new System.Drawing.Point(301, 7);
            this.btnAddTekiyou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAddTekiyou.Name = "btnAddTekiyou";
            this.btnAddTekiyou.Size = new System.Drawing.Size(152, 46);
            this.btnAddTekiyou.TabIndex = 5;
            this.btnAddTekiyou.Text = "摘要追加(&A)";
            this.btnAddTekiyou.UseVisualStyleBackColor = true;
            this.btnAddTekiyou.Click += new System.EventHandler(this.btnAddTekiyou_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(95, 72);
            this.lblCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(57, 21);
            this.lblCode.TabIndex = 7;
            this.lblCode.Text = "コード";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "科目";
            // 
            // radioSortTypeCode
            // 
            this.radioSortTypeCode.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioSortTypeCode.AutoSize = true;
            this.radioSortTypeCode.ForeColor = System.Drawing.Color.Blue;
            this.radioSortTypeCode.Location = new System.Drawing.Point(523, 56);
            this.radioSortTypeCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioSortTypeCode.Name = "radioSortTypeCode";
            this.radioSortTypeCode.Padding = new System.Windows.Forms.Padding(4);
            this.radioSortTypeCode.Size = new System.Drawing.Size(75, 39);
            this.radioSortTypeCode.TabIndex = 4;
            this.radioSortTypeCode.TabStop = true;
            this.radioSortTypeCode.Tag = "tekiyou_code";
            this.radioSortTypeCode.Text = "コード";
            this.radioSortTypeCode.UseVisualStyleBackColor = true;
            this.radioSortTypeCode.CheckedChanged += new System.EventHandler(this.radioSortType_CheckedChanged);
            // 
            // radioSortTypeAlphabet
            // 
            this.radioSortTypeAlphabet.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioSortTypeAlphabet.AutoSize = true;
            this.radioSortTypeAlphabet.ForeColor = System.Drawing.Color.Blue;
            this.radioSortTypeAlphabet.Location = new System.Drawing.Point(420, 56);
            this.radioSortTypeAlphabet.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioSortTypeAlphabet.Name = "radioSortTypeAlphabet";
            this.radioSortTypeAlphabet.Padding = new System.Windows.Forms.Padding(4);
            this.radioSortTypeAlphabet.Size = new System.Drawing.Size(91, 39);
            this.radioSortTypeAlphabet.TabIndex = 3;
            this.radioSortTypeAlphabet.TabStop = true;
            this.radioSortTypeAlphabet.Tag = "tekiyou_yomi";
            this.radioSortTypeAlphabet.Text = "五十音";
            this.radioSortTypeAlphabet.UseVisualStyleBackColor = true;
            this.radioSortTypeAlphabet.CheckedChanged += new System.EventHandler(this.radioSortType_CheckedChanged);
            // 
            // cmbFirstChar
            // 
            this.cmbFirstChar.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbFirstChar.FormattingEnabled = true;
            this.cmbFirstChar.Location = new System.Drawing.Point(22, 14);
            this.cmbFirstChar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbFirstChar.Name = "cmbFirstChar";
            this.cmbFirstChar.Size = new System.Drawing.Size(101, 34);
            this.cmbFirstChar.TabIndex = 0;
            this.cmbFirstChar.SelectedIndexChanged += new System.EventHandler(this.cmbFirstChar_SelectedIndexChanged);
            // 
            // TekiyouPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(614, 429);
            this.Controls.Add(this.radioSortTypeCode);
            this.Controls.Add(this.radioSortTypeAlphabet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnAddTekiyou);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbFirstChar);
            this.Controls.Add(this.grid);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "TekiyouPopup";
            this.ShowInTaskbar = false;
            this.Text = "勘定科目";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TekiyouPopup_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddTekiyou;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKamokuStr;
        private System.Windows.Forms.RadioButton radioSortTypeCode;
        private System.Windows.Forms.RadioButton radioSortTypeAlphabet;
        private System.Windows.Forms.ComboBox cmbFirstChar;
    }
}