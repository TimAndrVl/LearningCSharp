using System;

namespace Lesson27._05
{
    enum result {tic, tac, toe}
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = "AV";
            int playerStep;
            bool first = true;
            bool continueGame = true;
            
            //Console.WriteLine("Привет! Поиграем?");
            //Console.Write("Введите Ваше имя: ");
            //playerName = Console.ReadLine();
            //Console.Write(playerName + ", будете ходить первым? 1/2");
            //first = int.Parse(Console.ReadLine());
            GameField f1 = new GameField();
            do
            {
                Console.Write(playerName + ", Ваш ход: ");
                playerStep = int.Parse(Console.ReadLine());
                f1.Step(playerStep, first);
                f1.GetWin(continueGame);
                first = !first;
            }
            while (continueGame);


        }
    }
}
