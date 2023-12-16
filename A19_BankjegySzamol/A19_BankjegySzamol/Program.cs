using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_BankjegySzamol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem ad meg hogy melyik cimletből hány darab van");
            osszedAd();
            Console.ReadKey();
        }
        public static void osszedAd()
        {
            int[] cimletek = { 500, 1000, 2000, 5000, 10000, 20000 };
            int szamlalo = 0;
            int osszeg = 0;
            int darab;
            do
            {

                for (int i = 0; i < cimletek.Length; i++)
                {
                    Console.Write($"Hány darab van a {cimletek[i]} forintosbol?: ");

                    while (!int.TryParse(Console.ReadLine(), out darab))
                    {
                        Console.WriteLine("Nem memgfelelő bevitel, kérem a darab számot!");
                        Console.Write($"Hány darab van a {cimletek[i]} forintosbol?: ");

                    }
                    osszeg += darab * cimletek[i];

                }

                szamlalo++;

            }
            while ((szamlalo == cimletek.Length));
            Console.WriteLine($"\n A mai bevétel {osszeg}ft volt.");


        }
    }
}
