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
    public partial class frmThemTheLoai : Form
    {
        TheLoaiBUS tlBUS = new TheLoaiBUS();
        public frmThemTheLoai()
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
                TheLoaiDTO tlDTO = new TheLoaiDTO();
                tlDTO.Ten = txtTen.Text.Trim();
                tlDTO.GhiChu = txtGhiChu.Text.Trim();
                if (tlBUS.Them(tlDTO))
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
        }
    }
}
