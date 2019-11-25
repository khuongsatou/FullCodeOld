using BUS;
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
    public partial class frmTacGia : Form
    {
        TacGiaBUS tgBUS = new TacGiaBUS();
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmThemTacGia f = new frmThemTacGia())
            {
                f.ShowDialog();
            }
            bdsTacGia.DataSource = tgBUS.LayDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (frmCapNhatTacGia f = new frmCapNhatTacGia())
            {
                f.matacgia = Convert.ToInt32(dgvTacGia.CurrentRow.Cells["colMaTacGia"].Value);
                f.ShowDialog();
            }
            bdsTacGia.DataSource = tgBUS.LayDanhSach();
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            bdsTacGia.DataSource = tgBUS.LayDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Yes)
            {
                int matacgia = Convert.ToInt32(dgvTacGia.CurrentRow.Cells["colMaTacGia"].Value);
                tgBUS.Xoa(matacgia);
                bdsTacGia.DataSource = tgBUS.LayDanhSach();
            }
        }
    }
}
