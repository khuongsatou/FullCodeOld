using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using Microsoft.Reporting.WinForms;

namespace QuanLyCuaHangSach
{
    public partial class frmBaoCaoTonKho : Form
    {
        public frmBaoCaoTonKho()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            SachBUS sBUS = new SachBUS();
            DataTable dt = sBUS.LayDSSachTonKho((int)nudSoLuong.Value);
            frmReport f = new frmReport();
            f.TopLevel = false;
            AddControlsToPanel(f);
            f.rpvReport.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangSach.rptDSSachTonKho.rdlc";
            f.rpvReport.LocalReport.DataSources.Add(new ReportDataSource("dsSach", dt));
            f.rpvReport.RefreshReport();
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlReport.Controls.Clear();
            pnlReport.Controls.Add(c);
            c.Show();
        }
    }
}
