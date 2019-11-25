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
    public partial class frmCapNhatTheLoai : Form
    {
        public int matheloai;
        TheLoaiBUS tlBUS = new TheLoaiBUS();
        public frmCapNhatTheLoai()
        {
            InitializeComponent();
        }

        private void frmCapNhatTheLoai_Load(object sender, EventArgs e)
        {
            TheLoaiDTO tl = tlBUS.LayTheLoaiTheoMa(matheloai);
            txtMaTheLoai.Text = matheloai.ToString();
            txtTen.Text = tl.Ten;
            txtGhiChu.Text = tl.GhiChu;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                TheLoaiDTO tl = new TheLoaiDTO();
                tl.MaTheLoai = matheloai;
                tl.Ten = txtTen.Text.Trim();
                tl.GhiChu = txtGhiChu.Text.Trim();
                if (tlBUS.Sua(tl))
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!");
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
