namespace Tuan3_LuyenLv_From
{
    partial class frmTaoSoNgauNhien
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnTaoSoNgauNhien = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số ngẫu nhiên";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(113, 41);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(241, 20);
            this.txtNhap.TabIndex = 1;
            // 
            // btnTaoSoNgauNhien
            // 
            this.btnTaoSoNgauNhien.Location = new System.Drawing.Point(34, 99);
            this.btnTaoSoNgauNhien.Name = "btnTaoSoNgauNhien";
            this.btnTaoSoNgauNhien.Size = new System.Drawing.Size(152, 23);
            this.btnTaoSoNgauNhien.TabIndex = 2;
            this.btnTaoSoNgauNhien.Text = "Tạo số ngẫu nhiên";
            this.btnTaoSoNgauNhien.UseVisualStyleBackColor = true;
            this.btnTaoSoNgauNhien.Click += new System.EventHandler(this.btnTaoSoNgauNhien_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(243, 99);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(98, 23);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmTaoSoNgauNhien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 159);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTaoSoNgauNhien);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Name = "frmTaoSoNgauNhien";
            this.Text = "frmTaoSoNgauNhien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnTaoSoNgauNhien;
        private System.Windows.Forms.Button btnDong;
    }
}