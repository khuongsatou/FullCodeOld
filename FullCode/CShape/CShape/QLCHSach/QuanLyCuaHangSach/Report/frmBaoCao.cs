using BUS;
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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            //this.rpvReport.RefreshReport();
            btnSach_Click(sender, e);
        }

        private void moveSidePanel(Control btn)
        {
            sidePanel.Top = btn.Top;
            sidePanel.Height = btn.Height;
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSach);
            //SachBUS sBUS = new SachBUS();
            //DataTable dt = sBUS.LayDanhSach();
            //this.rpvReport.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangSach.rptDSSach.rdlc";
            //this.rpvReport.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsSach", dt));
            //this.rpvReport.RefreshReport();
            frmBaoCaoSach f = new frmBaoCaoSach();
            f.TopLevel = false;
            AddControlsToPanel(f);

        }
      
        public void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlMainReport.Controls.Clear();
            pnlMainReport.Controls.Add(c);
            c.Show();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnDoanhThu);
            frmBaoCaoDoanhThu f = new frmBaoCaoDoanhThu();
            f.TopLevel = false;
            AddControlsToPanel(f);
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnTonKho);
            frmBaoCaoTonKho f = new frmBaoCaoTonKho();
            f.TopLevel = false;
            AddControlsToPanel(f);
        }
    }
}
