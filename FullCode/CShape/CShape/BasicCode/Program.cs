using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("" + sizeof(int));
            Console.WriteLine("" + sizeof(float));
            Console.WriteLine("" + sizeof(char));
            Console.WriteLine("" + sizeof(bool));
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("a:" + a);
            Console.ReadKey();
        }
    }
}
