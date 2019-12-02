using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class SoSanhTrongCung1Mang
    {
        static void Main()
        {
            Console.Write("Nhap vao N:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("a[{0}]", i);
                arr[i] = int.Parse(Console.ReadLine());

            }

            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        dem++;
                        break;

                    }
                }
            }
            Console.WriteLine("So Phan tu giong nhau:"+dem);
           
            Console.ReadKey();
        }
    }
}
