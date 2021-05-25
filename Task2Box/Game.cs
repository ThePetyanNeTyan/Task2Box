using System;
using System.Collections.Generic;
using System.Text;

namespace Task2Box
{
    class Game
    {
        private Player _playerOne;
        private Player _playerTwo;
        private Random _random = new Random();
        private int _randomNumber;

        public void Welcome()
        {
            Console.WriteLine("Для игры с человеком нажмите 1 против бота - любая цифра");
            var isParse = int.TryParse(Console.ReadLine(), out var result);
            if (isParse == false)
                throw new Exception("Вы ввели не цифру");

            if (result == 1)
            {
                CreatePlayers();
                GenerateRandomNumber();
                StartGame();
            }
            else
            {
                CreateComputerGame();
                GenerateRandomNumber();
                StartGame();
            }
        }
        private void CreatePlayers()
        {
            Console.Write("Player1: ");
            _playerOne = Player.CreatePlayer(Console.ReadLine());
            Console.Write("Player2: ");
            _playerTwo = Player.CreatePlayer(Console.ReadLine());
        }

        private void CreateComputerGame()
        {
            Console.Write("Player1: ");
            _playerOne = Player.CreatePlayer(Console.ReadLine());
            Console.Write("Player2: ");
            _playerTwo = Player.CreateComputer();
        }

        private int GenerateRandomNumber()
        {
            _randomNumber = _random.Next(12, 121);
            Console.WriteLine("Загаданное число " + _randomNumber);
            return _randomNumber;
        }

        private void StartGame()
        {
            while (_randomNumber > 0)
            {
                    Console.Write($"Ход игрока  {_playerOne} - ");
                    int chooseOne = _playerOne.MakeStep();
                    _randomNumber = _randomNumber - chooseOne;
                    Console.WriteLine(_randomNumber);
                if (_randomNumber <= 0)
                {
                    Console.WriteLine("Победил игрок " + _playerOne.ToString());
                    break;
                }

                    Console.Write($"Ход игрока  {_playerTwo} - ");
                    int chooseTwo = _playerTwo.MakeStep();                  
                    _randomNumber = _randomNumber - chooseTwo;
                    Console.WriteLine(_randomNumber);
                if (_randomNumber <= 0)
                {
                    Console.WriteLine("Победил игрок " + _playerTwo.ToString());
                    break;
                }
            }
        }
    }
}
