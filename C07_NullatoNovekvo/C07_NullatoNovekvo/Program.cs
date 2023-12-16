using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_NullatoNovekvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam;
            Console.WriteLine("Bekért szám növekvő sorrendben, mellette csökkenő.");
            szam = szamBeker("Kérek egy számot: ");
            szamKiir(szam);
            Console.ReadKey();
        }
        private static void szamKiir(int szam)
        {
            int i;
            int szamlalo = 0;


            for (i = szam; 0 <= i; i--)
            {

                szamlalo++;
                Console.WriteLine($"{szamlalo - 1}, {i}");

            }


        }

        private static int szamBeker(string v)
        {
            int szam;
            Console.Write(v);
            while (!int.TryParse(Console.ReadLine(), out szam))
            {
                Console.WriteLine("Nem megfelő bevitel");
                Console.Write(v);

            }
            return szam;
        }
    }
}
