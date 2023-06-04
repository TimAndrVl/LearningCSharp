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
            int sequence = 1;
            bool continueGame = true;
            
            Console.WriteLine("Привет! Поиграем?");
            ConsoleKeyInfo key2 = Console.ReadKey();   
            if (key2.KeyChar != 'y' && key2.KeyChar != 'l') return;
            
            
            Console.Write("Введите Ваше имя: ");
            //playerName = Console.ReadLine();
            Console.Write(playerName + ", будете ходить первым? 1/2");
            //sequence = int.Parse(Console.ReadLine());
            Player P1 = new Player(playerName, sequence);
            Comp P2 = new Comp();

            GameField f1 = new GameField();
            
            do
            {
                f1.Put(P1.Step(), P1.Figure);
                f1.Put(P2.Step(), P2.Figure);
            }
            while (!f1.StopGame());


        }
    }
}
