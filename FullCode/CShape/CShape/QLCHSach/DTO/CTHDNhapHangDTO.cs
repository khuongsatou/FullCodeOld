using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CTHDNhapHangDTO
    {
        public int MaHD { set; get; }
        public int MaSach { set; get; }
        public int SoLuong { set; get; }
        public int GiaBia { set; get; }
        public int GiaNhap { set; get; }

        public CTHDNhapHangDTO()
        {
            MaHD = 0;
            MaSach = 0;
            SoLuong = 0;
            GiaBia = 0;
            GiaNhap = 0;
        }
    }
}
