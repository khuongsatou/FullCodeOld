using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim_PhatSinhDong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 15; i++)
            {
                CheckBox ckb = new CheckBox();
                ckb.Name = "ckb" + i;
                ckb.Text = i.ToString();
                flpGhe.Controls.Add(ckb);
                ckb.CheckedChanged += Checked_Changed;
                
            }
        }

        private void Checked_Changed(object sender, EventArgs e)
        {
            lstGheDangChon.Items.Clear();
            foreach (CheckBox ckb in flpGhe.Controls)
            {
                if (ckb.Checked)
                {

                    lstGheDangChon.Items.Add(ckb.Text);
                    ckb.Enabled = false;
                }
            }

            //foreach (string item in lstGheDangChon.SelectedItems)
            //{
            //    foreach (Control ctl in flpGhe.Controls)
            //    {
            //        if (((CheckBox) ctl).Text.Equals(item))
            //        {
            //            ((CheckBox)ctl).Checked = false;
            //            ctl.Enabled = true;
            //        }
            //    }
            //}
        }

       

        private void lstGheChon_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
           
            if (lstGheDangChon.SelectedItem != null)
            {
                
                if (lstGheDangChon.Items.IndexOf(lstGheDangChon.SelectedItem) < 0)
                {
                    MessageBox.Show("Lua Chọn Đi");
                }
                else
                {

                    lstGheDaChon.Items.Add(lstGheDangChon.SelectedItem);
                    lstGheDangChon.Items.Remove(lstGheDangChon.SelectedItem);
                   
                }
            }
            else
            {
                MessageBox.Show("Lua Chọn Đi");
            }
            txtTongTien.Text = CapNhatTongTien().ToString();
        }

        private void btnXoaGheDaChon_Click(object sender, EventArgs e)
        {
            if (lstGheDaChon.SelectedItem != null)
            {
                if (lstGheDaChon.Items.IndexOf(lstGheDaChon.SelectedItem) < 0)
                {
                    MessageBox.Show("Lua Chọn Đi");
                }
                else
                {
                    foreach (CheckBox ckb in flpGhe.Controls)
                    {
                        if (ckb.Text.Equals(lstGheDaChon.SelectedItem.ToString()))
                        {
                            ckb.Enabled = true;
                            ckb.Checked = false;
                        }
                    }
                    lstGheDaChon.Items.Remove(lstGheDaChon.SelectedItem);
                    lstGheDangChon.Items.Remove(lstGheDaChon.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Lua Chọn Đi");
            }
            txtTongTien.Text = CapNhatTongTien().ToString();
        }

        private void btnXemMoi_Click(object sender, EventArgs e)
        {
            foreach (CheckBox ckb in flpGhe.Controls)
            {
                ckb.Checked = false;
                ckb.Enabled = true;
            }

            lstGheDaChon.Items.Clear();
            lstGheDangChon.Items.Clear();

            txtTongTien.Text = "0";
        }

        private int CapNhatTongTien()
        {
            //int tong = 0;
            //int dem = 1;
            //for (int i = 0; i <= lstGheDaChon.Items.Count; i++)
            //{

            //    tong += dem + 120000;
            //    dem++;
            //}
            return 120000*lstGheDaChon.Items.Count;
        }

        private void lstGheDaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }
    }
}
