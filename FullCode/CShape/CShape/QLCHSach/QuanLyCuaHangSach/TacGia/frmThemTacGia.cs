using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
namespace QuanLyCuaHangSach
{
    public partial class frmThemTacGia : Form
    {
        public frmThemTacGia()
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
                TacGiaBUS tgBUS = new TacGiaBUS();
                tgDTO.HoTen = txtHoTen.Text.Trim();
                tgDTO.NgaySinh = dtpNgaySinh.Value;
                tgDTO.GioiTinh = radNam.Checked ? true : false;
                tgDTO.GhiChu = txtGhiChu.Text.Trim();
                if (tgBUS.Them(tgDTO))
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
    }
}
