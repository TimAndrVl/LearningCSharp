using System;
using System.Collections;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson27._05
{
    class Program
    {
        
        public static char[] fieldArray = new char[9];
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            int gameType;
            string player1Name, player2Name = "Computer", winPlayer;
            int sequence;
            int playerStep;
            char figureStep, keyChar2;
            string keysForPressed = "ДдLl", keysForPressed1 = "12", keysForPressed123 = "123";
            Player P1, P2;
            Comp P3;
            IPlayer[] arr = new IPlayer[2];

            Console.WriteLine("Привет! Поиграем в крестики-нолики!");
            Console.WriteLine();

            Console.WriteLine("Выберите тип игры");
            Console.Write("1 - с компьютером, 2 - вдвоем: ");
            do keyChar2 = Console.ReadKey().KeyChar;
            while (!keysForPressed1.Contains(keyChar2));
            gameType = int.Parse(keyChar2.ToString());
            Console.WriteLine();
                
            Console.WriteLine();
            Console.Write("Первый игрок, введите Ваше имя: ");
            player1Name = Console.ReadLine();
            Console.WriteLine();
            arr[0] = new Player(player1Name);

            if (gameType == 2)
            {
                Console.Write("Второй игрок, введите Ваше имя: ");
                player2Name = Console.ReadLine();
                arr[1] = new Player(player2Name);
            }
            else
            {
                Console.WriteLine(player1Name + 
                    ", знакомьтесь, второй игрок: " + player2Name);
                Thread.Sleep(3000);
                arr[1] = new Comp();
            }
            

            GameField f1 = new GameField();

            // Собственно, партия игры, в цикле

            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write(player1Name + ", выберите очередность хода: 1 - Х, 2 - 0 или 3 - случайный выбор: ");
                do keyChar2 = Console.ReadKey().KeyChar;
                while (!keysForPressed123.Contains(keyChar2));
                sequence = int.Parse(keyChar2.ToString()) - 1;
                if (keyChar2 == '3') sequence = rnd.Next(2);
                
                arr[sequence].Figure = 'X';
                sequence = - --sequence;
                arr[sequence].Figure = '0';
                Console.WriteLine();

                f1.Reset();

                do
                {
                    sequence = - --sequence;

                    playerStep = arr[sequence].Step();
                    figureStep = arr[sequence].Figure;
                    
                    f1.Put(playerStep, figureStep);
                    Console.WriteLine();

                }
                while (!f1.StopGame(playerStep, figureStep));
                
                winPlayer =  arr[sequence].Name;
                 
                if (f1.endType == 0) Console.WriteLine("Ничья! Конец игры.");
                else Console.WriteLine("Поздравляю, " + winPlayer + "! Конец игры.");
                Console.WriteLine();

                Console.WriteLine("Продолжим? Д/Н");
                keyChar2 = Console.ReadKey(true).KeyChar;
            }
            while (keysForPressed.Contains(keyChar2));
            
            Console.WriteLine();
            Console.WriteLine("Пока!");

        }
    }
}
