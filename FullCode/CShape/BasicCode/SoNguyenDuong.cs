using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class SoNguyenDuong
    {
        static void Main()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Nhap so nguyen duong N: ");
                n = int.Parse(Console.ReadLine());
              
            } while (n < 0);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
