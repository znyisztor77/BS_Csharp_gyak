using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01_Ciklusok10_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 és 20 közötti számok");
            for (int i = 11; i < 20; i++)
            {
                Console.Write(" " + i);
            }
            Console.ReadKey();
        }
    }
}
