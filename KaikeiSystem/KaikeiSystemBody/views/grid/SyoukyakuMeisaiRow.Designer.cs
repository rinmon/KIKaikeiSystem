namespace KaikeiSystemBody.views.grid
{
    partial class SyoukyakuMeisaiRow
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDenpyouHakkou = new System.Windows.Forms.Button();
            this.chkDenpyouHakkou = new System.Windows.Forms.CheckBox();
            this.amountKimatsuTyouboKagaku = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.amountGenkaSyoukyakuRuikeigaku = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.amountToukiGenkaSyoukyakuKagaku = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.amountKisyuTyouboKagaku = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTsukisuu = new System.Windows.Forms.TextBox();
            this.txtKaisuu = new System.Windows.Forms.TextBox();
            this.dateGensyoubi = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(1514, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 46);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "削除(&D)";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDenpyouHakkou
            // 
            this.btnDenpyouHakkou.Location = new System.Drawing.Point(1353, 2);
            this.btnDenpyouHakkou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDenpyouHakkou.Name = "btnDenpyouHakkou";
            this.btnDenpyouHakkou.Size = new System.Drawing.Size(150, 46);
            this.btnDenpyouHakkou.TabIndex = 8;
            this.btnDenpyouHakkou.Text = "伝票発行(&P)";
            this.btnDenpyouHakkou.UseVisualStyleBackColor = true;
            this.btnDenpyouHakkou.Click += new System.EventHandler(this.btnDenpyouHakkou_Click);
            // 
            // chkDenpyouHakkou
            // 
            this.chkDenpyouHakkou.AutoSize = true;
            this.chkDenpyouHakkou.Location = new System.Drawing.Point(1309, 14);
            this.chkDenpyouHakkou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkDenpyouHakkou.Name = "chkDenpyouHakkou";
            this.chkDenpyouHakkou.Size = new System.Drawing.Size(22, 21);
            this.chkDenpyouHakkou.TabIndex = 7;
            this.chkDenpyouHakkou.Tag = "denpyou_hakkou";
            this.chkDenpyouHakkou.UseVisualStyleBackColor = true;
            // 
            // amountKimatsuTyouboKagaku
            // 
            this.amountKimatsuTyouboKagaku.Amount = ((long)(0));
            this.amountKimatsuTyouboKagaku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountKimatsuTyouboKagaku.Location = new System.Drawing.Point(1102, 7);
            this.amountKimatsuTyouboKagaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountKimatsuTyouboKagaku.Name = "amountKimatsuTyouboKagaku";
            this.amountKimatsuTyouboKagaku.Size = new System.Drawing.Size(184, 33);
            this.amountKimatsuTyouboKagaku.TabIndex = 6;
            this.amountKimatsuTyouboKagaku.Tag = "kimatsu_tyoubo_kagaku";
            this.amountKimatsuTyouboKagaku.Text = "\\0";
            this.amountKimatsuTyouboKagaku.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amountGenkaSyoukyakuRuikeigaku
            // 
            this.amountGenkaSyoukyakuRuikeigaku.Amount = ((long)(0));
            this.amountGenkaSyoukyakuRuikeigaku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountGenkaSyoukyakuRuikeigaku.Location = new System.Drawing.Point(909, 7);
            this.amountGenkaSyoukyakuRuikeigaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountGenkaSyoukyakuRuikeigaku.Name = "amountGenkaSyoukyakuRuikeigaku";
            this.amountGenkaSyoukyakuRuikeigaku.Size = new System.Drawing.Size(184, 33);
            this.amountGenkaSyoukyakuRuikeigaku.TabIndex = 5;
            this.amountGenkaSyoukyakuRuikeigaku.Tag = "genka_syoukyaku_ruikeigaku";
            this.amountGenkaSyoukyakuRuikeigaku.Text = "\\0";
            this.amountGenkaSyoukyakuRuikeigaku.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amountToukiGenkaSyoukyakuKagaku
            // 
            this.amountToukiGenkaSyoukyakuKagaku.Amount = ((long)(0));
            this.amountToukiGenkaSyoukyakuKagaku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountToukiGenkaSyoukyakuKagaku.Location = new System.Drawing.Point(717, 7);
            this.amountToukiGenkaSyoukyakuKagaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountToukiGenkaSyoukyakuKagaku.Name = "amountToukiGenkaSyoukyakuKagaku";
            this.amountToukiGenkaSyoukyakuKagaku.Size = new System.Drawing.Size(184, 33);
            this.amountToukiGenkaSyoukyakuKagaku.TabIndex = 4;
            this.amountToukiGenkaSyoukyakuKagaku.Tag = "touki_genka_syoukyaku_kagaku";
            this.amountToukiGenkaSyoukyakuKagaku.Text = "\\0";
            this.amountToukiGenkaSyoukyakuKagaku.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amountKisyuTyouboKagaku
            // 
            this.amountKisyuTyouboKagaku.Amount = ((long)(0));
            this.amountKisyuTyouboKagaku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountKisyuTyouboKagaku.Location = new System.Drawing.Point(524, 7);
            this.amountKisyuTyouboKagaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountKisyuTyouboKagaku.Name = "amountKisyuTyouboKagaku";
            this.amountKisyuTyouboKagaku.Size = new System.Drawing.Size(184, 33);
            this.amountKisyuTyouboKagaku.TabIndex = 3;
            this.amountKisyuTyouboKagaku.Tag = "kisyu_tyoubo_kagaku";
            this.amountKisyuTyouboKagaku.Text = "\\0";
            this.amountKisyuTyouboKagaku.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(466, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "/12";
            // 
            // txtTsukisuu
            // 
            this.txtTsukisuu.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTsukisuu.Location = new System.Drawing.Point(396, 7);
            this.txtTsukisuu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTsukisuu.Name = "txtTsukisuu";
            this.txtTsukisuu.Size = new System.Drawing.Size(63, 33);
            this.txtTsukisuu.TabIndex = 2;
            this.txtTsukisuu.Tag = "tsukisuu";
            this.txtTsukisuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKaisuu
            // 
            this.txtKaisuu.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKaisuu.Location = new System.Drawing.Point(44, 7);
            this.txtKaisuu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKaisuu.Name = "txtKaisuu";
            this.txtKaisuu.Size = new System.Drawing.Size(70, 33);
            this.txtKaisuu.TabIndex = 0;
            this.txtKaisuu.Tag = "kaisuu";
            this.txtKaisuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateGensyoubi
            // 
            this.dateGensyoubi.AutoSize = true;
            this.dateGensyoubi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateGensyoubi.BackColor = System.Drawing.Color.Transparent;
            this.dateGensyoubi.Date = null;
            this.dateGensyoubi.DayStr = "";
            this.dateGensyoubi.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateGensyoubi.GengouStr = "";
            this.dateGensyoubi.Location = new System.Drawing.Point(149, 7);
            this.dateGensyoubi.Margin = new System.Windows.Forms.Padding(0);
            this.dateGensyoubi.MarginGengou2Year = 3;
            this.dateGensyoubi.MarginMonth2Day = 3;
            this.dateGensyoubi.MarginYear2Month = 3;
            this.dateGensyoubi.MonthStr = "";
            this.dateGensyoubi.Name = "dateGensyoubi";
            this.dateGensyoubi.Size = new System.Drawing.Size(217, 37);
            this.dateGensyoubi.TabIndex = 1;
            this.dateGensyoubi.Tag = "gensyoubi";
            this.dateGensyoubi.TextBoxWidth = 51;
            this.dateGensyoubi.YearStr = "";
            // 
            // SyoukyakuMeisaiRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.dateGensyoubi);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDenpyouHakkou);
            this.Controls.Add(this.chkDenpyouHakkou);
            this.Controls.Add(this.amountKimatsuTyouboKagaku);
            this.Controls.Add(this.amountGenkaSyoukyakuRuikeigaku);
            this.Controls.Add(this.amountToukiGenkaSyoukyakuKagaku);
            this.Controls.Add(this.amountKisyuTyouboKagaku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTsukisuu);
            this.Controls.Add(this.txtKaisuu);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SyoukyakuMeisaiRow";
            this.Size = new System.Drawing.Size(1795, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKaisuu;
        private System.Windows.Forms.TextBox txtTsukisuu;
        private System.Windows.Forms.Label label1;
        private controls.AmountTextBox amountKisyuTyouboKagaku;
        private controls.AmountTextBox amountToukiGenkaSyoukyakuKagaku;
        private controls.AmountTextBox amountGenkaSyoukyakuRuikeigaku;
        private controls.AmountTextBox amountKimatsuTyouboKagaku;
        private System.Windows.Forms.CheckBox chkDenpyouHakkou;
        private System.Windows.Forms.Button btnDenpyouHakkou;
        private System.Windows.Forms.Button btnDelete;
        private controls.DateInputPanel dateGensyoubi;
    }
}
