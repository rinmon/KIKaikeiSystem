namespace KaikeiSystemBody.views.grid
{
    partial class TekiyouRow
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
            this.txtTekiyouCode = new System.Windows.Forms.TextBox();
            this.txtTekiyouYomi = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTekiyouMei = new KaikeiSystemBody.views.controls.YomiTextBox();
            this.SuspendLayout();
            // 
            // txtTekiyouCode
            // 
            this.txtTekiyouCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtTekiyouCode.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTekiyouCode.Location = new System.Drawing.Point(25, 3);
            this.txtTekiyouCode.Name = "txtTekiyouCode";
            this.txtTekiyouCode.Size = new System.Drawing.Size(62, 21);
            this.txtTekiyouCode.TabIndex = 0;
            this.txtTekiyouCode.TabStop = false;
            this.txtTekiyouCode.Tag = "tekiyou_code";
            this.txtTekiyouCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTekiyouYomi
            // 
            this.txtTekiyouYomi.BackColor = System.Drawing.SystemColors.Window;
            this.txtTekiyouYomi.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTekiyouYomi.Location = new System.Drawing.Point(443, 3);
            this.txtTekiyouYomi.Name = "txtTekiyouYomi";
            this.txtTekiyouYomi.Size = new System.Drawing.Size(376, 21);
            this.txtTekiyouYomi.TabIndex = 2;
            this.txtTekiyouYomi.Tag = "tekiyou_yomi";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(885, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 24);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "削除(D)";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtTekiyouMei
            // 
            this.txtTekiyouMei.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTekiyouMei.Location = new System.Drawing.Point(93, 3);
            this.txtTekiyouMei.Name = "txtTekiyouMei";
            this.txtTekiyouMei.Size = new System.Drawing.Size(342, 21);
            this.txtTekiyouMei.TabIndex = 1;
            this.txtTekiyouMei.Tag = "tekiyou_mei";
            this.txtTekiyouMei.CompositionCompleted += new KaikeiSystemBody.views.controls.YomiTextBox.CompositionCompletedEventHandler(this.txtTekiyouMei_CompositionCompleted);
            // 
            // TekiyouRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTekiyouMei);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTekiyouYomi);
            this.Controls.Add(this.txtTekiyouCode);
            this.Name = "TekiyouRow";
            this.Size = new System.Drawing.Size(973, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTekiyouCode;
        private System.Windows.Forms.TextBox txtTekiyouYomi;
        private System.Windows.Forms.Button btnDelete;
        private controls.YomiTextBox txtTekiyouMei;
    }
}
