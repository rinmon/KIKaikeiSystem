namespace KaikeiSystemBody.views
{
    partial class RootMenuForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMargeDBKanjouKamoku = new System.Windows.Forms.Button();
            this.txtMargeDBFilePath = new System.Windows.Forms.TextBox();
            this.btnShowOpenDBFileDlg = new System.Windows.Forms.Button();
            this.openDBFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(805, 396);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(189, 49);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMargeDBKanjouKamoku
            // 
            this.btnMargeDBKanjouKamoku.Location = new System.Drawing.Point(700, 187);
            this.btnMargeDBKanjouKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMargeDBKanjouKamoku.Name = "btnMargeDBKanjouKamoku";
            this.btnMargeDBKanjouKamoku.Size = new System.Drawing.Size(249, 49);
            this.btnMargeDBKanjouKamoku.TabIndex = 3;
            this.btnMargeDBKanjouKamoku.Text = "勘定科目の結合";
            this.btnMargeDBKanjouKamoku.UseVisualStyleBackColor = true;
            this.btnMargeDBKanjouKamoku.Click += new System.EventHandler(this.btnMargeDBKanjouKamoku_Click);
            // 
            // txtMargeDBFilePath
            // 
            this.txtMargeDBFilePath.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.txtMargeDBFilePath.Location = new System.Drawing.Point(11, 84);
            this.txtMargeDBFilePath.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMargeDBFilePath.Name = "txtMargeDBFilePath";
            this.txtMargeDBFilePath.Size = new System.Drawing.Size(833, 33);
            this.txtMargeDBFilePath.TabIndex = 0;
            // 
            // btnShowOpenDBFileDlg
            // 
            this.btnShowOpenDBFileDlg.Location = new System.Drawing.Point(858, 80);
            this.btnShowOpenDBFileDlg.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnShowOpenDBFileDlg.Name = "btnShowOpenDBFileDlg";
            this.btnShowOpenDBFileDlg.Size = new System.Drawing.Size(92, 49);
            this.btnShowOpenDBFileDlg.TabIndex = 1;
            this.btnShowOpenDBFileDlg.Text = "参照";
            this.btnShowOpenDBFileDlg.UseVisualStyleBackColor = true;
            this.btnShowOpenDBFileDlg.Click += new System.EventHandler(this.btnShowOpenDBFileDlg_Click);
            // 
            // openDBFileDialog
            // 
            this.openDBFileDialog.FileName = "openFileDialog1";
            this.openDBFileDialog.Filter = "Sqlite DB File|*.db";
            this.openDBFileDialog.Title = "Select DB";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnShowOpenDBFileDlg);
            this.groupBox1.Controls.Add(this.btnMargeDBKanjouKamoku);
            this.groupBox1.Controls.Add(this.txtMargeDBFilePath);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.groupBox1.Location = new System.Drawing.Point(22, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(972, 268);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "データベースファイルの結合";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 187);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "伝票の結合";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "結合するDB";
            // 
            // RootMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1016, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "RootMenuForm";
            this.Text = "管理者コマンド";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMargeDBKanjouKamoku;
        private System.Windows.Forms.TextBox txtMargeDBFilePath;
        private System.Windows.Forms.Button btnShowOpenDBFileDlg;
        private System.Windows.Forms.OpenFileDialog openDBFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;

    }
}