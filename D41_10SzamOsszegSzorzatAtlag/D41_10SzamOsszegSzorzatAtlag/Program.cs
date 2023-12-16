using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D41_10SzamOsszegSzorzatAtlag
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] tomb = new int[10];

            
            tombElemei(tomb);
            tombOsszeg(tomb);
            tombSzorzata(tomb);
            tombAtlaga(tomb);
            Console.ReadKey();
        }

        private static void tombElemei(int[] tomb)
        {
            Console.WriteLine("A tömb elemi: ");
            for (int i = 0; i < 10; i++)
            {
                tomb[i] = rnd.Next(1, 100);
            }
            foreach (int i in tomb)
            {
                Console.Write(" "+i);
            }
        }

        public static void tombAtlaga(int[] tomb)
        {
            decimal atlag = 0;
            foreach (int i in tomb)
            {
                atlag += i;
            }
            Console.WriteLine($"A tömb átlaga: {atlag / tomb.Length}");
        }

        public static void tombSzorzata(int[] tomb)
        {
            decimal szorzat = tomb[0];
            for (int i = 0; i < tomb.Length; i++)
            {
                szorzat *= tomb[i];
            }


            Console.WriteLine($"A tomb szorzata: {szorzat}");
        }

        public static void tombOsszeg(int[] tomb)
        {
            int tombossszeg = 0;
            foreach (int i in tomb)
            {
                tombossszeg += i;
            }
            Console.WriteLine($"\nA tömb elemeinek összege: {tombossszeg}");

        }
    }
}
