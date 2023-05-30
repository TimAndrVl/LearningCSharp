using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27._05
{
    class GameField
    {
        char[] fieldArray;
        char sign;
        public GameField()
        {
            fieldArray = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            this.Print();
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

        public void Step(int Stp, bool Sym)
        {
            if (Sym) sign = '+';
            else sign = '0';
            fieldArray[Stp - 1] = sign;
            this.Print();
        }

        public void GetWin(bool contG)
        {

        }

        

    }
}
