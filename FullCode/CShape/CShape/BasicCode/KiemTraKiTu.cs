using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class KiemTraKiTu
    {
        static void Main()
        {
            char a = char.Parse(Console.ReadLine());

            //for (char i = '0'; i <= '9'; i++)
            //{
                
            //    Console.WriteLine(i + ",");
            //}

            if (a >= 'A' && a <= 'Z')
            {
                Console.WriteLine(a + " la ki tu In");
            }
            else if (a >= 'a' && a <= 'z')
            {
                Console.WriteLine(a + " la ki tu a thuong");
            }
            else if (a >= '0' && a <= '9')
            {
                Console.WriteLine(a + " la ki tu so");
            }
            else
            {
                Console.WriteLine(a + " la ki tu dat biet");
            }
            Console.ReadKey();
            
        }
    }
}
