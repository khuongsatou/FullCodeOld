using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class NhapDiem
    {
        static void Main()
        {
            float _diemCC, _diemTB, _diemThi;
            Console.Write("Nhap Diem Chuyen Can:");
            _diemCC = float.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Trung Binh Kiem Tra:");
            _diemTB = float.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Thi:");
            _diemThi = float.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            Console.WriteLine("DIEM MON HOC NHAP MON LAP TRINH");
            Console.WriteLine("Ho ten: Tran Thang Tuan");
            Console.WriteLine("MSSV: 0123456");
            Console.WriteLine("Lop: CDN SCMT 17");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Chuyen Can:" + _diemCC + "\t TBKT:" + _diemTB + "\t Thi:" + _diemThi);
            Console.ReadKey();
        }
    }
}
