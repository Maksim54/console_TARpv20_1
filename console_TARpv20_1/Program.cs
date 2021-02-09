using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_TARpv20_1
{
    class Program
    {
        private static int c;

        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a={0},b={1}", m, b);
            double c = (2 * m) + (b / (11 * m)) - (13 * b);
            Console.WriteLine("c={0}", c.ToString());

            Random rnd = new Random();
            int hinne = rnd.Next(1, 5);
            Console.WriteLine("Hinne: {0}", hinne);
            Console.ReadLine();


            string tekst="?";
            switch (hinne)
            {
                case 1:tekst = "Õpi veel!";break;
                case 2: tekst = "Õpi natuke veel!"; break;
                case 3: tekst = "Rahuldav!"; break;
                case 4: tekst = "Hea!"; break;
                case 5: tekst = "Väga hea!"; break;
                default:
                    tekst = "Viga!";
                    break;
            }
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine(tekst);
            ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Click button,Meshok");
                nupp = Console.ReadKey();

            } while (nupp.Key != ConsoleKey.Backspace);

            Console.ReadLine();
            Console.WriteLine("Töö failidega:");
            string a;
            Console.WriteLine("Q-on vaja salvestada failisse");
            Console.WriteLine("N-on vaja lugeda failist");
            Console.WriteLine("E-Math");
            Console.WriteLine("F-Info about you");
            nupp = Console.ReadKey();
            if (nupp.Key==ConsoleKey.Q)
            {
                StreamWriter file = new StreamWriter(@"..\..\texsts.txt", true);
                file.WriteLine(hinne + " " + tekst);
                file.Close();
                a = hinne + " " + tekst;
                Console.WriteLine("Failisse oli salvestatud: {0}", a);
            }
            else if(nupp.Key==ConsoleKey.N)
            {
                Console.WriteLine("Failis on järgmine informatsion:");
                StreamReader failist = new StreamReader(@"..\..\texsts.txt");
                a = failist.ReadToEnd();
                Console.WriteLine(a);
            }
            else if (nupp.Key == ConsoleKey.F)
            {


            }
            else
            {
                Console.WriteLine("Puhkame");
            }
            Console.ReadLine();
        }
    }
}
