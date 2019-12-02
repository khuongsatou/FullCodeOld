using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class XoaViTriThuK
    {
        static void Main()
        {
            Console.WriteLine("Nhap N:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a["+i+"]");
                arr[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Nhap vi tri K:");
            int k = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < n; i++)
            {
                arr[k] = arr[k + 1];
                
            }
            n--;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}]={1}",i,arr[i]);
            }
            Console.ReadKey();
        }

    }
}
