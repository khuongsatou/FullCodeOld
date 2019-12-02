namespace Tuan3_LuyenLv_From
{
    partial class frmSoLonNhatVaNhoNhat
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.txtSoThuBa = new System.Windows.Forms.TextBox();
            this.txtSoLonNhat = new System.Windows.Forms.TextBox();
            this.txtSoNhoNhat = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ ba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(31, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lớn nhất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(231, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số nhỏ nhất";
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.Location = new System.Drawing.Point(82, 24);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(100, 20);
            this.txtSoThuNhat.TabIndex = 5;
            this.txtSoThuNhat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoThuNhat_KeyPress);
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.Location = new System.Drawing.Point(266, 24);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(100, 20);
            this.txtSoThuHai.TabIndex = 6;
            this.txtSoThuHai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoThuHai_KeyPress);
            // 
            // txtSoThuBa
            // 
            this.txtSoThuBa.Location = new System.Drawing.Point(464, 27);
            this.txtSoThuBa.Name = "txtSoThuBa";
            this.txtSoThuBa.Size = new System.Drawing.Size(100, 20);
            this.txtSoThuBa.TabIndex = 7;
            this.txtSoThuBa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoThuBa_KeyPress);
            // 
            // txtSoLonNhat
            // 
            this.txtSoLonNhat.Enabled = false;
            this.txtSoLonNhat.Location = new System.Drawing.Point(106, 152);
            this.txtSoLonNhat.Name = "txtSoLonNhat";
            this.txtSoLonNhat.ReadOnly = true;
            this.txtSoLonNhat.Size = new System.Drawing.Size(100, 20);
            this.txtSoLonNhat.TabIndex = 8;
            // 
            // txtSoNhoNhat
            // 
            this.txtSoNhoNhat.Enabled = false;
            this.txtSoNhoNhat.Location = new System.Drawing.Point(306, 152);
            this.txtSoNhoNhat.Name = "txtSoNhoNhat";
            this.txtSoNhoNhat.ReadOnly = true;
            this.txtSoNhoNhat.Size = new System.Drawing.Size(100, 20);
            this.txtSoNhoNhat.TabIndex = 9;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTim.Location = new System.Drawing.Point(194, 77);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(129, 36);
            this.btnTim.TabIndex = 10;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 239);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtSoNhoNhat);
            this.Controls.Add(this.txtSoLonNhat);
            this.Controls.Add(this.txtSoThuBa);
            this.Controls.Add(this.txtSoThuHai);
            this.Controls.Add(this.txtSoThuNhat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chương Trình tìm số lớn nhất và nhỏ nhất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.TextBox txtSoThuBa;
        private System.Windows.Forms.TextBox txtSoLonNhat;
        private System.Windows.Forms.TextBox txtSoNhoNhat;
        private System.Windows.Forms.Button btnTim;
    }
}

