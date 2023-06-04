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
            char keyPressed;
            Console.Write(this.Name + ", Ваш ход: ");
            do
            {
                var key2 = Console.ReadKey();
                keyPressed = key2.KeyChar;
            }
            while (keyPressed != '1' && keyPressed != '2' && keyPressed != '3'
                && keyPressed != '4' && keyPressed != '5' && keyPressed != '6'
                && keyPressed != '7' && keyPressed != '8' && keyPressed != '9');
            return int.Parse(keyPressed.ToString());
            
            //return int.Parse(Console.ReadLine());

        }

    }
}
