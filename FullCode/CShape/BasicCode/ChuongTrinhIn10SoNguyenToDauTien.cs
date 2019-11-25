using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class ChuongTrinhIn10SoNguyenToDauTien
    {
        static void Main()
        {
            int i = 2;
            int dem = 0;
            while (true)
            {
                if (isNguyenTo(i))
                {
                    Console.WriteLine(i);
                    dem++;
                }

                if (dem == 10)
                {
                    break;
                }
                i++;
            }
            Console.ReadKey();
        }

        static bool isNguyenTo(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
