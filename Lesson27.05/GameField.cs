using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27._05
{
    public class GameField
    {
        //public static char[] fieldArray;
        //public char winFig;
        public int endType;
        public static char[] fieldArray {get; set;}
        
        public GameField()
        {
            fieldArray = new char[9];
            //Console.WriteLine();
            //fieldArray = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //this.Print();
            //Console.WriteLine();
        }

        public void Reset()
        {
            Console.WriteLine();
            Console.WriteLine("Начали!");
            fieldArray = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            this.Print();
        }

        public void Print()
        {
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(fieldArray[i * 3 + j].ToString() + " ");
                }    
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void Put(int step, char fig)
        {
            fieldArray[step - 1] = fig;
            this.Print();
        }

        public bool StopGame(int step, char fig)
        {
            int figCounter = 0;
            this.endType = 1; //по-умолчанию 1 - выход с выигрышем. 0 - ничья

            //проверка строки
            for (int i = (step - 1) / 3 * 3; i < 3; i++) 
            {
                if (fieldArray[i] == fig) figCounter++;
            }
            if (figCounter == 3) return true;

            //проверка столбца
            figCounter = 0;
            for (int i = (step - 1) % 3; i < 9; i+=3) 
            {
                if (fieldArray[i] == fig) figCounter++;
            }
            if (figCounter == 3) return true;

            //если ход нечетный - проверка диагоналей
            if (step % 2 != 0)
            {
                figCounter = 0;
                for (int i = 0; i < 9; i+=4) 
                {
                    if (fieldArray[i] == fig) figCounter++;
                }
                if (figCounter == 3) return true;
            
                figCounter = 0;
                for (int i = 2; i < 7; i+=2) 
                {
                    if (fieldArray[i] == fig) figCounter++;
                }
                if (figCounter == 3) return true;
            }

            // если нет выигрышных ходов, проверка на заполнение поля
            foreach (char sym in fieldArray)
            {
                if (sym != 'X' && sym != '0') return false;
                // если хотя бы одна ячейка не заполнена,
                // продолжаем
            }
            this.endType = 0;

            return true;
        }

        

    }
}
