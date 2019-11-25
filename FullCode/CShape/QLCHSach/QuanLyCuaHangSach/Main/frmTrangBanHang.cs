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
using Microsoft.Reporting.WinForms;

namespace QuanLyCuaHangSach
{
    public partial class frmTrangBanHang : Form
    {
        public int manv;
        public string tennv;
        SachBUS sachBUS = new SachBUS();
        KhachHangBUS khBUS = new KhachHangBUS();
        HDBanHangBUS HDBanBUS = new HDBanHangBUS();
        CTHDBanHangBUS CTHDBanBUS = new CTHDBanHangBUS();
        public frmTrangBanHang()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Yes)
            {
                this.Dispose();
            }

        }

        

        private void frmTrangBanHang_Load(object sender, EventArgs e)
        {
            lblMaNV.Text = manv.ToString();
            lblHoTenNV.Text = tennv.ToString();
            //txtMaKH.Text = "1";
        }

        private void txtMaSach_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMaSach.Text != "")
            {
                int masach = Convert.ToInt32(txtMaSach.Text);
                SachDTO sach = sachBUS.LaySachTonKhoTheoMa(masach);
                if (sach.MaSach == 0)
                {
                    MessageBox.Show("Không có mã sách này!");
                    txtMaSach.Clear();
                }
                else
                {
                    txtTenSach.Text = sach.Ten;
                    int rowIndex = -1;
                    for (var i = 0; i < dgvCTHDBanHang.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dgvCTHDBanHang.Rows[i].Cells["colMaSach"].Value) == sach.MaSach)
                        {
                            rowIndex = i;
                            break;
                        }
                    }
                    if (rowIndex == -1)
                    {
                        txtSoLuong.Text = sach.SoLuong.ToString();
                    }
                    else
                    {
                        txtSoLuong.Text = (sach.SoLuong - Convert.ToInt32(dgvCTHDBanHang.Rows[rowIndex].Cells["colSoLuong"].Value)).ToString();
                    }
                    txtGiaBia.Text = sach.GiaBia.ToString();
                    txtSLBan.Text = "1";
                }
            }
            else
            {
                txtTenSach.Clear();
                txtSoLuong.Clear();
                txtGiaBia.Clear();
                txtSLBan.Clear();
            }
        }

        private void txtSLBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtMaSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSLBan_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSLBan.Text != "" && txtSoLuong.Text != "")
            {
                if (Convert.ToInt32(txtSLBan.Text) > Convert.ToInt32(txtSoLuong.Text))
                {
                    txtConLai.Clear();
                    MessageBox.Show("Đã vượt quá số lượng hàng hiện có trong kho!");
                    txtSLBan.Clear();
                    
                }
                else
                {
                    int conlai = Convert.ToInt32(txtSoLuong.Text) - Convert.ToInt32(txtSLBan.Text);
                    txtConLai.Text = conlai.ToString();
                }
            }
            else
            {
                txtConLai.Clear();
            }
            
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            if (txtSLBan.Text != "")
            {   
                int maSach = Convert.ToInt32(txtMaSach.Text);
                int rowIndex = -1;
                for (int i = 0; i < dgvCTHDBanHang.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvCTHDBanHang.Rows[i].Cells["colMaSach"].Value) == maSach)
                    {
                        rowIndex = i;
                        break;
                    }
                }
                if (rowIndex == -1)
                {
                    int rowId = dgvCTHDBanHang.Rows.Add();
                    DataGridViewRow row = dgvCTHDBanHang.Rows[rowId];
                    row.Cells["colMaSach"].Value = txtMaSach.Text;
                    row.Cells["colTenSach"].Value = txtTenSach.Text;
                    row.Cells["colSoLuong"].Value = txtSLBan.Text;
                    row.Cells["colDonGia"].Value = txtGiaBia.Text;
                    row.Cells["colThanhTien"].Value = Convert.ToInt32(row.Cells["colSoLuong"].Value) * Convert.ToInt32(row.Cells["colDonGia"].Value);
                }
                else
                {
                    dgvCTHDBanHang.Rows[rowIndex].Cells["colSoLuong"].Value = Convert.ToDecimal(dgvCTHDBanHang.Rows[rowIndex].Cells["colSoLuong"].Value) + Convert.ToInt32(txtSLBan.Text);
                    dgvCTHDBanHang.Rows[rowIndex].Cells["colThanhTien"].Value = Convert.ToInt32(dgvCTHDBanHang.Rows[rowIndex].Cells["colSoLuong"].Value) * Convert.ToInt32(dgvCTHDBanHang.Rows[rowIndex].Cells["colDonGia"].Value);
                }
                txtMaSach.Clear();
                txtTenSach.Clear();
                txtSoLuong.Clear();
                txtGiaBia.Clear();
                txtConLai.Clear();
                txtSLBan.Clear();
            }
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (dgvCTHDBanHang.Rows.Count > 0)
            {
                pnlBuoc3.Enabled = true;
                int TongTien = 0;
                for (int i = 0; i < dgvCTHDBanHang.Rows.Count; i++)
                {
                    TongTien += Convert.ToInt32(dgvCTHDBanHang.Rows[i].Cells["colThanhTien"].Value);
                }
                txtTongTien.Text = TongTien.ToString();
                txtTongTienSauKM.Text = TongTien.ToString();
                nudTienKhachDua.Value = Convert.ToInt32(txtTongTien.Text);
            }
            
        }

        private void nudKhuyenMai_ValueChanged(object sender, EventArgs e)
        {
            int TongTienSauKM = Convert.ToInt32(txtTongTien.Text) - Convert.ToInt32(nudKhuyenMai.Value);
            txtTongTienSauKM.Text = TongTienSauKM.ToString();
        }

        private void nudTienKhachDua_ValueChanged(object sender, EventArgs e)
        {
            int TienTraLaiKhach = Convert.ToInt32(nudTienKhachDua.Value) - Convert.ToInt32(txtTongTienSauKM.Text);
            txtTienTraLai.Text = TienTraLaiKhach.ToString();
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtMaKH_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (dt.Hour >= 12)
            {
                lblTime.Text = dt.ToString("dd/MM/yyyy - hh:mm:ss") + " PM";
            }
            else
            {
                lblTime.Text = dt.ToString("dd/MM/yyyy - hh:mm:ss") + " AM";
            }
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            dgvCTHDBanHang.Rows.Clear();
        }

        private void btnKHMoi_Click(object sender, EventArgs e)
        {
            using (frmThemKhachHang f = new frmThemKhachHang())
            {
                f.ShowDialog();
            }
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "")
            {
                int makh = Convert.ToInt32(txtMaKH.Text);
                string tenkh = khBUS.LayTenKHTheoMa(makh);
                if (tenkh != null)
                {
                    txtTenKH.Text = tenkh;
                }
                else
                {
                    
                    MessageBox.Show("Không có mã khách hàng này!");
                    txtMaKH.Clear();
                    txtTenKH.Clear();
                }
            }
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Chưa nhập mã khách hàng,\r\nKhách lẻ vui lòng nhập '1'");
            }
            else
            {
                HDBanHangDTO HDBanDTO = new HDBanHangDTO();
                HDBanDTO.MaNV = Convert.ToInt32(lblMaNV.Text);
                HDBanDTO.MaKH = Convert.ToInt32(txtMaKH.Text);
                int mahd = HDBanBUS.Them(HDBanDTO);
                bool isThanhCong = true;
                List<CTHDBanHangDTO> lst = new List<CTHDBanHangDTO>();
                foreach (DataGridViewRow row in dgvCTHDBanHang.Rows)
                {
                    CTHDBanHangDTO CTHDBanDTO = new CTHDBanHangDTO();
                    CTHDBanDTO.MaHD = mahd;
                    CTHDBanDTO.MaSach = Convert.ToInt32(row.Cells["colMaSach"].Value);
                    CTHDBanDTO.TenSach = row.Cells["colTenSach"].Value.ToString();
                    CTHDBanDTO.SoLuong = Convert.ToInt32(row.Cells["colSoLuong"].Value);
                    CTHDBanDTO.GiaBan = Convert.ToInt32(row.Cells["colDonGia"].Value);
                    CTHDBanDTO.ThanhTien = Convert.ToInt32(row.Cells["colThanhTien"].Value);
                    isThanhCong = CTHDBanBUS.Them(CTHDBanDTO);
                    if (!isThanhCong)
                    {
                        break;
                    }
                    sachBUS.CapNhatSoLuong(CTHDBanDTO.MaSach, CTHDBanDTO.SoLuong);
                    lst.Add(CTHDBanDTO);
                }
                if (isThanhCong)
                {
                    MessageBox.Show("Thanh toán thành công!");
                    HDBanBUS.CapNhatTongTien(mahd, Convert.ToInt32(txtTongTienSauKM.Text));
                    using (frmThanhToan f = new frmThanhToan())
                    {
                        f.rpvHoaDon.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangSach.rptHDBanHang.rdlc";
                        f.rpvHoaDon.LocalReport.DataSources.Add(new ReportDataSource("InHDBanHang", lst));
                        f.rpvHoaDon.LocalReport.SetParameters(new ReportParameter("paTenNV", lblHoTenNV.Text, false));
                        f.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Thanh toán không thành công");
                }
                dgvCTHDBanHang.Rows.Clear();
            }
            
        }

        
        private void btnTang_Click(object sender, EventArgs e)
        {
            dgvCTHDBanHang.CurrentRow.Cells["colSoLuong"].Value = Convert.ToInt32(dgvCTHDBanHang.CurrentRow.Cells["colSoLuong"].Value) + 1;
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dgvCTHDBanHang.CurrentRow.Cells["colSoLuong"].Value) == 1)
            {
                dgvCTHDBanHang.Rows.Remove(dgvCTHDBanHang.CurrentRow);
            }
            else
            {
                dgvCTHDBanHang.CurrentRow.Cells["colSoLuong"].Value = Convert.ToInt32(dgvCTHDBanHang.CurrentRow.Cells["colSoLuong"].Value) - 1;
            }
            
        }

        private void txtSLBan_TextChanged(object sender, EventArgs e)
        {
            if (txtSLBan.Text != "" && txtSoLuong.Text != "")
            {
                if (Convert.ToInt32(txtSLBan.Text) > Convert.ToInt32(txtSoLuong.Text))
                {
                    txtConLai.Clear();
                    MessageBox.Show("Đã vượt quá số lượng hàng hiện có trong kho!");
                    txtSLBan.Clear();

                }
                else
                {
                    int conlai = Convert.ToInt32(txtSoLuong.Text) - Convert.ToInt32(txtSLBan.Text);
                    txtConLai.Text = conlai.ToString();
                }
            }
            else
            {
                txtConLai.Clear();
            }
        }
    }
}
