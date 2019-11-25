namespace Tuan5_lv5_WinForm
{
    partial class frmDatVeXemPhim
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
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.nudSoLuongVe = new System.Windows.Forms.NumericUpDown();
            this.cbChonPhim = new System.Windows.Forms.ComboBox();
            this.cbChonRap = new System.Windows.Forms.ComboBox();
            this.btnInVe = new System.Windows.Forms.Button();
            this.btnVeMoi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpDay = new System.Windows.Forms.FlowLayoutPanel();
            this.flpGhe = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongVe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày Đặt vé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng vé";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chọn phim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chọn Rạp";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(104, 34);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpNgay.TabIndex = 5;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(104, 69);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(200, 20);
            this.txtKhachHang.TabIndex = 6;
            // 
            // nudSoLuongVe
            // 
            this.nudSoLuongVe.Location = new System.Drawing.Point(104, 118);
            this.nudSoLuongVe.Name = "nudSoLuongVe";
            this.nudSoLuongVe.Size = new System.Drawing.Size(200, 20);
            this.nudSoLuongVe.TabIndex = 7;
            this.nudSoLuongVe.ValueChanged += new System.EventHandler(this.nudSoLuongVe_ValueChanged);
            // 
            // cbChonPhim
            // 
            this.cbChonPhim.FormattingEnabled = true;
            this.cbChonPhim.Location = new System.Drawing.Point(104, 163);
            this.cbChonPhim.Name = "cbChonPhim";
            this.cbChonPhim.Size = new System.Drawing.Size(200, 21);
            this.cbChonPhim.TabIndex = 8;
            this.cbChonPhim.SelectedIndexChanged += new System.EventHandler(this.cbChonPhim_SelectedIndexChanged);
            // 
            // cbChonRap
            // 
            this.cbChonRap.FormattingEnabled = true;
            this.cbChonRap.Location = new System.Drawing.Point(104, 203);
            this.cbChonRap.Name = "cbChonRap";
            this.cbChonRap.Size = new System.Drawing.Size(200, 21);
            this.cbChonRap.TabIndex = 9;
            this.cbChonRap.SelectedIndexChanged += new System.EventHandler(this.cbChonRap_SelectedIndexChanged);
            // 
            // btnInVe
            // 
            this.btnInVe.Location = new System.Drawing.Point(104, 248);
            this.btnInVe.Name = "btnInVe";
            this.btnInVe.Size = new System.Drawing.Size(94, 23);
            this.btnInVe.TabIndex = 10;
            this.btnInVe.Text = "In Vé";
            this.btnInVe.UseVisualStyleBackColor = true;
            this.btnInVe.Click += new System.EventHandler(this.btnInVe_Click);
            // 
            // btnVeMoi
            // 
            this.btnVeMoi.Location = new System.Drawing.Point(204, 248);
            this.btnVeMoi.Name = "btnVeMoi";
            this.btnVeMoi.Size = new System.Drawing.Size(100, 23);
            this.btnVeMoi.TabIndex = 11;
            this.btnVeMoi.Text = "Vé Mới";
            this.btnVeMoi.UseVisualStyleBackColor = true;
            this.btnVeMoi.Click += new System.EventHandler(this.btnVeMoi_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(104, 296);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(200, 23);
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpDay);
            this.groupBox1.Controls.Add(this.flpGhe);
            this.groupBox1.Location = new System.Drawing.Point(345, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 398);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Chỗ ngồi";
            // 
            // flpDay
            // 
            this.flpDay.Location = new System.Drawing.Point(6, 19);
            this.flpDay.Name = "flpDay";
            this.flpDay.Size = new System.Drawing.Size(90, 373);
            this.flpDay.TabIndex = 1;
            // 
            // flpGhe
            // 
            this.flpGhe.Location = new System.Drawing.Point(102, 20);
            this.flpGhe.Name = "flpGhe";
            this.flpGhe.Size = new System.Drawing.Size(712, 372);
            this.flpGhe.TabIndex = 0;
            // 
            // frmDatVeXemPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnVeMoi);
            this.Controls.Add(this.btnInVe);
            this.Controls.Add(this.cbChonRap);
            this.Controls.Add(this.cbChonPhim);
            this.Controls.Add(this.nudSoLuongVe);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDatVeXemPhim";
            this.Text = "frmDatVeXemPhim";
            this.Load += new System.EventHandler(this.frmDatVeXemPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongVe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.NumericUpDown nudSoLuongVe;
        private System.Windows.Forms.ComboBox cbChonPhim;
        private System.Windows.Forms.ComboBox cbChonRap;
        private System.Windows.Forms.Button btnInVe;
        private System.Windows.Forms.Button btnVeMoi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flpDay;
        private System.Windows.Forms.FlowLayoutPanel flpGhe;
    }
}