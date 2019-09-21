namespace KaikeiSystemBody.views.grid
{
    partial class KoteiShisanDetailSubRow
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
            this.cmbSyoukyakuHouhou = new KaikeiSystemBody.views.controls.MTComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTaikyuuNennsuu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.amountSyutokuKagaku = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.amountKisyuSyoukyaku = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.amountZanzonKagaku = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.cmbSyoukyakuKahi = new KaikeiSystemBody.views.controls.MTComboBox();
            this.txtBikou = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSyoukyakuRitu = new KaikeiSystemBody.views.controls.FormattedViewTextBox();
            this.txtZanzonWariai = new KaikeiSystemBody.views.controls.FormattedViewTextBox();
            this.dateSyutokubi = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.dateGensyoubi = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.SuspendLayout();
            // 
            // cmbSyoukyakuHouhou
            // 
            this.cmbSyoukyakuHouhou.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSyoukyakuHouhou.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbSyoukyakuHouhou.FormattingEnabled = true;
            this.cmbSyoukyakuHouhou.Location = new System.Drawing.Point(257, 303);
            this.cmbSyoukyakuHouhou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbSyoukyakuHouhou.Name = "cmbSyoukyakuHouhou";
            this.cmbSyoukyakuHouhou.Size = new System.Drawing.Size(217, 34);
            this.cmbSyoukyakuHouhou.TabIndex = 4;
            this.cmbSyoukyakuHouhou.Tag = "syoukyaku_houhou";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(53, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "期首償却額累計";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(53, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "取得価額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(53, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "減少日";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "取得日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(53, 308);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "償却方法";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(53, 364);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "耐久年数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(53, 420);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "償却率";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(53, 476);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "残存価額";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(53, 532);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 26);
            this.label9.TabIndex = 12;
            this.label9.Text = "償却可否";
            // 
            // txtTaikyuuNennsuu
            // 
            this.txtTaikyuuNennsuu.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTaikyuuNennsuu.Location = new System.Drawing.Point(257, 359);
            this.txtTaikyuuNennsuu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTaikyuuNennsuu.Name = "txtTaikyuuNennsuu";
            this.txtTaikyuuNennsuu.Size = new System.Drawing.Size(114, 33);
            this.txtTaikyuuNennsuu.TabIndex = 5;
            this.txtTaikyuuNennsuu.Tag = "taiyou_nennsuu";
            this.txtTaikyuuNennsuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(385, 364);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 26);
            this.label10.TabIndex = 17;
            this.label10.Text = "年";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(385, 476);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 26);
            this.label11.TabIndex = 20;
            this.label11.Text = "％";
            // 
            // amountSyutokuKagaku
            // 
            this.amountSyutokuKagaku.Amount = ((long)(0));
            this.amountSyutokuKagaku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountSyutokuKagaku.Location = new System.Drawing.Point(257, 135);
            this.amountSyutokuKagaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountSyutokuKagaku.Name = "amountSyutokuKagaku";
            this.amountSyutokuKagaku.Size = new System.Drawing.Size(217, 33);
            this.amountSyutokuKagaku.TabIndex = 2;
            this.amountSyutokuKagaku.Tag = "syutoku_kakaku";
            this.amountSyutokuKagaku.Text = "\\0";
            this.amountSyutokuKagaku.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amountKisyuSyoukyaku
            // 
            this.amountKisyuSyoukyaku.Amount = ((long)(0));
            this.amountKisyuSyoukyaku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountKisyuSyoukyaku.Location = new System.Drawing.Point(257, 247);
            this.amountKisyuSyoukyaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountKisyuSyoukyaku.Name = "amountKisyuSyoukyaku";
            this.amountKisyuSyoukyaku.Size = new System.Drawing.Size(217, 33);
            this.amountKisyuSyoukyaku.TabIndex = 3;
            this.amountKisyuSyoukyaku.Tag = "kisyu_syoukyakugaku_ruikei";
            this.amountKisyuSyoukyaku.Text = "\\0";
            this.amountKisyuSyoukyaku.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amountZanzonKagaku
            // 
            this.amountZanzonKagaku.Amount = ((long)(0));
            this.amountZanzonKagaku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountZanzonKagaku.Location = new System.Drawing.Point(436, 471);
            this.amountZanzonKagaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountZanzonKagaku.Name = "amountZanzonKagaku";
            this.amountZanzonKagaku.Size = new System.Drawing.Size(217, 33);
            this.amountZanzonKagaku.TabIndex = 8;
            this.amountZanzonKagaku.Tag = "zanzon_kakaku";
            this.amountZanzonKagaku.Text = "\\0";
            this.amountZanzonKagaku.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbSyoukyakuKahi
            // 
            this.cmbSyoukyakuKahi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSyoukyakuKahi.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbSyoukyakuKahi.FormattingEnabled = true;
            this.cmbSyoukyakuKahi.Location = new System.Drawing.Point(257, 527);
            this.cmbSyoukyakuKahi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbSyoukyakuKahi.Name = "cmbSyoukyakuKahi";
            this.cmbSyoukyakuKahi.Size = new System.Drawing.Size(290, 34);
            this.cmbSyoukyakuKahi.TabIndex = 9;
            this.cmbSyoukyakuKahi.Tag = "syoukyaku_kahi";
            // 
            // txtBikou
            // 
            this.txtBikou.Location = new System.Drawing.Point(755, 19);
            this.txtBikou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBikou.Multiline = true;
            this.txtBikou.Name = "txtBikou";
            this.txtBikou.Size = new System.Drawing.Size(849, 632);
            this.txtBikou.TabIndex = 10;
            this.txtBikou.Tag = "bikou";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(671, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 26);
            this.label12.TabIndex = 27;
            this.label12.Text = "備考:";
            // 
            // txtSyoukyakuRitu
            // 
            this.txtSyoukyakuRitu.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSyoukyakuRitu.Location = new System.Drawing.Point(257, 415);
            this.txtSyoukyakuRitu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSyoukyakuRitu.Name = "txtSyoukyakuRitu";
            this.txtSyoukyakuRitu.Size = new System.Drawing.Size(114, 33);
            this.txtSyoukyakuRitu.TabIndex = 6;
            this.txtSyoukyakuRitu.Tag = "syoukyaku_ritsu";
            this.txtSyoukyakuRitu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSyoukyakuRitu.Value = null;
            // 
            // txtZanzonWariai
            // 
            this.txtZanzonWariai.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtZanzonWariai.Location = new System.Drawing.Point(257, 471);
            this.txtZanzonWariai.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtZanzonWariai.Name = "txtZanzonWariai";
            this.txtZanzonWariai.Size = new System.Drawing.Size(114, 33);
            this.txtZanzonWariai.TabIndex = 7;
            this.txtZanzonWariai.Tag = "zanzon_wariai";
            this.txtZanzonWariai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtZanzonWariai.Value = null;
            // 
            // dateSyutokubi
            // 
            this.dateSyutokubi.AutoSize = true;
            this.dateSyutokubi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateSyutokubi.BackColor = System.Drawing.Color.Transparent;
            this.dateSyutokubi.Date = null;
            this.dateSyutokubi.DayStr = "";
            this.dateSyutokubi.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateSyutokubi.GengouStr = "";
            this.dateSyutokubi.Location = new System.Drawing.Point(257, 21);
            this.dateSyutokubi.Margin = new System.Windows.Forms.Padding(0);
            this.dateSyutokubi.MarginGengou2Year = 11;
            this.dateSyutokubi.MarginMonth2Day = 11;
            this.dateSyutokubi.MarginYear2Month = 11;
            this.dateSyutokubi.MonthStr = "";
            this.dateSyutokubi.Name = "dateSyutokubi";
            this.dateSyutokubi.Size = new System.Drawing.Size(241, 37);
            this.dateSyutokubi.TabIndex = 0;
            this.dateSyutokubi.Tag = "syutoku_nenngappi";
            this.dateSyutokubi.TextBoxWidth = 51;
            this.dateSyutokubi.YearStr = "";
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
            this.dateGensyoubi.Location = new System.Drawing.Point(257, 79);
            this.dateGensyoubi.Margin = new System.Windows.Forms.Padding(0);
            this.dateGensyoubi.MarginGengou2Year = 11;
            this.dateGensyoubi.MarginMonth2Day = 11;
            this.dateGensyoubi.MarginYear2Month = 11;
            this.dateGensyoubi.MonthStr = "";
            this.dateGensyoubi.Name = "dateGensyoubi";
            this.dateGensyoubi.Size = new System.Drawing.Size(241, 37);
            this.dateGensyoubi.TabIndex = 1;
            this.dateGensyoubi.Tag = "gensyoubi";
            this.dateGensyoubi.TextBoxWidth = 51;
            this.dateGensyoubi.YearStr = "";
            // 
            // KoteiShisanDetailSubRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.dateGensyoubi);
            this.Controls.Add(this.dateSyutokubi);
            this.Controls.Add(this.txtZanzonWariai);
            this.Controls.Add(this.txtSyoukyakuRitu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBikou);
            this.Controls.Add(this.cmbSyoukyakuKahi);
            this.Controls.Add(this.amountZanzonKagaku);
            this.Controls.Add(this.amountKisyuSyoukyaku);
            this.Controls.Add(this.amountSyutokuKagaku);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTaikyuuNennsuu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSyoukyakuHouhou);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "KoteiShisanDetailSubRow";
            this.Size = new System.Drawing.Size(1667, 730);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private controls.MTComboBox cmbSyoukyakuHouhou;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTaikyuuNennsuu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private controls.AmountTextBox amountSyutokuKagaku;
        private controls.AmountTextBox amountKisyuSyoukyaku;
        private controls.AmountTextBox amountZanzonKagaku;
        private controls.MTComboBox cmbSyoukyakuKahi;
        private System.Windows.Forms.TextBox txtBikou;
        private System.Windows.Forms.Label label12;
        private controls.FormattedViewTextBox txtSyoukyakuRitu;
        private controls.FormattedViewTextBox txtZanzonWariai;
        private controls.DateInputPanel dateSyutokubi;
        private controls.DateInputPanel dateGensyoubi;


    }
}
