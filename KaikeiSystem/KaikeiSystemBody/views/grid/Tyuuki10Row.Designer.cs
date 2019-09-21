namespace KaikeiSystemBody.views.grid
{
    partial class Tyuuki10Row
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
            this.amountToukimatsuZandaka = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.cmbKamokuKubun = new KaikeiSystemBody.views.controls.MTComboBox();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.amountSaikenGaku = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.amountTyousyuuhunouZandaka = new KaikeiSystemBody.views.controls.AmountTextBox();
            this.SuspendLayout();
            // 
            // amountToukimatsuZandaka
            // 
            this.amountToukimatsuZandaka.Amount = ((long)(0));
            this.amountToukimatsuZandaka.Location = new System.Drawing.Point(1040, 9);
            this.amountToukimatsuZandaka.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountToukimatsuZandaka.Name = "amountToukimatsuZandaka";
            this.amountToukimatsuZandaka.Size = new System.Drawing.Size(235, 28);
            this.amountToukimatsuZandaka.TabIndex = 3;
            this.amountToukimatsuZandaka.Tag = "toukimatsu_zandaka";
            this.amountToukimatsuZandaka.Text = "\\0";
            this.amountToukimatsuZandaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbKamokuKubun
            // 
            this.cmbKamokuKubun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKamokuKubun.DropDownHeight = 200;
            this.cmbKamokuKubun.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbKamokuKubun.FormattingEnabled = true;
            this.cmbKamokuKubun.IntegralHeight = false;
            this.cmbKamokuKubun.Location = new System.Drawing.Point(53, 9);
            this.cmbKamokuKubun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbKamokuKubun.Name = "cmbKamokuKubun";
            this.cmbKamokuKubun.Size = new System.Drawing.Size(334, 29);
            this.cmbKamokuKubun.TabIndex = 0;
            this.cmbKamokuKubun.Tag = "kamoku_kubun_id";
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRemoveRow.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveRow.Location = new System.Drawing.Point(1305, 9);
            this.btnRemoveRow.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(61, 38);
            this.btnRemoveRow.TabIndex = 4;
            this.btnRemoveRow.Text = "削";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            // 
            // amountSaikenGaku
            // 
            this.amountSaikenGaku.Amount = ((long)(0));
            this.amountSaikenGaku.Location = new System.Drawing.Point(402, 9);
            this.amountSaikenGaku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountSaikenGaku.Name = "amountSaikenGaku";
            this.amountSaikenGaku.Size = new System.Drawing.Size(235, 28);
            this.amountSaikenGaku.TabIndex = 1;
            this.amountSaikenGaku.Tag = "saiken_gaku";
            this.amountSaikenGaku.Text = "\\0";
            this.amountSaikenGaku.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amountTyousyuuhunouZandaka
            // 
            this.amountTyousyuuhunouZandaka.Amount = ((long)(0));
            this.amountTyousyuuhunouZandaka.Location = new System.Drawing.Point(651, 9);
            this.amountTyousyuuhunouZandaka.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountTyousyuuhunouZandaka.Name = "amountTyousyuuhunouZandaka";
            this.amountTyousyuuhunouZandaka.Size = new System.Drawing.Size(374, 28);
            this.amountTyousyuuhunouZandaka.TabIndex = 2;
            this.amountTyousyuuhunouZandaka.Tag = "tyousyuuhunoukin_zandaka";
            this.amountTyousyuuhunouZandaka.Text = "\\0";
            this.amountTyousyuuhunouZandaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Tyuuki10Row
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.amountTyousyuuhunouZandaka);
            this.Controls.Add(this.amountSaikenGaku);
            this.Controls.Add(this.amountToukimatsuZandaka);
            this.Controls.Add(this.cmbKamokuKubun);
            this.Controls.Add(this.btnRemoveRow);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Tyuuki10Row";
            this.Size = new System.Drawing.Size(1445, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveRow;
        private controls.MTComboBox cmbKamokuKubun;
        private controls.AmountTextBox amountToukimatsuZandaka;
        private controls.AmountTextBox amountSaikenGaku;
        private controls.AmountTextBox amountTyousyuuhunouZandaka;
    }
}
