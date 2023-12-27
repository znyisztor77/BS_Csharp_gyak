using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A14_PenzKerekit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tittle2 = @" 
    _    _ _  _      __      _           _       _     
   / \  / | || |    / _| ___| | __ _  __| | __ _| |_   
  / _ \ | | || |_  | |_ / _ \ |/ _` |/ _` |/ _` | __|  
 / ___ \| |__   _| |  _|  __/ | (_| | (_| | (_| | |_ _ 
/_/   \_\_|  |_|   |_|  \___|_|\__,_|\__,_|\__,_|\__(_)";
            
            Console.WriteLine(tittle2);
            Console.WriteLine("Kerekítés 5ft-ra");
            double penz;
            penz = adatBeker("Kérem a kerekítendő összget: ");
            osszegKerekit(penz);
            Console.ReadKey();
        }

        private static void osszegKerekit(double penz)
        {
           
            double kerekitettOsszeg = Math.Round(penz / 5)*5;
            double maradekos = penz % 5;
            Console.WriteLine("Kerkitett összeg: "+kerekitettOsszeg);
            
        }

        private static double adatBeker(string v)
        {
            double adat;
            Console.Write(v);
            while (!double.TryParse(Console.ReadLine(), out adat))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hibás bevitel!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(v);

            }
            return adat;
        }
    }
}
