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
            aOldal =oldalBeker("Kérem az A oldal hosszát: ");
            bOldal = oldalBeker("Kérem az B oldal hosszát: ");
            cOldal = oldalBeker("Kérem az C oldal hosszát: ");
            Console.WriteLine($"A téglasest felszíne: {felszinSzamol(aOldal,bOldal,cOldal)}");
            Console.WriteLine($"A téglasest térfogata: {terfogatSzamol(aOldal, bOldal, cOldal)}");
            Console.ReadKey();
            

        }

        private static double felszinSzamol(double aOldal, double bOldal, double cOldal)
        {
            double felszin;
            felszin = (2*(aOldal*bOldal))+ (2 * (aOldal * cOldal))+ (2 * (bOldal * cOldal));
            return felszin;
        }

        private static double terfogatSzamol(double aOldal, double bOldal, double cOldal)
        {
            double terfogat;
            terfogat= aOldal*bOldal*cOldal;
            return terfogat;
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
