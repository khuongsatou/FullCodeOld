using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class ChenXvaoViTriK
    {

        static void Main()
        {
            Console.Write("Nhap ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[50];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap vao a["+i+"] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nhap X:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap K:");
            int k = int.Parse(Console.ReadLine());

            for (int i = n; i >= k; i--)
            {
                arr[i] = arr[i - 1];//  5=4
            }
            arr[k] = x;
            n++;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}]={1}",i,arr[i]);

            }


            Console.ReadKey();
        }
        
    }
}
