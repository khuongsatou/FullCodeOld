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
    public partial class frmTheLoai : Form
    {
        TheLoaiBUS tlBUS = new TheLoaiBUS();

        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            bdsTheLoai.DataSource = tlBUS.LayDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmThemTheLoai f = new frmThemTheLoai())
            {
                f.ShowDialog();
            }
            bdsTheLoai.DataSource = tlBUS.LayDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (frmCapNhatTheLoai f = new frmCapNhatTheLoai())
            {
                f.matheloai = Convert.ToInt32(dgvDSTheLoai.CurrentRow.Cells["maTheLoaiDataGridViewTextBoxColumn"].Value);
                f.ShowDialog();
            }
            bdsTheLoai.DataSource = tlBUS.LayDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Yes)
            {
                int matheloai = Convert.ToInt32(dgvDSTheLoai.CurrentRow.Cells["maTheLoaiDataGridViewTextBoxColumn"].Value);
                tlBUS.Xoa(matheloai);
                bdsTheLoai.DataSource = tlBUS.LayDanhSach();
            }
        }
    }
}
