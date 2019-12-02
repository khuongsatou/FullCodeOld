using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangDAO khDAO = new KhachHangDAO();
        public DataTable LayDanhSach()
        {
            return khDAO.LayDanhSach();
        }
        public bool Them(KhachHangDTO khDTO)
        {
            if (khDTO.HoTen == "")
            {
                throw new Exception("Chưa nhập tên khách hàng!");
            }
            if (khDTO.NgaySinh > DateTime.Now)
            {
                throw new Exception("Ngày sinh không hợp lệ!");
            }
            return khDAO.Them(khDTO);
        }
        public bool Sua(KhachHangDTO khDTO)
        {
            if (khDTO.HoTen == "")
            {
                throw new Exception("Chưa nhập tên nhân viên!");
            }
            if (khDTO.NgaySinh > DateTime.Now)
            {
                throw new Exception("Ngày sinh không hợp lệ!");
            }
            return khDAO.Sua(khDTO);
        }
        public bool Xoa(int id)
        {
            return khDAO.Xoa(id);
        }
        public string LayTenKHTheoMa(int makh)
        {
            return khDAO.LayTenKHTheoMa(makh);
        }
        public KhachHangDTO LayKHTheoMa(int makh)
        {
            return khDAO.LayKHTheoMa(makh);
        }
    }
}
