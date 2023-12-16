using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_Negyzetszamol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A program kiírja 1-20-ig a számokat és mellé a négyzetüket.");
            negyzet_Szamol(20);
            Console.ReadKey();
        }
        private static void negyzet_Szamol(int v)
        {
            int i;
            for (i = 1; i < v + 1; i++)
            {
                int negyzet;
                negyzet = i * i;
                Console.WriteLine($"A {i} négyzete {negyzet}. ");
            }
        }
    }
}
