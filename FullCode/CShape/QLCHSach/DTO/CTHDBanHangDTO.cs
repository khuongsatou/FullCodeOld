using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CTHDBanHangDTO
    {
        public int MaHD { get; set; }
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public int SoLuong { get; set; }
        public int GiaBan { get; set; }
        public int KhuyenMai { get; set; }
        public int ThanhTien { get; set; }

        public CTHDBanHangDTO()
        {
            MaHD = 0;
            MaSach = 0;
            TenSach = "";
            SoLuong = 0;
            GiaBan = 0;
            KhuyenMai = 0;
            ThanhTien = 0;
        }
    }
}
