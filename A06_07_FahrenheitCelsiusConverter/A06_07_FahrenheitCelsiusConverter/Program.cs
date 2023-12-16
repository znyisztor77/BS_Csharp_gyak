using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A06_07_FahrenheitCelsiusConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valaszt;
            Console.WriteLine("Hőmérsélet váltó.");
            Console.WriteLine("Válaszd ki miből szertnél átváltani.");
            Console.WriteLine("c (celsiusból->Fahrenheitbe, f (fahrenheitből-celsiusba).");

            do
            {
                valaszt = Console.ReadLine();

            } while (!(valaszt == "f" || valaszt == "c"));


            switch (valaszt)
            {

                case "c":
                    Console.WriteLine("Celsiusból Váltunk Fahrenheitbe!");
                    CelsiustoFahrenheit();
                    break;

                case "f":
                    Console.WriteLine("Fahrenheitből Váltunk Celsiusba!");
                    FahrenheittoCelsius();
                    break;

                default:
                    Console.WriteLine("Nem megfelő választás");
                    break;
            }

            Console.WriteLine("Nyomj meg egy billentyűt a kilépéshez.");
            Console.ReadKey();

        }


        private static void CelsiustoFahrenheit()
        {
            double celsius_beker;
            double fahr;
            Console.WriteLine("Kérem add meg az átváltandó celsius értéket:");

            while (!double.TryParse(Console.ReadLine(), out celsius_beker))
            {
                Console.WriteLine("Nem megfelelő bevitel!");
                Console.WriteLine("Kérem add meg az átváltandó celsius értéket:");
            }


            fahr = ((celsius_beker * 9) / 5) + 32;
            Console.WriteLine($"A megadott {celsius_beker}° celsius fok {Math.Round(fahr, 2)}° fahrenheit fok");


        }


        private static void FahrenheittoCelsius()
        {
            double cels;
            Console.WriteLine("Kérem add meg az átváltandó fahrenheit értéket:");
            double fahr_beker;
            while (!double.TryParse(Console.ReadLine(), out fahr_beker))
            {
                Console.WriteLine("Nem megfelelő adat!");
                Console.WriteLine("Kérem add meg az átváltandó fahrenheit értéket:");
            }


            cels = ((fahr_beker - 32) * 5) / 9;
            Console.WriteLine($"A megadott {fahr_beker}° fahrenheit fok {Math.Round(cels, 2)}° celsius fok");

        }
    
    }
}
