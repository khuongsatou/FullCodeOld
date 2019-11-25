using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class IsSoNguyenTo
    {
        static void Main()
        {
            int n = 0;
            do
            {
                Console.Write("Nhap so nguyen duong N:");
                n = int.Parse(Console.ReadLine()); 
            } while (n <= 0);
            bool flag = false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine(n + " khong la so nguyen to");
            }
            else
            {
                Console.WriteLine(n + " la so nguyen to");
            
            }
            Console.ReadKey();
        }
    }
}
