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
    public partial class frmThanhToan : Form
    {
        public int mahd;
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            //CTHDBanHangBUS ct = new CTHDBanHangBUS();
            //DataTable dt = ct.LayDanhSachTheoMaHD(mahd);
            //this.rpvHoaDon.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangSach.rptHDBanHang.rdlc";
            //this.rpvHoaDon.LocalReport.DataSources.Add(new ReportDataSource("InHDBanHang", dt));
            this.rpvHoaDon.RefreshReport();
        }
    }
}
