using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A16_KoordinataTavolsag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A és B pont koordináták távolságának kiszámítása");
            Console.WriteLine("Kérem az A pont koordinátáit:");
            double a1pont = adatBeker("a1: ");
            double b1pont = adatBeker("b1: "); ;
            Console.WriteLine("Kérem az B pont koordinátáit:");
            double a2pont = adatBeker("a2: "); ;
            double b2pont = adatBeker("b2: "); ;
            tavolsagSzamol(a1pont, b1pont, a2pont, b2pont);
            Console.ReadKey();
        }

        private static void tavolsagSzamol(double a1pont, double b1pont, double a2pont, double b2pont)
        {
            double d;
            double A;
            double B;
            A = Math.Pow((b1pont-a1pont),2);
            B = Math.Pow((b2pont-a2pont),2);
            d = Math.Sqrt(A + B);
            Console.WriteLine($"A két pont távolsága: {d}");
        }

        private static double adatBeker(string v)
        {
            double adat;
            Console.Write(v);
            while (!double.TryParse(Console.ReadLine(), out adat))
            {
                Console.WriteLine("Hibás adat!");
                Console.Write(v);
               
            }
            return adat;
        }
    }
}
