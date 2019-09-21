namespace KaikeiSystemBody.views.grid
{
    partial class KoteiShisanRow
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
            this.txtTaikyuuNennsuu = new System.Windows.Forms.TextBox();
            this.txtSuuryou = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.amountSyutokuKakaku = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.cmbKaikeiKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.cmbKamoku = new KaikeiSystemBody.views.controls.MTComboBox();
            this.dateSyutokuNenngappi = new KaikeiSystemBody.views.controls.DateInputPanel();
            this.SuspendLayout();
            // 
            // txtTaikyuuNennsuu
            // 
            this.txtTaikyuuNennsuu.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTaikyuuNennsuu.Location = new System.Drawing.Point(1470, 10);
            this.txtTaikyuuNennsuu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTaikyuuNennsuu.Name = "txtTaikyuuNennsuu";
            this.txtTaikyuuNennsuu.Size = new System.Drawing.Size(92, 33);
            this.txtTaikyuuNennsuu.TabIndex = 6;
            this.txtTaikyuuNennsuu.Tag = "taiyou_nennsuu";
            this.txtTaikyuuNennsuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSuuryou
            // 
            this.txtSuuryou.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSuuryou.Location = new System.Drawing.Point(1129, 10);
            this.txtSuuryou.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSuuryou.Name = "txtSuuryou";
            this.txtSuuryou.Size = new System.Drawing.Size(74, 33);
            this.txtSuuryou.TabIndex = 4;
            this.txtSuuryou.Tag = "suuryou";
            this.txtSuuryou.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtName.Location = new System.Drawing.Point(185, 9);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(437, 33);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "shisan_meisyou";
            // 
            // btnDetail
            // 
            this.btnDetail.ForeColor = System.Drawing.Color.Black;
            this.btnDetail.Location = new System.Drawing.Point(39, 4);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(136, 46);
            this.btnDetail.TabIndex = 0;
            this.btnDetail.Text = "詳細(D)";
            this.btnDetail.UseVisualStyleBackColor = true;
            // 
            // amountSyutokuKakaku
            // 
            this.amountSyutokuKakaku.Amount = ((long)(0));
            this.amountSyutokuKakaku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountSyutokuKakaku.Location = new System.Drawing.Point(1577, 10);
            this.amountSyutokuKakaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountSyutokuKakaku.Name = "amountSyutokuKakaku";
            this.amountSyutokuKakaku.Size = new System.Drawing.Size(184, 33);
            this.amountSyutokuKakaku.TabIndex = 7;
            this.amountSyutokuKakaku.Tag = "syutoku_kakaku";
            this.amountSyutokuKakaku.Text = "\\0";
            this.amountSyutokuKakaku.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbKaikeiKubun
            // 
            this.cmbKaikeiKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKaikeiKubun.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKaikeiKubun.FormattingEnabled = true;
            this.cmbKaikeiKubun.Location = new System.Drawing.Point(895, 9);
            this.cmbKaikeiKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKaikeiKubun.Name = "cmbKaikeiKubun";
            this.cmbKaikeiKubun.Size = new System.Drawing.Size(220, 34);
            this.cmbKaikeiKubun.TabIndex = 3;
            this.cmbKaikeiKubun.Tag = "kaikei_kubun";
            // 
            // cmbKamoku
            // 
            this.cmbKamoku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKamoku.DropDownHeight = 200;
            this.cmbKamoku.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKamoku.FormattingEnabled = true;
            this.cmbKamoku.IntegralHeight = false;
            this.cmbKamoku.Location = new System.Drawing.Point(636, 9);
            this.cmbKamoku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKamoku.Name = "cmbKamoku";
            this.cmbKamoku.Size = new System.Drawing.Size(244, 34);
            this.cmbKamoku.TabIndex = 2;
            this.cmbKamoku.Tag = "kamoku_kubun_id";
            // 
            // dateSyutokuNenngappi
            // 
            this.dateSyutokuNenngappi.AutoSize = true;
            this.dateSyutokuNenngappi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateSyutokuNenngappi.BackColor = System.Drawing.Color.Transparent;
            this.dateSyutokuNenngappi.Date = null;
            this.dateSyutokuNenngappi.DayStr = "";
            this.dateSyutokuNenngappi.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateSyutokuNenngappi.GengouStr = "";
            this.dateSyutokuNenngappi.Location = new System.Drawing.Point(1221, 10);
            this.dateSyutokuNenngappi.Margin = new System.Windows.Forms.Padding(0);
            this.dateSyutokuNenngappi.MarginGengou2Year = 3;
            this.dateSyutokuNenngappi.MarginMonth2Day = 3;
            this.dateSyutokuNenngappi.MarginYear2Month = 3;
            this.dateSyutokuNenngappi.MonthStr = "";
            this.dateSyutokuNenngappi.Name = "dateSyutokuNenngappi";
            this.dateSyutokuNenngappi.Size = new System.Drawing.Size(233, 37);
            this.dateSyutokuNenngappi.TabIndex = 5;
            this.dateSyutokuNenngappi.Tag = "syutoku_nenngappi";
            this.dateSyutokuNenngappi.TextBoxWidth = 55;
            this.dateSyutokuNenngappi.YearStr = "";
            // 
            // KoteiShisanRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.amountSyutokuKakaku);
            this.Controls.Add(this.txtTaikyuuNennsuu);
            this.Controls.Add(this.txtSuuryou);
            this.Controls.Add(this.cmbKaikeiKubun);
            this.Controls.Add(this.cmbKamoku);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.dateSyutokuNenngappi);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "KoteiShisanRow";
            this.Size = new System.Drawing.Size(1795, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.TextBox txtName;
        private controls.MTComboBox cmbKamoku;
        private controls.MTComboBox cmbKaikeiKubun;
        private System.Windows.Forms.TextBox txtSuuryou;
        private System.Windows.Forms.TextBox txtTaikyuuNennsuu;
        private controls.AmountTextBox amountSyutokuKakaku;
        private controls.DateInputPanel dateSyutokuNenngappi;
    }
}
