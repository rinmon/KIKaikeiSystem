namespace KaikeiSystemBody.views.grid
{
    partial class DaikubunRow
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
            this.cmbParent = new KaikeiSystemBody.views.controls.MTComboBox();
            this.txtDaikubunCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbParent
            // 
            this.cmbParent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbParent.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbParent.FormattingEnabled = true;
            this.cmbParent.Location = new System.Drawing.Point(658, 5);
            this.cmbParent.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbParent.Name = "cmbParent";
            this.cmbParent.Size = new System.Drawing.Size(499, 32);
            this.cmbParent.TabIndex = 2;
            this.cmbParent.Tag = "parent_id";
            // 
            // txtDaikubunCode
            // 
            this.txtDaikubunCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtDaikubunCode.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtDaikubunCode.Location = new System.Drawing.Point(46, 5);
            this.txtDaikubunCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDaikubunCode.Name = "txtDaikubunCode";
            this.txtDaikubunCode.Size = new System.Drawing.Size(114, 31);
            this.txtDaikubunCode.TabIndex = 0;
            this.txtDaikubunCode.Tag = "display_order";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtName.Location = new System.Drawing.Point(174, 5);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(470, 31);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "name";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(1172, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 42);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // DaikubunRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDaikubunCode);
            this.Controls.Add(this.cmbParent);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "DaikubunRow";
            this.Size = new System.Drawing.Size(1346, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.MTComboBox cmbParent;
        private System.Windows.Forms.TextBox txtDaikubunCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDelete;
    }
}
