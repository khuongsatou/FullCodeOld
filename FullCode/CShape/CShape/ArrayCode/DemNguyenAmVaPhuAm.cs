using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class DemNguyenAmVaPhuAm
    {
        static void Main()
        {
            Console.WriteLine("Nhap Chuoi:");
            string str   = Console.ReadLine();
            int nguyenam = 0;
            int phuam    = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    if (str[i] == 'e' || str[i] == 'u' || str[i] == 'o' || str[i] == 'a' || str[i] == 'i')
                    {
                        nguyenam++;
                    }
                    else
                    {
                        phuam++;
                    }
                }
            }

            Console.WriteLine("{0} nguyen am, {1} phu am",nguyenam,phuam);
            Console.ReadKey();
        }
    }
}
