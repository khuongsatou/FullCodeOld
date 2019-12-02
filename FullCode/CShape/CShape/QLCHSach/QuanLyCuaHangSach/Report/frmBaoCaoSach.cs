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
    public partial class frmBaoCaoSach : Form
    {
        public frmBaoCaoSach()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSach_Load(object sender, EventArgs e)
        {
            NhaXuatBanBUS nxbBUS = new NhaXuatBanBUS();
            bdsNXB.DataSource = nxbBUS.LayDanhSach();
            TheLoaiBUS tlBUS = new TheLoaiBUS();
            bdsTheLoai.DataSource = tlBUS.LayDanhSach();

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
            SachBUS sBUS = new SachBUS();
            DataTable dt = new DataTable();

            if (radTatCa.Checked)
            {
                frmReport f = new frmReport();
                f.TopLevel = false;
                AddControlsToPanel(f);
                dt = sBUS.LayDanhSach();
                f.rpvReport.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangSach.rptDSSach.rdlc";
                f.rpvReport.LocalReport.DataSources.Add(new ReportDataSource("dsSach", dt));
                f.rpvReport.RefreshReport();
            }
            if (radTheoTheLoai.Checked)
            {
                frmReport f = new frmReport();
                f.TopLevel = false;
                AddControlsToPanel(f);
                dt = sBUS.LayDSSachTheoTheLoai((int)cboTheLoai.SelectedValue);
                f.rpvReport.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangSach.rptDSSachTheoTheLoai.rdlc";
                f.rpvReport.LocalReport.DataSources.Add(new ReportDataSource("dsSach", dt));
                f.rpvReport.LocalReport.SetParameters(new ReportParameter("paTheLoai", cboTheLoai.Text, false));
                f.rpvReport.RefreshReport();
            }
            if (radTheoNXB.Checked)
            {
                frmReport f = new frmReport();
                f.TopLevel = false;
                AddControlsToPanel(f);
                dt = sBUS.LayDSSachTheoNXB((int)cboNXB.SelectedValue);
                f.rpvReport.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangSach.rptDSSachTheoNXB.rdlc";
                f.rpvReport.LocalReport.DataSources.Add(new ReportDataSource("dsSach", dt));
                f.rpvReport.LocalReport.SetParameters(new ReportParameter("paNXB", cboNXB.Text, false));
                f.rpvReport.RefreshReport();
            }
            if (radNhomTheLoai.Checked)
            {
                frmReport f = new frmReport();
                f.TopLevel = false;
                AddControlsToPanel(f);
                TheLoaiBUS tlBUS = new TheLoaiBUS();
                DataTable dtTL = tlBUS.LayDanhSach();
                f.rpvReport.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangSach.rptDSSachTheLoaiGroup.rdlc";
                f.rpvReport.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
                f.rpvReport.LocalReport.DataSources.Add(new ReportDataSource("dsSach", dtTL));
                f.rpvReport.RefreshReport();
            }
            if (radNhomNXB.Checked)
            {
                frmReport f = new frmReport();
                f.TopLevel = false;
                AddControlsToPanel(f);
                NhaXuatBanBUS nxbBUS = new NhaXuatBanBUS();
                DataTable dtNXB = nxbBUS.LayDanhSach();
                f.rpvReport.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangSach.rptDSSachNXBGroup.rdlc";
                f.rpvReport.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
                f.rpvReport.LocalReport.DataSources.Add(new ReportDataSource("dsSach", dtNXB));
                f.rpvReport.RefreshReport();
            }
        }

        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            string pa="";
            SachBUS sBUS = new SachBUS();
            DataTable dt = new DataTable();
            if (radNhomTheLoai.Checked)
            {
                pa = "paMaTheLoai";
                int ma = int.Parse(e.Parameters[pa].Values[0]);
                dt = sBUS.LayDSSachTheoTheLoai(ma);
            }
            if (radNhomNXB.Checked)
            {
                pa = "paMaNXB";
                int ma = int.Parse(e.Parameters[pa].Values[0]);
                dt = sBUS.LayDSSachTheoNXB(ma);
            }
            e.DataSources.Add(new ReportDataSource("dsSach", dt));
        }

        private void rpvReport_Load(object sender, EventArgs e)
        {
            //this.rpvReport.RefreshReport();
        }
        
    }
}
