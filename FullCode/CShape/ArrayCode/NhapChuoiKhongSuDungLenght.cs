using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class NhapChuoiKhongSuDungLenght
    {
        static void Main()
        {
            Console.WriteLine("Nhap Chuoi:");
            string n = Console.ReadLine();
            int dem = 0;
            foreach (char item in n)
            {
                dem++;
            }
           
            Console.WriteLine("Do Dai:"+dem);
            Console.ReadKey();
        }
    }
}
