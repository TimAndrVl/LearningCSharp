using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Решения заданий по языку C# ");
            Console.WriteLine("1. Сумма архива");
            Console.WriteLine("2. Минимум-максимум");
            Console.WriteLine("3. Строка - символы");
            Console.WriteLine("4. Четные числа");
            Console.WriteLine("5. Нет");
            Console.WriteLine("6. Среднее из трех");
            Console.WriteLine("7. Имя и возраст");
            Console.WriteLine("8. Число слов в предложении");
            Console.WriteLine("9. Нет");
            int TaskNumber;
            string? ConRead;
            Program pro = new Program();
            do
            {
                Console.WriteLine();
                Console.Write("Введите номер задания: ");
                ConRead = Console.ReadLine();
                TaskNumber = Convert.ToInt32(ConRead);
                Console.WriteLine();
                
                switch (TaskNumber)
                {
                    case 1:
                        Task1 sumar = new Task1();
                        sumar.SumArr();
                        break;
                    case 2:
                        pro.MinMax();
                        break;
                    case 3:
                        Task3 Txt = new Task3();
                        Txt.ToChar();
                        break;
                    case 4:
                        pro.FiveNum();
                        break;
                    case 5:
                        Console.WriteLine("Еще не готово");
                        break;
                    case 6:
                        Task6 Sr3 = new Task6();
                        Sr3.Sr3();
                        break;
                    case 7:
                        Console.Write("Назовите свое имя: ");
                        string? name = Console.ReadLine();
                        Console.Write("Назовите свой возраст: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Task7 Hello_You = new Task7();
                        Hello_You.Name_Age(name, age);
                        break;
                    case 8:
                        Console.WriteLine("Введите предложение: ");
                        Task8 TXX = new Task8();
                        string? TextInput;
                        do TextInput = Console.ReadLine();
                        while (TextInput.Length == 0);//если введена пустая строка, повторный ввод
                        Console.WriteLine(TXX.Words(TextInput));
                        break;
                    case 9:
                        Console.WriteLine("Наибольшая общая подпоследовательность");
                        Console.WriteLine();
                        Console.WriteLine("Введите строку 1:");
                        string? str1 = Console.ReadLine();
                        Console.WriteLine("Введите строку 2:");
                        string? str2 = Console.ReadLine();
                        Console.WriteLine("Результат: " + Task9.MaxCommon(str1, str2));
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    default:
                        Console.WriteLine("Пока!");
                        break;
                }
            }
            while (TaskNumber < 9);


        }

        public void FiveNum() //задание 4
        {
            int[] arr = new int[5];

            Console.WriteLine("Введите 5 чисел");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Четные числа:");
            for (int i = 0; i < 5; i++)
            {
                if (arr[i] % 2 == 0) Console.WriteLine(arr[i]);
            }
        }

        public void SumArr() //задание 1
        {
            Console.Write("Input length of array: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write($"Input {i + 1} number: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < number; sum += arr[i++]) ;
            Console.WriteLine("Summ of numbers = " + sum);
        }
        public void MinMax() //задание 2
        {
            Console.WriteLine();
            Console.WriteLine("Задача2: минимальный и максимальный элементы массива");
            Console.WriteLine();
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; arr[i++] = rnd.Next(100)) ;
            for (int i = 0; i < arr.Length; Console.WriteLine(arr[i++])) ;
            int min = arr[0];
            int max = min;
            foreach (var item in arr)
            {
                if (item > max) max = item;
                if (item < min) min = item;
            }
            Console.WriteLine("минимальный элемент массива: " + min);
            Console.WriteLine("максимальный элемент массива: " + max);
            Console.WriteLine();
        }
    }
}