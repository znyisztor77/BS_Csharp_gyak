using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04_HanyJegyuSzam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double szam1;
            Console.WriteLine("Állapítsuk meg, hogy hány jegyű a bekért szám.");
            szam1 = szamBeker("Kérek egy számot: ");
            Console.WriteLine($" A megadott szám {hanyj_Jegyu_szam(szam1)} szánjegyből áll.");
            Console.ReadKey();
        }
        private static double hanyj_Jegyu_szam(double szam1)
        {
            string szamjegy;
            int db;
            szamjegy = szam1.ToString();
            db = szamjegy.Length;

            return db;
        }

        private static double szamBeker(string v)
        {
            double szam;
           
            while (true)
            {
                try
                {
                    Console.Write(v);
                    szam = Convert.ToInt64(Console.ReadLine());
                    break;
                }
                catch
                {

                    Console.WriteLine("Nem megfelelő bevitel!");

                }
            }
            
            return szam;
        }
    }
}
