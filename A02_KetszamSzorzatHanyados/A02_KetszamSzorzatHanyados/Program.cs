using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02_KetszamSzorzatHanyados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double szam1, szam2;
            szam1 = szamBeker("Kérek egy számot:");
            szam2 = szamBeker("Kérek még egy számot");
            double osztas = szam1 / szam2;
            Console.WriteLine($"A két szám szorzata {szam1 * szam2}, a hámnyadosa {Math.Round(osztas, 2)}");
            Console.ReadKey();
        }

        private static double szamBeker(string v)
        {
            Console.WriteLine(v);
            double szam = 0;
            while (!double.TryParse(Console.ReadLine(), out szam))
            {
                Console.WriteLine("Nem megfelelő bevitel");
                Console.WriteLine(v);

            }
            return szam;
        }
    }
}
