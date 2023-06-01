using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27._05
{
    class GameField
    {
        public static char[] fieldArray;
        public GameField()
        {
            Console.WriteLine("Начали!");
            Console.WriteLine();
            fieldArray = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            this.Print();
            Console.WriteLine();
        }

        public void Print()
        {
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

        public void Put(int step, char symbol)
        {
            fieldArray[step - 1] = symbol;
            this.Print();
        }

        public bool StopGame()
        {
            return false;
        }

        

    }
}
