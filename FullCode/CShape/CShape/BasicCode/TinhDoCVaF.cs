using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TinhDoCVaF
    {
        static void Main()
        {
            Console.Write("Nhap do C:");
            float _DoC = 0;
            do
            {
                _DoC = float.Parse(Console.ReadLine());
            } while (_DoC < 0);
            Console.WriteLine("DO F:"+(9.0/5*_DoC+32));
            
            Console.ReadKey();

        }
    }
}
