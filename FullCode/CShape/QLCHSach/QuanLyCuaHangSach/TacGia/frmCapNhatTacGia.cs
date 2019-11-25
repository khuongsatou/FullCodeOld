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
    public partial class frmCapNhatTacGia : Form
    {
        public int matacgia;
        public frmCapNhatTacGia()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                TacGiaDTO tgDTO = new TacGiaDTO();
                tgDTO.MaTacGia = matacgia;
                tgDTO.HoTen = txtHoTen.Text.Trim();
                tgDTO.NgaySinh = dtpNgaySinh.Value;
                tgDTO.GioiTinh = radNam.Checked ? true : false;
                tgDTO.GhiChu = txtGhiChu.Text.Trim();
                TacGiaBUS tgBUS = new TacGiaBUS();
                if (tgBUS.Sua(tgDTO))
                {
                    MessageBox.Show("Thành công!");
                }
                else
                    MessageBox.Show("Không thành công!");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCapNhatTacGia_Load(object sender, EventArgs e)
        {
            TacGiaBUS tgBUS = new TacGiaBUS();
            TacGiaDTO tgDTO = tgBUS.LayTacGiaTheoMa(matacgia);
            txtMaTacGia.Text = tgDTO.MaTacGia.ToString();
            txtHoTen.Text = tgDTO.HoTen;
            dtpNgaySinh.Value = tgDTO.NgaySinh;
            if (tgDTO.GioiTinh)
                radNam.Checked = true;
            else
                radNu.Checked = true;
            txtGhiChu.Text = tgDTO.GhiChu;
        }
    }
}
