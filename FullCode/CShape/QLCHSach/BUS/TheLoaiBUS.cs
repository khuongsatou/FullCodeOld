using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class TheLoaiBUS
    {
        TheLoaiDAO tlDAO = new TheLoaiDAO();
        public DataTable LayDanhSach()
        {
            return tlDAO.LayDanhSach();
        }
        public bool Them(TheLoaiDTO tlDTO)
        {
            if (tlDTO.Ten == "")
            {
                throw new Exception("Chưa nhập tên thể loại!");
            }
            return tlDAO.Them(tlDTO);
        }
        public bool Sua(TheLoaiDTO tlDTO)
        {
            if (tlDTO.Ten == "")
            {
                throw new Exception("Chưa nhập tên thể loại!");
            }
            return tlDAO.Sua(tlDTO);
        }
        public bool Xoa(int id)
        {
            return tlDAO.Xoa(id);
        }
        public TheLoaiDTO LayTheLoaiTheoMa(int matheloai)
        {
            return tlDAO.LayTheLoaiTheoMa(matheloai);
        }
    }
}
