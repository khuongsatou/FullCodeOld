using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TinhPhiVanChuyen
    {
        static void Main()
        {
            int khoiLuong = 0;
            do
            {
                Console.Write("Nhap khoi luong:");
                khoiLuong = int.Parse(Console.ReadLine());
                if (khoiLuong <= 0)
                {
                    Console.WriteLine("Khoi Luong Phai lon hon 0 ");
                }
            } while (khoiLuong <= 0);
            int result = TinhPhiVan(khoiLuong);
            Console.WriteLine("Phi Van Chuyen:" +result);
            Console.ReadKey();
        }

        static int TinhPhiVan(int m)
        {
            int phiVanChuyen = 0;
            if (0 < m && m <= 10)
            {
                phiVanChuyen = 5000;
            }
            else if (10 < m && m <= 20)
            {
                phiVanChuyen = 9000;
            }
            else if (20 < m && m <= 50)
            {
                phiVanChuyen = 15000;
            }
            else
            {
                phiVanChuyen = 20000;
            }
            return phiVanChuyen;
        }
    }
}
