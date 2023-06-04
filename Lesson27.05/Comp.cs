using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27._05
{
    public class Comp : IPlayer
    {
        public char Figure { get; set; } = '0';
        public string Name { get; set; } = "Computer";
        
        public Comp()
        {
        }
        public int Step()
        {
            int number;
            bool stop;
            Random rnd = new Random();
            do
            {
                number = rnd.Next(9);
                char c = GameField.fieldArray[number];
                if (c == 'X' || c == '0') stop = false;
                else stop = true;
            }
            while (!stop);
            
            return number + 1;
        }
    }
}
