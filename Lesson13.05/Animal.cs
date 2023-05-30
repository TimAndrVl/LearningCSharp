using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13._05
{
    class Animal
    {
        private string TypeOfAnimal;
        public string Type
        {
            get { return TypeOfAnimal; }
        }

        private string NameOfAnimal;
        public string Name
        {
            get { return NameOfAnimal; }
            set { NameOfAnimal = value; }
        }

        private string VoiceOfAnimal;
        public string Voice
        {
            get { return VoiceOfAnimal; }
        }

        private string FoodOfAnimal;
        public string Food
        {
            get { return FoodOfAnimal; }
        }

        public Animal(string Type)
        {
            TypeOfAnimal = Type;
            switch (TypeOfAnimal)
            {
                case "Dog":
                    VoiceOfAnimal = "Gau";
                    FoodOfAnimal = "Meat";
                    break;
                case "Cat":
                    VoiceOfAnimal = "Mjau";
                    FoodOfAnimal = "Fish";
                    break;
                case "Mouse":
                    VoiceOfAnimal = "Pee-pee";
                    FoodOfAnimal = "Chease";
                    break;
            }

        }





    }
}
