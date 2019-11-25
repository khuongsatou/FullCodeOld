using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> Nhom1 = new List<string>();
        private List<string> Nhom2 = new List<string>();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Ban chac chan muon thoat ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(kq==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            if(!KTNhom())
            {
                MessageBox.Show("chua chon nhom !!!");
            }
            else
            {
                if(cbNhom.SelectedItem=="Nhom 1")
                {
                    int t=0;
                    for (int i = 0; i < Nhom1.Count;i++)
                    {
                        if (Nhom1[i] == txtTenSV.Text)
                            t = 1;
                    }
                    for (int i = 0; i < Nhom2.Count; i++)
                    {
                        if (Nhom2[i] == txtTenSV.Text)
                            t = 1;
                    }
                    if(t==0)
                        Nhom1.Add(txtTenSV.Text);
                    else
                        MessageBox.Show("Da ton tai SV nay");
                }
                else if (cbNhom.SelectedItem == "Nhom 2")
                {
                    int t = 0;
                    for (int i = 0; i < Nhom1.Count; i++)
                    {
                        if (Nhom1[i] == txtTenSV.Text)
                            t = 1;
                    }
                    for (int i = 0; i < Nhom2.Count; i++)
                    {
                        if (Nhom2[i] == txtTenSV.Text)
                            t = 1;
                    }
                    if (t == 0)
                        Nhom2.Add(txtTenSV.Text);
                    else
                        MessageBox.Show("Da ton tai SV nay");
                }
                HienThi();
            }
        }
        private bool KTNhom()
        {
            if (cbNhom.Text == "")
                return false;
            return true;
        }

        private void HienThi()
        {
            lstNhom1.Items.Clear();
            lstNhom2.Items.Clear();
            for(int i=0;i<Nhom1.Count;i++)
            {
                lstNhom1.Items.Add(Nhom1[i]);
            }
            for (int i = 0; i < Nhom2.Count; i++)
            {
                lstNhom2.Items.Add(Nhom2[i]);
            }
            lblTong1.Text = "Tong So:" + Nhom1.Count.ToString();
            lblTong2.Text = "Tong So:" + Nhom2.Count.ToString();
        }

        private void btnChuyenNhom1_Click(object sender, EventArgs e)
        {
            if (lstNhom1.SelectedItem == null)
                MessageBox.Show("chua chon SV can chuyen");
            else
            {
                Nhom2.Add(lstNhom1.SelectedItem.ToString());
                Nhom1.Remove(lstNhom1.SelectedItem.ToString());
            }
            HienThi();
        }

        private void btnChuyenNhom2_Click(object sender, EventArgs e)
        {
            if (lstNhom2.SelectedItem == null)
                MessageBox.Show("chua chon SV can chuyen");
            else
            {
                Nhom1.Add(lstNhom2.SelectedItem.ToString());
                Nhom2.Remove(lstNhom2.SelectedItem.ToString());
            }
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstNhom1.SelectedItem == null && lstNhom2.SelectedItem == null)
                MessageBox.Show("chua chon SV can chuyen");
            else
            {
                if (lstNhom1.SelectedItem != null)
                    Nhom1.Remove(lstNhom1.SelectedItem.ToString());
                if (lstNhom2.SelectedItem != null)
                    Nhom2.Remove(lstNhom2.SelectedItem.ToString());
            }
            HienThi();
        }

        private void btnChuyenHet1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<Nhom1.Count;i++)
            {
                Nhom2.Add(Nhom1[i]); 
            }
            Nhom1.Clear();
            HienThi();
        }

        private void btnChuyenHet2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Nhom2.Count; i++)
            {
                Nhom1.Add(Nhom2[i]);
            }
            Nhom2.Clear();
            HienThi();
        }
       
    }
}
