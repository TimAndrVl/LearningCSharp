using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson27._05
{
    public class Player : IPlayer
    {
        public string Name { get; }
        public char Figure { get; set; } = '0';
        public int Sequence { get; set; }
        public Player(string name) 
        {
            this.Name = name;
        }
        public int Step()
        {
            char keyPressed;
            int keyNumber;
            bool stop = false;
            char c;

            Console.WriteLine();
            Console.Write(this.Name + ", Ваш ход: ");
            do
            {
                do
                {
                    var key2 = Console.ReadKey();
                    keyPressed = key2.KeyChar;
                }
                while (keyPressed != '1' && keyPressed != '2' && keyPressed != '3'
                    && keyPressed != '4' && keyPressed != '5' && keyPressed != '6'
                    && keyPressed != '7' && keyPressed != '8' && keyPressed != '9');

                keyNumber = int.Parse(keyPressed.ToString());
                c = GameField.fieldArray[keyNumber - 1];
                if (c != 'X' && c != '0') stop = true;
            }
            while (!stop);

            Console.WriteLine();

            return keyNumber;
            

        }

    }
}
