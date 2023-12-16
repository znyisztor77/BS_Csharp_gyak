using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_Ciklusok10_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 és 30 közötti páros számok:");
            for (int i = 10; i < 30; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" " + i);
                }

            }
            Console.ReadKey();
        }
    }
}
