using System;
using System.Globalization;
using System.Linq;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson2904
{
    class Program
    {
        static void Main(string[] args)
        {
            Program solution = new Program();
            
            
            //solution.pifagor();

            //Console.WriteLine(solution.formula(1, 2, 3));

            //Formula one = new Formula();
            //Console.Write("Результат: ");
            //Console.WriteLine(one.result());

            //Formula two = new Formula(0, 3.2, 12);
            //Console.WriteLine(two.result());

            /*
            Console.WriteLine("Треугольник");
            Console.WriteLine();
            Console.Write("Введите высоту треугольника: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Введите символ для заполнения: ");
            char chr = char.Parse(Console.ReadLine());
            solution.triangle(h, chr);
            

            Console.WriteLine("Сравнение целых чисел");
            bool correctRead = false;   
            int x = 0, y = 0;
            do
            {
                try
                {
                    Console.WriteLine();
                    Console.Write("Введите число Х: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Введите число Y: ");
                    y = int.Parse(Console.ReadLine());
                    correctRead = true;
                }
                catch 
                {
                    Console.WriteLine("Ошибка ввода, повторите пожалуйста");

                }
            }
            while (!correctRead);
            

            solution.twoIntComp(x, y);
            */

            /*Console.WriteLine("Введите строку");
            string txt = Console.ReadLine();
            Console.WriteLine("Введите символ");
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine(percentChrToTXT(txt, c) + " %");*/

            //9
            /*string txt = args[0];
            char c = char.Parse(args[1]);
            Console.WriteLine(percentChrToTXT(txt, c) + " %");*/


            //10
            /*Console.WriteLine("Введите строку");
            string txt = Console.ReadLine();
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());
            Console.WriteLine(char.ToUpper(txt[0]) + txt.Substring(1));
            //alternate
            Console.WriteLine(txt.Substring(0, 1).ToUpper() + txt.Substring(1));*/

            //11
            /*int a, b, c;
            Console.WriteLine("Введите целые a, b, c");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a == b || b == c || a == c)
            {
                a += 5;
                b += 5;
                c += 5;
            }
            Console.WriteLine($"Получилось: {a}, {b}, {c}");*/

            //12
            /*int x = int.Parse(args[0]);
            IntArray Z = new IntArray(x);
            Z.IntArrayPrint();
            */






        }





        static double percentChrToTXT(string txt, char chr) 
        {
            int count = 0;
            int len = txt.Length;
            for (int i = 0; i < len; i++)
            {
                if (txt[i] == chr) count++;

            }

            double pCTT = count / Convert.ToDouble(len) * 100.0;
            return pCTT;
        }


        public void twoIntComp(int x, int y)
        {

            char Comp = '=';
            if (x > y) Comp = '>';
            else if (x < y) Comp = '<';
            Console.WriteLine("X "+ Comp + " Y");
        }
        
        public void triangle(int h, char chr)
        {
            for (int i = 1; i <= h; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(chr);
                }
            }
            
            for (int i = 1; i <= h; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= (h - i); j++)
                {
                    Console.Write(' ');
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(chr);
                }
            }
        }
        
        
        public void pifagor()
        {
            double catet1, catet2;
            Console.WriteLine("Введите два катета треугольника");
            catet1 = Convert.ToDouble(Console.ReadLine());
            catet2 = Convert.ToDouble(Console.ReadLine());
            double hypot = Math.Sqrt(catet1 * catet1 + catet2 * catet2);
            Console.WriteLine("Гипотенуза равна: " + hypot);

            Console.WriteLine("Введите катет и гипотенузу треугольника");
            catet1 = Convert.ToDouble(Console.ReadLine());
            hypot = Convert.ToDouble(Console.ReadLine());
            catet2 = Math.Sqrt(hypot * hypot - catet1 * catet1);
            Console.WriteLine("Второй катет равен: " + catet2);
        }
        public double formula(double a, double b, double f)
        {
            return (a + b - f / a) + f * a * a - (a + b) * (a + b);
        }
    
    }


    public class IntArray
    {

        int[] array;

        public IntArray(int len)
        {
            array = new int[len];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
                

        }
        public void IntArrayPrint()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
        }
    }



    public class Formula 
    {
        double a, b, f;
        public Formula()
        {
            Console.WriteLine("Введите a, b, f: ");
            do
            {
                Console.WriteLine("a не должно быть равно нулю"); 
                a = double.Parse(Console.ReadLine());
            }
            while (a == 0);
            b = Convert.ToDouble(Console.ReadLine());
            f = Convert.ToDouble(Console.ReadLine());

        }
        public Formula(double x, double y, double z)
        {

            Console.WriteLine("Получены данные: " + x + ", " + y + ", " + z);
            if (x == 0)
            { 
                Console.WriteLine("А = 0, недопустимое значение");
                
            }
            a = x;
            b = y;
            f = z;

        }
        public double result()
        {
            return (a + b - f / a) + f * a * a - (a + b) * (a + b);
        }
    }
}
