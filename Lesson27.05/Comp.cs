using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson27._05
{
    public class Comp : IPlayer
    {
        public string Name { get; set; } = "Computer";
        public char Figure { get; set; } = '0';
        public int Sequence { get; set; }

        public int Step()
        {
            int number;
            char c;
            //bool stop = false;

            Console.WriteLine("Ходит " + this.Name);

            Thread.Sleep(2500);

            do
            {
                //Random rnd = new Random();
                number = Program.rnd.Next(0, 9);
                c = Program.fieldArray[number];
                //if (c != 'X' && c != '0') stop = true;
            }
            while (c == 'X' || c == '0');

            return number + 1;
        }
    }
}
