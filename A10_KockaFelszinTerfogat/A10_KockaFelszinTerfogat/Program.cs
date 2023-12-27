using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A10_KockaFelszinTerfogat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Négyzet felszín, térfogat számítása.");
            double oldal;
            oldal = sugarBeker("Kérem add meg négyzet oldalhosszát: ");
            double felszin = 6 * Math.Pow(oldal, 2);
            double terfogat = Math.Pow(oldal, 3);
            Console.WriteLine($"A négyzet felszine: {Math.Round(felszin, 2)}");
            Console.Write($"A négyzet térfogata: {Math.Round(terfogat, 2)}");
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
