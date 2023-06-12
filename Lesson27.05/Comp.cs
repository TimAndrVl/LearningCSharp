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
        public string Name { get; } = "Computer";
        public char Figure { get; set; } = '0';
        public int Sequence { get; set; }

/*        public Comp()
        {
            if (s == 2) this.Figure = 'X'; 
        }*/

        public int Step()
        {
            int number;
            char c;
            bool stop = false;

            //Random rnd = new Random();
            do
            {
                Random rnd = new Random();
                number = rnd.Next(0, 9);
                c = GameField.fieldArray[number];
                if (c != 'X' && c != '0') stop = true;
            }
            while (!stop);

            Console.WriteLine("Ходит " + this.Name);

            Thread.Sleep(3000);

            return number + 1;
        }
    }
}
