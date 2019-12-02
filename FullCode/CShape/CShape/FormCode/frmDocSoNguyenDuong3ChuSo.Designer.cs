namespace Tuan3_LuyenLv_From
{
    partial class frmDocSoNguyenDuong3ChuSo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoNguyenDuong = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số nguyên dương có 3 chữ số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết quả đọc số";
            // 
            // txtSoNguyenDuong
            // 
            this.txtSoNguyenDuong.Location = new System.Drawing.Point(210, 41);
            this.txtSoNguyenDuong.Name = "txtSoNguyenDuong";
            this.txtSoNguyenDuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoNguyenDuong.TabIndex = 2;
            this.txtSoNguyenDuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNguyenDuong_KeyPress);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Enabled = false;
            this.txtKetQua.Location = new System.Drawing.Point(147, 89);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(163, 20);
            this.txtKetQua.TabIndex = 3;
            // 
            // btnDoc
            // 
            this.btnDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDoc.Location = new System.Drawing.Point(347, 35);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(75, 31);
            this.btnDoc.TabIndex = 4;
            this.btnDoc.Text = "Đọc";
            this.btnDoc.UseVisualStyleBackColor = false;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // frmDocSoNguyenDuong3ChuSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 158);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoNguyenDuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDocSoNguyenDuong3ChuSo";
            this.Text = "Chương Trình Đọc Số";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDocSoNguyenDuong3ChuSo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoNguyenDuong;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnDoc;
    }
}