using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class Program
    {
        static void Main(string[] args)
        {
            //khởi tạo
            int[] n =new int[10];
            //gán vào 
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = i;
            }
            //in ra
            for (int i = 0; i < n.Length; i++)
            {
                 Console.WriteLine(n[i]);
            }
            //in bằng foreach
            foreach (int item in n)
            {
                 Console.WriteLine(n[item]);
            }
            // 0 -> 0 , 4 -> 4
            //truy cập 1 phần từ
            Console.WriteLine(n[4]);
            Console.ReadKey();
        }
    }
}
