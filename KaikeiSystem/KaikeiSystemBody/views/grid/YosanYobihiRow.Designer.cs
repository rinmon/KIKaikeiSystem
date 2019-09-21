namespace KaikeiSystemBody.views.grid
{
    partial class YosanYobihiRow
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateCreated = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.amountZenkiZandaka = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.amountYobihi = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "月";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "年";
            // 
            // dateCreated
            // 
            this.dateCreated.AutoSize = true;
            this.dateCreated.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateCreated.BackColor = System.Drawing.Color.Transparent;
            this.dateCreated.Date = null;
            this.dateCreated.DayStr = "";
            this.dateCreated.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateCreated.GengouStr = "";
            this.dateCreated.Location = new System.Drawing.Point(103, 60);
            this.dateCreated.Margin = new System.Windows.Forms.Padding(0);
            this.dateCreated.MarginGengou2Year = 7;
            this.dateCreated.MarginMonth2Day = 44;
            this.dateCreated.MarginYear2Month = 44;
            this.dateCreated.MonthStr = "";
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Size = new System.Drawing.Size(250, 31);
            this.dateCreated.TabIndex = 16;
            this.dateCreated.Tag = "create_date";
            this.dateCreated.TextBoxWidth = 38;
            this.dateCreated.YearStr = "";
            // 
            // amountZenkiZandaka
            // 
            this.amountZenkiZandaka.Amount = ((long)(0));
            this.amountZenkiZandaka.Location = new System.Drawing.Point(561, 9);
            this.amountZenkiZandaka.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountZenkiZandaka.Name = "amountZenkiZandaka";
            this.amountZenkiZandaka.Size = new System.Drawing.Size(180, 28);
            this.amountZenkiZandaka.TabIndex = 15;
            this.amountZenkiZandaka.Tag = "zenkimatsu_shiharai_shikin_zandaka";
            this.amountZenkiZandaka.Text = "\\0";
            this.amountZenkiZandaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amountYobihi
            // 
            this.amountYobihi.Amount = ((long)(0));
            this.amountYobihi.Location = new System.Drawing.Point(103, 9);
            this.amountYobihi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountYobihi.Name = "amountYobihi";
            this.amountYobihi.Size = new System.Drawing.Size(187, 28);
            this.amountYobihi.TabIndex = 14;
            this.amountYobihi.Tag = "yobihi";
            this.amountYobihi.Text = "\\0";
            this.amountYobihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "前期末支払資金残高";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "作成日";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "予備費";
            // 
            // btnCheckData
            // 
            this.btnCheckData.Location = new System.Drawing.Point(765, 5);
            this.btnCheckData.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCheckData.Name = "btnCheckData";
            this.btnCheckData.Size = new System.Drawing.Size(136, 46);
            this.btnCheckData.TabIndex = 20;
            this.btnCheckData.Text = "データ確認";
            this.btnCheckData.UseVisualStyleBackColor = true;
            this.btnCheckData.Click += new System.EventHandler(this.btnCheckData_Click);
            // 
            // YosanYobihiRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.btnCheckData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateCreated);
            this.Controls.Add(this.amountZenkiZandaka);
            this.Controls.Add(this.amountYobihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "YosanYobihiRow";
            this.Size = new System.Drawing.Size(917, 105);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private controls.DateInputPanel dateCreated;
        private controls.AmountTextBox amountZenkiZandaka;
        private controls.AmountTextBox amountYobihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckData;

    }
}
