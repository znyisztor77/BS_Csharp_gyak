using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A18_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 𝑐 = √𝑎2 + 𝑏2
            Console.WriteLine("Számoljuk ki a derékszögű háromszög átfogóját.");
            double befogoA = adatBeker("Kérem a háromszög A befogóját:");
            double befogoB = adatBeker("Kérem a háromszög B befogóját:");
            double szamol = Math.Pow(befogoA, 2) + Math.Pow(befogoB, 2);
            double atfogoC = Math.Sqrt(szamol);
            Console.WriteLine($"A három szög átfogója: {Math.Round(atfogoC, 4)}");
            Console.ReadKey();
            
        }

        private static double adatBeker(string v)
        {
            double adat;
            Console.Write(v);
            while (!double.TryParse(Console.ReadLine(), out adat))
            {
                Console.Write("Hibás adat!");
                Console.WriteLine(v);
            }
            return adat;
        }
    }
}
