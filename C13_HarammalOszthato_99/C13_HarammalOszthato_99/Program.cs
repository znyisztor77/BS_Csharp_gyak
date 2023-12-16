using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_HarammalOszthato_99
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("99-től viszafelé a 3-al osztható számok");

            int i;

            for (i = 99; i > 0; i--)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();
        }
    }
}
