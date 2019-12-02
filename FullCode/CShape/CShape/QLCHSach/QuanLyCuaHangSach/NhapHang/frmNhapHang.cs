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
    public partial class frmNhapHang : Form
    {
        SachBUS sachBUS = new SachBUS();
        HDNhapHangBUS HDNhapBUS = new HDNhapHangBUS();
        CTHDNhapHangBUS CTHDNhapBUS = new CTHDNhapHangBUS();
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void txtMaSach_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMaSach.Text != "")
            {
                int masach = Convert.ToInt32(txtMaSach.Text);
                txtTenSach.Text = sachBUS.LayTenSachTheoMa(masach);
                if (txtTenSach.Text == "")
                {
                    MessageBox.Show("Không có mã sách này!");
                    txtMaSach.Text = "";
                }
            }
            else
            {
                txtTenSach.Text = "";
            }
               
            
        }

        private void txtMaSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "")
            {
                if (nudSoLuong.Value == 0)
                {
                    MessageBox.Show("Chưa nhập số lượng!");
                    return;
                }
                if (nudGiaBia.Value == 0)
                {
                    MessageBox.Show("Chưa nhập giá bìa!");
                    return;
                }
                int maSach = Convert.ToInt32(txtMaSach.Text);
                int rowIndex = -1;
                for (var i = 0; i < dgvCTHDNhapHang.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvCTHDNhapHang.Rows[i].Cells["colMaSach"].Value) == maSach)
                    {
                        rowIndex = i;
                        break;
                    }
                }
                if (rowIndex == -1)
                {
                    int rowId = dgvCTHDNhapHang.Rows.Add();
                    DataGridViewRow row = dgvCTHDNhapHang.Rows[rowId];
                    row.Cells["colMaSach"].Value = txtMaSach.Text;
                    row.Cells["colTenSach"].Value = txtTenSach.Text;
                    row.Cells["colSoLuong"].Value = nudSoLuong.Value;
                    row.Cells["colGiaBia"].Value = nudGiaBia.Value;
                    row.Cells["colGiaNhap"].Value = nudGiaNhap.Value;
                }
                else
                {
                    dgvCTHDNhapHang.Rows[rowIndex].Cells["colSoLuong"].Value = Convert.ToDecimal(dgvCTHDNhapHang.Rows[rowIndex].Cells["colSoLuong"].Value) + nudSoLuong.Value;
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mã sách!");
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Lấy mã hóa đơn vừa nhập
            HDNhapHangDTO HDNhap = new HDNhapHangDTO();
            HDNhap.MaNV = 1;
            int id = HDNhapBUS.Them(HDNhap);
            bool isThanhCong = true;
            // Duyệt danh sách chi tiết hóa đơn (DataGridView)
            foreach (DataGridViewRow row in dgvCTHDNhapHang.Rows)
            {
                CTHDNhapHangDTO CTHDNhap = new CTHDNhapHangDTO();
                CTHDNhap.MaHD = id;
                CTHDNhap.MaSach = Convert.ToInt32(row.Cells["colMaSach"].Value);
                CTHDNhap.SoLuong = Convert.ToInt32(row.Cells["colSoLuong"].Value);
                CTHDNhap.GiaBia = Convert.ToInt32(row.Cells["colGiaBia"].Value);
                CTHDNhap.GiaNhap = Convert.ToInt32(row.Cells["colGiaNhap"].Value);
                isThanhCong = CTHDNhapBUS.Them(CTHDNhap);
                if (!isThanhCong)
                {
                    break;
                }
                sachBUS.CapNhatSoLuongGiaBia(CTHDNhap.MaSach, CTHDNhap.SoLuong, CTHDNhap.GiaBia, CTHDNhap.GiaNhap);
            }
            if (isThanhCong)
            {
                MessageBox.Show("Lưu hoá đơn thành công!");
            }
            else
            {
                MessageBox.Show("Lưu hoá đơn không thành công!");
            }
            btnHuy_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvCTHDNhapHang.Rows.Count > 0)
            {
                dgvCTHDNhapHang.Rows.RemoveAt(dgvCTHDNhapHang.CurrentRow.Index);
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgvCTHDNhapHang.Rows.Clear();
            txtMaSach.Clear();
            txtTenSach.Clear();
            nudGiaBia.Value = 0;
            nudSoLuong.Value = 0;
            nudGiaNhap.Value = 0;
        }

        private void nudGiaBia_ValueChanged(object sender, EventArgs e)
        {
            int gianhap = Convert.ToInt32(nudGiaBia.Value) * 80 / 100;
            nudGiaNhap.Value = gianhap;
        }
    }
}
