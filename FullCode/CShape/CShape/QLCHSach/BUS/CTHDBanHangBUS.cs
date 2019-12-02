using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class CTHDBanHangBUS
    {
        CTHDBanHangDAO cthdDAO = new CTHDBanHangDAO();
        public DataTable LayDanhSach()
        {
            return cthdDAO.LayDanhSach();
        }
        public DataTable LayDanhSachTheoMaHD(int mahd)
        {
            return cthdDAO.LayDanhSachTheoMaHD(mahd);
        }
        public bool Them(CTHDBanHangDTO cthd)
        {
            return cthdDAO.Them(cthd);
        }
    }
}
