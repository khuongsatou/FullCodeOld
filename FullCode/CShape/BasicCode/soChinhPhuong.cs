using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class soChinhPhuong
    {
        static void Main()
        {
            int n = 0;   
            do
            {
                Console.Write("Nhap so nguyen: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("So nguyen phai lon hon 0");
                }
            } while (n <= 0);

            if (KiemTraSoChinhPhuong(n))
            {
                Console.WriteLine("{0} la so chinh phuong", n);
            }
            else
            {
                Console.WriteLine("{0} khong la so chinh phuong", n);
            }

            Console.ReadKey();
        }

        static bool KiemTraSoChinhPhuong(int n)
        {
            int temp = (int)Math.Sqrt(n);
            if (temp * temp == n)
            {
                return true; 
            }
            return false;
        }
    }
}
