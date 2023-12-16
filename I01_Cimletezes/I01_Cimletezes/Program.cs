using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01_Cimletezes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int osszeg;
            osszeg = osszegBeker("Kérem a címletezendő összeget:");
            Cimletezes(osszeg);
            Console.ReadKey();
        }
        public static void Cimletezes(int osszeg)
        {
            int[] cimletek = { 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5 };
            int darab;

            for (int i = 0; i < cimletek.Length; i++)
            {
                darab = osszeg / cimletek[i];

                Console.WriteLine($" A {cimletek[i]} cimletből {darab}db van.");

                osszeg = osszeg - (darab * cimletek[i]);

            }
            Console.WriteLine($"Kerekítési hiba: {osszeg}ft");
            Console.ReadKey();

        }

        public static int osszegBeker(string v)

        {
            Console.Write(v);
            int szam = 0;

            while (!int.TryParse(Console.ReadLine(), out szam))
            {
                Console.WriteLine("Nem mgefelelő bevitel");
                Console.Write(v);
            }

            return szam;
        }
    }
}
