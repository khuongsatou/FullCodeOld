using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Tuan3_LuyenLv_From
{
    public partial class frmChuongTrinhXuLiChuoi : Form
    {
        public frmChuongTrinhXuLiChuoi()
        {
            InitializeComponent();
        }

        private void btnInHoa_Click(object sender, EventArgs e)
        {
            if (txtChuoi.Text != "")
            {
                string chuoi = txtChuoi.Text;
                lblKetQua.Text = chuoi.ToUpper();
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập dữ liệu");
            }
        }

        private void btnChuThuong_Click(object sender, EventArgs e)
        {
            if (txtChuoi.Text != "")
            {
                string chuoi = txtChuoi.Text;
                lblKetQua.Text = chuoi.ToLower();
            }
        }

        private void btnInHoaKyTuDau_Click(object sender, EventArgs e)
        {
            if (txtChuoi.Text != "")
            {
                string Chuoi = txtChuoi.Text;
                string[] ChuoiDaCat = Chuoi.Split(' ');
                string result = "";
                foreach (string word in ChuoiDaCat)
                {
                    if (word.Trim() != "")
                    {
                        if (word.Length > 1)
                        {
                            result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                        }
                        else
                        {
                            result += word.ToUpper() + " ";
                        }
                    }
                }

                lblKetQua.Text = result.Trim();

            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập dữ liệu");
            }
        }

        private void btnTimViTriWindow_Click(object sender, EventArgs e)
        {
            if (txtChuoi.Text !="")
            {
                string Chuoi= txtChuoi.Text;
                int vitri = Chuoi.IndexOf("Window");
                if (vitri >= 0)
                {
                    lblKetQua.Text = vitri.ToString();
                }else
                    lblKetQua.Text = "Không tìm Thấy".ToString();

            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập dữ liệu");
            }
        }

        private void btnDaoNguoc_Click(object sender, EventArgs e)
        {
            if (txtChuoi.Text != "")
            {
                string chuoi = txtChuoi.Text;
                char[] chuoiArr = chuoi.ToCharArray();
                string chuoiMoi ="";
                for (int i = chuoiArr.Length-1; i >= 0; i--)
                {
                    chuoiMoi += chuoiArr[i].ToString();
                }
                lblKetQua.Text = chuoiMoi.ToString();

            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập dữ liệu");
            }
        }

        private void btnDoDai_Click(object sender, EventArgs e)
        {
            if (txtChuoi.Text != "")
            {
                string chuoi = txtChuoi.Text;
                lblKetQua.Text = chuoi.Length.ToString();
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập dữ liệu");
            }
        }

        private void btnTimVTcuoiCuaH_Click(object sender, EventArgs e)
        {
            if (txtChuoi.Text != "")
            {
                string chuoi = txtChuoi.Text;
                int vitri = chuoi.LastIndexOf("h");
                lblKetQua.Text = vitri.ToString();
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập dữ liệu");
            }
        }

        private void btnTach_Click(object sender, EventArgs e)
        {
            if (txtChuoi.Text != "")
            {
                string chuoi = txtChuoi.Text;
                char[] chuoimoi = new char[chuoi.Length];
                chuoimoi = chuoi.ToCharArray();
                string tuRiengBiet = "";
                for (int i = 0; i < chuoimoi.Length; i++)
                {
                    tuRiengBiet += chuoimoi[i] + " ";
                }

                lblKetQua.Text = tuRiengBiet.ToString();
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập dữ liệu");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtChuoi.ResetText();
            lblKetQua.ResetText();

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình hay không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
