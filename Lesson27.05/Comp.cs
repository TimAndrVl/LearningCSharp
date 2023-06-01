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
            bool stop = false;
            Random rnd = new Random();
            do
            {
                number = rnd.Next(8) + 1;
                if (GameField.fieldArray[number] == number) stop = true;
            }
            while (!stop);
            
            return number;
        }
    }
}
