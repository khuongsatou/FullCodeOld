using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class InDaoNguoc
    {
        static void Main()
        {
            Console.WriteLine("Nhap N: ");
            int n = int.Parse( Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("a[{0}] = ",i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
