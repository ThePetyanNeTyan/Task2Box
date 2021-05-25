using System;
using System.Collections.Generic;
using System.Text;

namespace Task2Box
{
    class Player
    {
        private Player(string name, bool isComputer)
        {
            Name = name;
            IsComputer = isComputer;
        }

        public string Name { get; }
        public bool IsComputer { get; }

        public static Player CreatePlayer(string name)
        {
            return new Player(name, false);
        }

        public static Player CreateComputer()
        {
            return new Player("Компьютер", true);
        }

        public int MakeStep()
        {
            if (IsComputer)
            {
                Random rnd = new Random();
                return rnd.Next(1, 5);
            }
            else
            {
                int i = 0;
                while (i > 4 || i <= 0)
                {
                    Console.WriteLine("Введите цифры от 1 до 4");
                    i = int.Parse(Console.ReadLine());
                }
                return i;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
