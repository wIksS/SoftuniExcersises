using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Mammal : Animal
    {
        public Mammal(int years):base(years)
        {
            this.EatAmount = 55;
            Console.WriteLine("Mammal constructor");
        }

        public int EatAmount { get; set; }

        public void Eat()
        {
            Console.WriteLine("Mammal Eating");
        }

        public void MammalEat(int EatAmount)
        {
            Console.WriteLine(EatAmount);
            Console.WriteLine(this.EatAmount);
            Console.WriteLine(base.EatAmount);

            Eat();
            this.Eat();
            base.Eat();
        }
    }
}
