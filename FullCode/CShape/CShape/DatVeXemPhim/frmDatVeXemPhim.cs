using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan5_lv5_WinForm
{
    public partial class frmDatVeXemPhim : Form
    {
        public frmDatVeXemPhim()
        {
            InitializeComponent();
        }
        private void ChonPhim()
        {
            cbChonPhim.Items.Add("Hai Phượng");
            cbChonPhim.SelectedItem = "Hai Phượng";
            cbChonPhim.Items.Add("Alita");
            cbChonPhim.Items.Add("Chị Mười Ba");
            
        }

        private void ChonRap()
        {
            

            if (cbChonPhim.SelectedIndex == 0)
            {

                cbChonRap.Items.Add("Rạp 1");
                cbChonRap.SelectedItem = "Rạp 1";
                cbChonRap.Items.Add("Rạp 2");
            }
            else if (cbChonPhim.SelectedIndex == 1)
            {
                cbChonRap.Items.Add("Rạp 3");
                cbChonRap.SelectedItem = "Rạp 3";
                cbChonRap.Items.Add("Rạp 4");
            }
            else
            {
                cbChonRap.Items.Add("Rạp 5");
                cbChonRap.SelectedItem = "Rạp 5";
            }
        }

        private void HienThiDay()
        {
            LamSach();
            for (char i = 'A'; i <= 'J'; i++)
            {
                Label lbl = new Label();
                lbl.Name = "lbl" + i;
                lbl.Text = i.ToString();
                lbl.Size = new System.Drawing.Size(60, 27);
                flpDay.Controls.Add(lbl);

            }
        }

        
        private void LamSach()
        {
            flpDay.Controls.Clear();
            flpGhe.Controls.Clear();
        }
        //string ketquaCheck = "";
        private void SoGheCuaPhim(int SoluongGhe)
        {
            LamSach();
            HienThiDay();
           
            int for10 = 0;
            char forLbl = 'A';
            for (int i = 1; i <= SoluongGhe; i++)
            {
                CheckBox cb = new CheckBox();
                cb.Name = "cb" + i;
                if (for10 % 11 == 0)
                {
                    for10 = 1;
                   
                }
                //ketquaCheck =forLbl.ToString();
                cb.Text = for10.ToString();
                if (for10 %10 ==0)
                {
                    forLbl++;
                }
                cb.Enabled = false;
                cb.Size = new System.Drawing.Size(60, 20);
                flpGhe.Controls.Add(cb);
                cb.CheckedChanged += CheckedChanged_Click;
                for10++;
            }
            foreach (CheckBox cb in flpGhe.Controls)
            {
                cb.Enabled = true;
            }
        }

        
        private void CheckedChanged_Click(object sender, EventArgs e)
        {
            
            if (nudSoLuongVe.Value > 0)
            {
                int soluongve = int.Parse(nudSoLuongVe.Value.ToString());
                int dem = 0;
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
                        if (dem == soluongve)
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
            else
            {
                MessageBox.Show("Vui Lòng Nhập dữ liệu");
            }
        }

        private void btnInVe_Click(object sender, EventArgs e)
        {
            if (txtKhachHang.Text != "" && nudSoLuongVe.Value > 0)
            {
                string tenPhim = cbChonPhim.SelectedItem.ToString();
                DateTime ngay = dtpNgay.Value;
                string KhachHang = txtKhachHang.Text;
                //string ChoNgoi = capnhapCheck;
                string Rap = cbChonRap.SelectedItem.ToString();
                string ChoNgoi = "";
                int dem = 0;
                char lblDay = 'A';
                foreach (CheckBox cb in flpGhe.Controls)
                {
                    if (cb.Checked)
                    {
                        ChoNgoi += cb.Text +lblDay + ",".ToString();
                        dem++;
                    }
                    if (int.Parse(cb.Text) % 10 == 0)
                    {
                        lblDay++;
                    }
                }
                if (dem == nudSoLuongVe.Value)
                {
                    MessageBox.Show("Phim: " + tenPhim + "\nNgày:" + ngay.ToString("dd/MM/yyyy") + "\nKhách Hàng:" + KhachHang + "\nChỗ Ngồi:" + ChoNgoi.Trim(',') + "\n" + Rap, "Vé Xem Phim:", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Vui Lòng Nhập dữ liệu...", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập dữ liệu...","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void frmDatVeXemPhim_Load(object sender, EventArgs e)
        {
            ChonPhim();
           
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Muốn thoát chương trình hay không?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void LamSachRap()
        {
            cbChonRap.Items.Clear(); 
        }

        private void cbChonPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChonPhim.SelectedIndex == 0)
            {
                
                LamSachRap();
                ChonRap();
                //SoGheCuaPhim(100);
            }
            if (cbChonPhim.SelectedIndex == 1)
            {
               
                LamSachRap();
                ChonRap();
            }
            if (cbChonPhim.SelectedIndex == 2)
            {
                
                LamSachRap();
                ChonRap();
            }
          
        }

        private void cbChonRap_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cbChonPhim.SelectedIndex == 0 && cbChonRap.SelectedIndex == 0)
            {
                 SoGheCuaPhim(100);
            }
            else if (cbChonPhim.SelectedIndex == 0 && cbChonRap.SelectedIndex == 1)
            {
                SoGheCuaPhim(80);
            }
           
            if (cbChonPhim.SelectedIndex == 1 && cbChonRap.SelectedIndex == 0)
            {
                SoGheCuaPhim(70);
            }
            else if (cbChonPhim.SelectedIndex == 1 && cbChonRap.SelectedIndex == 1)
            {
                SoGheCuaPhim(90);
            }

            if (cbChonPhim.SelectedIndex == 2 && cbChonRap.SelectedIndex == 0)
            {
                SoGheCuaPhim(100);
            }
           
        }

        private void btnVeMoi_Click(object sender, EventArgs e)
        {
            txtKhachHang.Clear();
            nudSoLuongVe.Value = 0;
            cbChonPhim.SelectedIndex = 0;
            cbChonRap.SelectedIndex = 0;

            foreach (CheckBox cb in flpGhe.Controls)
            {
                cb.Checked = false;
            }
        }

        private void nudSoLuongVe_ValueChanged(object sender, EventArgs e)
        {
            foreach (CheckBox cb in flpGhe.Controls)
            {
                cb.Enabled = true;
            }
        }

    
        

      
    }
}
