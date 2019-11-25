using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class KiemTraSoAmDuong
    {
        static void Main()
        {
            Console.Write("Nhap So nguyen: ");
            int soNguyen = int.Parse(Console.ReadLine());
            if (soNguyen > 0)
            {
                Console.WriteLine("Ket Qua" + soNguyen + " là so duong");
            }
            else
            {
                Console.WriteLine("Ket Qua" + soNguyen + " là so am");
            }
            Console.ReadKey();
        }
    }
}
