using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class IsLeafYear
    {
        static void Main()
        {
            Console.Write("Nhap Nam:");
            int soNguyen = int.Parse(Console.ReadLine());
            if ((soNguyen % 4 == 0 && soNguyen % 100 != 0) || (soNguyen % 400 == 0) )
            {
                Console.WriteLine(soNguyen + " la nam nhuan");
            }
            else
            {
                Console.WriteLine(soNguyen + " la nam khong nhuan");
            }
            Console.ReadKey();
        }
    }
}
