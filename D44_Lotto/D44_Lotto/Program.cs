using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D44_Lotto
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] lottoszamok;

            Console.WriteLine("Ötös lottó számok generálása!");
            Console.Write("Add meg hogy hány sorozatot szeretnél generálni: ");
            int db; 
           
            int.TryParse(Console.ReadLine(), out db);

            for (int i = 0; i < db; i++)
            {
            lottoszamok = lottoGeneral();
            lottoEllenorzes(lottoszamok);

                while((lottoEllenorzes(lottoszamok)))
                {                   
                    lottoszamok = lottoGeneral();
                }
                
                Console.WriteLine($"{lottoszamok[0]} {lottoszamok[1]} {lottoszamok[2]} {lottoszamok[3]} {lottoszamok[4]}");
            }
            
            
            Console.ReadKey();
        }

        

        public static bool lottoEllenorzes(int[] lottoszamok)
        {
            int i=0;
            int keres = lottoszamok[0];
            bool logic = false;
            while(i<lottoszamok.Length-1 && !logic)
            {
                i++;
                if (lottoszamok[i]== keres)
                {
                    logic = true;
                
                }
                else
                {
                    keres = lottoszamok[i];
                }

            }
            
            return logic;
        }



        public static int[] lottoGeneral()
        {
            int szamok;
            int[] lotto = new int[5];
            int i;
            
            for (i = 0; i < 5; i++)
            {
                szamok = rnd.Next(1,91);
                lotto[i] = szamok;
            }

            Array.Sort(lotto);
            
            return lotto;
        }
    }
}
