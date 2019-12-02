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
    public partial class frmTinhTong : Form
    {
        public frmTinhTong()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (txtSoTuNhien.Text != "")
            {
                int SoTuNhien = int.Parse(txtSoTuNhien.Text);
                int S = 0;
                for (int i = 1; i <= SoTuNhien; i++)
                {
                    S += i;
                }
                txtS.Enabled = true;
                txtS.ForeColor = Color.Red;
                //txtS.Enabled = false;
                txtS.Text = S.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
        }

        private void txtSoTuNhien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmTinhTong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát Chương trình hay không","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


    }
}
