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

namespace BaiTapCauTrucLap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Các Hàm
            //Hàm tính tổng n
        private int TinhN(int n)
        {
            return (n * (n + 1)) / 2;
        }
            //Hàm tính N*(N+1)
        private int Cau2(int n)
        {
            int kq = 0;
            for (int i = 1; i < n + 1; i++)
            {
                kq += (i * (i + 1));
            }
            return kq;
        }
            //Kiểm tra nguyên tố
        private bool KTNgTo(int n)
        {
            for(int i=2;i<=Math.Sqrt(n);i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
            //in số nguyên tố vao mảng
        private ArrayList MangNgTo(int n)
        {
            ArrayList arr= new ArrayList();
            for (int i=2;i<n+1;i++)
            {
                if (KTNgTo(i) == true)
                     arr.Add(i);
            }
            return arr; 
        }
        private string LietKeNgTo(int soN)
        {
            ArrayList arr=MangNgTo(soN);
            string ketqua = null;
            for(int i=0;i<arr.Count;i++)
            {
                ketqua = ketqua + " " + arr[i];
            }
            return ketqua;
        }
        //Thực hiện phép tính
        private void btnNut1_Click(object sender, EventArgs e)
        {
            int soN = int.Parse(txtNhap.Text);
            rtbKetQua.Text = TinhN(soN).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn thoát chứ !","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                this.Close();
        }

        private void btnNut2_Click(object sender, EventArgs e)
        {
            int soN = int.Parse(txtNhap.Text);
            rtbKetQua.Text = Cau2(soN).ToString();
        }

        private void btnNut3_Click(object sender, EventArgs e)
        {
            int soN = int.Parse(txtNhap.Text);
            rtbKetQua.Text = ((float)Cau2(soN)/TinhN(soN)).ToString();
        }

        private void btnNut4_Click(object sender, EventArgs e)
        {
            int soN = int.Parse(txtNhap.Text);
            rtbKetQua.Text = ( ((float)Cau2(soN)* Cau2(soN)) / TinhN(soN) ).ToString();
        }

        private void btnKTNgTo_Click(object sender, EventArgs e)
        {
            int soN = int.Parse(txtNhap.Text);
            if(KTNgTo(soN)==false)
                 rtbKetQua.Text =soN.ToString()+" không phải là số nguyên tố ";
            else
                rtbKetQua.Text = soN.ToString() + " là số nguyên tố ";
        }

        private void btnInNgTo_Click(object sender, EventArgs e)
        {
            int soN = int.Parse(txtNhap.Text);
            rtbKetQua.Text = LietKeNgTo(soN);
            
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {

        }
        //Tinh fibonacci
    
        private string LietKeFibonacci(int soN)
        {
            int n1 = 0, n2 = 1, n3;
            string ketqua = "0  1  ";
            for(int i=2;i<soN;i++){
                n3 = n1 + n2;
                ketqua = ketqua + "  " + n3.ToString();
                n1 = n2;
                n2 = n3;
            }
            return ketqua;
        }
        private void btnFibonacci_Click_1(object sender, EventArgs e)
        {
            int soN = int.Parse(txtNhap.Text);
            rtbKetQua.Text = LietKeFibonacci(soN);
        }
    }
}
