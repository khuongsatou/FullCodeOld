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
    public partial class CheckBox4Chieu : Form
    {
        public CheckBox4Chieu()
        {
            InitializeComponent();
        }

        private void cbA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbA.Checked && cbB.Checked)
            {
                cbC.Enabled = false;
                cbD.Enabled = false;
            }
            else if (cbA.Checked && cbC.Checked)
            {
                cbB.Enabled = false;
                cbD.Enabled = false;
            }
            else if (cbA.Checked && cbD.Checked)
            {
                cbB.Enabled = false;
                cbC.Enabled = false;
            }

            if (!cbA.Checked && !cbB.Checked)
            {
                cbC.Enabled = true;
                cbD.Enabled = true;
            }
            else if (!cbA.Checked && !cbC.Checked)
            {
                cbB.Enabled = true;
                cbD.Enabled = true;
            }
            else if (!cbA.Checked && !cbD.Checked)
            {
                cbB.Enabled = true;
                cbC.Enabled = true;
            }

            if (!cbA.Checked)
            {
                cbB.Enabled = true;
                cbC.Enabled = true;
                cbD.Enabled = true;
            }
            else if (!cbA.Checked)
            {
                cbB.Enabled = true;
                cbD.Enabled = true;
            }
            else if (!cbA.Checked)
            {
                cbB.Enabled = true;
                cbC.Enabled = true;
            }
        }

        private void cbC_CheckedChanged(object sender, EventArgs e)
        {

            if (cbC.Checked && cbA.Checked)
            {
                cbB.Enabled = false;
                cbD.Enabled = false;
            }
            else if (cbC.Checked && cbB.Checked)
            {
                cbD.Enabled = false;
                cbA.Enabled = false;
            }
            else if (cbC.Checked && cbD.Checked)
            {
                cbA.Enabled = false;
                cbB.Enabled = false;
            }

            if (!cbC.Checked && !cbA.Checked)
            {
                cbB.Enabled = true;
                cbD.Enabled = true;
            }
            else if (!cbC.Checked && !cbB.Checked)
            {
                cbA.Enabled = true;
                cbD.Enabled = true;
            }
            else if (!cbA.Checked && !cbD.Checked)
            {
                cbB.Enabled = true;
                cbC.Enabled = true;
            }

            if (!cbC.Checked)
            {
                cbA.Enabled = true;
                cbD.Enabled = true;
            }
            else if (!cbC.Checked)
            {
                cbA.Enabled = true;
                cbB.Enabled = true;
            }
            else if (!cbC.Checked)
            {
                cbA.Enabled = true;
                cbD.Enabled = true;
            }
        }

        private void cbB_CheckedChanged(object sender, EventArgs e)
        {
            if (cbB.Checked && cbA.Checked)
            {
                cbC.Enabled = false;
                cbD.Enabled = false;
            }
            else if (cbB.Checked && cbC.Checked)
            {
                cbA.Enabled = false;
                cbD.Enabled = false;
            }
            else if (cbB.Checked && cbD.Checked)
            {
                cbA.Enabled = false;
                cbC.Enabled = false;
            }

            if (!cbB.Checked && !cbA.Checked)
            {
                cbC.Enabled = true;
                cbD.Enabled = true;
            }
            else if (!cbB.Checked && !cbC.Checked)
            {
                cbA.Enabled = true;
                cbD.Enabled = true;
            }
            else if (!cbB.Checked && !cbD.Checked)
            {
                cbC.Enabled = true;
                cbA.Enabled = true;
            }

            if (!cbB.Checked)
            {
                cbC.Enabled = true;
                cbA.Enabled = true;
            }
            else if (!cbB.Checked)
            {
                cbA.Enabled = true;
                cbC.Enabled = true;
            }
            else if (!cbB.Checked)
            {
                cbD.Enabled = true;
                cbA.Enabled = true;
            }
        }

        private void cbD_CheckedChanged(object sender, EventArgs e)
        {
            if (cbD.Checked && cbA.Checked)
            {
                cbB.Enabled = false;
                cbC.Enabled = false;
            }
            else if (cbD.Checked && cbB.Checked)
            {
                cbC.Enabled = false;
                cbA.Enabled = false;
            }
            else if (cbD.Checked && cbC.Checked)
            {
                cbA.Enabled = false;
                cbB.Enabled = false;
            }

            if (!cbD.Checked && !cbA.Checked)
            {
                cbB.Enabled = true;
                cbC.Enabled = true;
            }
            else if (!cbD.Checked && !cbB.Checked)
            {
                cbA.Enabled = true;
                cbC.Enabled = true;
            }
            else if (!cbD.Checked && !cbA.Checked)
            {
                cbB.Enabled = true;
                cbC.Enabled = true;
            }

            if (!cbD.Checked)
            {
                cbA.Enabled = true;
                cbB.Enabled = true;
            }
            else if (!cbD.Checked)
            {
                cbB.Enabled = true;
                cbC.Enabled = true;
            }
            else if (!cbD.Checked)
            {
                cbC.Enabled = true;
                cbA.Enabled = true;
            }
        }

       
    }
}
