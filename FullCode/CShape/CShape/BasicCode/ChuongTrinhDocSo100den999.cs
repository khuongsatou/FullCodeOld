using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class ChuongTrinhDocSo100den999
    {
        static void Main()
        {
            int soNguyen;
            do
            {
                 Console.Write("Nhap so nguyen: ");
                 soNguyen = int.Parse(Console.ReadLine());
                 if (soNguyen < 100 || soNguyen > 999)
                 {
                     Console.WriteLine("So khong Hop le");
                 }
            } while (soNguyen < 100 || soNguyen > 999);

            int tram = soNguyen / 100;// 333 -> 3
            int chuc = soNguyen % 100 / 10;//333 -> 33 -> 3
            int donvi = soNguyen % 100 % 10;

            //Console.WriteLine(DocSoHangTram(tram) + " " + DocSoHangChuc(chuc) + " " + DocSoHangDonVi(donvi));
            // hiện tại là 805 tam tram le 5
            // su li hang chuc
            // 900 chin tram xu li hang chuc và đơn vị
            if (DocSoHangChuc(chuc) == "" && DocSoHangDonVi(donvi)== "")
            {
                Console.WriteLine(DocSoHangTram(tram) + " " + DocSoHangChuc(chuc) + " " + DocSoHangDonVi(donvi));
            }
            else if (DocSoHangChuc(chuc) == "")
            {
                Console.WriteLine(DocSoHangTram(tram) + " le " + DocSoHangDonVi(donvi));
            }
            else
            {
                Console.WriteLine(DocSoHangTram(tram) + " " + DocSoHangChuc(chuc));
            }

            Console.ReadKey();

        }

        static string DocSoHangDonVi(int soNguyen)
        {
            switch (soNguyen)
            {
                case 0: return "";
                case 1: return "Mot";
                case 2: return "Hai";
                case 3: return "Ba";
                case 4: return "Bon";
                case 5: return "Nam";
                case 6: return "Sau";
                case 7: return "Bay";
                case 8: return "Tam";
               
            }
            return "Chin";
        }

        static string DocSoHangChuc(int soNguyen)
        {
            switch (soNguyen)
            {
                case 0: return "";
                case 1: return "Muoi";
                case 2: return "Hai Muoi";
                case 3: return "Ba  Muoi";
                case 4: return "Bon Muoi";
                case 5: return "Nam Muoi";
                case 6: return "Sau Muoi";
                case 7: return "Bay Muoi";
                case 8: return "Tam Muoi";

            }
            return "Chin Muoi";
        }

        static string DocSoHangTram(int soNguyen)
        {
            switch (soNguyen)
            {
                case 0: return "";
                case 1: return "Mot Tram";
                case 2: return "Hai Tram";
                case 3: return "Ba  Tram";
                case 4: return "Bon Tram";
                case 5: return "Nam Tram";
                case 6: return "Sau Tram";
                case 7: return "Bay Tram";
                case 8: return "Tam Tram";

            }
            return "Chin Tram";
        }
    }
}
