using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A15_SzamtaniKozep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Számtani közép számolás.");
            int szamElso;
            int szamMasodik;
            szamElso = szamBeker("Kérem az első számot: ");
            szamMasodik = szamBeker("Kérem a második számot: ");
            Console.WriteLine($"A két szám számtani közepe: {(szamElso+szamMasodik)/2}");
            Console.ReadKey();
        }

        private static int szamBeker(string v)
        {
            
            int szam;
            while (true)
            {
                Console.Write(v);
                try
                {
                    int.TryParse(Console.ReadLine(), out szam);
                    break;
                }
                catch
                {
                    Console.WriteLine("Hibás adat");
                }

            }
            return szam;
        }
    }
}
