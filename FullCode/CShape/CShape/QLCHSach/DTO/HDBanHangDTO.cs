using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DTO
{
    public class HDBanHangDTO
    {
        public int MaHD { get; set; }
        public DateTime NgayBan { get; set; }
        public int MaNV { get; set; }
        public int MaKH { get; set; }
        public int TongTien { get; set; }

        public HDBanHangDTO()
        {
            MaHD = 0;
            NgayBan = DateTime.Now;
            MaNV = 0;
            MaKH = 0;
            TongTien = 0;
        }
    }
}
