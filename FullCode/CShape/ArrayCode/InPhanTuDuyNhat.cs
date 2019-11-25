using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class InPhanTuDuyNhat
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


            int[] arrTrung = new int[n];
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)//1 1 2 3 .... vị trí 0
            {

                dem = 0;// reset
                //
                for (int j = 0; j <= i - 1; j++)// 0 <= -1  ... 0 <= 0  ... 0 <= 1
                {
                    if (arr[i] == arr[j])// so sánh lại , giống kiểu .... 
                    {
                        dem++;// tăng
                    }
                }

                for (int k = i + 1; k < arr.Length; k++)// vị trí 1   
                {
                    if (arr[i] == arr[k])// vt 0 ==vt 1
                    {
                        dem++;// tang dem
                    }
                }

                if (dem == 0)// ko in  .. ko in
                {
                    Console.Write("{0}", arr[i]);
                }

            }

            Console.ReadKey();
        }


    }
}
