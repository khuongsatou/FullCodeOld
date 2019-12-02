using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BaiTap02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            cboGiaTri.Items.Clear();
            int n = int.Parse(txtNhap.Text);
            int numb;
            Random rd = new Random();
            for (int i = 0; i < n;i++ )
            {
                numb = rd.Next(1, 1000);
                cboGiaTri.Items.Add(numb.ToString());
            }
        }

        private void btnTongUoc_Click(object sender, EventArgs e)
        {
            int soLuong = listBox1.Items.Count;
            int kq=0;
            for (int i = 0; i < soLuong; i++)
            {
                kq += int.Parse(listBox1.Items[i].ToString());
            }
            MessageBox.Show("Kết quả là: " + kq, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cboGiaTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int giaTri = int.Parse(cboGiaTri.SelectedItem.ToString());
            for (int i = 1; i < giaTri; i++)
            {
                if (giaTri % i == 0)
                    listBox1.Items.Add(i.ToString());
            }

        }

        private void btnSLUocChan_Click(object sender, EventArgs e)
        {
            int soLuong = listBox1.Items.Count;
            int kq = 0;
            for (int i = 0; i < soLuong; i++)
            {
                if(int.Parse(listBox1.Items[i].ToString())%2==0)
                kq += 1;
            }
            MessageBox.Show("Kết quả là: " + kq, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
