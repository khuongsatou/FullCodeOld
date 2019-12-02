using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO nvDAO = new NhanVienDAO();
        public DataTable LayDanhSach()
        {
            return nvDAO.LayDanhSach();
        }
        public bool Them(NhanVienDTO nvDTO)
        {
            if (nvDTO.HoTen == "")
            {
                throw new Exception("Chưa nhập tên nhân viên!");
            }
            if (nvDTO.MatKhau == "")
            {
                throw new Exception("Chưa nhập mật khẩu!");
            }
            if (nvDTO.MaLoaiNV == 0)
            {
                throw new Exception("Chưa chọn loại nhân viên!");
            }
            if (nvDTO.NgaySinh > DateTime.Now)
            {
                throw new Exception("Ngày sinh không hợp lệ!");
            }
            return nvDAO.Them(nvDTO);
        }
        public bool Sua(NhanVienDTO nvDTO)
        {
            if (nvDTO.HoTen == "")
            {
                throw new Exception("Chưa nhập tên nhân viên!");
            }
            if (nvDTO.MaLoaiNV == 0)
            {
                throw new Exception("Chưa chọn loại nhân viên");
            }
            if (nvDTO.NgaySinh > DateTime.Now)
            {
                throw new Exception("Ngày sinh không hợp lệ!");
            }
            return nvDAO.Sua(nvDTO);
        }
        public NhanVienDTO LayNhanVienTheoMaNV(int manv)
        {
            return nvDAO.LayNhanVienTheoMaNV(manv);
        }
        public bool ResetMatKhau(int manv, string matkhau)
        {
            return nvDAO.ResetMatKhau(manv, matkhau);
        }
        public int DangNhap(int manv, string matkhau)
        {
            return nvDAO.DangNhap(manv, matkhau);
        }
        public bool Xoa(int id)
        {
            return nvDAO.Xoa(id);
        }
        public string MaHoaMD5(string input)
        {
            return nvDAO.MaHoaMD5(input);
        }
    }
}
