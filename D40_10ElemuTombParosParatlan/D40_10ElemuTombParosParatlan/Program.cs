using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D40_10ElemuTombParosParatlan
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int[] tomb = new int[10];
           
            tombElemi(tomb);
           
            tombParos(tomb);

            Console.ReadKey();
        }

        private static void tombElemi(int[] tomb)
        {
            int i;
            Console.WriteLine("A tömb elemei: ");
            for (i = 0; i < tomb.Length; i++)
            {
                tomb[i] = random.Next(1, 100);
                Console.Write(" " + tomb[i]);
            }
        }

        public static void tombParos(int[] tomb)
        {
            int db = 0;
            int paratlan = 0;

            for (int i = 0; i < tomb.Length; i++)
            {

                if (tomb[i] % 2 == 0)
                {

                    db++;
                }
                else
                {
                    paratlan++;
                }

            }
            Console.WriteLine($"\nA tömben {db} páros szám van.");
            Console.WriteLine($"A tömben {paratlan} páratlan szám van.");
        }
    }
}
