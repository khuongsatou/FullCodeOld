using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace QuanLyCuaHangSach
{
    public partial class frmCapNhatKhachHang : Form
    {
        KhachHangBUS khBUS = new KhachHangBUS();
        public int makh;
        public frmCapNhatKhachHang()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmCapNhatKhachHang_Load(object sender, EventArgs e)
        {
            KhachHangDTO khDTO = khBUS.LayKHTheoMa(makh);
            txtMaKH.Text = khDTO.MaKH.ToString();
            txtHoTen.Text = khDTO.HoTen;
            dtpNgaySinh.Value = khDTO.NgaySinh;
            if (khDTO.GioiTinh)
                radNam.Checked = true;
            else
                radNu.Checked = true;
            txtDiaChi.Text = khDTO.DiaChi;
            txtDienThoai.Text = khDTO.DienThoai;
            txtEmail.Text = khDTO.Email;
            txtGhiChu.Text = khDTO.GhiChu;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHangDTO khDTO = new KhachHangDTO();
                khDTO.MaKH = makh;
                khDTO.HoTen = txtHoTen.Text.Trim();
                khDTO.NgaySinh = dtpNgaySinh.Value;
                khDTO.GioiTinh = radNam.Checked ? true : false;
                khDTO.DiaChi = txtDiaChi.Text.Trim();
                khDTO.Email = txtEmail.Text.Trim();
                khDTO.DienThoai = txtDienThoai.Text.Trim();
                khDTO.GhiChu = txtGhiChu.Text.Trim();
                if (khBUS.Sua(khDTO))
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                    MessageBox.Show("Cập nhật không thành công!");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
