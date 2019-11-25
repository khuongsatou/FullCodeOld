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

namespace Tuan6_lv6_Winform_QLBH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            CapNhatTrangThaiBanDau();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập tên Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            SqlConnection conn = ConnectDB();
            string CauTruyVan = "SELECT * FROM NHANVIEN WHERE TENDANGNHAP = '"+txtTenDangNhap.Text.Trim()+"' ";
            SqlCommand cmd = new SqlCommand(CauTruyVan,conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                btnThemMoi.Enabled = false;
                btnTim.Enabled = false;
                txtTenDangNhap.Enabled = false;

                btnCapNhap.Enabled = true;
                btnHuy.Enabled = true;
                btnXoa.Enabled = true;

                dr.Read();
                if (!dr.IsDBNull(1))
                {
                    txtMatKhau.Text = dr.GetString(1).Trim();
                }
                if (!dr.IsDBNull(2))
                {
                    txtHoTen .Text = dr.GetString(2).Trim();
                }
                if (!dr.IsDBNull(3))
                {
                    txtEmail.Text = dr.GetString(3).Trim();
                }
                if (!dr.IsDBNull(4))
                {
                    txtDiaChi.Text = dr.GetString(4).Trim();
                }
                if (!dr.IsDBNull(5))
                {
                    txtDienThoai.Text = dr.GetString(5).Trim();
                }
                if (!dr.IsDBNull(6))
                {
                    dtpNgaySinh.Value = dr.GetDateTime(6);
                }

                if (!dr.IsDBNull(7))
                {
                    radNam.Checked = dr.GetBoolean(7);
                    radNu.Checked = !radNam.Checked;
                }

            }
            else
            {
                MessageBox.Show("Tên Đăng Nhập Không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Text = "";
                txtTenDangNhap.Focus();
                return;
            }
            //đóng kết nối
            dr.Close();
            conn.Close();

        }

        private SqlConnection ConnectDB()
        {
            string ChuoiKetNoi =@"Data Source=.\sqlexpress;Initial Catalog=QuanLyBanHangDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            conn.Open();
            return conn;
        }

        private bool KiemTraTenDangNhap(string tendangnhap)
        {
            SqlConnection conn = ConnectDB();
            string CauTruyVan = string.Format("SELECT * FROM NHANVIEN WHERE TENDANGNHAP = '{0}'",tendangnhap);

            SqlCommand cmd = new SqlCommand(CauTruyVan,conn);
            SqlDataReader rd = cmd.ExecuteReader();
            bool result = rd.HasRows;
            return result;
            
        }

        private void CapNhatTrangThaiBanDau()
        {
            txtTenDangNhap.Enabled = true;
            btnTim.Enabled = true;
            btnThemMoi.Enabled = true;
            btnHuy.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhap.Enabled = false;
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập tên Đăng Nhập","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập tên Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Họ Tên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập tên Email", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập tên Địa Chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (txtDienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập tên Điện Thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return;
            }

            if (dtpNgaySinh.Value == null)
            {
                 MessageBox.Show("Chưa Nhập Ngày Sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }

            if (KiemTraTenDangNhap(txtTenDangNhap.Text.Trim()))
            {
                MessageBox.Show("Tên Đăng Nhập Đã Tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }
            else
            {
                try
                {
                    SqlConnection conn = ConnectDB();
                    string ChuoiInsert = string.Format("INSERT INTO  NHANVIEN  ( TENDANGNHAP  , MATKHAU  , HOTEN  , EMAIL  , DIACHI  , DIENTHOAI  , NGAYSINH  , GIOITINH ) VALUES ('{0}','{1}',N'{2}','{3}',N'{4}','{5}','{6}',{7})",txtTenDangNhap.Text,txtMatKhau.Text,txtHoTen.Text,txtEmail.Text,txtDiaChi.Text,txtDienThoai.Text,dtpNgaySinh.Value.ToString("yyyy/MM/dd"),radNam.Checked ? 1 : 0);
                    SqlCommand cmd = new SqlCommand(ChuoiInsert,conn);
                    int numOfRow = cmd.ExecuteNonQuery();
                    if (numOfRow > 0)
                    {
                        MessageBox.Show("Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Thất Bại");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                   
                }
                CapNhatTrangThaiBanDau();
                
            }


            
            

        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập tên Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập tên Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Họ Tên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập tên Email", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập tên Địa Chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (txtDienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập tên Điện Thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return;
            }

            if (dtpNgaySinh.Value == null)
            {
                MessageBox.Show("Chưa Nhập Ngày Sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }

            
                try
                {
                    SqlConnection conn = ConnectDB();
                    string ChuoiUpdate = string.Format("UPDATE  NHANVIEN  SET  MATKHAU  = '{0}' , HOTEN  = N'{1}' , EMAIL  = '{2}' , DIACHI  = N'{3}' , DIENTHOAI  = '{4}' , NGAYSINH  = '{5}' , GIOITINH  = '{6}' WHERE TENDANGNHAP = '{7}'",txtMatKhau.Text.Trim(),txtHoTen.Text.Trim(),txtEmail.Text.Trim(),txtDiaChi.Text.Trim(),txtDienThoai.Text.Trim(),dtpNgaySinh.Value.ToString("yyyy/MM/dd"),radNam.Checked ? 1 : 0,txtTenDangNhap.Text.Trim());
                    SqlCommand cmd = new SqlCommand(ChuoiUpdate, conn);
                    int numOfRow = cmd.ExecuteNonQuery();
                    if (numOfRow > 0)
                    {
                        MessageBox.Show("UPDATE Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("UPDATE Thất Bại");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);

                }
                

            }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = ConnectDB();
                string ChuoiUpdate = string.Format("DELETE FROM NHANVIEN WHERE TENDANGNHAP = '{0}'",txtTenDangNhap.Text.Trim());
                SqlCommand cmd = new SqlCommand(ChuoiUpdate, conn);
                int numOfRow = cmd.ExecuteNonQuery();
                if (numOfRow > 0)
                {
                    MessageBox.Show("DELETE Thành Công");
                }
                else
                {
                    MessageBox.Show("DELETE Thất Bại");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
            CapNhatTrangThaiBanDau();
        }
        

       


    }
}
