using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class SoHoanThien
    {
        static void Main()
        {
            int n = 0;
            do
            {
                Console.Write("Nhap So nguyen duong N:");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            int dem = 0;
            for (int i = 1; i < n; i++)
            {
                if (n% i == 0)
                {

                    dem+=i;
                }
            }
            if (dem==n)
            {
                Console.WriteLine(n + " la so hoan thien");
            }
            else
            {
                Console.WriteLine(n + " khong phai la so hoan thien");
            }


            Console.ReadKey();
        }
    }
}
