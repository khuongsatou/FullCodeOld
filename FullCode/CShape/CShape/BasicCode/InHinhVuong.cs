using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class InHinhVuong
    {
        static void Main()
        {
            int n, m;
            do
            {

                Console.Write("Nhap 2 so nguyen duong:");
                n = int.Parse(Console.ReadLine());
                m = int.Parse(Console.ReadLine());
            } while (n<=0 || m <=0);

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || j == 1 || i == m || j == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }

            
            Console.ReadKey();
           
        }
    }
}
