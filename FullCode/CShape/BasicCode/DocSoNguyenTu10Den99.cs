using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class DocSoNguyenTu10Den99
    {
        static void Main()
        {
            //Ghép vd như nhập vào số 11 -> mười mot -> mười nối chuỗi mot -> thế là sao cho nó biết có 10 và 1.
            //tách ra 11 % 10 dư 1 , 11/10 = 1
            int soNguyen = 0;
            do
            {
                Console.Write("Nhap so nguyen: ");
                 soNguyen = int.Parse(Console.ReadLine());
                 if (soNguyen < 10 || soNguyen > 99)
                 {
                     Console.WriteLine("So Khong hop le");
                 }
            } while (soNguyen < 10 || soNguyen > 99 );// dk đúng soNguyen >= 10 && soNguyen <= 99
            int soChuc = soNguyen / 10;
            int soDonVi = soNguyen % 10;
            
            Console.WriteLine(inTenSoTenToNinetyNine(soChuc) +" "+ inTenSoOneToNine(soDonVi));
            Console.ReadKey();
        }
        static string inTenSoOneToNine(int soDonVi)
        {
            switch (soDonVi)
            {
                case 1: return "Mot";
                case 2: return "Hai";
                case 3: return "Ba";
                case 4: return "Bon";
                case 5: return "Nam";
                case 6: return "Sau";
                case 7: return "Bay";
                case 8: return "Tam";
                case 9: return "Chin";
            }
            return "";
        }

        static string inTenSoTenToNinetyNine(int soChuc)
        {
            switch (soChuc)
            {
                case 1: return "Muoi";
                case 2: return "Hai Muoi";
                case 3: return "Ba Muoi";
                case 4: return "Bon Muoi";
                case 5: return "Nam Muoi";
                case 6: return "Sau Muoi";
                case 7: return "Bay Muoi";
                case 8: return "Tam Muoi";
            }
            return "Chin Muoi";
        }
    }
}
