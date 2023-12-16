using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_KetszamKozottiParos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam1;
            int szam2;
            Console.WriteLine("Két szám közötti páros számok");
            szam1 = szamBeker("Kérem az első számot: ");
            szam2 = szamBeker("Kérem a második számot: ");

            parosSzamok(szam1, szam2);
            Console.ReadKey();
        }
        private static void parosSzamok(int szam1, int szam2)
        {

            int i;
            int csere;
            if (szam1 > szam2)
            {
                csere = szam2;
                szam2 = szam1;
                szam1 = csere;


            }
            Console.WriteLine($"A {szam1} és {szam2} közötti páros számok:");
            for (i = szam1 + 1; i < szam2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" " + i);
                }
            }
        }

        private static int szamBeker(string v)
        {
            int szam;
            Console.Write(v);
            while(!int.TryParse(Console.ReadLine(), out szam))
            {
                Console.WriteLine("Nem megfelő bevitel!");
                Console.Write(v);
            }
            return szam;
        }
    }
}
