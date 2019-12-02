using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class InRaMangHinhSoLeLienTiep1DenN
    {
        static void Main()
        {
            int n = 0;
            do
            {
                Console.Write("Nhap so nguyen duong N: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 );

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
