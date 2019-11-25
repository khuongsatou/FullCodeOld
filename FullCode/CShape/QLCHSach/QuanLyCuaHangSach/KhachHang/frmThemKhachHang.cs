using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCuaHangSach
{
    public partial class frmThemKhachHang : Form
    {
        KhachHangBUS khBUS = new KhachHangBUS();
        public frmThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHangDTO khDTO = new KhachHangDTO();
                khDTO.HoTen = txtHoTen.Text.Trim();
                khDTO.NgaySinh = dtpNgaySinh.Value;
                khDTO.GioiTinh = radNam.Checked ? true : false;
                khDTO.DiaChi = txtDiaChi.Text.Trim();
                khDTO.Email = txtEmail.Text.Trim();
                khDTO.DienThoai = txtDienThoai.Text.Trim();
                khDTO.GhiChu = txtGhiChu.Text.Trim();
                if (khBUS.Them(khDTO))
                    MessageBox.Show("Thêm khách hàng thành công!");
                else
                    MessageBox.Show("Thêm khách hàng không thành công!");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
