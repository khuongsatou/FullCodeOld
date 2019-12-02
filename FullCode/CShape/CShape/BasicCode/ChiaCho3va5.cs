using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class ChiaCho3va5
    {
        static void Main()
        {
            Console.Write("Nhap so nguyen:");
            int soNguyen = int.Parse(Console.ReadLine());
            if (soNguyen % 3 == 0 && soNguyen % 5 == 0)
            {
                Console.WriteLine("Co");
            }
            else
            {
                Console.WriteLine("Khong");
            }
            Console.ReadKey();
        }
    }
}
