using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prim_szamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           int szam = adatBekeres();
           
            Kiiratás(szam);
            Console.WriteLine("\n Progranm vége!");
            Console.ReadKey();
        }

        private static int adatBekeres()
        {
            int szam = 0;
            Console.WriteLine("Kérek egy számot: ");
            while(!int.TryParse(Console.ReadLine(), out szam))
            {

                Console.WriteLine("Nem megfelelő bemeneti érték!!");
                Console.WriteLine("Kérek egy számot: ");

            }
            return szam;
        }

        private static void Kiiratás(int szam)
        {
            if (prime(szam))
            {
                Console.WriteLine($"{szam} prim szám");
            }
            else
            {
                Console.WriteLine($"{szam} Nem prim szám.");
            }
        }

        private static bool prime(int szam)
        {
            int osztokSzama = 0;
            for (int i = 1; i < szam; i++)
            {
                if (szam % i == 0)
                {
                    osztokSzama++;
                }
            }
            return (osztokSzama < 2 ? true : false);

            
        }
    }
}
