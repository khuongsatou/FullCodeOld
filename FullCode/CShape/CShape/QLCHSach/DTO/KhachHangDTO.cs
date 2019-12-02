using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KhachHangDTO
    {
        public int MaKH { set; get; }
        public string HoTen { set; get; }
        public DateTime NgaySinh { set; get; }
        public bool GioiTinh { set; get; }
        public string DiaChi { set; get; }
        public string DienThoai { set; get; }
        public string Email { set; get; }
        public bool Xoa { set; get; }
        public string GhiChu { set; get; }

        public KhachHangDTO()
        {
            HoTen = "";
            NgaySinh = DateTime.Now;
            GioiTinh = false;
            DiaChi = "";
            DienThoai = "";
            Email = "";
            Xoa = false;
            GhiChu = "";
        }
    }

}
