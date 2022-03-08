using AbstractionAndInterfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces
{
    public class Crocodile : Animal
    {
        public Crocodile() : base(FoodType.Meat, 15) { }

        public override void Eat()
        {
            Console.WriteLine("Eating everything");
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }

        public void ScarePeople()
        {
            Console.WriteLine("Pa");
        }
    }
}
