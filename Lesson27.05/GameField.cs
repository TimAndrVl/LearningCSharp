using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27._05
{
    public class GameField
    {
        public int endType;
        
        public GameField()
        {
        }

        public void Reset()
        {
            Console.WriteLine();
            Console.WriteLine("Начали!");
            Program.fieldArray = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            this.Print();
        }

        public void Print()
        {
            Console.WriteLine();
            for (int i = 2; i >= 0; i--)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Program.fieldArray[i * 3 + j].ToString() + " ");
                }    
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void Put(int step, char fig)
        {
            Program.fieldArray[step - 1] = fig;
            this.Print();
        }

        public bool StopGame(int step, char fig)
        {
            this.endType = 1; //по-умолчанию 1 - выход с выигрышем. 0 - ничья
            
            int win3(int a, int b, int c)
            {
                int figCounter = 0;
                for (int i = a; i < a + b; i+=c)
                    if (Program.fieldArray[i] == fig) figCounter++;
                return figCounter;
            }

            step--;
            //проверка строки
            if (win3((step) / 3 * 3, 3, 1) == 3) return true;

            //проверка столбца
            if (win3((step) % 3, 7, 3) == 3) return true;

            //если ход (-1) четный - проверка диагоналей
            if (step % 2 == 0)
            {
                if (win3(0, 9, 4) == 3) return true;
                if (win3(2, 5, 2) == 3) return true;
            }

/*            for (int i =  , j = 0; j < 3; i++, j++) 
            {
                if (Program.fieldArray[i] == fig) figCounter++;
            }
            if (figCounter == 3) return true;
*/
            //проверка столбца
 /*           figCounter = 0;
            for (int i = (step) % 3; i < 9; i+=3) 
            {
                if (Program.fieldArray[i] == fig) figCounter++;
            }
            if (figCounter == 3) return true;

            //если ход (-1) четный - проверка диагоналей
            if (step % 2 == 0)
            {
                figCounter = 0;
                for (int i = 0; i < 9; i+=4) 
                {
                    if (Program.fieldArray[i] == fig) figCounter++;
                }
                if (figCounter == 3) return true;
            
                figCounter = 0;
                for (int i = 2; i < 7; i+=2) 
                {
                    if (Program.fieldArray[i] == fig) figCounter++;
                }
                if (figCounter == 3) return true;
            }
 */

            // если нет выигрышных ходов, проверка на заполнение поля
                // если хотя бы одна ячейка не заполнена,
                // продолжаем
            foreach (char sym in Program.fieldArray)
                if (sym != 'X' && sym != '0') return false;

            this.endType = 0;
            return true;
        }

        

    }
}
