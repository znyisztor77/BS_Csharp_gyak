using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B23_NagyobbKisebbKivonas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam1;
            int szam2;
            szam1 = szamBeker("Kérek egy számot: ");
            szam2 = szamBeker("Kérek egy másik számot: ");
            KulonbsegEsCsere(szam1, szam2);
            Console.WriteLine($"A két szám különbsége: {KulonbsegEsCsere(szam1, szam2)}");
            Console.ReadKey();
        }
        private static int szamBeker(string v)
        {
            int szam;
            Console.WriteLine(v);
            while (!int.TryParse(Console.ReadLine(), out szam))
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nem megfelelő bevitel!");
                Console.ForegroundColor= ConsoleColor.Gray;
                Console.WriteLine(v);

            }
            return szam;
        }

        private static int KulonbsegEsCsere(int szam1, int szam2)
        {

            int csere;

            if (szam2 < szam1)
            {
                csere = szam2;
                szam2 = szam1;
                szam1 = csere;

            }
            return szam2 - szam1;
        }
    }
}
