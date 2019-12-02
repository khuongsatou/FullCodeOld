using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TaoSoNgauNhienHai
    {
        static void Main()
        {
            Random rd = new Random();
            Console.WriteLine(rd.Next(97-65+1)+65);
            Console.ReadKey();
        }
    }
}
