using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class HDNhapHangBUS
    {
        HDNhapHangDAO HDNhapDAO = new HDNhapHangDAO();
        public DataTable LayDanhSach()
        {
            return HDNhapDAO.LayDanhSach();
        }
        public int Them(HDNhapHangDTO HDNhapDTO)
        { 
            return HDNhapDAO.Them(HDNhapDTO);
        }
    }
}
