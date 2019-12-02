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
    public partial class frmCapNhatNhanVien : Form
    {
        public int manv;
        LoaiNhanVienBUS lnvBUS = new LoaiNhanVienBUS();
        NhanVienBUS nvBUS = new NhanVienBUS();
        public frmCapNhatNhanVien()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmCapNhatNhanVien_Load(object sender, EventArgs e)
        {
            bdsLoaiNhanVien.DataSource = lnvBUS.LayDanhSach();
            NhanVienDTO nvDTO = new NhanVienDTO();
            
            nvDTO = nvBUS.LayNhanVienTheoMaNV(manv);
            txtMaNhanVien.Text = manv.ToString();
            txtHoTen.Text = nvDTO.HoTen;
            cboLoaiNhanVien.SelectedValue = nvDTO.MaLoaiNV;
            dtpNgaySinh.Value = nvDTO.NgaySinh;
            if (nvDTO.GioiTinh)
                radNam.Checked = true;
            else
                radNu.Checked = true;
            txtDiaChi.Text = nvDTO.DiaChi;
            txtDienThoai.Text = nvDTO.DienThoai;
            txtEmail.Text = nvDTO.Email;
            txtGhiChu.Text = nvDTO.GhiChu;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVienDTO nvDTO = new NhanVienDTO();
                nvDTO.MaNV = manv;
                nvDTO.MaLoaiNV = Convert.ToInt32(cboLoaiNhanVien.SelectedValue);
                nvDTO.HoTen = txtHoTen.Text.Trim();
                nvDTO.NgaySinh = dtpNgaySinh.Value;
                nvDTO.GioiTinh = radNam.Checked ? true : false;
                nvDTO.DiaChi = txtDiaChi.Text.Trim();
                nvDTO.Email = txtEmail.Text.Trim();
                nvDTO.DienThoai = txtDienThoai.Text.Trim();
                nvDTO.GhiChu = txtGhiChu.Text.Trim();
                if (nvBUS.Sua(nvDTO))
                {
                    MessageBox.Show("Sửa thành công!");
                }
                else
                    MessageBox.Show("Sửa không thành công!");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
