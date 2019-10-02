using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CA191002SR
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //SzazDolog("Zoli");
            //SzazDolog("*");

            int i = 0;
            while (i < 10)
            {
                int a = rnd.Next(2, 10);
                int b = rnd.Next(2, 10);
                int c = rnd.Next(2, 10);

                if(SzerkeszthetoE(a, b, c))
                {
                    double t = HaromSzogTerulet(a, b, c);
                    Console.WriteLine(
                        "az {0} {1} {2} oldalú hszög területe: {3,5 :0.00}",
                        a, b, c, t);
                    i++;
                }
            }


            Console.ReadKey();
        }

        private static bool SzerkeszthetoE(int a, int b, int c)
        {
            return (a + b) > c && (a + c) > b && (b + c) > a;
        }

        static double HaromSzogTerulet(int a, int b, int c)
        {
            double s = (a + b + c) / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }


        static void SzazDolog(string cucc)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.SetCursorPosition(
                    rnd.Next(Console.WindowWidth),
                    rnd.Next(Console.WindowHeight));

                Console.ForegroundColor = (ConsoleColor)rnd.Next(16);

                Console.Write(cucc);
                Thread.Sleep(100);
            }
        }
    }
}


//Függvény (Function)
//csinál valamit, és
//van viasszatérési értéke
//Eljárás (Procepure)
//csinál valamit, és
//NINCS viasszatérési értéke (void)
