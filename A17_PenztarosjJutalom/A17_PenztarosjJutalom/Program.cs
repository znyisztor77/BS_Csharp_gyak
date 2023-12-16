using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A17_PenztarosjJutalom
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double szam = szambeker("Kérem a napi bevételt!: ");
            Console.WriteLine($"A pénztáros napi jutalma: {Math.Round(szam / 100) * 5}ft");
            Console.ReadKey();

        }

        private static int szambeker(string v)
        {

            double szam;
            Console.Write(v);



            while (!double.TryParse(Console.ReadLine(), out szam))
            {
                Console.WriteLine("Nem megfelelő adatbevitel!");
                Console.Write(v);
            }
            return (int)szam;
           
        }
    }
}
