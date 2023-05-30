using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    static class Task9
    {
        public static string MaxCommon(string s1, string s2)
        {
            string SMax = "";
            //не доделано
            return SMax;
        }
    }
    internal class Task1
    {
        public void SumArr()
        {
            Console.WriteLine("Задача1: сумма элементов массива");
            Console.WriteLine(); 
            Console.Write("Размер массива: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write($"Введите {i + 1} элемент: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < number; sum += arr[i++]);
            Console.WriteLine("Сумма = " + sum);
        }
         
    }
    internal class Task3
    {
        public void ToChar()
        {
            Console.WriteLine("Задача3: вывод символов строки");
            Console.WriteLine(); 
            
            
            string Str_inp;
            do
            {
                Console.Write("Введите строку: ");
                Str_inp = Console.ReadLine();
            } 
            while (Str_inp.Length == 0);
            
            for (int i = 0; i < Str_inp.Length; i++) Console.WriteLine(Str_inp[i]);
            
        }
         
    }internal class Task6
    {
        public void Sr3()
        {
            double Sum3 = 0;
            Console.WriteLine("Задача 6: среднее из трех чисел");
            Console.WriteLine(); 
            Console.WriteLine("Введите три числа: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write((i + 1) + ": ");
                Sum3 += Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Среднее значение = " + Sum3 / 3);
        }
         
    }
    internal class Task7
    {
        public void Name_Age(string? N, int A)
        {
            Console.WriteLine();
            Console.WriteLine("Привет, " + N + "!");
            Console.WriteLine("Тебе " + A + " лет.");   
        }
         
    }
    internal class Task8
    {
        public int Words(string Texxt)
        {
            int W = 0; //счетчик слов
            int ch = 0; //индикатор разделителя
            char one_char; //переменная для преребора символов
            for (int i = 0; i < Texxt.Length; i++)
            {
                one_char = Texxt[i];
                if (one_char == ' ') //любое слово заканчивается пробелом, даже если есть знак препинания 
                {
                    ch = 0;
                }                                            
                else if (one_char != '-') //тире просто пропускаем. 
                                          //Если оно с пробелами - как пробел, если в слове - как слово, 
                                          //счетчик не меняется в обоих случаях
                {
                    if (ch == 0)
                    {
                        W++; //счетчик слов добавляется только когда после пробела начнутся буквы 
                        ch = 1; //индикатор переключается на 1, и пока не появится пробел, счетчик не добавляется 
                    }
                        
                }
            }
            return W;
        }
         
    }
}
