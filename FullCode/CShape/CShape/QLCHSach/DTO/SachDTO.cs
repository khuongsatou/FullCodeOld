using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class SachDTO
    {
        public int MaSach { set; get; }
        public string Ten { set; get; }
        public int MaTacGia { set; get; }
        public string TenTacGia { set; get; }
        public int MaTheLoai { set; get; }
        public string TenTheLoai { set; get; }
        public DateTime NgayXuatBan { set; get; }
        public int MaNXB { set; get; }
        public string TenNXB { set; get; }
        public int GiaBia { set; get; }
        public int GiaNhap { set; get; }
        public int SoLuong { set; get; }
        public string AnhBia { set; get; }
        public bool Xoa { set; get; }
        public string GhiChu { set; get; }

        public SachDTO()
        {
            MaSach = 0;
            Ten = "";
            MaTacGia = 0;
            TenTacGia = "";
            MaTheLoai = 0;
            TenTheLoai = "";
            NgayXuatBan = DateTime.Now;
            MaNXB = 0;
            TenNXB = "";
            GiaBia = 0;
            GiaNhap = 0;
            SoLuong = 0;
            AnhBia = "";
            Xoa = false;
            GhiChu = "";
        }
    }
}
