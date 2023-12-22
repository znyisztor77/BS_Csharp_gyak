using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A04_MilimeterValtas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal adat;
            Console.WriteLine("Miliméterben megadott érték váltása méterre,deciméterre, centiméterre és miliméterre.");
            adat = adatBeker("Kérem az átváltandó értéket: ");

            decimal meter = adat / 1000;
            decimal decimeter = adat / 100;
            decimal centimeter = adat / 10;
            Console.WriteLine($"{adat}mm {meter}m");
            Console.WriteLine($"{adat}mm {decimeter}dm");
            Console.WriteLine($"{adat}mm {centimeter}cm");
            Console.ReadKey();
        }

        private static decimal adatBeker(string v)
        {
            Console.Write(v);
            decimal adat;
            while(!decimal.TryParse(Console.ReadLine(), out adat))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hibás adat bevitel!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(v);
            }
            return adat;
        }
    }
}
