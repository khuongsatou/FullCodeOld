using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TinhHinhTron
    {
        static void Main()
        {
            Console.Write("Nhap Ban Kinh:");
            float _BanKinh = float.Parse(Console.ReadLine());
            Console.WriteLine("Chu Vi:"+(2 * 3.14 *_BanKinh));
            Console.WriteLine("Dien Tich:" + ( 3.14 *Math.Pow(_BanKinh,2)));
            
            Console.ReadKey();
        }
    }
}
