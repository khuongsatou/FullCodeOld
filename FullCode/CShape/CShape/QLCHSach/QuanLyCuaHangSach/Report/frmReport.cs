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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

            
        }
        //public void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        //{
        //    int matheloai = int.Parse(e.Parameters["paMaTheLoai"].Values[0]);
        //    SachBUS sBUS = new SachBUS();
        //    DataTable dt = sBUS.LayDSSachTheoTheLoai(matheloai);
        //    e.DataSources.Add(new ReportDataSource("dsSach", dt));
        //}
    }
}
