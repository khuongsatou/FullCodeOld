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
    public partial class frmCapNhatNXB : Form
    {
        public int manxb;
        NhaXuatBanBUS nxbBUS = new NhaXuatBanBUS();
        public frmCapNhatNXB()
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
                NhaXuatBanDTO nxb = new NhaXuatBanDTO();
                nxb.MaNXB = manxb;
                nxb.Ten = txtTen.Text.Trim();
                nxb.Website = txtWebsite.Text.Trim();
                nxb.Email = txtEmail.Text.Trim();
                nxb.GhiChu = txtGhiChu.Text.Trim();
                if (nxbBUS.Sua(nxb))
                {
                    MessageBox.Show("Cập nhật nhà xuất bản thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật nhà xuất bản không thành công!");
                }
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCapNhatNXB_Load(object sender, EventArgs e)
        {
            NhaXuatBanDTO nxb = nxbBUS.LayNhaXuatBanTheoMa(manxb);
            txtMaNXB.Text = manxb.ToString();
            txtTen.Text = nxb.Ten;
            txtWebsite.Text = nxb.Website;
            txtEmail.Text = nxb.Email;
            txtGhiChu.Text = nxb.GhiChu;
        }
    }
}
