using System;
using System.Collections;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson27._05
{
    class Program
    {
        // здесь пытался определить переменные, которые используются
        // в разных классах проекта.
        // Не получалось, но теперь - да. Наверно не указывал имя класса,
        // или не определял объект, точно не помню.

        public static char[] fieldArray = new char[9];
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            int gameType = 0;
            string player1Name, player2Name = "Computer", winPlayer;
            int sequence = 0;
            int playerStep;
            char figureStep, keyChar2;
            string keysForPressed = "ДдLl";


            Console.WriteLine("Привет! Поиграем в крестики-нолики!");
            Console.WriteLine();

            Console.WriteLine("Выберите тип игры");
            Console.Write("1 - с компьютером, 2 - вдвоем: ");
            do
            {
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        gameType = 1;
                        break;
                    case '2':
                        gameType = 2;
                        break;
                }
            }
            while (gameType == 0);
            Console.WriteLine();
                
            Console.WriteLine();
            Console.Write("Первый игрок, введите Ваше имя: ");
            player1Name = Console.ReadLine();
            Console.WriteLine();

            if (gameType == 2)
            {
                Console.Write("Второй игрок, введите Ваше имя: ");
                player2Name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine(player1Name + 
                    ", знакомьтесь, второй игрок: " + player2Name);
                Thread.Sleep(3000);
            }

            Player P1 = new Player(player1Name);

            // здесь пытался создавать только один из объектов,
            // в зависимости от выбора - второй игрок, или компьютер.
            // Не получалось - дальше по тексту они не были видны

            // снял комментарии с блока switch,
            // появились ошибки в строках 123, 124 и далее
            /**/
            switch (gameType)
            {
                case 1:
                    Player P2 = new Player(player2Name);
                break;
                case 2:
                    Comp P3 = new Comp();
                break;
            }
            /**/

            //пришлось создавать оба объекта,
            //хотя используется только один

            //далее - рабочий вариант (закомментирован)
            
            /*
            Player P2 = new Player(player2Name);

            Comp P3 = new Comp();
            */

            GameField f1 = new GameField();

            // Собственно, партия игры, в цикле

            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write(player1Name + ", выберите очередность хода: 1 - Х, 2 - 0 или 3 - случайный выбор: ");
                do
                {
                    switch (Console.ReadKey().KeyChar)
                    {
                        case '1':
                            sequence = 1;
                            break;
                        case '2':
                            sequence = 2;
                            break;
                        case '3':
                            //Random rnd = new Random();
                            sequence = rnd.Next(1, 3);
                            break;
                    }
                }
                while (sequence == 0);
                
                switch (sequence) 
                {
                    case 1:
                        P1.Figure = 'X';
                        P2.Figure = '0';
                        P3.Figure = '0';
                        break;
                    default:
                        P1.Figure = '0';
                        P2.Figure = 'X';
                        P3.Figure = 'X';
                        break;
                }
                Console.WriteLine();

                f1.Reset();

                int i = 1;
                do
                {
                    if (sequence == i)
                    {
                        playerStep = P1.Step();
                        figureStep = P1.Figure;
                        winPlayer = P1.Name;
                    }
                    else
                    {
                        switch (gameType)
                        {
                            case 1:
                                playerStep = P3.Step();
                                figureStep = P3.Figure;
                                winPlayer = P3.Name;
                                break;
                            default:
                                playerStep = P2.Step();
                                figureStep = P2.Figure;
                                winPlayer = P2.Name;
                                break;
                        }
                    }
                    
                    f1.Put(playerStep, figureStep);
                    Console.WriteLine();

                    i %= 2;
                    i++;
                }
                while (!f1.StopGame(playerStep, figureStep));

                if (f1.endType == 0) Console.WriteLine("Ничья! Конец игры.");
                else Console.WriteLine("Поздравляю, " + winPlayer + "! Конец игры.");
                Console.WriteLine();

                Console.Write("Продолжим? Д/Н");
                keyChar2 = Console.ReadKey(false).KeyChar;
            }
            while (keysForPressed.Contains(keyChar2));
            
            Console.WriteLine();
            Console.WriteLine("Пока!");

        }
    }
}
