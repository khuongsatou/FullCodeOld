using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class is_do_while
    {
        static void Main()
        {
            int n=0;
            //n = int.Parse(Console.ReadLine());
            do
            {
                n =int.Parse(Console.ReadLine());//[1;100]
            } while (n<1 || n>100);//true thì lập ; -1 -> -1 < 1 -> true ,
            //-1 > 100 -> false => do -> true
            //
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
