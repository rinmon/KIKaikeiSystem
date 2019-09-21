namespace KaikeiSystemBody.views
{
    partial class KurikoshiSyoriForm
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
            this.openDBFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnRecalc = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentYear = new System.Windows.Forms.TextBox();
            this.dateNextYear = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(422, 214);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(189, 49);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "閉じる(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // openDBFileDialog
            // 
            this.openDBFileDialog.FileName = "openFileDialog1";
            this.openDBFileDialog.Filter = "Sqlite DB File|*.db";
            this.openDBFileDialog.Title = "Select DB";
            // 
            // btnRecalc
            // 
            this.btnRecalc.Enabled = false;
            this.btnRecalc.Location = new System.Drawing.Point(22, 214);
            this.btnRecalc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRecalc.Name = "btnRecalc";
            this.btnRecalc.Size = new System.Drawing.Size(189, 49);
            this.btnRecalc.TabIndex = 2;
            this.btnRecalc.Text = "再計算(&R)";
            this.btnRecalc.UseVisualStyleBackColor = true;
            this.btnRecalc.Visible = false;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(222, 214);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(189, 49);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "実行(&E)";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "新規登録年度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "現在の年度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(22, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(533, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "※指定された年度以前のデータの登録編集はできなくなります。";
            // 
            // txtCurrentYear
            // 
            this.txtCurrentYear.Enabled = false;
            this.txtCurrentYear.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.txtCurrentYear.Location = new System.Drawing.Point(222, 94);
            this.txtCurrentYear.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCurrentYear.Name = "txtCurrentYear";
            this.txtCurrentYear.Size = new System.Drawing.Size(169, 33);
            this.txtCurrentYear.TabIndex = 1;
            this.txtCurrentYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateNextYear
            // 
            this.dateNextYear.AutoSize = true;
            this.dateNextYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateNextYear.BackColor = System.Drawing.Color.Transparent;
            this.dateNextYear.Date = null;
            this.dateNextYear.DayStr = "1";
            this.dateNextYear.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateNextYear.GengouStr = "";
            this.dateNextYear.Location = new System.Drawing.Point(222, 44);
            this.dateNextYear.Margin = new System.Windows.Forms.Padding(0);
            this.dateNextYear.MarginGengou2Year = 11;
            this.dateNextYear.MarginMonth2Day = 11;
            this.dateNextYear.MarginYear2Month = 11;
            this.dateNextYear.MonthStr = "4";
            this.dateNextYear.Name = "dateNextYear";
            this.dateNextYear.Size = new System.Drawing.Size(175, 37);
            this.dateNextYear.TabIndex = 0;
            this.dateNextYear.TextBoxWidth = 80;
            this.dateNextYear.ViewType = KaikeiSystemBody.views.controls.DateInputPanel.ViewTypeEnum.WarekiYear;
            this.dateNextYear.YearStr = "";
            // 
            // KurikoshiSyoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(634, 292);
            this.Controls.Add(this.dateNextYear);
            this.Controls.Add(this.txtCurrentYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnRecalc);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "KurikoshiSyoriForm";
            this.Text = "繰越処理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog openDBFileDialog;
        private System.Windows.Forms.Button btnRecalc;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrentYear;
        private controls.DateInputPanel dateNextYear;

    }
}