using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class BieuThucToanHoc
    {
        static void Main()
        {
            int n = 0;
            do
            {
                Console.Write("Nhap N:");
                n = int.Parse(Console.ReadLine());
                
            } while (n<=0);

            int s4 = 0;
            for (int i = 1; i <= n; i++)
            {
                s4 += giaiThua(i - 1) + giaiThua(n);
            }
            int s5 = 0;
            for (int i = 1; i <= n; i++)
            {
                s5 += 1/giaiThua(i - 1) + 1/giaiThua(n);
            }
            Console.WriteLine("s4= " + s4);
            Console.WriteLine("s5= "+s5);
            Console.ReadKey();

        }

        static int giaiThua(int n)
        {
            int dem = 1;
            for (int i = 1; i < n; i++)
            {
                dem *= i;
            }

            return dem;
        }
    }
}
