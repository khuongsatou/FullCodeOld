using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
    public class HDBanHangBUS
    {
        HDBanHangDAO hdDAO = new HDBanHangDAO();
        public DataTable LayDanhSach()
        {
            return hdDAO.LayDanhSach();
        }
        public int Them(HDBanHangDTO hdDTO)
        {
            return hdDAO.Them(hdDTO);
        }
        public bool CapNhatTongTien(int mahd, int tongtien)
        {
            return hdDAO.CapNhatTongTien(mahd, tongtien);
        }
        public DataTable LayDSHDTheoNgay(DateTime ngaybd, DateTime ngaykt)
        {
            return hdDAO.LayDSHDTheoNgay(ngaybd, ngaykt);
        }
    }
}
