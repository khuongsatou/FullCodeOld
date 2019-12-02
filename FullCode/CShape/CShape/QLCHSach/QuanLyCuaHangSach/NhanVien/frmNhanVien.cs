using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyCuaHangSach
{
    public partial class frmNhanVien : Form
    {
        NhanVienBUS nvBUS = new NhanVienBUS();
        DataView dvNVFilter;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dvNVFilter = nvBUS.LayDanhSach().DefaultView;
            bdsNhanVien.DataSource = dvNVFilter;
            cboTimKiem.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmThemNhanVien f = new frmThemNhanVien())
            {
                f.ShowDialog();
            }
            dvNVFilter = nvBUS.LayDanhSach().DefaultView;
            bdsNhanVien.DataSource = dvNVFilter;
            txtTimKiemTheoMa.Clear();
            txtTimKiemTheoTen.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (frmCapNhatNhanVien f = new frmCapNhatNhanVien())
            {
                f.manv = Convert.ToInt32(dgvDSNhanVien.CurrentRow.Cells["colMaNV"].Value);
                f.ShowDialog();
            }
            dvNVFilter = nvBUS.LayDanhSach().DefaultView;
            bdsNhanVien.DataSource = dvNVFilter;
            txtTimKiemTheoMa.Clear();
            txtTimKiemTheoTen.Clear();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int manv = Convert.ToInt32(dgvDSNhanVien.CurrentRow.Cells["colMaNV"].Value);
            if (manv == 1 || manv == 2)
            {
                MessageBox.Show("Không thể xóa nhân viên là 'Admin'");
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlr == DialogResult.Yes)
                {

                    nvBUS.Xoa(manv);
                    dvNVFilter = nvBUS.LayDanhSach().DefaultView;
                    bdsNhanVien.DataSource = dvNVFilter;
                    txtTimKiemTheoMa.Clear();
                    txtTimKiemTheoTen.Clear();
                }
            }
            
        }

        private void btnDatLaiMatKhau_Click(object sender, EventArgs e)
        {
            int manv = Convert.ToInt32(dgvDSNhanVien.CurrentRow.Cells["colMaNV"].Value);
            if (manv == 1 || manv == 2)
            {
                using (frmDatLaiMatKhau f = new frmDatLaiMatKhau())
                {
                    f.manv = Convert.ToInt32(dgvDSNhanVien.CurrentRow.Cells["colMaNV"].Value);
                    f.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền để thực hiện tác vụ này!");
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTimKiemTheoTen.Text != "")
            {
                dvNVFilter.RowFilter = "HoTen LIKE '%" + txtTimKiemTheoTen.Text + "%'";
            }
            else
            {
                dvNVFilter.RowFilter = "";
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            //    e.Handled = true;
        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTimKiem.SelectedIndex == 0)
            {
                txtTimKiemTheoMa.Visible = true;
                txtTimKiemTheoTen.Visible = false;
            }
            else
            {
                txtTimKiemTheoMa.Visible = false;
                txtTimKiemTheoTen.Visible = true;
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
                dvNVFilter.RowFilter = "MaNV = " + txtTimKiemTheoMa.Text;
            }
            else
            {
                //dvNVFilter = nvBUS.LayDanhSach().DefaultView;
                //bdsNhanVien.DataSource = dvNVFilter;
                dvNVFilter.RowFilter = "";
            }
        }
    }
}
