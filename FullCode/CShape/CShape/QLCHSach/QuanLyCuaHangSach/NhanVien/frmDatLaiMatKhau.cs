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
    public partial class frmDatLaiMatKhau : Form
    {
        public int manv;
        public frmDatLaiMatKhau()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu!");
            }
            else
            {
                string matkhau = txtMatKhau.Text.Trim();
                NhanVienBUS nv = new NhanVienBUS();
                if (nv.ResetMatKhau(manv, matkhau))
                {
                    MessageBox.Show("Thành công!");
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }

                this.Dispose();
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
