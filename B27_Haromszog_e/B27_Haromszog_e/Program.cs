using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B27_Haromszog_e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a_oldal;
            int b_oldal;
            int c_oldal;

            Console.WriteLine("Kérem a háromszög oldalait:");
            
            a_oldal = szamBeker("a oldal: ");
           
            b_oldal = szamBeker("b oldal:" );
           
            c_oldal = szamBeker("c oldal: ");
            


            Szerkesztheto(a_oldal, b_oldal, c_oldal);
            // a = 2, b = 4, c = 8 nem
            // a = 5, b = 6, c = 10 igen
            // a = 3, b = 5, c = 1 nem
            // a = 6, b = 2, c = 3 nem
            Console.ReadKey();
        }

        private static int szamBeker(string v)
        {
            int szam;
            Console.Write(v);

            while(!int.TryParse(Console.ReadLine(),out szam))
            {
                Console.Write(v);
            }
            return szam;
        }

        private static void Szerkesztheto(int a_oldal, int b_oldal, int c_oldal)
        {
            if (a_oldal < b_oldal + c_oldal && b_oldal < a_oldal + c_oldal && c_oldal < a_oldal + b_oldal)
            {
                Console.WriteLine("A háromszög szerkeszthető!");
            }
            else
            {
                Console.WriteLine("A háromszög NEM szerkeszthető");
            }
        }

    }
}
