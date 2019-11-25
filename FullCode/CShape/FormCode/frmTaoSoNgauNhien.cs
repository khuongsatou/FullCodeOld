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
    public partial class frmTaoSoNgauNhien : Form
    {
        public frmTaoSoNgauNhien()
        {
            InitializeComponent();
        }

        private void btnTaoSoNgauNhien_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            txtNhap.Text = rd.Next(1, 100).ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
