namespace Tuan3_LuyenLv_From
{
    partial class frmTinhTong2
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoTuNhien = new System.Windows.Forms.TextBox();
            this.txtSTinh = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tự nhiên N:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "S=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "S=";
            // 
            // txtSoTuNhien
            // 
            this.txtSoTuNhien.Location = new System.Drawing.Point(133, 32);
            this.txtSoTuNhien.Name = "txtSoTuNhien";
            this.txtSoTuNhien.Size = new System.Drawing.Size(100, 20);
            this.txtSoTuNhien.TabIndex = 3;
            this.txtSoTuNhien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTuNhien_KeyPress);
            // 
            // txtSTinh
            // 
            this.txtSTinh.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.txtSTinh.Location = new System.Drawing.Point(74, 85);
            this.txtSTinh.Name = "txtSTinh";
            this.txtSTinh.ReadOnly = true;
            this.txtSTinh.Size = new System.Drawing.Size(274, 20);
            this.txtSTinh.TabIndex = 4;
            // 
            // txtS
            // 
            this.txtS.ForeColor = System.Drawing.Color.Red;
            this.txtS.Location = new System.Drawing.Point(74, 138);
            this.txtS.Name = "txtS";
            this.txtS.ReadOnly = true;
            this.txtS.Size = new System.Drawing.Size(274, 20);
            this.txtS.TabIndex = 5;
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTinhTong.Location = new System.Drawing.Point(251, 22);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(97, 39);
            this.btnTinhTong.TabIndex = 6;
            this.btnTinhTong.Text = "Tính Tổng";
            this.btnTinhTong.UseVisualStyleBackColor = false;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // frmTinhTong2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 245);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtSTinh);
            this.Controls.Add(this.txtSoTuNhien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTinhTong2";
            this.Text = "Tính Tổng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTinhTong2_FormClosing);
            this.Load += new System.EventHandler(this.frmTinhTong2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoTuNhien;
        private System.Windows.Forms.TextBox txtSTinh;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Button btnTinhTong;
    }
}