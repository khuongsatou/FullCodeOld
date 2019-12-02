using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan4_lv4_winfrom
{
    public partial class DatVeXemPhim : Form
    {
        public DatVeXemPhim()
        {
            InitializeComponent();
        }

       
        private void DatVeXemPhim_Load(object sender, EventArgs e)
        {
            radHaiPhuong.Checked = true;
            radRap1.Checked = true;

            InSoChoNgoi(100);


        }

    
        private void btnInVe_Click(object sender, EventArgs e)
        {
            if (txtHoTenKhachHang.Text != "" && txtSoLuongVe.Text != "")
            {
                string HoTen = txtHoTenKhachHang.Text;
                int SoLuong = int.Parse(txtSoLuongVe.Text);
                string Phim = "";
                string Rap = "";
                if (radRap1.Checked || radRap2.Checked)
                {
                    Rap = radRap1.Checked ? radRap1.Text : radRap2.Text;
                }
                else if (radRap3.Checked || radRap4.Checked)
                {
                    Rap = radRap3.Checked ? radRap3.Text : radRap4.Text;
                }
                else
                {
                    Rap = radRap5.Text;
                }

                if (radHaiPhuong.Checked)
                {
                    Phim = radHaiPhuong.Text;
                    
                }
                else if(radAlita.Checked)
                {
                    Phim = radAlita.Text;
                }
                else 
                {
                    Phim = radChi13.Text;
                }

                string Ghe = "";
                int dem = 0;
                char kytu = 'A';
                foreach (CheckBox ck in flpGhe.Controls)
                {
                    int ck_T = int.Parse(ck.Text);
                    if (ck_T % 10 == 0)
                    {
                        kytu++;
                    }
                    if (ck.Checked)
                    {
                        
                        Ghe += ck.Text+kytu+",";
                        dem++; 
                    }
                   
                }
                if (dem != SoLuong)
                {
                    MessageBox.Show("Vui Lòng chọn đủ chỗ ngồi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Phim: "+ Phim +"\n" +"Khách Hàng :"+HoTen+"\n"+"Chỗ Ngồi : "+Ghe.TrimEnd(',')+"\n"+""+Rap+"\n"+"Chúc bạn xem vui vẻ", "Vé Xem Phim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng nhập dữ liệu", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình hay không?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.OK)
            {
                this.Close();    
            }
            
        }

        private void radHaiPhuong_CheckedChanged(object sender, EventArgs e)
        {
            if (radHaiPhuong.Checked)
            {
                radRap1.Checked = true;
                radRap1.Enabled = true;
                radRap2.Enabled = true;
                radRap3.Enabled = false;
                radRap4.Enabled = false;
                radRap5.Enabled = false;
                
            }
        }

        private void radAlita_CheckedChanged(object sender, EventArgs e)
        {
            if (radAlita.Checked)
            {

                radRap3.Checked = true;
                radRap1.Enabled = false;
                radRap2.Enabled = false;
                radRap3.Enabled = true;
                radRap4.Enabled = true;
                radRap5.Enabled = false;
            }
        }

        private void radChi13_CheckedChanged(object sender, EventArgs e)
        {
            if (radChi13.Checked)
            {
                radRap5.Checked = true;
                radRap1.Enabled = false;
                radRap2.Enabled = false;
                radRap3.Enabled = false;
                radRap4.Enabled = false;
                radRap5.Enabled = true;
            }
        }

        private void InSoChoNgoi(int soChoNgoi){
            Xoaflp();
            int loop = 0;
            char kytu = 'A';
            for (int i = 1; i <= soChoNgoi; i++)
            {
                CheckBox ck = new CheckBox();
                ck.Name = "cb" + i;

                if (loop % 11 == 0)
                {
                    loop = 1;
                    Label lbl = new Label();
                    lbl.Name = "lbl" + kytu;
                    lbl.Font = new Font(lbl.Font, FontStyle.Bold);
                    lbl.Text = kytu.ToString();
                    lbl.Size = new System.Drawing.Size(30, 27);
                    flpDay.Controls.Add(lbl);
                }
                ck.Text = loop.ToString();
                if (i % 10 == 0)
                {
                    kytu++;
                }

                ck.Size = new System.Drawing.Size(70, 20);
                flpGhe.Controls.Add(ck);
                loop++;
                ck.CheckedChanged += Checked_box_textChanged;
                //ck.Click += Check_box_Click;
            }
        }

        private void Checked_box_textChanged(object sender, EventArgs e)
        {
            if (txtSoLuongVe.Text != "")
            {
                int dem = 0;
                int soLuongVe = int.Parse(txtSoLuongVe.Text);

                foreach (CheckBox cb in flpGhe.Controls)
                {
                    if (cb.Checked)
                    {
                        dem++;
                    }
                   
                }

                foreach (CheckBox cb in flpGhe.Controls)
                {
                    if (!cb.Checked)
                    {
                        if (dem == soLuongVe)
                        {
                            cb.Enabled = false;
                        }
                        else
                        {         
                            cb.Enabled = true;
                        }
                    }
                   
                    
                }
            }
            
        }

        private void radRap1_CheckedChanged(object sender, EventArgs e)
        {
            InSoChoNgoi(100);
        }

        private void Xoaflp()
        {
            flpDay.Controls.Clear();
            flpGhe.Controls.Clear();
        }

        private void radRap2_CheckedChanged(object sender, EventArgs e)
        {
            InSoChoNgoi(80);
        }

        private void radRap3_CheckedChanged(object sender, EventArgs e)
        {
            InSoChoNgoi(90);
           
        }

        private void radRap4_CheckedChanged(object sender, EventArgs e)
        {
            InSoChoNgoi(70);
        }

        private void radRap5_CheckedChanged(object sender, EventArgs e)
        {
            InSoChoNgoi(100);
        }

        private void btnVeMoi_Click(object sender, EventArgs e)
        {
            InSoChoNgoi(100);
            radHaiPhuong.Checked = true;
            radRap1.Checked = true;
            txtHoTenKhachHang.Clear();
            txtSoLuongVe.Clear();
        }

        private void txtHoTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtSoLuongVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      

       
    }
}
