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

namespace TimNgay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void msFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lblNoiDung.Font = fontDialog1.Font;
            }
        }

        private void msColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lblNoiDung.ForeColor = colorDialog1.Color;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

      


        private void TextBox1_Click(object sender, EventArgs e)
        {
            //string fileName = null;
            //if (openFileDialog2.ShowDialog() == DialogResult.OK)
            //{
            //    fileName = openFileDialog2.FileName;
            //}
            //openFile.Text = File.ReadAllText(fileName);


            OpenFileDialog dialogOpen = new OpenFileDialog();
            dialogOpen.Filter ="txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialogOpen.InitialDirectory = @"C:\";
            dialogOpen.Title = "Mở file text";
            if (dialogOpen.ShowDialog() == DialogResult.OK)
            {
                rtxtContent.Text = File.ReadAllText(dialogOpen.FileName);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

      



    }
}
