using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BEL
{
    public class BEL_SINHVIEN
    {
        private string _masv;
        private string _hoten;
        private string _gioitinh;
        private DateTime _ngaysinh;
        private string _diachi;
        private string _malop;


        public BEL_SINHVIEN()
        {
            _masv="";
            _hoten = "";
            _gioitinh = "";
            _ngaysinh = DateTime.Parse("1/1/1990");
            _diachi = "";
            _malop = "";
        }
        public BEL_SINHVIEN(string _masv, string _hoten, string _gioitinh, DateTime _ngaysinh, string _diachi, string _malop)
        {
            this._masv = _masv;
            this._hoten = _hoten;
            this._gioitinh = _gioitinh;
            this._ngaysinh = _ngaysinh;
            this._diachi = _diachi;
            this._malop = _malop;
        }

       
        public string MaLop
        {
            get { return _malop; }
            set { _malop = value; }
        }
        

        public string DiaChi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        

        public DateTime NgaySinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }
        

        public string GioiTinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        
        public string HoTen
        {
            get { return _hoten; }
            set { _hoten = value; }
        }
        
        public string MaSV
        {
            get { return _masv; }
            set { _masv = value; }
        }
        
    }
}
