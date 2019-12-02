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
    public partial class frmThemSach : Form
    {
        TacGiaBUS tgBUS = new TacGiaBUS();
        TheLoaiBUS tlBUS = new TheLoaiBUS();
        NhaXuatBanBUS nxbBUS = new NhaXuatBanBUS();
        SachBUS sBUS = new SachBUS();

        public frmThemSach()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmThemSach_Load(object sender, EventArgs e)
        {
            bdsTacGia.DataSource = tgBUS.LayDanhSach();
            bdsTheLoai.DataSource = tlBUS.LayDanhSach();
            bdsNhaXuatBan.DataSource = nxbBUS.LayDanhSach();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SachDTO sDTO = new SachDTO();
                sDTO.Ten = txtTen.Text.Trim();
                sDTO.MaTacGia = Convert.ToInt32(cboTacGia.SelectedValue);
                sDTO.MaTheLoai = Convert.ToInt32(cboTheLoai.SelectedValue);
                sDTO.MaNXB = Convert.ToInt32(cboNhaXuatBan.SelectedValue);
                sDTO.NgayXuatBan = dtpNgayXuatBan.Value;
                sDTO.GhiChu = txtGhiChu.Text.Trim();
                if (sBUS.Them(sDTO))
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            using (frmThemTacGia f = new frmThemTacGia())
            {
                f.ShowDialog();
            }
            bdsTacGia.DataSource = tgBUS.LayDanhSach();
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            using (frmThemTheLoai f = new frmThemTheLoai())
            {
                f.ShowDialog();
            }
            bdsTheLoai.DataSource = tlBUS.LayDanhSach();
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            using (frmThemNXB f = new frmThemNXB())
            {
                f.ShowDialog();
            }
            bdsNhaXuatBan.DataSource = nxbBUS.LayDanhSach();
        }
    }
}
