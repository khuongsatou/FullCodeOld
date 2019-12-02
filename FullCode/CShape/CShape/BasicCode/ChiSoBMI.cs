using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class ChiSoBMI
    {
        static void Main()
        {
            const float onePound = 0.45359237f;
            const float oneInch = 0.0245f;
            Console.Write("Nhap Can Nang(pound):");
            float pound = float.Parse(Console.ReadLine());
            Console.Write("Nhap Chieu Cao(inch):");
            float chieuCao = float.Parse(Console.ReadLine());
            Console.WriteLine("Chi So BMI"+(pound*onePound) / Math.Pow((chieuCao*oneInch),2));
            Console.ReadKey();
        }
    }
}
