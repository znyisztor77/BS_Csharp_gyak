using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_Ketszam_kulonbseg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double szam1, szam2;
            szam1 = szamBeker("Kérek egy számot:");
            szam2 = szamBeker("Kérek még egy számot");
            Console.WriteLine($"A két szám összege {szam1 + szam2}, a különbsége {szam1 - szam2}");
           
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
