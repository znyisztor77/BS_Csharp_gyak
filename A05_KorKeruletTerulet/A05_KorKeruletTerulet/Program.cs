using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace A05_KorKeruletTerulet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kör kerüler, terület számítása.");
            double sugar;
            sugar = sugarBeker("Kérem add meg kör sugarát: ");
            double kerulet = (2*sugar)*Math.PI;
            double terulet = (sugar * sugar) * Math.PI;
            Console.WriteLine($"A kör kerülete: {Math.Round(kerulet, 4)}");
            Console.Write($"A kör területe: {Math.Round(terulet, 4)}");
            Console.ReadKey();
        }

        private static double sugarBeker(string v)
        {
            double sugar;
            Console.Write(v);
            while(!double.TryParse(Console.ReadLine(),  out sugar))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hibás bevitel!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(v);

            }
            return sugar;
        }
    }
}
