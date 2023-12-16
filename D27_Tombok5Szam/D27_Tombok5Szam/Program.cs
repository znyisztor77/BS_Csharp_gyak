using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D27_Tombok5Szam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int szam;
            int[] tomb;
            //szam = szamBeker("Kérek 5 számot");
            tomb = tombFeltolt();
            tombElemi(tomb);
            maximumKivalaszt(tomb);
            Console.ReadKey();
        }
        private static void maximumKivalaszt(int[] tomb)
        {
            int max;
            max = tomb[0];
            int i;
            for (i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
            }
            Console.WriteLine($"A tömb legnagyobb eleme a: {max}");
        }

        private static void tombElemi(int[] tomb)

        {
            Console.WriteLine("A tömb elemi: ");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
        }

        private static int[] tombFeltolt()
        {
            int db = 5;
            int[] tomb = new int[db];
            int i;

            for (i = 0; i < db; i++)
            {
                tomb[i] = szamBeker($"Kérem az {i+1}. feltöltendő számot: ");
            }

            return tomb;

        }


        private static int szamBeker(string v)
        {
            int szam;
            Console.Write(v);
            while (!int.TryParse(Console.ReadLine(), out szam))
            {
                Console.WriteLine("Hibás bevitel!");
                Console.Write(v);

            }

            return szam;
        }
    }
}
