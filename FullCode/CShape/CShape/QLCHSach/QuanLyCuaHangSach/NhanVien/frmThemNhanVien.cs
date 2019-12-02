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
    public partial class frmThemNhanVien : Form
    {
        LoaiNhanVienBUS lnvBUS = new LoaiNhanVienBUS();
        NhanVienBUS nvBUS = new NhanVienBUS();
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            bdsLoaiNhanVien.DataSource = lnvBUS.LayDanhSach();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVienDTO nvDTO = new NhanVienDTO();
                nvDTO.MatKhau = txtMatKhau.Text.Trim();
                nvDTO.MaLoaiNV = Convert.ToInt32(cboLoaiNhanVien.SelectedValue);
                nvDTO.HoTen = txtHoTen.Text.Trim();
                nvDTO.NgaySinh = dtpNgaySinh.Value;
                nvDTO.GioiTinh = radNam.Checked ? true : false;
                nvDTO.DiaChi = txtDiaChi.Text.Trim();
                nvDTO.Email = txtEmail.Text.Trim();
                nvDTO.DienThoai = txtDienThoai.Text.Trim();
                nvDTO.GhiChu = txtGhiChu.Text.Trim();
                if (nvBUS.Them(nvDTO))
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                    MessageBox.Show("Thêm không thành công!");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
            
        }
    }
}
