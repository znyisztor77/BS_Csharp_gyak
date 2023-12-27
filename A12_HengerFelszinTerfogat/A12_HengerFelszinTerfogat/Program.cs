using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A12_HengerFelszinTerfogat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sugar;
            double magassag;
            sugar = adatBeker("Kérem a henger sugarát: ");
            magassag = adatBeker("Kérem a henger magasságát: ");
            felszinnszamol(sugar, magassag);
            terfogatszamol(sugar, magassag);
            Console.ReadKey();
        }

        private static void terfogatszamol(double sugar, double magassag)
        {
            double terfogat;
            terfogat = Math.PI*sugar*magassag;
            Console.WriteLine($"A henger térfogata: {Math.Round(terfogat, 2)}");
        }

        private static void felszinnszamol(double sugar, double magassag)
        {
            double felszin;
            felszin = 2* (Math.PI * sugar) * (sugar + magassag);
            Console.WriteLine($"A henger térfogata: {Math.Round(felszin , 2)}");
        }

        private static double adatBeker(string v)
        {
            double adat;
            Console.Write(v);
            while (!double.TryParse(Console.ReadLine(), out adat))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hibás bevitel!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(v);

            }
            return adat;
        }
    }
}
