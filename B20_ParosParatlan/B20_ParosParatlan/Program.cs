using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B20_ParosParatlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam;
            szam = szambeker("Kérek egy számot: ");
            paros_Paratalan(szam);
            Console.ReadKey();
        }
        private static void paros_Paratalan(int szam)
        {
            if (szam % 2 == 0)
            {
                Console.WriteLine("A szám páros.");
            }
            else
            {
                Console.WriteLine("A szám páratlan.");

            }
        }

        private static int szambeker(string v)
        {
            int szam;
            Console.WriteLine(v);
            while (!int.TryParse(Console.ReadLine(), out szam))
            {
                Console.WriteLine("Nem megfelelő bevitel!");
                Console.WriteLine(v);

            }
            return szam;
        }
    }
}
