using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces
{
    public class Eagle : Animal
    {
        public Eagle():base(FoodType.Oats,10) { }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("Flying");
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
