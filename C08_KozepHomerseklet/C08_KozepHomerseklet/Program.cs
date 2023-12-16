using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_KozepHomerseklet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Közép hőmérséklet ki számolás.");
            Console.WriteLine("Add meg a havi közép hőmérséleteket.");
            Console.WriteLine($"Az éves közép hőmérséklet {Math.Round(evesKozep(), 2)}");
            Console.ReadKey();
        }
        private static double evesKozep()
        {
            int db = 0;
            double kozep = 0;
            string[] honap = { "január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december" };

            do
            {

                for (int i = 0; i < honap.Length; i++)
                {

                    double szam = homersekletBeker($"{honap[i]} ?: ");
                    kozep = kozep + szam;

                }

                db++;
            } while (db == honap.Length);

            return kozep;
        }


        private static double homersekletBeker(string v)
        {
            Console.Write(v);
            double szam;
            while (!double.TryParse(Console.ReadLine(), out szam))
            {
                Console.WriteLine("Nem megfelelő bevitel");
                Console.Write(v);

            }
            return szam / 12;
        }
    }
}
