﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhanVienDTO
    {
        public int MaNV { set; get; }
        public string MatKhau { set; get; }
        public int MaLoaiNV { set; get; }
        public string TenLoaiNV { set; get; }
        public string HoTen { set; get; }
        public DateTime NgaySinh { set; get; }
        public bool GioiTinh { set; get; }
        public string DiaChi { set; get; }
        public string DienThoai { set; get; }
        public string Email { set; get; }
        public bool Xoa { set; get; }
        public string GhiChu { set; get; }
        

        public NhanVienDTO()
        {
            MaNV = 0;
            MatKhau = "";
            MaLoaiNV = 0;
            TenLoaiNV = "";
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
