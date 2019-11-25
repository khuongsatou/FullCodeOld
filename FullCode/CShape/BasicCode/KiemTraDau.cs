using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class KiemTraDau
    {
        static void Main()
        {
            Console.Write("Nhap 2 So nguyen:");
            int soNguyen1 = int.Parse(Console.ReadLine());
            int soNguyen2 = int.Parse(Console.ReadLine());
            if (( soNguyen1 > 0 && soNguyen2 > 0) || (soNguyen1 < 0 && soNguyen2 < 0))
            {
                Console.WriteLine("{0} va {1} la 2 so cung dau",soNguyen1,soNguyen2);
            }
            else
            {
                Console.WriteLine("{0} va {1} la 2 so trai dau", soNguyen1, soNguyen2);
            }
            Console.ReadKey();
        }
    }
}
