using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[,] tomb = new byte[10, 20];

            for (int sor = 0; sor < tomb.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < tomb.GetLength(0); oszlop++)
                {
                    tomb[sor, oszlop] = 0;
                }
            }

            char merre = Convert.ToChar(Console.ReadLine());
            string holVagyok = Console.ReadLine();


            do
            {
                Console.Clear();
                for (int sor = 0; sor < tomb.GetLength(0); sor++)
                {
                    for (int oszlop = 0; oszlop < tomb.GetLength(1); oszlop++)
                    {
                        Console.Write(tomb[sor, oszlop]);
                    }
                    Console.WriteLine();
                }

                switch (merre)
                {
                    case 'f':
                        break;
                    case 'l':
                        Console.BackgroundColor = ConsoleColor.Black;
                        tomb[Convert.ToInt32(holVagyok.Split(',')[0]), Convert.ToInt32(holVagyok.Split(',')[1])] = 0;
                        Console.BackgroundColor = ConsoleColor.Green;
                        tomb[Convert.ToInt32(holVagyok.Split(',')[0])-1, Convert.ToInt32(holVagyok.Split(',')[1])] = 0;
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    default:
                        break;
                }
            } while (true);


        }
    }
}
