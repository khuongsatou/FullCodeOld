using BUS;
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
    public partial class frmKhachHang : Form
    {
        KhachHangBUS khBUS = new KhachHangBUS();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmThemKhachHang f = new frmThemKhachHang())
            {
                f.ShowDialog();
            }
            bdsKhachHang.DataSource = khBUS.LayDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (frmCapNhatKhachHang f = new frmCapNhatKhachHang())
            {
                f.makh = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["colMaKH"].Value);
                f.ShowDialog();
            }
            bdsKhachHang.DataSource = khBUS.LayDanhSach();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            bdsKhachHang.DataSource = khBUS.LayDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int makh = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["colMaKH"].Value);
            if (makh == 1)
            {
                MessageBox.Show("Không thể xóa KH mặc định!");
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlr == DialogResult.Yes)
                {

                    khBUS.Xoa(makh);
                    bdsKhachHang.DataSource = khBUS.LayDanhSach();
                }
            }
            
        }
    }
}
