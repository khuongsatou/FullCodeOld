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
    public partial class frmThemNXB : Form
    {
        NhaXuatBanBUS nxbBUS = new NhaXuatBanBUS();
        public frmThemNXB()
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
                NhaXuatBanDTO nxbDTO = new NhaXuatBanDTO();
                nxbDTO.Ten = txtTen.Text.Trim();
                nxbDTO.Website = txtWebsite.Text.Trim();
                nxbDTO.Email = txtEmail.Text.Trim();
                nxbDTO.GhiChu = txtGhiChu.Text.Trim();
                if (nxbBUS.Them(nxbDTO))
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
