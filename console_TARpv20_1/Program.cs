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
        public void svobodnie_bileti(string[] args)
        {
            int[,] bumbers = new int[4, 7];
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            int[,] bumbers = new int[4, 7];
            for (int i = 0; i < bumbers.GetLength(0); i++)
            {
                for (int j = 0; j < bumbers.GetLength(1); j++)
                {
                    bumbers[i, j] = 0;
                    Console.Write(bumbers[i, j]);
                }
                Console.WriteLine();
            }
            do
            {
                Console.Write("Vali rida:");
                int rida = Convert.ToInt32(Console.ReadLine());
                Console.Write("vali koht");
                int koht = Convert.ToInt32(Console.ReadLine());
                if (bumbers[rida, koht] == 0)
                {
                    Console.WriteLine("Koht on vaba!");
                    bumbers[rida, koht] = 1;
                    for (int i = bumbers.GetLength(0) - 1; i >= 0; i--)
                    {
                        for (int j = 0; j < bumbers.GetLength(0); j++)
                        {
                            Console.Write(bumbers[i, j]);
                        }
                        Console.WriteLine();
                    }
                }
                nupp = Console.ReadKey();
            } while (nupp.Key != ConsoleKey.Escape);

            string[] texts = new string[4];
            for (int i = 0; i < texts.GetLength(0); i++)
            {
                Console.WriteLine("{0}-text", i.ToString());
                texts[i] = Console.ReadLine();
            }
            foreach (int item in texts)
            {
                Console.Write(item + " ");
            }


            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };//Создание списка в котором будет добавлено отдельное количество цифр
            Console.WriteLine(numbers[1]);
            foreach (int item in numbers)//Цикл foreach служит для циклического обращения к элементам коллекции, представляющей собой группу объектов.
            {
                Console.Write(item + " ");
            }
            //Пример с циклом for
            for (int i = 0; i < numbers.Length; i++)
            {
                ;
            }

            {
                int i = 0;
                Console.Write(numbers[i] + "_");

            }





            int a_ = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a_={0},b={1}", a_, b);
            double c = (2 * a_ + b) / (11 * a_ - 13 * b);
            Console.WriteLine("c={0}", c.ToString());

            Random rnd = new Random();
            int hinne = rnd.Next(1, 5);
            Console.WriteLine("Hinne: {0}", hinne);
            Console.ReadLine();


            string tekst = "?";
            switch (hinne)
            {
                case 1: tekst = "Õpi veel!"; break;
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
            Console.WriteLine("F-Info about you");
            nupp = Console.ReadKey();
            if (nupp.Key == ConsoleKey.Q)
            {
                StreamWriter file = new StreamWriter(@"..\..\texsts.txt", true);
                file.WriteLine(hinne + " " + tekst);
                file.Close();
                a = hinne + " " + tekst;
                Console.WriteLine("Failisse oli salvestatud: {0}", a);
            }
            else if (nupp.Key == ConsoleKey.N)
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
