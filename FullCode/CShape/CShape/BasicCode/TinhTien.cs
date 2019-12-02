using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TinhTien
    {
        public static void Main()
        {
            Console.Write("Nhap so tien:");
            int nhapSoTien = int.Parse(Console.ReadLine());
            int s1 = nhapSoTien / 10;// 148 -> 14 tờ 10k
            int s2 = nhapSoTien % 10 / 5;//148 tách 8 => mod 10 xong / 5 đển lấy 1
            int s3 = nhapSoTien % 10 % 5 / 2;
            int s4 = nhapSoTien % 10 % 5 % 2 / 1;
            Console.WriteLine("Quy Do:" + s1 + " to 10d " + s2 + " to 5d, " + s3 + " to 2d," + s4 +" to 1d");
            Console.ReadKey();
        }
    }
}
