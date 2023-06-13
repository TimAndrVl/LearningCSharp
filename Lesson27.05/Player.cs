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
            string keysForPressed = "123456789";
            char keyChar2;
            int keyNumber;
            //bool stop;
            char c;
            //ConsoleKeyInfo key2;

            Console.WriteLine();
            Console.Write(this.Name + ", Ваш ход: ");
            do
            {
                do keyChar2 = Console.ReadKey().KeyChar;
                while (!keysForPressed.Contains(keyChar2));

                keyNumber = int.Parse(keyChar2.ToString());
                c = Program.fieldArray[keyNumber - 1];
                //if (c != 'X' && c != '0') stop = true;
            }
            while (c == 'X' || c == '0');

            Console.WriteLine();

            return keyNumber;
            

        }

    }
}
