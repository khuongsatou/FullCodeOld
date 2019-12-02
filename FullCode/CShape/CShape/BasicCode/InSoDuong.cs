using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class InSoDuong
    {
        static void Main()
        {
            Console.Write("Nhap so nguyen : ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Ket Qua: " + Math.Abs(n));
          
            Console.ReadKey();
        }
    }
}
