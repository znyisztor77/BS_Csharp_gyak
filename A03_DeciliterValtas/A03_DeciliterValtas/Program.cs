using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A03_DeciliterValtas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bekert_szam;
            Console.WriteLine("A decilitrerben beírt értéket átváltjuk hektoliterbe, literbe és centiliterbe.");
            bekert_szam = Szambekeres("Adja meg az átváltando értéket:");
            Atvaltas(bekert_szam);
        }
        private static void Atvaltas(double bekert_szam)

        /*1 liter = 1000 milliliter.
        1 liter = 100 centiliter.
        1 liter = 10 deciliter.
        1 liter = 0.1 dekaliter.
        1 liter = 0.01 hektoliter.
        1 liter = 0.001 kiloliter.*/
        {
            double hekto;
            double liter;
            double centi;
            double mili;

            liter = bekert_szam / 10;
            hekto = bekert_szam / 1000;
            centi = bekert_szam * 10;
            mili = bekert_szam * 100;

            Console.WriteLine($"{bekert_szam} deciliter \n\n{hekto} hektoliter \n{liter} liter \n{centi} centi10liter \n{mili} mililiter");
            Console.WriteLine("Nyomj meg egy billentyűt a kilépéshez!");
            Console.ReadKey();
        }

        private static double Szambekeres(string v)
        {
            double szam;
            Console.WriteLine(v);
            while (!double.TryParse(Console.ReadLine(), out szam))
            {
                Console.WriteLine("Nem megfelelő adat! Kérem próbálja újra.");
                Console.WriteLine(v);


            }

            return szam;
        }
    }
}
