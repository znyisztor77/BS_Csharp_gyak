using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D35_VeletlenszamTomb
{
    internal class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            int[] tomb;
            tomb = tombFeltolt();
            Console.WriteLine($"A tömben levő számok: ");
            tombTartalom(tomb);
            Console.WriteLine($"\nA tömbben levő számok átlaga: {atlagKiir(tomb)}");
            atlagotMeghalado(tomb, atlagKiir(tomb));
            Console.ReadKey();
        }
        private static void atlagotMeghalado(int[] tomb, int atlag)
        {
            Console.WriteLine("Az átlagnál nagyobb számok:");
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > atlag)
                {
                    Console.WriteLine(tomb[i]);
                }
            }
        }

        private static int atlagKiir(int[] tomb)
        {
            int i;
            int osszeg = 0;
            int atlag;
            for (i = 0; i < tomb.Length; i++)
            {
                osszeg = tomb[i] + osszeg;
            }
            atlag = osszeg / tomb.Length;

            return atlag;
        }

        private static void tombTartalom(int[] tomb)
        {
            int i;
            for (i = 0; i < tomb.Length; i++)
            {
                Console.Write(" " + tomb[i]);
            }
        }

        public static int[] tombFeltolt()
        {
            int i;
            int[] tomb = new int[10];


            for (i = 0; i < 10; i++)
            {
                tomb[i] = rand.Next(1, 100);
            }
            return tomb;
        }
    }
}
