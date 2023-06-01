using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27._05
{
    public class Player : IPlayer
    {
        public char Figure { get; set; } = '0';
        public string Name { get; set; }
        public Player(string name, int sqns) 
        {
            this.Name = name;
            if (sqns == 1) this.Figure = 'X';
        }
        public int Step()
        {
            Console.Write(this.Name + ", Ваш ход: ");
            return int.Parse(Console.ReadLine());

        }

    }
}
