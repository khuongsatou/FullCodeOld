using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;

namespace QuanLyCuaHangSach
{
    public partial class frmSach : Form
    {
        SachBUS sBUS = new SachBUS();
        DataView dvSachFilter;
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            dvSachFilter = sBUS.LayDanhSach().DefaultView;
            bdsSach.DataSource = dvSachFilter;
            cboTimKiem.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmThemSach f = new frmThemSach())
            {
                f.ShowDialog();
            }
            dvSachFilter = sBUS.LayDanhSach().DefaultView;
            bdsSach.DataSource = dvSachFilter;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (frmCapNhatSach f = new frmCapNhatSach())
            {
                f.masach = Convert.ToInt32(dgvSach.CurrentRow.Cells["colMaSach"].Value);
                f.ShowDialog();
            }
            dvSachFilter = sBUS.LayDanhSach().DefaultView;
            bdsSach.DataSource = dvSachFilter;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Yes)
            {
                int masach = Convert.ToInt32(dgvSach.CurrentRow.Cells["colMaSach"].Value);
                sBUS.Xoa(masach);
                dvSachFilter = sBUS.LayDanhSach().DefaultView;
                bdsSach.DataSource = dvSachFilter;
            }
        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTimKiem.SelectedIndex == 0)
            {
                txtTimKiem.Visible = false;
                txtTimKiemTheoMa.Visible = true;
            }
            else
            {
                txtTimKiem.Visible = true;
                txtTimKiemTheoMa.Visible = false;
            }
        }

        private void txtTimKiemTheoMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTimKiemTheoMa_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTimKiemTheoMa.Text != "")
            {
                dvSachFilter.RowFilter = "MaSach = " + txtTimKiemTheoMa.Text;
            }
            else
            {
                dvSachFilter.RowFilter = "";
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboTimKiem.SelectedIndex == 1)
            {
                if (txtTimKiem.Text != "")
                {
                    dvSachFilter.RowFilter = "Ten LIKE '%" + txtTimKiem.Text + "%'";
                }
                else
                {
                    dvSachFilter.RowFilter = "";
                }
            }
            if (cboTimKiem.SelectedIndex == 2)
            {
                if (txtTimKiem.Text != "")
                {
                    dvSachFilter.RowFilter = "TenTacGia LIKE '%" + txtTimKiem.Text + "%'";
                }
                else
                {
                    dvSachFilter.RowFilter = "";
                }
            }
            if (cboTimKiem.SelectedIndex == 3)
            {
                if (txtTimKiem.Text != "")
                {
                    dvSachFilter.RowFilter = "TenTheLoai LIKE '%" + txtTimKiem.Text + "%'";
                }
                else
                {
                    dvSachFilter.RowFilter = "";
                }
            }
            if (cboTimKiem.SelectedIndex == 4)
            {
                if (txtTimKiem.Text != "")
                {
                    dvSachFilter.RowFilter = "TenNXB LIKE '%" + txtTimKiem.Text + "%'";
                }
                else
                {
                    dvSachFilter.RowFilter = "";
                }
            }
        }
    }
}
