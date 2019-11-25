using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan05BaiTapMang
{
    public partial class Form2 : Form
    {
        private int flag;
        public int Flag
        {
            get { return flag; }
            set { flag = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void btnNhapN_Click(object sender, EventArgs e)
        {
            flag = int.Parse(txtNhapN.Text);
            this.Visible = false;
        }
    }
}
