using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class InSoDaoNguoc
    {
        static void Main()
        {

            int n = 0;
            do
            {
                Console.Write("Nhap so nguyen duong N:");
                n = int.Parse(Console.ReadLine());
            } while (n<=0);
            //int save = n;
            int temp=0;
            int res = 0;
            while (n > 0)
            {
                temp = n % 10;
                res = res * 10 + temp;
                n /= 10;
            }

            Console.WriteLine(res);

            Console.ReadKey();



        }
    }
}
