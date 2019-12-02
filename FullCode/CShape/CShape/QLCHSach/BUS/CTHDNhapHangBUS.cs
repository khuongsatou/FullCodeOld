using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class CTHDNhapHangBUS
    {
        CTHDNhapHangDAO CTHDNhapDAO = new CTHDNhapHangDAO();
        public DataTable LayDanhSach()
        {
            return CTHDNhapDAO.LayDanhSach();
        }
        public bool Them(CTHDNhapHangDTO CTHDNhapDTO)
        {
            return CTHDNhapDAO.Them(CTHDNhapDTO);
        }
    }
}
