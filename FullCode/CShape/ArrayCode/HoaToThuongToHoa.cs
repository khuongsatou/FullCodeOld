using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class HoaToThuongToHoa
    {
        static void Main()
        {
            Console.Write("Nhap Vao Chuoi:");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(arr[i]))
                {
                    Console.Write(Char.ToUpper(arr[i]));
                }
                else
                {
                    Console.Write(Char.ToLower(arr[i]));
                }
            }
            

            Console.ReadKey();
        }
    }
}
