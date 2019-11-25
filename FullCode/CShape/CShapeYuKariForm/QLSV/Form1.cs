using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BAL;
using BEL;
namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMaSV.Enabled = true;
            LoadDataGridView();
            BAL_LOP bal_lop = new BAL_LOP();
            cbLop.DataSource = bal_lop.getLop();
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
        }

        private void LoadDataGridView()
        {
            BAL_SINHVIEN bal_sv = new BAL_SINHVIEN();
            dgvHienThi.DataSource = bal_sv.getSinhVien();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text =="")
            {
                MessageBox.Show("Rỗng","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtHoten.Text == "")
            {
                MessageBox.Show("Rỗng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Rỗng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BAL_SINHVIEN bal_sv = new BAL_SINHVIEN();
            int masv =int.Parse(txtMaSV.Text);
            string hoten = txtHoten.Text;
            string diachi = txtDiaChi.Text;
            DateTime ngaysinh = dtpNgaySinh.Value;
            int malop =int.Parse(cbLop.SelectedValue.ToString());
            //txtHoten.Text = malop.ToString();
            bool result = bal_sv.Them(new SINHVIEN(masv,hoten,diachi,ngaysinh,malop));
            if (result)
            {
                LoadDataGridView();
                MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }
            MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void btnCapNhatItem_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Rỗng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtHoten.Text == "")
            {
                MessageBox.Show("Rỗng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Rỗng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BAL_SINHVIEN bal_sv = new BAL_SINHVIEN();
            int masv = int.Parse(txtMaSV.Text);
            string hoten = txtHoten.Text;
            string diachi = txtDiaChi.Text;
            DateTime ngaysinh = dtpNgaySinh.Value;
            int malop = int.Parse(cbLop.SelectedValue.ToString());
            //txtHoten.Text = malop.ToString();
            bool result = bal_sv.CapNhat(new SINHVIEN(masv, hoten, diachi, ngaysinh, malop),masv);
            if (result)
            {
                LoadDataGridView();
                MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int masv = int.Parse(dgvHienThi.CurrentRow.Cells[0].Value.ToString());
            BAL_SINHVIEN bal_sv = new BAL_SINHVIEN();
            DataTable dt = bal_sv.getSinhVien_MaSV(masv);
            DataRow dr = dt.Rows[0];
            txtMaSV.Text = dr["MaSV"].ToString();
            txtHoten.Text = dr["HoTen"].ToString();
            txtDiaChi.Text = dr["DiaChi"].ToString();
            dtpNgaySinh.Value = DateTime.Parse(dr["NgaySinh"].ToString());
            //txtHoten.Text = dr["MaLop"].ToString();
            cbLop.SelectedIndex = int.Parse(dr["MaLop"].ToString())-1;

          //  txtMaSV.Enabled = false;

        }

        private void dgvHienThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaItem_Click(object sender, EventArgs e)
        {
            int masv = int.Parse(dgvHienThi.CurrentRow.Cells[0].Value.ToString());
            BAL_SINHVIEN bal_sv = new BAL_SINHVIEN();
            bool result = bal_sv.Xoa(masv);
            if (result)
            {
                LoadDataGridView();
                MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }
    }
}
