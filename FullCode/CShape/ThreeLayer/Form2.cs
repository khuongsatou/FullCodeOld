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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }
       
        
        private void Form2_Load(object sender, EventArgs e)
        {
            BAL_DM_LOP lop = new BAL_DM_LOP();
            dataGridView1.DataSource = lop.LayDanhSachLop();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
