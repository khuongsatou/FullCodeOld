using BUS;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCuaHangSach
{
    public partial class frmBaoCaoDoanhThu : Form
    {
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayBD.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày không hợp lệ!");
                dtpNgayBD.Value = DateTime.Now;
            }
        }

        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayKT.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày không hợp lệ!");
                dtpNgayKT.Value = DateTime.Now;
            }
            if (dtpNgayKT.Value < dtpNgayBD.Value)
            {
                MessageBox.Show("Không thể nhỏ hơn ngày bắt đầu!");
                dtpNgayKT.Value = DateTime.Now;
            }
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlReport.Controls.Clear();
            pnlReport.Controls.Add(c);
            c.Show();
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            HDBanHangBUS hd = new HDBanHangBUS();
            DataTable dt = hd.LayDSHDTheoNgay(dtpNgayBD.Value, dtpNgayKT.Value);
            frmReport f = new frmReport();
            f.TopLevel = false;
            AddControlsToPanel(f);
            f.rpvReport.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangSach.rptDoanhThu.rdlc";
            f.rpvReport.LocalReport.DataSources.Add(new ReportDataSource("dsDoanhThu", dt));
            f.rpvReport.RefreshReport();
        }
    }
}
