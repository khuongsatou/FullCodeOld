using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessLogicLayer;
using ValueObject;
using DataAccessLayer;

namespace QuanLiBanHang
{
    public partial class frmLoaiHang : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiHang()
        {
            InitializeComponent();
        }

        LoaiHang obj = new LoaiHang();
        LoaiHangBUS bus = new LoaiHangBUS();
        private bool isInsert = false;
        void KhoaDieuKhien()
        {
            txtMaLoaiHang.Enabled = false;
            txtTenLoaiHang.Enabled = false;
            txtMoTa.Enabled = false;

            btnThemMoi.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        void XoaText()
        {
            txtMaLoaiHang.Text = string.Empty;
            txtTenLoaiHang.Text = string.Empty;
            txtMoTa.Text = string.Empty;
        }

        void MoKhoaDieuKhien()
        {
            txtMaLoaiHang.Enabled = true;
            txtTenLoaiHang.Enabled = true;
            txtMoTa.Enabled = true;

            btnThemMoi.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        void HienThi()
        {
            msds.DataSource = bus.GetData();
        }

        private void frmLoaiHang_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            MoKhoaDieuKhien();
            isInsert = true;
            XoaText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoKhoaDieuKhien();
            txtMaLoaiHang.Enabled = false;
            isInsert = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa thông tin này không?","Thông Báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bus.Delete(txtMaLoaiHang.Text);
                    XtraMessageBox.Show("Đã Xóa Thông Tin Thành Công");
                    XoaText();
                    KhoaDieuKhien();
                    HienThi();
                }
                catch
                {
                   
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            obj.IDLoaiHang = txtMaLoaiHang.Text;
            obj.TenLoai = txtTenLoaiHang.Text;
            obj.MoTa = txtMoTa.Text;
            if (isInsert)
            {
                //insert
                bus.Insert(obj);
                XtraMessageBox.Show("Thêm Thông tin Thành công");
                HienThi();
                XoaText();
                KhoaDieuKhien();
            }
            else
            {
                //update
                bus.Update(obj);
                XtraMessageBox.Show("Sửa Thông tin Thành công");
                HienThi();
                XoaText();
                KhoaDieuKhien();

            }
        }

        private void msds_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaLoaiHang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
                txtTenLoaiHang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
                txtMoTa.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();

            }
            catch 
            {

            }
        }


    }

   

}