using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B25NagyobbKisebbOsztas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek két számot és a nyagyobb számot elosztom a kisebbikkel:");
            double szam1, szam2;
            szam1 = szambeker("Kérem az első számot: ");
            szam2 = szambeker("Kérem az második számot: ");
            osztas(szam1, szam2);
            Console.ReadKey();
        }
        private static void osztas(double szam1, double szam2)
        {
            double csere;
            double eredmeny;
            if (szam1 < szam2 && szam1 != 0 && szam2 != 0)
            {
                csere = szam2;
                szam2 = szam1;
                szam1 = csere;

            }
            else if (szam1 == 0 || szam2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nullával nem lehet osztani");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                Environment.Exit(0);

            }

            eredmeny = szam1 / szam2;
            Console.WriteLine($"A {szam1} / {szam2} = {Math.Round(eredmeny, 2)}");
        }

        private static double szambeker(string v)
        {
            Console.Write(v);
            double szam;
            while(!double.TryParse(Console.ReadLine(), out szam))
            {
                Console.WriteLine("Nem megfelő bevitel");
                Console.Write(v);

            }
            return szam;
        }
    }
}
