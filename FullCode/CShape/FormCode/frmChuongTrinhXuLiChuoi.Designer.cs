namespace Tuan3_LuyenLv_From
{
    partial class frmChuongTrinhXuLiChuoi
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
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtChuoi = new System.Windows.Forms.TextBox();
            this.btnInHoa = new System.Windows.Forms.Button();
            this.btnChuThuong = new System.Windows.Forms.Button();
            this.btnInHoaKyTuDau = new System.Windows.Forms.Button();
            this.btnTimViTriWindow = new System.Windows.Forms.Button();
            this.btnDaoNguoc = new System.Windows.Forms.Button();
            this.btnTach = new System.Windows.Forms.Button();
            this.btnTimVTcuoiCuaH = new System.Windows.Forms.Button();
            this.btnDoDai = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuỗi";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(32, 398);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(82, 20);
            this.lblKetQua.TabIndex = 1;
            this.lblKetQua.Text = "lblKetQua";
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtChuoi
            // 
            this.txtChuoi.Location = new System.Drawing.Point(84, 25);
            this.txtChuoi.Name = "txtChuoi";
            this.txtChuoi.Size = new System.Drawing.Size(506, 20);
            this.txtChuoi.TabIndex = 2;
            this.txtChuoi.Text = "Chào các bạn đến với môn học Lập trình Window";
            // 
            // btnInHoa
            // 
            this.btnInHoa.Location = new System.Drawing.Point(36, 64);
            this.btnInHoa.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnInHoa.Name = "btnInHoa";
            this.btnInHoa.Size = new System.Drawing.Size(554, 35);
            this.btnInHoa.TabIndex = 3;
            this.btnInHoa.Text = "1. Xuất chuỗi trên với tất cả các từ đều là chữ IN HOA";
            this.btnInHoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoa.UseVisualStyleBackColor = true;
            this.btnInHoa.Click += new System.EventHandler(this.btnInHoa_Click);
            // 
            // btnChuThuong
            // 
            this.btnChuThuong.Location = new System.Drawing.Point(36, 105);
            this.btnChuThuong.Name = "btnChuThuong";
            this.btnChuThuong.Size = new System.Drawing.Size(554, 35);
            this.btnChuThuong.TabIndex = 4;
            this.btnChuThuong.Text = "2. Xuất chuỗi trên với tất cả các từ đều là chữ thường";
            this.btnChuThuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuThuong.UseVisualStyleBackColor = true;
            this.btnChuThuong.Click += new System.EventHandler(this.btnChuThuong_Click);
            // 
            // btnInHoaKyTuDau
            // 
            this.btnInHoaKyTuDau.Location = new System.Drawing.Point(36, 146);
            this.btnInHoaKyTuDau.Name = "btnInHoaKyTuDau";
            this.btnInHoaKyTuDau.Size = new System.Drawing.Size(554, 35);
            this.btnInHoaKyTuDau.TabIndex = 5;
            this.btnInHoaKyTuDau.Text = "3. Xuất chuỗi trên với tất cả các từ đều là chữ thường nhưng IN HOA ký tự đầu tiê" +
    "n của mỗi từ";
            this.btnInHoaKyTuDau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaKyTuDau.UseVisualStyleBackColor = true;
            this.btnInHoaKyTuDau.Click += new System.EventHandler(this.btnInHoaKyTuDau_Click);
            // 
            // btnTimViTriWindow
            // 
            this.btnTimViTriWindow.Location = new System.Drawing.Point(36, 187);
            this.btnTimViTriWindow.Name = "btnTimViTriWindow";
            this.btnTimViTriWindow.Size = new System.Drawing.Size(554, 35);
            this.btnTimViTriWindow.TabIndex = 6;
            this.btnTimViTriWindow.Text = "4. Tìm vị trí của từ \"Window\" trong chuỗi trên";
            this.btnTimViTriWindow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimViTriWindow.UseVisualStyleBackColor = true;
            this.btnTimViTriWindow.Click += new System.EventHandler(this.btnTimViTriWindow_Click);
            // 
            // btnDaoNguoc
            // 
            this.btnDaoNguoc.Location = new System.Drawing.Point(36, 228);
            this.btnDaoNguoc.Name = "btnDaoNguoc";
            this.btnDaoNguoc.Size = new System.Drawing.Size(554, 35);
            this.btnDaoNguoc.TabIndex = 7;
            this.btnDaoNguoc.Text = "5. Xuất theo thứ tự đảo ngược các ký tự trong chuỗi trên";
            this.btnDaoNguoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDaoNguoc.UseVisualStyleBackColor = true;
            this.btnDaoNguoc.Click += new System.EventHandler(this.btnDaoNguoc_Click);
            // 
            // btnTach
            // 
            this.btnTach.Location = new System.Drawing.Point(36, 351);
            this.btnTach.Name = "btnTach";
            this.btnTach.Size = new System.Drawing.Size(554, 35);
            this.btnTach.TabIndex = 10;
            this.btnTach.Text = "8. Tách chuỗi trên ra thành từng từ riêng biệt";
            this.btnTach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTach.UseVisualStyleBackColor = true;
            this.btnTach.Click += new System.EventHandler(this.btnTach_Click);
            // 
            // btnTimVTcuoiCuaH
            // 
            this.btnTimVTcuoiCuaH.Location = new System.Drawing.Point(36, 310);
            this.btnTimVTcuoiCuaH.Name = "btnTimVTcuoiCuaH";
            this.btnTimVTcuoiCuaH.Size = new System.Drawing.Size(554, 35);
            this.btnTimVTcuoiCuaH.TabIndex = 9;
            this.btnTimVTcuoiCuaH.Text = "7. Tìm vị trí xuất hiện cuối cùng của chữ \'h\' trong chuỗi trên";
            this.btnTimVTcuoiCuaH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimVTcuoiCuaH.UseVisualStyleBackColor = true;
            this.btnTimVTcuoiCuaH.Click += new System.EventHandler(this.btnTimVTcuoiCuaH_Click);
            // 
            // btnDoDai
            // 
            this.btnDoDai.Location = new System.Drawing.Point(36, 269);
            this.btnDoDai.Name = "btnDoDai";
            this.btnDoDai.Size = new System.Drawing.Size(554, 35);
            this.btnDoDai.TabIndex = 8;
            this.btnDoDai.Text = "6. Cho biết chuỗi trên có độ dài bao nhiêu?";
            this.btnDoDai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoDai.UseVisualStyleBackColor = true;
            this.btnDoDai.Click += new System.EventHandler(this.btnDoDai_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(36, 433);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 29);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(498, 433);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(92, 29);
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmChuongTrinhXuLiChuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 474);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTach);
            this.Controls.Add(this.btnTimVTcuoiCuaH);
            this.Controls.Add(this.btnDoDai);
            this.Controls.Add(this.btnDaoNguoc);
            this.Controls.Add(this.btnTimViTriWindow);
            this.Controls.Add(this.btnInHoaKyTuDau);
            this.Controls.Add(this.btnChuThuong);
            this.Controls.Add(this.btnInHoa);
            this.Controls.Add(this.txtChuoi);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label1);
            this.Name = "frmChuongTrinhXuLiChuoi";
            this.Text = "frmChuongTrinhXuLiChuoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtChuoi;
        private System.Windows.Forms.Button btnInHoa;
        private System.Windows.Forms.Button btnChuThuong;
        private System.Windows.Forms.Button btnInHoaKyTuDau;
        private System.Windows.Forms.Button btnTimViTriWindow;
        private System.Windows.Forms.Button btnDaoNguoc;
        private System.Windows.Forms.Button btnTach;
        private System.Windows.Forms.Button btnTimVTcuoiCuaH;
        private System.Windows.Forms.Button btnDoDai;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDong;
    }
}