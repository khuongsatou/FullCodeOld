using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class XemChieuCao
    {
        static void Main()
        {
            int chieuCao;
            do
            {
                Console.Write("Nhap vao chieu cao:");
                chieuCao = int.Parse(Console.ReadLine());

            } while (chieuCao <=0 );
            if (chieuCao < 150)
            {
                Console.WriteLine("Thap");
            }
            else if (150 <= chieuCao && chieuCao < 165)
            {
                Console.WriteLine("Trung Binh");
            }
            else
            {
                Console.WriteLine("Cao");
            }
            Console.ReadKey();
        }


    }
}
