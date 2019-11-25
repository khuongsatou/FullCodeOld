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
    public partial class frmSoLonNhatVaNhoNhat : Form
    {
        public frmSoLonNhatVaNhoNhat()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtSoThuNhat.Text != "" && txtSoThuHai.Text != "" && txtSoThuBa.Text !="")
            {
                int soThuNhat = int.Parse(txtSoThuNhat.Text);
                int soThuHai = int.Parse(txtSoThuHai.Text);
                int soThuBa = int.Parse(txtSoThuBa.Text);

                int max = (soThuNhat > soThuHai && soThuNhat > soThuBa) ? soThuNhat : soThuHai > soThuBa ? soThuHai : soThuBa;
                int min = (soThuNhat < soThuHai && soThuNhat < soThuBa) ? soThuNhat : soThuHai < soThuBa ? soThuHai : soThuBa;
                txtSoLonNhat.Text = max.ToString();
                txtSoNhoNhat.Text = min.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu...", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void IsNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoThuNhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsNumber( sender,  e);
        }

        private void txtSoThuHai_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsNumber(sender, e);
        }

        private void txtSoThuBa_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsNumber(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình hay không? ","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true ;
            }
        }
    }
}
