using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class CuaHangBanSanPham
    {
        static void Main()
        {
            Console.Write("Nhap Doanh so:");
            long doanhThu = long.Parse(Console.ReadLine());
            double ketqua = 0;
            if (doanhThu <= 100000000)
            {
                ketqua = doanhThu * 0.05;
            }
            else if (doanhThu > 100000000 && doanhThu <= 300000000)
            {
                ketqua = doanhThu * 0.1;
            }
            else
            {
                ketqua = doanhThu * 0.2;
            }

            Console.WriteLine("Hoa Hong: " + ketqua);
            Console.ReadKey();
            

        }
    }
}
