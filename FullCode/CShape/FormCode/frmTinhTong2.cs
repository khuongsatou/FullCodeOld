using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan3_LuyenLv_From
{
    public partial class frmTinhTong2 : Form
    {
        public frmTinhTong2()
        {
            InitializeComponent();
        }

        private void frmTinhTong2_Load(object sender, EventArgs e)
        {

        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (txtSoTuNhien.Text != "")
            {
                int SoTuNhien = int.Parse(txtSoTuNhien.Text);
                int Tong = 0;
                string Stinh = "";
                for (int i = 1; i <= SoTuNhien; i++)
                {
                    Tong += i;
                    Stinh += i;
                    if (i != SoTuNhien)
                    {
                        Stinh += " + ";
                    }
                   
                }
                txtSTinh.Text = Stinh.ToString();
                txtS.Text = Tong.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
        }

        private void frmTinhTong2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình hay không?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void txtSoTuNhien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
