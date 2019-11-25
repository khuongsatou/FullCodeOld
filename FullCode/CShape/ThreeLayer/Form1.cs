using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
namespace ThreeLayer_2_4_2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BAL_DM_SINHVIEN sv = new BAL_DM_SINHVIEN();
            dataGridView1.DataSource = sv.LayDSSinhVien();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            frm2 frmLop = new frm2();
            frmLop.ShowDialog();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
