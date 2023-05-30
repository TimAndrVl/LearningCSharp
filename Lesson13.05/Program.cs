using System;
using System.Collections.Generic;

namespace Lesson13._05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! Do you want to have pets?");
            if (Console.ReadLine() != "Yes")
            {
                Console.WriteLine("Ok. Googbye!");
                return;
            
            }
            
            List<Animal> Animals = new List<Animal>(3);
            string ReadString, Name, Voice, Food;
            Console.WriteLine("Type of your new animal: Cat, Dog or Mouse");
            bool correct = false;
            do
            {
                ReadString = Console.ReadLine();
                switch (ReadString)
                {
                    case "Dog":
                        correct = true;
                        break;
                    case "Cat":
                        correct = true;
                        break;
                    case "Mouse":
                        correct = true;
                        break;
                    default:
                        Console.WriteLine("This is not available");
                        break;
                }
            }
            while (!correct);

            Animal A1 = new Animal(ReadString);

            Console.Write("Yor new Animal is: ");
            Console.WriteLine(A1.Type);
            Console.Write("He say: ");
            Console.WriteLine(A1.Voice);
            Console.Write("He likes to eat: ");
            Console.WriteLine(A1.Food);

            Console.Write("We need to give him a name: ");

            //Console.WriteLine(A1.Name);

            /*A1.Type = "Cat";
            A1.Name = "Murka";
            A1.Voice = "Mjau";
            A1.Food = "Fish";

            Animal A2 = new Animal();
            A2.Type = "Dog";
            A2.Name = "Sharik";
            A2.Voice = "Gau";
            A2.Food = "Meat";

            Animal A3 = new Animal();
            A3.Type = "Mouse";
            A3.Name = "Mouse";
            A3.Voice = "Pee-pee";
            A3.Food = "Cheesу";

            Console.WriteLine("Animal one:");
            Console.WriteLine(A1.Type); 
            Console.WriteLine(A1.Name); 
            Console.WriteLine(A1.Voice);
            Console.WriteLine(A1.Food);

            Console.WriteLine("Animal two:");
            Console.WriteLine(A2.Type); 
            Console.WriteLine(A2.Name); 
            Console.WriteLine(A2.Voice);
            Console.WriteLine(A2.Food);

            Console.WriteLine("Animal three:");
            Console.WriteLine(A3.Type); 
            Console.WriteLine(A3.Name); 
            Console.WriteLine(A3.Voice);
            Console.WriteLine(A3.Food);
            */

        }
    }


    
}
