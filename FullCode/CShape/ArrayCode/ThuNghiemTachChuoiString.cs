using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class ThuNghiemTachChuoiString
    {
        static void Main()
        {
            Console.WriteLine("Nhap Chuoi:");
            string n = Console.ReadLine();
            foreach (char item in n)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
