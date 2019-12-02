using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class NguyenAmVaPhuAm
    {
        static void Main()
        {
            char a;
            Console.Write("Nhap 1 ki tu:");
            a = char.Parse(Console.ReadLine());
            if (NguyenAm(a))
            {
                Console.WriteLine(a + " la nguyen am");
            }
            else
            {
                Console.WriteLine(a + " la phu am");
            }
            Console.ReadKey();
        }

        static bool NguyenAm(char a)
        {
            switch (a)
            {
                case 'e': 
                case 'u':
                case 'o':
                case 'a':
                case 'i':
                    return true;
            }
            return false;
        }
    }
}
