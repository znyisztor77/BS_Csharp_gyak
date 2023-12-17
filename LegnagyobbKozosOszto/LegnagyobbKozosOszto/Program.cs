using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegnagyobbKozosOszto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szamElso;
            int szamMasodik;
            szamElso= szamBeker("Kérem az első számot: ");
            szamMasodik = szamBeker("Kérem a második számot: ");
            int lekerdez = legnagyobbKozosOszto(szamElso, szamMasodik);
            Console.WriteLine($"A legnagyobb közös osztó {lekerdez}");
            Console.ReadKey();

        }


        private static int legnagyobbKozosOszto(int seged_a, int seged_b)
        {

            while (seged_a != seged_b)
            {
                if (seged_a > seged_b)
                {
                    seged_a = seged_a - seged_b;
                }
                else
                {
                    seged_b = seged_b - seged_a;
                }

            }

            return seged_a;
        }

        private static int szamBeker(string v)
        {
            int szam;
            Console.WriteLine(v);
            while (!int.TryParse(Console.ReadLine() , out szam))
            {
                
                Console.WriteLine("Hibás adat!");               
                Console.WriteLine(v);
            }
            return szam;
        }
    }
}
