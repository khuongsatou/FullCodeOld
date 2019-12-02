using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class TacGiaBUS
    {
        TacGiaDAO tgDAO = new TacGiaDAO();
        public DataTable LayDanhSach()
        {
            return tgDAO.LayDanhSach();
        }
        public bool Them(TacGiaDTO tgDTO)
        {
            if (tgDTO.HoTen == "")
            {
                throw new Exception("Chưa nhập tên tác giả!");
            }
            if (tgDTO.NgaySinh > DateTime.Now)
            {
                throw new Exception("Ngày sinh không hợp lệ!");
            }
            return tgDAO.Them(tgDTO);
        }
        public bool Sua(TacGiaDTO tgDTO)
        {
            if (tgDTO.HoTen == "")
            {
                throw new Exception("Chưa nhập tên tác giả!");
            }
            if (tgDTO.NgaySinh > DateTime.Now)
            {
                throw new Exception("Ngày sinh không hợp lệ!");
            }
            return tgDAO.Sua(tgDTO);
        }
        public bool Xoa(int id)
        {
            return tgDAO.Xoa(id);
        }
        public TacGiaDTO LayTacGiaTheoMa(int matacgia)
        {
            return tgDAO.LayTacGiaTheoMa(matacgia);
        }
    }
}
