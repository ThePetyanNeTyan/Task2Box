using System;
using System.Collections.Generic;

namespace Task2Box
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имена игроков");
            string[] players = new string[2];

            for (int i = 0; i < players.GetLength(0); i++)
            {
                Console.Write($"Введите имя игрока №{i + 1} - ");
                players[i] = Console.ReadLine();
            }
            Console.WriteLine("Таблица игроков:");
            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine($"Игрок №{i + 1} - " + players[i]);
            }

            Begin:

            Random randomize = new Random();
            int random = randomize.Next(12, 121);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Загаданное число " + random);

            while (random != 0)
            {
                for (int i = 0; i < players.GetLength(0); i++)
                {
                    Console.Write($"Ход игрока  {players[i]} - ");
                    random = random - int.Parse(Console.ReadLine());
                    Console.WriteLine(random);

                    if (random == 0)
                    {
                        Console.WriteLine("Победил игрок " + players[i]);
                        break;
                    }                    
                }
            }
            Console.WriteLine("Для повторной игры нажмите 1");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                goto Begin;
            }
        }
    }
}
