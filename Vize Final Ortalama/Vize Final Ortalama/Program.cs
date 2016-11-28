using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_Final_Ortalama
{
    class Program
    {
        static void Main(string[] args)
        {
            // not girişi , %40vize , %60 final
            double vize, final, ort;

            Console.WriteLine("Vize Notunu Giriniz..:");

            vize = double.Parse(Console.ReadLine());

            Console.WriteLine("\nFinal Notunu Giriniz..:");

            final = double.Parse(Console.ReadLine());

            ort = (vize * 0.4 + final * 0.6);

            Console.WriteLine("\nNot Ortalamanız : " + ort);

            if (ort < 50)
            {
                Console.WriteLine("\nKaldınız");
            }
            else if (ort >= 50)
            {
                Console.WriteLine("\nGeçtiniz");
            }

            Console.ReadLine();
        }
    }
}
