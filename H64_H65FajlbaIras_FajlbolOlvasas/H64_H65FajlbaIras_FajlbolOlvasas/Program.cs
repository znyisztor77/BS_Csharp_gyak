using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace H64_H65FajlbaIras_FajlbolOlvasas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fajlnev = "test.txt";
            string text = "Ez az első sor.\nEz a második sor.\nEz már a harmadik sor.\nEz a negyedik sor";
            string sor;
            List<string> szoveg = new List<string>();
            fajlbairas(fajlnev, text);
            fajbololvas(fajlnev, szoveg);
                      
            Console.ReadKey();

        }

        private static void fajbololvas(string fajlnev, List<string> szoveg)
        {
            Console.WriteLine("A fájlban levő szöveg: ");
            string sor;
            using (StreamReader reader = new StreamReader(fajlnev))
            {
                while ((sor = reader.ReadLine()) != null)
                {
                    szoveg.Add(sor);
                }
            }
           
            foreach (string listaszavak in szoveg)
            {
                Console.WriteLine(listaszavak);
            }
        }

        private static void fajlbairas(string fajlnev, string text)
        {
            using (StreamWriter writer = new StreamWriter(fajlnev))
            {
                writer.Write(text);
            }

        }
    }
}
