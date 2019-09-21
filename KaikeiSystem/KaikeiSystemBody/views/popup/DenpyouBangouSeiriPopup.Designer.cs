namespace KaikeiSystemBody.views.popup
{
    partial class DenpyouBangouSeiriPopup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOrderByKihyoubiAndNo = new System.Windows.Forms.Button();
            this.btnOrderByKaikeiKubunAndKihyoubiAndNo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReturnToSubfunctionPopup = new System.Windows.Forms.Button();
            this.dateTarget = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(51, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "元号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(517, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(350, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "年";
            // 
            // btnOrderByKihyoubiAndNo
            // 
            this.btnOrderByKihyoubiAndNo.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOrderByKihyoubiAndNo.Location = new System.Drawing.Point(57, 138);
            this.btnOrderByKihyoubiAndNo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOrderByKihyoubiAndNo.Name = "btnOrderByKihyoubiAndNo";
            this.btnOrderByKihyoubiAndNo.Size = new System.Drawing.Size(501, 51);
            this.btnOrderByKihyoubiAndNo.TabIndex = 1;
            this.btnOrderByKihyoubiAndNo.Text = "[起票日]-[No]の順に並べ替えを実行";
            this.btnOrderByKihyoubiAndNo.UseVisualStyleBackColor = true;
            this.btnOrderByKihyoubiAndNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnOrderByKihyoubiAndNo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnOrderByKaikeiKubunAndKihyoubiAndNo
            // 
            this.btnOrderByKaikeiKubunAndKihyoubiAndNo.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOrderByKaikeiKubunAndKihyoubiAndNo.Location = new System.Drawing.Point(57, 200);
            this.btnOrderByKaikeiKubunAndKihyoubiAndNo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOrderByKaikeiKubunAndKihyoubiAndNo.Name = "btnOrderByKaikeiKubunAndKihyoubiAndNo";
            this.btnOrderByKaikeiKubunAndKihyoubiAndNo.Size = new System.Drawing.Size(501, 51);
            this.btnOrderByKaikeiKubunAndKihyoubiAndNo.TabIndex = 2;
            this.btnOrderByKaikeiKubunAndKihyoubiAndNo.Text = "会計区分ごとに[起票日]-[No]の順に並べ替えを実行";
            this.btnOrderByKaikeiKubunAndKihyoubiAndNo.UseVisualStyleBackColor = true;
            this.btnOrderByKaikeiKubunAndKihyoubiAndNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnOrderByKaikeiKubunAndKihyoubiAndNo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(57, 261);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(501, 51);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnClose.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // btnReturnToSubfunctionPopup
            // 
            this.btnReturnToSubfunctionPopup.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturnToSubfunctionPopup.Location = new System.Drawing.Point(57, 322);
            this.btnReturnToSubfunctionPopup.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnReturnToSubfunctionPopup.Name = "btnReturnToSubfunctionPopup";
            this.btnReturnToSubfunctionPopup.Size = new System.Drawing.Size(501, 51);
            this.btnReturnToSubfunctionPopup.TabIndex = 4;
            this.btnReturnToSubfunctionPopup.Text = "補助機能選択へ戻る";
            this.btnReturnToSubfunctionPopup.UseVisualStyleBackColor = true;
            this.btnReturnToSubfunctionPopup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.btnReturnToSubfunctionPopup.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // dateTarget
            // 
            this.dateTarget.AutoSize = true;
            this.dateTarget.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateTarget.BackColor = System.Drawing.Color.Transparent;
            this.dateTarget.Date = null;
            this.dateTarget.DayStr = "1";
            this.dateTarget.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTarget.GengouStr = "";
            this.dateTarget.Location = new System.Drawing.Point(123, 51);
            this.dateTarget.Margin = new System.Windows.Forms.Padding(0);
            this.dateTarget.MarginGengou2Year = 11;
            this.dateTarget.MarginMonth2Day = 11;
            this.dateTarget.MarginYear2Month = 58;
            this.dateTarget.MonthStr = "";
            this.dateTarget.Name = "dateTarget";
            this.dateTarget.Size = new System.Drawing.Size(391, 37);
            this.dateTarget.TabIndex = 0;
            this.dateTarget.TextBoxWidth = 106;
            this.dateTarget.ViewType = KaikeiSystemBody.views.controls.DateInputPanel.ViewTypeEnum.WarekiYearMonth;
            this.dateTarget.YearStr = "";
            this.dateTarget.TextBoxKeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.dateTarget.TextBoxPreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // DenpyouBangouSeiriPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(623, 416);
            this.Controls.Add(this.btnReturnToSubfunctionPopup);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOrderByKaikeiKubunAndKihyoubiAndNo);
            this.Controls.Add(this.btnOrderByKihyoubiAndNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTarget);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "DenpyouBangouSeiriPopup";
            this.ShowInTaskbar = false;
            this.Text = "伝票番号整理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrderByKihyoubiAndNo;
        private System.Windows.Forms.Button btnOrderByKaikeiKubunAndKihyoubiAndNo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReturnToSubfunctionPopup;
        private controls.DateInputPanel dateTarget;
    }
}