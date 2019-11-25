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
    public partial class frmSecurityCode : Form
    {
        public frmSecurityCode()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InControl();
        }

        private void InControl()
        {
            for (int i = 1; i <= 9; i++)
            {
                Button btn = new Button();
                btn.Name = "btn" + i;
                btn.Size = new System.Drawing.Size(45, 30); 
                btn.Text = i.ToString();
                flpControl.Controls.Add(btn);
                btn.Click += button_Click;
            }
        }
        //string noichuoi = "";
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //noichuoi += btn.Text;
            txtSecurity.Text += btn.Text.ToString();
        }

        string ChuoiFomatDateTime = "";
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (txtSecurity.Text != "")
            {
                //DateTime dt = new DateTime(2015,12,11,13,30,55);
                DateTime hientai = DateTime.Now;
                ChuoiFomatDateTime = hientai.ToString("MM/dd/yyyy hh:mm tt");
                int SecurityCode = int.Parse(txtSecurity.Text);
                IsHopLe(SecurityCode);
            }
        }
        private void IsHopLe(int SecurityCode)
        {
            if (!(SecurityCode >= 0 && SecurityCode <=9))
            {
                if (SecurityCode == 6990 || SecurityCode == 6999)
                {
                    rtbAccessLog.Text += ChuoiFomatDateTime + " Granted" + "\n";
                    rtbAccessLog.Text +=ChuoiFomatDateTime + " Techinicians"+"\n";
                    
                }
                else if (SecurityCode == 9998 || SecurityCode >= 1006 && SecurityCode <= 1008)
                {
                    rtbAccessLog.Text += ChuoiFomatDateTime + " Granted" + "\n";
                    rtbAccessLog.Text += ChuoiFomatDateTime + " Scientist" + "\n";
                   
                }
                else if (SecurityCode == 0100)
                {
                    rtbAccessLog.Text += ChuoiFomatDateTime + " Granted" + "\n";
                    rtbAccessLog.Text += ChuoiFomatDateTime + " Custodians" + "\n";
                   
                }
                else
                {
                    rtbAccessLog.Text += ChuoiFomatDateTime + " Access denied" + "\n";
                }
            }
            else
            {
                rtbAccessLog.Text += ChuoiFomatDateTime + " Restricted Access!" + "\n";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (txtSecurity.Text != "")
            {
                string chuoiChinh = txtSecurity.Text;
                char[] chuoiCat = chuoiChinh.ToCharArray();
                string noiChuoi = "";
                for (int i = 0; i < chuoiCat.Length - 1; i++)
                {
                    noiChuoi += chuoiCat[i];
                }
                txtSecurity.Text = noiChuoi.ToString();
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            
            txtSecurity.Text += btn0.Text.ToString();
        } 
    }
}
