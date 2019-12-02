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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private string _ten;
        private bool _flag = false;



        public bool Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }


        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text != "")
            {
                _flag = true;
                this.Visible = false;
                _ten = txtNhap.Text;
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
    }
}
