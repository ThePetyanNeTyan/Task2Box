using System;
using System.Collections.Generic;

namespace Task2Box
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для игры с человеком нажмите 1 для игры против компика нажмите любую цифру");
            int cpuOrHuman = int.Parse(Console.ReadLine());
            if (cpuOrHuman == 1)
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
                        int choose = int.Parse(Console.ReadLine());
                        while (choose > 4 || choose <= 0)
                        {
                            Console.WriteLine("Введите цифры от 1 до 4");
                            choose = int.Parse(Console.ReadLine());
                        }
                        random = random - choose;
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
            else                    //// игра против компика
            {
                Random randomize = new Random();
                int random = randomize.Next(12, 121);
                Console.WriteLine();
                Console.WriteLine();


                Console.WriteLine("Загаданное число " + random);     

                while (random != 0)
                {
                    int cpu = randomize.Next(1, 5);
                    Console.WriteLine("Загаданное число " + random);
                    Console.WriteLine("Введите число ");
                        int chooseVsCpu = int.Parse(Console.ReadLine());
                    while (chooseVsCpu > 4 || chooseVsCpu <= 0)
                    {
                        Console.WriteLine("Введите цифры от 1 до 4");
                        chooseVsCpu = int.Parse(Console.ReadLine());
                    }
                        random = random - chooseVsCpu;
                    Console.WriteLine(random);
                    if (random == 0)
                    {
                        Console.WriteLine("Победил челик");
                        break;
                    }
                    if (random == 4)
                    {
                        cpu = 4;
                    }
                    if (random == 3)
                    {
                        cpu = 3;
                    }
                    if (random == 2)
                    {
                        cpu = 2;
                    }
                    if (random == 1)
                    {
                        cpu = 1;
                    }
                    Console.WriteLine(" Ход компика " + cpu);
                    random = random - cpu;
                    if (random == 0)
                    {
                        Console.WriteLine("Победил компик");
                        break;
                    }

                }
            }
        }
    }
}
