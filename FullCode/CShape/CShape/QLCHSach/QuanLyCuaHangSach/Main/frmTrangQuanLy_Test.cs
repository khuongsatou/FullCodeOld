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
    public partial class frmTrangQuanLy_Test : Form
    {
        public int manv;
        public string hoten;
        public frmTrangQuanLy_Test()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblNgayGio.Text = dt.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private void moveSidePanel( Control btn)
        {
            sidePanel.Top = btn.Top;
            sidePanel.Height = btn.Height;
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnNhapHang);
            frmNhapHang f = new frmNhapHang();
            f.TopLevel = false;
            AddControlsToPanel(f);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnNhanVien);
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.TopLevel = false;
            AddControlsToPanel(frmNV);
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnTheLoai);
            frmTheLoai frmTL = new frmTheLoai();
            frmTL.TopLevel = false;
            AddControlsToPanel(frmTL);
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnTacGia);
            frmTacGia f = new frmTacGia();
            f.TopLevel = false;
            AddControlsToPanel(f);
        }

        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnNhaXuatBan);
            frmNhaXuatBan frmNXB = new frmNhaXuatBan();
            frmNXB.TopLevel = false;
            AddControlsToPanel(frmNXB);
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSach);
            frmSach f = new frmSach();
            f.TopLevel = false;
            AddControlsToPanel(f);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnKhachHang);
            frmKhachHang f = new frmKhachHang();
            f.TopLevel = false;
            AddControlsToPanel(f);
        }

        private void frmTrangQuanLy_Test_Load(object sender, EventArgs e)
        {
            lblNgayGio.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
           
            btnNhapHang_Click(sender, e);
            lblMaNV.Text = manv.ToString();
            lblHoTen.Text = hoten;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(c);
            c.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnBaoCao);
            frmBaoCao f = new frmBaoCao();
            f.TopLevel = false;
            AddControlsToPanel(f);
        }
    }
}
