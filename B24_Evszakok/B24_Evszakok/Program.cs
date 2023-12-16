using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B24_Evszakok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //24. Olvassa be egy hónap számát, majd írja ki, hogy melyik évszakban van az adott hónap.

            Console.WriteLine("Melyik hónapra vagy kíváncsi?");
            Console.WriteLine("Irj be egy számot 1-12-ig,és meg mondom melyik évszakra esik.");
            int bekert_szam;
            bekert_szam = szamBekres("Kérem a hónap számát:");

            Console.WriteLine($"{bekert_szam}. hónapban {Evszakok(bekert_szam)} van.");
            Console.ReadKey();
        }
        private static int szamBekres(string v)
        {


            Console.WriteLine(v);
            int szam = 0;
            while (!int.TryParse(Console.ReadLine(), out szam) || szam > 12)
            {
                Console.WriteLine("Nem megfelelő bemenet!");
                Console.WriteLine(v);

            }
            return szam;
        }


        //12,1,2 tél, 3,4,5 tavasz, 6,7,8 nyár, 9,10,11 ősz
        private static string Evszakok(int bekert)
        {
            string[] evszakok = { "tél", "tavasz", "nyár", "ősz" };
            string evszak = "";

            if (bekert >= 3 && bekert < 6)
            {
                evszak = evszakok[1];
            }
            else if (bekert >= 6 && bekert < 9)
            {
                evszak = evszakok[2];
            }
            else if (bekert >= 9 && bekert < 12)
            {
                evszak = evszakok[3];
            }
            else
            {
                evszak = evszakok[0];
            }


            return evszak;
        }
    }
}
