namespace KaikeiSystemBody.views.popup
{
    partial class KoteiShisanDetailPopup
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rowDetailSub = new KaikeiSystemBody.views.grid.KoteiShisanDetailSubRow();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeleteMeisai = new System.Windows.Forms.Button();
            this.btnSyoukyakuJikkou = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.syoukyakuMeisaiGrid1 = new KaikeiSystemBody.views.grid.SyoukyakuMeisaiGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIkkatsuSyoukyaku = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.rowDetailMain = new KaikeiSystemBody.views.grid.KoteiShisanDetailMainRow();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 332);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1729, 786);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.rowDetailSub);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Size = new System.Drawing.Size(1721, 751);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本情報";
            // 
            // rowDetailSub
            // 
            this.rowDetailSub.IsNewRow = false;
            this.rowDetailSub.Location = new System.Drawing.Point(11, 10);
            this.rowDetailSub.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.rowDetailSub.Name = "rowDetailSub";
            this.rowDetailSub.RowNo = 0;
            this.rowDetailSub.RowSelected = false;
            this.rowDetailSub.Size = new System.Drawing.Size(1624, 679);
            this.rowDetailSub.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btnDeleteMeisai);
            this.tabPage2.Controls.Add(this.btnSyoukyakuJikkou);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage2.Size = new System.Drawing.Size(1721, 751);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "償却明細";
            // 
            // btnDeleteMeisai
            // 
            this.btnDeleteMeisai.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteMeisai.Location = new System.Drawing.Point(237, 21);
            this.btnDeleteMeisai.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDeleteMeisai.Name = "btnDeleteMeisai";
            this.btnDeleteMeisai.Size = new System.Drawing.Size(213, 46);
            this.btnDeleteMeisai.TabIndex = 9;
            this.btnDeleteMeisai.Text = "明細削除(&D)";
            this.btnDeleteMeisai.UseVisualStyleBackColor = true;
            // 
            // btnSyoukyakuJikkou
            // 
            this.btnSyoukyakuJikkou.ForeColor = System.Drawing.Color.Black;
            this.btnSyoukyakuJikkou.Location = new System.Drawing.Point(15, 21);
            this.btnSyoukyakuJikkou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSyoukyakuJikkou.Name = "btnSyoukyakuJikkou";
            this.btnSyoukyakuJikkou.Size = new System.Drawing.Size(213, 46);
            this.btnSyoukyakuJikkou.TabIndex = 8;
            this.btnSyoukyakuJikkou.Text = "償却実行";
            this.btnSyoukyakuJikkou.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pnlLine);
            this.panel2.Controls.Add(this.syoukyakuMeisaiGrid1);
            this.panel2.Location = new System.Drawing.Point(11, 77);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1689, 650);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1305, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "伝票発行";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1102, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "期末帳簿価額";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(909, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "減価償却累計額";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(719, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "当期減価償却価額";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "期首帳簿価額";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "月数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "減少日";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "回数";
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.Black;
            this.pnlLine.Location = new System.Drawing.Point(0, 35);
            this.pnlLine.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(1692, 2);
            this.pnlLine.TabIndex = 1;
            // 
            // syoukyakuMeisaiGrid1
            // 
            this.syoukyakuMeisaiGrid1.DataCount = 0;
            this.syoukyakuMeisaiGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.syoukyakuMeisaiGrid1.Location = new System.Drawing.Point(0, 37);
            this.syoukyakuMeisaiGrid1.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.syoukyakuMeisaiGrid1.Name = "syoukyakuMeisaiGrid1";
            this.syoukyakuMeisaiGrid1.NewRowIsVisible = false;
            this.syoukyakuMeisaiGrid1.Size = new System.Drawing.Size(1685, 609);
            this.syoukyakuMeisaiGrid1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnIkkatsuSyoukyaku);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnEnd);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Location = new System.Drawing.Point(4, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1726, 55);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1597, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 46);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "閉じる(&X)";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnIkkatsuSyoukyaku
            // 
            this.btnIkkatsuSyoukyaku.ForeColor = System.Drawing.Color.Black;
            this.btnIkkatsuSyoukyaku.Location = new System.Drawing.Point(1392, 4);
            this.btnIkkatsuSyoukyaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnIkkatsuSyoukyaku.Name = "btnIkkatsuSyoukyaku";
            this.btnIkkatsuSyoukyaku.Size = new System.Drawing.Size(194, 46);
            this.btnIkkatsuSyoukyaku.TabIndex = 6;
            this.btnIkkatsuSyoukyaku.Text = "一括償却実行(&C)";
            this.btnIkkatsuSyoukyaku.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(1260, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 46);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "削除(&A)";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(1102, 4);
            this.btnNew.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(147, 46);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "新規登録(&A)";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.ForeColor = System.Drawing.Color.Blue;
            this.btnEnd.Location = new System.Drawing.Point(350, 4);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(103, 46);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "最後(&E)";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.ForeColor = System.Drawing.Color.Blue;
            this.btnNext.Location = new System.Drawing.Point(237, 4);
            this.btnNext.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(103, 46);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "次(&N)";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.ForeColor = System.Drawing.Color.Blue;
            this.btnPrev.Location = new System.Drawing.Point(123, 4);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(103, 46);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "前(&F)";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.ForeColor = System.Drawing.Color.Blue;
            this.btnFirst.Location = new System.Drawing.Point(9, 4);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(103, 46);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "先頭(&T)";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // rowDetailMain
            // 
            this.rowDetailMain.IsNewRow = false;
            this.rowDetailMain.Location = new System.Drawing.Point(4, 77);
            this.rowDetailMain.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.rowDetailMain.Name = "rowDetailMain";
            this.rowDetailMain.RowNo = 0;
            this.rowDetailMain.RowSelected = false;
            this.rowDetailMain.Size = new System.Drawing.Size(1729, 245);
            this.rowDetailMain.TabIndex = 1;
            // 
            // KoteiShisanDetailPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1738, 1139);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rowDetailMain);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "KoteiShisanDetailPopup";
            this.ShowInTaskbar = false;
            this.Text = "固定資産減価償却";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private grid.KoteiShisanDetailMainRow rowDetailMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnIkkatsuSyoukyaku;
        private System.Windows.Forms.Button btnClose;
        private grid.KoteiShisanDetailSubRow rowDetailSub;
        private grid.SyoukyakuMeisaiGrid syoukyakuMeisaiGrid1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSyoukyakuJikkou;
        private System.Windows.Forms.Button btnDeleteMeisai;

    }
}