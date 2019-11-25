using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class ChoBietSoDuongSo0Am
    {
        static void Main()
        {
            Console.Write("Nhap so nguyen");
            int soNguyen = int.Parse(Console.ReadLine());
            if (soNguyen > 0)
            {
                Console.Write(soNguyen+ "la so duong");
            }
            else if (soNguyen < 0)
            {
                Console.Write(soNguyen + "la so am");
            }
            else
            {
                Console.Write(soNguyen + "la so 0 ");
            }
            Console.ReadKey();
            
        }
    }
}
