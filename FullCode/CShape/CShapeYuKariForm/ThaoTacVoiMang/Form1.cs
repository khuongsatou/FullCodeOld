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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] array;
        //Hàm set Enabled
        private void setEnabled(bool x)
        {
            btnClear.Enabled = x;
            btnDaoNguoc.Enabled = x;
            btnDemChan.Enabled =x;
            btnDemLe.Enabled = x;
            btnDemNgTo.Enabled = x;
            btnMax.Enabled = x;
            btnMin.Enabled =x;
            btnSoNgTo.Enabled = x;
            btnTimKiem.Enabled = x;
            btnTongChan.Enabled = x;
            btnTongLe.Enabled = x;
            btnTongMang.Enabled =x;
            btnXoa.Enabled = x;
        }
        private int TinhTong(int[] arr)
        {
            int tong = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                tong += arr[i];
            }
            return tong;
        }
        private bool KiemTraChan(int x)
        {
            if (x % 2 == 0)
                return true;
            return false;
        }
        private int TongChan(int[] arr)
        {
            int tong = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (KiemTraChan(arr[i]) == true)
                    tong += arr[i];
            }
            return tong;
        }
        private int DemChan(int[] arr)
        {
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (KiemTraChan(arr[i]) == true)
                    dem++;
            }
            return dem;
        }
        private bool KiemTraNgTo(int n)
        {
            for (int i = 2; i <= Math.Sqrt((float)n); i++)
            {
                if (n < 2)
                    return false;
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        private int DemNgTo(int[] arr)
        {
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 2 && KiemTraNgTo(arr[i]) == true)
                    dem++;
            }
            return dem;
        }

        private string InNgTo(int[] arr)
        {
            string arrNgTo = null;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 2 && KiemTraNgTo(arr[i]) == true)
                    arrNgTo += (arr[i] + " ");
            }
            return arrNgTo;
        }
        private string InMang(int[] arr)
        {
            string xuatMang = null;
            for (int i = 0; i < arr.Length; i++)
            {
                xuatMang += arr[i] + " ";
            }
            return xuatMang;
        }
        // Controller
        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int n =0;
            int SL = 10;
            array = new int[SL];

            while(n<SL)
           {
               array[n] = rd.Next(1, 100);
               n++;
            }
            rtbMangGoc.Text = InMang(array);
            setEnabled(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            array = null;
            rtbKetQua.Clear();
            rtbMangGoc.Clear();

            setEnabled(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            array = null;
            DialogResult kq = MessageBox.Show("Bạn muốn thoát chứ ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                this.Close();
        }
        
        private void btnTongMang_Click(object sender, EventArgs e)
        {
            rtbKetQua.Text = TinhTong(array).ToString();
        }

       
        private void btnTongChan_Click(object sender, EventArgs e)
        {
            rtbKetQua.Text = TongChan(array).ToString();
        }

        private void btnTongLe_Click(object sender, EventArgs e)
        {
            rtbKetQua.Text = (TinhTong(array)-TongChan(array)).ToString();
        }

      
        private void btnDemChan_Click(object sender, EventArgs e)
        {
            rtbKetQua.Text = DemChan(array).ToString();
        }

        private void btnDemLe_Click(object sender, EventArgs e)
        {
            rtbKetQua.Text = (array.Length-DemChan(array)).ToString();     
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            Array.Sort(array);
            rtbKetQua.Text = array[array.Length - 1].ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            Array.Sort(array);
            rtbKetQua.Text = array[0].ToString();
        }
       
        private void btnSoNgTo_Click(object sender, EventArgs e)
        {
            rtbKetQua.Text = InNgTo(array);
        }

        private void btnDemNgTo_Click(object sender, EventArgs e)
        {
            rtbKetQua.Text = DemNgTo(array).ToString();
        }

        
        private void btnDaoNguoc_Click(object sender, EventArgs e)
        {
            Array.Reverse(array);
            rtbKetQua.Text = InMang(array);
        }

       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (array.Length > 0)
            {
                int[] tam = new int[array.Length - 1];
                for (int i = 0; i < tam.Length; i++)
                {
                    tam[i] = array[i];
                }
                array = null;
                rtbKetQua.Clear();
                rtbMangGoc.Clear();
                rtbMangGoc.Text = InMang(tam);
                array = new int[tam.Length];
                for (int i = 0; i < tam.Length; i++)
                {
                    array[i] = tam[i];
                }
            }
            else
            {
                MessageBox.Show("Mảng không còn phần tử !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setEnabled(false);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            for (int i=0;i<array.Length;i++)
            {
                if (array[i] == frm2.Flag)
                {
                    rtbKetQua.Text = array[i] + " nằm tại vị trí thứ " + (i + 1);
                    break;
                }
                else
                    rtbKetQua.Text = array[i] + " không nằm trong mảng";
      
            }
        }
    }
}
