using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdtbekeresKonzolosGyakorlo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Készíts olyan konzolos alkalmazást, amely addig kér be adatokat, amíg nullát nem kap.
            '0' érték esetén kiírja az összes addig kapott szám összegét.

            pl.
            7
            5
            - 4.6
            - 2
            3.6
            0
            összegük: 9*/
            double szam;
            szam = szamBeker("Kérek egy számot(nulla kilépés): ");
            double osszeg = 0;

            while (szam != 0)
            {

                osszeg = osszeg + szam;
                szam = szamBeker("Kérek egy számot(nulla kilépés): ");

            }
            Console.WriteLine($"Ősszeg: {osszeg}");
            Console.ReadKey();
        }
    



        private static double szamBeker(string v)
        {
            double szam;
            Console.WriteLine(v);
            while (!double.TryParse(Console.ReadLine(), out szam))
            {
                Console.WriteLine("Hibás bevitel");
                Console.WriteLine(v);
            }

            return szam;
        }
    }
}
