using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTringXuLiChuoi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int _n;
        private bool _flag = false;
       

       
        public bool Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
        
        
        public int N
        {
            get { return _n; }
            set { _n = value; }
        }
        

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text !="")
            {
                _flag = true;
                this.Visible = false;
                _n = int.Parse(txtNhap.Text);
            }
            else
            {
                _flag = false;
                this.Visible = false;
            }
           
           

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _flag = false;
            this.Close();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
