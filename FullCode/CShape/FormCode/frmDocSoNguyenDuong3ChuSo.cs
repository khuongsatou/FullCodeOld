using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan3_LuyenLv_From
{
    public partial class frmDocSoNguyenDuong3ChuSo : Form
    {
        public frmDocSoNguyenDuong3ChuSo()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            if (txtSoNguyenDuong.Text != "")
            {

                int SoNguyenDuong = int.Parse(txtSoNguyenDuong.Text);
                if (txtSoNguyenDuong.Text.Length == 3)
                {
                    int tram = SoNguyenDuong / 100;
                    int chuc = SoNguyenDuong % 100 / 10;
                    int donvi = SoNguyenDuong % 100 % 10;
                    string tramDoc = DocSoNguyenDuongTram(tram);
                    string ChucDoc = DocSoNguyenDuongChuc(chuc);
                    string DonViDoc = DocSoNguyenDuongDonVi(donvi);

                    txtKetQua.Text = tramDoc + " " + ChucDoc + " " + DonViDoc;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số nguyên dương có 3 chữ số");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu ...");
            }
        }

        private string DocSoNguyenDuongTram(int SoNguyenDuong)
        {
            switch (SoNguyenDuong)
            {
                case 1: return "Một Trăm";

                case 2:
                    return "Hai Trăm";
                case 3:
                    return "Ba Trăm";
                case 4:
                    return "Bốn Trăm";
                case 5:
                    return "Năm Trăm";
                case 6:
                    return "Sáu Trăm";
                case 7:
                    return "Bảy Trăm";
                case 8:
                    return "Tám Trăm";
               
            }
             return "Chín Trăm";
        }

        private string DocSoNguyenDuongChuc(int SoNguyenDuong)
        {
            switch (SoNguyenDuong)
            {
                case 1: return "Mười";
                   
                case 2:
                    return "Hai Mươi";
                case 3:
                    return "Ba Mươi";
                case 4:
                    return "Bốn Mươi";
                case 5:
                    return "Năm Mươi";
                case 6:
                    return "Sáu Mươi";
                case 7:
                    return "Bảy Mươi";
                case 8:
                    return "Tám Mươi";
                case 9:
                    return "Chín Mươi";
            }
            return "Lẽ";
            
        }

        private string DocSoNguyenDuongDonVi(int SoNguyenDuong)
        {
            switch (SoNguyenDuong)
            {
                case 1: return "Một";

                case 2:
                    return "Hai";
                case 3:
                    return "Ba";
                case 4:
                    return "Bốn";
                case 5:
                    return "Năm";
                case 6:
                    return "Sáu";
                case 7:
                    return "Bảy";
                case 8:
                    return "Tám";
                case 9:
                    return "Chín";
            }
            return "";
        }

        private void txtSoNguyenDuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmDocSoNguyenDuong3ChuSo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình hay không","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
