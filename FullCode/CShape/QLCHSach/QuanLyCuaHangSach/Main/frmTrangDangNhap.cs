using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyCuaHangSach
{
    public partial class frmTrangDangNhap : Form
    {


        public frmTrangDangNhap()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Yes)
            {
                timer1.Start();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhân viên!");
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu!");
                return;
            }
            if (txtTenDangNhap.Text != "")
            {
                int manv = int.Parse(txtTenDangNhap.Text.Trim());
                string matkhau = txtMatKhau.Text.Trim();
                NhanVienBUS nv = new NhanVienBUS();
                int maloainv = nv.DangNhap(manv, matkhau);
                if (maloainv == 1)
                {
                    txtTenDangNhap.Clear();
                    txtMatKhau.Clear();
                    frmTrangQuanLy_Test f = new frmTrangQuanLy_Test();
                    NhanVienDTO nvDTO = nv.LayNhanVienTheoMaNV(manv);
                    f.manv = nvDTO.MaNV;
                    f.hoten = nvDTO.HoTen;
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                if (maloainv == 2)
                {
                    txtTenDangNhap.Clear();
                    txtMatKhau.Clear();
                    frmTrangBanHang f = new frmTrangBanHang();
                    NhanVienDTO nvDTO = nv.LayNhanVienTheoMaNV(manv);
                    f.manv = nvDTO.MaNV;
                    f.tennv = nvDTO.HoTen;
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                if (maloainv == 0)
                {
                    MessageBox.Show("Sai mã nhân viên hoặc mật khẩu!");
                }
            }
            
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                timer1.Stop();
                this.Dispose();
            }
        }

        private void btnDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void frmTrangDangNhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnDangNhap;
        }
    }
}
