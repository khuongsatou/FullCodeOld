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
    public partial class frmTinhTong3 : Form
    {
        public frmTinhTong3()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (txtSoThucX.Text != "" && txtSoTuNhienN.Text != "")
            {
                double SoThucX = double.Parse(txtSoThucX.Text);
                double SoTuNhienN = double.Parse(txtSoTuNhienN.Text);
                double Tong = 0;
                string S1 = "";
                string S2 = "";
                string S3 = "";
                if (SoTuNhienN == 1)
                {
                    S1 += "X";
                    S2 += SoTuNhienN;
                    S3 += SoTuNhienN;
                    Tong += SoTuNhienN;
                }
                else
                {


                    for (int i = 1; i <= SoTuNhienN; i++)
                    {

                        S1 += " X";
                        S2 += SoThucX;
                        if (i == 1)
                        {
                            S3 += SoThucX;
                        }


                        if ((i != 1))
                        {
                            S1 += "^" + i;
                            S2 += "^" + i;
                            S3 += Math.Pow(SoThucX, i).ToString();

                            if (i != SoTuNhienN)
                            {
                                S1 += " + ";
                                S2 += " + ";
                                S3 += " + ";
                            }
                        }
                        else if (i == 1)
                        {

                            S1 += " + ";
                            S2 += " + ";
                            S3 += " + ";
                        }
                        Tong += Math.Pow(SoThucX, i);
                    }
                }

                txtS1.Text = S1;
                txtS2.Text = S2;
                txtS3.Text = S3;
                txtS4.Text = Tong.ToString();

            }
            else
            {
                MessageBox.Show("Vui Lòng nhập dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void isKTSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtSoThucX_KeyPress(object sender, KeyPressEventArgs e)
        {
            isKTSo(sender, e);
        }

        private void txtSoTuNhienN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmTinhTong3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình hay không?", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
