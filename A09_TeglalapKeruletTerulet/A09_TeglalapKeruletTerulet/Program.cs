using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A09_TeglalapKeruletTerulet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Téglalap kerület, terület számítása.");
            double aOldal;
            double bOldal;
            aOldal = sugarBeker("Kérem add meg a téglalap egyik oldalának hosszát: ");
            bOldal = sugarBeker("Kérem add meg a téglalap másik oldalának hosszát: ");
            double kerulet = 2*(aOldal+bOldal);
            double terulet = aOldal * bOldal;
            Console.WriteLine($"A négyzet kerülete: {Math.Round(kerulet, 2)}");
            Console.Write($"A négyzet területe: {Math.Round(terulet, 2)}");
            Console.ReadKey();
        }
        private static double sugarBeker(string v)
        {
            double oldal;
            Console.Write(v);
            while (!double.TryParse(Console.ReadLine(), out oldal))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hibás bevitel!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(v);

            }
            return oldal;
        }
    }
}
