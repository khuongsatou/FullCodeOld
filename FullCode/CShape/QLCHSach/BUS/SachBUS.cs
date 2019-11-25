using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class SachBUS
    {
        SachDAO sDAO = new SachDAO();
        public DataTable LayDanhSach()
        {
            return sDAO.LayDanhSach();
        }
        public bool Them(SachDTO sDTO)
        {
            if (sDTO.Ten == "")
            {
                throw new Exception("Chưa nhập tên sách!");
            }
            if (sDTO.MaTacGia == 0)
            {
                throw new Exception("Chưa chọn tác giả!");
            }
            if (sDTO.MaTheLoai == 0)
            {
                throw new Exception("Chưa chọn thể loại!");
            }
            if (sDTO.MaNXB == 0)
            {
                throw new Exception("Chưa chọn nhà xuất bản!");
            }
            return sDAO.Them(sDTO);
        }
        public bool Sua(SachDTO sDTO)
        {
            if (sDTO.Ten == "")
            {
                throw new Exception("Chưa nhập tên sách!");
            }
            if (sDTO.MaTacGia == 0)
            {
                throw new Exception("Chưa chọn tác giả!");
            }
            if (sDTO.MaTheLoai == 0)
            {
                throw new Exception("Chưa chọn thể loại!");
            }
            if (sDTO.MaNXB == 0)
            {
                throw new Exception("Chưa chọn nhà xuất bản!");
            }
            return sDAO.Sua(sDTO);
        }
        public bool CapNhatSoLuongGiaBia(int masach, int soluong, int giabia, int gianhap)
        {
            return sDAO.CapNhatSoLuongGiaBia(masach, soluong, giabia,gianhap);
        }
        public bool Xoa(int id)
        {
            return sDAO.Xoa(id);
        }

        public string LayTenSachTheoMa(int masach)
        {
            return sDAO.LayTenSachTheoMa(masach);
        }
        public SachDTO LaySachTheoMa(int masach)
        {
            return sDAO.LaySachTheoMa(masach);
        }
        public SachDTO LaySachTonKhoTheoMa(int masach)
        {
            return sDAO.LaySachTonKhoTheoMa(masach);
        }
        public bool CapNhatSoLuong(int masach, int soluongban)
        {
            return sDAO.CapNhatSoLuong(masach, soluongban);
        }
        public DataTable LayDSSachTheoTheLoai(int matheloai)
        {
            return sDAO.LayDSSachTheoTheLoai(matheloai);
        }
        public DataTable LayDSSachTheoNXB(int manxb)
        {
            return sDAO.LayDSSachTheoNXB(manxb);
        }
        public DataTable LayDSSachTonKho(int soluong)
        {
            return sDAO.LayDSSachTonKho(soluong);
        }
    }
}
