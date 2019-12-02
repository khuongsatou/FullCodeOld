using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TinhHinhVuong
    {
        static void Main()
        {
            Console.Write("Nhap do dai canh:");
            float _Canh = float.Parse(Console.ReadLine());
            Console.WriteLine("Chu vi:"+(_Canh*4));
            Console.WriteLine("Dien Tich:"+((Math.Pow(_Canh,2))));
            Console.ReadKey();
            
        }
    }
}
