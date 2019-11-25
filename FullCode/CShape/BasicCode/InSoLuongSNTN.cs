using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class InSoLuongSNTN
    {
        static void Main()
        {
            int n = 0;
            do
            {
                Console.Write("Nhap so nguyen duong N:");
                n = int.Parse(Console.ReadLine());
            } while (n<=0);

            int i = 2;
            int dem = 0;
            while (true)
            {
                
                if (isNguyenTo(i))
                {
                    Console.WriteLine(i);
                    dem++;
                }
                
                if (dem == n)
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
