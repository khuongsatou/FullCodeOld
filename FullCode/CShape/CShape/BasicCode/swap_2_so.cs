using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class swap_2_so
    {
        static public void Main()
        {
            Console.Write("Nhap hai so nguyen");
            int a = int.Parse(Console.ReadLine());
            //Console.Write("Nhap hai so nguyen");
            int b = int.Parse(Console.ReadLine());

            int temp = b;
            b = a;
            a = temp;
            
            Console.WriteLine("Sau Khi Hoan Vi"+a+"\t"+b);
            Console.ReadKey();

        }
    }
}
