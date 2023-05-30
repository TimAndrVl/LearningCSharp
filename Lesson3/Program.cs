using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int Age = 48;
            string Name = "Андрей";
            string Company;
            bool YesOrNot;
            double Weight;
            float TempOut = 15;
            bool GenderF = false;

            Console.WriteLine("Цикл for"); 
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Цикл while");
            int ii = 0;
            while (ii <= 20) Console.WriteLine(ii++);

            Console.WriteLine("Цикл do while");
            int do_i = 0;
            do
            {
                Console.WriteLine(do_i);
                do_i++;
            }
            while (do_i <= 20);
            */
            string? Phrase = "";
            char Separ = '!';
            Phrase.
            /*Console.WriteLine("Введите 4 слова");
            for (int i = 1; i <= 4; i++)
            {
                Phrase += Console.ReadLine();
                if (i != 4) Phrase += Separ;
            }
            Console.WriteLine(Phrase);
            */
            string Word;
            Phrase = "";
            Separ = '*';
            /*Console.WriteLine("Вводите слова по одному, закончив ввод пустой строкой");
            do
            {
                Word = Console.ReadLine();
                Phrase += Word;
                if (Word != "") Phrase += Separ;
            }
            while (Word != "");
            Console.WriteLine(Phrase);
            
            
            Console.WriteLine("Введите 5 слов");
            
            int i = 0;
            while (i != 5)
            {
                Word = Console.ReadLine();
                Phrase += Word;
                if (i != 4) Phrase += Separ;
                i++;
            }
            Console.WriteLine(Phrase);
            */
            
            Console.Write("Введите длину в метрах: ");
            double m = int.Parse(Console.ReadLine());
            double km = m / 1000;
            Console.WriteLine(m + " м = " + km + " км");
            
            
            Console.Write("Введите длину в метрах: ");
            double m = int.Parse(Console.ReadLine());
            double km = m / 1000;
            Console.WriteLine(m + " м = " + km + " км");

        }
    }
}
