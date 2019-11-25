using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class SSChuoi
    {
        static void Main()
        {
            Console.Write("Nhap str:");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        char temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;

                    }
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(arr[i]);
            }
           

            Console.ReadKey();

        }
    }
}
