namespace Tuan4_lv4_winfrom
{
    partial class DatVeXemPhim
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radChi13 = new System.Windows.Forms.RadioButton();
            this.radAlita = new System.Windows.Forms.RadioButton();
            this.radHaiPhuong = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtSoLuongVe = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flpDay = new System.Windows.Forms.FlowLayoutPanel();
            this.flpGhe = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radRap5 = new System.Windows.Forms.RadioButton();
            this.radRap4 = new System.Windows.Forms.RadioButton();
            this.radRap3 = new System.Windows.Forms.RadioButton();
            this.radRap2 = new System.Windows.Forms.RadioButton();
            this.radRap1 = new System.Windows.Forms.RadioButton();
            this.btnInVe = new System.Windows.Forms.Button();
            this.btnVeMoi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radChi13);
            this.groupBox1.Controls.Add(this.radAlita);
            this.groupBox1.Controls.Add(this.radHaiPhuong);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Phim";
            // 
            // radChi13
            // 
            this.radChi13.AutoSize = true;
            this.radChi13.Location = new System.Drawing.Point(435, 19);
            this.radChi13.Name = "radChi13";
            this.radChi13.Size = new System.Drawing.Size(55, 17);
            this.radChi13.TabIndex = 2;
            this.radChi13.TabStop = true;
            this.radChi13.Text = "Chị 13";
            this.radChi13.UseVisualStyleBackColor = true;
            this.radChi13.CheckedChanged += new System.EventHandler(this.radChi13_CheckedChanged);
            // 
            // radAlita
            // 
            this.radAlita.AutoSize = true;
            this.radAlita.Location = new System.Drawing.Point(230, 20);
            this.radAlita.Name = "radAlita";
            this.radAlita.Size = new System.Drawing.Size(45, 17);
            this.radAlita.TabIndex = 1;
            this.radAlita.TabStop = true;
            this.radAlita.Text = "Alita";
            this.radAlita.UseVisualStyleBackColor = true;
            this.radAlita.CheckedChanged += new System.EventHandler(this.radAlita_CheckedChanged);
            // 
            // radHaiPhuong
            // 
            this.radHaiPhuong.AutoSize = true;
            this.radHaiPhuong.Location = new System.Drawing.Point(22, 20);
            this.radHaiPhuong.Name = "radHaiPhuong";
            this.radHaiPhuong.Size = new System.Drawing.Size(81, 17);
            this.radHaiPhuong.TabIndex = 0;
            this.radHaiPhuong.TabStop = true;
            this.radHaiPhuong.Text = "Hai Phương";
            this.radHaiPhuong.UseVisualStyleBackColor = true;
            this.radHaiPhuong.CheckedChanged += new System.EventHandler(this.radHaiPhuong_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ Tên Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng vé";
            // 
            // txtHoTenKhachHang
            // 
            this.txtHoTenKhachHang.Location = new System.Drawing.Point(130, 83);
            this.txtHoTenKhachHang.Name = "txtHoTenKhachHang";
            this.txtHoTenKhachHang.Size = new System.Drawing.Size(100, 20);
            this.txtHoTenKhachHang.TabIndex = 3;
            this.txtHoTenKhachHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTenKhachHang_KeyPress);
            // 
            // txtSoLuongVe
            // 
            this.txtSoLuongVe.Location = new System.Drawing.Point(130, 114);
            this.txtSoLuongVe.Name = "txtSoLuongVe";
            this.txtSoLuongVe.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuongVe.TabIndex = 4;
            this.txtSoLuongVe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongVe_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flpDay);
            this.groupBox2.Controls.Add(this.flpGhe);
            this.groupBox2.Location = new System.Drawing.Point(16, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 311);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn chỗ ngồi";
            // 
            // flpDay
            // 
            this.flpDay.AutoScroll = true;
            this.flpDay.Location = new System.Drawing.Point(18, 19);
            this.flpDay.Name = "flpDay";
            this.flpDay.Size = new System.Drawing.Size(51, 286);
            this.flpDay.TabIndex = 1;
            // 
            // flpGhe
            // 
            this.flpGhe.AutoScroll = true;
            this.flpGhe.Location = new System.Drawing.Point(75, 19);
            this.flpGhe.Name = "flpGhe";
            this.flpGhe.Size = new System.Drawing.Size(804, 286);
            this.flpGhe.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radRap5);
            this.groupBox3.Controls.Add(this.radRap4);
            this.groupBox3.Controls.Add(this.radRap3);
            this.groupBox3.Controls.Add(this.radRap2);
            this.groupBox3.Controls.Add(this.radRap1);
            this.groupBox3.Location = new System.Drawing.Point(257, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 47);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn rạp";
            // 
            // radRap5
            // 
            this.radRap5.AutoSize = true;
            this.radRap5.Location = new System.Drawing.Point(417, 19);
            this.radRap5.Name = "radRap5";
            this.radRap5.Size = new System.Drawing.Size(54, 17);
            this.radRap5.TabIndex = 7;
            this.radRap5.TabStop = true;
            this.radRap5.Text = "Rạp 5";
            this.radRap5.UseVisualStyleBackColor = true;
            this.radRap5.CheckedChanged += new System.EventHandler(this.radRap5_CheckedChanged);
            // 
            // radRap4
            // 
            this.radRap4.AutoSize = true;
            this.radRap4.Location = new System.Drawing.Point(314, 19);
            this.radRap4.Name = "radRap4";
            this.radRap4.Size = new System.Drawing.Size(54, 17);
            this.radRap4.TabIndex = 6;
            this.radRap4.TabStop = true;
            this.radRap4.Text = "Rạp 4";
            this.radRap4.UseVisualStyleBackColor = true;
            this.radRap4.CheckedChanged += new System.EventHandler(this.radRap4_CheckedChanged);
            // 
            // radRap3
            // 
            this.radRap3.AutoSize = true;
            this.radRap3.Location = new System.Drawing.Point(223, 19);
            this.radRap3.Name = "radRap3";
            this.radRap3.Size = new System.Drawing.Size(54, 17);
            this.radRap3.TabIndex = 5;
            this.radRap3.TabStop = true;
            this.radRap3.Text = "Rạp 3";
            this.radRap3.UseVisualStyleBackColor = true;
            this.radRap3.CheckedChanged += new System.EventHandler(this.radRap3_CheckedChanged);
            // 
            // radRap2
            // 
            this.radRap2.AutoSize = true;
            this.radRap2.Location = new System.Drawing.Point(123, 19);
            this.radRap2.Name = "radRap2";
            this.radRap2.Size = new System.Drawing.Size(54, 17);
            this.radRap2.TabIndex = 4;
            this.radRap2.TabStop = true;
            this.radRap2.Text = "Rạp 2";
            this.radRap2.UseVisualStyleBackColor = true;
            this.radRap2.CheckedChanged += new System.EventHandler(this.radRap2_CheckedChanged);
            // 
            // radRap1
            // 
            this.radRap1.AutoSize = true;
            this.radRap1.Location = new System.Drawing.Point(19, 19);
            this.radRap1.Name = "radRap1";
            this.radRap1.Size = new System.Drawing.Size(54, 17);
            this.radRap1.TabIndex = 3;
            this.radRap1.TabStop = true;
            this.radRap1.Text = "Rạp 1";
            this.radRap1.UseVisualStyleBackColor = true;
            this.radRap1.CheckedChanged += new System.EventHandler(this.radRap1_CheckedChanged);
            // 
            // btnInVe
            // 
            this.btnInVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInVe.Location = new System.Drawing.Point(503, 474);
            this.btnInVe.Name = "btnInVe";
            this.btnInVe.Size = new System.Drawing.Size(75, 23);
            this.btnInVe.TabIndex = 7;
            this.btnInVe.Text = "In Vé";
            this.btnInVe.UseVisualStyleBackColor = true;
            this.btnInVe.Click += new System.EventHandler(this.btnInVe_Click);
            // 
            // btnVeMoi
            // 
            this.btnVeMoi.Location = new System.Drawing.Point(602, 474);
            this.btnVeMoi.Name = "btnVeMoi";
            this.btnVeMoi.Size = new System.Drawing.Size(75, 23);
            this.btnVeMoi.TabIndex = 8;
            this.btnVeMoi.Text = "Vé Mới";
            this.btnVeMoi.UseVisualStyleBackColor = true;
            this.btnVeMoi.Click += new System.EventHandler(this.btnVeMoi_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(703, 474);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // DatVeXemPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 509);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnVeMoi);
            this.Controls.Add(this.btnInVe);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSoLuongVe);
            this.Controls.Add(this.txtHoTenKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DatVeXemPhim";
            this.Text = "DatVeXemPhim";
            this.Load += new System.EventHandler(this.DatVeXemPhim_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radChi13;
        private System.Windows.Forms.RadioButton radAlita;
        private System.Windows.Forms.RadioButton radHaiPhuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTenKhachHang;
        private System.Windows.Forms.TextBox txtSoLuongVe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flpGhe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radRap5;
        private System.Windows.Forms.RadioButton radRap4;
        private System.Windows.Forms.RadioButton radRap3;
        private System.Windows.Forms.RadioButton radRap2;
        private System.Windows.Forms.RadioButton radRap1;
        private System.Windows.Forms.Button btnInVe;
        private System.Windows.Forms.Button btnVeMoi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.FlowLayoutPanel flpDay;
    }
}