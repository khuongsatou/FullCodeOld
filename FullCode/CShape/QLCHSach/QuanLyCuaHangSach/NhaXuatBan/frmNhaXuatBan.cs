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
    public partial class frmNhaXuatBan : Form
    {
        NhaXuatBanBUS nxbBUS = new NhaXuatBanBUS();
        public frmNhaXuatBan()
        {
            InitializeComponent();  
        }

        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            bdsNhaXuatBan.DataSource = nxbBUS.LayDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmThemNXB themNXB = new frmThemNXB())
            {
                themNXB.ShowDialog();
            }
            bdsNhaXuatBan.DataSource = nxbBUS.LayDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (frmCapNhatNXB capNhatNXB = new frmCapNhatNXB())
            {
                capNhatNXB.manxb = Convert.ToInt32(dgvDSNhaXuatBan.CurrentRow.Cells["maNXBDataGridViewTextBoxColumn"].Value);
                capNhatNXB.ShowDialog();
            }
            bdsNhaXuatBan.DataSource = nxbBUS.LayDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa NXB này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Yes)
            {
                int manxb = Convert.ToInt32(dgvDSNhaXuatBan.CurrentRow.Cells["maNXBDataGridViewTextBoxColumn"].Value);
                nxbBUS.Xoa(manxb);
                bdsNhaXuatBan.DataSource = nxbBUS.LayDanhSach();
            }
        }
    }
}
