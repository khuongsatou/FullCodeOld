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
    public partial class frmTrangQuanLy : Form
    {

        DataView dvSachFilter;
        DataView dvSach;

        LoaiNhanVienBUS lnvBUS = new LoaiNhanVienBUS();
        NhanVienBUS nvBUS = new NhanVienBUS();
        TheLoaiBUS tlBUS = new TheLoaiBUS();
        TacGiaBUS tgBUS = new TacGiaBUS();
        NhaXuatBanBUS nxbBUS = new NhaXuatBanBUS();
        SachBUS sBUS = new SachBUS();
        KhachHangBUS khBUS = new KhachHangBUS();
        HDNhapHangBUS HDNhapBUS = new HDNhapHangBUS();
        CTHDNhapHangBUS CTHDNhapBUS = new CTHDNhapHangBUS();
        

        
        bool isThemLNV = false;
        bool isSuaLNV = false;
        bool isThemNV = false;
        bool isSuaNV = false;
        bool isThemTL = false;
        bool isSuaTL = false;
        bool isThemTG = false;
        bool isSuaTG = false;
        bool isThemNXB = false;
        bool isSuaNXB = false;
        bool isThemSach = false;
        bool isSuaSach = false;
        bool isThemKH = false;
        bool isSuaKH = false;

        public frmTrangQuanLy()
        {
            InitializeComponent();
        }

        private void frmTrangQuanLy_Load(object sender, EventArgs e)
        {
            
            

            bdsLoaiNhanVien.DataSource = lnvBUS.LayDanhSach();
            bdsNhanVien.DataSource = nvBUS.LayDanhSach();
            bdsCBOLoaiNV.DataSource = lnvBUS.LayDanhSach();
            bdsTheLoai.DataSource = tlBUS.LayDanhSach();
            bdsTacGia.DataSource = tgBUS.LayDanhSach();
            bdsNhaXuatBan.DataSource = nxbBUS.LayDanhSach();

            dvSachFilter = sBUS.LayDanhSach().DefaultView;
            bdsSachFilter.DataSource = dvSachFilter;
            //bdsSach.DataSource = sBUS.LayDanhSach();

            dvSach = sBUS.LayDanhSach().DefaultView;
            bdsSach.DataSource = dvSach;
            //bdsSach.DataSource = sBUS.LayDanhSach();

            bdsCBOTacGia.DataSource = tgBUS.LayDanhSach();
            bdsCBOTheLoai.DataSource = tlBUS.LayDanhSach();
            bdsCBONhaXuatBan.DataSource = nxbBUS.LayDanhSach();
            bdsKhachHang.DataSource = khBUS.LayDanhSach();

            if (dgvDSLoaiNV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSLoaiNV.SelectedRows[0];
                txtMaLoaiNV.Text = row.Cells["colMaLoaiNV_LNV"].Value.ToString();
                txtTenLoaiNV.Text = row.Cells["colTen_LNV"].Value.ToString();
                txtGhiChuLoaiNV.Text = row.Cells["colGhiChu_LNV"].Value.ToString();
            }
            if (dgvDSNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSNhanVien.SelectedRows[0];
                txtMaNV.Text = row.Cells["colMaNV_NV"].Value.ToString();
                cboLoaiNV.SelectedValue = row.Cells["colMaLoaiNV_NV"].Value;
                txtHoTenNV.Text = row.Cells["colHoTen_NV"].Value.ToString();
                dtpNgaySinhNV.Value = Convert.ToDateTime(row.Cells["colNgaySinh_NV"].Value);
                if ((bool)row.Cells["colGioiTinh_NV"].Value == true)
                    radNamNV.Checked = true;
                else
                    radNuNV.Checked = true;
                txtDiaChiNV.Text = row.Cells["colDiaChi_NV"].Value.ToString();
                txtEmailNV.Text = row.Cells["colEmail_NV"].Value.ToString();
                txtDienThoaiNV.Text = row.Cells["colDienThoai_NV"].Value.ToString();
                txtGhiChuNV.Text = row.Cells["colGhiChu_NV"].Value.ToString();
            }
            if (dgvDSTheLoai.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSTheLoai.SelectedRows[0];
                txtMaTheLoai.Text = row.Cells["colMaTheLoai_TL"].Value.ToString();
                txtTenTheLoai.Text = row.Cells["colTen_TL"].Value.ToString();
                txtGhiChuTL.Text = row.Cells["colGhiChu_TL"].Value.ToString();
            }
            if (dgvDSTacGia.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSTacGia.SelectedRows[0];
                txtMaTacGia.Text = row.Cells["colMaTacGia_TG"].Value.ToString();
                txtHoTenTG.Text = row.Cells["colHoTen_TG"].Value.ToString();
                dtpNgaySinhTG.Value = Convert.ToDateTime(row.Cells["colNgaySinh_TG"].Value);
                if ((bool)row.Cells["colGioiTinh_TG"].Value == true)
                    radNamTG.Checked = true;
                else
                    radNuTG.Checked = true;
                txtGhiChuTG.Text = row.Cells["colGhiChu_TG"].Value.ToString();
            }
            if (dgvDSNhaXuatBan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSNhaXuatBan.SelectedRows[0];
                txtMaNXB.Text = row.Cells["colMaNXB_NXB"].Value.ToString();
                txtTenNXB.Text = row.Cells["colTen_NXB"].Value.ToString();
                txtWebsiteNXB.Text = row.Cells["colWebsite_NXB"].Value.ToString();
                txtEmailNXB.Text = row.Cells["colEmail_NXB"].Value.ToString();
                txtGhiChuNXB.Text = row.Cells["colGhiChu_NXB"].Value.ToString();
            }
            if (dgvDSSach.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSSach.SelectedRows[0];
                txtMaSach.Text = row.Cells["colMaSach_Sach"].Value.ToString();
                txtTenSach.Text = row.Cells["colTen_Sach"].Value.ToString();
                cboTacGia.SelectedValue = row.Cells["colMaTacGia_Sach"].Value;
                cboTheLoai.SelectedValue = row.Cells["colMaTheLoai_Sach"].Value;
                cboNhaXuatBan.SelectedValue = row.Cells["colMaNXB_Sach"].Value;
                dtpNgayXuatBan.Value = Convert.ToDateTime(row.Cells["colNgayXuatBan_Sach"].Value);
                txtSoLuongSach.Text = row.Cells["colSoLuong_Sach"].Value.ToString();
                txtGiaBia.Text = row.Cells["colGiaBia_Sach"].Value.ToString();
                txtGhiChuSach.Text = row.Cells["colGhiChu_Sach"].Value.ToString();
            }
            if (dgvDSKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSKhachHang.SelectedRows[0];
                txtMaKH_KH.Text = row.Cells["colMaKH_KH"].Value.ToString();
                txtHoTen_KH.Text = row.Cells["colHoTen_KH"].Value.ToString();
                dtpNgaySInh_KH.Value = Convert.ToDateTime(row.Cells["colNgaySinh_KH"].Value);
                if ((bool)row.Cells["colGioiTinh_KH"].Value == true)
                    radNam_KH.Checked = true;
                else
                    radNu_KH.Checked = true;
                txtDiaChi_KH.Text = row.Cells["colDiaChi_KH"].Value.ToString();
                txtEmail_KH.Text = row.Cells["colEmail_KH"].Value.ToString();
                txtDienThoai_KH.Text = row.Cells["colDienThoai_KH"].Value.ToString();
                txtGhiChu_KH.Text = row.Cells["colGhiChu_KH"].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region LoaiNhanVien

        private void btnThemLoaiNV_Click(object sender, EventArgs e)
        {
            btnLuuLoaiNV.Visible = true;
            pnlControlLoaiNV.Enabled = true;
            pnlChucNangLNV.Enabled = false;
            txtMaLoaiNV.Clear();
            txtTenLoaiNV.Clear();
            txtGhiChuLoaiNV.Clear();
            isThemLNV = true;
            dgvDSLoaiNV.Enabled = false;

        }

        private void btnXoaLoaiNV_Click(object sender, EventArgs e)
        {
            if (dgvDSLoaiNV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSLoaiNV.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["colMaLoaiNV_LNV"].Value.ToString());
                if (lnvBUS.Xoa(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    bdsLoaiNhanVien.DataSource = lnvBUS.LayDanhSach();
                    bdsCBOLoaiNV.DataSource = lnvBUS.LayDanhSach();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }

        }

        private void btnSuaLoaiNV_Click(object sender, EventArgs e)
        {
            isSuaLNV = true;
            pnlChucNangLNV.Enabled = false;
            pnlControlLoaiNV.Enabled = true;
            btnLuuLoaiNV.Visible = true;
            dgvDSLoaiNV.Enabled = false;
        }

        private void btnLuuLoaiNV_Click(object sender, EventArgs e)
        {
            if (isThemLNV)
            {
                try
                {
                    LoaiNhanVienDTO lnvDTO = new LoaiNhanVienDTO();
                    lnvDTO.Ten = txtTenLoaiNV.Text.Trim();
                    lnvDTO.GhiChu = txtGhiChuLoaiNV.Text.Trim();
                    if (lnvBUS.Them(lnvDTO))
                    {
                        MessageBox.Show("Thêm thành công!");
                        bdsLoaiNhanVien.DataSource = lnvBUS.LayDanhSach();
                    }
                    else
                        MessageBox.Show("Thêm không thành công!");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    bdsCBOLoaiNV.DataSource = lnvBUS.LayDanhSach();
                    isThemLNV = false;
                    pnlChucNangLNV.Enabled = true;
                    pnlControlLoaiNV.Enabled = false;
                    dgvDSLoaiNV.Enabled = false;
                }
            }
            if (isSuaLNV)
            {
                try
                {
                    LoaiNhanVienDTO lnvDTO = new LoaiNhanVienDTO();
                    lnvDTO.MaLoaiNV = Convert.ToInt32(txtMaLoaiNV.Text);
                    lnvDTO.Ten = txtTenLoaiNV.Text.Trim();
                    lnvDTO.GhiChu = txtGhiChuLoaiNV.Text.Trim();
                    if (lnvBUS.Sua(lnvDTO))
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        bdsLoaiNhanVien.DataSource = lnvBUS.LayDanhSach();
                    }
                    else
                        MessageBox.Show("Cập nhật không thành công!");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    bdsCBOLoaiNV.DataSource = lnvBUS.LayDanhSach();
                    pnlChucNangLNV.Enabled = true;
                    pnlControlLoaiNV.Enabled = false;
                    isSuaLNV = false;
                    dgvDSLoaiNV.Enabled = false;
                }
            }
        }

        private void btnHuy_LNV_Click(object sender, EventArgs e)
        {
            pnlControlLoaiNV.Enabled = false;
            pnlChucNangLNV.Enabled = true;
            txtMaLoaiNV.Clear();
            txtTenLoaiNV.Clear();
            txtGhiChuLoaiNV.Clear();
            isThemLNV = false;
            isSuaLNV = false;
            dgvDSLoaiNV.Enabled = true;
        }

        private void dgvDSLoaiNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDSLoaiNV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSLoaiNV.SelectedRows[0];
                txtMaLoaiNV.Text = row.Cells["colMaLoaiNV_LNV"].Value.ToString();
                txtTenLoaiNV.Text = row.Cells["colTen_LNV"].Value.ToString();
                txtGhiChuLoaiNV.Text = row.Cells["colGhiChu_LNV"].Value.ToString();
            }
        }

        #endregion

        #region NhanVien

        private void resetControlNV()
        {
            txtMaNV.Clear();
            txtHoTenNV.Clear();
            txtMatKhauNV.Clear();
            dtpNgaySinhNV.Value = DateTime.Now;
            radNamNV.Checked = true;
            txtDiaChiNV.Clear();
            txtEmailNV.Clear();
            txtDienThoaiNV.Clear();
            txtGhiChuNV.Clear();
            cboLoaiNV.SelectedValue = -1;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            btnLuuNV.Visible = true;
            pnlChucNangNhanVien.Enabled = false;
            pnlControlNhanVien.Enabled = true;
            //pnlControlNhanVien.Visible = true;
            isThemNV = true;
            resetControlNV();
            dgvDSNhanVien.Enabled = false;
            txtMatKhauNV.ReadOnly = false;
            
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            btnLuuNV.Visible = true;
            pnlChucNangNhanVien.Enabled = false;
            pnlControlNhanVien.Enabled = true;
            isSuaNV = true;
            btnDatLaiMatKhau.Enabled = true;
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            if (isThemNV)
            {
                try
                {
                    NhanVienDTO nvDTO = new NhanVienDTO();
                    nvDTO.MatKhau = txtMatKhauNV.Text.Trim();
                    nvDTO.MaLoaiNV = Convert.ToInt32(cboLoaiNV.SelectedValue);
                    nvDTO.HoTen = txtHoTenNV.Text.Trim();
                    nvDTO.NgaySinh = dtpNgaySinhNV.Value;
                    nvDTO.GioiTinh = radNamNV.Checked ? true : false;
                    nvDTO.DiaChi = txtDiaChiNV.Text.Trim();
                    nvDTO.Email = txtEmailNV.Text.Trim();
                    nvDTO.DienThoai = txtDienThoaiNV.Text.Trim();
                    nvDTO.GhiChu = txtGhiChuNV.Text.Trim();
                    if (nvBUS.Them(nvDTO))
                    {
                        MessageBox.Show("Thêm thành công!");
                        bdsNhanVien.DataSource = nvBUS.LayDanhSach();
                    }
                    else
                        MessageBox.Show("Thêm không thành công!");
                    btnLuuNV.Visible = false;
                    isThemNV = false;
                    resetControlNV();
                    pnlChucNangNhanVien.Enabled = true;
                    pnlControlNhanVien.Enabled = false;
                    txtMatKhauNV.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            if (isSuaNV)
            {
                try
                {
                    NhanVienDTO nvDTO = new NhanVienDTO();
                    nvDTO.MaNV = Convert.ToInt32(txtMaNV.Text);
                    nvDTO.MaLoaiNV = Convert.ToInt32(cboLoaiNV.SelectedValue);
                    nvDTO.HoTen = txtHoTenNV.Text.Trim();
                    nvDTO.NgaySinh = dtpNgaySinhNV.Value;
                    nvDTO.GioiTinh = radNamNV.Checked ? true : false;
                    nvDTO.DiaChi = txtDiaChiNV.Text.Trim();
                    nvDTO.Email = txtEmailNV.Text.Trim();
                    nvDTO.DienThoai = txtDienThoaiNV.Text.Trim();
                    nvDTO.GhiChu = txtGhiChuNV.Text.Trim();
                    if (nvBUS.Sua(nvDTO))
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        

                    }
                    else
                        MessageBox.Show("Cập nhật không thành công!");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    bdsNhanVien.DataSource = nvBUS.LayDanhSach();
                    btnLuuNV.Visible = false;
                    isSuaNV = false;
                    pnlChucNangNhanVien.Enabled = true;
                    pnlControlNhanVien.Enabled = false;
                }
                
            }
        }

        private void dgvDSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSNhanVien.SelectedRows[0];
                txtMaNV.Text = row.Cells["colMaNV_NV"].Value.ToString();
                cboLoaiNV.SelectedValue = row.Cells["colMaLoaiNV_NV"].Value;
                txtHoTenNV.Text = row.Cells["colHoTen_NV"].Value.ToString();
                dtpNgaySinhNV.Value = Convert.ToDateTime(row.Cells["colNgaySinh_NV"].Value);
                if ((bool)row.Cells["colGioiTinh_NV"].Value == true)
                    radNamNV.Checked = true;
                else
                    radNuNV.Checked = true;
                txtDiaChiNV.Text = row.Cells["colDiaChi_NV"].Value.ToString();
                txtEmailNV.Text = row.Cells["colEmail_NV"].Value.ToString();
                txtDienThoaiNV.Text = row.Cells["colDienThoai_NV"].Value.ToString();
                txtGhiChuNV.Text = row.Cells["colGhiChu_NV"].Value.ToString();
            }
            
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (dgvDSNhanVien.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(txtMaNV.Text);
                if (nvBUS.Xoa(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    bdsNhanVien.DataSource = nvBUS.LayDanhSach();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
                resetControlNV();
                dgvDSNhanVien.ClearSelection();
            }
        }

        private void btnDatLaiMatKhau_Click(object sender, EventArgs e)
        {
            Program.MaNV_ResetPWD = Convert.ToInt32(txtMaNV.Text);
            frmDatLaiMatKhau f = new frmDatLaiMatKhau();
            f.ShowDialog();

        }
        #endregion

        #region TheLoai

        private void resetControlTL()
        {
            txtMaTheLoai.Clear();
            txtTenTheLoai.Clear();
            txtGhiChuTL.Clear();
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            isThemTL = true;
            pnlControlTheLoai.Enabled = true;
            pnlChucNangTheLoai.Enabled = false;
            btnLuuTheLoai.Visible = true;
            resetControlTL();
        }

        private void btnSuaTheLoai_Click(object sender, EventArgs e)
        {
            isSuaTL = true;
            pnlControlTheLoai.Enabled = true;
            pnlChucNangTheLoai.Enabled = false;
            btnLuuTheLoai.Visible = true;
        }

        private void dgvDSTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSTheLoai.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSTheLoai.SelectedRows[0];
                txtMaTheLoai.Text = row.Cells["colMaTheLoai_TL"].Value.ToString();
                txtTenTheLoai.Text = row.Cells["colTen_TL"].Value.ToString();
                txtGhiChuTL.Text = row.Cells["colGhiChu_TL"].Value.ToString();
            }
        }

        private void btnXoaTheLoai_Click(object sender, EventArgs e)
        {
            if (dgvDSTheLoai.CurrentRow != null)
            {
                int id = (int)dgvDSTheLoai.CurrentRow.Cells["colMaTheLoai_TL"].Value;
                if (tlBUS.Xoa(id))
                {
                    MessageBox.Show("Xoá thành công!");
                    bdsTheLoai.DataSource = tlBUS.LayDanhSach();
                }
                else
                {
                    MessageBox.Show("Xoá không thành công!");
                }
            }
        }

        private void btnLuuTheLoai_Click(object sender, EventArgs e)
        {
            if (isThemTL)
            {
                try
                {
                    TheLoaiDTO tlDTO = new TheLoaiDTO();
                    tlDTO.Ten = txtTenTheLoai.Text.Trim();
                    tlDTO.GhiChu = txtGhiChuTL.Text.Trim();
                    if (tlBUS.Them(tlDTO))
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                        MessageBox.Show("Thêm không thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    bdsTheLoai.DataSource = tlBUS.LayDanhSach();
                    bdsCBOTheLoai.DataSource = tlBUS.LayDanhSach();
                    isThemTL = false;
                    pnlControlTheLoai.Enabled = false;
                    pnlChucNangTheLoai.Enabled = true;
                    btnLuuTheLoai.Visible = false;
                    resetControlTL();
                }
            }
            if (isSuaTL)
            {
                try
                {
                    TheLoaiDTO tlDTO = new TheLoaiDTO();
                    tlDTO.MaTheLoai = Convert.ToInt32(txtMaTheLoai.Text);
                    tlDTO.Ten = txtTenTheLoai.Text.Trim();
                    tlDTO.GhiChu = txtGhiChuTL.Text.Trim();
                    if (tlBUS.Sua(tlDTO))
                        MessageBox.Show("Sửa thành công!");
                    else
                        MessageBox.Show("Sửa không thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    bdsTheLoai.DataSource = tlBUS.LayDanhSach();
                    bdsCBOTheLoai.DataSource = tlBUS.LayDanhSach();
                    isSuaTL = false;
                    pnlControlTheLoai.Enabled = false;
                    pnlChucNangTheLoai.Enabled = true;
                    btnLuuTheLoai.Visible = false;
                    resetControlTL();
                }
            }
        }

        #endregion

        #region TacGia

        private void resetControlTG()
        {
            txtMaTacGia.Clear();
            txtHoTenTG.Clear();
            dtpNgaySinhTG.Value = DateTime.Now;
            radNamTG.Checked = true;
            txtDiaChiTG.Clear();
            txtEmailTG.Clear();
            txtDienThoaiTG.Clear();
            txtGhiChuTG.Clear();
        }

        private void dgvDSTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSTacGia.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSTacGia.SelectedRows[0];
                txtMaTacGia.Text = row.Cells["colMaTacGia_TG"].Value.ToString();
                txtHoTenTG.Text = row.Cells["colHoTen_TG"].Value.ToString();
                dtpNgaySinhTG.Value = Convert.ToDateTime(row.Cells["colNgaySinh_TG"].Value);
                if ((bool)row.Cells["colGioiTinh_TG"].Value == true)
                    radNamTG.Checked = true;
                else
                    radNuTG.Checked = true;
                txtGhiChuTG.Text = row.Cells["colGhiChu_TG"].Value.ToString();
            }
        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            btnLuuTG.Visible = true;
            pnlChucNangTacGia.Enabled = false;
            pnlControlTacGia.Enabled = true;
            isThemTG = true;
            resetControlTG();
        }

        private void btnSuaTacGia_Click(object sender, EventArgs e)
        {
            btnLuuTG.Visible = true;
            pnlChucNangTacGia.Enabled = false;
            pnlControlTacGia.Enabled = true;
            isSuaTG = true;
        }

        private void btnXoaTacGia_Click(object sender, EventArgs e)
        {
            if (dgvDSTacGia.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(txtMaTacGia.Text);
                if (tgBUS.Xoa(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    bdsTacGia.DataSource = tgBUS.LayDanhSach();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
                resetControlTG();
                
            }
        }

        private void btnLuuTG_Click(object sender, EventArgs e)
        {
            if (isThemTG)
            {
                try
                {
                    TacGiaDTO tgDTO = new TacGiaDTO();
                    tgDTO.HoTen = txtHoTenTG.Text.Trim();
                    tgDTO.NgaySinh = dtpNgaySinhTG.Value;
                    tgDTO.GioiTinh = radNamTG.Checked ? true : false;
                    tgDTO.GhiChu = txtGhiChuTG.Text.Trim();
                    if (tgBUS.Them(tgDTO))
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    btnLuuTG.Visible = false;
                    pnlChucNangTacGia.Enabled = true;
                    pnlControlTacGia.Enabled = false;
                    isThemTG = false;
                    //resetControlTG();
                    bdsTacGia.DataSource = tgBUS.LayDanhSach();
                    bdsCBOTacGia.DataSource = tgBUS.LayDanhSach();
                }
            }
            if (isSuaTG)
            {
                try
                {
                    TacGiaDTO tgDTO = new TacGiaDTO();
                    tgDTO.MaTacGia = Convert.ToInt32(txtMaTacGia.Text);
                    tgDTO.HoTen = txtHoTenTG.Text.Trim();
                    tgDTO.NgaySinh = dtpNgaySinhTG.Value;
                    tgDTO.GioiTinh = radNamTG.Checked ? true : false;
                    tgDTO.GhiChu = txtGhiChuTG.Text.Trim();
                    if (tgBUS.Sua(tgDTO))
                    {
                        MessageBox.Show("Sửa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    btnLuuTG.Visible = false;
                    pnlChucNangTacGia.Enabled = true;
                    pnlControlTacGia.Enabled = false;
                    isSuaTG = false;
                    //resetControlTG();
                    bdsTacGia.DataSource = tgBUS.LayDanhSach();
                    bdsCBOTacGia.DataSource = tgBUS.LayDanhSach();
                }
            }
        }

        #endregion

        #region NhaXuatBan

        private void resetControlNXB()
        {
            txtMaNXB.Clear();
            txtTenNXB.Clear();
            txtWebsiteNXB.Clear();
            txtEmailNXB.Clear();
            txtGhiChuNXB.Clear();
        }

        private void resetPanelNXB()
        {

        }

        private void dgvDSNhaXuatBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSNhaXuatBan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSNhaXuatBan.SelectedRows[0];
                txtMaNXB.Text = row.Cells["colMaNXB_NXB"].Value.ToString();
                txtTenNXB.Text = row.Cells["colTen_NXB"].Value.ToString();
                txtWebsiteNXB.Text = row.Cells["colWebsite_NXB"].Value.ToString();
                txtEmailNXB.Text = row.Cells["colEmail_NXB"].Value.ToString();
                txtGhiChuNXB.Text = row.Cells["colGhiChu_NXB"].Value.ToString();
            }
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            isThemNXB = true;
            btnLuuNXB.Visible = true;
            pnlChucNangNXB.Enabled = false;
            pnlControlNXB.Enabled = true;
            resetControlNXB();
        }

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            isSuaNXB = true;
            btnLuuNXB.Visible = true;
            pnlChucNangNXB.Enabled = false;
            pnlControlNXB.Enabled = true;
        }

        private void btnLuuNXB_Click(object sender, EventArgs e)
        {
            if (isThemNXB)
            {
                try
                {
                    NhaXuatBanDTO nxbDTO = new NhaXuatBanDTO();
                    nxbDTO.Ten = txtTenNXB.Text.Trim();
                    nxbDTO.Website = txtWebsiteNXB.Text.Trim();
                    nxbDTO.Email = txtEmailNXB.Text.Trim();
                    nxbDTO.GhiChu = txtGhiChuNXB.Text.Trim();
                    if (nxbBUS.Them(nxbDTO))
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    bdsNhaXuatBan.DataSource = nxbBUS.LayDanhSach();
                    isThemNXB = false;
                    btnLuuNXB.Visible = false;
                    pnlChucNangNXB.Enabled = true;
                    pnlControlNXB.Enabled = false;
                    resetControlNXB();
                    bdsCBONhaXuatBan.DataSource = nxbBUS.LayDanhSach();
                }
            }
            if (isSuaNXB)
            {
                try
                {
                    NhaXuatBanDTO nxbDTO = new NhaXuatBanDTO();
                    nxbDTO.MaNXB = Convert.ToInt32(txtMaNXB.Text);
                    nxbDTO.Ten = txtTenNXB.Text.Trim();
                    nxbDTO.Website = txtWebsiteNXB.Text.Trim();
                    nxbDTO.Email = txtEmailNXB.Text.Trim();
                    nxbDTO.GhiChu = txtGhiChuNXB.Text.Trim();
                    if (nxbBUS.Sua(nxbDTO))
                    {
                        MessageBox.Show("Sửa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    bdsNhaXuatBan.DataSource = nxbBUS.LayDanhSach();
                    bdsCBONhaXuatBan.DataSource = nxbBUS.LayDanhSach();
                    isSuaNXB = false;
                    btnLuuNXB.Visible = false;
                    pnlChucNangNXB.Enabled = true;
                    pnlControlNXB.Enabled = false;
                    //resetControlNXB();
                }
            }
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            if (dgvDSNhaXuatBan.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(txtMaNXB.Text);
                if (nxbBUS.Xoa(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    bdsNhaXuatBan.DataSource = nxbBUS.LayDanhSach();
                    bdsCBONhaXuatBan.DataSource = nxbBUS.LayDanhSach();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
                resetControlNXB();

            }
        }

        #endregion

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            
        }

        #region Sach

        private void resetControlSach()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            cboTacGia.SelectedValue = 0;
            cboTheLoai.SelectedValue = 0;
            cboNhaXuatBan.SelectedValue = 0;
            dtpNgayXuatBan.Value = DateTime.Now;
            txtSoLuongSach.Clear();
            txtGiaBia.Clear();
            txtGhiChuSach.Clear();
        }

        private void dgvDSSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvDSSach.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow row = dgvDSSach.SelectedRows[0];
            //    txtMaSach.Text = row.Cells["colMaSach_Sach"].Value.ToString();
            //    txtTenSach.Text = row.Cells["colTen_Sach"].Value.ToString();
            //    cboTacGia.SelectedValue = row.Cells["colMaTacGia_Sach"].Value;
            //    cboTheLoai.SelectedValue = row.Cells["colMaTheLoai_Sach"].Value;
            //    cboNhaXuatBan.SelectedValue = row.Cells["colMaNXB_Sach"].Value;
            //    dtpNgayXuatBan.Value = Convert.ToDateTime(row.Cells["colNgayXuatBan_Sach"].Value);
            //    txtSoLuongSach.Text = row.Cells["colSoLuong_Sach"].Value.ToString();
            //    txtGiaBia.Text = row.Cells["colGiaBia_Sach"].Value.ToString();
            //    txtGhiChuSach.Text = row.Cells["colGhiChu_Sach"].Value.ToString();
            //}
        }

        private void dgvDSSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvDSSach.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow row = dgvDSSach.SelectedRows[0];
            //    txtMaSach.Text = row.Cells["colMaSach_Sach"].Value.ToString();
            //    txtTenSach.Text = row.Cells["colTen_Sach"].Value.ToString();
            //    cboTacGia.SelectedValue = row.Cells["colMaTacGia_Sach"].Value;
            //    cboTheLoai.SelectedValue = row.Cells["colMaTheLoai_Sach"].Value;
            //    cboNhaXuatBan.SelectedValue = row.Cells["colMaNXB_Sach"].Value;
            //    dtpNgayXuatBan.Value = Convert.ToDateTime(row.Cells["colNgayXuatBan_Sach"].Value);
            //    txtSoLuongSach.Text = row.Cells["colSoLuong_Sach"].Value.ToString();
            //    txtGiaBia.Text = row.Cells["colGiaBia_Sach"].Value.ToString();
            //    txtGhiChuSach.Text = row.Cells["colGhiChu_Sach"].Value.ToString();
            //}
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            isThemSach = true;
            pnlChucNangSach.Enabled = false;
            pnlControlSach.Enabled = true;
            btnLuuSach.Visible = true;
            resetControlSach();
            dgvDSSach.Enabled = false;
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            isSuaSach = true;
            pnlChucNangSach.Enabled = false;
            pnlControlSach.Enabled = true;
            btnLuuSach.Visible = true;
            dgvDSSach.Enabled = false;
            
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (dgvDSSach.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvDSSach.SelectedRows[0].Cells["colMaSach_Sach"].Value);
                if (sBUS.Xoa(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    bdsSach.DataSource = sBUS.LayDanhSach();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
        }

        private void btnLuuSach_Click(object sender, EventArgs e)
        {
            if (isThemSach)
            {
                try
                {
                    SachDTO sDTO = new SachDTO();
                    sDTO.Ten = txtTenSach.Text.Trim();
                    sDTO.MaTacGia = Convert.ToInt32(cboTacGia.SelectedValue);
                    sDTO.MaTheLoai = Convert.ToInt32(cboTheLoai.SelectedValue);
                    sDTO.MaNXB = Convert.ToInt32(cboNhaXuatBan.SelectedValue);
                    sDTO.NgayXuatBan = dtpNgayXuatBan.Value;
                    sDTO.GhiChu = txtGhiChuSach.Text.Trim();
                    if (sBUS.Them(sDTO))
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    isThemSach = false;
                    pnlChucNangSach.Enabled = true;
                    pnlControlSach.Enabled = false;
                    btnLuuSach.Visible = false;
                    bdsSach.DataSource = sBUS.LayDanhSach();
                    dgvDSSach.Enabled = true;
                }
            }
            if (isSuaSach)
            {
                try
                {
                    SachDTO sDTO = new SachDTO();
                    sDTO.MaSach = Convert.ToInt32(txtMaSach.Text);
                    sDTO.Ten = txtTenSach.Text.Trim();
                    sDTO.MaTacGia = Convert.ToInt32(cboTacGia.SelectedValue);
                    sDTO.MaTheLoai = Convert.ToInt32(cboTheLoai.SelectedValue);
                    sDTO.MaNXB = Convert.ToInt32(cboNhaXuatBan.SelectedValue);
                    sDTO.NgayXuatBan = dtpNgayXuatBan.Value;
                    sDTO.GhiChu = txtGhiChuSach.Text.Trim();
                    if (sBUS.Sua(sDTO))
                    {
                        MessageBox.Show("Sửa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    isSuaSach = false;
                    pnlChucNangSach.Enabled = true;
                    pnlControlSach.Enabled = false;
                    btnLuuSach.Visible = false;
                    bdsSach.DataSource = sBUS.LayDanhSach();
                    dgvDSSach.Enabled = true;
                    dgvDSSach.ClearSelection();
                    resetControlSach();
                }
            }

        }

        private void dgvDSSach_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSSach.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSSach.SelectedRows[0];
                txtMaSach.Text = row.Cells["colMaSach_Sach"].Value.ToString();
                txtTenSach.Text = row.Cells["colTen_Sach"].Value.ToString();
                cboTacGia.SelectedValue = row.Cells["colMaTacGia_Sach"].Value;
                cboTheLoai.SelectedValue = row.Cells["colMaTheLoai_Sach"].Value;
                cboNhaXuatBan.SelectedValue = row.Cells["colMaNXB_Sach"].Value;
                dtpNgayXuatBan.Value = Convert.ToDateTime(row.Cells["colNgayXuatBan_Sach"].Value);
                txtSoLuongSach.Text = row.Cells["colSoLuong_Sach"].Value.ToString();
                txtGiaBia.Text = row.Cells["colGiaBia_Sach"].Value.ToString();
                txtGhiChuSach.Text = row.Cells["colGhiChu_Sach"].Value.ToString();
            }
        }

        private void txtTimKiemSach_KeyUp(object sender, KeyEventArgs e)
        {
            dvSach.RowFilter = "Ten LIKE '%" + txtTimKiemSach.Text + "%'";
        }

        #endregion

        #region KhachHang

        private void resetControlKH()
        {
            txtMaKH_KH.Clear();
            txtHoTen_KH.Clear();
            dtpNgaySInh_KH.Value = DateTime.Now;
            radNam_KH.Checked = true;
            txtDiaChi_KH.Clear();
            txtEmail_KH.Clear();
            txtDienThoai_KH.Clear();
            txtGhiChu_KH.Clear();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            btnLuu_KH.Visible = true;
            pnlChucNangKH.Enabled = false;
            pnlControlKH.Enabled = true;
            isThemKH = true;
            resetControlKH();
            dgvDSKhachHang.Enabled = false;
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            btnLuu_KH.Visible = true;
            pnlChucNangKH.Enabled = false;
            pnlControlKH.Enabled = true;
            isSuaKH = true;
            dgvDSKhachHang.Enabled = false;
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (dgvDSKhachHang.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(txtMaKH_KH.Text);
                if (nvBUS.Xoa(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    bdsKhachHang.DataSource = khBUS.LayDanhSach();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
                resetControlKH();
                dgvDSKhachHang.ClearSelection();
            }
        }

        private void btnLuu_KH_Click(object sender, EventArgs e)
        {
            if (isThemKH)
            {
                try
                {
                    KhachHangDTO khDTO = new KhachHangDTO();
                    khDTO.HoTen = txtHoTen_KH.Text.Trim();
                    khDTO.NgaySinh = dtpNgaySInh_KH.Value;
                    khDTO.GioiTinh = radNam_KH.Checked ? true : false;
                    khDTO.DiaChi = txtDiaChi_KH.Text.Trim();
                    khDTO.Email = txtEmail_KH.Text.Trim();
                    khDTO.DienThoai = txtDienThoai_KH.Text.Trim();
                    khDTO.GhiChu = txtGhiChu_KH.Text.Trim();
                    if (khBUS.Them(khDTO))
                        MessageBox.Show("Thêm thành công!");
                    else
                        MessageBox.Show("Thêm không thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    bdsKhachHang.DataSource = khBUS.LayDanhSach();
                    btnLuu_KH.Visible = false;
                    isThemKH = false;
                    resetControlKH();
                    pnlChucNangKH.Enabled = true;
                    pnlControlKH.Enabled = false;
                    dgvDSKhachHang.Enabled = true;
                }
            }
            if (isSuaKH)
            {
                try
                {
                    KhachHangDTO khDTO = new KhachHangDTO();
                    khDTO.MaKH = Convert.ToInt32(txtMaKH_KH.Text);
                    khDTO.HoTen = txtHoTen_KH.Text.Trim();
                    khDTO.NgaySinh = dtpNgaySInh_KH.Value;
                    khDTO.GioiTinh = radNam_KH.Checked ? true : false;
                    khDTO.DiaChi = txtDiaChi_KH.Text.Trim();
                    khDTO.Email = txtEmail_KH.Text.Trim();
                    khDTO.DienThoai = txtDienThoai_KH.Text.Trim();
                    khDTO.GhiChu = txtGhiChu_KH.Text.Trim();
                    if (khBUS.Sua(khDTO))
                        MessageBox.Show("Sửa thành công!");
                    else
                        MessageBox.Show("Sửa không thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    bdsKhachHang.DataSource = khBUS.LayDanhSach();
                    btnLuu_KH.Visible = false;
                    isSuaKH = false;
                    resetControlKH();
                    pnlChucNangKH.Enabled = true;
                    pnlControlKH.Enabled = false;
                    dgvDSKhachHang.Enabled = true;
                }
            }
        }

        private void dgvDSKhachHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSKhachHang.SelectedRows[0];
                txtMaKH_KH.Text = row.Cells["colMaKH_KH"].Value.ToString();
                txtHoTen_KH.Text = row.Cells["colHoTen_KH"].Value.ToString();
                dtpNgaySInh_KH.Value = Convert.ToDateTime(row.Cells["colNgaySinh_KH"].Value);
                if ((bool)row.Cells["colGioiTinh_KH"].Value == true)
                    radNam_KH.Checked = true;
                else
                    radNu_KH.Checked = true;
                txtDiaChi_KH.Text = row.Cells["colDiaChi_KH"].Value.ToString();
                txtEmail_KH.Text = row.Cells["colEmail_KH"].Value.ToString();
                txtDienThoai_KH.Text = row.Cells["colDienThoai_KH"].Value.ToString();
                txtGhiChu_KH.Text = row.Cells["colGhiChu_KH"].Value.ToString();
            }
        }

        #endregion

        #region NhapHang

        private void btnThemSach_CTHD_Click(object sender, EventArgs e)
        {
            if (nudSoLuongNhap.Value == 0)
            {
                MessageBox.Show("Chưa nhập số lượng");
                return;
            }
            if (nudGiaBiaNhap.Value == 0)
            {
                MessageBox.Show("Chưa nhập giá bìa");
                return;
            }
            int maSach = Convert.ToInt32(dgvDSSachFilter.SelectedRows[0].Cells["colMaSach_Filter"].Value);
            int rowIndex = -1;
            for (var i = 0; i < dgvDSCTHDNhap.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvDSCTHDNhap.Rows[i].Cells["colMaSach_CTHD"].Value) == maSach)
                {
                    rowIndex = i;
                    break;
                }
            }
            if (rowIndex == -1)
            {
                int rowId = dgvDSCTHDNhap.Rows.Add();
                DataGridViewRow row = dgvDSCTHDNhap.Rows[rowId];
                row.Cells["colMaSach_CTHD"].Value = dgvDSSachFilter.SelectedRows[0].Cells["colMaSach_Filter"].Value;
                row.Cells["colTenSach_CTHD"].Value = dgvDSSachFilter.SelectedRows[0].Cells["colTenSach_Filter"].Value;
                row.Cells["colSoLuong_CTHD"].Value = nudSoLuongNhap.Value;
                row.Cells["colGiaBia_CTHD"].Value = nudGiaBiaNhap.Value;
            }
            else
            {
                dgvDSCTHDNhap.Rows[rowIndex].Cells["colSoLuong_CTHD"].Value = Convert.ToDecimal(dgvDSCTHDNhap.Rows[rowIndex].Cells["colSoLuong_CTHD"].Value) + nudSoLuongNhap.Value;
            }
        }

        private void txtFilterSach_KeyUp(object sender, KeyEventArgs e)
        {
            dvSachFilter.RowFilter = "Ten LIKE '%" + txtFilterSach.Text + "%'";
        }

        private void dgvDSSachFilter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvDSSachFilter.SelectedRows.Count > 0)
            //{
            //    nudSoLuongNhap.Enabled = true;
            //    nudGiaBiaNhap.Enabled = true;
            //}
        }

        private void btnXoaSach_CTHD_Click(object sender, EventArgs e)
        {
            dgvDSCTHDNhap.Rows.RemoveAt(dgvDSCTHDNhap.CurrentRow.Index);
        }

        private void btnLuuHDNhap_Click(object sender, EventArgs e)
        {
            // Lấy mã hóa đơn vừa nhập
            HDNhapHangDTO HDNhap = new HDNhapHangDTO();
            HDNhap.MaNV = 1;
            int id = HDNhapBUS.Them(HDNhap);
            bool isThanhCong = true;
            // Duyệt danh sách chi tiết hóa đơn (DataGridView)
            foreach (DataGridViewRow row in dgvDSCTHDNhap.Rows)
            {
                CTHDNhapHangDTO CTHDNhap = new CTHDNhapHangDTO();
                CTHDNhap.MaHD = id;
                CTHDNhap.MaSach = Convert.ToInt32(row.Cells["colMaSach_CTHD"].Value);
                CTHDNhap.SoLuong = Convert.ToInt32(row.Cells["colSoLuong_CTHD"].Value);
                CTHDNhap.GiaBia = Convert.ToInt32(row.Cells["colGiaBia_CTHD"].Value);
                isThanhCong = CTHDNhapBUS.Them(CTHDNhap);
                if (!isThanhCong)
                {
                    break;
                }
                sBUS.CapNhatSoLuongGiaBia(CTHDNhap.MaSach, CTHDNhap.SoLuong, CTHDNhap.GiaBia, CTHDNhap.GiaNhap);
            }
            if (isThanhCong)
            {
                MessageBox.Show("Lưu hoá đơn thành công!");
                bdsSach.DataSource = sBUS.LayDanhSach();
            }
            else
            {
                MessageBox.Show("Lưu hoá đơn không thành công!");
            }
            dgvDSCTHDNhap.Rows.Clear();
        }

        #endregion

        private void btnHuy_NV_Click(object sender, EventArgs e)
        {

        }
    }
}
