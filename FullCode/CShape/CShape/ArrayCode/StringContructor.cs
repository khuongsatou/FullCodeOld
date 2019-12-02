using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class StringContructor
    {
        static void Main()
        {
            Console.WriteLine("Cac cach tao chuoi trong C#");

            // gán
            string fname, lname;
            fname = "Tran Thanh";
            lname = "Tuan";

            string fullname = fname + "" + lname;
            Console.WriteLine(fullname);


            //su dụng contructor
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
         
            Console.WriteLine("\n Loi Chao bang tieng anh:{0}", new string(letters));

            // tu cac phuong thuc ma tra ve mot chuôi
            string[] sarray = { "CKC", "Xin", "CHAO", "CAC", "BAN" };
            Console.WriteLine(sarray.Length);
            string message = String.Join(", ", sarray);
            Console.WriteLine(message);

            //dinh dang phuong thuc de chuyen doi 1 gia tri
            DateTime waiting = new DateTime(2019, 2, 19, 12, 45, 55);
            string chat = String.Format("Thong diep duoc gui luc {0:t} ngay {0:D}",waiting);

            Console.WriteLine("\n thong dep: {0}",chat);

            Console.ReadKey();
        }
        
    }
}
