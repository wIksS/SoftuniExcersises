using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces
{
    public class Fish  : Animal
    {
        public Fish() : base(FoodType.Wheat, 5) { }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {

        }
    }
}
