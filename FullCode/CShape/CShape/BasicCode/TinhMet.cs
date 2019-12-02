using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TinhMet
    {
        static void Main()
        {
            Console.Write("Nhap so bo:");
            float _bo = float.Parse(Console.ReadLine());
            Console.WriteLine("Quy Doi:" + _bo * 0.305);
            Console.ReadKey();
        }
    }
}
