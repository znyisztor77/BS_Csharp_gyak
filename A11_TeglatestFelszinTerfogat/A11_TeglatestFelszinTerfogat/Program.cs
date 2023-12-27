using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_TeglatestFelszinTerfogat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aOldal;
            double bOldal;
            double cOldal;
            Console.WriteLine("Kérem add meg a téglatest oldalainak hosszát.");
            oldalBeker("Kérem az a oldal hosszát:");

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
