using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Tuan3_LuyenLv_From
{
    public partial class frmChuongTrinhXuLiMang1Chieu : Form
    {
        public frmChuongTrinhXuLiMang1Chieu()
        {
            InitializeComponent();
        }

        ArrayList arr = new ArrayList();
        private void txtTaoMang_Click(object sender, EventArgs e)
        {
            arr.Clear();
            if (txtN.Text !="")
            {
                int N = int.Parse(txtN.Text);
                Random rd = new Random();
                for (int i = 0; i < N; i++)
                {
                    arr.Add(rd.Next(-100, 100));
                }
                string mangTam = "";
                for (int i = 0; i < N; i++)
                {
                    mangTam += arr[i] + ",";
               
                }
                txtMang1Chieu.Text = mangTam.TrimEnd(',');
            }
        }

       

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtN.Text != "")
            {
                int max = 0;
                foreach (int i in arr)
                {
                    if (max < i)
                    {
                        max = i;
                    }
                }
                lblKetQua.Text = max.ToString();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtN.Text != "")
            {
                int max = 0;
                foreach (int i in arr)
                {
                    if (max > i)
                    {
                        max = i;
                    }
                }
                lblKetQua.Text = max.ToString();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtN.Text != "")
            {
                int tong = 0;
                foreach (int i in arr)
                {
                    tong += i;
                }
                lblKetQua.Text = tong.ToString();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtN.Text != "")
            {
                int tong = 0;
                foreach (int i in arr)
                {
                    tong += i;
                }
                double tbc = (double)tong/arr.Count;
                lblKetQua.Text = tbc.ToString();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtN.Text != "")
            {
                bool check = false;
                foreach (int i in arr)
                {
                    if (i % 2 == 0)
                    {
                        check = true;
                        break;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                   

                }
                if (check)
                {
                    lblKetQua.Text = "Đây Là Mảng số chẳn";
                }
                else
                {
                    lblKetQua.Text = "Đây Không Là Mảng số chẳn";
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtN.Text != "")
            {
                string noiChuoi = "";
                for (int i = 0; i <= arr.Count/2; i++)
                {
                    int temp = (int)arr[i];
                    arr[i] = arr[arr.Count-1-i];
                    arr[arr.Count-1-i] = temp;
                   
                }
                for (int i = 0; i < arr.Count; i++)
                {
                    noiChuoi += arr[i] + ",";
                }
                lblKetQua.Text = noiChuoi;

                
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtN.Text != "")
            {
                int tong = 0;
                int dem = 0;
                for (int i = 0; i < arr.Count; i++)
                {
                    if ((int)arr[i] < 0)
                    {
                        dem++;
                        tong += (int)arr[i];
                    }
                }
                double tbc =(double) tong / dem;
                lblKetQua.Text = tbc.ToString();


            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình hay không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmChuongTrinhXuLiMang1Chieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtN.Text != "")
            {
                if (arr.Count > 1)
                {
                    arr.RemoveAt(1);
                    string noichuoi = "";
                    for (int i = 0; i < arr.Count; i++)
                    {
                        noichuoi += arr[i] + ",";
                    }
                    lblKetQua.Text = noichuoi.Trim(',');
                }
                else
                {
                    MessageBox.Show("Mảng Phải lớn hơn 0 phần tử");
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtN.Text != "")
            {
                string noichuoi = "";
                for (int i = 0; i < arr.Count; )
                {
                    if ((int)arr[i] < 0)
                    {
                        arr.RemoveAt(i);
                        i = 0;
                    }
                    else
                    {
                        i++;
                    }

                }

                for (int i = 0; i < arr.Count; i++)
                {
                    noichuoi += (int)arr[i] + ",";
                }
                lblKetQua.Text = noichuoi.Trim(',');
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (txtN.Text != "")
            {


                ArrayList arr1 = new ArrayList();
                ArrayList arr2 = new ArrayList();
                //int demDuong = 0;
                //int demAm = 0;
                for (int i = 0; i < arr.Count; i++)
                {
                    if ((int)arr[i] < 0)
                    {
                        arr1.Add(arr[i]);
                        //demDuong++;
                    }
                    else
                    {
                        arr2.Add(arr[i]);
                        //demAm++;
                    }
                }
                string noichuoi1 = "";
                for (int i = 0; i < arr1.Count; i++)
                {
                    noichuoi1 += arr1[i] + ",";
                }
                string noichuoi2 = "";
                for (int i = 0; i < arr2.Count; i++)
                {
                    noichuoi2 += arr2[i] + ",";
                }
                lblKetQua.Text = "Dương" + noichuoi1.Trim(',') + "__ Âm" + noichuoi2.Trim(',');
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (txtN.Text != "")
            {
                int dem = 0;
                for (int i = 0; i < arr.Count; i++)
                {
                    if ((int) arr[i] == -9)
                    {
                        dem++;
                    }
                }
                lblKetQua.Text ="Sô lần xuất hiện -9 trong mảng:" +dem.ToString();
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (txtN.Text != "")
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if ((int) arr[i] < 0)
                    {
                        lblKetQua.Text = arr[i].ToString();
                        break;
                    }
                }
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (txtN.Text != "")
            {
                for (int i = arr.Count-1; i > 0; i--)
                {
                    if ((int)arr[i] % 2 == 0)
                    {
                        lblKetQua.Text = arr[i].ToString();
                        break;
                    }
                }
            }
        }

        private bool isSoNguyenTo(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return  false;
                }
            }
            return true;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            if (txtN.Text != "")
            {
                string noiChuoi = "";
                for (int i = 0; i < arr.Count; i++)
                {
                    if ((int)arr[i] > 0 && (int)arr[i] != 1) 
                    {
                        if (isSoNguyenTo((int)arr[i]))
                        {
                            noiChuoi += arr[i];
                            break;
                        }
                    }
                   
                }
                lblKetQua.Text = "So Nguyen To:" + noiChuoi.ToString();
            }
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            if (txtN.Text != "")
            {
                arr.Sort();
                string noiChuoi = "";
                for (int i = 0; i < arr.Count; i++)
                {
                    noiChuoi += arr[i]+",";
                }
                lblKetQua.Text = "Mảng Đã Sắp Xếp:" + noiChuoi.Trim(',').ToString();
            }
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            if (txtN.Text != "")
            {
                arr.Reverse();
                string noiChuoi = "";
                for (int i = 0; i < arr.Count; i++)
                {
                    noiChuoi += arr[i] + ",";
                }
                lblKetQua.Text = "Mảng Đã Sắp Xếp:" + noiChuoi.Trim(',').ToString();
            }
        }
    }
}
