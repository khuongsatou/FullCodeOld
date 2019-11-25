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
    public partial class frmCapNhatSach : Form
    {
        SachBUS sBUS = new SachBUS();
        TacGiaBUS tgBUS = new TacGiaBUS();
        TheLoaiBUS tlBUS = new TheLoaiBUS();
        NhaXuatBanBUS nxbBUS = new NhaXuatBanBUS();
        public int masach;
        public frmCapNhatSach()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmCapNhatSach_Load(object sender, EventArgs e)
        {
            bdsTacGia.DataSource = tgBUS.LayDanhSach();
            bdsTheLoai.DataSource = tlBUS.LayDanhSach();
            bdsNhaXuatBan.DataSource = nxbBUS.LayDanhSach();
            SachDTO sDTO = sBUS.LaySachTheoMa(masach);
            txtMaSach.Text = masach.ToString();
            txtTen.Text = sDTO.Ten;
            cboTacGia.SelectedValue = sDTO.MaTacGia;
            cboTheLoai.SelectedValue = sDTO.MaTheLoai;
            cboNhaXuatBan.SelectedValue = sDTO.MaNXB;
            dtpNgayXuatBan.Value = sDTO.NgayXuatBan;
            txtGhiChu.Text = sDTO.GhiChu;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SachDTO sDTO = new SachDTO();
                sDTO.MaSach = masach;
                sDTO.Ten = txtTen.Text.Trim();
                sDTO.MaTacGia = Convert.ToInt32(cboTacGia.SelectedValue);
                sDTO.MaTheLoai = Convert.ToInt32(cboTheLoai.SelectedValue);
                sDTO.MaNXB = Convert.ToInt32(cboNhaXuatBan.SelectedValue);
                sDTO.NgayXuatBan = dtpNgayXuatBan.Value;
                sDTO.GhiChu = txtGhiChu.Text.Trim();
                if (sBUS.Sua(sDTO))
                {
                    MessageBox.Show("Thành công!");
                }
                else
                {
                    MessageBox.Show("Không thành công!");
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
