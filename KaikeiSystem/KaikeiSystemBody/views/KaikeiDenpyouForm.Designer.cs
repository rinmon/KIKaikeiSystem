namespace KaikeiSystemBody.views
{
    partial class KaikeiDenpyouForm
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
            this.panelHeader1 = new System.Windows.Forms.Panel();
            this.lblKihyoubiStatus = new System.Windows.Forms.Label();
            this.dateKihyoubi = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.cmbTorihikiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.cmbKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.lblKihyoubi = new System.Windows.Forms.Label();
            this.lblTorihikiKubun = new System.Windows.Forms.Label();
            this.lblKaikeiKubun = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader2 = new System.Windows.Forms.Panel();
            this.groupShowData = new System.Windows.Forms.GroupBox();
            this.radioShowCurrentYearData = new System.Windows.Forms.RadioButton();
            this.radioShowAllData = new System.Windows.Forms.RadioButton();
            this.lblShowData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dbGrid = new KaikeiSystemBody.views.grid.KaikeiDenpyouGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUpdateDate = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnKanjouKamoku = new System.Windows.Forms.Button();
            this.btnTekiyou = new System.Windows.Forms.Button();
            this.btnNewRow = new System.Windows.Forms.Button();
            this.btnShowInvalidRow = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSubfunction = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.panelLine2 = new System.Windows.Forms.Panel();
            this.lblStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelHeader1.SuspendLayout();
            this.panelHeader2.SuspendLayout();
            this.groupShowData.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader1
            // 
            this.panelHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panelHeader1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHeader1.Controls.Add(this.lblKihyoubiStatus);
            this.panelHeader1.Controls.Add(this.dateKihyoubi);
            this.panelHeader1.Controls.Add(this.cmbTorihikiKubun);
            this.panelHeader1.Controls.Add(this.cmbKaikeiKubun);
            this.panelHeader1.Controls.Add(this.lblKihyoubi);
            this.panelHeader1.Controls.Add(this.lblTorihikiKubun);
            this.panelHeader1.Controls.Add(this.lblKaikeiKubun);
            this.panelHeader1.Controls.Add(this.label2);
            this.panelHeader1.Controls.Add(this.label1);
            this.panelHeader1.Location = new System.Drawing.Point(24, 2);
            this.panelHeader1.Name = "panelHeader1";
            this.panelHeader1.Size = new System.Drawing.Size(880, 44);
            this.panelHeader1.TabIndex = 1;
            // 
            // lblKihyoubiStatus
            // 
            this.lblKihyoubiStatus.AutoSize = true;
            this.lblKihyoubiStatus.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKihyoubiStatus.ForeColor = System.Drawing.Color.White;
            this.lblKihyoubiStatus.Location = new System.Drawing.Point(726, 32);
            this.lblKihyoubiStatus.Name = "lblKihyoubiStatus";
            this.lblKihyoubiStatus.Size = new System.Drawing.Size(0, 11);
            this.lblKihyoubiStatus.TabIndex = 13;
            this.lblKihyoubiStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateKihyoubi
            // 
            this.dateKihyoubi.AutoSize = true;
            this.dateKihyoubi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateKihyoubi.BackColor = System.Drawing.Color.Transparent;
            this.dateKihyoubi.Date = null;
            this.dateKihyoubi.DayStr = "";
            this.dateKihyoubi.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateKihyoubi.GengouStr = "";
            this.dateKihyoubi.Location = new System.Drawing.Point(623, 7);
            this.dateKihyoubi.Margin = new System.Windows.Forms.Padding(4);
            this.dateKihyoubi.MonthStr = "";
            this.dateKihyoubi.Name = "dateKihyoubi";
            this.dateKihyoubi.Size = new System.Drawing.Size(134, 26);
            this.dateKihyoubi.TabIndex = 3;
            this.dateKihyoubi.YearStr = "";
            this.dateKihyoubi.TextBoxKeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.dateKihyoubi.TextBoxPreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            this.dateKihyoubi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.dateKihyoubi.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // cmbTorihikiKubun
            // 
            this.cmbTorihikiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTorihikiKubun.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbTorihikiKubun.FormattingEnabled = true;
            this.cmbTorihikiKubun.Location = new System.Drawing.Point(455, 7);
            this.cmbTorihikiKubun.Name = "cmbTorihikiKubun";
            this.cmbTorihikiKubun.Size = new System.Drawing.Size(114, 23);
            this.cmbTorihikiKubun.TabIndex = 2;
            this.cmbTorihikiKubun.Enter += new System.EventHandler(this.cmbTorihikiKubun_Enter);
            this.cmbTorihikiKubun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.cmbTorihikiKubun.Leave += new System.EventHandler(this.control_Leave);
            this.cmbTorihikiKubun.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // cmbKaikeiKubun
            // 
            this.cmbKaikeiKubun.AutoFontSize = true;
            this.cmbKaikeiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKaikeiKubun.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKaikeiKubun.FormattingEnabled = true;
            this.cmbKaikeiKubun.Location = new System.Drawing.Point(165, 7);
            this.cmbKaikeiKubun.Name = "cmbKaikeiKubun";
            this.cmbKaikeiKubun.Size = new System.Drawing.Size(225, 23);
            this.cmbKaikeiKubun.TabIndex = 0;
            this.cmbKaikeiKubun.Enter += new System.EventHandler(this.cmbKaikeiTanni_Enter);
            this.cmbKaikeiKubun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.cmbKaikeiKubun.Leave += new System.EventHandler(this.control_Leave);
            this.cmbKaikeiKubun.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // lblKihyoubi
            // 
            this.lblKihyoubi.AutoSize = true;
            this.lblKihyoubi.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKihyoubi.ForeColor = System.Drawing.Color.White;
            this.lblKihyoubi.Location = new System.Drawing.Point(578, 7);
            this.lblKihyoubi.Name = "lblKihyoubi";
            this.lblKihyoubi.Size = new System.Drawing.Size(41, 24);
            this.lblKihyoubi.TabIndex = 8;
            this.lblKihyoubi.Text = "起票日\r\n(F11)";
            this.lblKihyoubi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTorihikiKubun
            // 
            this.lblTorihikiKubun.AutoSize = true;
            this.lblTorihikiKubun.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTorihikiKubun.ForeColor = System.Drawing.Color.White;
            this.lblTorihikiKubun.Location = new System.Drawing.Point(399, 7);
            this.lblTorihikiKubun.Name = "lblTorihikiKubun";
            this.lblTorihikiKubun.Size = new System.Drawing.Size(53, 24);
            this.lblTorihikiKubun.TabIndex = 5;
            this.lblTorihikiKubun.Text = "取引区分\r\n(F10)";
            this.lblTorihikiKubun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKaikeiKubun
            // 
            this.lblKaikeiKubun.AutoSize = true;
            this.lblKaikeiKubun.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKaikeiKubun.ForeColor = System.Drawing.Color.White;
            this.lblKaikeiKubun.Location = new System.Drawing.Point(106, 8);
            this.lblKaikeiKubun.Name = "lblKaikeiKubun";
            this.lblKaikeiKubun.Size = new System.Drawing.Size(53, 24);
            this.lblKaikeiKubun.TabIndex = 2;
            this.lblKaikeiKubun.Text = "会計区分\r\n(F8)";
            this.lblKaikeiKubun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(1, 1, 3, 3);
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "F12キーで明細へ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "作成する伝票";
            // 
            // panelHeader2
            // 
            this.panelHeader2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panelHeader2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHeader2.Controls.Add(this.groupShowData);
            this.panelHeader2.Controls.Add(this.lblShowData);
            this.panelHeader2.Controls.Add(this.label3);
            this.panelHeader2.Location = new System.Drawing.Point(24, 45);
            this.panelHeader2.Name = "panelHeader2";
            this.panelHeader2.Size = new System.Drawing.Size(880, 36);
            this.panelHeader2.TabIndex = 2;
            // 
            // groupShowData
            // 
            this.groupShowData.Controls.Add(this.radioShowCurrentYearData);
            this.groupShowData.Controls.Add(this.radioShowAllData);
            this.groupShowData.Location = new System.Drawing.Point(178, -2);
            this.groupShowData.Name = "groupShowData";
            this.groupShowData.Size = new System.Drawing.Size(250, 31);
            this.groupShowData.TabIndex = 4;
            this.groupShowData.TabStop = false;
            // 
            // radioShowCurrentYearData
            // 
            this.radioShowCurrentYearData.AutoSize = true;
            this.radioShowCurrentYearData.ForeColor = System.Drawing.Color.White;
            this.radioShowCurrentYearData.Location = new System.Drawing.Point(132, 10);
            this.radioShowCurrentYearData.Name = "radioShowCurrentYearData";
            this.radioShowCurrentYearData.Size = new System.Drawing.Size(97, 16);
            this.radioShowCurrentYearData.TabIndex = 1;
            this.radioShowCurrentYearData.TabStop = true;
            this.radioShowCurrentYearData.Text = "当年度のデータ";
            this.radioShowCurrentYearData.UseVisualStyleBackColor = true;
            this.radioShowCurrentYearData.Enter += new System.EventHandler(this.radioShowData_Enter);
            // 
            // radioShowAllData
            // 
            this.radioShowAllData.AutoSize = true;
            this.radioShowAllData.ForeColor = System.Drawing.Color.White;
            this.radioShowAllData.Location = new System.Drawing.Point(13, 10);
            this.radioShowAllData.Name = "radioShowAllData";
            this.radioShowAllData.Size = new System.Drawing.Size(90, 16);
            this.radioShowAllData.TabIndex = 0;
            this.radioShowAllData.TabStop = true;
            this.radioShowAllData.Text = "すべてのデータ";
            this.radioShowAllData.UseVisualStyleBackColor = true;
            this.radioShowAllData.Enter += new System.EventHandler(this.radioShowData_Enter);
            // 
            // lblShowData
            // 
            this.lblShowData.AutoSize = true;
            this.lblShowData.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblShowData.ForeColor = System.Drawing.Color.White;
            this.lblShowData.Location = new System.Drawing.Point(106, 6);
            this.lblShowData.Name = "lblShowData";
            this.lblShowData.Size = new System.Drawing.Size(53, 12);
            this.lblShowData.TabIndex = 3;
            this.lblShowData.Text = "表示対象";
            this.lblShowData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(7, 2);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1, 1, 3, 3);
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "F2キーで直前値\r\nコピー";
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.BackColor = System.Drawing.SystemColors.Control;
            this.panelGrid.Controls.Add(this.dbGrid);
            this.panelGrid.Location = new System.Drawing.Point(0, 132);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1022, 346);
            this.panelGrid.TabIndex = 37;
            this.panelGrid.TabStop = true;
            // 
            // dbGrid
            // 
            this.dbGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbGrid.DataCount = 0;
            this.dbGrid.Location = new System.Drawing.Point(0, 0);
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.NewRowIsVisible = false;
            this.dbGrid.Size = new System.Drawing.Size(1022, 346);
            this.dbGrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::KaikeiSystemBody.Properties.Resources.denpyou_grid_header;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblUpdateDate);
            this.panel1.Controls.Add(this.lblCreateDate);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(19, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 49);
            this.panel1.TabIndex = 4;
            // 
            // lblUpdateDate
            // 
            this.lblUpdateDate.AutoSize = true;
            this.lblUpdateDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblUpdateDate.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblUpdateDate.Location = new System.Drawing.Point(830, 11);
            this.lblUpdateDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblUpdateDate.Name = "lblUpdateDate";
            this.lblUpdateDate.Size = new System.Drawing.Size(52, 15);
            this.lblUpdateDate.TabIndex = 2;
            this.lblUpdateDate.Text = "更新日";
            this.lblUpdateDate.Visible = false;
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCreateDate.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCreateDate.Location = new System.Drawing.Point(830, 11);
            this.lblCreateDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(52, 15);
            this.lblCreateDate.TabIndex = 1;
            this.lblCreateDate.Text = "登録日";
            this.lblCreateDate.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblId.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblId.Location = new System.Drawing.Point(718, 34);
            this.lblId.Margin = new System.Windows.Forms.Padding(0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(39, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "U-ID";
            this.lblId.Visible = false;
            // 
            // btnKanjouKamoku
            // 
            this.btnKanjouKamoku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKanjouKamoku.Location = new System.Drawing.Point(12, 0);
            this.btnKanjouKamoku.Name = "btnKanjouKamoku";
            this.btnKanjouKamoku.Size = new System.Drawing.Size(90, 28);
            this.btnKanjouKamoku.TabIndex = 38;
            this.btnKanjouKamoku.Text = "勘定科目(&C)";
            this.btnKanjouKamoku.UseVisualStyleBackColor = true;
            this.btnKanjouKamoku.Enter += new System.EventHandler(this.btnKanjouKamoku_Enter);
            this.btnKanjouKamoku.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnKanjouKamoku.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnTekiyou
            // 
            this.btnTekiyou.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTekiyou.Location = new System.Drawing.Point(907, 0);
            this.btnTekiyou.Name = "btnTekiyou";
            this.btnTekiyou.Size = new System.Drawing.Size(90, 28);
            this.btnTekiyou.TabIndex = 39;
            this.btnTekiyou.Text = "摘要(&R)";
            this.btnTekiyou.UseVisualStyleBackColor = true;
            this.btnTekiyou.Enter += new System.EventHandler(this.btnTekiyou_Enter);
            this.btnTekiyou.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnTekiyou.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnNewRow
            // 
            this.btnNewRow.Location = new System.Drawing.Point(0, 0);
            this.btnNewRow.Name = "btnNewRow";
            this.btnNewRow.Size = new System.Drawing.Size(90, 28);
            this.btnNewRow.TabIndex = 0;
            this.btnNewRow.Text = "新規登録(&N)";
            this.btnNewRow.UseVisualStyleBackColor = true;
            this.btnNewRow.Enter += new System.EventHandler(this.btnNewRecord_Enter);
            this.btnNewRow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnNewRow.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnShowInvalidRow
            // 
            this.btnShowInvalidRow.Location = new System.Drawing.Point(0, 81);
            this.btnShowInvalidRow.Name = "btnShowInvalidRow";
            this.btnShowInvalidRow.Size = new System.Drawing.Size(90, 28);
            this.btnShowInvalidRow.TabIndex = 3;
            this.btnShowInvalidRow.Text = "伝票確認(&C)";
            this.btnShowInvalidRow.UseVisualStyleBackColor = true;
            this.btnShowInvalidRow.Enter += new System.EventHandler(this.btnShowInvalidRow_Enter);
            this.btnShowInvalidRow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnShowInvalidRow.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(0, 27);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 28);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "メニューへ(&M)";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Enter += new System.EventHandler(this.btnReturn_Enter);
            this.btnReturn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnReturn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnSubfunction
            // 
            this.btnSubfunction.Location = new System.Drawing.Point(0, 54);
            this.btnSubfunction.Name = "btnSubfunction";
            this.btnSubfunction.Size = new System.Drawing.Size(90, 28);
            this.btnSubfunction.TabIndex = 2;
            this.btnSubfunction.Text = "補助機能(&S)";
            this.btnSubfunction.UseVisualStyleBackColor = true;
            this.btnSubfunction.Enter += new System.EventHandler(this.btnSubfunction_Enter);
            this.btnSubfunction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnSubfunction.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // panelFooter
            // 
            this.panelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelFooter.Controls.Add(this.btnKanjouKamoku);
            this.panelFooter.Controls.Add(this.btnTekiyou);
            this.panelFooter.Location = new System.Drawing.Point(0, 483);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1000, 28);
            this.panelFooter.TabIndex = 5;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnNewRow);
            this.panelMenu.Controls.Add(this.btnReturn);
            this.panelMenu.Controls.Add(this.btnShowInvalidRow);
            this.panelMenu.Controls.Add(this.btnSubfunction);
            this.panelMenu.Location = new System.Drawing.Point(907, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(94, 110);
            this.panelMenu.TabIndex = 3;
            // 
            // panelLine1
            // 
            this.panelLine1.BackColor = System.Drawing.Color.Red;
            this.panelLine1.Location = new System.Drawing.Point(-1, 130);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(1000, 2);
            this.panelLine1.TabIndex = 0;
            // 
            // panelLine2
            // 
            this.panelLine2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLine2.BackColor = System.Drawing.Color.Red;
            this.panelLine2.Location = new System.Drawing.Point(0, 478);
            this.panelLine2.Name = "panelLine2";
            this.panelLine2.Size = new System.Drawing.Size(1000, 2);
            this.panelLine2.TabIndex = 41;
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1022, 22);
            this.statusStrip1.TabIndex = 42;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // KaikeiDenpyouForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1022, 538);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelLine2);
            this.Controls.Add(this.panelLine1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelHeader2);
            this.Controls.Add(this.panelHeader1);
            this.DoubleBuffered = true;
            this.Name = "KaikeiDenpyouForm";
            this.Text = "会計伝票";
            this.panelHeader1.ResumeLayout(false);
            this.panelHeader1.PerformLayout();
            this.panelHeader2.ResumeLayout(false);
            this.panelHeader2.PerformLayout();
            this.groupShowData.ResumeLayout(false);
            this.groupShowData.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTorihikiKubun;
        private System.Windows.Forms.Label lblKaikeiKubun;
        private System.Windows.Forms.Label lblKihyoubi;
        private System.Windows.Forms.Panel panelHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblShowData;
        private System.Windows.Forms.GroupBox groupShowData;
        private System.Windows.Forms.RadioButton radioShowAllData;
        private System.Windows.Forms.RadioButton radioShowCurrentYearData;
        private System.Windows.Forms.Label lblKihyoubiStatus;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Button btnKanjouKamoku;
        private System.Windows.Forms.Button btnTekiyou;
        private grid.KaikeiDenpyouGrid dbGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewRow;
        private System.Windows.Forms.Button btnShowInvalidRow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSubfunction;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.Panel panelLine2;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMessage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.Label lblUpdateDate;
        private controls.MTComboBox cmbKaikeiKubun;
        private controls.MTComboBox cmbTorihikiKubun;
        private controls.DateInputPanel dateKihyoubi;
    }
}