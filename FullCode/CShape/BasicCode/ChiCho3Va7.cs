using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class ChiCho3Va7
    {
        static void Main()
        {
            int n;
            do
            {
                Console.Write("Nhap so nguyen N:");
                n = int.Parse(Console.ReadLine());
            } while (n<= 0);

            if (is3Va7(n))
            {
                Console.WriteLine("Co");
            }
            else
            {
                Console.WriteLine("Khong");
            }
            Console.ReadKey();
        }
        static bool is3Va7(int n)
        {

            if (n % 3 == 0 && n % 7 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
