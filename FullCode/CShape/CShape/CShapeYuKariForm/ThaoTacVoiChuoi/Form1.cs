using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChuongTringXuLiChuoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //khu vực tạo tên
        string[] ho = { "Nguyễn", "Trần", "Đinh", "Gia", "Ngo", "Lê", "Hà", "Lâm", "Vương" };
        string[] tenlot = { "Thị", "Hoàng", "Huy", "Cao", "Văn", "Duy", "Thanh", "Anh" };
        string[] ten = { "Lan", "Hương", "Tuấn", "Hùng", "Cường", "Vy", "Loan", "Nam", "Tú" ,"Nga","Phát","Kiệt","Triều","Hạ","Đạt","Khương"};
        List<string> dsHoten = new List<string>();
       

        private void btnTenNgauNhien_Click(object sender, EventArgs e)
        {
            Random random = new Random();//(b-a+1)+a
            Form2 f2 = new Form2();
            f2.ShowDialog();
            int soluong = f2.N;
            if (f2.Flag)
            {
                string NoiChuoi = "";
                for (int i = 0; i < soluong; i++)
                {
                    do
                    {
                        int vtHo = random.Next(0, ho.Length);
                        int vtTenLot = random.Next(0, tenlot.Length);
                        int vtTen = random.Next(0, ten.Length);
                        NoiChuoi = ho[vtHo] + " " + tenlot[vtTenLot] + " " + ten[vtTen];
                      
                    } while (KiemTraTrungTen(NoiChuoi,dsHoten));
                    dsHoten.Add(NoiChuoi); 
                }
                HienThiDanhSachHoten(dsHoten, lstDanhSach);
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Đúng");
            }
            
        }

        private void HienThiDanhSachHoten(List<string> ds,ListBox lb)
        {
            lb.Items.Clear();
            for (int i = 0; i < ds.Count; i++)
            {
                lb.Items.Add(ds[i]);
            }
        }

        private bool KiemTraTrungTen(string chuoihoten, List<string> ds)
        {
            bool ketqua = false;
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].Equals(chuoihoten))
                {
                    ketqua = true;
                    return ketqua;
                }
            }
            return ketqua;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaSVTheoTen_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            string ten = f3.Ten;
            for (int i = 0; i < dsHoten.Count; i++)
            {
                string[] kq = dsHoten[i].Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);//nhiều chỉ tính là 1
                if (kq[2].Equals(ten))
                {
                    dsHoten.Remove(dsHoten[i]);
                }
            }
            HienThiDanhSachHoten(dsHoten, lstDanhSach);

        }

        private void btnXoaSVTheoHo_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            string ten = f3.Ten;
            for (int i = 0; i < dsHoten.Count; i++)
            {
                string[] kq = dsHoten[i].Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);//nhiều chỉ tính là 1
                if (kq[1].Equals(ten))
                {
                    dsHoten.Remove(dsHoten[i]);
                }
            }
            HienThiDanhSachHoten(dsHoten, lstDanhSach);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
