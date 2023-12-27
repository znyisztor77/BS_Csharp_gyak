using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A08_NegyzetKeruletTerulet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Négyzet kerület, terület számítása.");
            double oldal;
            oldal = oldalBeker("Kérem add meg négyzet oldalhosszát: ");
            double kerulet = 4* oldal;
            double terulet = oldal * oldal;
            Console.WriteLine($"A négyzet kerülete: {Math.Round(kerulet, 2)}");
            Console.Write($"A négyzet területe: {Math.Round(terulet, 2)}");
            Console.ReadKey();
        }
        private static double oldalBeker(string v)
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
